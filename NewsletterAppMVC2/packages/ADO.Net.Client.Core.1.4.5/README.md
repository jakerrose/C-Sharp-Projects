Version History
===============

### 1.4.5

* Adding support for NET 7.0
* Removing support for .NET 4.6.1, bumping to .NET 4.6.2
* Updating to Microsoft.Bcl.AsyncInterfaces 7.0.0
* [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs) 
and [IDbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbObjectFactory.cs) have new methods
CreateDbDataSource for .NET 7.0 build

### 1.4.4

* Adding [IConnectionManager](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IConnectionManager.cs) as a getter property to the following objects
  * [DbProvider](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbProvider.cs)
  * [IDbProvider](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbProvider.cs)
  * [ISqlExecutor](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutor.cs)
   
### 1.4.3

* Adding build for .NET 6.0
* Updating to Microsoft.Bcl.AsyncInterfaces 6.0.0
* Removing builds for .NET 4.0 and 4.5
* [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs) 
and [IDbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbObjectFactory.cs) have new methods
CreateDbBatch and CreateDbBatchCommand
and CanCreateBatch Property for .NET 6.0 build

### 1.4.2.1

* Updating to ADO.Net.Client.Annotations 1.1.9.2
* [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs) 
and [IDbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbObjectFactory.cs) have new method CreatePermission
for .NET 4.0, 4.5, 4.6.1 builds

### 1.4.2

* Adding .Net 5.0 build
* Updating to Microsoft.Bcl.AsyncInterfaces 5.0.0 for .net 4.6.1 and
.net standard 2.0 builds
 
### 1.4.0

* Adding .Net 4.0 build
* Updating to ADO.Net.Client.Annotations 1.1.9.1

### 1.3.6.2

* [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) 
MapDbType now handles the char type
* [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) 
MapDbType now respects nullable types for mapping
* [Utilities](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/Utilities.cs) new function FindProperty
that takes in IEnumerable of Propertyinfo and string
and bool for matching on underscores

### 1.3.6.1

* [DataMapper](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DataMapper.cs) methods are now virtual
* [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) methods are now virtual
* [DbParameterBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterBuilder.cs) methods are now virtual

### 1.3.6

* GetXXX functions in [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs)  are now virtual
* GetDbCommand new overload that takes in an instance of [DbConnection](https://docs.microsoft.com/en-us/dotnet/api/system.data.common.dbconnection?view=netcore-3.1) and command timeout as integer
* GetDbCommand overload switching parameters and connection in signature

### 1.3.5.1

* Updating to ADO.Net.Client.Annotations 1.1.7
* [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) now properly mapping a value of enum by type code

### 1.3.5

* Updating to ADO.Net.Client.Annotations 1.1.6
* New Property MatchUnderscoreNames on [DataMapper](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DataMapper.cs)
indicates if column names have underscores separating words in the column name
* New Property MatchUnderscoreNames on [IDataMapper](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDataMapper.cs)
indicates if column names have underscores separating words in the column name

### 1.3.4.1

* Bug fix in [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) MapDbParameter correctly set size of parameter when property type is guid, but native database guid type is not supported
* [DbParameterBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterBuilder.cs) CreateParameter overload taking in value and [PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo?view=netcore-3.1) now throws exception if the property is ignored property

### 1.3.4

* [DbParameterBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterBuilder.cs) CreateParameters now honors IgnoreParameter attribute on a property

### 1.3.3

* [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) new method MapParameterName that takes in an instance of [PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo?view=netcore-3.1)
* [IDbParamaterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbParameterFormatter.cs) new method MapParameterName that takes in an instance of [PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo?view=netcore-3.1)

### 1.3.2.1

* Bug fix in [DataMapper](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DataMapper.cs) setting value for a nullable enum property in MapRecord

### 1.3.2

* [QueryBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/QueryBuilder.cs) is now an abstract class
  * CreateSQLQuery back to protected method
* New [QueryFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/QueryFactory.cs) static class

### 1.3.1

* [QueryBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/QueryBuilder.cs) CreateSQLQuery now a public method
* [IQueryBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IQueryBuilder.cs) new function CreateSQLQuery

### 1.3.0

* [SqlQuery](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/SqlQuery.cs) renamed from SQLQuery
* [QueryBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/QueryBuilder.cs) moved from ADO.Net.Client.Implementation
* [SqlQuery](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/SqlQuery.cs) moved from ADO.Net.Client.Implementation
* New class [DbParameterBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterBuilder.cs)
* IDbParameterUtility renamed to [IDbParameterBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbParameterBuilder.cs)
* Removing GetDbParameter overloads from [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs)
* Removing GetDbParameter overloads from [IDbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbObjectFactory.cs)
* New interface [IAdHocQueryBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IAdHocQueryBuilder.cs) for creating ad-hoc queries
* New interface [IStoredProcedureQueryBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IStoredProcedureQueryBuilder.cs) for creating stored procedure queries

### 1.2.0

* [ISqlExecutorAsync](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutorAsync.cs) adding two new methods
  * GetScalarValuesAsync
    * Returns an IEnumerable of values
  * GetScalarValuesStreamAsync for .Net 4.6.1 .Net Standard 2.0+ builds
    * Returns a single scalar streamed from a query
      * Intended to be implemented as an Iterator function
* [ISqlExecutorSync](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutorSync.cs) adding two new methods
  * GetScalarValues
    * Returns an IEnumerable of values
  * GetScalarValuesStream
    * Returns a single scalar streamed from a query
      * Intended to be implemented as an Iterator function
      
### 1.1.9.5

* [IDbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbObjectFactory.cs) restoring CanCreateDataAdapter .NET Standard 2.1+ builds
* [IDbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbObjectFactory.cs) restoring CanCreateCommandBuilder .NET Standard 2.1+ builds
* [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs) restoring CanCreateDataAdapter .NET Standard 2.1+ builds
* [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs) restoring CanCreateCommandBuilder .NET Standard 2.1+ builds

### 1.1.9.4

* [ISqlExecutorSync](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutorSync.cs) methods that take in DbParameter no longer require that parameter it's optional
* [ISqlExecutorAsync](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutorAsync.cs) methods that take in DbParameter no longer require that parameter it's optional
* [Utilities](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/Utilities.cs) GetProperty is now case insensitive
* [Utilities](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/Utilities.cs) new function GetPropertyInfoByDbField

### 1.1.9.3

* [ISqlExecutorSync](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutorSync.cs) methods that take in command timeout no longer require that parameter it's optional with a default value of 30
* [ISqlExecutorAsync](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutorAsync.cs) methods that take in command timeout no longer require that parameter it's optional with a default value of 30


### 1.1.9.2

* Adding ClearTransaction method to [IConnectionManager](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IConnectionManager.cs)

### 1.1.9.1

* Nullable enum set value fix in MapRecord

### 1.1.9

* Bug Fix in [DataMapper](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DataMapper.cs) don't attempt to map a property that wasn't in the [IDataRecord](https://docs.microsoft.com/en-us/dotnet/api/system.data.idatarecord?view=netcore-3.1) parameter

### 1.1.8

* [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) MapDbParameter now takes in an instance of DbParameter instead of IDbDataParameter
* [IDbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbParameterFormatter.cs) MapDbParameter now takes in an instance of DbParameter instead of IDbDataParameter
* [IConnectionManager](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IConnectionManager.cs) now has a read only property called Transaction of [DbTransaction](https://docs.microsoft.com/en-us/dotnet/api/system.data.common.dbtransaction?view=netcore-3.1)
* [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs) removing GetDbTransaction syc/async functions
* [IDbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbObjectFactory.cs) removing GetDbTransaction syc/async functions

### 1.1.7

* [IDataMapper](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDataMapper.cs) map methods now have generic constraint of class
* [IMultResultReaderSync](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IMultiResultReaderSync.cs) read methods now have generic constraint of class
* [IMultiResultReaderAsync](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IMultiResultReaderAsync.cs) read methods now have generic constraint of class

### 1.1.6.3

* Null check in [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs) GetDbCommand overload that takes in IEnumerable of DbParameter

### 1.1.6.2

* [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs) correcctly utilize DbParameters in GetDbCommand

### 1.1.6.1

* [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) MapDbType map ushort correctly to uint16

### 1.1.6

* [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) MapParameter now maps Parameter direction
* [IDbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbParameterFormatter.cs) now has method that maps an instance of PropertyInfo to ParameterDirection enum value
* [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) now has method that maps an instance of PropertyInfo to ParameterDirection enum value
* Intellisense updates

### 1.1.5

* [IQueryBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IQueryBuilder.cs) CreateSQLQuery now has optional parameter to clear 
  parameters and query text used to buld an instance of [ISqlQuery](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlQuery.cs)

### 1.1.4

* Adding **new** AddParameterRange overload to [IDbParameterUtility](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbParameterUtility.cs) that takes in a parameter array of objects
* Adding **new** Append overload to [IQueryBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IQueryBuilder.cs) that takes in a SQL string in a parameter array of objects
* Adding **new** append overload to [IQueryBuilder](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IQueryBuilder.cs) that takes in a parameter name and value

### 1.1.3

* IMultiResultReaderAsync now implements IAsyncDisposable for .NET Standard 2.1 and above

### 1.1.2

* GetScalarValue sync/async now returns T instead of object on following objects
  * [ISqlExecutor](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutor.cs)
  * IDbProvider
  * DbProvider
  * IAsynchronousClient
  * ISynchronousClient

### 1.1.1

* Adding **new** GetMultiResultReader async/sync on ISqlExectourSync/Async

### 1.1.0

* ISqlExecutorAsync .NET standard 2.1+ build executetransactednonquery/nonquery now take in a cancellation token
* DbObjectFactory now has constructors that don't require an instance of IDbParameterFormatter


### 1.0.9

* IDbParamaeterUtility now has Contains function that takes in an instance of DbParameter
* Updating to ADO.Net.Client.Annotations 1.1.2
* IDbObjectFactory new GetDbParameters function that takes in a param array of object
  and returns an IEnumerable of DbParameter
* IAsynchronousClient and ISynchronousClient GetScalarValue is now generic
* Utilities class adding new extension method to check if type is IEnumerable
* Utilites class making IsNullableGenericType an extension method
* Utilities class adding new extensions method on PropertyInfo[] to get a property by name with string value of the name

### 1.0.8

* Renaming ReadObjectList and ReadObjectEnumerable on IMultiResultReaderSync
  * Renamed to ReadObjects
  * Renamed to ReadObjectsStream
* Renaming ReadObjectListAsync and ReadObjectEnumerableAsync on IMultiResultReaderAsync
  * Renamed to ReadObjectsAsync
  * Renamed to ReadaObjectsStreamAsync
* Renaming GetDataObjectList and GetDataObjectEnumerable on ISqlExecutorSync
  * Renamed to GetDataObects
  * Renamed to GetDataObjectsStream
* Renaming GetDataObjectListAsync and GetDataObjectEnumerableAsync on ISqlExecutorAsync
  * Renamed to GetDataObjectsAsync
  * Renamed to GetDataObjectsStreamAsync
* Removing all async/sync functions from [Utilities](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/Utilities.cs), those functions are now in [IDataMapper](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDataMapper.cs)
* [ISqlExecutor](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutor.cs) GetScalarValue sync and async functions are now generic
* **New** Class [DataMapper](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DataMapper.cs)
* **New** Interface [IDataMapper](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDataMapper.cs)
* All instances of [DbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbObjectFactory.cs) constructors now take in an instance of [IDbParamaterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbParameterFormatter.cs)
* Removing dependency on [Microsoft.Extensions.DependencyModel](https://www.nuget.org/packages/Microsoft.Extensions.DependencyModel)
* Correctiing all references to #if NET472
* Updating to [Microsoft.Bcl.AsyncInterfaces](https://www.nuget.org/packages/Microsoft.Bcl.AsyncInterfaces/) 1.1.1
* Making DbObjectFactory.GetProviderFactory a static function
  * Removing API from [IDbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbObjectFactory.cs)

### 1.0.7

* Updating to ADO.Net.Client.Annotations 1.1.1
* Adding **new** [DbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/DbParameterFormatter.cs) class
* Updating [IDbParameterFormatter](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbParameterFormatter.cs) API
  * MapDbTye now takes in an instance of PropertyInfo
  * MapDbValue now takes in an instance PropertyInfo and object
  * **New** MapParameter
    * Takes in an IDbDataParameter for the purpose of mapping the object to data type, value, and other settings
* Adding .NET 4.5 and .NET 4.6.1 builds

### 1.0.6

* Setting default parameter direction to input in DbObjectFactory.GetDbParameter
* New dependency [ADO.Net.Client.Annotations](https://www.nuget.org/packages/ADO.Net.Client.Annotations/)
* IConnectionManager no longer chaining IConnectionStringUtility 
  
### 1.0.5

* Updating [ISqlExecutor](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutorAsync.cs) async methods to take in a bool that determines 
  if a query should be prepared
  * For .net standard 2.1+ and above

### 1.0.4

* Updating [ISqlExecutor](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/ISqlExecutorSync.cs) sync methods to take in a bool that determines if a query should be prepared

### 1.0.3
* Adding CanCreateDataAdapter and CanCreateCommandBuilder
  properties to [IDbObjectFactory](https://github.com/rgarrison12345/ADO.Net.Client/blob/master/src/ADO.Net.Client.Core/IDbObjectFactory.cs) 
    * For .NET Standard 2.1+ and above

### 1.0.0

* Initial Release