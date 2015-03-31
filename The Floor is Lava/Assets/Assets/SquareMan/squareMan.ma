//Maya ASCII 2015 scene
//Name: squareMan.ma
//Last modified: Tue, Mar 31, 2015 05:00:08 PM
//Codeset: UTF-8
requires maya "2015";
requires -dataType "byteArray" "Mayatomr" "2015.0 - 3.12.1.18 ";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2015";
fileInfo "version" "2015";
fileInfo "cutIdentifier" "201410051530-933320";
fileInfo "osv" "Mac OS X 10.9.2";
fileInfo "license" "education";
createNode transform -n "pCube1";
	setAttr ".t" -type "double3" 0.45314230713777004 5.1216881935755669 0.40360692933756859 ;
createNode mesh -n "pCubeShape1" -p "pCube1";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode transform -n "pSphere1";
	setAttr ".t" -type "double3" 0.92487706537284364 5.8280542001917484 1.7873700409447029 ;
createNode mesh -n "pSphereShape1" -p "pSphere1";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt";
	setAttr ".pt[45]" -type "float3" 0 0 0.04775922 ;
	setAttr ".pt[46]" -type "float3" 0 0 0.04775922 ;
createNode transform -n "pSphere3";
	setAttr ".t" -type "double3" 0.4392222365855466 5.2111762125392085 1.777692471602327 ;
	setAttr ".s" -type "double3" 6.024046374824449 3.6041677220785817 0.94042200583257662 ;
createNode mesh -n "pSphereShape3" -p "pSphere3";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.625 0.25 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode mesh -n "polySurfaceShape1" -p "pSphere3";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.25 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 44 ".uvst[0].uvsp[0:43]" -type "float2" 0 0.125 0.125 0.125
		 0.25 0.125 0.375 0.125 0.5 0.125 0.625 0.125 0.75 0.125 0.875 0.125 1 0.125 0 0.25
		 0.125 0.25 0.25 0.25 0.375 0.25 0.5 0.25 0.625 0.25 0.75 0.25 0.875 0.25 1 0.25 0
		 0.375 0.125 0.375 0.25 0.375 0.375 0.375 0.5 0.375 0.625 0.375 0.75 0.375 0.875 0.375
		 1 0.375 0 0.5 0.125 0.5 0.25 0.5 0.375 0.5 0.5 0.5 0.625 0.5 0.75 0.5 0.875 0.5 1
		 0.5 0.0625 0 0.1875 0 0.3125 0 0.4375 0 0.5625 0 0.6875 0 0.8125 0 0.9375 0;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 33 ".vt[0:32]"  0.074934386 -0.255842 -0.074934386 0 -0.255842 -0.10597322
		 -0.074934386 -0.255842 -0.074934386 -0.10597322 -0.255842 0 -0.074934386 -0.255842 0.074934386
		 0 -0.255842 0.10597323 0.074934393 -0.255842 0.074934393 0.10597324 -0.255842 0 0.13846068 -0.19581299 -0.13846068
		 0 -0.19581299 -0.19581296 -0.13846068 -0.19581299 -0.13846068 -0.19581296 -0.19581299 0
		 -0.13846068 -0.19581299 0.13846068 0 -0.19581299 0.19581297 0.13846068 -0.19581299 0.13846068
		 0.19581299 -0.19581299 0 0.18090759 -0.10597323 -0.18090759 0 -0.10597323 -0.25584197
		 -0.18090759 -0.10597323 -0.18090759 -0.25584197 -0.10597323 0 -0.18090759 -0.10597323 0.18090759
		 0 -0.10597323 0.25584197 0.18090761 -0.10597323 0.18090761 0.255842 -0.10597323 0
		 0.19581297 0 -0.19581297 0 0 -0.27692136 -0.19581297 0 -0.19581297 -0.27692136 0 0
		 -0.19581297 0 0.19581297 0 0 0.27692136 0.19581299 0 0.19581299 0.27692139 0 0 0 -0.27692139 0;
	setAttr -s 64 ".ed[0:63]"  0 1 0 1 2 0 2 3 0 3 4 0 4 5 0 5 6 0 6 7 0
		 7 0 0 8 9 0 9 10 0 10 11 0 11 12 0 12 13 0 13 14 0 14 15 0 15 8 0 16 17 0 17 18 0
		 18 19 0 19 20 0 20 21 0 21 22 0 22 23 0 23 16 0 24 25 0 25 26 0 26 27 0 27 28 0 28 29 0
		 29 30 0 30 31 0 31 24 0 0 8 0 1 9 0 2 10 0 3 11 0 4 12 0 5 13 0 6 14 0 7 15 0 8 16 0
		 9 17 0 10 18 0 11 19 0 12 20 0 13 21 0 14 22 0 15 23 0 16 24 0 17 25 0 18 26 0 19 27 0
		 20 28 0 21 29 0 22 30 0 23 31 0 32 0 0 32 1 0 32 2 0 32 3 0 32 4 0 32 5 0 32 6 0
		 32 7 0;
	setAttr -s 32 -ch 120 ".fc[0:31]" -type "polyFaces" 
		f 4 0 33 -9 -33
		mu 0 4 0 1 10 9
		f 4 1 34 -10 -34
		mu 0 4 1 2 11 10
		f 4 2 35 -11 -35
		mu 0 4 2 3 12 11
		f 4 3 36 -12 -36
		mu 0 4 3 4 13 12
		f 4 4 37 -13 -37
		mu 0 4 4 5 14 13
		f 4 5 38 -14 -38
		mu 0 4 5 6 15 14
		f 4 6 39 -15 -39
		mu 0 4 6 7 16 15
		f 4 7 32 -16 -40
		mu 0 4 7 8 17 16
		f 4 8 41 -17 -41
		mu 0 4 9 10 19 18
		f 4 9 42 -18 -42
		mu 0 4 10 11 20 19
		f 4 10 43 -19 -43
		mu 0 4 11 12 21 20
		f 4 11 44 -20 -44
		mu 0 4 12 13 22 21
		f 4 12 45 -21 -45
		mu 0 4 13 14 23 22
		f 4 13 46 -22 -46
		mu 0 4 14 15 24 23
		f 4 14 47 -23 -47
		mu 0 4 15 16 25 24
		f 4 15 40 -24 -48
		mu 0 4 16 17 26 25
		f 4 16 49 -25 -49
		mu 0 4 18 19 28 27
		f 4 17 50 -26 -50
		mu 0 4 19 20 29 28
		f 4 18 51 -27 -51
		mu 0 4 20 21 30 29
		f 4 19 52 -28 -52
		mu 0 4 21 22 31 30
		f 4 20 53 -29 -53
		mu 0 4 22 23 32 31
		f 4 21 54 -30 -54
		mu 0 4 23 24 33 32
		f 4 22 55 -31 -55
		mu 0 4 24 25 34 33
		f 4 23 48 -32 -56
		mu 0 4 25 26 35 34
		f 3 -1 -57 57
		mu 0 3 1 0 36
		f 3 -2 -58 58
		mu 0 3 2 1 37
		f 3 -3 -59 59
		mu 0 3 3 2 38
		f 3 -4 -60 60
		mu 0 3 4 3 39
		f 3 -5 -61 61
		mu 0 3 5 4 40
		f 3 -6 -62 62
		mu 0 3 6 5 41
		f 3 -7 -63 63
		mu 0 3 7 6 42
		f 3 -8 -64 56
		mu 0 3 8 7 43;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode transform -n "pSphere4";
	setAttr ".t" -type "double3" -0.072452053199649646 5.8280542001917484 1.7873700409447029 ;
createNode mesh -n "pSphereShape4" -p "pSphere4";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 79 ".uvst[0].uvsp[0:78]" -type "float2" 0 0.125 0.125 0.125
		 0.25 0.125 0.375 0.125 0.5 0.125 0.625 0.125 0.75 0.125 0.875 0.125 1 0.125 0 0.25
		 0.125 0.25 0.25 0.25 0.375 0.25 0.5 0.25 0.625 0.25 0.75 0.25 0.875 0.25 1 0.25 0
		 0.375 0.125 0.375 0.25 0.375 0.375 0.375 0.5 0.375 0.625 0.375 0.75 0.375 0.875 0.375
		 1 0.375 0 0.5 0.125 0.5 0.25 0.5 0.375 0.5 0.5 0.5 0.625 0.5 0.75 0.5 0.875 0.5 1
		 0.5 0 0.625 0.125 0.625 0.25 0.625 0.375 0.625 0.5 0.625 0.625 0.625 0.75 0.625 0.875
		 0.625 1 0.625 0 0.75 0.125 0.75 0.25 0.75 0.375 0.75 0.5 0.75 0.625 0.75 0.75 0.75
		 0.875 0.75 1 0.75 0 0.875 0.125 0.875 0.25 0.875 0.375 0.875 0.5 0.875 0.625 0.875
		 0.75 0.875 0.875 0.875 1 0.875 0.0625 0 0.1875 0 0.3125 0 0.4375 0 0.5625 0 0.6875
		 0 0.8125 0 0.9375 0 0.0625 1 0.1875 1 0.3125 1 0.4375 1 0.5625 1 0.6875 1 0.8125
		 1 0.9375 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 4 ".pt";
	setAttr ".pt[45]" -type "float3" 0 0 0.04775922 ;
	setAttr ".pt[46]" -type "float3" 0 0 0.04775922 ;
	setAttr -s 58 ".vt[0:57]"  0.074934386 -0.255842 -0.074934386 0 -0.255842 -0.10597322
		 -0.074934386 -0.255842 -0.074934386 -0.10597322 -0.255842 0 -0.074934386 -0.255842 0.074934386
		 0 -0.255842 0.10597323 0.074934393 -0.255842 0.074934393 0.10597324 -0.255842 0 0.13846068 -0.19581299 -0.13846068
		 0 -0.19581299 -0.19581296 -0.13846068 -0.19581299 -0.13846068 -0.19581296 -0.19581299 0
		 -0.13846068 -0.19581299 0.13846068 0 -0.19581299 0.19581297 0.13846068 -0.19581299 0.13846068
		 0.19581299 -0.19581299 0 0.18090759 -0.10597323 -0.18090759 0 -0.10597323 -0.25584197
		 -0.18090759 -0.10597323 -0.18090759 -0.25584197 -0.10597323 0 -0.18090759 -0.10597323 0.18090759
		 0 -0.10597323 0.25584197 0.18090761 -0.10597323 0.18090761 0.255842 -0.10597323 0
		 0.19581297 0 -0.19581297 0 0 -0.27692136 -0.19581297 0 -0.19581297 -0.27692136 0 0
		 -0.19581297 0 0.19581297 0 0 0.27692136 0.19581299 0 0.19581299 0.27692139 0 0 0.18090759 0.10597323 -0.18090759
		 0 0.10597323 -0.25584197 -0.18090759 0.10597323 -0.18090759 -0.25584197 0.10597323 0
		 -0.18090759 0.10597323 0.18090759 0 0.10597323 0.25584197 0.18090761 0.10597323 0.18090761
		 0.255842 0.10597323 0 0.13846068 0.19581299 -0.13846068 0 0.19581299 -0.19581296
		 -0.13846068 0.19581299 -0.13846068 -0.19581296 0.19581299 0 -0.13846068 0.19581299 0.13846068
		 0 0.19581299 0.19581297 0.13846068 0.19581299 0.13846068 0.19581299 0.19581299 0
		 0.074934386 0.255842 -0.074934386 0 0.255842 -0.10597322 -0.074934386 0.255842 -0.074934386
		 -0.10597322 0.255842 0 -0.074934386 0.255842 0.074934386 0 0.255842 0.10597323 0.074934393 0.255842 0.074934393
		 0.10597324 0.255842 0 0 -0.27692139 0 0 0.27692139 0;
	setAttr -s 168 ".ed";
	setAttr ".ed[0:165]"  0 1 0 1 2 0 2 3 0 3 4 0 4 5 0 5 6 0 6 7 0 7 0 0 8 9 0
		 9 10 0 10 11 0 11 12 0 12 13 0 13 14 0 14 15 0 15 8 0 16 17 0 17 18 0 18 19 0 19 20 0
		 20 21 0 21 22 0 22 23 0 23 16 0 24 25 0 25 26 0 26 27 0 27 28 0 28 29 0 29 30 0 30 31 0
		 31 24 0 32 33 0 33 34 0 34 35 0 35 36 0 36 37 0 37 38 0 38 39 0 39 32 0 40 41 0 41 42 0
		 42 43 0 43 44 0 44 45 0 45 46 0 46 47 0 47 40 0 48 49 0 49 50 0 50 51 0 51 52 0 52 53 0
		 53 54 0 54 55 0 55 48 0 0 8 0 1 9 0 2 10 0 3 11 0 4 12 0 5 13 0 6 14 0 7 15 0 8 16 0
		 9 17 0 10 18 0 11 19 0 12 20 0 13 21 0 14 22 0 15 23 0 16 24 0 17 25 0 18 26 0 19 27 0
		 20 28 0 21 29 0 22 30 0 23 31 0 24 32 0 25 33 0 26 34 0 27 35 0 28 36 0 29 37 0 30 38 0
		 31 39 0 32 40 0 33 41 0 34 42 0 35 43 0 36 44 0 37 45 0 38 46 0 39 47 0 40 48 0 41 49 0
		 42 50 0 43 51 0 44 52 0 45 53 0 46 54 0 47 55 0 56 0 0 56 1 0 56 2 0 56 3 0 56 4 0
		 56 5 0 56 6 0 56 7 0 48 57 0 49 57 0 50 57 0 51 57 0 52 57 0 53 57 0 54 57 0 55 57 0
		 1 8 1 2 9 1 3 10 1 4 11 1 5 12 1 6 13 1 7 14 1 0 15 1 9 16 1 10 17 1 11 18 1 12 19 1
		 13 20 1 14 21 1 15 22 1 8 23 1 17 24 1 18 25 1 19 26 1 20 27 1 21 28 1 22 29 1 23 30 1
		 16 31 1 25 32 1 26 33 1 27 34 1 28 35 1 29 36 1 30 37 1 31 38 1 24 39 1 33 40 1 34 41 1
		 35 42 1 36 43 1 37 44 1 38 45 1 39 46 1 32 47 1 41 48 1 42 49 1 43 50 1 44 51 1 45 52 1
		 46 53 1;
	setAttr ".ed[166:167]" 47 54 1 40 55 1;
	setAttr -s 112 -ch 336 ".fc[0:111]" -type "polyFaces" 
		f 3 0 120 -57
		mu 0 3 0 1 9
		f 3 -121 57 -9
		mu 0 3 9 1 10
		f 3 1 121 -58
		mu 0 3 1 2 10
		f 3 -122 58 -10
		mu 0 3 10 2 11
		f 3 2 122 -59
		mu 0 3 2 3 11
		f 3 -123 59 -11
		mu 0 3 11 3 12
		f 3 3 123 -60
		mu 0 3 3 4 12
		f 3 -124 60 -12
		mu 0 3 12 4 13
		f 3 4 124 -61
		mu 0 3 4 5 13
		f 3 -125 61 -13
		mu 0 3 13 5 14
		f 3 5 125 -62
		mu 0 3 5 6 14
		f 3 -126 62 -14
		mu 0 3 14 6 15
		f 3 6 126 -63
		mu 0 3 6 7 15
		f 3 -127 63 -15
		mu 0 3 15 7 16
		f 3 7 127 -64
		mu 0 3 7 8 16
		f 3 -128 56 -16
		mu 0 3 16 8 17
		f 3 8 128 -65
		mu 0 3 9 10 18
		f 3 -129 65 -17
		mu 0 3 18 10 19
		f 3 9 129 -66
		mu 0 3 10 11 19
		f 3 -130 66 -18
		mu 0 3 19 11 20
		f 3 10 130 -67
		mu 0 3 11 12 20
		f 3 -131 67 -19
		mu 0 3 20 12 21
		f 3 11 131 -68
		mu 0 3 12 13 21
		f 3 -132 68 -20
		mu 0 3 21 13 22
		f 3 12 132 -69
		mu 0 3 13 14 22
		f 3 -133 69 -21
		mu 0 3 22 14 23
		f 3 13 133 -70
		mu 0 3 14 15 23
		f 3 -134 70 -22
		mu 0 3 23 15 24
		f 3 14 134 -71
		mu 0 3 15 16 24
		f 3 -135 71 -23
		mu 0 3 24 16 25
		f 3 15 135 -72
		mu 0 3 16 17 25
		f 3 -136 64 -24
		mu 0 3 25 17 26
		f 3 16 136 -73
		mu 0 3 18 19 27
		f 3 -137 73 -25
		mu 0 3 27 19 28
		f 3 17 137 -74
		mu 0 3 19 20 28
		f 3 -138 74 -26
		mu 0 3 28 20 29
		f 3 18 138 -75
		mu 0 3 20 21 29
		f 3 -139 75 -27
		mu 0 3 29 21 30
		f 3 19 139 -76
		mu 0 3 21 22 30
		f 3 -140 76 -28
		mu 0 3 30 22 31
		f 3 20 140 -77
		mu 0 3 22 23 31
		f 3 -141 77 -29
		mu 0 3 31 23 32
		f 3 21 141 -78
		mu 0 3 23 24 32
		f 3 -142 78 -30
		mu 0 3 32 24 33
		f 3 22 142 -79
		mu 0 3 24 25 33
		f 3 -143 79 -31
		mu 0 3 33 25 34
		f 3 23 143 -80
		mu 0 3 25 26 34
		f 3 -144 72 -32
		mu 0 3 34 26 35
		f 3 24 144 -81
		mu 0 3 27 28 36
		f 3 -145 81 -33
		mu 0 3 36 28 37
		f 3 25 145 -82
		mu 0 3 28 29 37
		f 3 -146 82 -34
		mu 0 3 37 29 38
		f 3 26 146 -83
		mu 0 3 29 30 38
		f 3 -147 83 -35
		mu 0 3 38 30 39
		f 3 27 147 -84
		mu 0 3 30 31 39
		f 3 -148 84 -36
		mu 0 3 39 31 40
		f 3 28 148 -85
		mu 0 3 31 32 40
		f 3 -149 85 -37
		mu 0 3 40 32 41
		f 3 29 149 -86
		mu 0 3 32 33 41
		f 3 -150 86 -38
		mu 0 3 41 33 42
		f 3 30 150 -87
		mu 0 3 33 34 42
		f 3 -151 87 -39
		mu 0 3 42 34 43
		f 3 31 151 -88
		mu 0 3 34 35 43
		f 3 -152 80 -40
		mu 0 3 43 35 44
		f 3 32 152 -89
		mu 0 3 36 37 45
		f 3 -153 89 -41
		mu 0 3 45 37 46
		f 3 33 153 -90
		mu 0 3 37 38 46
		f 3 -154 90 -42
		mu 0 3 46 38 47
		f 3 34 154 -91
		mu 0 3 38 39 47
		f 3 -155 91 -43
		mu 0 3 47 39 48
		f 3 35 155 -92
		mu 0 3 39 40 48
		f 3 -156 92 -44
		mu 0 3 48 40 49
		f 3 36 156 -93
		mu 0 3 40 41 49
		f 3 -157 93 -45
		mu 0 3 49 41 50
		f 3 37 157 -94
		mu 0 3 41 42 50
		f 3 -158 94 -46
		mu 0 3 50 42 51
		f 3 38 158 -95
		mu 0 3 42 43 51
		f 3 -159 95 -47
		mu 0 3 51 43 52
		f 3 39 159 -96
		mu 0 3 43 44 52
		f 3 -160 88 -48
		mu 0 3 52 44 53
		f 3 40 160 -97
		mu 0 3 45 46 54
		f 3 -161 97 -49
		mu 0 3 54 46 55
		f 3 41 161 -98
		mu 0 3 46 47 55
		f 3 -162 98 -50
		mu 0 3 55 47 56
		f 3 42 162 -99
		mu 0 3 47 48 56
		f 3 -163 99 -51
		mu 0 3 56 48 57
		f 3 43 163 -100
		mu 0 3 48 49 57
		f 3 -164 100 -52
		mu 0 3 57 49 58
		f 3 44 164 -101
		mu 0 3 49 50 58
		f 3 -165 101 -53
		mu 0 3 58 50 59
		f 3 45 165 -102
		mu 0 3 50 51 59
		f 3 -166 102 -54
		mu 0 3 59 51 60
		f 3 46 166 -103
		mu 0 3 51 52 60
		f 3 -167 103 -55
		mu 0 3 60 52 61
		f 3 47 167 -104
		mu 0 3 52 53 61
		f 3 -168 96 -56
		mu 0 3 61 53 62
		f 3 -1 -105 105
		mu 0 3 1 0 63
		f 3 -2 -106 106
		mu 0 3 2 1 64
		f 3 -3 -107 107
		mu 0 3 3 2 65
		f 3 -4 -108 108
		mu 0 3 4 3 66
		f 3 -5 -109 109
		mu 0 3 5 4 67
		f 3 -6 -110 110
		mu 0 3 6 5 68
		f 3 -7 -111 111
		mu 0 3 7 6 69
		f 3 -8 -112 104
		mu 0 3 8 7 70
		f 3 48 113 -113
		mu 0 3 54 55 71
		f 3 49 114 -114
		mu 0 3 55 56 72
		f 3 50 115 -115
		mu 0 3 56 57 73
		f 3 51 116 -116
		mu 0 3 57 58 74
		f 3 52 117 -117
		mu 0 3 58 59 75
		f 3 53 118 -118
		mu 0 3 59 60 76
		f 3 54 119 -119
		mu 0 3 60 61 77
		f 3 55 112 -120
		mu 0 3 61 62 78;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode polyMoveVertex -n "polyMoveVertex3";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "vtx[0:169]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0.45314230713777004 5.1216881935755669 0.40360692933756859 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.4550114 5.1278529 0.40381548 ;
	setAttr ".ran" 0.4724000096321106;
	setAttr ".rs" 1206961689;
	setAttr ".lt" -type "double3" 8.1185058675714572e-16 -1.3045120539345589e-15 0.0963070308523057 ;
createNode polyTriangulate -n "polyTriangulate2";
	setAttr ".ics" -type "componentList" 1 "f[0:167]";
createNode polyMoveVertex -n "polyMoveVertex2";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "vtx[0:169]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0.45314230713777004 5.1216881935755669 0.40360692933756859 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.45314243 5.1216884 0.40360692 ;
	setAttr ".ran" 0.4724000096321106;
	setAttr ".rs" 462006149;
	setAttr ".lt" -type "double3" 1.0234868508263162e-15 -4.7184478546569153e-16 0.081346256921844745 ;
createNode polyCube -n "polyCube1";
	addAttr -ci true -sn "nts" -ln "notes" -dt "string";
	setAttr ".w" 5.3843504431258413;
	setAttr ".h" 5.0425919601238833;
	setAttr ".d" 2.5096202232331386;
	setAttr ".sw" 6;
	setAttr ".sh" 6;
	setAttr ".sd" 4;
	setAttr ".cuv" 4;
	setAttr ".nts" -type "string" "\t\t";
createNode materialInfo -n "materialInfo1";
createNode shadingEngine -n "blinn1SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "lambert2";
	setAttr ".c" -type "float3" 0 1 0.22755003 ;
createNode polyTriangulate -n "polyTriangulate3";
	setAttr ".ics" -type "componentList" 1 "f[*]";
createNode polySphere -n "polySphere1";
	setAttr ".r" 0.27692137725572152;
	setAttr ".sa" 8;
	setAttr ".sh" 8;
createNode materialInfo -n "materialInfo3";
createNode shadingEngine -n "lambert4SG";
	setAttr ".ihi" 0;
	setAttr -s 3 ".dsm";
	setAttr ".ro" yes;
createNode lambert -n "lambert4";
	setAttr ".c" -type "float3" 0 0 0 ;
createNode polyMoveVertex -n "polyMoveVertex6";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 4 "vtx[4]" "vtx[6]" "vtx[12:14]" "vtx[20:22]";
	setAttr ".ix" -type "matrix" 6.024046374824449 0 0 0 0 3.6041677220785817 0 0 0 0 0.94042200583257662 0
		 0.50626765057523393 5.2111762125392085 4.254053161375948 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.50626785 4.5591545 4.4095874 ;
	setAttr ".ran" 0.4724000096321106;
	setAttr ".rs" 381711902;
	setAttr ".lt" -type "double3" -7.422177022292642e-16 2.0200854877749919e-15 0.015200359348544051 ;
createNode polyTriangulate -n "polyTriangulate4";
	setAttr ".ics" -type "componentList" 1 "f[*]";
createNode polyMoveVertex -n "polyMoveVertex5";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "vtx[0:32]";
	setAttr ".ix" -type "matrix" 6.024046374824449 0 0 0 0 3.6041677220785817 0 0 0 0 0.94042200583257662 0
		 0.50626765057523393 5.2111762125392085 4.254053161375948 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.50626773 4.7121406 4.2540531 ;
	setAttr ".ran" 0.4724000096321106;
	setAttr ".rs" 1159853830;
createNode polyCloseBorder -n "polyCloseBorder1";
	setAttr ".ics" -type "componentList" 1 "e[0:63]";
createNode lightLinker -s -n "lightLinker1";
	setAttr -s 5 ".lnk";
	setAttr -s 5 ".slnk";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :renderPartition;
	setAttr -s 5 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 5 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :lambert1;
	setAttr ".c" -type "float3" 0 0 0 ;
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
connectAttr "polyMoveVertex3.out" "pCubeShape1.i";
connectAttr "polyTriangulate3.out" "pSphereShape1.i";
connectAttr "polyMoveVertex6.out" "pSphereShape3.i";
connectAttr "polyTriangulate2.out" "polyMoveVertex3.ip";
connectAttr "pCubeShape1.wm" "polyMoveVertex3.mp";
connectAttr "polyMoveVertex2.out" "polyTriangulate2.ip";
connectAttr "polyCube1.out" "polyMoveVertex2.ip";
connectAttr "pCubeShape1.wm" "polyMoveVertex2.mp";
connectAttr "blinn1SG.msg" "materialInfo1.sg";
connectAttr "lambert2.msg" "materialInfo1.m";
connectAttr "lambert2.oc" "blinn1SG.ss";
connectAttr "pCubeShape1.iog" "blinn1SG.dsm" -na;
connectAttr "polySphere1.out" "polyTriangulate3.ip";
connectAttr "lambert4SG.msg" "materialInfo3.sg";
connectAttr "lambert4.msg" "materialInfo3.m";
connectAttr "lambert4.oc" "lambert4SG.ss";
connectAttr "pSphereShape1.iog" "lambert4SG.dsm" -na;
connectAttr "pSphereShape4.iog" "lambert4SG.dsm" -na;
connectAttr "pSphereShape3.iog" "lambert4SG.dsm" -na;
connectAttr "polyTriangulate4.out" "polyMoveVertex6.ip";
connectAttr "pSphereShape3.wm" "polyMoveVertex6.mp";
connectAttr "polyMoveVertex5.out" "polyTriangulate4.ip";
connectAttr "polyCloseBorder1.out" "polyMoveVertex5.ip";
connectAttr "pSphereShape3.wm" "polyMoveVertex5.mp";
connectAttr "polySurfaceShape1.o" "polyCloseBorder1.ip";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "blinn1SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert4SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "blinn1SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert4SG.message" ":defaultLightSet.message";
connectAttr "blinn1SG.pa" ":renderPartition.st" -na;
connectAttr "lambert4SG.pa" ":renderPartition.st" -na;
connectAttr "lambert2.msg" ":defaultShaderList1.s" -na;
connectAttr "lambert4.msg" ":defaultShaderList1.s" -na;
// End of squareMan.ma
