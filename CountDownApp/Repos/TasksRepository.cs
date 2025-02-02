using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;
using CountDownApp.Models;

namespace CountDownApp.Repos
{
  internal class TasksRepository
  {
    private const string TaskFilePath = "tasks.json";
    private string tempPath = null;
    private string tempFile = null;

    public TasksRepository()
    {
      this.tempPath = Path.GetTempPath();

      Console.WriteLine("Temporary files directory: " + tempPath);

      // Example: Creating a temporary file
      this.tempFile = Path.Combine(tempPath, TaskFilePath);

      Console.WriteLine("Temporary file created at: " + tempFile);
    }

    public string SerializeToJson<T>(T obj)
    {
      using (var memoryStream = new MemoryStream())
      {
        var serializer = new DataContractJsonSerializer(typeof(T));
        serializer.WriteObject(memoryStream, obj);
        return Encoding.UTF8.GetString(memoryStream.ToArray());
      }
    }

    public T DeserializeFromJson<T>(string jsonString)
    {
      using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
      {
        var serializer = new DataContractJsonSerializer(typeof(T));
        return (T)serializer.ReadObject(memoryStream);
      }
    }

    public bool WriteTask(BindingList<Task> tasks)
    {
      try
      {
        File.WriteAllText(tempFile, this.SerializeToJson<BindingList<Task>>(tasks));
      }
      catch (Exception ex)
      {
        return false;
      }
      return true;
    }

    public BindingList<Task> GetTasks()
    {
      try
      {
        var json = File.ReadAllText(tempFile);
        var tasks = this.DeserializeFromJson<BindingList<Task>>(json);
        return tasks;
      }
      catch (Exception)
      {
        return new BindingList<Task>() {
        new Task { Name="new Task.."}
        };
      }
    }
  }
}