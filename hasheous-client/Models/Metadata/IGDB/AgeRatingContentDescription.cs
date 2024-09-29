using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HasheousClient.Models.Metadata.IGDB
{
  public class AgeRatingContentDescription : IIdentifier, IHasChecksum
  {
    [JsonPropertyName("category")]
    [JsonProperty("category")]
    public AgeRatingContentDescriptionCategory? Category { get; set; }

    [JsonPropertyName("checksum")]
    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonPropertyName("description")]
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public long? Id { get; set; }
  }

  public enum AgeRatingContentDescriptionCategory
  {
    ESRB_alcohol_reference = 1,
    ESRB_animated_blood = 2,
    ESRB_blood = 3,
    ESRB_blood_and_gore = 4,
    ESRB_cartoon_violence = 5,
    ESRB_comic_mischief = 6,
    ESRB_crude_humor = 7,
    ESRB_drug_reference = 8,
    ESRB_fantasy_violence = 9,
    ESRB_intense_violence = 10,
    ESRB_language = 11,
    ESRB_lyrics = 12,
    ESRB_mature_humor = 13,
    ESRB_nudity = 14,
    ESRB_partial_nudity = 15,
    ESRB_real_gambling = 16,
    ESRB_sexual_content = 17,
    ESRB_sexual_themes = 18,
    ESRB_sexual_violence = 19,
    ESRB_simulated_gambling = 20,
    ESRB_strong_language = 21,
    ESRB_strong_lyrics = 22,
    ESRB_strong_sexual_content = 23,
    ESRB_suggestive_themes = 24,
    ESRB_tobacco_reference = 25,
    ESRB_use_of_alcohol = 26,
    ESRB_use_of_drugs = 27,
    ESRB_use_of_tobacco = 28,
    ESRB_violence = 29,
    ESRB_violent_references = 30,
    ESRB_animated_violence = 31,
    ESRB_mild_language = 32,
    ESRB_mild_violence = 33,
    ESRB_use_of_drugs_and_alcohol = 34,
    ESRB_drug_and_alcohol_reference = 35,
    ESRB_mild_suggestive_themes = 36,
    ESRB_mild_cartoon_violence = 37,
    ESRB_mild_blood = 38,
    ESRB_realistic_blood_and_gore = 39,
    ESRB_realistic_violence = 40,
    ESRB_alcohol_and_tobacco_reference = 41,
    ESRB_mature_sexual_themes = 42,
    ESRB_mild_animated_violence = 43,
    ESRB_mild_sexual_themes = 44,
    ESRB_use_of_alcohol_and_tobacco = 45,
    ESRB_animated_blood_and_gore = 46,
    ESRB_mild_fantasy_violence = 47,
    ESRB_mild_lyrics = 48,
    ESRB_realistic_blood = 49,
    PEGI_violence = 50,
    PEGI_sex = 51,
    PEGI_drugs = 52,
    PEGI_fear = 53,
    PEGI_discrimination = 54,
    PEGI_bad_language = 55,
    PEGI_gambling = 56,
    PEGI_online_gameplay = 57,
    PEGI_in_game_purchases = 58,
    CERO_love = 59,
    CERO_sexual_content = 60,
    CERO_violence = 61,
    CERO_horror = 62,
    CERO_drinking_smoking = 63,
    CERO_gambling = 64,
    CERO_crime = 65,
    CERO_controlled_substances = 66,
    CERO_languages_and_others = 67,
    GRAC_sexuality = 68,
    GRAC_violence = 69,
    GRAC_fear_horror_threatening = 70,
    GRAC_language = 71,
    GRAC_alcohol_tobacco_drug = 72,
    GRAC_crime_anti_social = 73,
    GRAC_gambling = 74,
    CLASS_IND_violencia = 75,
    CLASS_IND_violencia_extrema = 76,
    CLASS_IND_conteudo_sexual = 77,
    CLASS_IND_nudez = 78,
    CLASS_IND_sexo = 79,
    CLASS_IND_sexo_explicito = 80,
    CLASS_IND_drogas = 81,
    CLASS_IND_drogas_licitas = 82,
    CLASS_IND_drogas_ilicitas = 83,
    CLASS_IND_linguagem_impropria = 84,
    CLASS_IND_atos_criminosos = 85
  }
}