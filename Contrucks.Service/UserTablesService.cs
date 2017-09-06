﻿using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Repository.Infrastructure;
using Contrucks.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Service
{
    public class UserTablesService : UserTablesService.IUserTablesService
    {
        private readonly IUserTablesRepository usertableRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserTablesService(IUserTablesRepository usertableRepository, IUnitOfWork unitOfWork)
        {
            this.usertableRepository = usertableRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Recentpostviewmodel> GetAllCustomers()
        {
            return usertableRepository.GetAll();
        }

        public void AddUser(UserTables usertables)
        {
            usertableRepository.Add(usertables);
            unitOfWork.Commit();
        }

        IEnumerable<UserTables> IUserTablesService.GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public interface IUserTablesService
        {
            IEnumerable<UserTables> GetAllCustomers();
            void AddUser(UserTables usertables);
        }

    }
}
