namespace BookStore.Data.Entities
{
    public interface IVersionedEntity
    {
        byte[] Version { get; set; }

    }
}

