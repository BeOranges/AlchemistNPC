using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items.Notes
{
	public class ResearchNote7 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Research Note #7");
			Tooltip.SetDefault("''Once, I was in quite insane world."
			+"\nThere was one old scientist, named [c/00FF00:Rick]."
			+"\nLuckly, I was able to saw all that without being caught..."
			+"\nHe escaped from the maximum security prison without help from outside."
			+"\nAnd then destroyed the entire Galactic Federation in the same day." 
			+"\nThe thing what I was the most interested in is his Portal Gun."
			+"\nHe managed to use it as a weapon. And I really want to make one for myself.."
			+"\nNaturally we need [c/00FF00:Portal Gun] as the base..."
			+"\nFor some parts, we need an [c/00FF00:Alchemical Bundle]."
			+"\nWe also need the [c/00FF00:Lunar Portal Staff] for stabilizing the portals."
			+"\nTo variate dimensions, we can use [c/00FF00:R.E.K. 3000]."
			+"\nI am still not sure about source of energy..."
			+"\nSomething, named [c/00FF00:Concentrated Dark Matter] would be required as ammo."
			+"\nI hope I'm able to synthesize it...''");
			DisplayName.AddTranslation(GameCulture.Russian, "Запись исследования №7");
            Tooltip.AddTranslation(GameCulture.Russian, "''Однажды я побывала в довольно безумном мире.\nТам я видела старика-учёного, которого звали [c/00FF00:Рик].\nК счастью, я смогла понаблюдать за событиями незамеченной.\nОн сбежал из тюрьмы максимальной безопасности безо всякой помощи снаружи.\nИ в тот же день он уничтожил Галактическую Федерацию.\nМеня очень заинтересовала его Портальная Пушка.\nОн пользовался ей в качестве оружия. Я очень хочу себе такую же...\nКонечно, нам необходима [c/00FF00:Портальная Пушка] Лунного Лорда в качестве основы.\nДля некоторых частей нам потребуется [c/00FF00:Алхимический Набор].\nДля стабилизации порталов нам потребуется [c/00FF00:Посох Лунных Порталов].\nДля варьирования реальностей, нам понадобится [c/00FF00:R.E.K. 3000].\nНо я не уверена насчёт источника энергии...\nДля стрельбы необходимо что-то, называющееся [c/00FF00:Концентрированная Тёмная Материя].\nНадеюсь, мне удастся её синтезировать...''");
        }

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 36;
			item.maxStack = 1;
			item.value = 10000000;
			item.rare = 10;
		}	
	}
}
