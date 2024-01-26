﻿using Domain;
using Domain.Interfaces.Repository;
using Infrastructure.Repository;
using Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly Context Context;
        public IRepository<User> UserRepository { get;private set; }

        public IRepository<Product> ProductRepository { get; private set; }

        public IRepository<Permission> PermissionRepository { get; private set; }

        public IRepository<assessment_answers> assessment_AnswersRepo { get; private set; }
        public IRepository<assessment_questions> assessment_QuestionsRepo { get; private set; }
        public IRepository<assessment_questions_relation> assessment_Questions_RelationRepo{ get; private set; }

        public IRepository<Assessments> assessmentRepo { get; private set; }
        public IRepository<assessment_options> assessment_optionsRepo { get; private set; }
        public IRepository<assessment_meta> assessment_metaRepo { get; private set; }
        public IRepository<assessment_match> assessment_matchRepo{ get; private set; }

        public IRepository<assessment_enrols> assessment_enrolsRepo { get; private set; }
        public IRepository<assessment_data> assessment_dataRepo { get; private set; }
        public IRepository<assessment_department> assessment_departmentRepo { get; private set; }
        public IRepository<assessment_sections> assessment_sectionsRepo { get; private set; }

        public IRepository<assessment_text> assessment_textRepo { get; private set; }

        public IRepository<assessment_true_false> assessment_true_falseRepo { get; private set; }



        //public IRepository<User> Users => throw new NotImplementedException();

        public UnitOfWork(Context context) 
        {
            Context = context;
            UserRepository = new Repository<User>(Context);
            //ProductRepository = new Repository<Product>(Context);
            //PermissionRepository = new Repository<Permission>(Context);
            assessment_true_falseRepo = new Repository<assessment_true_false>(Context);
            assessment_sectionsRepo = new Repository<assessment_sections>(Context);
            assessment_textRepo = new Repository<assessment_text>(Context);
            assessment_Questions_RelationRepo = new Repository<assessment_questions_relation>(Context);
            assessment_QuestionsRepo = new Repository<assessment_questions>(Context);
            assessment_optionsRepo = new Repository<assessment_options>(Context);
            assessment_metaRepo = new Repository<assessment_meta>(Context);
            assessment_matchRepo = new Repository<assessment_match>(Context);
            assessment_enrolsRepo = new Repository<assessment_enrols>(Context);
            assessment_departmentRepo = new Repository<assessment_department>(Context);
            assessment_dataRepo = new Repository<assessment_data>(Context);
            assessment_AnswersRepo = new Repository<assessment_answers>(Context);
            assessmentRepo = new Repository<Assessments>(Context);
        }
        public void commit() 
        {
            try
            {
                Context.SaveChanges();
                //Context.Database.CurrentTransaction.Commit();
            }
            catch
            {
                Context.Database.CurrentTransaction.Rollback();
            }
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
