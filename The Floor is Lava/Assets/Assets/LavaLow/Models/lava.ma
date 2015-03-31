//Maya ASCII 2015 scene
//Name: lava.ma
//Last modified: Tue, Mar 31, 2015 06:13:37 PM
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
createNode transform -n "pPlane2";
	setAttr ".t" -type "double3" 24.089538372128832 0 0 ;
	setAttr ".s" -type "double3" 3.8391887761238634 3.8391887761238634 3.8391887761238634 ;
createNode mesh -n "pPlaneShape2" -p "pPlane2";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.45146114379167557 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode mesh -n "polySurfaceShape2" -p "pPlane2";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.45146114379167557 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 81 ".uvst[0].uvsp[0:80]" -type "float2" 0 0 0.11286528 0
		 0.22573057 0 0.33859587 0 0.45146114 0 0.56432641 0 0.67719173 0 0.790057 0 0.90292227
		 0 0 0.125 0.11286528 0.125 0.22573057 0.125 0.33859587 0.125 0.45146114 0.125 0.56432641
		 0.125 0.67719173 0.125 0.790057 0.125 0.90292227 0.125 0 0.25 0.11286528 0.25 0.22573057
		 0.25 0.33859587 0.25 0.45146114 0.25 0.56432641 0.25 0.67719173 0.25 0.790057 0.25
		 0.90292227 0.25 0 0.375 0.11286528 0.375 0.22573057 0.375 0.33859587 0.375 0.45146114
		 0.375 0.56432641 0.375 0.67719173 0.375 0.790057 0.375 0.90292227 0.375 0 0.5 0.11286528
		 0.5 0.22573057 0.5 0.33859587 0.5 0.45146114 0.5 0.56432641 0.5 0.67719173 0.5 0.790057
		 0.5 0.90292227 0.5 0 0.625 0.11286528 0.625 0.22573057 0.625 0.33859587 0.625 0.45146114
		 0.625 0.56432641 0.625 0.67719173 0.625 0.790057 0.625 0.90292227 0.625 0 0.75 0.11286528
		 0.75 0.22573057 0.75 0.33859587 0.75 0.45146114 0.75 0.56432641 0.75 0.67719173 0.75
		 0.790057 0.75 0.90292227 0.75 0 0.875 0.11286528 0.875 0.22573057 0.875 0.33859587
		 0.875 0.45146114 0.875 0.56432641 0.875 0.67719173 0.875 0.790057 0.875 0.90292227
		 0.875 0 1 0.11286528 1 0.22573057 1 0.33859587 1 0.45146114 1 0.56432641 1 0.67719173
		 1 0.790057 1 0.90292227 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 49 ".pt";
	setAttr ".pt[10]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[11]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[12]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[13]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[14]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[15]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[16]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[19]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[20]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[21]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[22]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[23]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[24]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[25]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[28]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[29]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[30]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[31]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[32]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[33]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[34]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[37]" -type "float3" 0 -0.42701632 1.3789257e-23 ;
	setAttr ".pt[38]" -type "float3" 0 -0.42701632 1.3789257e-23 ;
	setAttr ".pt[39]" -type "float3" 0 -0.42701632 1.3789257e-23 ;
	setAttr ".pt[40]" -type "float3" 0 -0.42701632 1.3789257e-23 ;
	setAttr ".pt[41]" -type "float3" 0 -0.42701632 1.3789257e-23 ;
	setAttr ".pt[42]" -type "float3" 0 -0.42701632 1.3789257e-23 ;
	setAttr ".pt[43]" -type "float3" 0 -0.42701632 1.3789257e-23 ;
	setAttr ".pt[46]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[47]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[48]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[49]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[50]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[51]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[52]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[55]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[56]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[57]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[58]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[59]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[60]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[61]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[64]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[65]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[66]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[67]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[68]" -type "float3" 0 -0.42701632 0 ;
	setAttr ".pt[69]" -type "float3" 0 -0.42701632 0 ;
	setAttr -s 81 ".vt[0:80]"  -3.32343912 -8.1729256e-16 3.68075848 -2.49257922 -8.1729256e-16 3.68075848
		 -1.66171956 -8.1729256e-16 3.68075848 -0.83085972 -8.1729256e-16 3.68075848 0 -8.1729256e-16 3.68075848
		 0.8308599 -8.1729256e-16 3.68075848 1.66171968 -8.1729256e-16 3.68075848 2.49257922 -8.1729256e-16 3.68075848
		 3.32343912 -8.1729256e-16 3.68075848 -3.32343912 -6.1296942e-16 2.76056886 -2.49257922 0.81219941 2.76056886
		 -1.66171956 0.86680037 2.76056886 -0.83085972 0.85283881 2.76056886 4.0185975e-16 0.56421256 2.76056886
		 0.8308599 0.88611948 2.76056886 1.66171968 0.37387523 2.76056886 2.49257922 0.34989583 2.76056886
		 3.32343912 -6.1296942e-16 2.76056886 -3.32343912 -4.0864628e-16 1.84037924 -2.49257922 0.49331564 1.84037924
		 -1.66171956 0.5690037 1.84037924 -0.83085972 0.69410038 1.84037924 3.5610414e-16 0.49997154 1.84037924
		 0.8308599 0.66612923 1.84037924 1.66171968 0.79016471 1.84037924 2.49257922 0.90144181 1.84037924
		 3.32343912 -4.0864628e-16 1.84037924 -3.32343912 -2.0432314e-16 0.92018962 -2.49257922 0.44644943 0.92018962
		 -1.66171956 0.83708262 0.92018962 -0.83085972 0.48882392 0.92018962 4.3445257e-16 0.60997301 0.92018962
		 0.8308599 0.38215753 0.92018962 1.66171968 0.90787798 0.92018962 2.49257922 0.61630571 0.92018962
		 3.32343912 -2.0432314e-16 0.92018962 -3.32343912 0 0 -2.49257922 0.76196009 -5.4270523e-16
		 -1.66171956 0.68037301 -4.8459485e-16 -0.83085972 0.34966889 -2.4905124e-16 3.2631463e-16 0.45814696 -3.2631465e-16
		 0.8308599 0.43006235 -3.0631144e-16 1.66171968 0.65140027 -4.6395907e-16 2.49257922 0.42068732 -2.9963404e-16
		 3.32343912 0 0 -3.32343912 2.0432319e-16 -0.92018986 -2.49257922 0.66758239 -0.92018986
		 -1.66171956 0.62896127 -0.92018986 -0.83085972 0.87630218 -0.92018986 4.4545087e-16 0.62541467 -0.92018986
		 0.8308599 0.47781712 -0.92018986 1.66171968 0.84508669 -0.92018986 2.49257922 0.49228194 -0.92018986
		 3.32343912 2.0432319e-16 -0.92018986 -3.32343912 4.0864628e-16 -1.84037924 -2.49257922 0.67290443 -1.84037924
		 -1.66171956 0.66027737 -1.84037924 -0.83085972 0.55608779 -1.84037924 4.3325193e-16 0.60828733 -1.84037924
		 0.8308599 0.58614987 -1.84037924 1.66171968 0.44283393 -1.84037924 2.49257922 0.45767608 -1.84037924
		 3.32343912 4.0864628e-16 -1.84037924 -3.32343912 6.1296937e-16 -2.76056862 -2.49257922 0.76128417 -2.76056862
		 -1.66171956 0.79665458 -2.76056862 -0.83085972 0.39466569 -2.76056862 4.8356158e-16 0.67892224 -2.76056862
		 0.8308599 0.35944572 -2.76056862 1.66171968 0.8326959 -2.76056862 2.49257922 0.90559715 -2.76056862
		 3.32343912 6.1296937e-16 -2.76056862 -3.32343912 8.1729256e-16 -3.68075848 -2.49257922 8.1729256e-16 -3.68075848
		 -1.66171956 8.1729256e-16 -3.68075848 -0.83085972 8.1729256e-16 -3.68075848 0 8.1729256e-16 -3.68075848
		 0.8308599 8.1729256e-16 -3.68075848 1.66171968 8.1729256e-16 -3.68075848 2.49257922 8.1729256e-16 -3.68075848
		 3.32343912 8.1729256e-16 -3.68075848;
	setAttr -s 208 ".ed";
	setAttr ".ed[0:165]"  0 1 0 0 9 0 1 2 0 1 10 1 2 3 0 2 11 1 3 4 0 3 12 1
		 4 5 0 4 13 1 5 6 0 5 14 1 6 7 0 6 15 1 7 8 0 7 16 1 8 17 0 9 10 1 9 18 0 10 11 1
		 10 19 1 11 12 1 11 20 1 12 13 1 12 21 1 13 14 1 13 22 1 14 15 1 14 23 1 15 16 1 15 24 1
		 16 17 1 16 25 1 17 26 0 18 19 1 18 27 0 19 20 1 19 28 1 20 21 1 20 29 1 21 22 1 21 30 1
		 22 23 1 22 31 1 23 24 1 23 32 1 24 25 1 24 33 1 25 26 1 25 34 1 26 35 0 27 28 1 27 36 0
		 28 29 1 28 37 1 29 30 1 29 38 1 30 31 1 30 39 1 31 32 1 31 40 1 32 33 1 32 41 1 33 34 1
		 33 42 1 34 35 1 34 43 1 35 44 0 36 37 1 36 45 0 37 38 1 37 46 1 38 39 1 38 47 1 39 40 1
		 39 48 1 40 41 1 40 49 1 41 42 1 41 50 1 42 43 1 42 51 1 43 44 1 43 52 1 44 53 0 45 46 1
		 45 54 0 46 47 1 46 55 1 47 48 1 47 56 1 48 49 1 48 57 1 49 50 1 49 58 1 50 51 1 50 59 1
		 51 52 1 51 60 1 52 53 1 52 61 1 53 62 0 54 55 1 54 63 0 55 56 1 55 64 1 56 57 1 56 65 1
		 57 58 1 57 66 1 58 59 1 58 67 1 59 60 1 59 68 1 60 61 1 60 69 1 61 62 1 61 70 1 62 71 0
		 63 64 1 63 72 0 64 65 1 64 73 1 65 66 1 65 74 1 66 67 1 66 75 1 67 68 1 67 76 1 68 69 1
		 68 77 1 69 70 1 69 78 1 70 71 1 70 79 1 71 80 0 72 73 0 73 74 0 74 75 0 75 76 0 76 77 0
		 77 78 0 78 79 0 79 80 0 1 9 1 2 10 1 12 2 1 13 3 1 5 13 1 15 5 1 16 6 1 17 7 1 19 9 1
		 20 10 1 21 11 1 13 21 1 23 13 1 24 14 1 16 24 1 26 16 1 28 18 1 20 28 1 30 20 1 22 30 1
		 23 31 1 33 23 1;
	setAttr ".ed[166:207]" 25 33 1 26 34 1 28 36 1 29 37 1 30 38 1 40 30 1 32 40 1
		 42 32 1 34 42 1 35 43 1 46 36 1 38 46 1 48 38 1 49 39 1 50 40 1 42 50 1 52 42 1 53 43 1
		 46 54 1 56 46 1 57 47 1 49 57 1 59 49 1 60 50 1 52 60 1 53 61 1 55 63 1 56 64 1 57 65 1
		 67 57 1 59 67 1 60 68 1 61 69 1 71 61 1 73 63 1 74 64 1 66 74 1 76 66 1 68 76 1 78 68 1
		 79 69 1 71 79 1;
	setAttr -s 128 -ch 384 ".fc[0:127]" -type "polyFaces" 
		f 3 0 144 -2
		mu 0 3 0 1 9
		f 3 -145 3 -18
		mu 0 3 9 1 10
		f 3 2 145 -4
		mu 0 3 1 2 10
		f 3 -146 5 -20
		mu 0 3 10 2 11
		f 3 7 146 4
		mu 0 3 3 12 2
		f 3 -147 -22 -6
		mu 0 3 2 12 11
		f 3 9 147 6
		mu 0 3 4 13 3
		f 3 -148 -24 -8
		mu 0 3 3 13 12
		f 3 8 148 -10
		mu 0 3 4 5 13
		f 3 -149 11 -26
		mu 0 3 13 5 14
		f 3 13 149 10
		mu 0 3 6 15 5
		f 3 -150 -28 -12
		mu 0 3 5 15 14
		f 3 15 150 12
		mu 0 3 7 16 6
		f 3 -151 -30 -14
		mu 0 3 6 16 15
		f 3 16 151 14
		mu 0 3 8 17 7
		f 3 -152 -32 -16
		mu 0 3 7 17 16
		f 3 20 152 17
		mu 0 3 10 19 9
		f 3 -153 -35 -19
		mu 0 3 9 19 18
		f 3 22 153 19
		mu 0 3 11 20 10
		f 3 -154 -37 -21
		mu 0 3 10 20 19
		f 3 24 154 21
		mu 0 3 12 21 11
		f 3 -155 -39 -23
		mu 0 3 11 21 20
		f 3 23 155 -25
		mu 0 3 12 13 21
		f 3 -156 26 -41
		mu 0 3 21 13 22
		f 3 28 156 25
		mu 0 3 14 23 13
		f 3 -157 -43 -27
		mu 0 3 13 23 22
		f 3 30 157 27
		mu 0 3 15 24 14
		f 3 -158 -45 -29
		mu 0 3 14 24 23
		f 3 29 158 -31
		mu 0 3 15 16 24
		f 3 -159 32 -47
		mu 0 3 24 16 25
		f 3 33 159 31
		mu 0 3 17 26 16
		f 3 -160 -49 -33
		mu 0 3 16 26 25
		f 3 37 160 34
		mu 0 3 19 28 18
		f 3 -161 -52 -36
		mu 0 3 18 28 27
		f 3 36 161 -38
		mu 0 3 19 20 28
		f 3 -162 39 -54
		mu 0 3 28 20 29
		f 3 41 162 38
		mu 0 3 21 30 20
		f 3 -163 -56 -40
		mu 0 3 20 30 29
		f 3 40 163 -42
		mu 0 3 21 22 30
		f 3 -164 43 -58
		mu 0 3 30 22 31
		f 3 42 164 -44
		mu 0 3 22 23 31
		f 3 -165 45 -60
		mu 0 3 31 23 32
		f 3 47 165 44
		mu 0 3 24 33 23
		f 3 -166 -62 -46
		mu 0 3 23 33 32
		f 3 46 166 -48
		mu 0 3 24 25 33
		f 3 -167 49 -64
		mu 0 3 33 25 34
		f 3 48 167 -50
		mu 0 3 25 26 34
		f 3 -168 50 -66
		mu 0 3 34 26 35
		f 3 51 168 -53
		mu 0 3 27 28 36
		f 3 -169 54 -69
		mu 0 3 36 28 37
		f 3 53 169 -55
		mu 0 3 28 29 37
		f 3 -170 56 -71
		mu 0 3 37 29 38
		f 3 55 170 -57
		mu 0 3 29 30 38
		f 3 -171 58 -73
		mu 0 3 38 30 39
		f 3 60 171 57
		mu 0 3 31 40 30
		f 3 -172 -75 -59
		mu 0 3 30 40 39
		f 3 59 172 -61
		mu 0 3 31 32 40
		f 3 -173 62 -77
		mu 0 3 40 32 41
		f 3 64 173 61
		mu 0 3 33 42 32
		f 3 -174 -79 -63
		mu 0 3 32 42 41
		f 3 63 174 -65
		mu 0 3 33 34 42
		f 3 -175 66 -81
		mu 0 3 42 34 43
		f 3 65 175 -67
		mu 0 3 34 35 43
		f 3 -176 67 -83
		mu 0 3 43 35 44
		f 3 71 176 68
		mu 0 3 37 46 36
		f 3 -177 -86 -70
		mu 0 3 36 46 45
		f 3 70 177 -72
		mu 0 3 37 38 46
		f 3 -178 73 -88
		mu 0 3 46 38 47
		f 3 75 178 72
		mu 0 3 39 48 38
		f 3 -179 -90 -74
		mu 0 3 38 48 47
		f 3 77 179 74
		mu 0 3 40 49 39
		f 3 -180 -92 -76
		mu 0 3 39 49 48
		f 3 79 180 76
		mu 0 3 41 50 40
		f 3 -181 -94 -78
		mu 0 3 40 50 49
		f 3 78 181 -80
		mu 0 3 41 42 50
		f 3 -182 81 -96
		mu 0 3 50 42 51
		f 3 83 182 80
		mu 0 3 43 52 42
		f 3 -183 -98 -82
		mu 0 3 42 52 51
		f 3 84 183 82
		mu 0 3 44 53 43
		f 3 -184 -100 -84
		mu 0 3 43 53 52
		f 3 85 184 -87
		mu 0 3 45 46 54
		f 3 -185 88 -103
		mu 0 3 54 46 55
		f 3 90 185 87
		mu 0 3 47 56 46
		f 3 -186 -105 -89
		mu 0 3 46 56 55
		f 3 92 186 89
		mu 0 3 48 57 47
		f 3 -187 -107 -91
		mu 0 3 47 57 56
		f 3 91 187 -93
		mu 0 3 48 49 57
		f 3 -188 94 -109
		mu 0 3 57 49 58
		f 3 96 188 93
		mu 0 3 50 59 49
		f 3 -189 -111 -95
		mu 0 3 49 59 58
		f 3 98 189 95
		mu 0 3 51 60 50
		f 3 -190 -113 -97
		mu 0 3 50 60 59
		f 3 97 190 -99
		mu 0 3 51 52 60
		f 3 -191 100 -115
		mu 0 3 60 52 61
		f 3 99 191 -101
		mu 0 3 52 53 61
		f 3 -192 101 -117
		mu 0 3 61 53 62
		f 3 102 192 -104
		mu 0 3 54 55 63
		f 3 -193 105 -120
		mu 0 3 63 55 64
		f 3 104 193 -106
		mu 0 3 55 56 64
		f 3 -194 107 -122
		mu 0 3 64 56 65
		f 3 106 194 -108
		mu 0 3 56 57 65
		f 3 -195 109 -124
		mu 0 3 65 57 66
		f 3 111 195 108
		mu 0 3 58 67 57
		f 3 -196 -126 -110
		mu 0 3 57 67 66
		f 3 110 196 -112
		mu 0 3 58 59 67
		f 3 -197 113 -128
		mu 0 3 67 59 68
		f 3 112 197 -114
		mu 0 3 59 60 68
		f 3 -198 115 -130
		mu 0 3 68 60 69
		f 3 114 198 -116
		mu 0 3 60 61 69
		f 3 -199 117 -132
		mu 0 3 69 61 70
		f 3 118 199 116
		mu 0 3 62 71 61
		f 3 -200 -134 -118
		mu 0 3 61 71 70
		f 3 122 200 119
		mu 0 3 64 73 63
		f 3 -201 -137 -121
		mu 0 3 63 73 72
		f 3 124 201 121
		mu 0 3 65 74 64
		f 3 -202 -138 -123
		mu 0 3 64 74 73
		f 3 123 202 -125
		mu 0 3 65 66 74
		f 3 -203 126 -139
		mu 0 3 74 66 75
		f 3 128 203 125
		mu 0 3 67 76 66
		f 3 -204 -140 -127
		mu 0 3 66 76 75
		f 3 127 204 -129
		mu 0 3 67 68 76
		f 3 -205 130 -141
		mu 0 3 76 68 77
		f 3 132 205 129
		mu 0 3 69 78 68
		f 3 -206 -142 -131
		mu 0 3 68 78 77
		f 3 134 206 131
		mu 0 3 70 79 69
		f 3 -207 -143 -133
		mu 0 3 69 79 78
		f 3 133 207 -135
		mu 0 3 70 71 79
		f 3 -208 135 -144
		mu 0 3 79 71 80;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode polyMoveVertex -n "polyMoveVertex10";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 7 "vtx[10:16]" "vtx[19:25]" "vtx[28:34]" "vtx[37:43]" "vtx[46:52]" "vtx[55:61]" "vtx[64:69]";
	setAttr ".ix" -type "matrix" 3.8391887761238634 0 0 0 0 3.8391887761238634 0 0 0 0 3.8391887761238634 0
		 24.089538372128832 0 0 1;
	setAttr ".ws" yes;
	setAttr ".t" -type "double3" 0 2.5619387467641079 0 ;
	setAttr ".pvt" -type "float3" 24.089539 3.3365211 4.5766697e-07 ;
	setAttr ".ran" 0.4724000096321106;
	setAttr ".rs" 705331307;
createNode materialInfo -n "materialInfo7";
createNode shadingEngine -n "blinn3SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode blinn -n "blinn3";
	setAttr ".c" -type "float3" 1 0.43113333 0 ;
	setAttr ".ic" -type "float3" 0.10257114 0.10257114 0.10257114 ;
createNode lightLinker -s -n "lightLinker1";
	setAttr -s 9 ".lnk";
	setAttr -s 9 ".slnk";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :renderPartition;
	setAttr -s 9 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 9 ".s";
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
connectAttr "polyMoveVertex10.out" "pPlaneShape2.i";
connectAttr "polySurfaceShape2.o" "polyMoveVertex10.ip";
connectAttr "pPlaneShape2.wm" "polyMoveVertex10.mp";
connectAttr "blinn3SG.msg" "materialInfo7.sg";
connectAttr "blinn3.msg" "materialInfo7.m";
connectAttr "blinn3.oc" "blinn3SG.ss";
connectAttr "pPlaneShape2.iog" "blinn3SG.dsm" -na;
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "blinn3SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "blinn3SG.message" ":defaultLightSet.message";
connectAttr "blinn3SG.pa" ":renderPartition.st" -na;
connectAttr "blinn3.msg" ":defaultShaderList1.s" -na;
// End of lava.ma
