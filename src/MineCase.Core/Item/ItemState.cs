﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MineCase.Item
{
    public enum ItemId : uint
    {
        Air = 0,
        Stone = 1,
        Granite = 2,
        PolishedGranite = 3,
        Diorite = 4,
        PolishedDiorite = 5,
        Andesite = 6,
        PolishedAndesite = 7,
        GrassBlock = 8,
        Dirt = 9,
        CoarseDirt = 10,
        Podzol = 11,
        Cobblestone = 12,
        OakPlanks = 13,
        SprucePlanks = 14,
        BirchPlanks = 15,
        JunglePlanks = 16,
        AcaciaPlanks = 17,
        DarkOakPlanks = 18,
        OakSapling = 19,
        SpruceSapling = 20,
        BirchSapling = 21,
        JungleSapling = 22,
        AcaciaSapling = 23,
        DarkOakSapling = 24,
        Bedrock = 25,
        Sand = 26,
        RedSand = 27,
        Gravel = 28,
        GoldOre = 29,
        IronOre = 30,
        CoalOre = 31,
        OakLog = 32,
        SpruceLog = 33,
        BirchLog = 34,
        JungleLog = 35,
        AcaciaLog = 36,
        DarkOakLog = 37,
        StrippedOakLog = 38,
        StrippedSpruceLog = 39,
        StrippedBirchLog = 40,
        StrippedJungleLog = 41,
        StrippedAcaciaLog = 42,
        StrippedDarkOakLog = 43,
        StrippedOakWood = 44,
        StrippedSpruceWood = 45,
        StrippedBirchWood = 46,
        StrippedJungleWood = 47,
        StrippedAcaciaWood = 48,
        StrippedDarkOakWood = 49,
        OakWood = 50,
        SpruceWood = 51,
        BirchWood = 52,
        JungleWood = 53,
        AcaciaWood = 54,
        DarkOakWood = 55,
        OakLeaves = 56,
        SpruceLeaves = 57,
        BirchLeaves = 58,
        JungleLeaves = 59,
        AcaciaLeaves = 60,
        DarkOakLeaves = 61,
        Sponge = 62,
        WetSponge = 63,
        Glass = 64,
        LapisOre = 65,
        LapisBlock = 66,
        Dispenser = 67,
        Sandstone = 68,
        ChiseledSandstone = 69,
        CutSandstone = 70,
        NoteBlock = 71,
        PoweredRail = 72,
        DetectorRail = 73,
        StickyPiston = 74,
        Cobweb = 75,
        Grass = 76,
        Fern = 77,
        DeadBush = 78,
        Seagrass = 79,
        SeaPickle = 80,
        Piston = 81,
        WhiteWool = 82,
        OrangeWool = 83,
        MagentaWool = 84,
        LightBlueWool = 85,
        YellowWool = 86,
        LimeWool = 87,
        PinkWool = 88,
        GrayWool = 89,
        LightGrayWool = 90,
        CyanWool = 91,
        PurpleWool = 92,
        BlueWool = 93,
        BrownWool = 94,
        GreenWool = 95,
        RedWool = 96,
        BlackWool = 97,
        Dandelion = 98,
        Poppy = 99,
        BlueOrchid = 100,
        Allium = 101,
        AzureBluet = 102,
        RedTulip = 103,
        OrangeTulip = 104,
        WhiteTulip = 105,
        PinkTulip = 106,
        OxeyeDaisy = 107,
        Cornflower = 108,
        LilyOfTheValley = 109,
        WitherRose = 110,
        BrownMushroom = 111,
        RedMushroom = 112,
        GoldBlock = 113,
        IronBlock = 114,
        OakSlab = 115,
        SpruceSlab = 116,
        BirchSlab = 117,
        JungleSlab = 118,
        AcaciaSlab = 119,
        DarkOakSlab = 120,
        StoneSlab = 121,
        SmoothStoneSlab = 122,
        SandstoneSlab = 123,
        CutSandstoneSlab = 124,
        PetrifiedOakSlab = 125,
        CobblestoneSlab = 126,
        BrickSlab = 127,
        StoneBrickSlab = 128,
        NetherBrickSlab = 129,
        QuartzSlab = 130,
        RedSandstoneSlab = 131,
        CutRedSandstoneSlab = 132,
        PurpurSlab = 133,
        PrismarineSlab = 134,
        PrismarineBrickSlab = 135,
        DarkPrismarineSlab = 136,
        SmoothQuartz = 137,
        SmoothRedSandstone = 138,
        SmoothSandstone = 139,
        SmoothStone = 140,
        Bricks = 141,
        Tnt = 142,
        Bookshelf = 143,
        MossyCobblestone = 144,
        Obsidian = 145,
        Torch = 146,
        EndRod = 147,
        ChorusPlant = 148,
        ChorusFlower = 149,
        PurpurBlock = 150,
        PurpurPillar = 151,
        PurpurStairs = 152,
        Spawner = 153,
        OakStairs = 154,
        Chest = 155,
        DiamondOre = 156,
        DiamondBlock = 157,
        CraftingTable = 158,
        Farmland = 159,
        Furnace = 160,
        Ladder = 161,
        Rail = 162,
        CobblestoneStairs = 163,
        Lever = 164,
        StonePressurePlate = 165,
        OakPressurePlate = 166,
        SprucePressurePlate = 167,
        BirchPressurePlate = 168,
        JunglePressurePlate = 169,
        AcaciaPressurePlate = 170,
        DarkOakPressurePlate = 171,
        RedstoneOre = 172,
        RedstoneTorch = 173,
        StoneButton = 174,
        Snow = 175,
        Ice = 176,
        SnowBlock = 177,
        Cactus = 178,
        Clay = 179,
        Jukebox = 180,
        OakFence = 181,
        SpruceFence = 182,
        BirchFence = 183,
        JungleFence = 184,
        AcaciaFence = 185,
        DarkOakFence = 186,
        Pumpkin = 187,
        CarvedPumpkin = 188,
        Netherrack = 189,
        SoulSand = 190,
        Glowstone = 191,
        JackOLantern = 192,
        OakTrapdoor = 193,
        SpruceTrapdoor = 194,
        BirchTrapdoor = 195,
        JungleTrapdoor = 196,
        AcaciaTrapdoor = 197,
        DarkOakTrapdoor = 198,
        InfestedStone = 199,
        InfestedCobblestone = 200,
        InfestedStoneBricks = 201,
        InfestedMossyStoneBricks = 202,
        InfestedCrackedStoneBricks = 203,
        InfestedChiseledStoneBricks = 204,
        StoneBricks = 205,
        MossyStoneBricks = 206,
        CrackedStoneBricks = 207,
        ChiseledStoneBricks = 208,
        BrownMushroomBlock = 209,
        RedMushroomBlock = 210,
        MushroomStem = 211,
        IronBars = 212,
        GlassPane = 213,
        Melon = 214,
        Vine = 215,
        OakFenceGate = 216,
        SpruceFenceGate = 217,
        BirchFenceGate = 218,
        JungleFenceGate = 219,
        AcaciaFenceGate = 220,
        DarkOakFenceGate = 221,
        BrickStairs = 222,
        StoneBrickStairs = 223,
        Mycelium = 224,
        LilyPad = 225,
        NetherBricks = 226,
        NetherBrickFence = 227,
        NetherBrickStairs = 228,
        EnchantingTable = 229,
        EndPortalFrame = 230,
        EndStone = 231,
        EndStoneBricks = 232,
        DragonEgg = 233,
        RedstoneLamp = 234,
        SandstoneStairs = 235,
        EmeraldOre = 236,
        EnderChest = 237,
        TripwireHook = 238,
        EmeraldBlock = 239,
        SpruceStairs = 240,
        BirchStairs = 241,
        JungleStairs = 242,
        CommandBlock = 243,
        Beacon = 244,
        CobblestoneWall = 245,
        MossyCobblestoneWall = 246,
        BrickWall = 247,
        PrismarineWall = 248,
        RedSandstoneWall = 249,
        MossyStoneBrickWall = 250,
        GraniteWall = 251,
        StoneBrickWall = 252,
        NetherBrickWall = 253,
        AndesiteWall = 254,
        RedNetherBrickWall = 255,
        SandstoneWall = 256,
        EndStoneBrickWall = 257,
        DioriteWall = 258,
        OakButton = 259,
        SpruceButton = 260,
        BirchButton = 261,
        JungleButton = 262,
        AcaciaButton = 263,
        DarkOakButton = 264,
        Anvil = 265,
        ChippedAnvil = 266,
        DamagedAnvil = 267,
        TrappedChest = 268,
        LightWeightedPressurePlate = 269,
        HeavyWeightedPressurePlate = 270,
        DaylightDetector = 271,
        RedstoneBlock = 272,
        NetherQuartzOre = 273,
        Hopper = 274,
        ChiseledQuartzBlock = 275,
        QuartzBlock = 276,
        QuartzPillar = 277,
        QuartzStairs = 278,
        ActivatorRail = 279,
        Dropper = 280,
        WhiteTerracotta = 281,
        OrangeTerracotta = 282,
        MagentaTerracotta = 283,
        LightBlueTerracotta = 284,
        YellowTerracotta = 285,
        LimeTerracotta = 286,
        PinkTerracotta = 287,
        GrayTerracotta = 288,
        LightGrayTerracotta = 289,
        CyanTerracotta = 290,
        PurpleTerracotta = 291,
        BlueTerracotta = 292,
        BrownTerracotta = 293,
        GreenTerracotta = 294,
        RedTerracotta = 295,
        BlackTerracotta = 296,
        Barrier = 297,
        IronTrapdoor = 298,
        HayBlock = 299,
        WhiteCarpet = 300,
        OrangeCarpet = 301,
        MagentaCarpet = 302,
        LightBlueCarpet = 303,
        YellowCarpet = 304,
        LimeCarpet = 305,
        PinkCarpet = 306,
        GrayCarpet = 307,
        LightGrayCarpet = 308,
        CyanCarpet = 309,
        PurpleCarpet = 310,
        BlueCarpet = 311,
        BrownCarpet = 312,
        GreenCarpet = 313,
        RedCarpet = 314,
        BlackCarpet = 315,
        Terracotta = 316,
        CoalBlock = 317,
        PackedIce = 318,
        AcaciaStairs = 319,
        DarkOakStairs = 320,
        SlimeBlock = 321,
        GrassPath = 322,
        Sunflower = 323,
        Lilac = 324,
        RoseBush = 325,
        Peony = 326,
        TallGrass = 327,
        LargeFern = 328,
        WhiteStainedGlass = 329,
        OrangeStainedGlass = 330,
        MagentaStainedGlass = 331,
        LightBlueStainedGlass = 332,
        YellowStainedGlass = 333,
        LimeStainedGlass = 334,
        PinkStainedGlass = 335,
        GrayStainedGlass = 336,
        LightGrayStainedGlass = 337,
        CyanStainedGlass = 338,
        PurpleStainedGlass = 339,
        BlueStainedGlass = 340,
        BrownStainedGlass = 341,
        GreenStainedGlass = 342,
        RedStainedGlass = 343,
        BlackStainedGlass = 344,
        WhiteStainedGlassPane = 345,
        OrangeStainedGlassPane = 346,
        MagentaStainedGlassPane = 347,
        LightBlueStainedGlassPane = 348,
        YellowStainedGlassPane = 349,
        LimeStainedGlassPane = 350,
        PinkStainedGlassPane = 351,
        GrayStainedGlassPane = 352,
        LightGrayStainedGlassPane = 353,
        CyanStainedGlassPane = 354,
        PurpleStainedGlassPane = 355,
        BlueStainedGlassPane = 356,
        BrownStainedGlassPane = 357,
        GreenStainedGlassPane = 358,
        RedStainedGlassPane = 359,
        BlackStainedGlassPane = 360,
        Prismarine = 361,
        PrismarineBricks = 362,
        DarkPrismarine = 363,
        PrismarineStairs = 364,
        PrismarineBrickStairs = 365,
        DarkPrismarineStairs = 366,
        SeaLantern = 367,
        RedSandstone = 368,
        ChiseledRedSandstone = 369,
        CutRedSandstone = 370,
        RedSandstoneStairs = 371,
        RepeatingCommandBlock = 372,
        ChainCommandBlock = 373,
        MagmaBlock = 374,
        NetherWartBlock = 375,
        RedNetherBricks = 376,
        BoneBlock = 377,
        StructureVoid = 378,
        Observer = 379,
        ShulkerBox = 380,
        WhiteShulkerBox = 381,
        OrangeShulkerBox = 382,
        MagentaShulkerBox = 383,
        LightBlueShulkerBox = 384,
        YellowShulkerBox = 385,
        LimeShulkerBox = 386,
        PinkShulkerBox = 387,
        GrayShulkerBox = 388,
        LightGrayShulkerBox = 389,
        CyanShulkerBox = 390,
        PurpleShulkerBox = 391,
        BlueShulkerBox = 392,
        BrownShulkerBox = 393,
        GreenShulkerBox = 394,
        RedShulkerBox = 395,
        BlackShulkerBox = 396,
        WhiteGlazedTerracotta = 397,
        OrangeGlazedTerracotta = 398,
        MagentaGlazedTerracotta = 399,
        LightBlueGlazedTerracotta = 400,
        YellowGlazedTerracotta = 401,
        LimeGlazedTerracotta = 402,
        PinkGlazedTerracotta = 403,
        GrayGlazedTerracotta = 404,
        LightGrayGlazedTerracotta = 405,
        CyanGlazedTerracotta = 406,
        PurpleGlazedTerracotta = 407,
        BlueGlazedTerracotta = 408,
        BrownGlazedTerracotta = 409,
        GreenGlazedTerracotta = 410,
        RedGlazedTerracotta = 411,
        BlackGlazedTerracotta = 412,
        WhiteConcrete = 413,
        OrangeConcrete = 414,
        MagentaConcrete = 415,
        LightBlueConcrete = 416,
        YellowConcrete = 417,
        LimeConcrete = 418,
        PinkConcrete = 419,
        GrayConcrete = 420,
        LightGrayConcrete = 421,
        CyanConcrete = 422,
        PurpleConcrete = 423,
        BlueConcrete = 424,
        BrownConcrete = 425,
        GreenConcrete = 426,
        RedConcrete = 427,
        BlackConcrete = 428,
        WhiteConcretePowder = 429,
        OrangeConcretePowder = 430,
        MagentaConcretePowder = 431,
        LightBlueConcretePowder = 432,
        YellowConcretePowder = 433,
        LimeConcretePowder = 434,
        PinkConcretePowder = 435,
        GrayConcretePowder = 436,
        LightGrayConcretePowder = 437,
        CyanConcretePowder = 438,
        PurpleConcretePowder = 439,
        BlueConcretePowder = 440,
        BrownConcretePowder = 441,
        GreenConcretePowder = 442,
        RedConcretePowder = 443,
        BlackConcretePowder = 444,
        TurtleEgg = 445,
        DeadTubeCoralBlock = 446,
        DeadBrainCoralBlock = 447,
        DeadBubbleCoralBlock = 448,
        DeadFireCoralBlock = 449,
        DeadHornCoralBlock = 450,
        TubeCoralBlock = 451,
        BrainCoralBlock = 452,
        BubbleCoralBlock = 453,
        FireCoralBlock = 454,
        HornCoralBlock = 455,
        TubeCoral = 456,
        BrainCoral = 457,
        BubbleCoral = 458,
        FireCoral = 459,
        HornCoral = 460,
        DeadBrainCoral = 461,
        DeadBubbleCoral = 462,
        DeadFireCoral = 463,
        DeadHornCoral = 464,
        DeadTubeCoral = 465,
        TubeCoralFan = 466,
        BrainCoralFan = 467,
        BubbleCoralFan = 468,
        FireCoralFan = 469,
        HornCoralFan = 470,
        DeadTubeCoralFan = 471,
        DeadBrainCoralFan = 472,
        DeadBubbleCoralFan = 473,
        DeadFireCoralFan = 474,
        DeadHornCoralFan = 475,
        BlueIce = 476,
        Conduit = 477,
        PolishedGraniteStairs = 478,
        SmoothRedSandstoneStairs = 479,
        MossyStoneBrickStairs = 480,
        PolishedDioriteStairs = 481,
        MossyCobblestoneStairs = 482,
        EndStoneBrickStairs = 483,
        StoneStairs = 484,
        SmoothSandstoneStairs = 485,
        SmoothQuartzStairs = 486,
        GraniteStairs = 487,
        AndesiteStairs = 488,
        RedNetherBrickStairs = 489,
        PolishedAndesiteStairs = 490,
        DioriteStairs = 491,
        PolishedGraniteSlab = 492,
        SmoothRedSandstoneSlab = 493,
        MossyStoneBrickSlab = 494,
        PolishedDioriteSlab = 495,
        MossyCobblestoneSlab = 496,
        EndStoneBrickSlab = 497,
        SmoothSandstoneSlab = 498,
        SmoothQuartzSlab = 499,
        GraniteSlab = 500,
        AndesiteSlab = 501,
        RedNetherBrickSlab = 502,
        PolishedAndesiteSlab = 503,
        DioriteSlab = 504,
        Scaffolding = 505,
        IronDoor = 506,
        OakDoor = 507,
        SpruceDoor = 508,
        BirchDoor = 509,
        JungleDoor = 510,
        AcaciaDoor = 511,
        DarkOakDoor = 512,
        Repeater = 513,
        Comparator = 514,
        StructureBlock = 515,
        Jigsaw = 516,
        Composter = 517,
        TurtleHelmet = 518,
        Scute = 519,
        IronShovel = 520,
        IronPickaxe = 521,
        IronAxe = 522,
        FlintAndSteel = 523,
        Apple = 524,
        Bow = 525,
        Arrow = 526,
        Coal = 527,
        Charcoal = 528,
        Diamond = 529,
        IronIngot = 530,
        GoldIngot = 531,
        IronSword = 532,
        WoodenSword = 533,
        WoodenShovel = 534,
        WoodenPickaxe = 535,
        WoodenAxe = 536,
        StoneSword = 537,
        StoneShovel = 538,
        StonePickaxe = 539,
        StoneAxe = 540,
        DiamondSword = 541,
        DiamondShovel = 542,
        DiamondPickaxe = 543,
        DiamondAxe = 544,
        Stick = 545,
        Bowl = 546,
        MushroomStew = 547,
        GoldenSword = 548,
        GoldenShovel = 549,
        GoldenPickaxe = 550,
        GoldenAxe = 551,
        String = 552,
        Feather = 553,
        Gunpowder = 554,
        WoodenHoe = 555,
        StoneHoe = 556,
        IronHoe = 557,
        DiamondHoe = 558,
        GoldenHoe = 559,
        WheatSeeds = 560,
        Wheat = 561,
        Bread = 562,
        LeatherHelmet = 563,
        LeatherChestplate = 564,
        LeatherLeggings = 565,
        LeatherBoots = 566,
        ChainmailHelmet = 567,
        ChainmailChestplate = 568,
        ChainmailLeggings = 569,
        ChainmailBoots = 570,
        IronHelmet = 571,
        IronChestplate = 572,
        IronLeggings = 573,
        IronBoots = 574,
        DiamondHelmet = 575,
        DiamondChestplate = 576,
        DiamondLeggings = 577,
        DiamondBoots = 578,
        GoldenHelmet = 579,
        GoldenChestplate = 580,
        GoldenLeggings = 581,
        GoldenBoots = 582,
        Flint = 583,
        Porkchop = 584,
        CookedPorkchop = 585,
        Painting = 586,
        GoldenApple = 587,
        EnchantedGoldenApple = 588,
        OakSign = 589,
        SpruceSign = 590,
        BirchSign = 591,
        JungleSign = 592,
        AcaciaSign = 593,
        DarkOakSign = 594,
        Bucket = 595,
        WaterBucket = 596,
        LavaBucket = 597,
        Minecart = 598,
        Saddle = 599,
        Redstone = 600,
        Snowball = 601,
        OakBoat = 602,
        Leather = 603,
        MilkBucket = 604,
        PufferfishBucket = 605,
        SalmonBucket = 606,
        CodBucket = 607,
        TropicalFishBucket = 608,
        Brick = 609,
        ClayBall = 610,
        SugarCane = 611,
        Kelp = 612,
        DriedKelpBlock = 613,
        Bamboo = 614,
        Paper = 615,
        Book = 616,
        SlimeBall = 617,
        ChestMinecart = 618,
        FurnaceMinecart = 619,
        Egg = 620,
        Compass = 621,
        FishingRod = 622,
        Clock = 623,
        GlowstoneDust = 624,
        Cod = 625,
        Salmon = 626,
        TropicalFish = 627,
        Pufferfish = 628,
        CookedCod = 629,
        CookedSalmon = 630,
        InkSac = 631,
        RedDye = 632,
        GreenDye = 633,
        CocoaBeans = 634,
        LapisLazuli = 635,
        PurpleDye = 636,
        CyanDye = 637,
        LightGrayDye = 638,
        GrayDye = 639,
        PinkDye = 640,
        LimeDye = 641,
        YellowDye = 642,
        LightBlueDye = 643,
        MagentaDye = 644,
        OrangeDye = 645,
        BoneMeal = 646,
        BlueDye = 647,
        BrownDye = 648,
        BlackDye = 649,
        WhiteDye = 650,
        Bone = 651,
        Sugar = 652,
        Cake = 653,
        WhiteBed = 654,
        OrangeBed = 655,
        MagentaBed = 656,
        LightBlueBed = 657,
        YellowBed = 658,
        LimeBed = 659,
        PinkBed = 660,
        GrayBed = 661,
        LightGrayBed = 662,
        CyanBed = 663,
        PurpleBed = 664,
        BlueBed = 665,
        BrownBed = 666,
        GreenBed = 667,
        RedBed = 668,
        BlackBed = 669,
        Cookie = 670,
        FilledMap = 671,
        Shears = 672,
        MelonSlice = 673,
        DriedKelp = 674,
        PumpkinSeeds = 675,
        MelonSeeds = 676,
        Beef = 677,
        CookedBeef = 678,
        Chicken = 679,
        CookedChicken = 680,
        RottenFlesh = 681,
        EnderPearl = 682,
        BlazeRod = 683,
        GhastTear = 684,
        GoldNugget = 685,
        NetherWart = 686,
        Potion = 687,
        GlassBottle = 688,
        SpiderEye = 689,
        FermentedSpiderEye = 690,
        BlazePowder = 691,
        MagmaCream = 692,
        BrewingStand = 693,
        Cauldron = 694,
        EnderEye = 695,
        GlisteringMelonSlice = 696,
        BatSpawnEgg = 697,
        BeeSpawnEgg = 698,
        BlazeSpawnEgg = 699,
        CatSpawnEgg = 700,
        CaveSpiderSpawnEgg = 701,
        ChickenSpawnEgg = 702,
        CodSpawnEgg = 703,
        CowSpawnEgg = 704,
        CreeperSpawnEgg = 705,
        DolphinSpawnEgg = 706,
        DonkeySpawnEgg = 707,
        DrownedSpawnEgg = 708,
        ElderGuardianSpawnEgg = 709,
        EndermanSpawnEgg = 710,
        EndermiteSpawnEgg = 711,
        EvokerSpawnEgg = 712,
        FoxSpawnEgg = 713,
        GhastSpawnEgg = 714,
        GuardianSpawnEgg = 715,
        HorseSpawnEgg = 716,
        HuskSpawnEgg = 717,
        LlamaSpawnEgg = 718,
        MagmaCubeSpawnEgg = 719,
        MooshroomSpawnEgg = 720,
        MuleSpawnEgg = 721,
        OcelotSpawnEgg = 722,
        PandaSpawnEgg = 723,
        ParrotSpawnEgg = 724,
        PhantomSpawnEgg = 725,
        PigSpawnEgg = 726,
        PillagerSpawnEgg = 727,
        PolarBearSpawnEgg = 728,
        PufferfishSpawnEgg = 729,
        RabbitSpawnEgg = 730,
        RavagerSpawnEgg = 731,
        SalmonSpawnEgg = 732,
        SheepSpawnEgg = 733,
        ShulkerSpawnEgg = 734,
        SilverfishSpawnEgg = 735,
        SkeletonSpawnEgg = 736,
        SkeletonHorseSpawnEgg = 737,
        SlimeSpawnEgg = 738,
        SpiderSpawnEgg = 739,
        SquidSpawnEgg = 740,
        StraySpawnEgg = 741,
        TraderLlamaSpawnEgg = 742,
        TropicalFishSpawnEgg = 743,
        TurtleSpawnEgg = 744,
        VexSpawnEgg = 745,
        VillagerSpawnEgg = 746,
        VindicatorSpawnEgg = 747,
        WanderingTraderSpawnEgg = 748,
        WitchSpawnEgg = 749,
        WitherSkeletonSpawnEgg = 750,
        WolfSpawnEgg = 751,
        ZombieSpawnEgg = 752,
        ZombieHorseSpawnEgg = 753,
        ZombiePigmanSpawnEgg = 754,
        ZombieVillagerSpawnEgg = 755,
        ExperienceBottle = 756,
        FireCharge = 757,
        WritableBook = 758,
        WrittenBook = 759,
        Emerald = 760,
        ItemFrame = 761,
        FlowerPot = 762,
        Carrot = 763,
        Potato = 764,
        BakedPotato = 765,
        PoisonousPotato = 766,
        Map = 767,
        GoldenCarrot = 768,
        SkeletonSkull = 769,
        WitherSkeletonSkull = 770,
        PlayerHead = 771,
        ZombieHead = 772,
        CreeperHead = 773,
        DragonHead = 774,
        CarrotOnAStick = 775,
        NetherStar = 776,
        PumpkinPie = 777,
        FireworkRocket = 778,
        FireworkStar = 779,
        EnchantedBook = 780,
        NetherBrick = 781,
        Quartz = 782,
        TntMinecart = 783,
        HopperMinecart = 784,
        PrismarineShard = 785,
        PrismarineCrystals = 786,
        Rabbit = 787,
        CookedRabbit = 788,
        RabbitStew = 789,
        RabbitFoot = 790,
        RabbitHide = 791,
        ArmorStand = 792,
        IronHorseArmor = 793,
        GoldenHorseArmor = 794,
        DiamondHorseArmor = 795,
        LeatherHorseArmor = 796,
        Lead = 797,
        NameTag = 798,
        CommandBlockMinecart = 799,
        Mutton = 800,
        CookedMutton = 801,
        WhiteBanner = 802,
        OrangeBanner = 803,
        MagentaBanner = 804,
        LightBlueBanner = 805,
        YellowBanner = 806,
        LimeBanner = 807,
        PinkBanner = 808,
        GrayBanner = 809,
        LightGrayBanner = 810,
        CyanBanner = 811,
        PurpleBanner = 812,
        BlueBanner = 813,
        BrownBanner = 814,
        GreenBanner = 815,
        RedBanner = 816,
        BlackBanner = 817,
        EndCrystal = 818,
        ChorusFruit = 819,
        PoppedChorusFruit = 820,
        Beetroot = 821,
        BeetrootSeeds = 822,
        BeetrootSoup = 823,
        DragonBreath = 824,
        SplashPotion = 825,
        SpectralArrow = 826,
        TippedArrow = 827,
        LingeringPotion = 828,
        Shield = 829,
        Elytra = 830,
        SpruceBoat = 831,
        BirchBoat = 832,
        JungleBoat = 833,
        AcaciaBoat = 834,
        DarkOakBoat = 835,
        TotemOfUndying = 836,
        ShulkerShell = 837,
        IronNugget = 838,
        KnowledgeBook = 839,
        DebugStick = 840,
        MusicDisc13 = 841,
        MusicDiscCat = 842,
        MusicDiscBlocks = 843,
        MusicDiscChirp = 844,
        MusicDiscFar = 845,
        MusicDiscMall = 846,
        MusicDiscMellohi = 847,
        MusicDiscStal = 848,
        MusicDiscStrad = 849,
        MusicDiscWard = 850,
        MusicDisc11 = 851,
        MusicDiscWait = 852,
        Trident = 853,
        PhantomMembrane = 854,
        NautilusShell = 855,
        HeartOfTheSea = 856,
        Crossbow = 857,
        SuspiciousStew = 858,
        Loom = 859,
        FlowerBannerPattern = 860,
        CreeperBannerPattern = 861,
        SkullBannerPattern = 862,
        MojangBannerPattern = 863,
        GlobeBannerPattern = 864,
        Barrel = 865,
        Smoker = 866,
        BlastFurnace = 867,
        CartographyTable = 868,
        FletchingTable = 869,
        Grindstone = 870,
        Lectern = 871,
        SmithingTable = 872,
        Stonecutter = 873,
        Bell = 874,
        Lantern = 875,
        SweetBerries = 876,
        Campfire = 877,
        Honeycomb = 878,
        BeeNest = 879,
        Beehive = 880,
        HoneyBottle = 881,
        HoneyBlock = 882,
        HoneycombBlock = 883,
    }

    public enum CoalType : uint
    {
        Coal = 0,
        Charcoal = 1
    }

    public enum GoldenAppleType : uint
    {
        GoldenApple = 0,
        EnchantedGoldenApple = 1
    }

    public enum DyeType : uint
    {
        InkSac = 0,
        RoseRed = 1,
        CactusGreen = 2,
        CocoaBeans = 3,
        LapisLazuli = 4,
        PurpleDye = 5,
        CyanDye = 6,
        LightGrayDye = 7,
        GrayDye = 8,
        PinkDye = 9,
        LimeDye = 10,
        DandelionYellow = 11,
        LightBlueDye = 12,
        MagentaDye = 13,
        OrangeDye = 14,
        BoneMeal = 15
    }

    public enum RawFishType : uint
    {
        RawFish = 0,
        RawSalmon = 1,
        Clownfish = 2,
        Pufferfish = 3
    }

    public enum CookedFishType : uint
    {
        CookedFish = 0,
        CookedSalmon = 1
    }

    public enum HeadForItemType : uint
    {
        SkeletonSkull = 0,
        WitherSkeletonSkull = 1,
        ZombieHead = 2,
        Head = 3,
        CreeperHead = 4,
        DragonHead = 5
    }

    public enum PotionNameType : uint
    {
        WaterBottle = 0,
        Regeneration1 = 1,
        Swiftness1 = 2,
        FireResistance1 = 3,
        Poison1 = 4,
        Healing1 = 5,
        NightVision1 = 6,
        Clear = 7,
        Weakness1 = 8,
        Strength1 = 9,
        Slowness1 = 10,
        Leaping1 = 11,
        Harming1 = 12,
        WaterBreathing1 = 13,
        Invisibility1 = 14,
        Thin = 15,
        Awkward = 16,
        Regeneration2 = 17,
        Swiftness2 = 18,
        FireResistance2 = 19,
        Poison2 = 20,
        Healing2 = 21,
        NightVision2 = 22,
        Bungling = 23,
        Weakness2 = 24,
        Strength2 = 25,
        Slowness2 = 26,
        Leaping2 = 27,
        Harming2 = 28,
        WaterBreathing2 = 29,
        Invisibility2 = 30,
        Debonair = 31,
        Thick = 32,
        Regeneration3 = 33,
        Swiftness3 = 34,
        FireResistance3 = 35,
        Poison3 = 36,
        Healing3 = 37,
        NightVision3 = 38,
        Charming = 39,
        Weakness3 = 40,
        Strength3 = 41,
        Slowness3 = 42,
        Leaping3 = 43,
        Harming3 = 44,
        WaterBreathing3 = 45,
        Invisibility3 = 46,
        Sparkling = 47,
        Potent = 48,
        Regeneration4 = 49,
        Swiftness4 = 50,
        FireResistance4 = 51,
        Poison4 = 52,
        Healing4 = 53,
        NightVision4 = 54,
        Rank = 55,
        Weakness4 = 56,
        Strength4 = 57,
        Slowness4 = 58,
        Leaping4 = 59,
        Harming4 = 60,
        WaterBreathing4 = 61,
        Invisibility4 = 62,
        Stinky = 63
    }

    public enum PotionEffectType : uint
    {
        None = 0,
        Regeneration = 1,
        Speed = 2,
        FireResistance = 3,
        Poison = 4,
        InstantHealth = 5,
        NightVision = 6,
        Weakness = 8,
        Strength = 9,
        Slowness = 10,
        JumpBoost = 11,
        InstantDamage = 12,
        WaterBreathing = 13,
        Invisibility = 14
    }

    public enum PotionTierType : uint
    {
        Base = 0,
        LessDuration = 32
    }

    public enum PotionExDurationType : uint
    {
        Base = 0,
        MoreDuration = 64
    }

    public enum SplashPotionType : uint
    {
        DrinkablePotion = 0,
        SplashPotion = 16384
    }

    public struct ItemState : IEquatable<ItemState>
    {
        public uint Id { get; set; }

        public uint MetaValue { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ItemState && Equals((ItemState)obj);
        }

        public bool Equals(ItemState other)
        {
            return Id == other.Id &&
                   MetaValue == other.MetaValue;
        }

        public override int GetHashCode()
        {
            var hashCode = -81208087;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + MetaValue.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(ItemState state1, ItemState state2)
        {
            return state1.Equals(state2);
        }

        public static bool operator !=(ItemState state1, ItemState state2)
        {
            return !(state1 == state2);
        }
    }
}
