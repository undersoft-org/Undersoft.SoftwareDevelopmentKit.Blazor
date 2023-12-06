using Undersoft.SDK.Blazor.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Undersoft.SDK.Blazor.Components;

public abstract class CrudDataService<TModel> : DataServiceBase<TModel> where TModel : class, new()
{
    public override Task<bool> AddAsync(TModel model) => Task.FromResult(true);

    public override Task<bool> DeleteAsync(IEnumerable<TModel> models) => Task.FromResult(true);

    public override Task<bool> SaveAsync(TModel model, ItemChangedType changedType) => Task.FromResult(true);

    public override Task<QueryData<TModel>> QueryAsync(QueryPageOptions option) => null;
}