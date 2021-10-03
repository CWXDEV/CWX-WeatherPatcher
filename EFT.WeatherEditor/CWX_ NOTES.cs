

/* things that might actually control the last fog layer that i want to remove:
 * -class-CustomGlobalFog has some Fog settings that are seperate to GClass1414
 * -class-VolumetricFog has ConstantFog and GlobalDensityMult(has header Fog Density and set 1f to start) values
 * -class-TOD_FogParameters 
 * -class-FogEllipsoid
 * -class-SetFog might be able to turn fog off from unity, here?
 * -class-GlobalFog has some interesting values, "Apply Distance-based fog" = true (fog does move with camera when using terkoiz free cam
 * for me that option looks decent to check, also has heightFog "apply height-based fog" = true with 1f, might be why it stops at a certain height
 * -class-PrismEffects also has Fog Values, camera type stuff though
 * -class-LevelSettings has values refering to RenderSettings, sounds more accurate with how it is like a layer with set height and density distance, start etc
 * -class-AreaLight refers to FogLight Class
 * -class-GClass579 has levelRenderSettings for fog
 * -class-TOD_Sky has fog settings
 * -class-GClass1415 has ref to GClass1414 with fog settings
 * -class-OpticComponentUpdater not sure but has fog settings, camera based i think
 * 
 * CLASSES with fog in name:
 * CustomGlobalFog
 * Fog
 * FogEllipsoid
 * FogLight
 * GlobalFog
 * LightManagerFogEllipsoids
 * LightManagerFogLights
 * SetFog
 * TOD_FogParameters
 * VolumetricFog
 * 
 * 
 *
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 *
 */
