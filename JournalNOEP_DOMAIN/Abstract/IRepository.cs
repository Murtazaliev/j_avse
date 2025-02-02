﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalNOEP_DOMAIN
{
    public interface IRepository
    {
        IQueryable<Articles> Articles { get; }
        IQueryable<DataArticleAuthors> DataArticleAuthors { get; }
        IQueryable<DataEdition> DataEdition { get; }
        IQueryable<DataYear> DataYear { get; }
        IQueryable<SprJoiurnalAuthors> SprJoiurnalAuthors { get; }
        IQueryable<DataInfo> DataInfo { get; }

        #region |-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-[  Универсальные методы CRUD  ]-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|-=|=-|

        void Insert<TEntity>(TEntity entity) where TEntity : class;
        void Inserts<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
        void Update<TEntity>(TEntity entity) where TEntity : class;
        void Delete<TEntity>(TEntity entity) where TEntity : class;

        #endregion
    }
}
