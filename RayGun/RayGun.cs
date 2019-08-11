namespace RayGun
{
    public class Raygun
    {

        private int ammo = 5;

        public void FireAt(Bug bug)
        {
            if (HasAmmo())
            {
                if (bug.IsDodging())
                {
                    bug.Miss();
                }
                else
                {
                    bug.Hit();
                }
                ammo--;
            }
        }

        public void Recharge()
        {
            ammo = 5;
        }

        public bool HasAmmo()
        {
            return ammo > 0;
        }
    }
}
