using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlchemistNPC.Projectiles
{
	public class NyctosythiaBullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nyctosythia Bullet");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;        //The recording mode
		}
		
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Bullet);
			projectile.timeLeft = 300;
			aiType = ProjectileID.Bullet;
		}
		
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Main.PlaySound(SoundID.NPCDeath52.WithVolume(.3f), projectile.position);
			Vector2 vel = new Vector2(0, -1);
			float rand = Main.rand.NextFloat() * 6.283f;
			vel = vel.RotatedBy(rand);
			vel *= 12f;
			Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel.X, vel.Y, mod.ProjectileType("NyctosyphiaBeam"), projectile.damage/4, 0, Main.myPlayer);
			Vector2 vel2 = new Vector2(0, -1);
			vel2 = vel.RotatedBy(rand);
			vel2 *= 12f;
			Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel2.X, vel2.Y, mod.ProjectileType("NyctosyphiaBeam"), projectile.damage/4, 0, Main.myPlayer);
			Vector2 vel3 = new Vector2(0, -1);
			vel3 = vel.RotatedBy(rand);
			vel3 *= 12f;
			Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel3.X, vel3.Y, mod.ProjectileType("NyctosyphiaBeam"), projectile.damage/4, 0, Main.myPlayer);
			Vector2 vel4 = new Vector2(0, -1);
			vel4 = vel.RotatedBy(rand);
			vel4 *= 12f;
			Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel4.X, vel4.Y, mod.ProjectileType("NyctosyphiaBeam"), projectile.damage/4, 0, Main.myPlayer);
			return true;
		}
	}
}