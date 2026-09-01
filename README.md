# 🌌 appStargate — Application de Gestion de Missions Spatiales

[![C#](https://img.shields.io/badge/C%23-7.3-blue.svg)](https://docs.microsoft.com/fr-fr/dotnet/csharp/)
[![Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4.svg)](https://dotnet.microsoft.com/)
[![Database](https://img.shields.io/badge/Database-SQLite-003B57.svg)](https://www.sqlite.org/)
[![UI](https://img.shields.io/badge/UI-WinForms-0078D4.svg)](https://docs.microsoft.com/fr-fr/dotnet/desktop/winforms/)
[![Security](https://img.shields.io/badge/Security-BCrypt.Net-green.svg)](https://github.com/BcryptNet/bcrypt.net)
[![PDF Export](https://img.shields.io/badge/Export-iTextSharp-red.svg)](https://github.com/itext/itextsharp)

---

## 📌 Présentation du Projet

**appStargate** est une application desktop Windows (WinForms) développée en C# dédiée à la gestion, au suivi et à l'analyse des missions d'exploration interplanétaires inspirées de l'univers **Stargate**.

L'application permet d'administrer les expéditions à travers la Porte des Étoiles : de la composition des équipages à l'analyse des ressources collectées (*Databaz*), en passant par la tenue d'un journal de bord complet, le bilan financier, le suivi des contacts informateurs et la capture d'espèces extraterrestres.

---

## ✨ Fonctionnalités Principales

### 🔐 1. Authentification & Sécurité
- Module de connexion sécurisé pour l'accès administrateur (`formAuthentification`).
- Hachage et vérification des mots de passe avec **BCrypt** (`BCrypt.Net-Core`).
- Restriction des privilèges de création et de modification aux utilisateurs authentifiés.

### 🚀 2. Tableau de Bord & Gestion des Missions
- **Vue globale des missions** (`Form1`) avec cartes interactives personnalisées (`MissionUserControle`).
- **Création de missions** (`formNouvelleMission`) :
  - Sélection de la planète cible et calcul automatique de la disponibilité des chefs militaires (évite les conflits d'emploi du temps).
  - Définition du budget, des dates de début/fin, de la feuille de route et des objectifs de collecte de *Databaz*.
- **Édition et gestion de l'équipage** (`formEditMission`, `frmEquipageMission`) : affectation de membres militaires et civils.
- **Consultation détaillée** (`DetailsMission`) : solde budgétaire en temps réel, objectifs de capture et composition de l'équipe.

### 📖 3. Journal de Bord & Export PDF Professionnel
- **Journal de bord interactif** (`journal`) : navigation pas à pas dans les comptes-rendus quotidiens.
- **Suivi financier & contacts** : enregistrement des dépenses de mission et des récompenses versées aux informateurs locaux.
- **Bilan de capture d'espèces** : suivi des objectifs initiaux vs réalisations avec calcul automatique du taux de réussite (%).
- **Exportation PDF** : génération en 1 clic d'un rapport de mission officiel structuré via **iTextSharp** (en-tête, membres, dépenses, journal et tableau bilan).

### 🪐 4. Explorateur de Planètes
- **Catalogue visuel** (`FormPlanetes`, `UCPlanete`) affichant les caractéristiques environnementales (température, gravité, présence de *Databaz*).
- **Fiche détaillée** : visualisation immédiate des espèces habitantes (alliées ou ennemies) et de l'historique des missions effectuées sur la planète.

### 👽 5. Bestiaire & Encyclopédie des Races
- **Catalogue des espèces extraterrestres** (`FormRaces`, `UCAlien`).
- **Système de filtrage dynamique** (`UCFiltres`) :
  - Filtre par alignement (*Tous*, *Alliés*, *Ennemis*).
  - Recherche textuelle par nom d'espèce.
  - Filtrage par couleur/apparence.

### 📊 6. Statistiques & Requêtes Avancées
- **Centre d'analyse** (`FormStats`) offrant un suivi approfondi sous forme de tableaux et logs colorés :
  - Identification des membres d'équipage communs sur plusieurs missions.
  - Analyse des missions de longue durée.
  - Classement des dépenses maximales et des planètes les plus explorées.
  - Statistiques de captures par espèce.

### 🔔 7. Interface Utilisateur & Animations
- Système de **notifications animées et glissantes** (custom Toast panels) pour les retours d'actions (succès, erreurs, validations).
- Architecture modulaire basée sur des **User Controls (UC)** réutilisables.

---

## 🛠️ Architecture Technique & Choix Technologiques

| Composant | Technologie / Bibliothèque | Rôle |
| :--- | :--- | :--- |
| **Langage** | C# (.NET Framework 4.7.2) | Cœur applicatif |
| **Interface Graphique** | WinForms / Custom UserControls | UI Desktop réactive et modulaire |
| **Base de Données** | SQLite (`System.Data.SQLite.Core`) | Stockage relationnel local des missions, planètes et membres |
| **Accès aux Données** | Pattern Singleton + Mode Déconnecté (`DataSet`, `DataAdapters`) | Performance et gestion centralisée des données (`Connexion.cs`, `MesDatas.cs`) |
| **Sécurité** | `BCrypt.Net-Core` (v1.6.0) | Chiffrement et validation des identifiants administrateur |
| **Exportation PDF** | `iTextSharp` (v5.5.13.5) | Génération dynamique de documents PDF mis en page |

---

## 📂 Structure du Projet

```
appStargate/
├── 📁 Images/                   # Visuals, avatars et cartes de planètes
├── 📄 Program.cs               # Point d'entrée principal de l'application
├── 📄 Connexion.cs             # Gestion de la connexion SQLite (Pattern Singleton)
├── 📄 mesDatas.cs              # Conteneur global DataSet pour le mode déconnecté
├── 📄 Form1.cs                 # Formulaire principal / Dashboard des missions
├── 📄 DetailsMission.cs        # Vue détaillée d'une mission
├── 📄 formAuthentification.cs # Écran de connexion Administrateur (BCrypt)
├── 📄 formNouvelleMission.cs   # Formulaire de création de mission
├── 📄 formEditMission.cs       # Formulaire d'édition de mission
├── 📄 frmEquipageMission.cs    # Gestion de la composition de l'équipage
├── 📄 FormPlanetes.cs          # Catalogue et détails des planètes
├── 📄 FormRaces.cs             # Bestiaire des espèces extraterrestres
├── 📄 FormStats.cs             # Module de statistiques et requêtes SQL/DataSet
├── 📄 journal.cs               # Journal de bord et export de rapport PDF
├── 🧱 MissionUserControle.cs   # Composant UI : Carte de mission
├── 🧱 MembreUserControle.cs    # Composant UI : Carte de membre
├── 🧱 UCPlanete.cs             # Composant UI : Carte de planète
├── 🧱 UCAlien.cs               # Composant UI : Carte d'espèce extraterrestre
├── 🧱 UCFiltres.cs             # Composant UI : Barre de filtres pour le bestiaire
├── 📄 Stargate.db              # Base de données SQLite embarquée
├── 📄 appStargate.csproj       # Fichier de projet Visual Studio
└── 📄 packages.config          # Configuration des packages NuGet
```

---

## 🚀 Installation & Exécution

### Prérequis
- **Windows OS** (Windows 10 / 11 recommandé)
- **Visual Studio 2019 ou 2022** (avec le chargeur de travail *.NET desktop development*)
- **.NET Framework 4.7.2 Developer Pack**

### Étapes d'installation

1. **Cloner le dépôt Git :**
   ```bash
   git clone https://github.com/VOTRE_NOM_UTILISATEUR/appStargate.git
   cd appStargate
   ```

2. **Ouvrir le projet :**
   Double-cliquez sur `appStargate.csproj` ou ouvrez la solution dans Visual Studio.

3. **Restauration des packages NuGet :**
   Dans Visual Studio, faites un clic droit sur la solution > **Restaurer les packages NuGet** (ou laissez Visual Studio les restaurer automatiquement lors du build).

4. **Base de Données :**
   S'assurer que le fichier `Stargate.db` est bien présent à la racine du dossier d'exécution (copié automatiquement dans `bin/Debug/` lors du build).

5. **Exécuter l'application :**
   Appuyez sur `F5` ou cliquez sur **Démarrer** dans Visual Studio.

---

## 📸 Aperçu de l'Application

- 🛸 **Dashboard Principal** : Liste défilante des missions en cours et passées.
- 📋 **Détails de Mission & Membres** : Suivi budgétaire et membres affectés.
- 📑 **Rapport PDF** : Génération instantanée d'un bilan d'expédition imprimable.
- 🌌 **Explorateur Stellaire & Bestiaire** : Fiches d'espèces et cartes planétaires interactives.

---

## 📜 Licence & Crédits

Projet développé dans le cadre d'une application C# / WinForms.  
Inspiré par l'univers **Stargate**.
