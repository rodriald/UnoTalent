namespace UnoTalent.Service.Mappers.Abstractions
{
    public abstract class IMapper<TEntity, PModel>
    {
        public abstract TEntity Map(PModel entity);

        public abstract PModel Map(TEntity entity);
    }
}
