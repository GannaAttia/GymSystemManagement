namespace GymSystemManagement.Entities
{
    public class Member : GymUser
    {
        public string? Photo { get; set; }
        public ICollection<MemberShip> MemberShipSupcription { get; set; } = default!;

    }
}
