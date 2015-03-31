//Maya ASCII 2015 scene
//Name: lavaLow.ma
//Last modified: Tue, Mar 31, 2015 04:17:15 PM
//Codeset: UTF-8
requires maya "2015";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2015";
fileInfo "version" "2015";
fileInfo "cutIdentifier" "201410051530-933320";
fileInfo "osv" "Mac OS X 10.9.2";
fileInfo "license" "education";
createNode transform -n "pPlane1";
	setAttr ".s" -type "double3" 3.8391887761238634 3.8391887761238634 3.8391887761238634 ;
createNode mesh -n "pPlaneShape1" -p "pPlane1";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.45146113634109497 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode polyTriangulate -n "polyTriangulate1";
	setAttr ".ics" -type "componentList" 1 "f[*]";
createNode polyMoveVertex -n "polyMoveVertex1";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 7 "vtx[10:16]" "vtx[19:25]" "vtx[28:34]" "vtx[37:43]" "vtx[46:52]" "vtx[55:61]" "vtx[64:70]";
	setAttr ".ix" -type "matrix" 3.8391887761238634 0 0 0 0 3.8391887761238634 0 0 0 0 3.8391887761238634 0
		 0 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0 -1.0162248e-22 4.5766697e-07 ;
	setAttr ".ran" 0.4724000096321106;
	setAttr ".rs" 1271697936;
	setAttr ".lt" -type "double3" 1.7763568394002505e-15 2.3301386287379609e-15 2.4940114601058783 ;
createNode polyPlane -n "polyPlane1";
	setAttr ".w" 6.6468779080175091;
	setAttr ".h" 7.3615170000460708;
	setAttr ".sw" 8;
	setAttr ".sh" 8;
	setAttr ".cuv" 2;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 2 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :lambert1;
	setAttr ".c" -type "float3" 1 0 0 ;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "mentalRay";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
select -ne :defaultHardwareRenderGlobals;
	setAttr ".res" -type "string" "ntsc_4d 646 485 1.333";
connectAttr "polyTriangulate1.out" "pPlaneShape1.i";
connectAttr "polyMoveVertex1.out" "polyTriangulate1.ip";
connectAttr "polyPlane1.out" "polyMoveVertex1.ip";
connectAttr "pPlaneShape1.wm" "polyMoveVertex1.mp";
connectAttr "pPlaneShape1.iog" ":initialShadingGroup.dsm" -na;
// End of lavaLow.ma
