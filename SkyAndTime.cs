using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Menu
{
    internal class SkyAndTime
    {
        public static void NightTime() => BetterDayNightManager.instance.SetTimeOfDay(0);

        public static void EveningTime() => BetterDayNightManager.instance.SetTimeOfDay(7);

        public static void MorningTime() => BetterDayNightManager.instance.SetTimeOfDay(1);

        public static void DayTime() => BetterDayNightManager.instance.SetTimeOfDay(3);

        public static void Rain()
        {
            for (int index = 1; index < BetterDayNightManager.instance.weatherCycle.Length; ++index)
                BetterDayNightManager.instance.weatherCycle[index] = (BetterDayNightManager.WeatherType)1;
        }

        public static void NoRain()
        {
            for (int index = 1; index < BetterDayNightManager.instance.weatherCycle.Length; ++index)
                BetterDayNightManager.instance.weatherCycle[index] = (BetterDayNightManager.WeatherType)0;
        }

        public static void greenSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.green;
        }

        public static void NostalgiaSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.gray1;
        }

        public static void PurpleSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.purple;
        }

        public static void redSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.red;
        }

        public static void blueSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.blue;
        }
        public static void CoralSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.lightCoral;
        }
        public static void ChocolateSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.brown;
        }
        public static void PissSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.yellow;
        }
        public static void CumSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.white;
        }
        public static void GoldenSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.gold;
        }
        public static void LightGraySky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.lightGray;
        }
        public static void LightPinkSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.lightPink;
        }
        public static void CornflowerBlueSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.cornflowerBlue;
        }
        public static void PowderBlueSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.powderBlue;
        }
        public static void SnowSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.snow;
        }
        public static void TanSky()
        {
            Renderer component = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            component.material.shader = Shader.Find("GorillaTag/UberShader");
            component.material.color = Color.tan;
        }
    }
}
