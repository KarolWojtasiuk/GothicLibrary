namespace GothicLibrary
{
    public class Address
    {
        public Gothic1Address Gothic1Address { get; private set; }
        public Gothic2Address Gothic2Address { get; private set; }

        public Address(Gothic1Address Gothic1Address, Gothic2Address Gothic2Address)
        {
            this.Gothic1Address = Gothic1Address;
            this.Gothic2Address = Gothic2Address;
        }

        public Address(Gothic1Address Gothic1Address)
        {
            this.Gothic1Address = Gothic1Address;
        }

        public Address(Gothic2Address Gothic2Address)
        {
            this.Gothic2Address = Gothic2Address;
        }
    }

    public static class AddressList
    {
        private static Gothic1Address HERO_ATR_HITPOINTS_G1 = new Gothic1Address(0x4DBBB0, 0x184);
        private static Gothic2Address HERO_ATR_HITPOINTS_G2 = new Gothic2Address(0x4CECBC, 0x1B8);
        public static Address HERO_ATR_HITPOINTS = new Address(HERO_ATR_HITPOINTS_G1, HERO_ATR_HITPOINTS_G2);

        private static Gothic1Address HERO_ATR_HITPOINTS_MAX_G1 = new Gothic1Address(0x4DBBB0, 0x188);
        private static Gothic2Address HERO_ATR_HITPOINTS_MAX_G2 = new Gothic2Address(0x4CECBC, 0x1BC);
        public static Address HERO_ATR_HITPOINTS_MAX = new Address(HERO_ATR_HITPOINTS_MAX_G1, HERO_ATR_HITPOINTS_MAX_G2);

        private static Gothic1Address HERO_ATR_MANA_G1 = new Gothic1Address(0x4DBBB0, 0x18C);
        private static Gothic2Address HERO_ATR_MANA_G2 = new Gothic2Address(0x4CECBC, 0x1C0);
        public static Address HERO_ATR_MANA = new Address(HERO_ATR_MANA_G1, HERO_ATR_MANA_G2);

        private static Gothic1Address HERO_ATR_MANA_MAX_G1 = new Gothic1Address(0x4DBBB0, 0x190);
        private static Gothic2Address HERO_ATR_MANA_MAX_G2 = new Gothic2Address(0x4CECBC, 0x1C4);
        public static Address HERO_ATR_MANA_MAX = new Address(HERO_ATR_MANA_MAX_G1, HERO_ATR_MANA_MAX_G2);

        private static Gothic1Address HERO_ATR_STRENGTH_G1 = new Gothic1Address(0x4DBBB0, 0x194);
        private static Gothic2Address HERO_ATR_STRENGTH_G2 = new Gothic2Address(0x4CECBC, 0x1C8);
        public static Address HERO_ATR_STRENGTH = new Address(HERO_ATR_STRENGTH_G1, HERO_ATR_STRENGTH_G2);

        private static Gothic1Address HERO_ATR_DEXTERITY_G1 = new Gothic1Address(0x4DBBB0, 0x198);
        private static Gothic2Address HERO_ATR_DEXTERITY_G2 = new Gothic2Address(0x4CECBC, 0x1CC);
        public static Address HERO_ATR_DEXTERITY = new Address(HERO_ATR_DEXTERITY_G1, HERO_ATR_DEXTERITY_G2);

        private static Gothic1Address HERO_ATR_REGENERATEHP_G1 = new Gothic1Address(0x4DBBB0, 0x19C);
        private static Gothic2Address HERO_ATR_REGENERATEHP_G2 = new Gothic2Address(0x4CECBC, 0x1D0);
        public static Address HERO_ATR_REGENERATEHP = new Address(HERO_ATR_REGENERATEHP_G1, HERO_ATR_REGENERATEHP_G2);

        private static Gothic1Address HERO_ATR_REGENERATEMANA_G1 = new Gothic1Address(0x4DBBB0, 0x1A0);
        private static Gothic2Address HERO_ATR_REGENERATEMANA_G2 = new Gothic2Address(0x4CECBC, 0x1D4);
        public static Address HERO_ATR_REGENERATEMANA = new Address(HERO_ATR_REGENERATEMANA_G1, HERO_ATR_REGENERATEMANA_G2);

    }
}