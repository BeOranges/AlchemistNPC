using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlchemistNPC.Projectiles
{
	public class SharpNeedle : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sharp Needle");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(616);
			projectile.width = 10;
			projectile.height = 24;
			aiType = 616;
		}
		
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.Kill();
			Main.PlaySound(SoundID.Item34, projectile.position);
			for (int h = 0; h < 3; h++)
				{
					Vector2 vel = new Vector2(0, -1);
					float rand = Main.rand.NextFloat() * 6.283f;
					vel = vel.RotatedBy(rand);
					vel *= 1f;
					switch (Main.rand.Next(4))
					{
					case 0:
					Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel.X, vel.Y, mod.ProjectileType("L3"), projectile.damage/2, 0, Main.myPlayer);
					break;
					case 1:
					Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel.X, vel.Y, mod.ProjectileType("L1"), projectile.damage/2, 0, Main.myPlayer);
					break;
					case 2:
					Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel.X, vel.Y, mod.ProjectileType("L2"), projectile.damage/2, 0, Main.myPlayer);
					break;
					case 3:
					Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel.X, vel.Y, mod.ProjectileType("L2"), projectile.damage/2, 0, Main.myPlayer);
					break;
					}
				}
			return true;
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.Kill();
			Main.PlaySound(SoundID.Item34, projectile.position);
			for (int g = 0; g < 3; g++)
				{
					Vector2 vel = new Vector2(0, -1);
					float rand = Main.rand.NextFloat() * 6.283f;
					vel = vel.RotatedBy(rand);
					vel *= 1f;
					switch (Main.rand.Next(4))
					{
					case 0:
					Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel.X, vel.Y, mod.ProjectileType("L3"), projectile.damage/2, 0, Main.myPlayer);
					break;
					case 1:
					Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel.X, vel.Y, mod.ProjectileType("L1"), projectile.damage/2, 0, Main.myPlayer);
					break;
					case 2:
					Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel.X, vel.Y, mod.ProjectileType("L2"), projectile.damage/2, 0, Main.myPlayer);
					break;
					case 3:
					Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vel.X, vel.Y, mod.ProjectileType("L2"), projectile.damage/2, 0, Main.myPlayer);
					break;
					}
				}
		}
	}
}