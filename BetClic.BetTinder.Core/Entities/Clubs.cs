﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BetClic.BetTinder.Core.Entities
{
    public class StringValue : System.Attribute
    {
        private string _value;

        public StringValue(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

    }

    public class BetMarkets
    {
        public enum BetType
        {
            [StringValue("Both Teams to Score")]
            BothTeamsScore = 1,
            [StringValue("Home Team Wins")]
            HomeTeamWins = 2,
            [StringValue("Away Team Wins")]
            AwayTeamWins = 3,
            [StringValue("Home Team Wins Both Halfs")]
            HomeTeamWinsBothHalfs = 4,
            [StringValue("No Goals Scored")]
            NoGolsScored = 5,
            [StringValue("Over 3.5")]
            Over35 = 6,
            [StringValue("Over 2.5")]
            Over25 = 7,
            [StringValue("Under 1.5")]
            Under15 = 8
        }

        public enum BetOn
        {
            [StringValue("Yes")]Yes =1,
            [StringValue("No")]
            No = 2,            
        }
    }

    public class Clubs
    {
        public enum FootballClubs
        {
            [StringValue("A.F.C. Blackpool")]
            AFCBlackpool = 1,
            [StringValue("A.F.C. Bournemouth")]
            AFCBournemouth = 2,
            [StringValue("A.F.C. Bridgnorth")]
            AFCBridgnorth = 3,
            [StringValue("A.F.C. Croydon Athletic")]
            AFCCroydonAthletic = 4,
            [StringValue("A.F.C. Darwen")]
            AFCDarwen = 5,
            [StringValue("A.F.C. Dunstable")]
            AFCDunstable = 6,
            [StringValue("A.F.C. Emley")]
            AFCEmley = 7,
            [StringValue("A.F.C. Fylde")]
            AFCFylde = 8,
            [StringValue("A.F.C. Hayes")]
            AFCHayes = 9,
            [StringValue("A.F.C. Hornchurch")]
            AFCHornchurch = 10,
            [StringValue("A.F.C. Kempston Rovers")]
            AFCKempstonRovers = 11,
            [StringValue("A.F.C. Liverpool")]
            AFCLiverpool = 12,
            [StringValue("A.F.C. Mansfield")]
            AFCMansfield = 13,
            [StringValue("A.F.C. Portchester")]
            AFCPortchester = 14,
            [StringValue("A.F.C. Rushden  Diamonds")]
            AFCRushdenDiamonds = 15,
            [StringValue("A.F.C. St Austell")]
            AFCStAustell = 16,
            [StringValue("A.F.C. Sudbury")]
            AFCSudbury = 17,
            [StringValue("A.F.C. Sudbury Reserves")]
            AFCSudburyReserves = 18,
            [StringValue("A.F.C. Telford United")]
            AFCTelfordUnited = 19,
            [StringValue("A.F.C. Totton")]
            AFCTotton = 20,
            [StringValue("A.F.C. Uckfield Town")]
            AFCUckfieldTown = 21,
            [StringValue("A.F.C. Wimbledon")]
            AFCWimbledon = 22,
            [StringValue("A.F.C. Wulfrunians")]
            AFCWulfrunians = 23,
            [StringValue("Abbey Hey")]
            AbbeyHey = 24,
            [StringValue("Abingdon United")]
            AbingdonUnited = 25,
            [StringValue("Accrington Stanley")]
            AccringtonStanley = 26,
            [StringValue("Albion Sports")]
            AlbionSports = 27,
            [StringValue("Aldershot Town")]
            AldershotTown = 28,
            [StringValue("Alfreton Town")]
            AlfretonTown = 29,
            [StringValue("Almondsbury UWE")]
            AlmondsburyUWE = 30,
            [StringValue("Alnwick Town")]
            AlnwickTown = 31,
            [StringValue("Alresford Town")]
            AlresfordTown = 32,
            [StringValue("Alsager Town")]
            AlsagerTown = 33,
            [StringValue("Alton Town")]
            AltonTown = 34,
            [StringValue("Altrincham")]
            Altrincham = 35,
            [StringValue("Alvechurch")]
            Alvechurch = 36,
            [StringValue("Alvis Sporting Club")]
            AlvisSportingClub = 37,
            [StringValue("Amersham Town")]
            AmershamTown = 38,
            [StringValue("Amesbury Town")]
            AmesburyTown = 39,
            [StringValue("Ampthill Town")]
            AmpthillTown = 40,
            [StringValue("Andover New Street")]
            AndoverNewStreet = 41,
            [StringValue("Andover Town")]
            AndoverTown = 42,
            [StringValue("Anstey Nomads")]
            AnsteyNomads = 43,
            [StringValue("Ardley United")]
            ArdleyUnited = 44,
            [StringValue("Arlesey Town")]
            ArleseyTown = 45,
            [StringValue("Arlesey Town Reserves")]
            ArleseyTownReserves = 46,
            [StringValue("Armthorpe Welfare")]
            ArmthorpeWelfare = 47,
            [StringValue("Arnold Town")]
            ArnoldTown = 48,
            [StringValue("Arsenal")]
            Arsenal = 49,
            [StringValue("Arundel")]
            Arundel = 50,
            [StringValue("Ascot United")]
            AscotUnited = 51,
            [StringValue("Ash United")]
            AshUnited = 52,
            [StringValue("Ashby Ivanhoe")]
            AshbyIvanhoe = 53,
            [StringValue("Ashford Town")]
            AshfordTown = 54,
            [StringValue("Ashford United")]
            AshfordUnited = 55,
            [StringValue("Ashington")]
            Ashington = 56,
            [StringValue("Ashton  Backwell United")]
            AshtonBackwellUnited = 57,
            [StringValue("Ashton Athletic")]
            AshtonAthletic = 58,
            [StringValue("Ashton Town")]
            AshtonTown = 59,
            [StringValue("Ashton United")]
            AshtonUnited = 60,
            [StringValue("Aston Villa")]
            AstonVilla = 61,
            [StringValue("Athersley Recreation")]
            AthersleyRecreation = 62,
            [StringValue("Atherstone Town")]
            AtherstoneTown = 63,
            [StringValue("Atherton Collieries")]
            AthertonCollieries = 64,
            [StringValue("Atherton Laburnum Rovers")]
            AthertonLaburnumRovers = 65,
            [StringValue("Aveley")]
            Aveley = 66,
            [StringValue("Aylesbury")]
            Aylesbury = 67,
            [StringValue("Aylesbury United")]
            AylesburyUnited = 68,
            [StringValue("Aylestone Park")]
            AylestonePark = 69,
            [StringValue("Bacup  Rossendale Borough")]
            BacupRossendaleBorough = 70,
            [StringValue("Badshot Lea")]
            BadshotLea = 71,
            [StringValue("Baldock Town")]
            BaldockTown = 72,
            [StringValue("Bamber Bridge")]
            BamberBridge = 73,
            [StringValue("Banbury United")]
            BanburyUnited = 74,
            [StringValue("Banstead Athletic")]
            BansteadAthletic = 75,
            [StringValue("Bardon Hill")]
            BardonHill = 76,
            [StringValue("Barking")]
            Barking = 77,
            [StringValue("Barkingside")]
            Barkingside = 78,
            [StringValue("Barnet")]
            Barnet = 79,
            [StringValue("Barnoldswick Town")]
            BarnoldswickTown = 80,
            [StringValue("Barnsley")]
            Barnsley = 81,
            [StringValue("Barnstaple Town")]
            BarnstapleTown = 82,
            [StringValue("Barnton")]
            Barnton = 83,
            [StringValue("Barrow")]
            Barrow = 84,
            [StringValue("Barrow Town")]
            BarrowTown = 85,
            [StringValue("Barton Rovers")]
            BartonRovers = 86,
            [StringValue("Barton Town Old Boys")]
            BartonTownOldBoys = 87,
            [StringValue("Barwell")]
            Barwell = 88,
            [StringValue("Basford United")]
            BasfordUnited = 89,
            [StringValue("Bashley")]
            Bashley = 90,
            [StringValue("Basildon United")]
            BasildonUnited = 91,
            [StringValue("Basingstoke Town")]
            BasingstokeTown = 92,
            [StringValue("Bath City")]
            BathCity = 93,
            [StringValue("Beaconsfield SYCOB")]
            BeaconsfieldSYCOB = 94,
            [StringValue("Beckenham Town")]
            BeckenhamTown = 95,
            [StringValue("Bedfont  Feltham")]
            BedfontFeltham = 96,
            [StringValue("Bedfont Sports")]
            BedfontSports = 97,
            [StringValue("Bedford")]
            Bedford = 98,
            [StringValue("Bedford Town")]
            BedfordTown = 99,
            [StringValue("Bedlington Terriers")]
            BedlingtonTerriers = 100,
            [StringValue("Bedworth United")]
            BedworthUnited = 101,
            [StringValue("Belper Town")]
            BelperTown = 102,
            [StringValue("Bemerton Heath Harlequins")]
            BemertonHeathHarlequins = 103,
            [StringValue("Berkhamsted")]
            Berkhamsted = 104,
            [StringValue("Bewdley Town")]
            BewdleyTown = 105,
            [StringValue("Bexhill United")]
            BexhillUnited = 106,
            [StringValue("Bideford")]
            Bideford = 107,
            [StringValue("Biggleswade Town")]
            BiggleswadeTown = 108,
            [StringValue("Biggleswade United")]
            BiggleswadeUnited = 109,
            [StringValue("Billericay Town")]
            BillericayTown = 110,
            [StringValue("Billingham Synthonia")]
            BillinghamSynthonia = 111,
            [StringValue("Billingham Town")]
            BillinghamTown = 112,
            [StringValue("Bilston Town")]
            BilstonTown = 113,
            [StringValue("Binfield")]
            Binfield = 114,
            [StringValue("Birmingham City")]
            BirminghamCity = 115,
            [StringValue("Birtley Town")]
            BirtleyTown = 116,
            [StringValue("Bishop Auckland")]
            BishopAuckland = 117,
            [StringValue("Bishop Sutton")]
            BishopSutton = 118,
            [StringValue("Bishop's Cleeve")]
            BishopCleeve = 119,
            [StringValue("Bishop's Stortford")]
            BishopStortford = 120,
            [StringValue("Bitton")]
            Bitton = 121,
            [StringValue("Blaby  Whetstone Athletic")]
            BlabyWhetstoneAthletic = 122,
            [StringValue("Black Country Rangers")]
            BlackCountryRangers = 123,
            [StringValue("Blackburn Rovers")]
            BlackburnRovers = 124,
            [StringValue("Blackfield  Langley")]
            BlackfieldLangley = 125,
            [StringValue("Blackpool")]
            Blackpool = 126,
            [StringValue("Blackstones")]
            Blackstones = 127,
            [StringValue("Blyth Spartans")]
            BlythSpartans = 128,
            [StringValue("Bodmin Town")]
            BodminTown = 129,
            [StringValue("Bognor Regis Town")]
            BognorRegisTown = 130,
            [StringValue("Boldmere St. Michaels")]
            BoldmereStMichaels = 131,
            [StringValue("Bolehall Swifts")]
            BolehallSwifts = 132,
            [StringValue("Bolton Wanderers")]
            BoltonWanderers = 133,
            [StringValue("Bootle")]
            Bootle = 134,
            [StringValue("Boreham Wood")]
            BorehamWood = 135,
            [StringValue("Borrowash Victoria")]
            BorrowashVictoria = 136,
            [StringValue("Boston Town")]
            BostonTown = 137,
            [StringValue("Boston United")]
            BostonUnited = 138,
            [StringValue("Bottesford Town")]
            BottesfordTown = 139,
            [StringValue("Bourne Town")]
            BourneTown = 140,
            [StringValue("Bournemouth")]
            Bournemouth = 141,
            [StringValue("Bovey Tracey")]
            BoveyTracey = 142,
            [StringValue("Bowers  Pitsea")]
            BowersPitsea = 143,
            [StringValue("Brackley Town")]
            BrackleyTown = 144,
            [StringValue("Brackley Town Development")]
            BrackleyTownDevelopment = 145,
            [StringValue("Bracknell Town")]
            BracknellTown = 146,
            [StringValue("Bradford City")]
            BradfordCity = 147,
            [StringValue("Bradford Park Avenue")]
            BradfordParkAvenue = 148,
            [StringValue("Bradford Town")]
            BradfordTown = 149,
            [StringValue("Braintree Town")]
            BraintreeTown = 150,
            [StringValue("Braintree Town Reserves")]
            BraintreeTownReserves = 151,
            [StringValue("Brandon United")]
            BrandonUnited = 152,
            [StringValue("Brantham Athletic")]
            BranthamAthletic = 153,
            [StringValue("Brentford")]
            Brentford = 154,
            [StringValue("Brentwood Town")]
            BrentwoodTown = 155,
            [StringValue("Bridgwater Town")]
            BridgwaterTown = 156,
            [StringValue("Bridlington Town")]
            BridlingtonTown = 157,
            [StringValue("Bearsted")]
            Bearsted = 158,
            [StringValue("Bridport")]
            Bridport = 159,
            [StringValue("Brigg Town")]
            BriggTown = 160,
            [StringValue("Brighouse Town")]
            BrighouseTown = 161,
            [StringValue("Brightlingsea Regent")]
            BrightlingseaRegent = 162,
            [StringValue("Brighton  Hove Albion")]
            BrightonHoveAlbion = 163,
            [StringValue("Brimscombe  Thrupp")]
            BrimscombeThrupp = 164,
            [StringValue("Brislington")]
            Brislington = 165,
            [StringValue("Bristol City")]
            BristolCity = 166,
            [StringValue("Bristol Manor Farm")]
            BristolManorFarm = 167,
            [StringValue("Bristol Rovers")]
            BristolRovers = 168,
            [StringValue("Broadbridge Heath")]
            BroadbridgeHeath = 169,
            [StringValue("Brockenhurst")]
            Brockenhurst = 170,
            [StringValue("Brocton")]
            Brocton = 171,
            [StringValue("Bromley")]
            Bromley = 172,
            [StringValue("Bromsgrove Sporting")]
            BromsgroveSporting = 173,
            [StringValue("Broxbourne Borough")]
            BroxbourneBorough = 174,
            [StringValue("Buckingham Athletic")]
            BuckinghamAthletic = 175,
            [StringValue("Buckingham Town")]
            BuckinghamTown = 176,
            [StringValue("Buckland Athletic")]
            BucklandAthletic = 177,
            [StringValue("Bugbrooke St Michaels")]
            BugbrookeStMichaels = 178,
            [StringValue("Burgess Hill Town")]
            BurgessHillTown = 179,
            [StringValue("Burnham")]
            Burnham = 180,
            [StringValue("Burnham Reserves")]
            BurnhamReserves = 181,
            [StringValue("Burnham Ramblers")]
            BurnhamRamblers = 182,
            [StringValue("Burnley")]
            Burnley = 183,
            [StringValue("Burscough")]
            Burscough = 184,
            [StringValue("Burton Albion")]
            BurtonAlbion = 185,
            [StringValue("Burton Park Wanderers")]
            BurtonParkWanderers = 186,
            [StringValue("Bury")]
            Bury = 187,
            [StringValue("Bury Town")]
            BuryTown = 188,
            [StringValue("Bush Hill Rangers")]
            BushHillRangers = 189,
            [StringValue("Buxton")]
            Buxton = 190,
            [StringValue("Cadbury Athletic")]
            CadburyAthletic = 191,
            [StringValue("Cadbury Heath")]
            CadburyHeath = 192,
            [StringValue("Callington Town")]
            CallingtonTown = 193,
            [StringValue("Calne Town")]
            CalneTown = 194,
            [StringValue("Camberley Town")]
            CamberleyTown = 195,
            [StringValue("Cambridge City")]
            CambridgeCity = 196,
            [StringValue("Cambridge United")]
            CambridgeUnited = 197,
            [StringValue("Camelford")]
            Camelford = 198,
            [StringValue("Cammell Laird 1907")]
            CammellLaird1907 = 199,
            [StringValue("Canterbury City")]
            CanterburyCity = 200,
            [StringValue("Canvey Island")]
            CanveyIsland = 201,
            [StringValue("Cardiff City (WE)")]
            CardiffCityWE = 202,
            [StringValue("Carlisle United")]
            CarlisleUnited = 203,
            [StringValue("Carlton Town")]
            CarltonTown = 204,
            [StringValue("Carshalton Athletic")]
            CarshaltonAthletic = 205,
            [StringValue("Carterton")]
            Carterton = 206,
            [StringValue("Causeway United")]
            CausewayUnited = 207,
            [StringValue("CB Hounslow United")]
            CBHounslowUnited = 208,
            [StringValue("Celtic Nation")]
            CelticNation = 209,
            [StringValue("Chadderton")]
            Chadderton = 210,
            [StringValue("Chalfont St Peter")]
            ChalfontStPeter = 211,
            [StringValue("Chalfont Wasps")]
            ChalfontWasps = 212,
            [StringValue("Chard Town")]
            ChardTown = 213,
            [StringValue("Charlton Athletic")]
            CharltonAthletic = 214,
            [StringValue("Chasetown")]
            Chasetown = 215,
            [StringValue("Chatham Town")]
            ChathamTown = 216,
            [StringValue("Cheadle Town")]
            CheadleTown = 217,
            [StringValue("Cheddar")]
            Cheddar = 218,
            [StringValue("Chelmsford City")]
            ChelmsfordCity = 219,
            [StringValue("Chelsea")]
            Chelsea = 220,
            [StringValue("Cheltenham Saracens")]
            CheltenhamSaracens = 221,
            [StringValue("Cheltenham Town")]
            CheltenhamTown = 222,
            [StringValue("Chertsey Town")]
            ChertseyTown = 223,
            [StringValue("Chesham United")]
            CheshamUnited = 224,
            [StringValue("Chesham United Reserves")]
            CheshamUnitedReserves = 225,
            [StringValue("Cheshunt")]
            Cheshunt = 226,
            [StringValue("Chessington  Hook United")]
            ChessingtonHookUnited = 227,
            [StringValue("Chester")]
            Chester = 228,
            [StringValue("Chesterfield")]
            Chesterfield = 229,
            [StringValue("Chester-le-Street Town")]
            ChesterleStreetTown = 230,
            [StringValue("Chichester City")]
            ChichesterCity = 231,
            [StringValue("Chinnor")]
            Chinnor = 232,
            [StringValue("Chippenham Park")]
            ChippenhamPark = 233,
            [StringValue("Chippenham Town")]
            ChippenhamTown = 234,
            [StringValue("Chipstead")]
            Chipstead = 235,
            [StringValue("Chorley")]
            Chorley = 236,
            [StringValue("Christchurch")]
            Christchurch = 237,
            [StringValue("Cinderford Town")]
            CinderfordTown = 238,
            [StringValue("Cirencester Town")]
            CirencesterTown = 239,
            [StringValue("Cirencester Town Development")]
            CirencesterTownDevelopment = 240,
            [StringValue("Clanfield")]
            Clanfield = 241,
            [StringValue("Clapton")]
            Clapton = 242,
            [StringValue("Cleethorpes Town")]
            CleethorpesTown = 243,
            [StringValue("Clevedon Town")]
            ClevedonTown = 244,
            [StringValue("Clipstone")]
            Clipstone = 245,
            [StringValue("Clitheroe")]
            Clitheroe = 246,
            [StringValue("Coalville Town")]
            CoalvilleTown = 247,
            [StringValue("Cobham")]
            Cobham = 248,
            [StringValue("Cockfosters")]
            Cockfosters = 249,
            [StringValue("Codicote")]
            Codicote = 250,
            [StringValue("Cogenhoe United")]
            CogenhoeUnited = 251,
            [StringValue("Colchester United")]
            ColchesterUnited = 252,
            [StringValue("Coleshill Town")]
            ColeshillTown = 253,
            [StringValue("Colliers Wood United")]
            ColliersWoodUnited = 254,
            [StringValue("Colne")]
            Colne = 255,
            [StringValue("Colney Heath")]
            ColneyHeath = 256,
            [StringValue("Colwyn Bay (WE)")]
            ColwynBayWE = 257,
            [StringValue("Concord Rangers")]
            ConcordRangers = 258,
            [StringValue("Congleton Town")]
            CongletonTown = 259,
            [StringValue("Consett")]
            Consett = 260,
            [StringValue("Continental Star")]
            ContinentalStar = 261,
            [StringValue("Corby Town")]
            CorbyTown = 262,
            [StringValue("Corinthian")]
            Corinthian = 263,
            [StringValue("Corinthian-Casuals")]
            CorinthianCasuals = 264,
            [StringValue("Cornard United")]
            CornardUnited = 265,
            [StringValue("Corsham Town")]
            CorshamTown = 266,
            [StringValue("Cove")]
            Cove = 267,
            [StringValue("Coventry City")]
            CoventryCity = 268,
            [StringValue("Coventry Copsewood")]
            CoventryCopsewood = 269,
            [StringValue("Coventry Sphinx")]
            CoventrySphinx = 270,
            [StringValue("Cowes Sports")]
            CowesSports = 271,
            [StringValue("Cradley Town")]
            CradleyTown = 272,
            [StringValue("Crawley Down Gatwick")]
            CrawleyDownGatwick = 273,
            [StringValue("Crawley Green")]
            CrawleyGreen = 274,
            [StringValue("Crawley Town")]
            CrawleyTown = 275,
            [StringValue("Cray Valley Paper Mills")]
            CrayValleyPaperMills = 276,
            [StringValue("Cray Wanderers")]
            CrayWanderers = 277,
            [StringValue("Crewe Alexandra")]
            CreweAlexandra = 278,
            [StringValue("Cribbs")]
            Cribbs = 279,
            [StringValue("Crockenhill")]
            Crockenhill = 280,
            [StringValue("Crook Town")]
            CrookTown = 281,
            [StringValue("Crowborough Athletic")]
            CrowboroughAthletic = 282,
            [StringValue("Croydon")]
            Croydon = 283,
            [StringValue("Crystal Palace")]
            CrystalPalace = 284,
            [StringValue("Cullompton Rangers")]
            CullomptonRangers = 285,
            [StringValue("Curzon Ashton")]
            CurzonAshton = 286,
            [StringValue("Dagenham  Redbridge")]
            DagenhamRedbridge = 287,
            [StringValue("Daisy Hill")]
            DaisyHill = 288,
            [StringValue("Darlington 1883")]
            Darlington1883 = 289,
            [StringValue("Darlington Railway Athletic")]
            DarlingtonRailwayAthletic = 290,
            [StringValue("Dartford")]
            Dartford = 291,
            [StringValue("Daventry Town")]
            DaventryTown = 292,
            [StringValue("Deal Town")]
            DealTown = 293,
            [StringValue("Debenham LC")]
            DebenhamLC = 294,
            [StringValue("Deeping Rangers")]
            DeepingRangers = 295,
            [StringValue("Derby County")]
            DerbyCounty = 296,
            [StringValue("Dereham Town")]
            DerehamTown = 297,
            [StringValue("Dereham Town Reserves")]
            DerehamTownReserves = 298,
            [StringValue("Desborough Town")]
            DesboroughTown = 299,
            [StringValue("Devizes Town")]
            DevizesTown = 300,
            [StringValue("Didcot Town")]
            DidcotTown = 301,
            [StringValue("Didcot Town Reserves")]
            DidcotTownReserves = 302,
            [StringValue("Diss Town")]
            DissTown = 303,
            [StringValue("Doncaster Rovers")]
            DoncasterRovers = 304,
            [StringValue("Dorchester Town")]
            DorchesterTown = 305,
            [StringValue("Dorking")]
            Dorking = 306,
            [StringValue("Dorking Wanderers")]
            DorkingWanderers = 307,
            [StringValue("Dover Athletic")]
            DoverAthletic = 308,
            [StringValue("Downham Town")]
            DownhamTown = 309,
            [StringValue("Downton")]
            Downton = 310,
            [StringValue("Dronfield Town")]
            DronfieldTown = 311,
            [StringValue("Droylsden")]
            Droylsden = 312,
            [StringValue("Dudley Sports")]
            DudleySports = 313,
            [StringValue("Dudley Town")]
            DudleyTown = 314,
            [StringValue("Dulwich Hamlet")]
            DulwichHamlet = 315,
            [StringValue("Dunkirk")]
            Dunkirk = 316,
            [StringValue("Dunstable Town")]
            DunstableTown = 317,
            [StringValue("Dunston UTS")]
            DunstonUTS = 318,
            [StringValue("Durham City")]
            DurhamCity = 319,
            [StringValue("Easington Sports")]
            EasingtonSports = 320,
            [StringValue("East Cowes Victoria Athletic")]
            EastCowesVictoriaAthletic = 321,
            [StringValue("East Grinstead Town")]
            EastGrinsteadTown = 322,
            [StringValue("East Preston")]
            EastPreston = 323,
            [StringValue("East Thurrock United")]
            EastThurrockUnited = 324,
            [StringValue("Eastbourne Borough")]
            EastbourneBorough = 325,
            [StringValue("Eastbourne Town")]
            EastbourneTown = 326,
            [StringValue("Eastbourne United Association")]
            EastbourneUnitedAssociation = 327,
            [StringValue("Eastleigh")]
            Eastleigh = 328,
            [StringValue("Ebbsfleet United")]
            EbbsfleetUnited = 329,
            [StringValue("Eccleshall")]
            Eccleshall = 330,
            [StringValue("Eccleshill United")]
            EccleshillUnited = 331,
            [StringValue("Edgware Town")]
            EdgwareTown = 332,
            [StringValue("Egham Town")]
            EghamTown = 333,
            [StringValue("Elburton Villa")]
            ElburtonVilla = 334,
            [StringValue("Ellesmere Rangers")]
            EllesmereRangers = 335,
            [StringValue("Ellistown  Ibstock United")]
            EllistownIbstockUnited = 336,
            [StringValue("Elmore")]
            Elmore = 337,
            [StringValue("Eltham Palace")]
            ElthamPalace = 338,
            [StringValue("Ely City")]
            ElyCity = 339,
            [StringValue("Enfield 1893")]
            Enfield1893 = 340,
            [StringValue("Enfield Town")]
            EnfieldTown = 341,
            [StringValue("Epsom  Ewell")]
            EpsomEwell = 342,
            [StringValue("Epsom Athletic")]
            EpsomAthletic = 343,
            [StringValue("Erith  Belvedere")]
            ErithBelvedere = 344,
            [StringValue("Erith Town")]
            ErithTown = 345,
            [StringValue("Esh Winning")]
            EshWinning = 346,
            [StringValue("Eton Manor")]
            EtonManor = 347,
            [StringValue("Eversley  California")]
            EversleyCalifornia = 348,
            [StringValue("Everton")]
            Everton = 349,
            [StringValue("Evesham United")]
            EveshamUnited = 350,
            [StringValue("Exeter City")]
            ExeterCity = 351,
            [StringValue("Exmouth Town")]
            ExmouthTown = 352,
            [StringValue("Eynesbury Rovers")]
            EynesburyRovers = 353,
            [StringValue("F.C. Clacton")]
            FCClacton = 354,
            [StringValue("F.C. Halifax Town")]
            FCHalifaxTown = 355,
            [StringValue("F.C. Romania")]
            FCRomania = 356,
            [StringValue("F.C. United of Manchester")]
            FCUnitedofManchester = 357,
            [StringValue("Fairford Town")]
            FairfordTown = 358,
            [StringValue("Fakenham Town")]
            FakenhamTown = 359,
            [StringValue("Falmouth Town")]
            FalmouthTown = 360,
            [StringValue("Fareham Town")]
            FarehamTown = 361,
            [StringValue("Farleigh Rovers")]
            FarleighRovers = 362,
            [StringValue("Farnborough")]
            Farnborough = 363,
            [StringValue("Farnham Town")]
            FarnhamTown = 364,
            [StringValue("Farsley")]
            Farsley = 365,
            [StringValue("Faversham Town")]
            FavershamTown = 366,
            [StringValue("Fawley")]
            Fawley = 367,
            [StringValue("Felixstowe  Walton United")]
            FelixstoweWaltonUnited = 368,
            [StringValue("Finchampstead")]
            Finchampstead = 369,
            [StringValue("Fisher")]
            Fisher = 370,
            [StringValue("Flackwell Heath")]
            FlackwellHeath = 371,
            [StringValue("Fleet Spurs")]
            FleetSpurs = 372,
            [StringValue("Fleet Town")]
            FleetTown = 373,
            [StringValue("Fleetwood Town")]
            FleetwoodTown = 374,
            [StringValue("Folkestone Invicta")]
            FolkestoneInvicta = 375,
            [StringValue("Folland Sports")]
            FollandSports = 376,
            [StringValue("Forest Green Rovers")]
            ForestGreenRovers = 377,
            [StringValue("Frickley Athletic")]
            FrickleyAthletic = 378,
            [StringValue("Frimley Green")]
            FrimleyGreen = 379,
            [StringValue("Frome Town")]
            FromeTown = 380,
            [StringValue("Fulham")]
            Fulham = 381,
            [StringValue("Gainsborough Trinity")]
            GainsboroughTrinity = 382,
            [StringValue("Garforth Town")]
            GarforthTown = 383,
            [StringValue("Gateshead")]
            Gateshead = 384,
            [StringValue("Gedling Miners Welfare")]
            GedlingMinersWelfare = 385,
            [StringValue("Gillingham")]
            Gillingham = 386,
            [StringValue("Gillingham Town")]
            GillinghamTown = 387,
            [StringValue("Glasshoughton Welfare")]
            GlasshoughtonWelfare = 388,
            [StringValue("Glebe")]
            Glebe = 389,
            [StringValue("Glossop North End")]
            GlossopNorthEnd = 390,
            [StringValue("Gloucester City")]
            GloucesterCity = 391,
            [StringValue("Godalming Town")]
            GodalmingTown = 392,
            [StringValue("Godmanchester Rovers")]
            GodmanchesterRovers = 393,
            [StringValue("Godolphin Atlantic")]
            GodolphinAtlantic = 394,
            [StringValue("Goole")]
            Goole = 395,
            [StringValue("Gorleston")]
            Gorleston = 396,
            [StringValue("Gornal Athletic")]
            GornalAthletic = 397,
            [StringValue("Gosport Borough")]
            GosportBorough = 398,
            [StringValue("Graham Street Prims")]
            GrahamStreetPrims = 399,
            [StringValue("Grantham Town")]
            GranthamTown = 400,
            [StringValue("Gravesham Borough")]
            GraveshamBorough = 401,
            [StringValue("Grays Athletic")]
            GraysAthletic = 402,
            [StringValue("Great Wakering Rovers")]
            GreatWakeringRovers = 403,
            [StringValue("Great Yarmouth Town")]
            GreatYarmouthTown = 404,
            [StringValue("Greenhouse London")]
            GreenhouseLondon = 405,
            [StringValue("Greenwich Borough")]
            GreenwichBorough = 406,
            [StringValue("Greenwood Meadows")]
            GreenwoodMeadows = 407,
            [StringValue("Gresley")]
            Gresley = 408,
            [StringValue("Grimsby Borough")]
            GrimsbyBorough = 409,
            [StringValue("Grimsby Town")]
            GrimsbyTown = 410,
            [StringValue("Guernsey")]
            Guernsey = 411,
            [StringValue("Guildford City")]
            GuildfordCity = 412,
            [StringValue("Guisborough Town")]
            GuisboroughTown = 413,
            [StringValue("Guiseley")]
            Guiseley = 414,
            [StringValue("(GS) Groundshare with Cheltenham Town.")]
            GSGroundsharewithCheltenhamTown = 415,
            [StringValue("Hadleigh United")]
            HadleighUnited = 416,
            [StringValue("Hadley")]
            Hadley = 417,
            [StringValue("Hailsham Town")]
            HailshamTown = 418,
            [StringValue("Halesowen Town")]
            HalesowenTown = 419,
            [StringValue("Hall Road Rangers")]
            HallRoadRangers = 420,
            [StringValue("Hallam")]
            Hallam = 421,
            [StringValue("Hallen")]
            Hallen = 422,
            [StringValue("Halstead Town")]
            HalsteadTown = 423,
            [StringValue("Hampton  Richmond Borough")]
            HamptonRichmondBorough = 424,
            [StringValue("Hamworthy United")]
            HamworthyUnited = 425,
            [StringValue("Hamdsworth Parramore")]
            HamdsworthParramore = 426,
            [StringValue("Hanley Town")]
            HanleyTown = 427,
            [StringValue("Hanwell Town")]
            HanwellTown = 428,
            [StringValue("Hanworth Villa")]
            HanworthVilla = 429,
            [StringValue("Harborough Town")]
            HarboroughTown = 430,
            [StringValue("Harefield United")]
            HarefieldUnited = 431,
            [StringValue("Haringey Borough")]
            HaringeyBorough = 432,
            [StringValue("Harlow Town")]
            HarlowTown = 433,
            [StringValue("Harpenden Town")]
            HarpendenTown = 434,
            [StringValue("Harrogate Railway Athletic")]
            HarrogateRailwayAthletic = 435,
            [StringValue("Harrogate Town")]
            HarrogateTown = 436,
            [StringValue("Harrow Borough")]
            HarrowBorough = 437,
            [StringValue("Harrowby United")]
            HarrowbyUnited = 438,
            [StringValue("Hartlepool United")]
            HartlepoolUnited = 439,
            [StringValue("Hartley Wintney")]
            HartleyWintney = 440,
            [StringValue("Hassocks")]
            Hassocks = 441,
            [StringValue("Hastings United")]
            HastingsUnited = 442,
            [StringValue("Hatfield Town")]
            HatfieldTown = 443,
            [StringValue("Haughmond")]
            Haughmond = 444,
            [StringValue("Havant  Waterlooville")]
            HavantWaterlooville = 445,
            [StringValue("Haverhill Borough")]
            HaverhillBorough = 446,
            [StringValue("Haverhill Rovers")]
            HaverhillRovers = 447,
            [StringValue("Hayes  Yeading United")]
            HayesYeadingUnited = 448,
            [StringValue("Haywards Heath Town")]
            HaywardsHeathTown = 449,
            [StringValue("Headington Amateurs")]
            HeadingtonAmateurs = 450,
            [StringValue("Heanor Town")]
            HeanorTown = 451,
            [StringValue("Heath Hayes")]
            HeathHayes = 452,
            [StringValue("Heather St John's")]
            HeatherStJohns = 453,
            [StringValue("Heaton Stannington")]
            HeatonStannington = 454,
            [StringValue("Hebburn Town")]
            HebburnTown = 455,
            [StringValue("Hednesford Town")]
            HednesfordTown = 456,
            [StringValue("Hemel Hempstead Town")]
            HemelHempsteadTown = 457,
            [StringValue("Hemsworth Miners Welfare")]
            HemsworthMinersWelfare = 458,
            [StringValue("Hendon")]
            Hendon = 459,
            [StringValue("Hengrove Athletic")]
            HengroveAthletic = 460,
            [StringValue("Henley Town")]
            HenleyTown = 461,
            [StringValue("Hereford United")]
            HerefordUnited = 462,
            [StringValue("Herne Bay")]
            HerneBay = 463,
            [StringValue("Hertford Town")]
            HertfordTown = 464,
            [StringValue("Heybridge Swifts")]
            HeybridgeSwifts = 465,
            [StringValue("Highgate United")]
            HighgateUnited = 466,
            [StringValue("Highmoor Ibis")]
            HighmoorIbis = 467,
            [StringValue("Highworth Town")]
            HighworthTown = 468,
            [StringValue("Hillingdon Borough")]
            HillingdonBorough = 469,
            [StringValue("Hinckley AFC")]
            HinckleyAFC = 470,
            [StringValue("Histon")]
            Histon = 471,
            [StringValue("Hitchin Town")]
            HitchinTown = 472,
            [StringValue("Hoddesdon Town")]
            HoddesdonTown = 473,
            [StringValue("Holbeach United")]
            HolbeachUnited = 474,
            [StringValue("Holbrook Sports")]
            HolbrookSports = 475,
            [StringValue("Holker Old Boys")]
            HolkerOldBoys = 476,
            [StringValue("Hollands  Blair")]
            HollandsBlair = 477,
            [StringValue("Holmer Green")]
            HolmerGreen = 478,
            [StringValue("Holmesdale")]
            Holmesdale = 479,
            [StringValue("Holwell Sports")]
            HolwellSports = 480,
            [StringValue("Holyport")]
            Holyport = 481,
            [StringValue("Hook Norton")]
            HookNorton = 482,
            [StringValue("Horley Town")]
            HorleyTown = 483,
            [StringValue("Horndean")]
            Horndean = 484,
            [StringValue("Horsham")]
            Horsham = 485,
            [StringValue("Horsham YMCA")]
            HorshamYMCA = 486,
            [StringValue("Huddersfield Town")]
            HuddersfieldTown = 487,
            [StringValue("Hull City")]
            HullCity = 488,
            [StringValue("Hullbridge Sports")]
            HullbridgeSports = 489,
            [StringValue("Hungerford Town")]
            HungerfordTown = 490,
            [StringValue("Huntingdon Town")]
            HuntingdonTown = 491,
            [StringValue("Hyde")]
            Hyde = 492,
            [StringValue("Hythe  Dibden")]
            HytheDibden = 493,
            [StringValue("Hythe Town")]
            HytheTown = 494,
            [StringValue("Ilford")]
            Ilford = 495,
            [StringValue("Ilkeston")]
            Ilkeston = 496,
            [StringValue("Ipswich Town")]
            IpswichTown = 497,
            [StringValue("Ipswich Wanderers")]
            IpswichWanderers = 498,
            [StringValue("Irchester United")]
            IrchesterUnited = 499,
            [StringValue("Irlam")]
            Irlam = 500,
            [StringValue("Ivybridge Town")]
            IvybridgeTown = 501,
            [StringValue("Jarrow Roofing Boldon CA")]
            JarrowRoofingBoldonCA = 502,
            [StringValue("Kendal Town")]
            KendalTown = 503,
            [StringValue("Kent Football United")]
            KentFootballUnited = 504,
            [StringValue("Kettering Town")]
            KetteringTown = 505,
            [StringValue("Keynsham Town")]
            KeynshamTown = 506,
            [StringValue("Kidderminster Harriers")]
            KidderminsterHarriers = 507,
            [StringValue("Kidlington")]
            Kidlington = 508,
            [StringValue("Kidsgrove Athletic")]
            KidsgroveAthletic = 509,
            [StringValue("Kimberley Miners Welfare")]
            KimberleyMinersWelfare = 510,
            [StringValue("Kings Langley")]
            KingsLangley = 511,
            [StringValue("King's Lynn Town")]
            KingsLynnTown = 512,
            [StringValue("King's Lynn Town Reserves")]
            KingsLynnTownReserves = 513,
            [StringValue("Kingstonian")]
            Kingstonian = 514,
            [StringValue("Kirby Muxloe")]
            KirbyMuxloe = 515,
            [StringValue("Kirkley  Pakefield")]
            KirkleyPakefield = 516,
            [StringValue("Knaphill")]
            Knaphill = 517,
            [StringValue("Knaresborough Town")]
            KnaresboroughTown = 518,
            [StringValue("Lancaster City")]
            LancasterCity = 519,
            [StringValue("Lancing")]
            Lancing = 520,
            [StringValue("Langford")]
            Langford = 521,
            [StringValue("Larkhall Athletic")]
            LarkhallAthletic = 522,
            [StringValue("Launceston")]
            Launceston = 523,
            [StringValue("Laverstock  Ford")]
            LaverstockFord = 524,
            [StringValue("Leamington")]
            Leamington = 525,
            [StringValue("Leatherhead")]
            Leatherhead = 526,
            [StringValue("Leeds United")]
            LeedsUnited = 527,
            [StringValue("Leek Town")]
            LeekTown = 528,
            [StringValue("Leicester City")]
            LeicesterCity = 529,
            [StringValue("Leighton Town")]
            LeightonTown = 530,
            [StringValue("Leiston")]
            Leiston = 531,
            [StringValue("Leiston Reserves")]
            LeistonReserves = 532,
            [StringValue("Letcombe")]
            Letcombe = 533,
            [StringValue("Leverstock Green")]
            LeverstockGreen = 534,
            [StringValue("Lewes")]
            Lewes = 535,
            [StringValue("Lewisham Borough")]
            LewishamBorough = 536,
            [StringValue("Leyton Orient")]
            LeytonOrient = 537,
            [StringValue("Lichfield City")]
            LichfieldCity = 538,
            [StringValue("Lincoln City")]
            LincolnCity = 539,
            [StringValue("Lincoln Moorlands Railway")]
            LincolnMoorlandsRailway = 540,
            [StringValue("Lincoln United")]
            LincolnUnited = 541,
            [StringValue("Lingfield")]
            Lingfield = 542,
            [StringValue("Litherland REMYCA")]
            LitherlandREMYCA = 543,
            [StringValue("Little Common")]
            LittleCommon = 544,
            [StringValue("Littlehampton Town")]
            LittlehamptonTown = 545,
            [StringValue("Littleton")]
            Littleton = 546,
            [StringValue("Liverpool")]
            Liverpool = 547,
            [StringValue("Liversedge")]
            Liversedge = 548,
            [StringValue("London Bari")]
            LondonBari = 549,
            [StringValue("London Colney")]
            LondonColney = 550,
            [StringValue("London Lions")]
            LondonLions = 551,
            [StringValue("London Tigers")]
            LondonTigers = 552,
            [StringValue("Long Buckby")]
            LongBuckby = 553,
            [StringValue("Long Eaton United")]
            LongEatonUnited = 554,
            [StringValue("Long Melford")]
            LongMelford = 555,
            [StringValue("Longlevens")]
            Longlevens = 556,
            [StringValue("Longwell Green Sports")]
            LongwellGreenSports = 557,
            [StringValue("Lordswood")]
            Lordswood = 558,
            [StringValue("Loughborough Dynamo")]
            LoughboroughDynamo = 559,
            [StringValue("Loughborough University")]
            LoughboroughUniversity = 560,
            [StringValue("Louth Town")]
            LouthTown = 561,
            [StringValue("Lowestoft Town")]
            LowestoftTown = 562,
            [StringValue("Loxwood")]
            Loxwood = 563,
            [StringValue("Luton Town")]
            LutonTown = 564,
            [StringValue("Lutterworth Athletic")]
            LutterworthAthletic = 565,
            [StringValue("Lydd Town")]
            LyddTown = 566,
            [StringValue("Lydney Town")]
            LydneyTown = 567,
            [StringValue("Lye Town")]
            LyeTown = 568,
            [StringValue("Lymington Town")]
            LymingtonTown = 569,
            [StringValue("Macclesfield Town")]
            MacclesfieldTown = 570,
            [StringValue("Maidenhead United")]
            MaidenheadUnited = 571,
            [StringValue("Maidstone United")]
            MaidstoneUnited = 572,
            [StringValue("Maine Road")]
            MaineRoad = 573,
            [StringValue("Maldon  Tiptree")]
            MaldonTiptree = 574,
            [StringValue("Maltby Main")]
            MaltbyMain = 575,
            [StringValue("Malvern Town")]
            MalvernTown = 576,
            [StringValue("Manchester City")]
            ManchesterCity = 577,
            [StringValue("Manchester United")]
            ManchesterUnited = 578,
            [StringValue("Mangotsfield United")]
            MangotsfieldUnited = 579,
            [StringValue("Mansfield Town")]
            MansfieldTown = 580,
            [StringValue("March Town United")]
            MarchTownUnited = 581,
            [StringValue("Margate")]
            Margate = 582,
            [StringValue("Marine")]
            Marine = 583,
            [StringValue("Market Drayton Town")]
            MarketDraytonTown = 584,
            [StringValue("Marlow")]
            Marlow = 585,
            [StringValue("Marske United")]
            MarskeUnited = 586,
            [StringValue("Matlock Town")]
            MatlockTown = 587,
            [StringValue("Melksham Town")]
            MelkshamTown = 588,
            [StringValue("Meridian VP")]
            MeridianVP = 589,
            [StringValue("Merstham")]
            Merstham = 590,
            [StringValue("Merthyr Town (WE)")]
            MerthyrTownWE = 591,
            [StringValue("Metropolitan Police")]
            MetropolitanPolice = 592,
            [StringValue("Mickleover Sports")]
            MickleoverSports = 593,
            [StringValue("Middlesbrough")]
            Middlesbrough = 594,
            [StringValue("Midhurst  Easebourne")]
            MidhurstEasebourne = 595,
            [StringValue("Mildenhall Town")]
            MildenhallTown = 596,
            [StringValue("Mile Oak")]
            MileOak = 597,
            [StringValue("Millwall")]
            Millwall = 598,
            [StringValue("Milton Keynes")]
            MiltonKeynes = 599,
            [StringValue("Milton United")]
            MiltonUnited = 600,
            [StringValue("Mole Valley S.C.R.")]
            MoleValleySCR = 601,
            [StringValue("Molesey")]
            Molesey = 602,
            [StringValue("Moneyfields")]
            Moneyfields = 603,
            [StringValue("Morecambe")]
            Morecambe = 604,
            [StringValue("Morpeth Town")]
            MorpethTown = 605,
            [StringValue("Mossley")]
            Mossley = 606,
            [StringValue("Nantwich Town")]
            NantwichTown = 607,
            [StringValue("Needham Market")]
            NeedhamMarket = 608,
            [StringValue("Needham Market Reserves")]
            NeedhamMarketReserves = 609,
            [StringValue("Nelson")]
            Nelson = 610,
            [StringValue("New College Academy")]
            NewCollegeAcademy = 611,
            [StringValue("New Mills")]
            NewMills = 612,
            [StringValue("New Milton Town")]
            NewMiltonTown = 613,
            [StringValue("Newbury")]
            Newbury = 614,
            [StringValue("Newcastle Benfield")]
            NewcastleBenfield = 615,
            [StringValue("Newcastle Town")]
            NewcastleTown = 616,
            [StringValue("Newcastle United")]
            NewcastleUnited = 617,
            [StringValue("Newham")]
            Newham = 618,
            [StringValue("Newhaven")]
            Newhaven = 619,
            [StringValue("Newmarket Town")]
            NewmarketTown = 620,
            [StringValue("Newport (IOW)")]
            NewportIOW = 621,
            [StringValue("Newport County (WE)")]
            NewportCountyWE = 622,
            [StringValue("Newport Pagnell Town")]
            NewportPagnellTown = 623,
            [StringValue("Newton Aycliffe")]
            NewtonAycliffe = 624,
            [StringValue("Newquay")]
            Newquay = 625,
            [StringValue("North Ferriby United")]
            NorthFerribyUnited = 626,
            [StringValue("North Greenford United")]
            NorthGreenfordUnited = 627,
            [StringValue("North Leigh")]
            NorthLeigh = 628,
            [StringValue("North Leigh United")]
            NorthLeighUnited = 629,
            [StringValue("North Shields")]
            NorthShields = 630,
            [StringValue("Northallerton Town")]
            NorthallertonTown = 631,
            [StringValue("Northampton ON Chenecks")]
            NorthamptonONChenecks = 632,
            [StringValue("Northampton Sileby Rangers")]
            NorthamptonSilebyRangers = 633,
            [StringValue("Northampton Spencer")]
            NorthamptonSpencer = 634,
            [StringValue("Northampton Town")]
            NorthamptonTown = 635,
            [StringValue("Northwich Flixton Villa")]
            NorthwichFlixtonVilla = 636,
            [StringValue("Northwich Victoria")]
            NorthwichVictoria = 637,
            [StringValue("Northwood")]
            Northwood = 638,
            [StringValue("Norton  Stockton Ancients")]
            NortonStocktonAncients = 639,
            [StringValue("Norton United")]
            NortonUnited = 640,
            [StringValue("Norwich City")]
            NorwichCity = 641,
            [StringValue("Norwich United")]
            NorwichUnited = 642,
            [StringValue("Nostell Miners Welfare")]
            NostellMinersWelfare = 643,
            [StringValue("Nottingham Forest")]
            NottinghamForest = 644,
            [StringValue("Notts County")]
            NottsCounty = 645,
            [StringValue("Nuneaton Griff")]
            NuneatonGriff = 646,
            [StringValue("Nuneaton Town")]
            NuneatonTown = 647,
            [StringValue("Oadby Town")]
            OadbyTown = 648,
            [StringValue("Oakwood")]
            Oakwood = 649,
            [StringValue("Odd Down")]
            OddDown = 650,
            [StringValue("Old Woodstock Town")]
            OldWoodstockTown = 651,
            [StringValue("Oldham Athletic")]
            OldhamAthletic = 652,
            [StringValue("Oldham Boro")]
            OldhamBoro = 653,
            [StringValue("Oldland Abbotonians")]
            OldlandAbbotonians = 654,
            [StringValue("Olney Town")]
            OlneyTown = 655,
            [StringValue("Orpington")]
            Orpington = 656,
            [StringValue("Ossett Albion")]
            OssettAlbion = 657,
            [StringValue("Ossett Town")]
            OssettTown = 658,
            [StringValue("Oxford City")]
            OxfordCity = 659,
            [StringValue("Oxford City Nomads")]
            OxfordCityNomads = 660,
            [StringValue("Oxford United")]
            OxfordUnited = 661,
            [StringValue("Oxhey Jets")]
            OxheyJets = 662,
            [StringValue("Padiham")]
            Padiham = 663,
            [StringValue("Pagham")]
            Pagham = 664,
            [StringValue("Parkgate")]
            Parkgate = 665,
            [StringValue("Paulton Rovers")]
            PaultonRovers = 666,
            [StringValue("Peacehaven  Telscombe")]
            PeacehavenTelscombe = 667,
            [StringValue("Pegasus Juniors")]
            PegasusJuniors = 668,
            [StringValue("Pelsall Villa")]
            PelsallVilla = 669,
            [StringValue("Penistone Church")]
            PenistoneChurch = 670,
            [StringValue("Penn  Tylers Green")]
            PennTylersGreen = 671,
            [StringValue("Penrith")]
            Penrith = 672,
            [StringValue("Pershore Town")]
            PershoreTown = 673,
            [StringValue("Peterborough Northern Star")]
            PeterboroughNorthernStar = 674,
            [StringValue("Peterborough Sports")]
            PeterboroughSports = 675,
            [StringValue("Peterborough United")]
            PeterboroughUnited = 676,
            [StringValue("Petersfield Town")]
            PetersfieldTown = 677,
            [StringValue("Pewsey Vale")]
            PewseyVale = 678,
            [StringValue("Phoenix Sports")]
            PhoenixSports = 679,
            [StringValue("Pickering Town")]
            PickeringTown = 680,
            [StringValue("Pilkington XXX")]
            PilkingtonXXX = 681,
            [StringValue("Plymouth Argyle")]
            PlymouthArgyle = 682,
            [StringValue("Plymouth Parkway")]
            PlymouthParkway = 683,
            [StringValue("Pontefract Collieries")]
            PontefractCollieries = 684,
            [StringValue("Poole Town")]
            PooleTown = 685,
            [StringValue("Port Vale")]
            PortVale = 686,
            [StringValue("Portishead Town")]
            PortisheadTown = 687,
            [StringValue("Portsmouth")]
            Portsmouth = 688,
            [StringValue("Potters Bar Town")]
            PottersBarTown = 689,
            [StringValue("Potton United")]
            PottonUnited = 690,
            [StringValue("Prescot Cables")]
            PrescotCables = 691,
            [StringValue("Preston North End")]
            PrestonNorthEnd = 692,
            [StringValue("Purton")]
            Purton = 693,
            [StringValue("Racing Club Warwick")]
            RacingClubWarwick = 694,
            [StringValue("Radcliffe Borough")]
            RadcliffeBorough = 695,
            [StringValue("Radcliffe Olympic")]
            RadcliffeOlympic = 696,
            [StringValue("Radford")]
            Radford = 697,
            [StringValue("Radstock Town")]
            RadstockTown = 698,
            [StringValue("Rainworth Miners Welfare")]
            RainworthMinersWelfare = 699,
            [StringValue("Ramsbottom United")]
            RamsbottomUnited = 700,
            [StringValue("Ramsgate")]
            Ramsgate = 701,
            [StringValue("Raunds Town")]
            RaundsTown = 702,
            [StringValue("Rayners Lane")]
            RaynersLane = 703,
            [StringValue("Raynes Park Vale")]
            RaynesParkVale = 704,
            [StringValue("Reading")]
            Reading = 705,
            [StringValue("Reading Town")]
            ReadingTown = 706,
            [StringValue("Redbridge")]
            Redbridge = 707,
            [StringValue("Redditch United")]
            RedditchUnited = 708,
            [StringValue("Redhill")]
            Redhill = 709,
            [StringValue("Retford United")]
            RetfordUnited = 710,
            [StringValue("Ringmer")]
            Ringmer = 711,
            [StringValue("Ringwood Town")]
            RingwoodTown = 712,
            [StringValue("Risborough Rangers")]
            RisboroughRangers = 713,
            [StringValue("Rocester")]
            Rocester = 714,
            [StringValue("Rochdale")]
            Rochdale = 715,
            [StringValue("Rochdale Town")]
            RochdaleTown = 716,
            [StringValue("Rochester United")]
            RochesterUnited = 717,
            [StringValue("Roman Glass St George")]
            RomanGlassStGeorge = 718,
            [StringValue("Romford")]
            Romford = 719,
            [StringValue("Romsey Town")]
            RomseyTown = 720,
            [StringValue("Romulus")]
            Romulus = 721,
            [StringValue("Rossington Main")]
            RossingtonMain = 722,
            [StringValue("Rotherham United")]
            RotherhamUnited = 723,
            [StringValue("Rothwell Corinthians")]
            RothwellCorinthians = 724,
            [StringValue("Royston Town")]
            RoystonTown = 725,
            [StringValue("Rugby Town")]
            RugbyTown = 726,
            [StringValue("Runcorn Linnets")]
            RuncornLinnets = 727,
            [StringValue("Runcorn Town")]
            RuncornTown = 728,
            [StringValue("Rushall Olympic")]
            RushallOlympic = 729,
            [StringValue("Rushden  Higham United")]
            RushdenHighamUnited = 730,
            [StringValue("Rusthall")]
            Rusthall = 731,
            [StringValue("Rustington")]
            Rustington = 732,
            [StringValue("Ryhope Colliery Welfare")]
            RyhopeCollieryWelfare = 733,
            [StringValue("Ryton  Crawcrook Albion")]
            RytonCrawcrookAlbion = 734,
            [StringValue("Saffron Walden Town")]
            SaffronWaldenTown = 735,
            [StringValue("Salford City")]
            SalfordCity = 736,
            [StringValue("Saltash United")]
            SaltashUnited = 737,
            [StringValue("Saltdean United")]
            SaltdeanUnited = 738,
            [StringValue("Sandhurst Town")]
            SandhurstTown = 739,
            [StringValue("Sawbridgeworth Town")]
            SawbridgeworthTown = 740,
            [StringValue("Scarborough Athletic")]
            ScarboroughAthletic = 741,
            [StringValue("Scunthorpe United")]
            ScunthorpeUnited = 742,
            [StringValue("Seaford Town")]
            SeafordTown = 743,
            [StringValue("Seaham Red Star")]
            SeahamRedStar = 744,
            [StringValue("Selby Town")]
            SelbyTown = 745,
            [StringValue("Selsey")]
            Selsey = 746,
            [StringValue("Seven Acre  Sidcup")]
            SevenAcreSidcup = 747,
            [StringValue("Sevenoaks Town")]
            SevenoaksTown = 748,
            [StringValue("Shaw Lane Aquaforce")]
            ShawLaneAquaforce = 749,
            [StringValue("Shawbury United")]
            ShawburyUnited = 750,
            [StringValue("Sheerwater")]
            Sheerwater = 751,
            [StringValue("Sheffield")]
            Sheffield = 752,
            [StringValue("Sheffield United")]
            SheffieldUnited = 753,
            [StringValue("Sheffield Wednesday")]
            SheffieldWednesday = 754,
            [StringValue("Sheppey United")]
            SheppeyUnited = 755,
            [StringValue("Shepshed Dynamo")]
            ShepshedDynamo = 756,
            [StringValue("Shepton Mallet")]
            SheptonMallet = 757,
            [StringValue("Sherborne Town")]
            SherborneTown = 758,
            [StringValue("Shifnal Town")]
            ShifnalTown = 759,
            [StringValue("Shildon")]
            Shildon = 760,
            [StringValue("Shirebrook Town")]
            ShirebrookTown = 761,
            [StringValue("Sholing")]
            Sholing = 762,
            [StringValue("Shoreham")]
            Shoreham = 763,
            [StringValue("Shortwood United")]
            ShortwoodUnited = 764,
            [StringValue("Shortwood United Reserves")]
            ShortwoodUnitedReserves = 765,
            [StringValue("Shrewsbury Town")]
            ShrewsburyTown = 766,
            [StringValue("Shrivenham")]
            Shrivenham = 767,
            [StringValue("Silsden")]
            Silsden = 768,
            [StringValue("Sittingbourne")]
            Sittingbourne = 769,
            [StringValue("Skelmersdale United")]
            SkelmersdaleUnited = 770,
            [StringValue("Sleaford Town")]
            SleafordTown = 771,
            [StringValue("Slimbridge")]
            Slimbridge = 772,
            [StringValue("Slough Town")]
            SloughTown = 773,
            [StringValue("Smethwick Rangers")]
            SmethwickRangers = 774,
            [StringValue("Soham Town Rangers")]
            SohamTownRangers = 775,
            [StringValue("Solihull Moors")]
            SolihullMoors = 776,
            [StringValue("South Normanton Athletic")]
            SouthNormantonAthletic = 777,
            [StringValue("South Park")]
            SouthPark = 778,
            [StringValue("South Shields")]
            SouthShields = 779,
            [StringValue("Southall")]
            Southall = 780,
            [StringValue("Southam United")]
            SouthamUnited = 781,
            [StringValue("Southampton")]
            Southampton = 782,
            [StringValue("Southend Manor")]
            SouthendManor = 783,
            [StringValue("Southend United")]
            SouthendUnited = 784,
            [StringValue("Southport")]
            Southport = 785,
            [StringValue("Spalding United")]
            SpaldingUnited = 786,
            [StringValue("Spelthorne Sports")]
            SpelthorneSports = 787,
            [StringValue("Spennymoor Town")]
            SpennymoorTown = 788,
            [StringValue("Sporting Bengal United")]
            SportingBengalUnited = 789,
            [StringValue("Sporting Khalsa")]
            SportingKhalsa = 790,
            [StringValue("Squires Gate")]
            SquiresGate = 791,
            [StringValue("St Albans City")]
            StAlbansCity = 792,
            [StringValue("St Andrews")]
            StAndrews = 793,
            [StringValue("St Blazey")]
            StBlazey = 794,
            [StringValue("St Francis Rangers")]
            StFrancisRangers = 795,
            [StringValue("St Helens Town")]
            StHelensTown = 796,
            [StringValue("St Ives Town")]
            StIvesTown = 797,
            [StringValue("St Margaretsbury")]
            StMargaretsbury = 798,
            [StringValue("St Neots Town")]
            StNeotsTown = 799,
            [StringValue("St. Neots Town Saints")]
            StNeotsTownSaints = 800,
            [StringValue("Stafford Rangers")]
            StaffordRangers = 801,
            [StringValue("Stafford Town")]
            StaffordTown = 802,
            [StringValue("Staines Lammas")]
            StainesLammas = 803,
            [StringValue("Staines Town")]
            StainesTown = 804,
            [StringValue("Stalybridge Celtic")]
            StalybridgeCeltic = 805,
            [StringValue("Stamford")]
            Stamford = 806,
            [StringValue("Stansted")]
            Stansted = 807,
            [StringValue("Stanway Rovers")]
            StanwayRovers = 808,
            [StringValue("Stapenhill")]
            Stapenhill = 809,
            [StringValue("Staveley Miners Welfare")]
            StaveleyMinersWelfare = 810,
            [StringValue("Stevenage")]
            Stevenage = 811,
            [StringValue("Stewart  Lloyds Corby")]
            StewartLloydsCorby = 812,
            [StringValue("Steyning Town")]
            SteyningTown = 813,
            [StringValue("Stockport County")]
            StockportCounty = 814,
            [StringValue("Stockport Sports")]
            StockportSports = 815,
            [StringValue("Stocksbridge Park Steels")]
            StocksbridgeParkSteels = 816,
            [StringValue("Stoke City")]
            StokeCity = 817,
            [StringValue("Stoke Gabriel")]
            StokeGabriel = 818,
            [StringValue("Stokesley Sports Club")]
            StokesleySportsClub = 819,
            [StringValue("Stony Stratford Town")]
            StonyStratfordTown = 820,
            [StringValue("Storrington")]
            Storrington = 821,
            [StringValue("Stotfold")]
            Stotfold = 822,
            [StringValue("Stourbridge")]
            Stourbridge = 823,
            [StringValue("Stourport Swifts")]
            StourportSwifts = 824,
            [StringValue("Stowmarket Town")]
            StowmarketTown = 825,
            [StringValue("Stratford Town")]
            StratfordTown = 826,
            [StringValue("Street")]
            Street = 827,
            [StringValue("Studley")]
            Studley = 828,
            [StringValue("Sun Postal Sports")]
            SunPostalSports = 829,
            [StringValue("Sunderland")]
            Sunderland = 830,
            [StringValue("Sunderland Ryhope CA")]
            SunderlandRyhopeCA = 831,
            [StringValue("Sutton Athletic")]
            SuttonAthletic = 832,
            [StringValue("Sutton Coldfield Town")]
            SuttonColdfieldTown = 833,
            [StringValue("Sutton United")]
            SuttonUnited = 834,
            [StringValue("Swaffham Town")]
            SwaffhamTown = 835,
            [StringValue("Swansea City (WE)")]
            SwanseaCityWE = 836,
            [StringValue("Swindon Supermarine")]
            SwindonSupermarine = 837,
            [StringValue("Swindon Town")]
            SwindonTown = 838,
            [StringValue("Tadcaster Albion")]
            TadcasterAlbion = 839,
            [StringValue("Tadley Calleva")]
            TadleyCalleva = 840,
            [StringValue("Takeley")]
            Takeley = 841,
            [StringValue("Tamworth")]
            Tamworth = 842,
            [StringValue("Taunton Town")]
            TauntonTown = 843,
            [StringValue("Team Bury")]
            TeamBury = 844,
            [StringValue("Team Northumbria")]
            TeamNorthumbria = 845,
            [StringValue("Team Solent")]
            TeamSolent = 846,
            [StringValue("Teversal")]
            Teversal = 847,
            [StringValue("Thackley")]
            Thackley = 848,
            [StringValue("Thame United")]
            ThameUnited = 849,
            [StringValue("Thamesmead Town")]
            ThamesmeadTown = 850,
            [StringValue("Thatcham Town")]
            ThatchamTown = 851,
            [StringValue("Thetford Town")]
            ThetfordTown = 852,
            [StringValue("Thornaby")]
            Thornaby = 853,
            [StringValue("Thrapston Town")]
            ThrapstonTown = 854,
            [StringValue("Three Bridges")]
            ThreeBridges = 855,
            [StringValue("Thurnby Nirvana")]
            ThurnbyNirvana = 856,
            [StringValue("Thurrock")]
            Thurrock = 857,
            [StringValue("Tilbury")]
            Tilbury = 858,
            [StringValue("Tipton Town")]
            TiptonTown = 859,
            [StringValue("Tiverton Town")]
            TivertonTown = 860,
            [StringValue("Tividale")]
            Tividale = 861,
            [StringValue("Tonbridge Angels")]
            TonbridgeAngels = 862,
            [StringValue("Tooting  Mitcham United")]
            TootingMitchamUnited = 863,
            [StringValue("Torpoint Athletic")]
            TorpointAthletic = 864,
            [StringValue("Torquay United")]
            TorquayUnited = 865,
            [StringValue("Tottenham Hotspur")]
            TottenhamHotspur = 866,
            [StringValue("Totton  Eling")]
            TottonEling = 867,
            [StringValue("Tow Law Town")]
            TowLawTown = 868,
            [StringValue("Tower Hamlets")]
            TowerHamlets = 869,
            [StringValue("Trafford")]
            Trafford = 870,
            [StringValue("Tranmere Rovers")]
            TranmereRovers = 871,
            [StringValue("Tring Athletic")]
            TringAthletic = 872,
            [StringValue("Truro City")]
            TruroCity = 873,
            [StringValue("Tuffley Rovers")]
            TuffleyRovers = 874,
            [StringValue("Tunbridge Wells")]
            TunbridgeWells = 875,
            [StringValue("Tytherington Rocks")]
            TytheringtonRocks = 876,
            [StringValue("United Services Portsmouth")]
            UnitedServicesPortsmouth = 877,
            [StringValue("Uttoxeter Town")]
            UttoxeterTown = 878,
            [StringValue("Uxbridge")]
            Uxbridge = 879,
            [StringValue("VCD Athletic")]
            VCDAthletic = 880,
            [StringValue("Verwood Town")]
            VerwoodTown = 881,
            [StringValue("Walsall")]
            Walsall = 882,
            [StringValue("Walsall Wood")]
            WalsallWood = 883,
            [StringValue("Walsham-le-Willows")]
            WalshamleWillows = 884,
            [StringValue("Waltham Abbey")]
            WalthamAbbey = 885,
            [StringValue("Waltham Forest")]
            WalthamForest = 886,
            [StringValue("Walton Casuals")]
            WaltonCasuals = 887,
            [StringValue("Walton  Hersham")]
            WaltonHersham = 888,
            [StringValue("Wantage Town")]
            WantageTown = 889,
            [StringValue("Wantage Town Reserves")]
            WantageTownReserves = 890,
            [StringValue("Ware")]
            Ware = 891,
            [StringValue("Warminster Town")]
            WarminsterTown = 892,
            [StringValue("Warrington Town")]
            WarringtonTown = 893,
            [StringValue("Washington")]
            Washington = 894,
            [StringValue("Watford")]
            Watford = 895,
            [StringValue("Wealdstone")]
            Wealdstone = 896,
            [StringValue("Wednesfield")]
            Wednesfield = 897,
            [StringValue("Welling United")]
            WellingUnited = 898,
            [StringValue("Wellingborough Town")]
            WellingboroughTown = 899,
            [StringValue("Wellingborough Whitworth")]
            WellingboroughWhitworth = 900,
            [StringValue("Wellington (Herefordshire)")]
            WellingtonHerefordshire = 901,
            [StringValue("Wellington (Somerset)")]
            WellingtonSomerset = 902,
            [StringValue("Wellington Amateurs")]
            WellingtonAmateurs = 903,
            [StringValue("Wells City")]
            WellsCity = 904,
            [StringValue("Welton Rovers")]
            WeltonRovers = 905,
            [StringValue("Welwyn Garden City")]
            WelwynGardenCity = 906,
            [StringValue("Wembley")]
            Wembley = 907,
            [StringValue("West Allotment Celtic")]
            WestAllotmentCeltic = 908,
            [StringValue("West Auckland Town")]
            WestAucklandTown = 909,
            [StringValue("West Bromwich Albion")]
            WestBromwichAlbion = 910,
            [StringValue("West Didsbury  Chorlton")]
            WestDidsburyChorlton = 911,
            [StringValue("West Ham United")]
            WestHamUnited = 912,
            [StringValue("Westbury United")]
            WestburyUnited = 913,
            [StringValue("Westfield (Surrey)")]
            WestfieldSurrey = 914,
            [StringValue("Westfield (Sussex)")]
            WestfieldSussex = 915,
            [StringValue("Westfields")]
            Westfields = 916,
            [StringValue("Weston-super-Mare")]
            WestonsuperMare = 917,
            [StringValue("Weymouth")]
            Weymouth = 918,
            [StringValue("Whickham")]
            Whickham = 919,
            [StringValue("Whitby Town")]
            WhitbyTown = 920,
            [StringValue("Whitchurch United")]
            WhitchurchUnited = 921,
            [StringValue("Whitehawk")]
            Whitehawk = 922,
            [StringValue("Whitley Bay")]
            WhitleyBay = 923,
            [StringValue("Whitstable Town")]
            WhitstableTown = 924,
            [StringValue("Whitton United")]
            WhittonUnited = 925,
            [StringValue("Whyteleafe")]
            Whyteleafe = 926,
            [StringValue("Wick  Barnham United")]
            WickBarnhamUnited = 927,
            [StringValue("Widnes")]
            Widnes = 928,
            [StringValue("Wigan Athletic")]
            WiganAthletic = 929,
            [StringValue("Wigan Robin Park")]
            WiganRobinPark = 930,
            [StringValue("Willand Rovers")]
            WillandRovers = 931,
            [StringValue("Willenhall Town")]
            WillenhallTown = 932,
            [StringValue("Willington")]
            Willington = 933,
            [StringValue("Wimborne Town")]
            WimborneTown = 934,
            [StringValue("Wincanton Town")]
            WincantonTown = 935,
            [StringValue("Winchester City")]
            WinchesterCity = 936,
            [StringValue("Windsor")]
            Windsor = 937,
            [StringValue("Wingate  Finchley")]
            WingateFinchley = 938,
            [StringValue("Winsford United")]
            WinsfordUnited = 939,
            [StringValue("Wilslow United")]
            WilslowUnited = 940,
            [StringValue("Winterbourne United")]
            WinterbourneUnited = 941,
            [StringValue("Winterton Rangers")]
            WintertonRangers = 942,
            [StringValue("Wisbech Town")]
            WisbechTown = 943,
            [StringValue("Witham Town")]
            WithamTown = 944,
            [StringValue("Witheridge")]
            Witheridge = 945,
            [StringValue("Witton Albion")]
            WittonAlbion = 946,
            [StringValue("Wivenhoe Town")]
            WivenhoeTown = 947,
            [StringValue("Wodson Park")]
            WodsonPark = 948,
            [StringValue("Woking")]
            Woking = 949,
            [StringValue("Wokingham  Emmbrook")]
            WokinghamEmmbrook = 950,
            [StringValue("Wolverhampton Casuals")]
            WolverhamptonCasuals = 951,
            [StringValue("Wolverhampton Sporting Community")]
            WolverhamptonSportingCommunity = 952,
            [StringValue("Wolverhampton Wanderers")]
            WolverhamptonWanderers = 953,
            [StringValue("Woodbridge Town")]
            WoodbridgeTown = 954,
            [StringValue("Woodford United")]
            WoodfordUnited = 955,
            [StringValue("Woodley Town")]
            WoodleyTown = 956,
            [StringValue("Woodstock Sports")]
            WoodstockSports = 957,
            [StringValue("Wootton Bassett Town")]
            WoottonBassettTown = 958,
            [StringValue("Worcester City")]
            WorcesterCity = 959,
            [StringValue("Worcester Park")]
            WorcesterPark = 960,
            [StringValue("Workington")]
            Workington = 961,
            [StringValue("Worksop Town")]
            WorksopTown = 962,
            [StringValue("Worsbrough Bridge Athletic")]
            WorsbroughBridgeAthletic = 963,
            [StringValue("Worthing")]
            Worthing = 964,
            [StringValue("Worthing United")]
            WorthingUnited = 965,
            [StringValue("Wrexham (WE)")]
            WrexhamWE = 966,
            [StringValue("Wroxham")]
            Wroxham = 967,
            [StringValue("Wycombe Wanderers")]
            WycombeWanderers = 968

        }
    }
}