using System;

public interface IDateTime
{
  DateTime Now { get; }
}


public interface Record
{
  int Id { get; set; }
  int userId { get; set; }
  string userName { get; set; }
  DateTime? createDateTime { get; set; }
  string countValue { get; set; }
}