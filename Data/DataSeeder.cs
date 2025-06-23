using Microsoft.EntityFrameworkCore;
using RareDiseasesAPI.Models;

namespace RareDiseasesAPI.Data
{
    public static class DataSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Diseases.Any())
            {
                var diseases = new List<Disease>
                {
                    new Disease
                    {
                        Name = "Myelofibrosis",
                        Definition = "Myelofibrosis is a rare type of blood cancer where your bone marrow (the soft, spongy tissue inside of your bones) is replaced by fibrous scar tissue. It’s a form of chronic leukemia and a myeloproliferative disorder. " +
                                     "Myeloproliferative disorders involve too many blood cells getting made in your bone marrow. A change (mutation) in a stem cell’s DNA causes it to become a defective, cancerous cell instead, leading to inflammation, scar tissue formation, and impaired healthy blood cell production.",
                        Etiology = "Scientists don’t know the exact cause of myelofibrosis, but it's associated with mutations in certain genes (e.g., JAK2, MPL, CALR). " +
                                   "About 60%-65% of people with myelofibrosis have a JAK2 mutation, 5%-10% have an MPL mutation, and 20%-25% have a CALR mutation. " +
                                   "Overactive Janus-associated kinases (JAKs) disturb normal blood cell production.",
                        Pathophysiology = "Mutations in stem cells cause defective, cancerous blood cells that stimulate inflammation and scar tissue (fibrosis) formation in bone marrow. " +
                                          "This leads to anemia, enlarged spleen (splenomegaly), and sometimes blood production outside bone marrow (extramedullary hematopoiesis).",
                        Symptoms = "• Fatigue (due to anemia)\n" +
                                   "• Fever\n" +
                                   "• Itching\n" +
                                   "• Pale skin\n" +
                                   "• Weight loss\n" +
                                   "• Night sweats\n" +
                                   "• Bone or joint pain\n" +
                                   "• Frequent infections\n" +
                                   "• Enlarged spleen or liver\n" +
                                   "• Unexplained blood clots\n" +
                                   "• Abnormal bleeding or bruising\n" +
                                   "• Enlarged veins in stomach and esophagus (may rupture and bleed)",
                        Complications = "• Severe anemia\n" +
                                        "• Splenomegaly causing discomfort and early satiety\n" +
                                        "• Increased bleeding risk (low platelets)\n" +
                                        "• Increased infection risk (low white blood cells)\n" +
                                        "• Progression to acute myeloid leukemia (AML)\n" +
                                        "• Portal hypertension\n" +
                                        "• Extramedullary hematopoiesis\n" +
                                        "• Blood clots (thrombosis)",
                        Diagnosis = "• Physical exam: Check for spleen enlargement, signs of anemia\n" +
                                    "• Blood tests: CBC, blood chemistry tests, peripheral blood smear\n" +
                                    "• Bone marrow tests: Bone marrow biopsy, aspiration\n" +
                                    "• Gene mutation analysis: JAK2, CALR, MPL\n" +
                                    "• Imaging: Ultrasound for spleen, MRI for scar tissue",
                        Treatment = "• Monitoring if asymptomatic\n\n" +
                                    "• Medications:\n" +
                                    "   - Jakafi® (ruxolitinib)\n" +
                                    "   - Inrebic® (fedratinib)\n" +
                                    "   - Vonjo® (pacritinib)\n\n" +
                                    "• Anemia Treatments:\n" +
                                    "   - Androgens (e.g., danazol)\n" +
                                    "   - Immunomodulators (e.g., interferon, thalidomide, lenalidomide)\n" +
                                    "   - Chemotherapy drugs (e.g., hydroxyurea, cladribine)\n" +
                                    "   - Blood transfusions\n\n" +
                                    "• Splenomegaly Treatments:\n" +
                                    "   - JAK inhibitors\n" +
                                    "   - Immunomodulators\n" +
                                    "   - Chemotherapy\n" +
                                    "   - Splenectomy or radiation (if severe)\n\n" +
                                    "• Radiation therapy for extramedullary hematopoiesis",
                        RiskFactors = "• Age over 50\n" +
                                      "• History of polycythemia vera or essential thrombocytosis\n" +
                                      "• Exposure to ionizing radiation\n" +
                                      "• Exposure to petrochemicals (e.g., benzene, toluene)",
                        Prevention = "There is no guaranteed prevention for myelofibrosis. Avoiding exposure to harmful chemicals and radiation might reduce risk.",
                        Lifestyle = "A balanced, anti-inflammatory diet rich in:\n" +
                                    "• Fruits and vegetables\n" +
                                    "• Whole grains\n" +
                                    "• Healthy protein sources\n" +
                                    "• Iron, Vitamin B12, Vitamin A, Vitamin C, Vitamin D, Vitamin E, Folate, Copper\n" +
                                    "may help control inflammation and improve health.",
                        EmergencyGuide = "Seek immediate medical care for:\n" +
                                         "• Uncontrolled bleeding\n" +
                                         "• Severe infections\n" +
                                         "• Extreme fatigue or shortness of breath\n" +
                                         "• Sudden abdominal pain (possible ruptured spleen)",
                        References = "• Medscape\n" +
                                     "• MPN Research Foundation\n" +
                                     "• Cleveland Clinic\n" +
                                     "• Cancer Research UK"
                    },

                    new Disease
                    {
                        Name = "Phenylketonuria (PKU)",
                        Definition = "Phenylketonuria (PKU) is a rare genetic disorder affecting the metabolism of the amino acid phenylalanine. " +
                                     "It is caused by a deficiency or absence of the enzyme phenylalanine hydroxylase (PAH), which is responsible for converting phenylalanine into tyrosine. " +
                                     "Without this enzyme, phenylalanine accumulates in the blood and brain, leading to neurological damage if untreated.",
                        Etiology = "PKU results from mutations in the PAH gene, leading to reduced or absent enzyme activity. " +
                                   "It is inherited in an autosomal recessive pattern, meaning a child must inherit two mutated copies of the gene (one from each parent) to develop the disease.",
                        Pathophysiology = "Deficiency of the PAH enzyme prevents the conversion of phenylalanine into tyrosine, causing accumulation of phenylalanine and its toxic metabolites such as phenylpyruvate. " +
                                          "Low tyrosine levels affect the production of neurotransmitters (dopamine, norepinephrine, epinephrine) and melanin, leading to neurological problems and changes in skin and hair color.",
                        Symptoms = "Symptoms typically appear a few months after birth and may include:\n" +
                                   "• Developmental delay (mental and motor)\n" +
                                   "• Seizures\n" +
                                   "• \"Musty\" odor in breath, skin, or urine\n" +
                                   "• Fair skin and light hair\n" +
                                   "• Skin rashes (eczema)\n" +
                                   "• Small head size (microcephaly)\n" +
                                   "• Behavioral and social problems",
                        Complications = "If untreated, PKU can lead to:\n" +
                                        "• Irreversible brain damage and severe intellectual disability\n" +
                                        "• Neurological problems such as seizures and tremors\n" +
                                        "• Behavioral, emotional, and social problems",
                        Diagnosis = "PKU is diagnosed through:\n" +
                                    "• Newborn screening (24–72 hours after birth) to detect elevated phenylalanine levels\n" +
                                    "• Genetic testing to identify PAH gene mutations\n" +
                                    "• Regular blood tests to monitor phenylalanine and tyrosine levels",
                        Treatment = "• Dietary management: Lifelong adherence to a low-phenylalanine diet, avoiding high-protein foods like meat, dairy, and nuts\n" +
                                    "• Specialized formulas: Providing essential nutrients without phenylalanine\n" +
                                    "• Medications:\n" +
                                    "   - Sapropterin dihydrochloride (Kuvan) to help reduce phenylalanine levels in some patients\n" +
                                    "   - Pegvaliase (enzyme replacement therapy for adults)\n" +
                                    "• Future therapies: Research on gene therapy is ongoing as a potential treatment option",
                        RiskFactors = "• Family history of PKU\n" +
                                      "• Consanguineous marriage (increases risk)",
                        Prevention = "• Genetic screening before marriage to identify carriers\n" +
                                     "• Genetic counseling for couples at risk\n" +
                                     "• Prenatal testing to determine if the fetus has PKU",
                        Lifestyle = "• Strict diet adherence: Avoid high-phenylalanine foods\n" +
                                    "• Regular monitoring: Frequent blood tests to monitor phenylalanine levels\n" +
                                    "• Psychosocial support: Joining support groups for patients and families",
                        EmergencyGuide = "In emergencies:\n" +
                                         "• Inform medical staff about PKU condition\n" +
                                         "• Avoid giving foods or medications containing phenylalanine\n" +
                                         "• Ensure not to miss special meals or nutritional supplements",
                        References = "• StatPearls: Phenylketonuria (ncbi.nlm.nih.gov)\n" +
                                     "• Mayo Clinic: Phenylketonuria (mayoclinic.org)\n" +
                                     "• Cleveland Clinic: Phenylketonuria (my.clevelandclinic.org)\n" +
                                     "• MedlinePlus Genetics: Phenylketonuria (medlineplus.gov)\n" +
                                     "• Wikipedia: Phenylketonuria (en.wikipedia.org)"
                    },

                    new Disease
                    {
                        Name = "Osteogenesis Imperfecta (OI)",
                        Definition = "OI is a genetic disorder characterized by fragile bones that break easily, often with little or no apparent cause.",
                        Etiology = "Caused by mutations in the genes responsible for producing collagen, primarily COL1A1 and COL1A2.\n" +
                                   "These mutations affect the structure or quantity of Type I collagen, a protein essential for bone strength.",
                        Pathophysiology = "In OI, type I collagen is either produced in insufficient amounts or with abnormal structure.\n" +
                                          "This results in weak bone matrix and fragility, leading to frequent fractures.\n" +
                                          "A reduction in bone density and abnormal bone formation are also observed.",
                        Symptoms = "• Frequent fractures – occurring with minimal trauma.\n" +
                                   "• Joint hypermobility – especially in small joints.\n" +
                                   "• Fragile skin – easy bruising and tears.\n" +
                                   "• Hearing loss – can occur in 50% of type I OI patients by age 40.\n" +
                                   "• Muscle weakness – leading to reduced exercise tolerance.\n" +
                                   "• Sclera color – blue or grayish sclera in many patients.",
                        Complications = "• Chronic bone pain – from repeated fractures and deformities.\n" +
                                        "• Growth issues – shorter stature due to bone deformities.\n" +
                                        "• Hearing loss – progressive, especially in severe forms.\n" +
                                        "• Respiratory problems – due to kyphoscoliosis.\n" +
                                        "• Joint deformities – limiting mobility and function.",
                        Diagnosis = "• Clinical evaluation – based on history of fractures and physical examination.\n" +
                                    "• Genetic testing – to identify mutations in collagen genes.\n" +
                                    "• X-rays and bone scans – to assess bone deformities and fractures.\n" +
                                    "• Collagen analysis – can confirm type I collagen abnormalities.",
                        Treatment = "• Bisphosphonates – pamidronate and zoledronic acid help increase bone density and reduce fractures.\n" +
                                    "• Growth hormone – for certain forms of OI to enhance growth.\n" +
                                    "• Intramedullary rods – to stabilize and prevent deformities in severe cases.\n" +
                                    "• Physical therapy – to strengthen muscles and improve mobility.\n" +
                                    "• Surgery – corrective procedures for fractures and deformities.\n" +
                                    "• Bone marrow transplantation – experimental treatment, not widely used yet.",
                        RiskFactors = "• Family history – OI is often inherited in an autosomal dominant manner.\n" +
                                      "• Genetic mutations – mutations in COL1A1 and COL1A2 genes.\n" +
                                      "• Gender and age – some types are more severe in males and manifest earlier in life.",
                        Prevention = "• Genetic counseling – for families with a history of OI.\n" +
                                     "• Prenatal screening – can help diagnose OI before birth.\n" +
                                     "• Avoiding high-impact activities – can reduce the risk of fractures.",
                        Lifestyle = "• Physical activity – low-impact exercises to strengthen muscles and maintain mobility.\n" +
                                    "• Nutrition – adequate intake of calcium and vitamin D to support bone health.\n" +
                                    "• Safety measures – use of protective gear, fall prevention at home.\n" +
                                    "• Emotional support – counseling to deal with the challenges of living with OI.",
                        EmergencyGuide = "• Fracture care – minimize movement, provide support, and seek immediate medical attention.\n" +
                                         "• Joint dislocation – avoid extreme movements, splint the joint, and consult a specialist.\n" +
                                         "• Bone pain – manage with pain relief medications and physical therapy.",
                        References = "• https://www.ncbi.nlm.nih.gov/books/NBK470248/\n" +
                                     "• https://www.medicalnewstoday.com/articles/osteoogenesis-imperfecta\n" +
                                     "• https://emedicine.medscape.com/article/1256726-overview\n" +
                                     "• https://www.drugs.com/drug-interactions/zoledronic-acid.html"
                    },

                    new Disease
                    {
                        Name = "Sickle Cell Anemia (SCD)",
                        Definition = "Sickle cell anemia (SCD) is an inherited condition where the red blood cells, which are normally round and flexible, become rigid and shaped like a sickle or crescent moon. " +
                                     "These sickle-shaped cells can block blood flow, leading to pain, organ damage, and various complications.",
                        Etiology = "Sickle cell anemia is caused by a mutation in the gene that encodes hemoglobin, a protein in red blood cells. " +
                                   "The disease is inherited in an autosomal recessive pattern. " +
                                   "If a person inherits one sickle cell gene, they are a carrier (sickle cell trait) and are generally healthy. " +
                                   "A person must inherit two copies of the sickle cell gene (one from each parent) to have the disease.",
                        Pathophysiology = "The mutation in hemoglobin causes red blood cells to change shape and become stiff and sticky. " +
                                          "These sickle-shaped cells can block small blood vessels, preventing blood flow and causing pain and organ damage. " +
                                          "The sickle cells break down more quickly than normal red blood cells, leading to anemia, as the body does not have enough red blood cells to carry oxygen.",
                        Symptoms = "• Anemia: Due to the rapid breakdown of sickle cells, causing fatigue.\n" +
                                   "• Pain Crises: Episodes of intense pain when sickle cells block blood flow.\n" +
                                   "• Swelling of Hands and Feet: Caused by blocked circulation.\n" +
                                   "• Frequent Infections: Damaged spleen increases infection risk.\n" +
                                   "• Delayed Growth and Puberty: Due to reduced red blood cells.\n" +
                                   "• Vision Problems: Blockage of blood vessels in the retina.\n" +
                                   "Other Possible Complications:\n" +
                                   "• Pregnancy complications\n" +
                                   "• Deep vein thrombosis\n" +
                                   "• Leg ulcers\n" +
                                   "• Blindness\n" +
                                   "• Splenic sequestration\n" +
                                   "• Chronic kidney disease\n" +
                                   "• Pulmonary hypertension\n" +
                                   "• Avascular necrosis\n" +
                                   "• Acute chest syndrome\n" +
                                   "• Stroke\n" +
                                   "• Priapism (painful erections)",
                        Complications = "• Heart failure due to chronic anemia.\n" +
                                        "• Severe infections.\n" +
                                        "• Stroke.\n" +
                                        "• Organ damage (kidneys, liver, spleen).\n" +
                                        "• Vision loss.\n" +
                                        "• Pregnancy-related complications.",
                        Diagnosis = "• Blood Tests: Detect hemoglobin S, which causes sickle cell anemia.\n" +
                                    "• Genetic Testing: Confirms presence of one or two sickle cell genes.\n" +
                                    "• Genetic Counseling: Helps individuals understand inheritance risks.",
                        Treatment = "• Pain Management: Hydroxyurea (Droxia, Hydrea) and L-glutamine oral powder (Endari) to reduce pain episodes.\n" +
                                    "• Blood Transfusions: Help manage symptoms and prevent complications.\n" +
                                    "• Stem Cell Transplant: Can cure sickle cell anemia in some cases.\n" +
                                    "• Gene Therapy: Ongoing research aiming for a permanent cure.\n" +
                                    "Preventing Infections:\n" +
                                    "• Penicillin from a young age.\n" +
                                    "• Essential vaccinations, especially for children.",
                        RiskFactors = "• Family history: Both parents must carry the sickle cell gene.\n" +
                                      "• Ethnic groups: Most commonly affects individuals of African, Mediterranean, or Middle Eastern descent.",
                        Prevention = "• Genetic Counseling: Before pregnancy to assess risk.\n" +
                                     "• Prenatal Testing: To determine if the child will inherit sickle cell anemia.",
                        Lifestyle = "• Exercise regularly to stay active.\n" +
                                    "• Stay hydrated: Drink 8-10 glasses of water daily.\n" +
                                    "• Eat a heart-healthy diet and limit alcohol.\n" +
                                    "• Get 7-8 hours of sleep each night.\n" +
                                    "• Take folic acid supplements.\n" +
                                    "• Avoid smoking and extreme temperatures.\n" +
                                    "• Manage stress effectively.\n" +
                                    "• Join support groups or therapy for emotional support.",
                        EmergencyGuide = "Seek emergency care immediately for:\n" +
                                         "• Fever above 101˚F (38.3°C)\n" +
                                         "• Difficulty breathing\n" +
                                         "• Chest pain\n" +
                                         "• Abdominal swelling\n" +
                                         "• Sudden vision problems\n" +
                                         "• Severe headache\n" +
                                         "• Sudden weakness or loss of feeling\n" +
                                         "• Seizure\n" +
                                         "• Painful erection lasting more than 4 hours",
                        References = "• Mayo Clinic: Sickle Cell Anemia\n" +
                                     "• Medscape: Sickle Cell Anemia Overview\n" +
                                     "• Cleveland Clinic: Sickle Cell Anemia\n" +
                                     "• Wikipedia: Sickle Cell Disease"
                    },

                    new Disease
                        {
                            Name = "Spinal Muscular Atrophy (SMA)",
                            Definition = "Spinal Muscular Atrophy (SMA) is a genetic disorder that affects the motor neurons in the spinal cord, leading to muscle weakness and atrophy. " +
                                         "It impacts the voluntary muscles, primarily those closest to the center of the body, such as the shoulders, hips, and thighs. " +
                                         "SMA is classified as a motor neuron disease and is caused by a deficiency in the SMN (Survival Motor Neuron) protein.",
                            Etiology = "Genetic Mutation: SMA is caused by mutations in the SMN1 gene on chromosome 5, leading to a deficiency of the SMN protein.\n" +
                                       "The most common mutation involves a deletion in exon 7 of the SMN1 gene.\n" +
                                       "SMN2 genes (which are closely related to SMN1) can partially compensate for the loss of SMN1, but they are less efficient, leading to the progression of the disease.\n" +
                                       "The disease is inherited in an autosomal recessive pattern, meaning both copies of the gene must be mutated for the disease to manifest.\n" +
                                       "SMN protein is essential for the survival and function of motor neurons, and its deficiency leads to motor neuron death.",
                            Symptoms = "The primary symptom of SMA is muscle weakness in voluntary muscles, which typically affects:\n" +
                                       "• Proximal muscles (those closest to the center of the body), such as the hips, thighs, shoulders, and upper back.\n" +
                                       "• Lower limbs tend to be more affected than the upper limbs.\n" +
                                       "• Deep tendon reflexes are often diminished or absent.\n\n" +
                                       "Symptoms can progress as follows:\n" +
                                       "• SMA type 1 (Werdnig–Hoffman disease): Symptoms appear in infants and often result in death within the first two years due to respiratory complications.\n" +
                                       "• SMA type 2: Onset occurs in early childhood and has a slower progression.\n" +
                                       "• SMA type 3: Onset occurs in later childhood, and individuals may live into adulthood.\n\n" +
                                       "• Tongue fasciculations (involuntary twitches of the tongue) are commonly observed, along with hyporeflexia (absence of reflexes).",
                            Pathophysiology = "The disease's severity is often related to the age of onset:\n" +
                                              "• Earlier onset: More severe form, typically leading to a rapid decline in motor function.\n" +
                                              "• Later onset: Milder progression, often leading to a better quality of life and longer survival.\n\n" +
                                              "SMN protein levels influence the progression: higher SMN protein levels correlate with milder symptoms and better motor function.\n" +
                                              "In the past, infants with SMA type 1 rarely survived past two years, but with newer treatments, longer survival and improved quality of life are now possible.\n" +
                                              "SMA is considered a continuum, with varying severity based on the amount of SMN protein and age of onset.",
                            Complications = "SMA can cause various complications, such as:\n\n" +
                                            "Musculoskeletal complications:\n" +
                                            "• Joint contractures, scoliosis, hip dislocations, and bone fractures.\n\n" +
                                            "Dysphagia (difficulty swallowing):\n" +
                                            "• Can lead to dehydration, malnutrition, and aspiration pneumonia.\n" +
                                            "• Dysphagia results from weakness in the bulbar motor neurons, which control chewing, speaking, and swallowing.\n\n" +
                                            "Respiratory complications:\n" +
                                            "• Difficulty in breathing and clearing secretions can lead to respiratory infections and heart failure in severe cases.\n\n" +
                                            "Nutritional and metabolic issues may also arise due to swallowing difficulties and reduced mobility.",
                            Lifestyle = "Exercise is important to:\n" +
                                        "• Improve flexibility, range of motion, and posture.\n" +
                                        "• Prevent contractures and reduce muscle stress.\n" +
                                        "• Maintain a better quality of life, even though complete muscle function cannot be restored.\n\n" +
                                        "Physical therapy may be recommended to help with mobility and joint preservation.\n" +
                                        "Adaptive devices such as wheelchairs, braces, and respiratory support (e.g., non-invasive ventilation) can improve mobility and respiratory function.\n" +
                                        "Regular monitoring of respiratory and nutritional status is essential to prevent complications.",
                            Diagnosis = "Diagnosis involves a combination of clinical evaluation and tests:\n\n" +
                                        "Physical Examination and Family History:\n" +
                                        "• Symptoms such as muscle weakness, hypotonia, and loss of motor skills are red flags for SMA.\n" +
                                        "• History of motor difficulties or proximal muscle weakness is suggestive.\n\n" +
                                        "Blood Tests:\n" +
                                        "• Elevated levels of creatine kinase (CK) can indicate muscle damage but are not specific to SMA.\n\n" +
                                        "Genetic Testing:\n" +
                                        "• The most accurate and least invasive test for SMA is genetic testing, which can detect mutations in the SMN1 gene.\n\n" +
                                        "Muscle Biopsy:\n" +
                                        "• In some cases, doctors may recommend a muscle biopsy to examine muscle tissue for signs of degeneration.\n\n" +
                                        "Nerve Conduction Studies:\n" +
                                        "• Nerve conduction velocity tests may be done to assess motor neuron function.",
                            Treatment = "There is no cure for SMA, but treatments aim to manage symptoms and improve quality of life:\n\n" +
                                        "Gene Therapy:\n" +
                                        "• Onasemnogene abeparvovec (Zolgensma) is a gene therapy approved for treating SMA, which aims to replace the defective SMN1 gene with a functional copy.\n\n" +
                                        "SMN Enhancers:\n" +
                                        "• Nusinersen (Spinraza) is an FDA-approved treatment that increases SMN protein production in motor neurons.\n" +
                                        "• Risdiplam (Evrysdi) is another oral medication that increases SMN protein production.\n\n" +
                                        "Supportive Care:\n" +
                                        "• Respiratory support, including non-invasive ventilation (e.g., BiPAP) in severe cases.\n" +
                                        "• Feeding tubes may be required for those with severe dysphagia.\n" +
                                        "• Physical therapy and occupational therapy to help maintain muscle function.",
                            RiskFactors = "• Genetic inheritance: SMA is inherited in an autosomal recessive pattern, meaning both parents must carry the mutated SMN1 gene for a child to inherit the disease.\n" +
                                          "• Carrier parents: Carriers of the SMN1 gene mutation do not show symptoms but can pass the mutation on to their children.",
                            Prevention = "• Genetic Counseling:\n" +
                                         "Individuals with a family history of SMA should seek genetic counseling to assess the risk of having an affected child.\n\n" +
                                         "• Carrier Screening:\n" +
                                         "Genetic tests can identify carriers of the SMA gene mutation, which can help in family planning decisions.",
                            EmergencyGuide = "Emergency Care:\n" +
                                             "• Respiratory distress should be treated with immediate ventilation support.\n" +
                                             "• Feeding difficulties may require emergency intervention for hydration and nutrition.\n\n" +
                                             "Monitoring:\n" +
                                             "• Regular check-ups to monitor respiratory function and muscle strength are important for managing the condition.",
                            References = "• NCBI - Spinal Muscular Atrophy\n" +
                                         "• Genetic Testing for SMA"
                        },

                    new Disease
                    {
                        Name = "Hemophilia",
                        Definition = "Hemophilia is a hereditary bleeding disorder where the blood does not clot properly due to the lack or dysfunction of clotting factors, mainly Factor VIII (Hemophilia A) or Factor IX (Hemophilia B).",
                        Etiology = "Hemophilia is typically inherited and caused by mutations in the genes responsible for clotting factors. " +
                                   "Hemophilia A is caused by a deficiency in Factor VIII, while Hemophilia B is caused by a deficiency in Factor IX. " +
                                   "In some cases, hemophilia can result from acquired inhibitors that bind to these factors. " +
                                   "Around one-third of genetic cases arise from de novo mutations, which are not inherited from the mother.",
                        Pathophysiology = "Hemophilia impairs the coagulation cascade, particularly the formation of fibrin during secondary hemostasis. " +
                                          "Normally, when blood vessels are injured, platelets activate and trigger the clotting cascade, but in hemophilia, there is insufficient Factor VIII or Factor IX to form a stable clot. " +
                                          "Factor VIII binds to von Willebrand factor to stabilize it, but without this factor, clot stabilization is deficient, leading to excessive bleeding. " +
                                          "Insufficient thrombin production results in impaired fibrin generation, preventing the formation of a clot.",
                        Symptoms = "• Prolonged bleeding, either spontaneously or after injury.\n" +
                                   "• Nosebleeds.\n" +
                                   "• Bleeding gums.\n" +
                                   "• Internal bleeding in joints (hemarthrosis) and muscles.\n" +
                                   "Severity based on clotting factor levels:\n" +
                                   "• Mild Hemophilia: 5%-50% of normal clotting factor.\n" +
                                   "• Moderate Hemophilia: 1%-5% of normal clotting factor.\n" +
                                   "• Severe Hemophilia: Less than 1% of normal clotting factor.\n" +
                                   "• Spontaneous joint bleeding common in severe cases.",
                        Complications = "• Joint damage due to repeated internal bleeding.\n" +
                                        "• Muscle bleeding leading to disability.\n" +
                                        "• Development of inhibitors that neutralize clotting therapies.\n" +
                                        "• Pain and swelling in joints, limiting movement.\n" +
                                        "• Increased risk during surgeries or dental procedures.\n" +
                                        "• Life-threatening bleeding in the brain, digestive tract, or vital organs.",
                        Diagnosis = "• Complete Blood Count (CBC).\n" +
                                    "• Activated Partial Thromboplastin Time (APTT).\n" +
                                    "• Prothrombin Time (PT).\n" +
                                    "• Factor assays to measure Factor VIII and Factor IX levels.\n" +
                                    "These help identify clotting factor deficiency and disease severity.",
                        Treatment = "Preventative (Prophylactic) Therapy:\n" +
                                    "• Regular infusion of clotting factor concentrates.\n" +
                                    "• Hemophilia A: Octocog alfa (Advate).\n" +
                                    "• Hemophilia B: Nonacog alfa (BeneFix).\n" +
                                    "On-demand Treatment:\n" +
                                    "• Mild/Moderate Hemophilia: Treated during bleeding episodes.\n" +
                                    "• Hemophilia A: Octocog alfa or desmopressin.\n" +
                                    "• Hemophilia B: Nonacog alfa.\n" +
                                    "Gene Therapy:\n" +
                                    "• Experimental option aiming to insert a functional clotting factor gene.",
                        RiskFactors = "• Genetic inheritance: Family history.\n" +
                                      "• Male gender: X-linked disorder.\n" +
                                      "• Maternal carriers: Pass mutation to children.\n" +
                                      "• De novo mutations can cause hemophilia without family history.",
                        Prevention = "• Early diagnosis and regular clotting factor monitoring.\n" +
                                     "• Preventative treatments.\n" +
                                     "• Avoid trauma and injuries.\n" +
                                     "• Genetic counseling for at-risk families.",
                        Lifestyle = "• Regular exercise to maintain joints and muscle strength.\n" +
                                    "• Avoid blood-thinning medications like aspirin.\n" +
                                    "• Good dental hygiene.\n" +
                                    "• Up-to-date vaccinations to prevent infections.\n" +
                                    "• Use acetaminophen (Tylenol) instead of NSAIDs for pain.",
                        EmergencyGuide = "• For bleeding episodes: Apply pressure and seek urgent care.\n" +
                                         "• For joint bleeding: Elevate and ice the joint; seek care for severe cases.\n" +
                                         "• For severe internal bleeding (brain, organs): Immediate clotting factor infusion needed; medical emergency.",
                        References = "• NCBI - Hemophilia Overview\n" +
                                     "• NHS - Hemophilia Symptoms\n" +
                                     "• CDC - Hemophilia Testing\n" +
                                     "• Mayo Clinic - Hemophilia Treatment"
                    },

                    new Disease
                    {
                        Name = "Hemolytic Uremic Syndrome (HUS)",
                        Definition = "Hemolytic Uremic Syndrome (HUS) is a condition characterized by the destruction of blood platelets and kidney failure, often following an infection with Shiga toxin-producing Escherichia coli (STEC), specifically the E. coli O157:H7 strain, commonly found in contaminated food or water.",
                        Etiology = "• Infection with Shiga toxin-producing E. coli (especially O157:H7).\n" +
                                   "• Other bacterial infections (e.g., pneumococcal bacteria, HIV, influenza virus).\n" +
                                   "• Medications: Certain cancer treatments and immunosuppressive drugs.\n" +
                                   "• Complications of conditions like pregnancy, autoimmune diseases, or cancer.\n" +
                                   "• Atypical HUS: Genetically inherited form triggered by infections, medications, or underlying diseases.",
                        Pathophysiology = "• HUS involves thrombotic microangiopathy, the formation of platelet-fibrin thrombi in small blood vessels.\n" +
                                          "• Platelet aggregation damages red blood cells, resulting in microangiopathic hemolytic anemia.\n" +
                                          "• Thrombosis primarily occurs at arteriolar-capillary junctions, especially affecting kidneys, brain, and heart.\n" +
                                          "• The formation of microthrombi leads to thrombocytopenia and anemia.",
                        Symptoms = "• Bloody diarrhea, stomach pain, cramping, vomiting, fever.\n" +
                                   "• Paleness or loss of skin color.\n" +
                                   "• Fatigue and extreme tiredness.\n" +
                                   "• Easy bruising and unusual bleeding (nosebleeds, gum bleeding).\n" +
                                   "• Decreased urination or blood in urine.\n" +
                                   "• Swelling (edema) in legs, feet, and ankles.\n" +
                                   "• Confusion, seizures, or stroke.\n" +
                                   "• High blood pressure (hypertension).",
                        Complications = "• Kidney failure.\n" +
                                        "• Neurological issues including seizures and strokes.\n" +
                                        "• Heart failure from high blood pressure and thrombosis.",
                        Diagnosis = "• Blood Tests: Detect hemolysis, thrombocytopenia, elevated creatinine levels.\n" +
                                    "• Urine Tests: Detect protein and blood indicating kidney damage.\n" +
                                    "• Stool Sample: Identify E. coli or other pathogens.\n" +
                                    "• Additional tests if cause is unclear.",
                        Treatment = "• Fluid and electrolyte management to compensate for dehydration and kidney dysfunction.\n" +
                                    "• Blood transfusions to correct anemia and low platelet counts.\n" +
                                    "• Blood pressure medications to protect kidneys.\n" +
                                    "• Eculizumab (Soliris) for treating atypical HUS.\n" +
                                    "• Kidney dialysis in cases of severe renal impairment.\n" +
                                    "• Plasma exchange to remove toxins.\n" +
                                    "• Kidney transplant for end-stage kidney failure.",
                        RiskFactors = "• Children under 5 years of age.\n" +
                                      "• Exposure to contaminated food or water.\n" +
                                      "• Genetic predisposition in atypical HUS.",
                        Prevention = "• Avoid unpasteurized dairy products and juices.\n" +
                                     "• Wash hands thoroughly before eating and after restroom use.\n" +
                                     "• Clean kitchen surfaces and utensils to avoid cross-contamination.\n" +
                                     "• Cook meat thoroughly to an internal temperature of 160°F (71°C).\n" +
                                     "• Defrost meats safely (refrigerator or microwave).\n" +
                                     "• Separate raw and cooked foods.\n" +
                                     "• Avoid swimming in unclean waters, especially if symptomatic with diarrhea.",
                        Lifestyle = "• Practice proper hygiene.\n" +
                                    "• Maintain safe food preparation practices.\n" +
                                    "• Stay hydrated to support kidney health.\n" +
                                    "• Seek medical help early if experiencing symptoms like bloody diarrhea or reduced urination.",
                        EmergencyGuide = "• Seek immediate medical attention for severe bloody diarrhea, confusion, seizures, swelling, or signs of kidney failure.",
                        References = "• Mayo Clinic - Hemolytic Uremic Syndrome\n" +
                                     "• Medscape - Hemolytic Uremic Syndrome Overview\n" +
                                     "• National Library of Medicine - Hemolytic Uremic Syndrome"
                    },

                   new Disease
                    {
                        Name = "Behçet's Disease",
                        Definition = "Behçet's disease is a systemic vasculitis (inflammation of blood vessels) that affects multiple organ systems. It is associated with genetic and environmental factors, commonly affecting individuals aged 20-40, especially along the ancient Silk Road regions such as Turkey, Israel, and East Asia.",
                        Etiology = "• Exact cause unknown; believed to be an autoimmune disorder.\n" +
                                   "• Strong genetic link to the HLA-B51 allele.\n" +
                                   "• Environmental triggers, such as infections, can initiate the disease in genetically predisposed individuals.",
                        Pathophysiology = "• Vasculitis (inflammation of blood vessels) is the hallmark feature.\n" +
                                          "• Affects superficial and deep veins, and in severe cases, major arteries.\n" +
                                          "• Neurological involvement may occur, potentially leading to strokes or symptoms resembling meningitis.",
                        Symptoms = "• Recurrent oral ulcers (in over 95% of patients).\n" +
                                   "• Genital ulcers.\n" +
                                   "• Skin lesions: Erythema nodosum (painful red bumps) and acneiform nodules.\n" +
                                   "• Uveitis (eye inflammation) that can cause blindness.\n" +
                                   "• Joint pain, mainly in knees, ankles, and wrists.\n" +
                                   "• Gastrointestinal symptoms like abdominal pain, ulcers, and bleeding.",
                        Complications = "• Vision loss due to uveitis.\n" +
                                        "• Neurological complications (stroke-like events).\n" +
                                        "• Gastrointestinal bleeding.\n" +
                                        "• Permanent vascular damage.",
                        Diagnosis = "• Clinical diagnosis based on recurring oral ulcers plus at least two other symptoms (genital ulcers, eye inflammation, skin lesions).\n" +
                                    "• Pathergy test: A positive result where a needle prick leads to a red bump.\n" +
                                    "• Blood tests to rule out conditions like systemic lupus erythematosus or Crohn's disease.",
                        Treatment = "• Immunosuppressive medications:\n" +
                                    "  - Corticosteroids (e.g., Prednisone).\n" +
                                    "  - Colchicine.\n" +
                                    "  - Azathioprine and Methotrexate.\n" +
                                    "  - Biologics like Infliximab for severe cases.\n" +
                                    "• Regular monitoring to adjust therapies and manage flares.",
                        RiskFactors = "• Genetic predisposition (HLA-B51 positive individuals).\n" +
                                      "• Environmental exposure to infectious agents.\n" +
                                      "• Age between 20-40 years.\n" +
                                      "• Geographic prevalence along Silk Road countries.",
                        Prevention = "• No known way to prevent Behçet's disease.\n" +
                                     "• Managing infections and minimizing physical trauma may reduce flare risks.\n" +
                                     "• Early diagnosis and treatment improve outcomes.",
                        Lifestyle = "• Managing stress effectively.\n" +
                                    "• Avoiding known triggers like infections or injuries.\n" +
                                    "• Adhering strictly to prescribed medications.\n" +
                                    "• Regular follow-up visits to monitor disease activity and modify treatment.",
                        EmergencyGuide = "• Immediate medical attention for severe vision problems, stroke symptoms, severe gastrointestinal bleeding, or extreme joint swelling.",
                        References = "• Mayo Clinic - Behçet's Disease Overview\n" +
                                     "• National Institute of Arthritis and Musculoskeletal and Skin Diseases - Behçet's Disease\n" +
                                     "• MedlinePlus - Behçet's Disease"
                    },

                    new Disease
                    {
                        Name = "Cardiac Amyloidosis (\"Stiff Heart Syndrome\")",
                        Definition = "Cardiac amyloidosis is a condition where amyloid protein deposits accumulate in the heart muscle, disrupting normal heart function. It is a type of restrictive cardiomyopathy, leading to impaired heart function, heart failure, arrhythmias, and other systemic complications.",
                        Etiology = "• Inherited: Familial amyloidosis, passed from parents.\n" +
                                   "• Acquired: Related to diseases like cancer and monoclonal gammopathies.\n" +
                                   "• Types:\n" +
                                   "  - AL (light chain) amyloidosis.\n" +
                                   "  - ATTR (transthyretin) amyloidosis (more common in older adults).\n" +
                                   "• Risk Factors:\n" +
                                   "  - Age: More common in adults over 45.\n" +
                                   "  - Sex: More common in men.\n" +
                                   "  - Genetics: Inherited mutations increase risk.",
                        Pathophysiology = "• Amyloid deposition: Misfolded proteins form amyloid fibrils depositing in heart tissue.\n" +
                                          "• Heart dysfunction: Stiffening of the heart muscle causes diastolic dysfunction.\n" +
                                          "• Conduction impact: Deposits interfere with electrical signals, causing arrhythmias and heart block.\n" +
                                          "• Heart strain: Leads to progressive heart failure over time.",
                        Symptoms = "• Congestive heart failure: Shortness of breath, fatigue, fluid accumulation.\n" +
                                   "• Arrhythmias: Lightheadedness, dizziness, palpitations.\n" +
                                   "• Valvular disease: Leaky or narrowed heart valves.\n" +
                                   "• Fatigue and reduced exercise tolerance.\n" +
                                   "• Swelling in abdomen, legs, or body.\n" +
                                   "• Excessive urination at night.",
                        Complications = "• Heart failure: Can progress to cardiogenic shock.\n" +
                                        "• Arrhythmias: Life-threatening irregular heart rhythms.\n" +
                                        "• Organ dysfunction: Liver, kidneys, nervous system involvement.\n" +
                                        "• Stroke: Due to arrhythmias or embolism.",
                        Diagnosis = "• Clinical signs: Abnormal heart sounds, lung crackles, enlarged neck veins.\n" +
                                    "• Imaging and Tests:\n" +
                                    "  - Echocardiogram: Heart structure and function.\n" +
                                    "  - ECG: Detects arrhythmias and low voltage signals.\n" +
                                    "  - Cardiac MRI: Detailed imaging of amyloid deposits.\n" +
                                    "  - CT scan: Identifies chest/abdominal amyloid deposits.\n" +
                                    "  - Blood and urine protein tests.\n" +
                                    "  - Cardiac biopsy: Gold standard for confirmation.\n" +
                                    "• Pathergy test: Sometimes used to assess tissue response.",
                        Treatment = "• Medications:\n" +
                                    "  - ATTR stabilizers: Tafamidis (Vyndamax®), Tafamidis meglumine (Vyndaqel®).\n" +
                                    "  - ATTR silencers: Patisiran (Onpattro®), Vutrisiran (Amvuttra®).\n" +
                                    "• Chemotherapy: For AL amyloidosis.\n" +
                                    "• Organ transplantation: Considered in severe advanced cases.\n" +
                                    "• Supportive care: Managing heart failure, arrhythmias, and organ dysfunction.",
                        RiskFactors = "• Age: Risk increases after age 45.\n" +
                                      "• Male gender: More common in men.\n" +
                                      "• Genetic factors: Familial mutations.\n" +
                                      "• Comorbidities: Cancer, monoclonal gammopathies.",
                        Prevention = "• No specific prevention methods.\n" +
                                     "• Early diagnosis helps slow progression.\n" +
                                     "• Genetic counseling recommended for those with family history.",
                        Lifestyle = "• Diet: Heart-healthy diet, limit salt, manage fluid retention.\n" +
                                    "• Exercise: Engage in moderate, tolerated physical activity.\n" +
                                    "• Stress management: Reduce stress to prevent symptom flare-ups.\n" +
                                    "• Regular follow-ups: Routine cardiologist visits to monitor disease progression.",
                        EmergencyGuide = "• Signs of heart failure: Severe shortness of breath, chest pain, sudden swelling.\n" +
                                         "• Arrhythmia symptoms: Dizziness, lightheadedness, palpitations, or fainting.\n" +
                                         "• Chest pain: Could indicate heart attack or embolism; seek immediate care.",
                        References = "• Mayo Clinic: Cardiac Amyloidosis\n" +
                                     "• American Heart Association: Restrictive Cardiomyopathy\n" +
                                     "• National Institutes of Health: Amyloidosis Overview"
                    },

                   new Disease
                    {
                        Name = "Huntington's Disease (HD)",
                        Definition = "Huntington's disease (HD) is an inherited neurodegenerative disorder that causes the gradual breakdown of nerve cells in the brain. The disease affects areas of the brain responsible for voluntary movement control and other cognitive and psychiatric functions. This leads to symptoms such as uncontrollable, dance-like movements (chorea), abnormal postures, and problems with mood, thinking, and behavior.",
                        Etiology = "• Genetic Mutation: Caused by a mutation in the HTT gene on chromosome 4.\n" +
                                   "• Expanded CAG repeats (36 or more) produce a defective huntingtin protein.\n" +
                                   "• Inheritance Pattern: Autosomal dominant; each child has a 50% chance of inheriting.\n" +
                                   "• Rare sporadic cases occur without family history.",
                        Pathophysiology = "• Gradual degeneration of nerve cells in basal ganglia and cerebral cortex.\n" +
                                          "• Affects voluntary movement, cognition, and mood regulation.\n" +
                                          "• Progressive neuronal loss leads to worsening motor, cognitive, and psychiatric symptoms.",
                        Symptoms = "• Chorea: Involuntary, jerky movements.\n" +
                                   "• Akinesia: Rigidity and reduced movement.\n" +
                                   "• Dystonia: Abnormal fixed postures.\n" +
                                   "• Tremor: Unintentional back-and-forth movement.\n" +
                                   "• Eye movement abnormalities.\n" +
                                   "• Speech and swallowing difficulties.\n" +
                                   "• Cognitive changes: Poor attention, judgment, decision-making.\n" +
                                   "• Psychiatric symptoms: Depression, anxiety, irritability.\n" +
                                   "• Other: Balance problems, fatigue, insomnia, seizures.",
                        Complications = "• Chorea increases fall risk.\n" +
                                        "• Cognitive decline affects memory, reasoning, and judgment.\n" +
                                        "• Psychiatric disorders common (depression, mania).\n" +
                                        "• Malnutrition from swallowing difficulties.\n" +
                                        "• Respiratory complications: Choking, aspiration pneumonia.",
                        Diagnosis = "• Medical History & Neurological Exam: Evaluate movement, reflexes, balance, mental status.\n" +
                                    "• Genetic Testing: CAG repeat count in HTT gene; 36+ confirms HD.\n" +
                                    "• Prenatal Testing: For known family history.\n" +
                                    "• Brain Imaging (MRI/CT): Brain shrinkage, enlarged ventricles.\n" +
                                    "• Neuropsychological Assessment: Evaluate cognition and mental health.",
                        Treatment = "• Medications for Chorea:\n" +
                                    "  - Tetrabenazine, deutetrabenazine.\n" +
                                    "  - Antipsychotics (with caution).\n" +
                                    "• Medications for Psychiatric Symptoms:\n" +
                                    "  - Antidepressants, anxiolytics.\n" +
                                    "• Speech Therapy: For speech and swallowing issues.\n" +
                                    "• Dietary Support: High-calorie diet; tube feeding if necessary.\n" +
                                    "• Physical Therapy: Maintain mobility and manage rigidity.\n" +
                                    "• Occupational Therapy: Assistance with daily living activities.",
                        RiskFactors = "• Genetic inheritance: Autosomal dominant mutation in HTT gene.\n" +
                                      "• Sporadic HD: Rare new mutations without family history.",
                        Prevention = "• Genetic Counseling: Assess risk and family planning options.\n" +
                                     "• Prenatal Testing: Available for couples at risk.",
                        Lifestyle = "• Regular monitoring by neurologists, psychiatrists, and therapists.\n" +
                                    "• Fall prevention measures at home.\n" +
                                    "• Nutritional support to prevent weight loss.\n" +
                                    "• Psychological support for patient and family.",
                        EmergencyGuide = "• Choking and swallowing difficulty: Immediate intervention required.\n" +
                                         "• Advanced HD: Respiratory support may be needed for breathing difficulties.",
                        References = "• Huntington’s Disease and Nutrition - Huntington's Disease News\n" +
                                     "• Cleveland Clinic - Huntington's Disease\n" +
                                     "• National Institute of Neurological Disorders and Stroke (NINDS)\n" +
                                     "• NHS - Huntington's Disease\n" +
                                     "• Huntington's Disease Society of America (HDSA)"
                    },

                };

                context.Diseases.AddRange(diseases);
                context.SaveChanges(); // 💾 يحفظ التغييرات
            }
        }
    }
}
