﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace LoadingBarGenerator
{
    public class LoadingBar
    {
        private Random Rand { get; }

        public LoadingBar()
        {
            Rand = new Random();
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;
            var filled = 0;

            Console.WriteLine("Welcome to Loading Bar Generator !" + Environment.NewLine);
            while (true)
            {
                if (filled < 30)
                {
                    filled += Rand.Next(1, 25);
                }
                else if (filled < 50)
                {
                    filled += Rand.Next(1, 15);
                }
                else if (filled < 70)
                {
                    filled += Rand.Next(1, 10);
                }
                else if (filled < 80)
                {
                    filled += Rand.Next(1, 7);
                }
                else if (filled < 90)
                {
                    filled += Rand.Next(1, 5);
                }
                else if (filled < 95)
                {
                    filled += Rand.Next(1, 3);
                }
                else
                {
                    filled += Rand.Next(1, 2);
                }

                if (filled >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Environment.NewLine + "ERROR - retrying...");
                    Console.ForegroundColor = ConsoleColor.White;

                    filled = 0;
                    Thread.Sleep(3000);
                    continue;
                }

                Console.Clear();
                Console.WriteLine(Environment.NewLine + "\t\t---== LOADING ==---");
                var barFill = filled / 2;

                PrintCharInColor('[');
                for (var i = 0; i < 50; i++)
                {
                    if (i < barFill)
                    {
                        PrintCharInColor('#', ConsoleColor.DarkGreen);
                    }
                    else
                    {
                        PrintCharInColor('#');
                    }
                }
                PrintCharInColor(']');
                Console.WriteLine($" {filled} %");
                PrintRandomQuote();

                Thread.Sleep(Rand.Next(300, 4000));
            }
        }

        private void PrintRandomQuote()
        {
            Console.WriteLine("\t\t" + _stupidQuotes[Rand.Next(_stupidQuotes.Count)]);
        }

        public void PrintCharInColor(char chr, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(chr);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private readonly List<string> _stupidQuotes = new List<string>
        {
            "Applying patches",
            "Clearing cache",
            "Just one more minute",
            "This is taking longer than expected",
            "Are you still there ?",
            "Multiplexing RAM",
            "Removing Deadlocks",
            "Compiling librairies",
            "Fetching SDK",
            "Updating CPU",
            "Modifying your BiOS",
            "Network issue, reconnecting",
            "git --pull",
            "git --fetch",
            "git --commit",
            "Turning it off then on again",
            "All your bases are belong to us",
            "One and one is ELEVEN ?",
            "May the force be with you",
            "Chlorinating Car Pools",
            "Partitioning Social Network",
            "Prelaminating Drywall Inventory",
            "Blurring Reality Lines",
            "Reticulating 3-Dimensional Splines",
            "Preparing Captive Simulators",
            "Capacitating Genetic Modifiers",
            "Destabilizing Orbital Payloads",
            "Sequencing Cinematic Specifiers",
            "Branching Family Trees",
            "Manipulating Modal Memory",
            "Pressurizing Fruit Punch Barrel Hydraulics",
            "Testing Underworld Telecommunications",
            "Priming Mascot Mischief Coefficients",
            "Caffeinating Student Body",
            "Initializing Secret Societies",
            "Securing Online Grades Database",
            "Reticulating Graduated Splines",
            "Requisitioning Alumni Donations",
            "Pre-Inking Simoleon Plates",
            "Loading School Spirit Algorithm",
            "Shampooing Dirty Rugs",
            "Restocking Sim Inventories",
            "Compositing Vampiric Complexions",
            "Replacing Wheel Bearings",
            "Re-Re-Re-Re-Re-Reticulating Splines",
            "Loading 'Vroom' Sounds",
            "Turning On Turn-Ons",
            "Preparing a Tasty Grilled Cheese Sandwich",
            "Infuriating Furious Bits",
            "Flavorizing Side-Dishes",
            "Disgruntling Employees",
            "Managing Managers' Managers",
            "Configuring Lemony Squeezation",
            "Preparing Bacon for Homeward Transportation",
            "Reticulated Splines for Sale: §2000",
            "Mitigating Time-Stream Discontinuities",
            "Loading 'First Batch' Metrics",
            "Initializing Forth-Rallying Protocol",
            "Neutralizing Shuriken Oxidization",
            "Roof = Roof(1/3*pi*r^2*h)",
            "Rasterizing Rodent Residences",
            "Limiting Litterbox Loads",
            "Scheduling Copious Catnaps",
            "Calibrating Canine Customization",
            "Dumbing Down Doofuses",
            "Scolding Splines for Reticulating",
            "Distilling Doggie Dynamics",
            "Atomizing Atomic Particles",
            "Decrementing Feline Life-Count",
            "Dampening Stray Generators",
            "Gleefully Stacking Inventories",
            "De-chlorophyllizing Leaves",
            "Predicting Puddle Prevalence",
            "Calculating Snowball Trajectories",
            "Unexpectedly Reticulating Splines",
            "Assessing Loam Particle Sizes",
            "Timing Temperature Transference",
            "Individualizing Snowflakes",
            "Hydrating Harvestables",
            "Stocking Ponds",
            "Readying Relaxation Receptors",
            "Predicting Pagoda Peaks",
            "Originating Ocean Currents",
            "Faceting Precious Gems",
            "Preparing Vacation Days",
            "Spawning Sights to See",
            "Reticulating Ninja Splines",
            "Analyzing Axe Trajectories",
            "Training Tour Guides",
            "Initializing Dastardly Schemes",
            "Factoring Hobby Enthusiasm",
            "Calculating Lifetime Aspirations",
            "Predicating Predestined Paths",
            "Populating Yards with Bugs and Birds",
            "Writing Scrolling Startup String Text",
            "Reticulating Splines in the Zone",
            "Recruiting Snooty Food Judges",
            "Breaking Down Restorable Cars",
            "Threading Sewing Needles",
            "Lacing Football Cleats",
            "Going Apartment Hunting",
            "Determining Rent Guidelines",
            "Preparing for Pops and Locks",
            "Generating Compatible Roommates",
            "Twisting Spiral Staircases",
            "Telling Splines to Reticulate More Quietly",
            "Making a Little Bit of Magic",
            "Rasterizing Reputation Algorithms",
            "Cluttering Closets",
            "Perfecting Playground Pieces",
            "Submerging Bedroom Furniture",
            "Desalinizing Snorkels",
            "Enhancing Crown Reflectivity",
            "Crenellating Crenellations",
            "Dragon-proofing Dressers",
            "Reticulating Underwater Splines",
            "Intensifying Hawaiian Prints",
            "Navigating Stormy Waters",
            "Pre-fluffing Pillows",
            "Factoring Fairy Frolicking Frequencies",
            "Modeling Marquetry",
            "Eschewing Everyday Aesthetics",
            "Cultivating Quality and Class",
            "Proscribing Plebeian Palates",
            "Falsifying Faux Finishes",
            "Invigorating Dull Habitations",
            "Abolishing Pedestrian Posturing",
            "Buffing Splines for Reticulation",
            "Appointing Appealing Appurtenances",
            "Simulating Sparkling Surfaces",
            "Reverse-Engineering Party Scores",
            "Unfolding Foldy Chairs",
            "Rehearsing Dinner",
            "Crash-Proofing Parties",
            "Grooming Grooms",
            "Mingling",
            "De-inviting Don Lothario",
            "Borrowing Something Blue",
            "Happy 14th Birthday Reticulated Splines!",
            "Applying Lampshade Headwear",
            "Stocking Clearance Racks",
            "Fiercely Reticulating Splines",
            "Fashioning Late Arrivals",
            "De-wrinkling Worry-Free Clothing",
            "Distressing Jeans",
            "Developing Delicious Designs",
            "Formulating Fitting Rooms",
            "Tailoring Trendy Threads",
            "Constructing Clothes Hangers",
            "Adjusting Acceptable Apparel",
            "Capturing Youthful Exuberance",
            "Analyzing Adolescent Angst",
            "Preparing Personal Spaces",
            "Making a Mess",
            "Like, Totally Reticulating Splines, Dude",
            "Generating Gothic Glamour",
            "Monitoring Moody Minors",
            "Sweetening Sixteens",
            "Teasing Teenage Hair-dos",
            "Building Boring Bedrooms? As If!",
            "Taking Countertops for Granite",
            "Preparing Perfect Plumbing",
            "Baking Bread for Toasters",
            "Igniting Pilot Lights",
            "Putting Down Toilet Seats",
            "Remodeling Spline Reticulator",
            "Assembling Shower Stalls",
            "Examining Tiles from All Zooms and Angles",
            "Cooling Down Refrigerators",
            "Stocking Stylish Sinks",
            "Creating Handmade Lampshades",
            "Making Many Mini Wrenches",
            "Supplying Self-Serve Furniture Area",
            "Simmering Swedish Meatballs",
            "Building Bedroom Displays",
            "Stress-Testing POÄNG Chairs",
            "Some Spline Reticulating Required",
            "Upholstering Sofas and Loveseats",
            "Boxing BILLY Bookcases",
            "Spooling IKEA Awesomeness",
            "Growing Greener Gardens",
            "Making Manic Mansions",
            "Storing Solar Energy",
            "Over-Waxing Banisters",
            "Stopping To Smell The Flowers",
            "Extrapolating Empire Eigenvectors",
            "Ceiling Fan Rotation = dL/dT",
            "Increasing Water Plant Population",
            "Redistributing Resources",
            "Reticulating Splines One Last Time",
            "Reticulating Story Splines",
            "Matching Walls and Floors",
            "Partitioning Prose",
            "Canceling Un-cancelable Actions",
            "Filling in the Blanks",
            "Enforcing Storyline",
            "Generating Intrigue",
            "Launching SimSat 9000",
            "Compiling Riley's Wardrobe",
            "Calculating Vincent's Wealth",
            "Activating Story Arc",
            "Re-Activating Story Arc",
            "Leveling Playing Fields",
            "Stooping and Scooping",
            "Making Pets Look Like Owners",
            "Making Owners Look Like Pets",
            "Reticulating Dog Show Object Splines",
            "Delineating Mask Dynamics",
            "Reinforcing Story Lines",
            "Decrementing Alice's Funds",
            "Making Stephen Loyal",
            "Calculating Native Restlessness",
            "Transmitting Message Bottles",
            "Clearing Shipping Lanes",
            "Severing Civilization Connections",
            "Generating Sand Grains",
            "Bribing The Orangutans",
            "Wrangling All Wreckage",
            "Predicting Weather Unpredictability",
            "Estimating Volcanic Activity",
            "Amplifying Sun to '11'",
            "Extruding Mesh Terrain",
            "Balancing Domestic Coefficients",
            "Inverting Career Ladder",
            "Calculating Money Supply",
            "Normalizing Social Network",
            "Reticulating Splines",
            "Adjusting Emotional Weights",
            "Calibrating Personality Matrix",
            "Inserting Chaos Generator",
            "Concatenating Vertex Nodes",
            "Balancing Domestic Coefficients",
            "Inverting Career Ladder",
            "Mapping Influence Attributes",
            "Assigning Mimic Propagation",
            "Reticulating Splines",
            "Iterating Chaos Array",
            "Importing Personality Anchors",
            "Inserting Extension Algorithms",
            "Concatenating Vertex Nodes",
            "Balancing Domestic Coefficients",
            "Re-Inverting Career Ladder",
            "Mapping Influence Attributes",
            "Aggregating Need Agents",
            "Reticulating Splines",
            "Interpreting Family Values",
            "Cabalizing NPC Controls",
            "Maximizing Social Network",
            "Renewing Urban Combinatorics",
            "Redefining Family Values",
            "Calibrating Personality Matrix",
            "Generating Population Model",
            "Homogenizing Interest Anatomy",
            "Reticulating Splines",
            "Establishing Gift Registry",
            "Randomizing Inhabitant Characteristics",
            "Readjusting Emotional Weights",
            "Activating Hotel Staff",
            "Importing Entertainment Talent",
            "Updating Vacancy Request Hotline",
            "Downloading Weather Data",
            "Hyperactivating Children",
            "Still Reticulating Splines",
            "Updating Hotel Registry",
            "Calculating Exchange Rate",
            "Activating Deviance Threshold",
            "Adapting Behavioral Model",
            "Reconfiguring Genetic Algorithms",
            "Hybridizing Plant Material",
            "Reticulating Splines Again",
            "Unfolding Helix Packet",
            "Synthesizing Natural Selection",
            "Enabling Lot Commercialization",
            "Recomputing Mammal Matrix",
            "Augmenting Occupational Conduits",
            "Initializing Operant Construct",
            "Generating Schmoozing Algorithm",
            "Populating Empyreal Entities",
            "Configuring Studio Operations",
            "Reticulating Golden Splines",
            "Composing Melodic Euphony",
            "Spreading Rumors",
            "Polarizing Image Conduits",
            "Calibrating Fame Indicant",
            "Strengthening Award Foundations",
            "Abstracting Loading Procedures",
            "Locating Misplaced Calculations",
            "Eliminating Would-be Chicanery",
            "Tabulating Spell Effectors",
            "Reticulating Unreticulated Splines",
            "Recycling Hex Decimals",
            "Binding Trace Enchantments",
            "Fabricating Imaginary Infrastructure",
            "Optimizing Baking Temperature",
            "Ensuring Transplanar Synergy",
            "Simulating Program Execution",
            "Reticulating Splines",
            "Interpreting Family Values",
            "Fabricating Imaginary Infrastructure",
            "Recomputing Mammal Matrix",
            "Activating Deviance Threshold",
            "Composing Melodic Euphony",
            "Homogenizing Interest Anatomy",
            "Normalizing Social Network",
            "Compiling Reticulated Splines",
            "Simulating Program Execution"
        };
    }
}