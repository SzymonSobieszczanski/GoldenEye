﻿using Backend.Core.Repository;
using Backend.Business.Entities;
using Backend.Business.Context;

namespace Backend.Business.Repository
{
    public class TaskRepository: RepositoryBase<Task>, ITaskRepository
    {
        public TaskRepository(ITHBContext context): base(context, context.Tasks)
        {
        }

    }
}