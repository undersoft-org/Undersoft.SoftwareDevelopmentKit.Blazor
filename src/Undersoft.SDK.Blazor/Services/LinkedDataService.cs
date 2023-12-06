namespace Undersoft.SDK.Blazor.Components;

using Undersoft.SDK.Service.Data.Repository;
using Uniques;

public class LinkedDataService<TModel> : DataServiceBase<TModel> where TModel : class, IUniqueIdentifiable, new()
{
    protected IRemoteRepository<IDataStore, TModel> _repository;

    public LinkedDataService(IRemoteRepository<IDataStore, TModel> repository) { _repository = repository; }

    public override Task<bool> AddAsync(TModel model) => Task.FromResult(true);

    public override Task<bool> DeleteAsync(IEnumerable<TModel> models) => Task.FromResult(true);

    public override Task<bool> SaveAsync(TModel model, ItemChangedType changedType) => Task.FromResult(true);

    public override Task<QueryData<TModel>> QueryAsync(QueryPageOptions option) => null;
}