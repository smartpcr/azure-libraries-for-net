// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.IndependentChild.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.Sql.Fluent.SqlElasticPool.Definition;
    using Microsoft.Azure.Management.Sql.Fluent.SqlElasticPool.Update;
    using Microsoft.Azure.Management.Sql.Fluent.Models;
    using System.Collections.Generic;
    using System;

    internal partial class SqlElasticPoolImpl 
    {
        /// <summary>
        /// Creates a new child resource under parent resource.
        /// </summary>
        /// <param name="existingParentResource">The parent resource under which this resource to be created.</param>
        /// <return>The creatable for the child resource.</return>
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.ICreatable<Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool> Microsoft.Azure.Management.ResourceManager.Fluent.Core.IndependentChild.Definition.IWithParentResource<Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool,Microsoft.Azure.Management.Sql.Fluent.ISqlServer>.WithExistingParentResource(ISqlServer existingParentResource)
        {
            return this.WithExistingParentResource(existingParentResource) as Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.ICreatable<Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool>;
        }

        /// <summary>
        /// Creates a new child resource under parent resource.
        /// </summary>
        /// <param name="groupName">The name of the resource group for parent resource.</param>
        /// <param name="parentName">The name of the parent resource.</param>
        /// <return>The creatable for the child resource.</return>
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.ICreatable<Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool> Microsoft.Azure.Management.ResourceManager.Fluent.Core.IndependentChild.Definition.IWithParentResource<Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool,Microsoft.Azure.Management.Sql.Fluent.ISqlServer>.WithExistingParentResource(string groupName, string parentName)
        {
            return this.WithExistingParentResource(groupName, parentName) as Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.ICreatable<Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool>;
        }

        /// <summary>
        /// Creates a new child resource under parent resource.
        /// </summary>
        /// <param name="parentResourceCreatable">A creatable definition for the parent resource.</param>
        /// <return>The creatable for the child resource.</return>
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.ICreatable<Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool> Microsoft.Azure.Management.ResourceManager.Fluent.Core.IndependentChild.Definition.IWithParentResource<Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool,Microsoft.Azure.Management.Sql.Fluent.ISqlServer>.WithNewParentResource(ICreatable<Microsoft.Azure.Management.Sql.Fluent.ISqlServer> parentResourceCreatable)
        {
            return this.WithNewParentResource(parentResourceCreatable) as Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.ICreatable<Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool>;
        }

        /// <summary>
        /// Specifies tags for the resource as a  Map.
        /// </summary>
        /// <param name="tags">A  Map of tags.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Definition.IWithCreate Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Definition.IDefinitionWithTags<SqlElasticPool.Definition.IWithCreate>.WithTags(IDictionary<string,string> tags)
        {
            return this.WithTags(tags) as SqlElasticPool.Definition.IWithCreate;
        }

        /// <summary>
        /// Adds a tag to the resource.
        /// </summary>
        /// <param name="key">The key for the tag.</param>
        /// <param name="value">The value for the tag.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Definition.IWithCreate Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Definition.IDefinitionWithTags<SqlElasticPool.Definition.IWithCreate>.WithTag(string key, string value)
        {
            return this.WithTag(key, value) as SqlElasticPool.Definition.IWithCreate;
        }

        /// <summary>
        /// Sets the maximum DTU any one SQL Azure Database can consume.
        /// </summary>
        /// <param name="databaseDtuMax">Maximum DTU any one SQL Azure Database can consume.</param>
        /// <return>The next stage of definition.</return>
        SqlElasticPool.Update.IUpdate SqlElasticPool.Update.IWithDatabaseDtuMax.WithDatabaseDtuMax(int databaseDtuMax)
        {
            return this.WithDatabaseDtuMax(databaseDtuMax) as SqlElasticPool.Update.IUpdate;
        }

        /// <summary>
        /// Sets the maximum DTU any one SQL Azure Database can consume.
        /// </summary>
        /// <param name="databaseDtuMax">Maximum DTU any one SQL Azure Database can consume.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Definition.IWithCreate SqlElasticPool.Definition.IWithDatabaseDtuMax.WithDatabaseDtuMax(int databaseDtuMax)
        {
            return this.WithDatabaseDtuMax(databaseDtuMax) as SqlElasticPool.Definition.IWithCreate;
        }

        /// <summary>
        /// Adds an existing database in the SQL elastic pool.
        /// </summary>
        /// <param name="databaseName">Name of the existing database to be added in the elastic pool.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Update.IUpdate SqlElasticPool.Update.IWithDatabase.WithExistingDatabase(string databaseName)
        {
            return this.WithExistingDatabase(databaseName) as SqlElasticPool.Update.IUpdate;
        }

        /// <summary>
        /// Adds the database in the SQL elastic pool.
        /// </summary>
        /// <param name="database">Database instance to be added in SQL elastic pool.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Update.IUpdate SqlElasticPool.Update.IWithDatabase.WithExistingDatabase(ISqlDatabase database)
        {
            return this.WithExistingDatabase(database) as SqlElasticPool.Update.IUpdate;
        }

        /// <summary>
        /// Creates a new database in the SQL elastic pool.
        /// </summary>
        /// <param name="databaseName">Name of the new database to be added in the elastic pool.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Update.IUpdate SqlElasticPool.Update.IWithDatabase.WithNewDatabase(string databaseName)
        {
            return this.WithNewDatabase(databaseName) as SqlElasticPool.Update.IUpdate;
        }

        /// <summary>
        /// Adds an existing database in the SQL elastic pool.
        /// </summary>
        /// <param name="databaseName">Name of the existing database to be added in the elastic pool.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Definition.IWithCreate SqlElasticPool.Definition.IWithDatabase.WithExistingDatabase(string databaseName)
        {
            return this.WithExistingDatabase(databaseName) as SqlElasticPool.Definition.IWithCreate;
        }

        /// <summary>
        /// Adds the database in the SQL elastic pool.
        /// </summary>
        /// <param name="database">Database instance to be added in SQL elastic pool.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Definition.IWithCreate SqlElasticPool.Definition.IWithDatabase.WithExistingDatabase(ISqlDatabase database)
        {
            return this.WithExistingDatabase(database) as SqlElasticPool.Definition.IWithCreate;
        }

        /// <summary>
        /// Creates a new database in the SQL elastic pool.
        /// </summary>
        /// <param name="databaseName">Name of the new database to be added in the elastic pool.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Definition.IWithCreate SqlElasticPool.Definition.IWithDatabase.WithNewDatabase(string databaseName)
        {
            return this.WithNewDatabase(databaseName) as SqlElasticPool.Definition.IWithCreate;
        }

        /// <summary>
        /// Sets the total shared DTU for the SQL Azure Database Elastic Pool.
        /// </summary>
        /// <param name="dtu">Total shared DTU for the SQL Azure Database Elastic Pool.</param>
        /// <return>The next stage of definition.</return>
        SqlElasticPool.Update.IUpdate SqlElasticPool.Update.IWithDtu.WithDtu(int dtu)
        {
            return this.WithDtu(dtu) as SqlElasticPool.Update.IUpdate;
        }

        /// <summary>
        /// Sets the total shared DTU for the SQL Azure Database Elastic Pool.
        /// </summary>
        /// <param name="dtu">Total shared DTU for the SQL Azure Database Elastic Pool.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Definition.IWithCreate SqlElasticPool.Definition.IWithDtu.WithDtu(int dtu)
        {
            return this.WithDtu(dtu) as SqlElasticPool.Definition.IWithCreate;
        }

        /// <summary>
        /// Sets the edition for the SQL Elastic Pool.
        /// </summary>
        /// <param name="edition">Edition to be set for elastic pool.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Definition.IWithCreate SqlElasticPool.Definition.IWithEdition.WithEdition(string edition)
        {
            return this.WithEdition(edition) as SqlElasticPool.Definition.IWithCreate;
        }

        /// <summary>
        /// Sets the storage limit for the SQL Azure Database Elastic Pool in MB.
        /// </summary>
        /// <param name="storageMB">Storage limit for the SQL Azure Database Elastic Pool in MB.</param>
        /// <return>The next stage of definition.</return>
        SqlElasticPool.Update.IUpdate SqlElasticPool.Update.IWithStorageCapacity.WithStorageCapacity(int storageMB)
        {
            return this.WithStorageCapacity(storageMB) as SqlElasticPool.Update.IUpdate;
        }

        /// <summary>
        /// Sets the storage limit for the SQL Azure Database Elastic Pool in MB.
        /// </summary>
        /// <param name="storageMB">Storage limit for the SQL Azure Database Elastic Pool in MB.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Definition.IWithCreate SqlElasticPool.Definition.IWithStorageCapacity.WithStorageCapacity(int storageMB)
        {
            return this.WithStorageCapacity(storageMB) as SqlElasticPool.Definition.IWithCreate;
        }

        /// <return>The information about databases in elastic pool.</return>
        System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase> Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.ListDatabases()
        {
            return this.ListDatabases() as System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase>;
        }

        /// <summary>
        /// Gets name of the SQL Server to which this elastic pool belongs.
        /// </summary>
        string Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.SqlServerName
        {
            get
            {
                return this.SqlServerName();
            }
        }

        /// <summary>
        /// Gets the edition of Azure SQL Elastic Pool.
        /// </summary>
        string Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.Edition
        {
            get
            {
                return this.Edition();
            }
        }

        /// <summary>
        /// Gets the maximum DTU any one SQL Azure database can consume.
        /// </summary>
        int Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.DatabaseDtuMax
        {
            get
            {
                return this.DatabaseDtuMax();
            }
        }

        /// <summary>
        /// Gets The total shared DTU for the SQL Azure Database Elastic Pool.
        /// </summary>
        int Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.Dtu
        {
            get
            {
                return this.Dtu();
            }
        }

        /// <summary>
        /// Gets the storage limit for the SQL Azure Database Elastic Pool in MB.
        /// </summary>
        int Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.StorageMB
        {
            get
            {
                return this.StorageMB();
            }
        }

        /// <return>The information about elastic pool activities.</return>
        System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.IElasticPoolActivity> Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.ListActivities()
        {
            return this.ListActivities() as System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.IElasticPoolActivity>;
        }

        /// <summary>
        /// Gets the specific database in the elastic pool.
        /// </summary>
        /// <param name="databaseName">Name of the database to look into.</param>
        /// <return>The information about specific database in elastic pool.</return>
        Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.GetDatabase(string databaseName)
        {
            return this.GetDatabase(databaseName) as Microsoft.Azure.Management.Sql.Fluent.ISqlDatabase;
        }

        /// <summary>
        /// Deletes the elastic pool from the server.
        /// </summary>
        void Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.Delete()
        {
 
            this.Delete();
        }

        /// <summary>
        /// Gets the creation date of the Azure SQL Elastic Pool.
        /// </summary>
        System.DateTime Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.CreationDate
        {
            get
            {
                return this.CreationDate();
            }
        }

        /// <summary>
        /// Gets the minimum DTU all SQL Azure Databases are guaranteed.
        /// </summary>
        int Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.DatabaseDtuMin
        {
            get
            {
                return this.DatabaseDtuMin();
            }
        }

        /// <return>The information about elastic pool database activities.</return>
        System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.IElasticPoolDatabaseActivity> Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.ListDatabaseActivities()
        {
            return this.ListDatabaseActivities() as System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.IElasticPoolDatabaseActivity>;
        }

        /// <summary>
        /// Gets the state of the Azure SQL Elastic Pool.
        /// </summary>
        string Microsoft.Azure.Management.Sql.Fluent.ISqlElasticPool.State
        {
            get
            {
                return this.State();
            }
        }

        /// <summary>
        /// Sets the minimum DTU all SQL Azure Databases are guaranteed.
        /// </summary>
        /// <param name="databaseDtuMin">Minimum DTU for all SQL Azure databases.</param>
        /// <return>The next stage of definition.</return>
        SqlElasticPool.Update.IUpdate SqlElasticPool.Update.IWithDatabaseDtuMin.WithDatabaseDtuMin(int databaseDtuMin)
        {
            return this.WithDatabaseDtuMin(databaseDtuMin) as SqlElasticPool.Update.IUpdate;
        }

        /// <summary>
        /// Sets the minimum DTU all SQL Azure Databases are guaranteed.
        /// </summary>
        /// <param name="databaseDtuMin">Minimum DTU for all SQL Azure databases.</param>
        /// <return>The next stage of the definition.</return>
        SqlElasticPool.Definition.IWithCreate SqlElasticPool.Definition.IWithDatabaseDtuMin.WithDatabaseDtuMin(int databaseDtuMin)
        {
            return this.WithDatabaseDtuMin(databaseDtuMin) as SqlElasticPool.Definition.IWithCreate;
        }
    }
}