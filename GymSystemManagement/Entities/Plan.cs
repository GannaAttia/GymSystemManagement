namespace GymSystemManagement.Entities
{
    public class Plan :BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public int DurationDays { get; set; }
        public bool IsActive { get; set; }
        public ICollection<MemberShip> PlanSubscription { get; set; } = default!;
    }
}
