using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace CountDownApp.Models
{
  [DataContract]
  internal class Task
  {
    [DataMember]
    public Guid TaskId { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember]
    private int _NoOfPomodorrowsReq;

    public int NoOfPomodorrowsReq
    {
      get { return _NoOfPomodorrowsReq; }
      set
      {
        _NoOfPomodorrowsReq = value;
          this.NoOfPomodorrowPending = value;
      }
    }

    [DataMember]
    public int NoOfPomodorrowPending { get; set; }

    public Task()
    {
      this.TaskId = Guid.NewGuid();
      this.NoOfPomodorrowsReq = 1;
    }
  }
}