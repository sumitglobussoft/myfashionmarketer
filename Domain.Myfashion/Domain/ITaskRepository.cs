﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Domain.Myfashion.Domain
{
    public interface ITaskRepository
    {
        void addTask(Tasks task);
        //int deleteTask(string taskid, Guid userid);
        int deleteTask(Guid taskid);
        void updateTask(Tasks task);
        ArrayList getAllTasksOfUser(Guid UserId,Guid GroupId);
        bool checkTaskExists(string taskid, Guid Userid);
        Tasks getTaskById(string Taskid, Guid userId);
        ArrayList getAllTasksOfUserByStatus(Guid UserId, bool status);
        void updateTaskStatus(Guid TaskId, Guid UserId, bool status);
        ArrayList getAllMyTasksOfUser(Guid AssignTo, Guid GroupId);
    }
}
