namespace SevenKnightsAI
{
	
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.adventureTab = new System.Windows.Forms.TabPage();
            this.AD_UseFriendCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_EnHottime_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_limitLabel = new System.Windows.Forms.Label();
            this.AD_StopOnLV30_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_continuousCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_CheckingHeroes_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_StopOnFullItems_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_limitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AD_StopOnFullHeroes_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_limitCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_mainPanel = new System.Windows.Forms.Panel();
            this.AD_masteryComboBox = new System.Windows.Forms.ComboBox();
            this.AD_masteryLabel = new System.Windows.Forms.Label();
            this.AD_teamComboBox2 = new System.Windows.Forms.ComboBox();
            this.AD_difficultyComboBox2nd = new System.Windows.Forms.ComboBox();
            this.AD_sequenceButton = new System.Windows.Forms.Button();
            this.AD_manageHeroHelpLabel = new System.Windows.Forms.Label();
            this.AD_formationComboBox = new System.Windows.Forms.ComboBox();
            this.AD_teamComboBox = new System.Windows.Forms.ComboBox();
            this.AD_stageComboBox = new System.Windows.Forms.ComboBox();
            this.AD_worldComboBox = new System.Windows.Forms.ComboBox();
            this.AD_formationPanel = new System.Windows.Forms.Panel();
            this.AD_pos5CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_pos4CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_pos3CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_pos2CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_pos1CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_formationLabel = new System.Windows.Forms.Label();
            this.AD_teamLabel = new System.Windows.Forms.Label();
            this.AD_stageLabel = new System.Windows.Forms.Label();
            this.AD_worldLabel = new System.Windows.Forms.Label();
            this.AD_difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.AD_skillGroupBox = new System.Windows.Forms.GroupBox();
            this.AD_bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_wave3Panel = new System.Windows.Forms.Panel();
            this.AD_w3Skill11Button = new System.Windows.Forms.Button();
            this.AD_w3Skill12Button = new System.Windows.Forms.Button();
            this.AD_w3Skill13Button = new System.Windows.Forms.Button();
            this.AD_w3Skill14Button = new System.Windows.Forms.Button();
            this.AD_w3Skill15Button = new System.Windows.Forms.Button();
            this.AD_wave3LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_w3Skill10Button = new System.Windows.Forms.Button();
            this.AD_w3Skill09Button = new System.Windows.Forms.Button();
            this.AD_w3Skill08Button = new System.Windows.Forms.Button();
            this.AD_w3Skill07Button = new System.Windows.Forms.Button();
            this.AD_w3Skill06Button = new System.Windows.Forms.Button();
            this.AD_w3Skill05Button = new System.Windows.Forms.Button();
            this.AD_w3Skill04Button = new System.Windows.Forms.Button();
            this.AD_w3Skill03Button = new System.Windows.Forms.Button();
            this.AD_w3Skill02Button = new System.Windows.Forms.Button();
            this.AD_wave3Label = new System.Windows.Forms.Label();
            this.AD_w3Skill01Button = new System.Windows.Forms.Button();
            this.AD_wave2Panel = new System.Windows.Forms.Panel();
            this.AD_wave2LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_w2Skill10Button = new System.Windows.Forms.Button();
            this.AD_w2Skill09Button = new System.Windows.Forms.Button();
            this.AD_w2Skill08Button = new System.Windows.Forms.Button();
            this.AD_w2Skill07Button = new System.Windows.Forms.Button();
            this.AD_w2Skill06Button = new System.Windows.Forms.Button();
            this.AD_w2Skill05Button = new System.Windows.Forms.Button();
            this.AD_w2Skill04Button = new System.Windows.Forms.Button();
            this.AD_w2Skill03Button = new System.Windows.Forms.Button();
            this.AD_w2Skill02Button = new System.Windows.Forms.Button();
            this.AD_wave2Label = new System.Windows.Forms.Label();
            this.AD_w2Skill01Button = new System.Windows.Forms.Button();
            this.AD_manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.AD_wave1Panel = new System.Windows.Forms.Panel();
            this.AD_wave1LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_w1Skill10Button = new System.Windows.Forms.Button();
            this.AD_w1Skill09Button = new System.Windows.Forms.Button();
            this.AD_w1Skill08Button = new System.Windows.Forms.Button();
            this.AD_w1Skill07Button = new System.Windows.Forms.Button();
            this.AD_w1Skill06Button = new System.Windows.Forms.Button();
            this.AD_w1Skill05Button = new System.Windows.Forms.Button();
            this.AD_w1Skill04Button = new System.Windows.Forms.Button();
            this.AD_w1Skill03Button = new System.Windows.Forms.Button();
            this.AD_w1Skill02Button = new System.Windows.Forms.Button();
            this.AD_wave1Label = new System.Windows.Forms.Label();
            this.AD_w1Skill01Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AD_difficultyLabel = new System.Windows.Forms.Label();
            this.AD_elementHeroesCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.goldChamberTab = new System.Windows.Forms.TabPage();
            this.GC_limitLabel = new System.Windows.Forms.Label();
            this.GC_limitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.GC_limitCheckBox = new System.Windows.Forms.CheckBox();
            this.GC_mainPanel = new System.Windows.Forms.Panel();
            this.GC_UseFriendCheckBox = new System.Windows.Forms.CheckBox();
            this.GC_masteryComboBox = new System.Windows.Forms.ComboBox();
            this.GC_skillGroupBox = new System.Windows.Forms.GroupBox();
            this.GC_bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.GC_wave2Panel = new System.Windows.Forms.Panel();
            this.GC_wave2LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.GC_w2Skill10Button = new System.Windows.Forms.Button();
            this.GC_w2Skill09Button = new System.Windows.Forms.Button();
            this.GC_w2Skill08Button = new System.Windows.Forms.Button();
            this.GC_w2Skill07Button = new System.Windows.Forms.Button();
            this.GC_w2Skill06Button = new System.Windows.Forms.Button();
            this.GC_w2Skill05Button = new System.Windows.Forms.Button();
            this.GC_w2Skill04Button = new System.Windows.Forms.Button();
            this.GC_w2Skill03Button = new System.Windows.Forms.Button();
            this.GC_w2Skill02Button = new System.Windows.Forms.Button();
            this.GC_wave2Label = new System.Windows.Forms.Label();
            this.GC_w2Skill01Button = new System.Windows.Forms.Button();
            this.GC_manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.GC_autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.GC_wave1Panel = new System.Windows.Forms.Panel();
            this.GC_wave1LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.GC_w1Skill10Button = new System.Windows.Forms.Button();
            this.GC_w1Skill09Button = new System.Windows.Forms.Button();
            this.GC_w1Skill08Button = new System.Windows.Forms.Button();
            this.GC_w1Skill07Button = new System.Windows.Forms.Button();
            this.GC_w1Skill06Button = new System.Windows.Forms.Button();
            this.GC_w1Skill05Button = new System.Windows.Forms.Button();
            this.GC_w1Skill04Button = new System.Windows.Forms.Button();
            this.GC_w1Skill03Button = new System.Windows.Forms.Button();
            this.GC_w1Skill02Button = new System.Windows.Forms.Button();
            this.GC_wave1Label = new System.Windows.Forms.Label();
            this.GC_w1Skill01Button = new System.Windows.Forms.Button();
            this.GC_masteryLabel = new System.Windows.Forms.Label();
            this.GC_formationComboBox = new System.Windows.Forms.ComboBox();
            this.GC_teamComboBox = new System.Windows.Forms.ComboBox();
            this.GC_formationPanel = new System.Windows.Forms.Panel();
            this.GC_pos5CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos4CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos3CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos2CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos1CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_formationLabel = new System.Windows.Forms.Label();
            this.GC_teamLabel = new System.Windows.Forms.Label();
            this.GC_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.specialDungeonTab = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.SP_limitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.SP_limitCheckBox = new System.Windows.Forms.CheckBox();
            this.karinGroupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SP_karinCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_karinHellRadioButton = new System.Windows.Forms.RadioButton();
            this.SP_karinLimitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.SP_karinHardRadioButton = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.SP_karinNorRadioButton = new System.Windows.Forms.RadioButton();
            this.evanGroupBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SP_evanCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_evanHellRadioButton = new System.Windows.Forms.RadioButton();
            this.SP_evanLimitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.SP_evanHardRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.SP_evanNorRadioButton = new System.Windows.Forms.RadioButton();
            this.crystalGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SP_crystalCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_crystalHardRadioButton = new System.Windows.Forms.RadioButton();
            this.SP_crystalLimitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.SP_crystalNorRadioButton = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.SP_crystalEasyRadioButton = new System.Windows.Forms.RadioButton();
            this.cakeGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SP_cakeCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_cakeHardRadioButton = new System.Windows.Forms.RadioButton();
            this.SP_cakeLimitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.SP_cakeNormalRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.SP_cakeEasyRadioButton = new System.Windows.Forms.RadioButton();
            this.dailyGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SP_dailyCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_dailyHellRadioButton = new System.Windows.Forms.RadioButton();
            this.SP_dailyLimitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.SP_dailyHardRadioButton = new System.Windows.Forms.RadioButton();
            this.SP_dailyNomalRadioButton = new System.Windows.Forms.RadioButton();
            this.SP_skillGroupBox = new System.Windows.Forms.GroupBox();
            this.SP_wave3Panel = new System.Windows.Forms.Panel();
            this.SP_w3Skill11Button = new System.Windows.Forms.Button();
            this.SP_w3Skill12Button = new System.Windows.Forms.Button();
            this.SP_w3Skill13Button = new System.Windows.Forms.Button();
            this.SP_w3Skill14Button = new System.Windows.Forms.Button();
            this.SP_w3Skill15Button = new System.Windows.Forms.Button();
            this.SP_wave3LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_w3Skill10Button = new System.Windows.Forms.Button();
            this.SP_w3Skill09Button = new System.Windows.Forms.Button();
            this.SP_w3Skill08Button = new System.Windows.Forms.Button();
            this.SP_w3Skill07Button = new System.Windows.Forms.Button();
            this.SP_w3Skill06Button = new System.Windows.Forms.Button();
            this.SP_w3Skill05Button = new System.Windows.Forms.Button();
            this.SP_w3Skill04Button = new System.Windows.Forms.Button();
            this.SP_w3Skill03Button = new System.Windows.Forms.Button();
            this.SP_w3Skill02Button = new System.Windows.Forms.Button();
            this.SP_wave3Label = new System.Windows.Forms.Label();
            this.SP_w3Skill01Button = new System.Windows.Forms.Button();
            this.SP_bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_wave2Panel = new System.Windows.Forms.Panel();
            this.SP_wave2LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_w2Skill10Button = new System.Windows.Forms.Button();
            this.SP_w2Skill09Button = new System.Windows.Forms.Button();
            this.SP_w2Skill08Button = new System.Windows.Forms.Button();
            this.SP_w2Skill07Button = new System.Windows.Forms.Button();
            this.SP_w2Skill06Button = new System.Windows.Forms.Button();
            this.SP_w2Skill05Button = new System.Windows.Forms.Button();
            this.SP_w2Skill04Button = new System.Windows.Forms.Button();
            this.SP_w2Skill03Button = new System.Windows.Forms.Button();
            this.SP_w2Skill02Button = new System.Windows.Forms.Button();
            this.SP_wave2Label = new System.Windows.Forms.Label();
            this.SP_w2Skill01Button = new System.Windows.Forms.Button();
            this.SP_manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.SP_wave1Panel = new System.Windows.Forms.Panel();
            this.SP_wave1LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.SP_w1Skill10Button = new System.Windows.Forms.Button();
            this.SP_w1Skill09Button = new System.Windows.Forms.Button();
            this.SP_w1Skill08Button = new System.Windows.Forms.Button();
            this.SP_w1Skill07Button = new System.Windows.Forms.Button();
            this.SP_w1Skill06Button = new System.Windows.Forms.Button();
            this.SP_w1Skill05Button = new System.Windows.Forms.Button();
            this.SP_w1Skill04Button = new System.Windows.Forms.Button();
            this.SP_w1Skill03Button = new System.Windows.Forms.Button();
            this.SP_w1Skill02Button = new System.Windows.Forms.Button();
            this.SP_wave1Label = new System.Windows.Forms.Label();
            this.SP_w1Skill01Button = new System.Windows.Forms.Button();
            this.SP_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.arenaTab = new System.Windows.Forms.TabPage();
            this.AR_limitLabel = new System.Windows.Forms.Label();
            this.AR_useRubyLabel = new System.Windows.Forms.Label();
            this.AR_limitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AR_useRubyNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AR_limitCheckBox = new System.Windows.Forms.CheckBox();
            this.AR_useRubyCheckBox = new System.Windows.Forms.CheckBox();
            this.AR_mainPanel = new System.Windows.Forms.Panel();
            this.AR_skillGroupBox = new System.Windows.Forms.GroupBox();
            this.AR_masteryComboBox = new System.Windows.Forms.ComboBox();
            this.AR_masteryLabel = new System.Windows.Forms.Label();
            this.AR_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.raidTab = new System.Windows.Forms.TabPage();
            this.RD_RoundNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RD_DragonLimit_lbl = new System.Windows.Forms.Label();
            this.RD_mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RD_DragonLVLimit = new System.Windows.Forms.NumericUpDown();
            this.RD_DragonHPLimit = new System.Windows.Forms.NumericUpDown();
            this.RD_LevelCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RD_DragonLV = new System.Windows.Forms.NumericUpDown();
            this.RD_DragonHP = new System.Windows.Forms.NumericUpDown();
            this.RD_OwnerDragon = new System.Windows.Forms.CheckBox();
            this.RD_masteryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ARD_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.RD_StopOnDragonFound_Checkbox = new System.Windows.Forms.CheckBox();
            this.RD_skillGroupBox = new System.Windows.Forms.GroupBox();
            this.RD_bothSkillRadio = new System.Windows.Forms.RadioButton();
            this.RD_team2Panel = new System.Windows.Forms.Panel();
            this.RD_team2LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.RD_t2Skill10Button = new System.Windows.Forms.Button();
            this.RD_t2Skill09Button = new System.Windows.Forms.Button();
            this.RD_t2Skill08Button = new System.Windows.Forms.Button();
            this.RD_t2Skill07Button = new System.Windows.Forms.Button();
            this.RD_t2Skill06Button = new System.Windows.Forms.Button();
            this.RD_t2Skill05Button = new System.Windows.Forms.Button();
            this.RD_t2Skill04Button = new System.Windows.Forms.Button();
            this.RD_t2Skill03Button = new System.Windows.Forms.Button();
            this.RD_t2Skill02Button = new System.Windows.Forms.Button();
            this.RD_team2Label = new System.Windows.Forms.Label();
            this.RD_t2Skill01Button = new System.Windows.Forms.Button();
            this.RD_manualSkillRadio = new System.Windows.Forms.RadioButton();
            this.RD_autoSkillRadio = new System.Windows.Forms.RadioButton();
            this.RD_team1Panel = new System.Windows.Forms.Panel();
            this.RD_team1LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.RD_t1Skill10Button = new System.Windows.Forms.Button();
            this.RD_t1Skill09Button = new System.Windows.Forms.Button();
            this.RD_t1Skill08Button = new System.Windows.Forms.Button();
            this.RD_t1Skill07Button = new System.Windows.Forms.Button();
            this.RD_t1Skill06Button = new System.Windows.Forms.Button();
            this.RD_t1Skill05Button = new System.Windows.Forms.Button();
            this.RD_t1Skill04Button = new System.Windows.Forms.Button();
            this.RD_t1Skill03Button = new System.Windows.Forms.Button();
            this.RD_t1Skill02Button = new System.Windows.Forms.Button();
            this.RD_team1Label = new System.Windows.Forms.Label();
            this.RD_t1Skill01Button = new System.Windows.Forms.Button();
            this.RD_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.RD_DragonLimitCheckBox = new System.Windows.Forms.CheckBox();
            this.resourcesTab = new System.Windows.Forms.TabPage();
            this.RS_collectQuestsGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_questsSocialCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsItemCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsHeroCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsBattleCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_specialQuestsMonthlyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_specialQuestsWeeklyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_specialQuestsDailyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsNormalLabel = new System.Windows.Forms.Label();
            this.RS_questsSpecialLabel = new System.Windows.Forms.Label();
            this.RS_sendHonorsGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_sendHonorsInGame = new System.Windows.Forms.CheckBox();
            this.RS_sendHonorsFacebook = new System.Windows.Forms.CheckBox();
            this.RS_buyKeysGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_buyKeyRubiesLabel = new System.Windows.Forms.Label();
            this.RS_buyKeyRubiesNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_buyKeyRubiesComboBox = new System.Windows.Forms.ComboBox();
            this.RS_buyKeyRubiesCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_buyKeyHonorsLabel = new System.Windows.Forms.Label();
            this.RS_buyKeyHonorsNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_buyKeyHonorsComboBox = new System.Windows.Forms.ComboBox();
            this.RS_buyKeyHonorsCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_inboxGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_inboxTickets = new System.Windows.Forms.CheckBox();
            this.RS_inboxRubies = new System.Windows.Forms.CheckBox();
            this.RS_inboxGold = new System.Windows.Forms.CheckBox();
            this.RS_inboxKeys = new System.Windows.Forms.CheckBox();
            this.RS_inboxHonors = new System.Windows.Forms.CheckBox();
            this.RS_sellingGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_itemRadioPanel = new System.Windows.Forms.Panel();
            this.RS_itemAmountRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_itemAllRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_heroRadioPanel = new System.Windows.Forms.Panel();
            this.RS_heroAmountRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_heroAllRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_itemAmountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_heroAmountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_itemStarsComboBox = new System.Windows.Forms.ComboBox();
            this.RS_heroStarsComboBox = new System.Windows.Forms.ComboBox();
            this.RS_sellHeroesCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_sellItemsCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_giftsGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_luckyBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_luckyChestCheckBox = new System.Windows.Forms.CheckBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.ST_blueStacksGroupBox = new System.Windows.Forms.GroupBox();
            this.ST_forceActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_toggleBlueStacksButton = new System.Windows.Forms.Button();
            this.ST_profileGroupBox = new System.Windows.Forms.GroupBox();
            this.ST_manageProfileButton = new System.Windows.Forms.Button();
            this.ST_hotTimeProfileComboBox = new System.Windows.Forms.ComboBox();
            this.ST_AutoProfileCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_hotTimeProfileCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_currentProfileComboBox = new System.Windows.Forms.ComboBox();
            this.ST_currentProfileLabel = new System.Windows.Forms.Label();
            this.ST_foregroundMode = new System.Windows.Forms.CheckBox();
            this.ST_reconnectNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ST_reconnectInterruptCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_opacityLabel = new System.Windows.Forms.Label();
            this.ST_opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.ST_pushbulletGroupBox = new System.Windows.Forms.GroupBox();
            this.ST_pushbulletHintLabel = new System.Windows.Forms.Label();
            this.ST_pushbulletEmailLabel = new System.Windows.Forms.Label();
            this.ST_pushbulletEmailTextBox = new System.Windows.Forms.TextBox();
            this.ST_pushbulletCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_pushbulletPictureBox = new System.Windows.Forms.PictureBox();
            this.ST_delayValueLabel = new System.Windows.Forms.Label();
            this.ST_delayLabel = new System.Windows.Forms.Label();
            this.ST_delayTrackBar = new System.Windows.Forms.TrackBar();
            this.logTab = new System.Windows.Forms.TabPage();
            this.LG_SaveScreen = new System.Windows.Forms.Button();
            this.LG_LogPixel = new System.Windows.Forms.Button();
            this.LG_scrollCheckBox = new System.Windows.Forms.CheckBox();
            this.LG_exportButton = new System.Windows.Forms.Button();
            this.LG_clearButton = new System.Windows.Forms.Button();
            this.LG_logPanel = new System.Windows.Forms.Panel();
            this.LG_logTextBox = new System.Windows.Forms.RichTextBox();
            this.Info = new System.Windows.Forms.TabPage();
            this.testdayofweek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.adminToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.profileToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCursorPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPixel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBuildInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.aiButton = new System.Windows.Forms.Button();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB_WaitForKeys = new System.Windows.Forms.CheckBox();
            this.HeroCountLabel = new System.Windows.Forms.Label();
            this.raidPictureBox = new System.Windows.Forms.PictureBox();
            this.goldChamberPictureBox = new System.Windows.Forms.PictureBox();
            this.arenaPictureBox = new System.Windows.Forms.PictureBox();
            this.adventurePictureBox = new System.Windows.Forms.PictureBox();
            this.raidCountLabel = new System.Windows.Forms.Label();
            this.goldChamberCountLabel = new System.Windows.Forms.Label();
            this.arenaCountLabel = new System.Windows.Forms.Label();
            this.adventureCountLabel = new System.Windows.Forms.Label();
            this.arenaKeysLabel = new System.Windows.Forms.Label();
            this.adventureKeyPictureBox = new System.Windows.Forms.PictureBox();
            this.arenaKeyPictureBox = new System.Windows.Forms.PictureBox();
            this.towerKeysLabel = new System.Windows.Forms.Label();
            this.towerKeyPictureBox = new System.Windows.Forms.PictureBox();
            this.adventureKeysLabel = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topheaderPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.topazPictureBox = new System.Windows.Forms.PictureBox();
            this.honorPictureBox = new System.Windows.Forms.PictureBox();
            this.rubyPictureBox = new System.Windows.Forms.PictureBox();
            this.goldPictureBox = new System.Windows.Forms.PictureBox();
            this.topazLabel = new System.Windows.Forms.Label();
            this.honorLabel = new System.Windows.Forms.Label();
            this.rubyLabel = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.resourcesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.aiPause = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.adventureTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AD_limitNumericBox)).BeginInit();
            this.AD_mainPanel.SuspendLayout();
            this.AD_formationPanel.SuspendLayout();
            this.AD_skillGroupBox.SuspendLayout();
            this.AD_wave3Panel.SuspendLayout();
            this.AD_wave2Panel.SuspendLayout();
            this.AD_wave1Panel.SuspendLayout();
            this.goldChamberTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_limitNumericBox)).BeginInit();
            this.GC_mainPanel.SuspendLayout();
            this.GC_skillGroupBox.SuspendLayout();
            this.GC_wave2Panel.SuspendLayout();
            this.GC_wave1Panel.SuspendLayout();
            this.GC_formationPanel.SuspendLayout();
            this.specialDungeonTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_limitNumericBox)).BeginInit();
            this.karinGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_karinLimitNumericBox)).BeginInit();
            this.evanGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_evanLimitNumericBox)).BeginInit();
            this.crystalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_crystalLimitNumericBox)).BeginInit();
            this.cakeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_cakeLimitNumericBox)).BeginInit();
            this.dailyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_dailyLimitNumericBox)).BeginInit();
            this.SP_skillGroupBox.SuspendLayout();
            this.SP_wave3Panel.SuspendLayout();
            this.SP_wave2Panel.SuspendLayout();
            this.SP_wave1Panel.SuspendLayout();
            this.arenaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AR_limitNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AR_useRubyNumericBox)).BeginInit();
            this.AR_mainPanel.SuspendLayout();
            this.AR_skillGroupBox.SuspendLayout();
            this.raidTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RD_RoundNumericUpDown)).BeginInit();
            this.RD_mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonLVLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonHPLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonHP)).BeginInit();
            this.RD_skillGroupBox.SuspendLayout();
            this.RD_team2Panel.SuspendLayout();
            this.RD_team1Panel.SuspendLayout();
            this.resourcesTab.SuspendLayout();
            this.RS_collectQuestsGroupBox.SuspendLayout();
            this.RS_sendHonorsGroupBox.SuspendLayout();
            this.RS_buyKeysGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyRubiesNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyHonorsNumericBox)).BeginInit();
            this.RS_inboxGroupBox.SuspendLayout();
            this.RS_sellingGroupBox.SuspendLayout();
            this.RS_itemRadioPanel.SuspendLayout();
            this.RS_heroRadioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_itemAmountNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_heroAmountNumericBox)).BeginInit();
            this.RS_giftsGroupBox.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.ST_blueStacksGroupBox.SuspendLayout();
            this.ST_profileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ST_reconnectNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_opacityTrackBar)).BeginInit();
            this.ST_pushbulletGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ST_pushbulletPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_delayTrackBar)).BeginInit();
            this.logTab.SuspendLayout();
            this.LG_logPanel.SuspendLayout();
            this.Info.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raidPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldChamberPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventurePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureKeyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenaKeyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.towerKeyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topheaderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topazPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldPictureBox)).BeginInit();
            this.resourcesTableLayoutPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.adventureTab);
            this.tabControl.Controls.Add(this.goldChamberTab);
            this.tabControl.Controls.Add(this.specialDungeonTab);
            this.tabControl.Controls.Add(this.arenaTab);
            this.tabControl.Controls.Add(this.raidTab);
            this.tabControl.Controls.Add(this.resourcesTab);
            this.tabControl.Controls.Add(this.settingsTab);
            this.tabControl.Controls.Add(this.logTab);
            this.tabControl.Controls.Add(this.Info);
            this.tabControl.Location = new System.Drawing.Point(4, 86);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(496, 335);
            this.tabControl.TabIndex = 1;
            // 
            // adventureTab
            // 
            this.adventureTab.BackColor = System.Drawing.Color.Transparent;
            this.adventureTab.Controls.Add(this.AD_UseFriendCheckBox);
            this.adventureTab.Controls.Add(this.AD_EnHottime_Checkbox);
            this.adventureTab.Controls.Add(this.AD_limitLabel);
            this.adventureTab.Controls.Add(this.AD_StopOnLV30_Checkbox);
            this.adventureTab.Controls.Add(this.AD_continuousCheckBox);
            this.adventureTab.Controls.Add(this.AD_CheckingHeroes_Checkbox);
            this.adventureTab.Controls.Add(this.AD_StopOnFullItems_Checkbox);
            this.adventureTab.Controls.Add(this.AD_limitNumericBox);
            this.adventureTab.Controls.Add(this.AD_StopOnFullHeroes_Checkbox);
            this.adventureTab.Controls.Add(this.AD_limitCheckBox);
            this.adventureTab.Controls.Add(this.AD_mainPanel);
            this.adventureTab.Controls.Add(this.AD_elementHeroesCheckBox);
            this.adventureTab.Controls.Add(this.AD_enableCheckBox);
            this.adventureTab.Location = new System.Drawing.Point(4, 22);
            this.adventureTab.Name = "adventureTab";
            this.adventureTab.Padding = new System.Windows.Forms.Padding(3);
            this.adventureTab.Size = new System.Drawing.Size(488, 309);
            this.adventureTab.TabIndex = 1;
            this.adventureTab.Text = "Adventure";
            // 
            // AD_UseFriendCheckBox
            // 
            this.AD_UseFriendCheckBox.AutoSize = true;
            this.AD_UseFriendCheckBox.Location = new System.Drawing.Point(229, 29);
            this.AD_UseFriendCheckBox.Name = "AD_UseFriendCheckBox";
            this.AD_UseFriendCheckBox.Size = new System.Drawing.Size(82, 17);
            this.AD_UseFriendCheckBox.TabIndex = 28;
            this.AD_UseFriendCheckBox.Text = "Use Friends";
            this.AD_UseFriendCheckBox.UseVisualStyleBackColor = true;
            this.AD_UseFriendCheckBox.CheckedChanged += new System.EventHandler(this.AD_UseFriendCheckBox_CheckedChanged);
            // 
            // AD_EnHottime_Checkbox
            // 
            this.AD_EnHottime_Checkbox.AutoSize = true;
            this.AD_EnHottime_Checkbox.Location = new System.Drawing.Point(14, 54);
            this.AD_EnHottime_Checkbox.Name = "AD_EnHottime_Checkbox";
            this.AD_EnHottime_Checkbox.Size = new System.Drawing.Size(95, 17);
            this.AD_EnHottime_Checkbox.TabIndex = 27;
            this.AD_EnHottime_Checkbox.Text = "Active Hottime";
            this.AD_EnHottime_Checkbox.UseVisualStyleBackColor = true;
            this.AD_EnHottime_Checkbox.CheckedChanged += new System.EventHandler(this.AD_EnHottime_Checkbox_CheckedChanged);
            // 
            // AD_limitLabel
            // 
            this.AD_limitLabel.AutoSize = true;
            this.AD_limitLabel.Location = new System.Drawing.Point(407, 8);
            this.AD_limitLabel.Name = "AD_limitLabel";
            this.AD_limitLabel.Size = new System.Drawing.Size(70, 13);
            this.AD_limitLabel.TabIndex = 16;
            this.AD_limitLabel.Text = "times per visit";
            // 
            // AD_StopOnLV30_Checkbox
            // 
            this.AD_StopOnLV30_Checkbox.AutoSize = true;
            this.AD_StopOnLV30_Checkbox.Location = new System.Drawing.Point(115, 31);
            this.AD_StopOnLV30_Checkbox.Name = "AD_StopOnLV30_Checkbox";
            this.AD_StopOnLV30_Checkbox.Size = new System.Drawing.Size(101, 17);
            this.AD_StopOnLV30_Checkbox.TabIndex = 25;
            this.AD_StopOnLV30_Checkbox.Text = "Pause On LV30";
            this.AD_StopOnLV30_Checkbox.UseVisualStyleBackColor = true;
            this.AD_StopOnLV30_Checkbox.CheckedChanged += new System.EventHandler(this.AD_StopOnLV30_Checkbox_CheckedChanged);
            // 
            // AD_continuousCheckBox
            // 
            this.AD_continuousCheckBox.AutoSize = true;
            this.AD_continuousCheckBox.Location = new System.Drawing.Point(351, 52);
            this.AD_continuousCheckBox.Name = "AD_continuousCheckBox";
            this.AD_continuousCheckBox.Size = new System.Drawing.Size(128, 17);
            this.AD_continuousCheckBox.TabIndex = 5;
            this.AD_continuousCheckBox.Text = "Progress to next zone";
            this.AD_continuousCheckBox.UseVisualStyleBackColor = true;
            this.AD_continuousCheckBox.CheckedChanged += new System.EventHandler(this.AD_continuousCheckBox_CheckedChanged);
            // 
            // AD_CheckingHeroes_Checkbox
            // 
            this.AD_CheckingHeroes_Checkbox.AutoSize = true;
            this.AD_CheckingHeroes_Checkbox.Enabled = false;
            this.AD_CheckingHeroes_Checkbox.Location = new System.Drawing.Point(148, 8);
            this.AD_CheckingHeroes_Checkbox.Name = "AD_CheckingHeroes_Checkbox";
            this.AD_CheckingHeroes_Checkbox.Size = new System.Drawing.Size(134, 17);
            this.AD_CheckingHeroes_Checkbox.TabIndex = 26;
            this.AD_CheckingHeroes_Checkbox.Text = "Check Max Heroes Lvl";
            this.AD_CheckingHeroes_Checkbox.UseVisualStyleBackColor = true;
            this.AD_CheckingHeroes_Checkbox.Visible = false;
            this.AD_CheckingHeroes_Checkbox.CheckedChanged += new System.EventHandler(this.AD_CheckingHeroes_Checkbox_CheckedChanged);
            // 
            // AD_StopOnFullItems_Checkbox
            // 
            this.AD_StopOnFullItems_Checkbox.AutoSize = true;
            this.AD_StopOnFullItems_Checkbox.Location = new System.Drawing.Point(229, 52);
            this.AD_StopOnFullItems_Checkbox.Name = "AD_StopOnFullItems_Checkbox";
            this.AD_StopOnFullItems_Checkbox.Size = new System.Drawing.Size(120, 17);
            this.AD_StopOnFullItems_Checkbox.TabIndex = 25;
            this.AD_StopOnFullItems_Checkbox.Text = "Pause On Full Items";
            this.AD_StopOnFullItems_Checkbox.UseVisualStyleBackColor = true;
            this.AD_StopOnFullItems_Checkbox.CheckedChanged += new System.EventHandler(this.AD_StopOnFullItems_Checkbox_CheckedChanged);
            // 
            // AD_limitNumericBox
            // 
            this.AD_limitNumericBox.Location = new System.Drawing.Point(365, 5);
            this.AD_limitNumericBox.Name = "AD_limitNumericBox";
            this.AD_limitNumericBox.Size = new System.Drawing.Size(37, 20);
            this.AD_limitNumericBox.TabIndex = 15;
            this.AD_limitNumericBox.Tag = "0";
            this.AD_limitNumericBox.ValueChanged += new System.EventHandler(this.limitNumericBox_ValueChanged);
            // 
            // AD_StopOnFullHeroes_Checkbox
            // 
            this.AD_StopOnFullHeroes_Checkbox.AutoSize = true;
            this.AD_StopOnFullHeroes_Checkbox.Location = new System.Drawing.Point(115, 53);
            this.AD_StopOnFullHeroes_Checkbox.Name = "AD_StopOnFullHeroes_Checkbox";
            this.AD_StopOnFullHeroes_Checkbox.Size = new System.Drawing.Size(112, 17);
            this.AD_StopOnFullHeroes_Checkbox.TabIndex = 25;
            this.AD_StopOnFullHeroes_Checkbox.Text = "Pause Full Heroes";
            this.AD_StopOnFullHeroes_Checkbox.UseVisualStyleBackColor = true;
            this.AD_StopOnFullHeroes_Checkbox.CheckedChanged += new System.EventHandler(this.AD_StopOnFullHeroes_Checkbox_CheckedChanged);
            // 
            // AD_limitCheckBox
            // 
            this.AD_limitCheckBox.Location = new System.Drawing.Point(315, 7);
            this.AD_limitCheckBox.Name = "AD_limitCheckBox";
            this.AD_limitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.AD_limitCheckBox.TabIndex = 14;
            this.AD_limitCheckBox.Tag = "0";
            this.AD_limitCheckBox.Text = "Limit";
            this.AD_limitCheckBox.UseVisualStyleBackColor = true;
            this.AD_limitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // AD_mainPanel
            // 
            this.AD_mainPanel.Controls.Add(this.AD_masteryComboBox);
            this.AD_mainPanel.Controls.Add(this.AD_masteryLabel);
            this.AD_mainPanel.Controls.Add(this.AD_teamComboBox2);
            this.AD_mainPanel.Controls.Add(this.AD_difficultyComboBox2nd);
            this.AD_mainPanel.Controls.Add(this.AD_sequenceButton);
            this.AD_mainPanel.Controls.Add(this.AD_manageHeroHelpLabel);
            this.AD_mainPanel.Controls.Add(this.AD_formationComboBox);
            this.AD_mainPanel.Controls.Add(this.AD_teamComboBox);
            this.AD_mainPanel.Controls.Add(this.AD_stageComboBox);
            this.AD_mainPanel.Controls.Add(this.AD_worldComboBox);
            this.AD_mainPanel.Controls.Add(this.AD_formationPanel);
            this.AD_mainPanel.Controls.Add(this.AD_formationLabel);
            this.AD_mainPanel.Controls.Add(this.AD_teamLabel);
            this.AD_mainPanel.Controls.Add(this.AD_stageLabel);
            this.AD_mainPanel.Controls.Add(this.AD_worldLabel);
            this.AD_mainPanel.Controls.Add(this.AD_difficultyComboBox);
            this.AD_mainPanel.Controls.Add(this.AD_skillGroupBox);
            this.AD_mainPanel.Controls.Add(this.label1);
            this.AD_mainPanel.Controls.Add(this.AD_difficultyLabel);
            this.AD_mainPanel.Location = new System.Drawing.Point(0, 73);
            this.AD_mainPanel.Name = "AD_mainPanel";
            this.AD_mainPanel.Size = new System.Drawing.Size(487, 237);
            this.AD_mainPanel.TabIndex = 13;
            // 
            // AD_masteryComboBox
            // 
            this.AD_masteryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_masteryComboBox.Enabled = false;
            this.AD_masteryComboBox.FormattingEnabled = true;
            this.AD_masteryComboBox.Items.AddRange(new object[] {
            "--",
            "1",
            "2",
            "3"});
            this.AD_masteryComboBox.Location = new System.Drawing.Point(170, 192);
            this.AD_masteryComboBox.Name = "AD_masteryComboBox";
            this.AD_masteryComboBox.Size = new System.Drawing.Size(46, 21);
            this.AD_masteryComboBox.TabIndex = 14;
            this.AD_masteryComboBox.Tag = "0";
            this.AD_masteryComboBox.Visible = false;
            this.AD_masteryComboBox.SelectedIndexChanged += new System.EventHandler(this.masteryComboBox_SelectedIndexChanged);
            // 
            // AD_masteryLabel
            // 
            this.AD_masteryLabel.AutoSize = true;
            this.AD_masteryLabel.Enabled = false;
            this.AD_masteryLabel.Location = new System.Drawing.Point(167, 172);
            this.AD_masteryLabel.Name = "AD_masteryLabel";
            this.AD_masteryLabel.Size = new System.Drawing.Size(44, 13);
            this.AD_masteryLabel.TabIndex = 13;
            this.AD_masteryLabel.Text = "Mastery";
            this.AD_masteryLabel.Visible = false;
            // 
            // AD_teamComboBox2
            // 
            this.AD_teamComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_teamComboBox2.Enabled = false;
            this.AD_teamComboBox2.FormattingEnabled = true;
            this.AD_teamComboBox2.Items.AddRange(new object[] {
            "--",
            "A",
            "B",
            "C"});
            this.AD_teamComboBox2.Location = new System.Drawing.Point(159, 93);
            this.AD_teamComboBox2.Name = "AD_teamComboBox2";
            this.AD_teamComboBox2.Size = new System.Drawing.Size(60, 21);
            this.AD_teamComboBox2.TabIndex = 28;
            this.AD_teamComboBox2.Tag = "0";
            this.AD_teamComboBox2.Visible = false;
            this.AD_teamComboBox2.SelectedIndexChanged += new System.EventHandler(this.AD_teamComboBox2_SelectedIndexChanged);
            // 
            // AD_difficultyComboBox2nd
            // 
            this.AD_difficultyComboBox2nd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_difficultyComboBox2nd.FormattingEnabled = true;
            this.AD_difficultyComboBox2nd.Items.AddRange(new object[] {
            "--",
            "Easy",
            "Normal",
            "Hard"});
            this.AD_difficultyComboBox2nd.Location = new System.Drawing.Point(159, 66);
            this.AD_difficultyComboBox2nd.MaxDropDownItems = 3;
            this.AD_difficultyComboBox2nd.Name = "AD_difficultyComboBox2nd";
            this.AD_difficultyComboBox2nd.Size = new System.Drawing.Size(60, 21);
            this.AD_difficultyComboBox2nd.TabIndex = 27;
            this.AD_difficultyComboBox2nd.SelectedValueChanged += new System.EventHandler(this.AD_difficultyComboBox2nd_SelectedValueChanged);
            // 
            // AD_sequenceButton
            // 
            this.AD_sequenceButton.Location = new System.Drawing.Point(128, 35);
            this.AD_sequenceButton.Name = "AD_sequenceButton";
            this.AD_sequenceButton.Size = new System.Drawing.Size(69, 23);
            this.AD_sequenceButton.TabIndex = 4;
            this.AD_sequenceButton.Text = "Sequence";
            this.AD_sequenceButton.UseVisualStyleBackColor = true;
            this.AD_sequenceButton.Click += new System.EventHandler(this.AD_sequenceButton_Click);
            // 
            // AD_manageHeroHelpLabel
            // 
            this.AD_manageHeroHelpLabel.Location = new System.Drawing.Point(52, 151);
            this.AD_manageHeroHelpLabel.Name = "AD_manageHeroHelpLabel";
            this.AD_manageHeroHelpLabel.Size = new System.Drawing.Size(14, 14);
            this.AD_manageHeroHelpLabel.TabIndex = 21;
            this.AD_manageHeroHelpLabel.Click += new System.EventHandler(this.AD_manageHeroHelpLabel_Click);
            // 
            // AD_formationComboBox
            // 
            this.AD_formationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_formationComboBox.FormattingEnabled = true;
            this.AD_formationComboBox.Items.AddRange(new object[] {
            "--",
            "2 Front / 3 Back",
            "3 Front / 2 Back",
            "1 Front / 4 Back",
            "4 Front / 1 Back"});
            this.AD_formationComboBox.Location = new System.Drawing.Point(72, 119);
            this.AD_formationComboBox.Name = "AD_formationComboBox";
            this.AD_formationComboBox.Size = new System.Drawing.Size(127, 21);
            this.AD_formationComboBox.TabIndex = 11;
            this.AD_formationComboBox.Tag = "0";
            this.AD_formationComboBox.SelectedIndexChanged += new System.EventHandler(this.formationComboBox_SelectedIndexChanged);
            // 
            // AD_teamComboBox
            // 
            this.AD_teamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_teamComboBox.FormattingEnabled = true;
            this.AD_teamComboBox.Items.AddRange(new object[] {
            "--",
            "A",
            "B",
            "C"});
            this.AD_teamComboBox.Location = new System.Drawing.Point(72, 93);
            this.AD_teamComboBox.Name = "AD_teamComboBox";
            this.AD_teamComboBox.Size = new System.Drawing.Size(52, 21);
            this.AD_teamComboBox.TabIndex = 9;
            this.AD_teamComboBox.Tag = "0";
            this.AD_teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // AD_stageComboBox
            // 
            this.AD_stageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_stageComboBox.FormattingEnabled = true;
            this.AD_stageComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.AD_stageComboBox.Location = new System.Drawing.Point(72, 35);
            this.AD_stageComboBox.Name = "AD_stageComboBox";
            this.AD_stageComboBox.Size = new System.Drawing.Size(52, 21);
            this.AD_stageComboBox.TabIndex = 3;
            this.AD_stageComboBox.SelectedIndexChanged += new System.EventHandler(this.AD_stageComboBox_SelectedIndexChanged);
            // 
            // AD_worldComboBox
            // 
            this.AD_worldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_worldComboBox.FormattingEnabled = true;
            this.AD_worldComboBox.Items.AddRange(new object[] {
            "-- Quick Start",
            "-- Sequencer",
            "1 - Mystic Woods",
            "2 - Silent Mine",
            "3 - Blazing Desert",
            "4 - Dark Grave",
            "5 - Dragon Ruins",
            "6 - Frozen Land",
            "7 - Purgatory",
            "8 - Moonlit Isle",
            "9 - Western Empire",
            "10 - Eastern Empire",
            "11 - Dark Sanctuary"});
            this.AD_worldComboBox.Location = new System.Drawing.Point(72, 8);
            this.AD_worldComboBox.Name = "AD_worldComboBox";
            this.AD_worldComboBox.Size = new System.Drawing.Size(127, 21);
            this.AD_worldComboBox.TabIndex = 1;
            this.AD_worldComboBox.SelectedIndexChanged += new System.EventHandler(this.AD_worldComboBox_SelectedIndexChanged);
            // 
            // AD_formationPanel
            // 
            this.AD_formationPanel.BackColor = System.Drawing.Color.Silver;
            this.AD_formationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AD_formationPanel.Controls.Add(this.AD_pos5CheckBox);
            this.AD_formationPanel.Controls.Add(this.AD_pos4CheckBox);
            this.AD_formationPanel.Controls.Add(this.AD_pos3CheckBox);
            this.AD_formationPanel.Controls.Add(this.AD_pos2CheckBox);
            this.AD_formationPanel.Controls.Add(this.AD_pos1CheckBox);
            this.AD_formationPanel.Location = new System.Drawing.Point(72, 148);
            this.AD_formationPanel.Name = "AD_formationPanel";
            this.AD_formationPanel.Size = new System.Drawing.Size(80, 85);
            this.AD_formationPanel.TabIndex = 12;
            this.AD_formationPanel.Tag = "0";
            // 
            // AD_pos5CheckBox
            // 
            this.AD_pos5CheckBox.AutoSize = true;
            this.AD_pos5CheckBox.Location = new System.Drawing.Point(3, 61);
            this.AD_pos5CheckBox.Name = "AD_pos5CheckBox";
            this.AD_pos5CheckBox.Size = new System.Drawing.Size(15, 14);
            this.AD_pos5CheckBox.TabIndex = 4;
            this.AD_pos5CheckBox.Tag = "4";
            this.AD_pos5CheckBox.UseVisualStyleBackColor = true;
            this.AD_pos5CheckBox.Visible = false;
            this.AD_pos5CheckBox.CheckedChanged += new System.EventHandler(this.AD_posCheckBox_CheckedChanged);
            // 
            // AD_pos4CheckBox
            // 
            this.AD_pos4CheckBox.AutoSize = true;
            this.AD_pos4CheckBox.Location = new System.Drawing.Point(3, 48);
            this.AD_pos4CheckBox.Name = "AD_pos4CheckBox";
            this.AD_pos4CheckBox.Size = new System.Drawing.Size(15, 14);
            this.AD_pos4CheckBox.TabIndex = 3;
            this.AD_pos4CheckBox.Tag = "3";
            this.AD_pos4CheckBox.UseVisualStyleBackColor = true;
            this.AD_pos4CheckBox.Visible = false;
            this.AD_pos4CheckBox.CheckedChanged += new System.EventHandler(this.AD_posCheckBox_CheckedChanged);
            // 
            // AD_pos3CheckBox
            // 
            this.AD_pos3CheckBox.AutoSize = true;
            this.AD_pos3CheckBox.Location = new System.Drawing.Point(3, 35);
            this.AD_pos3CheckBox.Name = "AD_pos3CheckBox";
            this.AD_pos3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.AD_pos3CheckBox.TabIndex = 2;
            this.AD_pos3CheckBox.Tag = "2";
            this.AD_pos3CheckBox.UseVisualStyleBackColor = true;
            this.AD_pos3CheckBox.Visible = false;
            this.AD_pos3CheckBox.CheckedChanged += new System.EventHandler(this.AD_posCheckBox_CheckedChanged);
            // 
            // AD_pos2CheckBox
            // 
            this.AD_pos2CheckBox.AutoSize = true;
            this.AD_pos2CheckBox.Location = new System.Drawing.Point(3, 22);
            this.AD_pos2CheckBox.Name = "AD_pos2CheckBox";
            this.AD_pos2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.AD_pos2CheckBox.TabIndex = 1;
            this.AD_pos2CheckBox.Tag = "1";
            this.AD_pos2CheckBox.UseVisualStyleBackColor = true;
            this.AD_pos2CheckBox.Visible = false;
            this.AD_pos2CheckBox.CheckedChanged += new System.EventHandler(this.AD_posCheckBox_CheckedChanged);
            // 
            // AD_pos1CheckBox
            // 
            this.AD_pos1CheckBox.AutoSize = true;
            this.AD_pos1CheckBox.Location = new System.Drawing.Point(3, 9);
            this.AD_pos1CheckBox.Name = "AD_pos1CheckBox";
            this.AD_pos1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.AD_pos1CheckBox.TabIndex = 0;
            this.AD_pos1CheckBox.Tag = "0";
            this.AD_pos1CheckBox.UseVisualStyleBackColor = true;
            this.AD_pos1CheckBox.Visible = false;
            this.AD_pos1CheckBox.CheckedChanged += new System.EventHandler(this.AD_posCheckBox_CheckedChanged);
            // 
            // AD_formationLabel
            // 
            this.AD_formationLabel.Location = new System.Drawing.Point(3, 122);
            this.AD_formationLabel.Name = "AD_formationLabel";
            this.AD_formationLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_formationLabel.TabIndex = 10;
            this.AD_formationLabel.Text = "Formation";
            // 
            // AD_teamLabel
            // 
            this.AD_teamLabel.Location = new System.Drawing.Point(4, 95);
            this.AD_teamLabel.Name = "AD_teamLabel";
            this.AD_teamLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_teamLabel.TabIndex = 8;
            this.AD_teamLabel.Text = "Team";
            // 
            // AD_stageLabel
            // 
            this.AD_stageLabel.Location = new System.Drawing.Point(3, 38);
            this.AD_stageLabel.Name = "AD_stageLabel";
            this.AD_stageLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_stageLabel.TabIndex = 2;
            this.AD_stageLabel.Text = "Stage";
            // 
            // AD_worldLabel
            // 
            this.AD_worldLabel.Location = new System.Drawing.Point(3, 11);
            this.AD_worldLabel.Name = "AD_worldLabel";
            this.AD_worldLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_worldLabel.TabIndex = 0;
            this.AD_worldLabel.Text = "World";
            // 
            // AD_difficultyComboBox
            // 
            this.AD_difficultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_difficultyComboBox.FormattingEnabled = true;
            this.AD_difficultyComboBox.Items.AddRange(new object[] {
            "--",
            "Easy",
            "Normal",
            "Hard"});
            this.AD_difficultyComboBox.Location = new System.Drawing.Point(72, 66);
            this.AD_difficultyComboBox.MaxDropDownItems = 3;
            this.AD_difficultyComboBox.Name = "AD_difficultyComboBox";
            this.AD_difficultyComboBox.Size = new System.Drawing.Size(60, 21);
            this.AD_difficultyComboBox.TabIndex = 7;
            this.AD_difficultyComboBox.SelectedValueChanged += new System.EventHandler(this.AD_difficultyComboBox_SelectedValueChanged);
            // 
            // AD_skillGroupBox
            // 
            this.AD_skillGroupBox.Controls.Add(this.AD_bothSkillRadio);
            this.AD_skillGroupBox.Controls.Add(this.AD_wave3Panel);
            this.AD_skillGroupBox.Controls.Add(this.AD_wave2Panel);
            this.AD_skillGroupBox.Controls.Add(this.AD_manualSkillRadio);
            this.AD_skillGroupBox.Controls.Add(this.AD_autoSkillRadio);
            this.AD_skillGroupBox.Controls.Add(this.AD_wave1Panel);
            this.AD_skillGroupBox.Location = new System.Drawing.Point(233, 1);
            this.AD_skillGroupBox.Name = "AD_skillGroupBox";
            this.AD_skillGroupBox.Size = new System.Drawing.Size(254, 236);
            this.AD_skillGroupBox.TabIndex = 14;
            this.AD_skillGroupBox.TabStop = false;
            this.AD_skillGroupBox.Tag = "0";
            this.AD_skillGroupBox.Text = "Skill Management";
            // 
            // AD_bothSkillRadio
            // 
            this.AD_bothSkillRadio.AutoSize = true;
            this.AD_bothSkillRadio.Location = new System.Drawing.Point(189, 19);
            this.AD_bothSkillRadio.Name = "AD_bothSkillRadio";
            this.AD_bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.AD_bothSkillRadio.TabIndex = 9;
            this.AD_bothSkillRadio.Tag = "2";
            this.AD_bothSkillRadio.Text = "Both";
            this.AD_bothSkillRadio.UseVisualStyleBackColor = true;
            this.AD_bothSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // AD_wave3Panel
            // 
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill11Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill12Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill13Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill14Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill15Button);
            this.AD_wave3Panel.Controls.Add(this.AD_wave3LoopCheckBox);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill10Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill09Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill08Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill07Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill06Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill05Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill04Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill03Button);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill02Button);
            this.AD_wave3Panel.Controls.Add(this.AD_wave3Label);
            this.AD_wave3Panel.Controls.Add(this.AD_w3Skill01Button);
            this.AD_wave3Panel.Location = new System.Drawing.Point(9, 150);
            this.AD_wave3Panel.Name = "AD_wave3Panel";
            this.AD_wave3Panel.Size = new System.Drawing.Size(241, 82);
            this.AD_wave3Panel.TabIndex = 12;
            this.AD_wave3Panel.Tag = "2";
            // 
            // AD_w3Skill11Button
            // 
            this.AD_w3Skill11Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w3Skill11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill11Button.Location = new System.Drawing.Point(77, 6);
            this.AD_w3Skill11Button.Name = "AD_w3Skill11Button";
            this.AD_w3Skill11Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill11Button.TabIndex = 11;
            this.AD_w3Skill11Button.Tag = "10";
            this.AD_w3Skill11Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill11Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill12Button
            // 
            this.AD_w3Skill12Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w3Skill12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill12Button.Location = new System.Drawing.Point(109, 6);
            this.AD_w3Skill12Button.Name = "AD_w3Skill12Button";
            this.AD_w3Skill12Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill12Button.TabIndex = 12;
            this.AD_w3Skill12Button.Tag = "11";
            this.AD_w3Skill12Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill12Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill13Button
            // 
            this.AD_w3Skill13Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w3Skill13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill13Button.Location = new System.Drawing.Point(141, 6);
            this.AD_w3Skill13Button.Name = "AD_w3Skill13Button";
            this.AD_w3Skill13Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill13Button.TabIndex = 13;
            this.AD_w3Skill13Button.Tag = "12";
            this.AD_w3Skill13Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill13Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill14Button
            // 
            this.AD_w3Skill14Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w3Skill14Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill14Button.Location = new System.Drawing.Point(173, 6);
            this.AD_w3Skill14Button.Name = "AD_w3Skill14Button";
            this.AD_w3Skill14Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill14Button.TabIndex = 14;
            this.AD_w3Skill14Button.Tag = "13";
            this.AD_w3Skill14Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill14Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill15Button
            // 
            this.AD_w3Skill15Button.BackColor = System.Drawing.Color.Transparent;
            this.AD_w3Skill15Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AD_w3Skill15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill15Button.Location = new System.Drawing.Point(205, 6);
            this.AD_w3Skill15Button.Name = "AD_w3Skill15Button";
            this.AD_w3Skill15Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill15Button.TabIndex = 15;
            this.AD_w3Skill15Button.Tag = "14";
            this.AD_w3Skill15Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill15Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave3LoopCheckBox
            // 
            this.AD_wave3LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.AD_wave3LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_wave3LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.AD_wave3LoopCheckBox.Name = "AD_wave3LoopCheckBox";
            this.AD_wave3LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.AD_wave3LoopCheckBox.TabIndex = 24;
            this.AD_wave3LoopCheckBox.Text = "Loop";
            this.AD_wave3LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AD_wave3LoopCheckBox.UseVisualStyleBackColor = true;
            this.AD_wave3LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // AD_w3Skill10Button
            // 
            this.AD_w3Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill10Button.Location = new System.Drawing.Point(205, 58);
            this.AD_w3Skill10Button.Name = "AD_w3Skill10Button";
            this.AD_w3Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill10Button.TabIndex = 10;
            this.AD_w3Skill10Button.Tag = "9";
            this.AD_w3Skill10Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill09Button
            // 
            this.AD_w3Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill09Button.Location = new System.Drawing.Point(173, 58);
            this.AD_w3Skill09Button.Name = "AD_w3Skill09Button";
            this.AD_w3Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill09Button.TabIndex = 9;
            this.AD_w3Skill09Button.Tag = "8";
            this.AD_w3Skill09Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill08Button
            // 
            this.AD_w3Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill08Button.Location = new System.Drawing.Point(141, 58);
            this.AD_w3Skill08Button.Name = "AD_w3Skill08Button";
            this.AD_w3Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill08Button.TabIndex = 8;
            this.AD_w3Skill08Button.Tag = "7";
            this.AD_w3Skill08Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill07Button
            // 
            this.AD_w3Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill07Button.Location = new System.Drawing.Point(109, 58);
            this.AD_w3Skill07Button.Name = "AD_w3Skill07Button";
            this.AD_w3Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill07Button.TabIndex = 7;
            this.AD_w3Skill07Button.Tag = "6";
            this.AD_w3Skill07Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill06Button
            // 
            this.AD_w3Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill06Button.Location = new System.Drawing.Point(77, 58);
            this.AD_w3Skill06Button.Name = "AD_w3Skill06Button";
            this.AD_w3Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill06Button.TabIndex = 6;
            this.AD_w3Skill06Button.Tag = "5";
            this.AD_w3Skill06Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill05Button
            // 
            this.AD_w3Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill05Button.Location = new System.Drawing.Point(205, 34);
            this.AD_w3Skill05Button.Name = "AD_w3Skill05Button";
            this.AD_w3Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill05Button.TabIndex = 5;
            this.AD_w3Skill05Button.Tag = "4";
            this.AD_w3Skill05Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill04Button
            // 
            this.AD_w3Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill04Button.Location = new System.Drawing.Point(173, 34);
            this.AD_w3Skill04Button.Name = "AD_w3Skill04Button";
            this.AD_w3Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill04Button.TabIndex = 4;
            this.AD_w3Skill04Button.Tag = "3";
            this.AD_w3Skill04Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill03Button
            // 
            this.AD_w3Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill03Button.Location = new System.Drawing.Point(141, 34);
            this.AD_w3Skill03Button.Name = "AD_w3Skill03Button";
            this.AD_w3Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill03Button.TabIndex = 3;
            this.AD_w3Skill03Button.Tag = "2";
            this.AD_w3Skill03Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w3Skill02Button
            // 
            this.AD_w3Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill02Button.Location = new System.Drawing.Point(109, 34);
            this.AD_w3Skill02Button.Name = "AD_w3Skill02Button";
            this.AD_w3Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill02Button.TabIndex = 2;
            this.AD_w3Skill02Button.Tag = "1";
            this.AD_w3Skill02Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave3Label
            // 
            this.AD_wave3Label.Location = new System.Drawing.Point(6, 7);
            this.AD_wave3Label.Name = "AD_wave3Label";
            this.AD_wave3Label.Size = new System.Drawing.Size(60, 13);
            this.AD_wave3Label.TabIndex = 0;
            this.AD_wave3Label.Text = "Wave 3";
            // 
            // AD_w3Skill01Button
            // 
            this.AD_w3Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w3Skill01Button.Location = new System.Drawing.Point(77, 34);
            this.AD_w3Skill01Button.Name = "AD_w3Skill01Button";
            this.AD_w3Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w3Skill01Button.TabIndex = 1;
            this.AD_w3Skill01Button.Tag = "0";
            this.AD_w3Skill01Button.UseVisualStyleBackColor = true;
            this.AD_w3Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave2Panel
            // 
            this.AD_wave2Panel.Controls.Add(this.AD_wave2LoopCheckBox);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill10Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill09Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill08Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill07Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill06Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill05Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill04Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill03Button);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill02Button);
            this.AD_wave2Panel.Controls.Add(this.AD_wave2Label);
            this.AD_wave2Panel.Controls.Add(this.AD_w2Skill01Button);
            this.AD_wave2Panel.Location = new System.Drawing.Point(9, 96);
            this.AD_wave2Panel.Name = "AD_wave2Panel";
            this.AD_wave2Panel.Size = new System.Drawing.Size(241, 51);
            this.AD_wave2Panel.TabIndex = 11;
            this.AD_wave2Panel.Tag = "1";
            // 
            // AD_wave2LoopCheckBox
            // 
            this.AD_wave2LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.AD_wave2LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_wave2LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.AD_wave2LoopCheckBox.Name = "AD_wave2LoopCheckBox";
            this.AD_wave2LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.AD_wave2LoopCheckBox.TabIndex = 24;
            this.AD_wave2LoopCheckBox.Text = "Loop";
            this.AD_wave2LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AD_wave2LoopCheckBox.UseVisualStyleBackColor = true;
            this.AD_wave2LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // AD_w2Skill10Button
            // 
            this.AD_w2Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill10Button.Location = new System.Drawing.Point(205, 26);
            this.AD_w2Skill10Button.Name = "AD_w2Skill10Button";
            this.AD_w2Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill10Button.TabIndex = 10;
            this.AD_w2Skill10Button.Tag = "9";
            this.AD_w2Skill10Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill09Button
            // 
            this.AD_w2Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill09Button.Location = new System.Drawing.Point(173, 26);
            this.AD_w2Skill09Button.Name = "AD_w2Skill09Button";
            this.AD_w2Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill09Button.TabIndex = 9;
            this.AD_w2Skill09Button.Tag = "8";
            this.AD_w2Skill09Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill08Button
            // 
            this.AD_w2Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill08Button.Location = new System.Drawing.Point(141, 26);
            this.AD_w2Skill08Button.Name = "AD_w2Skill08Button";
            this.AD_w2Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill08Button.TabIndex = 8;
            this.AD_w2Skill08Button.Tag = "7";
            this.AD_w2Skill08Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill07Button
            // 
            this.AD_w2Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill07Button.Location = new System.Drawing.Point(109, 26);
            this.AD_w2Skill07Button.Name = "AD_w2Skill07Button";
            this.AD_w2Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill07Button.TabIndex = 7;
            this.AD_w2Skill07Button.Tag = "6";
            this.AD_w2Skill07Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill06Button
            // 
            this.AD_w2Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill06Button.Location = new System.Drawing.Point(77, 26);
            this.AD_w2Skill06Button.Name = "AD_w2Skill06Button";
            this.AD_w2Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill06Button.TabIndex = 6;
            this.AD_w2Skill06Button.Tag = "5";
            this.AD_w2Skill06Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill05Button
            // 
            this.AD_w2Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill05Button.Location = new System.Drawing.Point(205, 2);
            this.AD_w2Skill05Button.Name = "AD_w2Skill05Button";
            this.AD_w2Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill05Button.TabIndex = 5;
            this.AD_w2Skill05Button.Tag = "4";
            this.AD_w2Skill05Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill04Button
            // 
            this.AD_w2Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill04Button.Location = new System.Drawing.Point(173, 2);
            this.AD_w2Skill04Button.Name = "AD_w2Skill04Button";
            this.AD_w2Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill04Button.TabIndex = 4;
            this.AD_w2Skill04Button.Tag = "3";
            this.AD_w2Skill04Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill03Button
            // 
            this.AD_w2Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill03Button.Location = new System.Drawing.Point(141, 2);
            this.AD_w2Skill03Button.Name = "AD_w2Skill03Button";
            this.AD_w2Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill03Button.TabIndex = 3;
            this.AD_w2Skill03Button.Tag = "2";
            this.AD_w2Skill03Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w2Skill02Button
            // 
            this.AD_w2Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill02Button.Location = new System.Drawing.Point(109, 2);
            this.AD_w2Skill02Button.Name = "AD_w2Skill02Button";
            this.AD_w2Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill02Button.TabIndex = 2;
            this.AD_w2Skill02Button.Tag = "1";
            this.AD_w2Skill02Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave2Label
            // 
            this.AD_wave2Label.Location = new System.Drawing.Point(6, 7);
            this.AD_wave2Label.Name = "AD_wave2Label";
            this.AD_wave2Label.Size = new System.Drawing.Size(60, 13);
            this.AD_wave2Label.TabIndex = 0;
            this.AD_wave2Label.Text = "Wave 2";
            // 
            // AD_w2Skill01Button
            // 
            this.AD_w2Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w2Skill01Button.Location = new System.Drawing.Point(77, 2);
            this.AD_w2Skill01Button.Name = "AD_w2Skill01Button";
            this.AD_w2Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w2Skill01Button.TabIndex = 1;
            this.AD_w2Skill01Button.Tag = "0";
            this.AD_w2Skill01Button.UseVisualStyleBackColor = true;
            this.AD_w2Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_manualSkillRadio
            // 
            this.AD_manualSkillRadio.AutoSize = true;
            this.AD_manualSkillRadio.Location = new System.Drawing.Point(97, 19);
            this.AD_manualSkillRadio.Name = "AD_manualSkillRadio";
            this.AD_manualSkillRadio.Size = new System.Drawing.Size(82, 17);
            this.AD_manualSkillRadio.TabIndex = 8;
            this.AD_manualSkillRadio.Tag = "1";
            this.AD_manualSkillRadio.Text = "Manual Skill";
            this.AD_manualSkillRadio.UseVisualStyleBackColor = true;
            this.AD_manualSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // AD_autoSkillRadio
            // 
            this.AD_autoSkillRadio.AutoSize = true;
            this.AD_autoSkillRadio.Checked = true;
            this.AD_autoSkillRadio.Location = new System.Drawing.Point(18, 19);
            this.AD_autoSkillRadio.Name = "AD_autoSkillRadio";
            this.AD_autoSkillRadio.Size = new System.Drawing.Size(69, 17);
            this.AD_autoSkillRadio.TabIndex = 7;
            this.AD_autoSkillRadio.TabStop = true;
            this.AD_autoSkillRadio.Tag = "0";
            this.AD_autoSkillRadio.Text = "Auto Skill";
            this.AD_autoSkillRadio.UseVisualStyleBackColor = true;
            this.AD_autoSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // AD_wave1Panel
            // 
            this.AD_wave1Panel.Controls.Add(this.AD_wave1LoopCheckBox);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill10Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill09Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill08Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill07Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill06Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill05Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill04Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill03Button);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill02Button);
            this.AD_wave1Panel.Controls.Add(this.AD_wave1Label);
            this.AD_wave1Panel.Controls.Add(this.AD_w1Skill01Button);
            this.AD_wave1Panel.Location = new System.Drawing.Point(9, 39);
            this.AD_wave1Panel.Name = "AD_wave1Panel";
            this.AD_wave1Panel.Size = new System.Drawing.Size(241, 51);
            this.AD_wave1Panel.TabIndex = 10;
            this.AD_wave1Panel.Tag = "0";
            // 
            // AD_wave1LoopCheckBox
            // 
            this.AD_wave1LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.AD_wave1LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_wave1LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.AD_wave1LoopCheckBox.Name = "AD_wave1LoopCheckBox";
            this.AD_wave1LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.AD_wave1LoopCheckBox.TabIndex = 11;
            this.AD_wave1LoopCheckBox.Text = "Loop";
            this.AD_wave1LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AD_wave1LoopCheckBox.UseVisualStyleBackColor = true;
            this.AD_wave1LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // AD_w1Skill10Button
            // 
            this.AD_w1Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill10Button.Location = new System.Drawing.Point(205, 26);
            this.AD_w1Skill10Button.Name = "AD_w1Skill10Button";
            this.AD_w1Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill10Button.TabIndex = 10;
            this.AD_w1Skill10Button.Tag = "9";
            this.AD_w1Skill10Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill09Button
            // 
            this.AD_w1Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill09Button.Location = new System.Drawing.Point(173, 26);
            this.AD_w1Skill09Button.Name = "AD_w1Skill09Button";
            this.AD_w1Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill09Button.TabIndex = 9;
            this.AD_w1Skill09Button.Tag = "8";
            this.AD_w1Skill09Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill08Button
            // 
            this.AD_w1Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill08Button.Location = new System.Drawing.Point(141, 26);
            this.AD_w1Skill08Button.Name = "AD_w1Skill08Button";
            this.AD_w1Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill08Button.TabIndex = 8;
            this.AD_w1Skill08Button.Tag = "7";
            this.AD_w1Skill08Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill07Button
            // 
            this.AD_w1Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill07Button.Location = new System.Drawing.Point(109, 26);
            this.AD_w1Skill07Button.Name = "AD_w1Skill07Button";
            this.AD_w1Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill07Button.TabIndex = 7;
            this.AD_w1Skill07Button.Tag = "6";
            this.AD_w1Skill07Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill06Button
            // 
            this.AD_w1Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill06Button.Location = new System.Drawing.Point(77, 26);
            this.AD_w1Skill06Button.Name = "AD_w1Skill06Button";
            this.AD_w1Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill06Button.TabIndex = 6;
            this.AD_w1Skill06Button.Tag = "5";
            this.AD_w1Skill06Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill05Button
            // 
            this.AD_w1Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill05Button.Location = new System.Drawing.Point(205, 2);
            this.AD_w1Skill05Button.Name = "AD_w1Skill05Button";
            this.AD_w1Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill05Button.TabIndex = 5;
            this.AD_w1Skill05Button.Tag = "4";
            this.AD_w1Skill05Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill04Button
            // 
            this.AD_w1Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill04Button.Location = new System.Drawing.Point(173, 2);
            this.AD_w1Skill04Button.Name = "AD_w1Skill04Button";
            this.AD_w1Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill04Button.TabIndex = 4;
            this.AD_w1Skill04Button.Tag = "3";
            this.AD_w1Skill04Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill03Button
            // 
            this.AD_w1Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill03Button.Location = new System.Drawing.Point(141, 2);
            this.AD_w1Skill03Button.Name = "AD_w1Skill03Button";
            this.AD_w1Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill03Button.TabIndex = 3;
            this.AD_w1Skill03Button.Tag = "2";
            this.AD_w1Skill03Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_w1Skill02Button
            // 
            this.AD_w1Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill02Button.Location = new System.Drawing.Point(109, 2);
            this.AD_w1Skill02Button.Name = "AD_w1Skill02Button";
            this.AD_w1Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill02Button.TabIndex = 2;
            this.AD_w1Skill02Button.Tag = "1";
            this.AD_w1Skill02Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // AD_wave1Label
            // 
            this.AD_wave1Label.Location = new System.Drawing.Point(6, 7);
            this.AD_wave1Label.Name = "AD_wave1Label";
            this.AD_wave1Label.Size = new System.Drawing.Size(60, 13);
            this.AD_wave1Label.TabIndex = 0;
            this.AD_wave1Label.Text = "Wave 1";
            // 
            // AD_w1Skill01Button
            // 
            this.AD_w1Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AD_w1Skill01Button.Location = new System.Drawing.Point(77, 2);
            this.AD_w1Skill01Button.Name = "AD_w1Skill01Button";
            this.AD_w1Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.AD_w1Skill01Button.TabIndex = 1;
            this.AD_w1Skill01Button.Tag = "0";
            this.AD_w1Skill01Button.UseVisualStyleBackColor = true;
            this.AD_w1Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(133, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "2nd";
            // 
            // AD_difficultyLabel
            // 
            this.AD_difficultyLabel.Location = new System.Drawing.Point(4, 69);
            this.AD_difficultyLabel.Name = "AD_difficultyLabel";
            this.AD_difficultyLabel.Size = new System.Drawing.Size(54, 13);
            this.AD_difficultyLabel.TabIndex = 6;
            this.AD_difficultyLabel.Text = "Difficulty";
            // 
            // AD_elementHeroesCheckBox
            // 
            this.AD_elementHeroesCheckBox.AutoSize = true;
            this.AD_elementHeroesCheckBox.Location = new System.Drawing.Point(14, 31);
            this.AD_elementHeroesCheckBox.Name = "AD_elementHeroesCheckBox";
            this.AD_elementHeroesCheckBox.Size = new System.Drawing.Size(86, 17);
            this.AD_elementHeroesCheckBox.TabIndex = 13;
            this.AD_elementHeroesCheckBox.Text = "First Element";
            this.AD_elementHeroesCheckBox.UseVisualStyleBackColor = true;
            this.AD_elementHeroesCheckBox.CheckedChanged += new System.EventHandler(this.AD_elementHeroesCheckBox_CheckedChanged);
            // 
            // AD_enableCheckBox
            // 
            this.AD_enableCheckBox.AutoSize = true;
            this.AD_enableCheckBox.Checked = true;
            this.AD_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AD_enableCheckBox.Location = new System.Drawing.Point(9, 7);
            this.AD_enableCheckBox.Name = "AD_enableCheckBox";
            this.AD_enableCheckBox.Size = new System.Drawing.Size(111, 17);
            this.AD_enableCheckBox.TabIndex = 1;
            this.AD_enableCheckBox.Tag = "0";
            this.AD_enableCheckBox.Text = "Enable Adventure";
            this.AD_enableCheckBox.UseVisualStyleBackColor = true;
            this.AD_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // goldChamberTab
            // 
            this.goldChamberTab.BackColor = System.Drawing.Color.Transparent;
            this.goldChamberTab.Controls.Add(this.GC_limitLabel);
            this.goldChamberTab.Controls.Add(this.GC_limitNumericBox);
            this.goldChamberTab.Controls.Add(this.GC_limitCheckBox);
            this.goldChamberTab.Controls.Add(this.GC_mainPanel);
            this.goldChamberTab.Controls.Add(this.GC_enableCheckBox);
            this.goldChamberTab.Location = new System.Drawing.Point(4, 22);
            this.goldChamberTab.Name = "goldChamberTab";
            this.goldChamberTab.Size = new System.Drawing.Size(488, 309);
            this.goldChamberTab.TabIndex = 2;
            this.goldChamberTab.Text = "Gold Chamber";
            // 
            // GC_limitLabel
            // 
            this.GC_limitLabel.AutoSize = true;
            this.GC_limitLabel.Location = new System.Drawing.Point(407, 8);
            this.GC_limitLabel.Name = "GC_limitLabel";
            this.GC_limitLabel.Size = new System.Drawing.Size(70, 13);
            this.GC_limitLabel.TabIndex = 19;
            this.GC_limitLabel.Text = "times per visit";
            // 
            // GC_limitNumericBox
            // 
            this.GC_limitNumericBox.Location = new System.Drawing.Point(365, 5);
            this.GC_limitNumericBox.Name = "GC_limitNumericBox";
            this.GC_limitNumericBox.Size = new System.Drawing.Size(37, 20);
            this.GC_limitNumericBox.TabIndex = 18;
            this.GC_limitNumericBox.Tag = "1";
            this.GC_limitNumericBox.ValueChanged += new System.EventHandler(this.limitNumericBox_ValueChanged);
            // 
            // GC_limitCheckBox
            // 
            this.GC_limitCheckBox.Location = new System.Drawing.Point(315, 7);
            this.GC_limitCheckBox.Name = "GC_limitCheckBox";
            this.GC_limitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.GC_limitCheckBox.TabIndex = 17;
            this.GC_limitCheckBox.Tag = "1";
            this.GC_limitCheckBox.Text = "Limit";
            this.GC_limitCheckBox.UseVisualStyleBackColor = true;
            this.GC_limitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // GC_mainPanel
            // 
            this.GC_mainPanel.Controls.Add(this.GC_UseFriendCheckBox);
            this.GC_mainPanel.Controls.Add(this.GC_masteryComboBox);
            this.GC_mainPanel.Controls.Add(this.GC_skillGroupBox);
            this.GC_mainPanel.Controls.Add(this.GC_masteryLabel);
            this.GC_mainPanel.Controls.Add(this.GC_formationComboBox);
            this.GC_mainPanel.Controls.Add(this.GC_teamComboBox);
            this.GC_mainPanel.Controls.Add(this.GC_formationPanel);
            this.GC_mainPanel.Controls.Add(this.GC_formationLabel);
            this.GC_mainPanel.Controls.Add(this.GC_teamLabel);
            this.GC_mainPanel.Location = new System.Drawing.Point(0, 31);
            this.GC_mainPanel.Name = "GC_mainPanel";
            this.GC_mainPanel.Size = new System.Drawing.Size(487, 277);
            this.GC_mainPanel.TabIndex = 14;
            // 
            // GC_UseFriendCheckBox
            // 
            this.GC_UseFriendCheckBox.AutoSize = true;
            this.GC_UseFriendCheckBox.Location = new System.Drawing.Point(14, 0);
            this.GC_UseFriendCheckBox.Name = "GC_UseFriendCheckBox";
            this.GC_UseFriendCheckBox.Size = new System.Drawing.Size(82, 17);
            this.GC_UseFriendCheckBox.TabIndex = 20;
            this.GC_UseFriendCheckBox.Text = "Use Friends";
            this.GC_UseFriendCheckBox.UseVisualStyleBackColor = true;
            this.GC_UseFriendCheckBox.CheckedChanged += new System.EventHandler(this.GC_UseFriendCheckBox_CheckedChanged);
            // 
            // GC_masteryComboBox
            // 
            this.GC_masteryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GC_masteryComboBox.Enabled = false;
            this.GC_masteryComboBox.FormattingEnabled = true;
            this.GC_masteryComboBox.Items.AddRange(new object[] {
            "--",
            "1",
            "2",
            "3"});
            this.GC_masteryComboBox.Location = new System.Drawing.Point(354, 215);
            this.GC_masteryComboBox.Name = "GC_masteryComboBox";
            this.GC_masteryComboBox.Size = new System.Drawing.Size(46, 21);
            this.GC_masteryComboBox.TabIndex = 16;
            this.GC_masteryComboBox.Tag = "1";
            this.GC_masteryComboBox.Visible = false;
            this.GC_masteryComboBox.SelectedIndexChanged += new System.EventHandler(this.masteryComboBox_SelectedIndexChanged);
            // 
            // GC_skillGroupBox
            // 
            this.GC_skillGroupBox.Controls.Add(this.GC_bothSkillRadio);
            this.GC_skillGroupBox.Controls.Add(this.GC_wave2Panel);
            this.GC_skillGroupBox.Controls.Add(this.GC_manualSkillRadio);
            this.GC_skillGroupBox.Controls.Add(this.GC_autoSkillRadio);
            this.GC_skillGroupBox.Controls.Add(this.GC_wave1Panel);
            this.GC_skillGroupBox.Location = new System.Drawing.Point(228, 5);
            this.GC_skillGroupBox.Name = "GC_skillGroupBox";
            this.GC_skillGroupBox.Size = new System.Drawing.Size(254, 184);
            this.GC_skillGroupBox.TabIndex = 24;
            this.GC_skillGroupBox.TabStop = false;
            this.GC_skillGroupBox.Tag = "1";
            this.GC_skillGroupBox.Text = "Skill Management";
            // 
            // GC_bothSkillRadio
            // 
            this.GC_bothSkillRadio.AutoSize = true;
            this.GC_bothSkillRadio.Location = new System.Drawing.Point(186, 24);
            this.GC_bothSkillRadio.Name = "GC_bothSkillRadio";
            this.GC_bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.GC_bothSkillRadio.TabIndex = 7;
            this.GC_bothSkillRadio.Tag = "2";
            this.GC_bothSkillRadio.Text = "Both";
            this.GC_bothSkillRadio.UseVisualStyleBackColor = true;
            this.GC_bothSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // GC_wave2Panel
            // 
            this.GC_wave2Panel.Controls.Add(this.GC_wave2LoopCheckBox);
            this.GC_wave2Panel.Controls.Add(this.GC_w2Skill10Button);
            this.GC_wave2Panel.Controls.Add(this.GC_w2Skill09Button);
            this.GC_wave2Panel.Controls.Add(this.GC_w2Skill08Button);
            this.GC_wave2Panel.Controls.Add(this.GC_w2Skill07Button);
            this.GC_wave2Panel.Controls.Add(this.GC_w2Skill06Button);
            this.GC_wave2Panel.Controls.Add(this.GC_w2Skill05Button);
            this.GC_wave2Panel.Controls.Add(this.GC_w2Skill04Button);
            this.GC_wave2Panel.Controls.Add(this.GC_w2Skill03Button);
            this.GC_wave2Panel.Controls.Add(this.GC_w2Skill02Button);
            this.GC_wave2Panel.Controls.Add(this.GC_wave2Label);
            this.GC_wave2Panel.Controls.Add(this.GC_w2Skill01Button);
            this.GC_wave2Panel.Location = new System.Drawing.Point(6, 109);
            this.GC_wave2Panel.Name = "GC_wave2Panel";
            this.GC_wave2Panel.Size = new System.Drawing.Size(241, 51);
            this.GC_wave2Panel.TabIndex = 9;
            this.GC_wave2Panel.Tag = "4";
            // 
            // GC_wave2LoopCheckBox
            // 
            this.GC_wave2LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.GC_wave2LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_wave2LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.GC_wave2LoopCheckBox.Name = "GC_wave2LoopCheckBox";
            this.GC_wave2LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.GC_wave2LoopCheckBox.TabIndex = 12;
            this.GC_wave2LoopCheckBox.Text = "Loop";
            this.GC_wave2LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GC_wave2LoopCheckBox.UseVisualStyleBackColor = true;
            this.GC_wave2LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // GC_w2Skill10Button
            // 
            this.GC_w2Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w2Skill10Button.Location = new System.Drawing.Point(205, 26);
            this.GC_w2Skill10Button.Name = "GC_w2Skill10Button";
            this.GC_w2Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w2Skill10Button.TabIndex = 10;
            this.GC_w2Skill10Button.Tag = "9";
            this.GC_w2Skill10Button.UseVisualStyleBackColor = true;
            this.GC_w2Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w2Skill09Button
            // 
            this.GC_w2Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w2Skill09Button.Location = new System.Drawing.Point(173, 26);
            this.GC_w2Skill09Button.Name = "GC_w2Skill09Button";
            this.GC_w2Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w2Skill09Button.TabIndex = 9;
            this.GC_w2Skill09Button.Tag = "8";
            this.GC_w2Skill09Button.UseVisualStyleBackColor = true;
            this.GC_w2Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w2Skill08Button
            // 
            this.GC_w2Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w2Skill08Button.Location = new System.Drawing.Point(141, 26);
            this.GC_w2Skill08Button.Name = "GC_w2Skill08Button";
            this.GC_w2Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w2Skill08Button.TabIndex = 8;
            this.GC_w2Skill08Button.Tag = "7";
            this.GC_w2Skill08Button.UseVisualStyleBackColor = true;
            this.GC_w2Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w2Skill07Button
            // 
            this.GC_w2Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w2Skill07Button.Location = new System.Drawing.Point(109, 26);
            this.GC_w2Skill07Button.Name = "GC_w2Skill07Button";
            this.GC_w2Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w2Skill07Button.TabIndex = 7;
            this.GC_w2Skill07Button.Tag = "6";
            this.GC_w2Skill07Button.UseVisualStyleBackColor = true;
            this.GC_w2Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w2Skill06Button
            // 
            this.GC_w2Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w2Skill06Button.Location = new System.Drawing.Point(77, 26);
            this.GC_w2Skill06Button.Name = "GC_w2Skill06Button";
            this.GC_w2Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w2Skill06Button.TabIndex = 6;
            this.GC_w2Skill06Button.Tag = "5";
            this.GC_w2Skill06Button.UseVisualStyleBackColor = true;
            this.GC_w2Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w2Skill05Button
            // 
            this.GC_w2Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w2Skill05Button.Location = new System.Drawing.Point(205, 2);
            this.GC_w2Skill05Button.Name = "GC_w2Skill05Button";
            this.GC_w2Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w2Skill05Button.TabIndex = 5;
            this.GC_w2Skill05Button.Tag = "4";
            this.GC_w2Skill05Button.UseVisualStyleBackColor = true;
            this.GC_w2Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w2Skill04Button
            // 
            this.GC_w2Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w2Skill04Button.Location = new System.Drawing.Point(173, 2);
            this.GC_w2Skill04Button.Name = "GC_w2Skill04Button";
            this.GC_w2Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w2Skill04Button.TabIndex = 4;
            this.GC_w2Skill04Button.Tag = "3";
            this.GC_w2Skill04Button.UseVisualStyleBackColor = true;
            this.GC_w2Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w2Skill03Button
            // 
            this.GC_w2Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w2Skill03Button.Location = new System.Drawing.Point(141, 2);
            this.GC_w2Skill03Button.Name = "GC_w2Skill03Button";
            this.GC_w2Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w2Skill03Button.TabIndex = 3;
            this.GC_w2Skill03Button.Tag = "2";
            this.GC_w2Skill03Button.UseVisualStyleBackColor = true;
            this.GC_w2Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w2Skill02Button
            // 
            this.GC_w2Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w2Skill02Button.Location = new System.Drawing.Point(109, 2);
            this.GC_w2Skill02Button.Name = "GC_w2Skill02Button";
            this.GC_w2Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w2Skill02Button.TabIndex = 2;
            this.GC_w2Skill02Button.Tag = "1";
            this.GC_w2Skill02Button.UseVisualStyleBackColor = true;
            this.GC_w2Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_wave2Label
            // 
            this.GC_wave2Label.Location = new System.Drawing.Point(6, 7);
            this.GC_wave2Label.Name = "GC_wave2Label";
            this.GC_wave2Label.Size = new System.Drawing.Size(60, 13);
            this.GC_wave2Label.TabIndex = 0;
            this.GC_wave2Label.Text = "Wave 2";
            // 
            // GC_w2Skill01Button
            // 
            this.GC_w2Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w2Skill01Button.Location = new System.Drawing.Point(77, 2);
            this.GC_w2Skill01Button.Name = "GC_w2Skill01Button";
            this.GC_w2Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w2Skill01Button.TabIndex = 1;
            this.GC_w2Skill01Button.Tag = "0";
            this.GC_w2Skill01Button.UseVisualStyleBackColor = true;
            this.GC_w2Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_manualSkillRadio
            // 
            this.GC_manualSkillRadio.AutoSize = true;
            this.GC_manualSkillRadio.Location = new System.Drawing.Point(94, 24);
            this.GC_manualSkillRadio.Name = "GC_manualSkillRadio";
            this.GC_manualSkillRadio.Size = new System.Drawing.Size(82, 17);
            this.GC_manualSkillRadio.TabIndex = 6;
            this.GC_manualSkillRadio.Tag = "1";
            this.GC_manualSkillRadio.Text = "Manual Skill";
            this.GC_manualSkillRadio.UseVisualStyleBackColor = true;
            this.GC_manualSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // GC_autoSkillRadio
            // 
            this.GC_autoSkillRadio.AutoSize = true;
            this.GC_autoSkillRadio.Checked = true;
            this.GC_autoSkillRadio.Location = new System.Drawing.Point(15, 24);
            this.GC_autoSkillRadio.Name = "GC_autoSkillRadio";
            this.GC_autoSkillRadio.Size = new System.Drawing.Size(69, 17);
            this.GC_autoSkillRadio.TabIndex = 5;
            this.GC_autoSkillRadio.TabStop = true;
            this.GC_autoSkillRadio.Tag = "0";
            this.GC_autoSkillRadio.Text = "Auto Skill";
            this.GC_autoSkillRadio.UseVisualStyleBackColor = true;
            this.GC_autoSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // GC_wave1Panel
            // 
            this.GC_wave1Panel.Controls.Add(this.GC_wave1LoopCheckBox);
            this.GC_wave1Panel.Controls.Add(this.GC_w1Skill10Button);
            this.GC_wave1Panel.Controls.Add(this.GC_w1Skill09Button);
            this.GC_wave1Panel.Controls.Add(this.GC_w1Skill08Button);
            this.GC_wave1Panel.Controls.Add(this.GC_w1Skill07Button);
            this.GC_wave1Panel.Controls.Add(this.GC_w1Skill06Button);
            this.GC_wave1Panel.Controls.Add(this.GC_w1Skill05Button);
            this.GC_wave1Panel.Controls.Add(this.GC_w1Skill04Button);
            this.GC_wave1Panel.Controls.Add(this.GC_w1Skill03Button);
            this.GC_wave1Panel.Controls.Add(this.GC_w1Skill02Button);
            this.GC_wave1Panel.Controls.Add(this.GC_wave1Label);
            this.GC_wave1Panel.Controls.Add(this.GC_w1Skill01Button);
            this.GC_wave1Panel.Location = new System.Drawing.Point(6, 52);
            this.GC_wave1Panel.Name = "GC_wave1Panel";
            this.GC_wave1Panel.Size = new System.Drawing.Size(241, 51);
            this.GC_wave1Panel.TabIndex = 8;
            this.GC_wave1Panel.Tag = "3";
            // 
            // GC_wave1LoopCheckBox
            // 
            this.GC_wave1LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.GC_wave1LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_wave1LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.GC_wave1LoopCheckBox.Name = "GC_wave1LoopCheckBox";
            this.GC_wave1LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.GC_wave1LoopCheckBox.TabIndex = 12;
            this.GC_wave1LoopCheckBox.Text = "Loop";
            this.GC_wave1LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GC_wave1LoopCheckBox.UseVisualStyleBackColor = true;
            this.GC_wave1LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // GC_w1Skill10Button
            // 
            this.GC_w1Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w1Skill10Button.Location = new System.Drawing.Point(205, 26);
            this.GC_w1Skill10Button.Name = "GC_w1Skill10Button";
            this.GC_w1Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w1Skill10Button.TabIndex = 10;
            this.GC_w1Skill10Button.Tag = "9";
            this.GC_w1Skill10Button.UseVisualStyleBackColor = true;
            this.GC_w1Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w1Skill09Button
            // 
            this.GC_w1Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w1Skill09Button.Location = new System.Drawing.Point(173, 26);
            this.GC_w1Skill09Button.Name = "GC_w1Skill09Button";
            this.GC_w1Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w1Skill09Button.TabIndex = 9;
            this.GC_w1Skill09Button.Tag = "8";
            this.GC_w1Skill09Button.UseVisualStyleBackColor = true;
            this.GC_w1Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w1Skill08Button
            // 
            this.GC_w1Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w1Skill08Button.Location = new System.Drawing.Point(141, 26);
            this.GC_w1Skill08Button.Name = "GC_w1Skill08Button";
            this.GC_w1Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w1Skill08Button.TabIndex = 8;
            this.GC_w1Skill08Button.Tag = "7";
            this.GC_w1Skill08Button.UseVisualStyleBackColor = true;
            this.GC_w1Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w1Skill07Button
            // 
            this.GC_w1Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w1Skill07Button.Location = new System.Drawing.Point(109, 26);
            this.GC_w1Skill07Button.Name = "GC_w1Skill07Button";
            this.GC_w1Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w1Skill07Button.TabIndex = 7;
            this.GC_w1Skill07Button.Tag = "6";
            this.GC_w1Skill07Button.UseVisualStyleBackColor = true;
            this.GC_w1Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w1Skill06Button
            // 
            this.GC_w1Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w1Skill06Button.Location = new System.Drawing.Point(77, 26);
            this.GC_w1Skill06Button.Name = "GC_w1Skill06Button";
            this.GC_w1Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w1Skill06Button.TabIndex = 6;
            this.GC_w1Skill06Button.Tag = "5";
            this.GC_w1Skill06Button.UseVisualStyleBackColor = true;
            this.GC_w1Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w1Skill05Button
            // 
            this.GC_w1Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w1Skill05Button.Location = new System.Drawing.Point(205, 2);
            this.GC_w1Skill05Button.Name = "GC_w1Skill05Button";
            this.GC_w1Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w1Skill05Button.TabIndex = 5;
            this.GC_w1Skill05Button.Tag = "4";
            this.GC_w1Skill05Button.UseVisualStyleBackColor = true;
            this.GC_w1Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w1Skill04Button
            // 
            this.GC_w1Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w1Skill04Button.Location = new System.Drawing.Point(173, 2);
            this.GC_w1Skill04Button.Name = "GC_w1Skill04Button";
            this.GC_w1Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w1Skill04Button.TabIndex = 4;
            this.GC_w1Skill04Button.Tag = "3";
            this.GC_w1Skill04Button.UseVisualStyleBackColor = true;
            this.GC_w1Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w1Skill03Button
            // 
            this.GC_w1Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w1Skill03Button.Location = new System.Drawing.Point(141, 2);
            this.GC_w1Skill03Button.Name = "GC_w1Skill03Button";
            this.GC_w1Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w1Skill03Button.TabIndex = 3;
            this.GC_w1Skill03Button.Tag = "2";
            this.GC_w1Skill03Button.UseVisualStyleBackColor = true;
            this.GC_w1Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_w1Skill02Button
            // 
            this.GC_w1Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w1Skill02Button.Location = new System.Drawing.Point(109, 2);
            this.GC_w1Skill02Button.Name = "GC_w1Skill02Button";
            this.GC_w1Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w1Skill02Button.TabIndex = 2;
            this.GC_w1Skill02Button.Tag = "1";
            this.GC_w1Skill02Button.UseVisualStyleBackColor = true;
            this.GC_w1Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_wave1Label
            // 
            this.GC_wave1Label.Location = new System.Drawing.Point(6, 7);
            this.GC_wave1Label.Name = "GC_wave1Label";
            this.GC_wave1Label.Size = new System.Drawing.Size(60, 13);
            this.GC_wave1Label.TabIndex = 0;
            this.GC_wave1Label.Text = "Wave 1";
            // 
            // GC_w1Skill01Button
            // 
            this.GC_w1Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GC_w1Skill01Button.Location = new System.Drawing.Point(77, 2);
            this.GC_w1Skill01Button.Name = "GC_w1Skill01Button";
            this.GC_w1Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.GC_w1Skill01Button.TabIndex = 1;
            this.GC_w1Skill01Button.Tag = "0";
            this.GC_w1Skill01Button.UseVisualStyleBackColor = true;
            this.GC_w1Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // GC_masteryLabel
            // 
            this.GC_masteryLabel.AutoSize = true;
            this.GC_masteryLabel.Enabled = false;
            this.GC_masteryLabel.Location = new System.Drawing.Point(302, 219);
            this.GC_masteryLabel.Name = "GC_masteryLabel";
            this.GC_masteryLabel.Size = new System.Drawing.Size(44, 13);
            this.GC_masteryLabel.TabIndex = 15;
            this.GC_masteryLabel.Text = "Mastery";
            this.GC_masteryLabel.Visible = false;
            // 
            // GC_formationComboBox
            // 
            this.GC_formationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GC_formationComboBox.FormattingEnabled = true;
            this.GC_formationComboBox.Items.AddRange(new object[] {
            "--",
            "2 Front / 3 Back",
            "3 Front / 2 Back",
            "1 Front / 4 Back",
            "4 Front / 1 Back"});
            this.GC_formationComboBox.Location = new System.Drawing.Point(81, 143);
            this.GC_formationComboBox.Name = "GC_formationComboBox";
            this.GC_formationComboBox.Size = new System.Drawing.Size(127, 21);
            this.GC_formationComboBox.TabIndex = 3;
            this.GC_formationComboBox.Tag = "1";
            this.GC_formationComboBox.Visible = false;
            this.GC_formationComboBox.SelectedIndexChanged += new System.EventHandler(this.formationComboBox_SelectedIndexChanged);
            // 
            // GC_teamComboBox
            // 
            this.GC_teamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GC_teamComboBox.Enabled = false;
            this.GC_teamComboBox.FormattingEnabled = true;
            this.GC_teamComboBox.Items.AddRange(new object[] {
            "--",
            "A",
            "B",
            "C"});
            this.GC_teamComboBox.Location = new System.Drawing.Point(81, 111);
            this.GC_teamComboBox.Name = "GC_teamComboBox";
            this.GC_teamComboBox.Size = new System.Drawing.Size(52, 21);
            this.GC_teamComboBox.TabIndex = 2;
            this.GC_teamComboBox.Tag = "1";
            this.GC_teamComboBox.Visible = false;
            this.GC_teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // GC_formationPanel
            // 
            this.GC_formationPanel.BackColor = System.Drawing.Color.Silver;
            this.GC_formationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GC_formationPanel.Controls.Add(this.GC_pos5CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos4CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos3CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos2CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos1CheckBox);
            this.GC_formationPanel.Location = new System.Drawing.Point(81, 170);
            this.GC_formationPanel.Name = "GC_formationPanel";
            this.GC_formationPanel.Size = new System.Drawing.Size(80, 85);
            this.GC_formationPanel.TabIndex = 4;
            this.GC_formationPanel.Tag = "1";
            this.GC_formationPanel.Visible = false;
            // 
            // GC_pos5CheckBox
            // 
            this.GC_pos5CheckBox.AutoSize = true;
            this.GC_pos5CheckBox.Enabled = false;
            this.GC_pos5CheckBox.Location = new System.Drawing.Point(3, 61);
            this.GC_pos5CheckBox.Name = "GC_pos5CheckBox";
            this.GC_pos5CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos5CheckBox.TabIndex = 4;
            this.GC_pos5CheckBox.Tag = "4";
            this.GC_pos5CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos5CheckBox.Visible = false;
            // 
            // GC_pos4CheckBox
            // 
            this.GC_pos4CheckBox.AutoSize = true;
            this.GC_pos4CheckBox.Enabled = false;
            this.GC_pos4CheckBox.Location = new System.Drawing.Point(3, 48);
            this.GC_pos4CheckBox.Name = "GC_pos4CheckBox";
            this.GC_pos4CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos4CheckBox.TabIndex = 3;
            this.GC_pos4CheckBox.Tag = "3";
            this.GC_pos4CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos4CheckBox.Visible = false;
            // 
            // GC_pos3CheckBox
            // 
            this.GC_pos3CheckBox.AutoSize = true;
            this.GC_pos3CheckBox.Enabled = false;
            this.GC_pos3CheckBox.Location = new System.Drawing.Point(3, 35);
            this.GC_pos3CheckBox.Name = "GC_pos3CheckBox";
            this.GC_pos3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos3CheckBox.TabIndex = 2;
            this.GC_pos3CheckBox.Tag = "2";
            this.GC_pos3CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos3CheckBox.Visible = false;
            // 
            // GC_pos2CheckBox
            // 
            this.GC_pos2CheckBox.AutoSize = true;
            this.GC_pos2CheckBox.Enabled = false;
            this.GC_pos2CheckBox.Location = new System.Drawing.Point(3, 22);
            this.GC_pos2CheckBox.Name = "GC_pos2CheckBox";
            this.GC_pos2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos2CheckBox.TabIndex = 1;
            this.GC_pos2CheckBox.Tag = "1";
            this.GC_pos2CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos2CheckBox.Visible = false;
            // 
            // GC_pos1CheckBox
            // 
            this.GC_pos1CheckBox.AutoSize = true;
            this.GC_pos1CheckBox.Enabled = false;
            this.GC_pos1CheckBox.Location = new System.Drawing.Point(3, 9);
            this.GC_pos1CheckBox.Name = "GC_pos1CheckBox";
            this.GC_pos1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos1CheckBox.TabIndex = 0;
            this.GC_pos1CheckBox.Tag = "0";
            this.GC_pos1CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos1CheckBox.Visible = false;
            // 
            // GC_formationLabel
            // 
            this.GC_formationLabel.Location = new System.Drawing.Point(12, 146);
            this.GC_formationLabel.Name = "GC_formationLabel";
            this.GC_formationLabel.Size = new System.Drawing.Size(62, 13);
            this.GC_formationLabel.TabIndex = 20;
            this.GC_formationLabel.Text = "Formation";
            this.GC_formationLabel.Visible = false;
            // 
            // GC_teamLabel
            // 
            this.GC_teamLabel.Enabled = false;
            this.GC_teamLabel.Location = new System.Drawing.Point(12, 114);
            this.GC_teamLabel.Name = "GC_teamLabel";
            this.GC_teamLabel.Size = new System.Drawing.Size(62, 13);
            this.GC_teamLabel.TabIndex = 19;
            this.GC_teamLabel.Text = "Team";
            this.GC_teamLabel.Visible = false;
            // 
            // GC_enableCheckBox
            // 
            this.GC_enableCheckBox.AutoSize = true;
            this.GC_enableCheckBox.Checked = true;
            this.GC_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GC_enableCheckBox.Location = new System.Drawing.Point(9, 7);
            this.GC_enableCheckBox.Name = "GC_enableCheckBox";
            this.GC_enableCheckBox.Size = new System.Drawing.Size(129, 17);
            this.GC_enableCheckBox.TabIndex = 1;
            this.GC_enableCheckBox.Tag = "1";
            this.GC_enableCheckBox.Text = "Enable Gold Chamber";
            this.GC_enableCheckBox.UseVisualStyleBackColor = true;
            this.GC_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // specialDungeonTab
            // 
            this.specialDungeonTab.BackColor = System.Drawing.SystemColors.Control;
            this.specialDungeonTab.Controls.Add(this.label17);
            this.specialDungeonTab.Controls.Add(this.SP_limitNumericBox);
            this.specialDungeonTab.Controls.Add(this.SP_limitCheckBox);
            this.specialDungeonTab.Controls.Add(this.karinGroupBox);
            this.specialDungeonTab.Controls.Add(this.evanGroupBox);
            this.specialDungeonTab.Controls.Add(this.crystalGroupBox);
            this.specialDungeonTab.Controls.Add(this.cakeGroupBox);
            this.specialDungeonTab.Controls.Add(this.dailyGroupBox);
            this.specialDungeonTab.Controls.Add(this.SP_skillGroupBox);
            this.specialDungeonTab.Controls.Add(this.SP_enableCheckBox);
            this.specialDungeonTab.Location = new System.Drawing.Point(4, 22);
            this.specialDungeonTab.Name = "specialDungeonTab";
            this.specialDungeonTab.Size = new System.Drawing.Size(488, 309);
            this.specialDungeonTab.TabIndex = 9;
            this.specialDungeonTab.Text = "SpDungeon";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(407, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "times per visit";
            // 
            // SP_limitNumericBox
            // 
            this.SP_limitNumericBox.Location = new System.Drawing.Point(365, 5);
            this.SP_limitNumericBox.Name = "SP_limitNumericBox";
            this.SP_limitNumericBox.Size = new System.Drawing.Size(37, 20);
            this.SP_limitNumericBox.TabIndex = 40;
            this.SP_limitNumericBox.Tag = "5";
            this.SP_limitNumericBox.ValueChanged += new System.EventHandler(this.limitNumericBox_ValueChanged);
            // 
            // SP_limitCheckBox
            // 
            this.SP_limitCheckBox.Location = new System.Drawing.Point(315, 7);
            this.SP_limitCheckBox.Name = "SP_limitCheckBox";
            this.SP_limitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.SP_limitCheckBox.TabIndex = 39;
            this.SP_limitCheckBox.Tag = "5";
            this.SP_limitCheckBox.Text = "Limit";
            this.SP_limitCheckBox.UseVisualStyleBackColor = true;
            this.SP_limitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // karinGroupBox
            // 
            this.karinGroupBox.Controls.Add(this.label16);
            this.karinGroupBox.Controls.Add(this.SP_karinCheckBox);
            this.karinGroupBox.Controls.Add(this.SP_karinHellRadioButton);
            this.karinGroupBox.Controls.Add(this.SP_karinLimitNumericBox);
            this.karinGroupBox.Controls.Add(this.SP_karinHardRadioButton);
            this.karinGroupBox.Controls.Add(this.label12);
            this.karinGroupBox.Controls.Add(this.SP_karinNorRadioButton);
            this.karinGroupBox.Location = new System.Drawing.Point(9, 246);
            this.karinGroupBox.Name = "karinGroupBox";
            this.karinGroupBox.Size = new System.Drawing.Size(213, 44);
            this.karinGroupBox.TabIndex = 38;
            this.karinGroupBox.TabStop = false;
            this.karinGroupBox.Text = "Event Tab";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(21, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Difficulty";
            // 
            // SP_karinCheckBox
            // 
            this.SP_karinCheckBox.AutoSize = true;
            this.SP_karinCheckBox.Location = new System.Drawing.Point(7, 1);
            this.SP_karinCheckBox.Name = "SP_karinCheckBox";
            this.SP_karinCheckBox.Size = new System.Drawing.Size(88, 17);
            this.SP_karinCheckBox.TabIndex = 33;
            this.SP_karinCheckBox.Tag = "4";
            this.SP_karinCheckBox.Text = "Event Row 4";
            this.SP_karinCheckBox.UseVisualStyleBackColor = true;
            this.SP_karinCheckBox.CheckedChanged += new System.EventHandler(this.spEnableCheckBox_CheckedChanged);
            // 
            // SP_karinHellRadioButton
            // 
            this.SP_karinHellRadioButton.AutoSize = true;
            this.SP_karinHellRadioButton.Location = new System.Drawing.Point(170, 23);
            this.SP_karinHellRadioButton.Name = "SP_karinHellRadioButton";
            this.SP_karinHellRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_karinHellRadioButton.TabIndex = 1;
            this.SP_karinHellRadioButton.Tag = "2";
            this.SP_karinHellRadioButton.Text = "R3";
            this.SP_karinHellRadioButton.UseVisualStyleBackColor = true;
            this.SP_karinHellRadioButton.CheckedChanged += new System.EventHandler(this.SP_karinRadioButton_CheckedChanged);
            // 
            // SP_karinLimitNumericBox
            // 
            this.SP_karinLimitNumericBox.Location = new System.Drawing.Point(131, 1);
            this.SP_karinLimitNumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SP_karinLimitNumericBox.Name = "SP_karinLimitNumericBox";
            this.SP_karinLimitNumericBox.Size = new System.Drawing.Size(41, 20);
            this.SP_karinLimitNumericBox.TabIndex = 35;
            this.SP_karinLimitNumericBox.Tag = "4";
            this.SP_karinLimitNumericBox.ValueChanged += new System.EventHandler(this.splimitNumericBox_ValueChanged);
            // 
            // SP_karinHardRadioButton
            // 
            this.SP_karinHardRadioButton.AutoSize = true;
            this.SP_karinHardRadioButton.Location = new System.Drawing.Point(123, 23);
            this.SP_karinHardRadioButton.Name = "SP_karinHardRadioButton";
            this.SP_karinHardRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_karinHardRadioButton.TabIndex = 1;
            this.SP_karinHardRadioButton.Tag = "1";
            this.SP_karinHardRadioButton.Text = "R2";
            this.SP_karinHardRadioButton.UseVisualStyleBackColor = true;
            this.SP_karinHardRadioButton.CheckedChanged += new System.EventHandler(this.SP_karinRadioButton_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "times";
            // 
            // SP_karinNorRadioButton
            // 
            this.SP_karinNorRadioButton.AutoSize = true;
            this.SP_karinNorRadioButton.Checked = true;
            this.SP_karinNorRadioButton.Location = new System.Drawing.Point(78, 23);
            this.SP_karinNorRadioButton.Name = "SP_karinNorRadioButton";
            this.SP_karinNorRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_karinNorRadioButton.TabIndex = 2;
            this.SP_karinNorRadioButton.TabStop = true;
            this.SP_karinNorRadioButton.Tag = "0";
            this.SP_karinNorRadioButton.Text = "R1";
            this.SP_karinNorRadioButton.UseVisualStyleBackColor = true;
            this.SP_karinNorRadioButton.CheckedChanged += new System.EventHandler(this.SP_karinRadioButton_CheckedChanged);
            // 
            // evanGroupBox
            // 
            this.evanGroupBox.Controls.Add(this.label15);
            this.evanGroupBox.Controls.Add(this.SP_evanCheckBox);
            this.evanGroupBox.Controls.Add(this.SP_evanHellRadioButton);
            this.evanGroupBox.Controls.Add(this.SP_evanLimitNumericBox);
            this.evanGroupBox.Controls.Add(this.SP_evanHardRadioButton);
            this.evanGroupBox.Controls.Add(this.label11);
            this.evanGroupBox.Controls.Add(this.SP_evanNorRadioButton);
            this.evanGroupBox.Location = new System.Drawing.Point(9, 198);
            this.evanGroupBox.Name = "evanGroupBox";
            this.evanGroupBox.Size = new System.Drawing.Size(213, 44);
            this.evanGroupBox.TabIndex = 38;
            this.evanGroupBox.TabStop = false;
            this.evanGroupBox.Text = "Event Tab";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(21, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Difficulty";
            // 
            // SP_evanCheckBox
            // 
            this.SP_evanCheckBox.AutoSize = true;
            this.SP_evanCheckBox.Location = new System.Drawing.Point(7, 0);
            this.SP_evanCheckBox.Name = "SP_evanCheckBox";
            this.SP_evanCheckBox.Size = new System.Drawing.Size(88, 17);
            this.SP_evanCheckBox.TabIndex = 33;
            this.SP_evanCheckBox.Tag = "3";
            this.SP_evanCheckBox.Text = "Event Row 3";
            this.SP_evanCheckBox.UseVisualStyleBackColor = true;
            this.SP_evanCheckBox.CheckedChanged += new System.EventHandler(this.spEnableCheckBox_CheckedChanged);
            // 
            // SP_evanHellRadioButton
            // 
            this.SP_evanHellRadioButton.AutoSize = true;
            this.SP_evanHellRadioButton.Location = new System.Drawing.Point(170, 23);
            this.SP_evanHellRadioButton.Name = "SP_evanHellRadioButton";
            this.SP_evanHellRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_evanHellRadioButton.TabIndex = 1;
            this.SP_evanHellRadioButton.Tag = "2";
            this.SP_evanHellRadioButton.Text = "R3";
            this.SP_evanHellRadioButton.UseVisualStyleBackColor = true;
            this.SP_evanHellRadioButton.CheckedChanged += new System.EventHandler(this.SP_evanRadioButton_CheckedChanged);
            // 
            // SP_evanLimitNumericBox
            // 
            this.SP_evanLimitNumericBox.Location = new System.Drawing.Point(131, 0);
            this.SP_evanLimitNumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SP_evanLimitNumericBox.Name = "SP_evanLimitNumericBox";
            this.SP_evanLimitNumericBox.Size = new System.Drawing.Size(41, 20);
            this.SP_evanLimitNumericBox.TabIndex = 35;
            this.SP_evanLimitNumericBox.Tag = "3";
            this.SP_evanLimitNumericBox.ValueChanged += new System.EventHandler(this.splimitNumericBox_ValueChanged);
            // 
            // SP_evanHardRadioButton
            // 
            this.SP_evanHardRadioButton.AutoSize = true;
            this.SP_evanHardRadioButton.Location = new System.Drawing.Point(123, 23);
            this.SP_evanHardRadioButton.Name = "SP_evanHardRadioButton";
            this.SP_evanHardRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_evanHardRadioButton.TabIndex = 1;
            this.SP_evanHardRadioButton.Tag = "1";
            this.SP_evanHardRadioButton.Text = "R2";
            this.SP_evanHardRadioButton.UseVisualStyleBackColor = true;
            this.SP_evanHardRadioButton.CheckedChanged += new System.EventHandler(this.SP_evanRadioButton_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "times";
            // 
            // SP_evanNorRadioButton
            // 
            this.SP_evanNorRadioButton.AutoSize = true;
            this.SP_evanNorRadioButton.Checked = true;
            this.SP_evanNorRadioButton.Location = new System.Drawing.Point(78, 23);
            this.SP_evanNorRadioButton.Name = "SP_evanNorRadioButton";
            this.SP_evanNorRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_evanNorRadioButton.TabIndex = 2;
            this.SP_evanNorRadioButton.TabStop = true;
            this.SP_evanNorRadioButton.Tag = "0";
            this.SP_evanNorRadioButton.Text = "R1";
            this.SP_evanNorRadioButton.UseVisualStyleBackColor = true;
            this.SP_evanNorRadioButton.CheckedChanged += new System.EventHandler(this.SP_evanRadioButton_CheckedChanged);
            // 
            // crystalGroupBox
            // 
            this.crystalGroupBox.Controls.Add(this.label14);
            this.crystalGroupBox.Controls.Add(this.SP_crystalCheckBox);
            this.crystalGroupBox.Controls.Add(this.SP_crystalHardRadioButton);
            this.crystalGroupBox.Controls.Add(this.SP_crystalLimitNumericBox);
            this.crystalGroupBox.Controls.Add(this.SP_crystalNorRadioButton);
            this.crystalGroupBox.Controls.Add(this.label10);
            this.crystalGroupBox.Controls.Add(this.SP_crystalEasyRadioButton);
            this.crystalGroupBox.Location = new System.Drawing.Point(9, 148);
            this.crystalGroupBox.Name = "crystalGroupBox";
            this.crystalGroupBox.Size = new System.Drawing.Size(213, 44);
            this.crystalGroupBox.TabIndex = 38;
            this.crystalGroupBox.TabStop = false;
            this.crystalGroupBox.Text = "Event Tab";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(21, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Difficulty";
            // 
            // SP_crystalCheckBox
            // 
            this.SP_crystalCheckBox.AutoSize = true;
            this.SP_crystalCheckBox.Location = new System.Drawing.Point(7, 0);
            this.SP_crystalCheckBox.Name = "SP_crystalCheckBox";
            this.SP_crystalCheckBox.Size = new System.Drawing.Size(88, 17);
            this.SP_crystalCheckBox.TabIndex = 33;
            this.SP_crystalCheckBox.Tag = "2";
            this.SP_crystalCheckBox.Text = "Event Row 2";
            this.SP_crystalCheckBox.UseVisualStyleBackColor = true;
            this.SP_crystalCheckBox.CheckedChanged += new System.EventHandler(this.spEnableCheckBox_CheckedChanged);
            // 
            // SP_crystalHardRadioButton
            // 
            this.SP_crystalHardRadioButton.AutoSize = true;
            this.SP_crystalHardRadioButton.Location = new System.Drawing.Point(170, 23);
            this.SP_crystalHardRadioButton.Name = "SP_crystalHardRadioButton";
            this.SP_crystalHardRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_crystalHardRadioButton.TabIndex = 1;
            this.SP_crystalHardRadioButton.Tag = "2";
            this.SP_crystalHardRadioButton.Text = "R3";
            this.SP_crystalHardRadioButton.UseVisualStyleBackColor = true;
            this.SP_crystalHardRadioButton.CheckedChanged += new System.EventHandler(this.SP_crystalRadioButton_CheckedChanged);
            // 
            // SP_crystalLimitNumericBox
            // 
            this.SP_crystalLimitNumericBox.Location = new System.Drawing.Point(131, 0);
            this.SP_crystalLimitNumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SP_crystalLimitNumericBox.Name = "SP_crystalLimitNumericBox";
            this.SP_crystalLimitNumericBox.Size = new System.Drawing.Size(41, 20);
            this.SP_crystalLimitNumericBox.TabIndex = 35;
            this.SP_crystalLimitNumericBox.Tag = "2";
            this.SP_crystalLimitNumericBox.ValueChanged += new System.EventHandler(this.splimitNumericBox_ValueChanged);
            // 
            // SP_crystalNorRadioButton
            // 
            this.SP_crystalNorRadioButton.AutoSize = true;
            this.SP_crystalNorRadioButton.Location = new System.Drawing.Point(123, 23);
            this.SP_crystalNorRadioButton.Name = "SP_crystalNorRadioButton";
            this.SP_crystalNorRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_crystalNorRadioButton.TabIndex = 1;
            this.SP_crystalNorRadioButton.Tag = "1";
            this.SP_crystalNorRadioButton.Text = "R2";
            this.SP_crystalNorRadioButton.UseVisualStyleBackColor = true;
            this.SP_crystalNorRadioButton.CheckedChanged += new System.EventHandler(this.SP_crystalRadioButton_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "times";
            // 
            // SP_crystalEasyRadioButton
            // 
            this.SP_crystalEasyRadioButton.AutoSize = true;
            this.SP_crystalEasyRadioButton.Checked = true;
            this.SP_crystalEasyRadioButton.Location = new System.Drawing.Point(78, 23);
            this.SP_crystalEasyRadioButton.Name = "SP_crystalEasyRadioButton";
            this.SP_crystalEasyRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_crystalEasyRadioButton.TabIndex = 2;
            this.SP_crystalEasyRadioButton.TabStop = true;
            this.SP_crystalEasyRadioButton.Tag = "0";
            this.SP_crystalEasyRadioButton.Text = "R1";
            this.SP_crystalEasyRadioButton.UseVisualStyleBackColor = true;
            this.SP_crystalEasyRadioButton.CheckedChanged += new System.EventHandler(this.SP_crystalRadioButton_CheckedChanged);
            // 
            // cakeGroupBox
            // 
            this.cakeGroupBox.Controls.Add(this.label13);
            this.cakeGroupBox.Controls.Add(this.SP_cakeCheckBox);
            this.cakeGroupBox.Controls.Add(this.SP_cakeHardRadioButton);
            this.cakeGroupBox.Controls.Add(this.SP_cakeLimitNumericBox);
            this.cakeGroupBox.Controls.Add(this.SP_cakeNormalRadioButton);
            this.cakeGroupBox.Controls.Add(this.label8);
            this.cakeGroupBox.Controls.Add(this.SP_cakeEasyRadioButton);
            this.cakeGroupBox.Location = new System.Drawing.Point(9, 98);
            this.cakeGroupBox.Name = "cakeGroupBox";
            this.cakeGroupBox.Size = new System.Drawing.Size(213, 44);
            this.cakeGroupBox.TabIndex = 38;
            this.cakeGroupBox.TabStop = false;
            this.cakeGroupBox.Text = "Event Tab";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(21, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Difficulty";
            // 
            // SP_cakeCheckBox
            // 
            this.SP_cakeCheckBox.AutoSize = true;
            this.SP_cakeCheckBox.Location = new System.Drawing.Point(7, 0);
            this.SP_cakeCheckBox.Name = "SP_cakeCheckBox";
            this.SP_cakeCheckBox.Size = new System.Drawing.Size(88, 17);
            this.SP_cakeCheckBox.TabIndex = 33;
            this.SP_cakeCheckBox.Tag = "1";
            this.SP_cakeCheckBox.Text = "Event Row 1";
            this.SP_cakeCheckBox.UseVisualStyleBackColor = true;
            this.SP_cakeCheckBox.CheckedChanged += new System.EventHandler(this.spEnableCheckBox_CheckedChanged);
            // 
            // SP_cakeHardRadioButton
            // 
            this.SP_cakeHardRadioButton.AutoSize = true;
            this.SP_cakeHardRadioButton.Location = new System.Drawing.Point(170, 23);
            this.SP_cakeHardRadioButton.Name = "SP_cakeHardRadioButton";
            this.SP_cakeHardRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_cakeHardRadioButton.TabIndex = 1;
            this.SP_cakeHardRadioButton.Tag = "2";
            this.SP_cakeHardRadioButton.Text = "R3";
            this.SP_cakeHardRadioButton.UseVisualStyleBackColor = true;
            this.SP_cakeHardRadioButton.CheckedChanged += new System.EventHandler(this.SP_cakeRadioButton_CheckedChanged);
            // 
            // SP_cakeLimitNumericBox
            // 
            this.SP_cakeLimitNumericBox.Location = new System.Drawing.Point(131, 0);
            this.SP_cakeLimitNumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SP_cakeLimitNumericBox.Name = "SP_cakeLimitNumericBox";
            this.SP_cakeLimitNumericBox.Size = new System.Drawing.Size(41, 20);
            this.SP_cakeLimitNumericBox.TabIndex = 35;
            this.SP_cakeLimitNumericBox.Tag = "1";
            this.SP_cakeLimitNumericBox.ValueChanged += new System.EventHandler(this.splimitNumericBox_ValueChanged);
            // 
            // SP_cakeNormalRadioButton
            // 
            this.SP_cakeNormalRadioButton.AutoSize = true;
            this.SP_cakeNormalRadioButton.Location = new System.Drawing.Point(123, 23);
            this.SP_cakeNormalRadioButton.Name = "SP_cakeNormalRadioButton";
            this.SP_cakeNormalRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_cakeNormalRadioButton.TabIndex = 1;
            this.SP_cakeNormalRadioButton.Tag = "1";
            this.SP_cakeNormalRadioButton.Text = "R2";
            this.SP_cakeNormalRadioButton.UseVisualStyleBackColor = true;
            this.SP_cakeNormalRadioButton.CheckedChanged += new System.EventHandler(this.SP_cakeRadioButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "times";
            // 
            // SP_cakeEasyRadioButton
            // 
            this.SP_cakeEasyRadioButton.AutoSize = true;
            this.SP_cakeEasyRadioButton.Checked = true;
            this.SP_cakeEasyRadioButton.Location = new System.Drawing.Point(78, 23);
            this.SP_cakeEasyRadioButton.Name = "SP_cakeEasyRadioButton";
            this.SP_cakeEasyRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_cakeEasyRadioButton.TabIndex = 2;
            this.SP_cakeEasyRadioButton.TabStop = true;
            this.SP_cakeEasyRadioButton.Tag = "0";
            this.SP_cakeEasyRadioButton.Text = "R1";
            this.SP_cakeEasyRadioButton.UseVisualStyleBackColor = true;
            this.SP_cakeEasyRadioButton.CheckedChanged += new System.EventHandler(this.SP_cakeRadioButton_CheckedChanged);
            // 
            // dailyGroupBox
            // 
            this.dailyGroupBox.Controls.Add(this.label9);
            this.dailyGroupBox.Controls.Add(this.SP_dailyCheckBox);
            this.dailyGroupBox.Controls.Add(this.SP_dailyHellRadioButton);
            this.dailyGroupBox.Controls.Add(this.SP_dailyLimitNumericBox);
            this.dailyGroupBox.Controls.Add(this.label7);
            this.dailyGroupBox.Controls.Add(this.SP_dailyHardRadioButton);
            this.dailyGroupBox.Controls.Add(this.SP_dailyNomalRadioButton);
            this.dailyGroupBox.Location = new System.Drawing.Point(9, 36);
            this.dailyGroupBox.Name = "dailyGroupBox";
            this.dailyGroupBox.Size = new System.Drawing.Size(213, 50);
            this.dailyGroupBox.TabIndex = 37;
            this.dailyGroupBox.TabStop = false;
            this.dailyGroupBox.Text = "Daily";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(18, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Difficulty";
            // 
            // SP_dailyCheckBox
            // 
            this.SP_dailyCheckBox.AutoSize = true;
            this.SP_dailyCheckBox.Location = new System.Drawing.Point(6, 0);
            this.SP_dailyCheckBox.Name = "SP_dailyCheckBox";
            this.SP_dailyCheckBox.Size = new System.Drawing.Size(96, 17);
            this.SP_dailyCheckBox.TabIndex = 34;
            this.SP_dailyCheckBox.Tag = "0";
            this.SP_dailyCheckBox.Text = "Daily Dungeon";
            this.SP_dailyCheckBox.UseVisualStyleBackColor = true;
            this.SP_dailyCheckBox.CheckedChanged += new System.EventHandler(this.spEnableCheckBox_CheckedChanged);
            // 
            // SP_dailyHellRadioButton
            // 
            this.SP_dailyHellRadioButton.AutoSize = true;
            this.SP_dailyHellRadioButton.Location = new System.Drawing.Point(170, 27);
            this.SP_dailyHellRadioButton.Name = "SP_dailyHellRadioButton";
            this.SP_dailyHellRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_dailyHellRadioButton.TabIndex = 1;
            this.SP_dailyHellRadioButton.Tag = "2";
            this.SP_dailyHellRadioButton.Text = "R3";
            this.SP_dailyHellRadioButton.UseVisualStyleBackColor = true;
            this.SP_dailyHellRadioButton.CheckedChanged += new System.EventHandler(this.SP_dailyRadioButton_CheckedChanged);
            // 
            // SP_dailyLimitNumericBox
            // 
            this.SP_dailyLimitNumericBox.Location = new System.Drawing.Point(130, 1);
            this.SP_dailyLimitNumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SP_dailyLimitNumericBox.Name = "SP_dailyLimitNumericBox";
            this.SP_dailyLimitNumericBox.Size = new System.Drawing.Size(41, 20);
            this.SP_dailyLimitNumericBox.TabIndex = 35;
            this.SP_dailyLimitNumericBox.Tag = "0";
            this.SP_dailyLimitNumericBox.ValueChanged += new System.EventHandler(this.splimitNumericBox_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "times";
            // 
            // SP_dailyHardRadioButton
            // 
            this.SP_dailyHardRadioButton.AutoSize = true;
            this.SP_dailyHardRadioButton.Location = new System.Drawing.Point(126, 27);
            this.SP_dailyHardRadioButton.Name = "SP_dailyHardRadioButton";
            this.SP_dailyHardRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_dailyHardRadioButton.TabIndex = 1;
            this.SP_dailyHardRadioButton.Tag = "1";
            this.SP_dailyHardRadioButton.Text = "R2";
            this.SP_dailyHardRadioButton.UseVisualStyleBackColor = true;
            this.SP_dailyHardRadioButton.CheckedChanged += new System.EventHandler(this.SP_dailyRadioButton_CheckedChanged);
            // 
            // SP_dailyNomalRadioButton
            // 
            this.SP_dailyNomalRadioButton.AutoSize = true;
            this.SP_dailyNomalRadioButton.Checked = true;
            this.SP_dailyNomalRadioButton.Location = new System.Drawing.Point(78, 27);
            this.SP_dailyNomalRadioButton.Name = "SP_dailyNomalRadioButton";
            this.SP_dailyNomalRadioButton.Size = new System.Drawing.Size(39, 17);
            this.SP_dailyNomalRadioButton.TabIndex = 2;
            this.SP_dailyNomalRadioButton.TabStop = true;
            this.SP_dailyNomalRadioButton.Tag = "0";
            this.SP_dailyNomalRadioButton.Text = "R1";
            this.SP_dailyNomalRadioButton.UseVisualStyleBackColor = true;
            this.SP_dailyNomalRadioButton.CheckedChanged += new System.EventHandler(this.SP_dailyRadioButton_CheckedChanged);
            // 
            // SP_skillGroupBox
            // 
            this.SP_skillGroupBox.Controls.Add(this.SP_wave3Panel);
            this.SP_skillGroupBox.Controls.Add(this.SP_bothSkillRadio);
            this.SP_skillGroupBox.Controls.Add(this.SP_wave2Panel);
            this.SP_skillGroupBox.Controls.Add(this.SP_manualSkillRadio);
            this.SP_skillGroupBox.Controls.Add(this.SP_autoSkillRadio);
            this.SP_skillGroupBox.Controls.Add(this.SP_wave1Panel);
            this.SP_skillGroupBox.Location = new System.Drawing.Point(228, 36);
            this.SP_skillGroupBox.Name = "SP_skillGroupBox";
            this.SP_skillGroupBox.Size = new System.Drawing.Size(254, 254);
            this.SP_skillGroupBox.TabIndex = 29;
            this.SP_skillGroupBox.TabStop = false;
            this.SP_skillGroupBox.Tag = "3";
            this.SP_skillGroupBox.Text = "Skill Management";
            // 
            // SP_wave3Panel
            // 
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill11Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill12Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill13Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill14Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill15Button);
            this.SP_wave3Panel.Controls.Add(this.SP_wave3LoopCheckBox);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill10Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill09Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill08Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill07Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill06Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill05Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill04Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill03Button);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill02Button);
            this.SP_wave3Panel.Controls.Add(this.SP_wave3Label);
            this.SP_wave3Panel.Controls.Add(this.SP_w3Skill01Button);
            this.SP_wave3Panel.Location = new System.Drawing.Point(5, 166);
            this.SP_wave3Panel.Name = "SP_wave3Panel";
            this.SP_wave3Panel.Size = new System.Drawing.Size(241, 82);
            this.SP_wave3Panel.TabIndex = 13;
            this.SP_wave3Panel.Tag = "9";
            // 
            // SP_w3Skill11Button
            // 
            this.SP_w3Skill11Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w3Skill11Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w3Skill11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill11Button.Location = new System.Drawing.Point(78, 4);
            this.SP_w3Skill11Button.Name = "SP_w3Skill11Button";
            this.SP_w3Skill11Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill11Button.TabIndex = 26;
            this.SP_w3Skill11Button.Tag = "10";
            this.SP_w3Skill11Button.UseVisualStyleBackColor = false;
            this.SP_w3Skill11Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill12Button
            // 
            this.SP_w3Skill12Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w3Skill12Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w3Skill12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill12Button.Location = new System.Drawing.Point(110, 4);
            this.SP_w3Skill12Button.Name = "SP_w3Skill12Button";
            this.SP_w3Skill12Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill12Button.TabIndex = 27;
            this.SP_w3Skill12Button.Tag = "11";
            this.SP_w3Skill12Button.UseVisualStyleBackColor = false;
            this.SP_w3Skill12Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill13Button
            // 
            this.SP_w3Skill13Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w3Skill13Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w3Skill13Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill13Button.Location = new System.Drawing.Point(142, 4);
            this.SP_w3Skill13Button.Name = "SP_w3Skill13Button";
            this.SP_w3Skill13Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill13Button.TabIndex = 28;
            this.SP_w3Skill13Button.Tag = "12";
            this.SP_w3Skill13Button.UseVisualStyleBackColor = false;
            this.SP_w3Skill13Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill14Button
            // 
            this.SP_w3Skill14Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w3Skill14Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w3Skill14Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill14Button.Location = new System.Drawing.Point(174, 4);
            this.SP_w3Skill14Button.Name = "SP_w3Skill14Button";
            this.SP_w3Skill14Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill14Button.TabIndex = 29;
            this.SP_w3Skill14Button.Tag = "13";
            this.SP_w3Skill14Button.UseVisualStyleBackColor = false;
            this.SP_w3Skill14Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill15Button
            // 
            this.SP_w3Skill15Button.BackColor = System.Drawing.Color.Transparent;
            this.SP_w3Skill15Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SP_w3Skill15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill15Button.Location = new System.Drawing.Point(206, 4);
            this.SP_w3Skill15Button.Name = "SP_w3Skill15Button";
            this.SP_w3Skill15Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill15Button.TabIndex = 30;
            this.SP_w3Skill15Button.Tag = "14";
            this.SP_w3Skill15Button.UseVisualStyleBackColor = false;
            this.SP_w3Skill15Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_wave3LoopCheckBox
            // 
            this.SP_wave3LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SP_wave3LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_wave3LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.SP_wave3LoopCheckBox.Name = "SP_wave3LoopCheckBox";
            this.SP_wave3LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.SP_wave3LoopCheckBox.TabIndex = 24;
            this.SP_wave3LoopCheckBox.Text = "Loop";
            this.SP_wave3LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SP_wave3LoopCheckBox.UseVisualStyleBackColor = true;
            this.SP_wave3LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // SP_w3Skill10Button
            // 
            this.SP_w3Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill10Button.Location = new System.Drawing.Point(206, 56);
            this.SP_w3Skill10Button.Name = "SP_w3Skill10Button";
            this.SP_w3Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill10Button.TabIndex = 10;
            this.SP_w3Skill10Button.Tag = "9";
            this.SP_w3Skill10Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill09Button
            // 
            this.SP_w3Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill09Button.Location = new System.Drawing.Point(174, 56);
            this.SP_w3Skill09Button.Name = "SP_w3Skill09Button";
            this.SP_w3Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill09Button.TabIndex = 9;
            this.SP_w3Skill09Button.Tag = "8";
            this.SP_w3Skill09Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill08Button
            // 
            this.SP_w3Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill08Button.Location = new System.Drawing.Point(142, 56);
            this.SP_w3Skill08Button.Name = "SP_w3Skill08Button";
            this.SP_w3Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill08Button.TabIndex = 8;
            this.SP_w3Skill08Button.Tag = "7";
            this.SP_w3Skill08Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill07Button
            // 
            this.SP_w3Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill07Button.Location = new System.Drawing.Point(110, 56);
            this.SP_w3Skill07Button.Name = "SP_w3Skill07Button";
            this.SP_w3Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill07Button.TabIndex = 7;
            this.SP_w3Skill07Button.Tag = "6";
            this.SP_w3Skill07Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill06Button
            // 
            this.SP_w3Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill06Button.Location = new System.Drawing.Point(78, 56);
            this.SP_w3Skill06Button.Name = "SP_w3Skill06Button";
            this.SP_w3Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill06Button.TabIndex = 6;
            this.SP_w3Skill06Button.Tag = "5";
            this.SP_w3Skill06Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill05Button
            // 
            this.SP_w3Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill05Button.Location = new System.Drawing.Point(206, 32);
            this.SP_w3Skill05Button.Name = "SP_w3Skill05Button";
            this.SP_w3Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill05Button.TabIndex = 5;
            this.SP_w3Skill05Button.Tag = "4";
            this.SP_w3Skill05Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill04Button
            // 
            this.SP_w3Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill04Button.Location = new System.Drawing.Point(174, 32);
            this.SP_w3Skill04Button.Name = "SP_w3Skill04Button";
            this.SP_w3Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill04Button.TabIndex = 4;
            this.SP_w3Skill04Button.Tag = "3";
            this.SP_w3Skill04Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill03Button
            // 
            this.SP_w3Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill03Button.Location = new System.Drawing.Point(142, 32);
            this.SP_w3Skill03Button.Name = "SP_w3Skill03Button";
            this.SP_w3Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill03Button.TabIndex = 3;
            this.SP_w3Skill03Button.Tag = "2";
            this.SP_w3Skill03Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w3Skill02Button
            // 
            this.SP_w3Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill02Button.Location = new System.Drawing.Point(110, 32);
            this.SP_w3Skill02Button.Name = "SP_w3Skill02Button";
            this.SP_w3Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill02Button.TabIndex = 2;
            this.SP_w3Skill02Button.Tag = "1";
            this.SP_w3Skill02Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_wave3Label
            // 
            this.SP_wave3Label.Location = new System.Drawing.Point(6, 7);
            this.SP_wave3Label.Name = "SP_wave3Label";
            this.SP_wave3Label.Size = new System.Drawing.Size(60, 13);
            this.SP_wave3Label.TabIndex = 0;
            this.SP_wave3Label.Text = "Wave 3";
            // 
            // SP_w3Skill01Button
            // 
            this.SP_w3Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w3Skill01Button.Location = new System.Drawing.Point(78, 32);
            this.SP_w3Skill01Button.Name = "SP_w3Skill01Button";
            this.SP_w3Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w3Skill01Button.TabIndex = 1;
            this.SP_w3Skill01Button.Tag = "0";
            this.SP_w3Skill01Button.UseVisualStyleBackColor = true;
            this.SP_w3Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_bothSkillRadio
            // 
            this.SP_bothSkillRadio.AutoSize = true;
            this.SP_bothSkillRadio.Location = new System.Drawing.Point(186, 24);
            this.SP_bothSkillRadio.Name = "SP_bothSkillRadio";
            this.SP_bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.SP_bothSkillRadio.TabIndex = 7;
            this.SP_bothSkillRadio.Tag = "2";
            this.SP_bothSkillRadio.Text = "Both";
            this.SP_bothSkillRadio.UseVisualStyleBackColor = true;
            this.SP_bothSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // SP_wave2Panel
            // 
            this.SP_wave2Panel.Controls.Add(this.SP_wave2LoopCheckBox);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill10Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill09Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill08Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill07Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill06Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill05Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill04Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill03Button);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill02Button);
            this.SP_wave2Panel.Controls.Add(this.SP_wave2Label);
            this.SP_wave2Panel.Controls.Add(this.SP_w2Skill01Button);
            this.SP_wave2Panel.Location = new System.Drawing.Point(6, 109);
            this.SP_wave2Panel.Name = "SP_wave2Panel";
            this.SP_wave2Panel.Size = new System.Drawing.Size(241, 51);
            this.SP_wave2Panel.TabIndex = 9;
            this.SP_wave2Panel.Tag = "8";
            // 
            // SP_wave2LoopCheckBox
            // 
            this.SP_wave2LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SP_wave2LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_wave2LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.SP_wave2LoopCheckBox.Name = "SP_wave2LoopCheckBox";
            this.SP_wave2LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.SP_wave2LoopCheckBox.TabIndex = 12;
            this.SP_wave2LoopCheckBox.Text = "Loop";
            this.SP_wave2LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SP_wave2LoopCheckBox.UseVisualStyleBackColor = true;
            this.SP_wave2LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // SP_w2Skill10Button
            // 
            this.SP_w2Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill10Button.Location = new System.Drawing.Point(205, 26);
            this.SP_w2Skill10Button.Name = "SP_w2Skill10Button";
            this.SP_w2Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill10Button.TabIndex = 10;
            this.SP_w2Skill10Button.Tag = "9";
            this.SP_w2Skill10Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill09Button
            // 
            this.SP_w2Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill09Button.Location = new System.Drawing.Point(173, 26);
            this.SP_w2Skill09Button.Name = "SP_w2Skill09Button";
            this.SP_w2Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill09Button.TabIndex = 9;
            this.SP_w2Skill09Button.Tag = "8";
            this.SP_w2Skill09Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill08Button
            // 
            this.SP_w2Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill08Button.Location = new System.Drawing.Point(141, 26);
            this.SP_w2Skill08Button.Name = "SP_w2Skill08Button";
            this.SP_w2Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill08Button.TabIndex = 8;
            this.SP_w2Skill08Button.Tag = "7";
            this.SP_w2Skill08Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill07Button
            // 
            this.SP_w2Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill07Button.Location = new System.Drawing.Point(109, 26);
            this.SP_w2Skill07Button.Name = "SP_w2Skill07Button";
            this.SP_w2Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill07Button.TabIndex = 7;
            this.SP_w2Skill07Button.Tag = "6";
            this.SP_w2Skill07Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill06Button
            // 
            this.SP_w2Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill06Button.Location = new System.Drawing.Point(77, 26);
            this.SP_w2Skill06Button.Name = "SP_w2Skill06Button";
            this.SP_w2Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill06Button.TabIndex = 6;
            this.SP_w2Skill06Button.Tag = "5";
            this.SP_w2Skill06Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill05Button
            // 
            this.SP_w2Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill05Button.Location = new System.Drawing.Point(205, 2);
            this.SP_w2Skill05Button.Name = "SP_w2Skill05Button";
            this.SP_w2Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill05Button.TabIndex = 5;
            this.SP_w2Skill05Button.Tag = "4";
            this.SP_w2Skill05Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill04Button
            // 
            this.SP_w2Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill04Button.Location = new System.Drawing.Point(173, 2);
            this.SP_w2Skill04Button.Name = "SP_w2Skill04Button";
            this.SP_w2Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill04Button.TabIndex = 4;
            this.SP_w2Skill04Button.Tag = "3";
            this.SP_w2Skill04Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill03Button
            // 
            this.SP_w2Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill03Button.Location = new System.Drawing.Point(141, 2);
            this.SP_w2Skill03Button.Name = "SP_w2Skill03Button";
            this.SP_w2Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill03Button.TabIndex = 3;
            this.SP_w2Skill03Button.Tag = "2";
            this.SP_w2Skill03Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w2Skill02Button
            // 
            this.SP_w2Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill02Button.Location = new System.Drawing.Point(109, 2);
            this.SP_w2Skill02Button.Name = "SP_w2Skill02Button";
            this.SP_w2Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill02Button.TabIndex = 2;
            this.SP_w2Skill02Button.Tag = "1";
            this.SP_w2Skill02Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_wave2Label
            // 
            this.SP_wave2Label.Location = new System.Drawing.Point(6, 7);
            this.SP_wave2Label.Name = "SP_wave2Label";
            this.SP_wave2Label.Size = new System.Drawing.Size(60, 13);
            this.SP_wave2Label.TabIndex = 0;
            this.SP_wave2Label.Text = "Wave 2";
            // 
            // SP_w2Skill01Button
            // 
            this.SP_w2Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w2Skill01Button.Location = new System.Drawing.Point(77, 2);
            this.SP_w2Skill01Button.Name = "SP_w2Skill01Button";
            this.SP_w2Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w2Skill01Button.TabIndex = 1;
            this.SP_w2Skill01Button.Tag = "0";
            this.SP_w2Skill01Button.UseVisualStyleBackColor = true;
            this.SP_w2Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_manualSkillRadio
            // 
            this.SP_manualSkillRadio.AutoSize = true;
            this.SP_manualSkillRadio.Location = new System.Drawing.Point(94, 24);
            this.SP_manualSkillRadio.Name = "SP_manualSkillRadio";
            this.SP_manualSkillRadio.Size = new System.Drawing.Size(82, 17);
            this.SP_manualSkillRadio.TabIndex = 6;
            this.SP_manualSkillRadio.Tag = "1";
            this.SP_manualSkillRadio.Text = "Manual Skill";
            this.SP_manualSkillRadio.UseVisualStyleBackColor = true;
            this.SP_manualSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // SP_autoSkillRadio
            // 
            this.SP_autoSkillRadio.AutoSize = true;
            this.SP_autoSkillRadio.Checked = true;
            this.SP_autoSkillRadio.Location = new System.Drawing.Point(15, 24);
            this.SP_autoSkillRadio.Name = "SP_autoSkillRadio";
            this.SP_autoSkillRadio.Size = new System.Drawing.Size(69, 17);
            this.SP_autoSkillRadio.TabIndex = 5;
            this.SP_autoSkillRadio.TabStop = true;
            this.SP_autoSkillRadio.Tag = "0";
            this.SP_autoSkillRadio.Text = "Auto Skill";
            this.SP_autoSkillRadio.UseVisualStyleBackColor = true;
            this.SP_autoSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // SP_wave1Panel
            // 
            this.SP_wave1Panel.Controls.Add(this.SP_wave1LoopCheckBox);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill10Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill09Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill08Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill07Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill06Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill05Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill04Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill03Button);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill02Button);
            this.SP_wave1Panel.Controls.Add(this.SP_wave1Label);
            this.SP_wave1Panel.Controls.Add(this.SP_w1Skill01Button);
            this.SP_wave1Panel.Location = new System.Drawing.Point(6, 52);
            this.SP_wave1Panel.Name = "SP_wave1Panel";
            this.SP_wave1Panel.Size = new System.Drawing.Size(241, 51);
            this.SP_wave1Panel.TabIndex = 8;
            this.SP_wave1Panel.Tag = "7";
            // 
            // SP_wave1LoopCheckBox
            // 
            this.SP_wave1LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SP_wave1LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_wave1LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.SP_wave1LoopCheckBox.Name = "SP_wave1LoopCheckBox";
            this.SP_wave1LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.SP_wave1LoopCheckBox.TabIndex = 12;
            this.SP_wave1LoopCheckBox.Text = "Loop";
            this.SP_wave1LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SP_wave1LoopCheckBox.UseVisualStyleBackColor = true;
            this.SP_wave1LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // SP_w1Skill10Button
            // 
            this.SP_w1Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill10Button.Location = new System.Drawing.Point(205, 26);
            this.SP_w1Skill10Button.Name = "SP_w1Skill10Button";
            this.SP_w1Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill10Button.TabIndex = 10;
            this.SP_w1Skill10Button.Tag = "9";
            this.SP_w1Skill10Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill09Button
            // 
            this.SP_w1Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill09Button.Location = new System.Drawing.Point(173, 26);
            this.SP_w1Skill09Button.Name = "SP_w1Skill09Button";
            this.SP_w1Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill09Button.TabIndex = 9;
            this.SP_w1Skill09Button.Tag = "8";
            this.SP_w1Skill09Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill08Button
            // 
            this.SP_w1Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill08Button.Location = new System.Drawing.Point(141, 26);
            this.SP_w1Skill08Button.Name = "SP_w1Skill08Button";
            this.SP_w1Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill08Button.TabIndex = 8;
            this.SP_w1Skill08Button.Tag = "7";
            this.SP_w1Skill08Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill07Button
            // 
            this.SP_w1Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill07Button.Location = new System.Drawing.Point(109, 26);
            this.SP_w1Skill07Button.Name = "SP_w1Skill07Button";
            this.SP_w1Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill07Button.TabIndex = 7;
            this.SP_w1Skill07Button.Tag = "6";
            this.SP_w1Skill07Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill06Button
            // 
            this.SP_w1Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill06Button.Location = new System.Drawing.Point(77, 26);
            this.SP_w1Skill06Button.Name = "SP_w1Skill06Button";
            this.SP_w1Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill06Button.TabIndex = 6;
            this.SP_w1Skill06Button.Tag = "5";
            this.SP_w1Skill06Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill05Button
            // 
            this.SP_w1Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill05Button.Location = new System.Drawing.Point(205, 2);
            this.SP_w1Skill05Button.Name = "SP_w1Skill05Button";
            this.SP_w1Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill05Button.TabIndex = 5;
            this.SP_w1Skill05Button.Tag = "4";
            this.SP_w1Skill05Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill04Button
            // 
            this.SP_w1Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill04Button.Location = new System.Drawing.Point(173, 2);
            this.SP_w1Skill04Button.Name = "SP_w1Skill04Button";
            this.SP_w1Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill04Button.TabIndex = 4;
            this.SP_w1Skill04Button.Tag = "3";
            this.SP_w1Skill04Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill03Button
            // 
            this.SP_w1Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill03Button.Location = new System.Drawing.Point(141, 2);
            this.SP_w1Skill03Button.Name = "SP_w1Skill03Button";
            this.SP_w1Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill03Button.TabIndex = 3;
            this.SP_w1Skill03Button.Tag = "2";
            this.SP_w1Skill03Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_w1Skill02Button
            // 
            this.SP_w1Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill02Button.Location = new System.Drawing.Point(109, 2);
            this.SP_w1Skill02Button.Name = "SP_w1Skill02Button";
            this.SP_w1Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill02Button.TabIndex = 2;
            this.SP_w1Skill02Button.Tag = "1";
            this.SP_w1Skill02Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_wave1Label
            // 
            this.SP_wave1Label.Location = new System.Drawing.Point(6, 7);
            this.SP_wave1Label.Name = "SP_wave1Label";
            this.SP_wave1Label.Size = new System.Drawing.Size(60, 13);
            this.SP_wave1Label.TabIndex = 0;
            this.SP_wave1Label.Text = "Wave 1";
            // 
            // SP_w1Skill01Button
            // 
            this.SP_w1Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SP_w1Skill01Button.Location = new System.Drawing.Point(77, 2);
            this.SP_w1Skill01Button.Name = "SP_w1Skill01Button";
            this.SP_w1Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.SP_w1Skill01Button.TabIndex = 1;
            this.SP_w1Skill01Button.Tag = "0";
            this.SP_w1Skill01Button.UseVisualStyleBackColor = true;
            this.SP_w1Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // SP_enableCheckBox
            // 
            this.SP_enableCheckBox.AutoSize = true;
            this.SP_enableCheckBox.Checked = true;
            this.SP_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SP_enableCheckBox.Location = new System.Drawing.Point(9, 7);
            this.SP_enableCheckBox.Name = "SP_enableCheckBox";
            this.SP_enableCheckBox.Size = new System.Drawing.Size(144, 17);
            this.SP_enableCheckBox.TabIndex = 25;
            this.SP_enableCheckBox.Tag = "4";
            this.SP_enableCheckBox.Text = "Enable Special Dungeon";
            this.SP_enableCheckBox.UseVisualStyleBackColor = true;
            this.SP_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // arenaTab
            // 
            this.arenaTab.BackColor = System.Drawing.Color.Transparent;
            this.arenaTab.Controls.Add(this.AR_limitLabel);
            this.arenaTab.Controls.Add(this.AR_useRubyLabel);
            this.arenaTab.Controls.Add(this.AR_limitNumericBox);
            this.arenaTab.Controls.Add(this.AR_useRubyNumericBox);
            this.arenaTab.Controls.Add(this.AR_limitCheckBox);
            this.arenaTab.Controls.Add(this.AR_useRubyCheckBox);
            this.arenaTab.Controls.Add(this.AR_mainPanel);
            this.arenaTab.Controls.Add(this.AR_enableCheckBox);
            this.arenaTab.Location = new System.Drawing.Point(4, 22);
            this.arenaTab.Name = "arenaTab";
            this.arenaTab.Size = new System.Drawing.Size(488, 309);
            this.arenaTab.TabIndex = 3;
            this.arenaTab.Text = "Arena";
            // 
            // AR_limitLabel
            // 
            this.AR_limitLabel.AutoSize = true;
            this.AR_limitLabel.Location = new System.Drawing.Point(407, 8);
            this.AR_limitLabel.Name = "AR_limitLabel";
            this.AR_limitLabel.Size = new System.Drawing.Size(70, 13);
            this.AR_limitLabel.TabIndex = 22;
            this.AR_limitLabel.Text = "times per visit";
            // 
            // AR_useRubyLabel
            // 
            this.AR_useRubyLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AR_useRubyLabel.AutoSize = true;
            this.AR_useRubyLabel.Location = new System.Drawing.Point(165, 32);
            this.AR_useRubyLabel.Name = "AR_useRubyLabel";
            this.AR_useRubyLabel.Size = new System.Drawing.Size(31, 13);
            this.AR_useRubyLabel.TabIndex = 12;
            this.AR_useRubyLabel.Text = "times";
            // 
            // AR_limitNumericBox
            // 
            this.AR_limitNumericBox.Location = new System.Drawing.Point(365, 5);
            this.AR_limitNumericBox.Name = "AR_limitNumericBox";
            this.AR_limitNumericBox.Size = new System.Drawing.Size(37, 20);
            this.AR_limitNumericBox.TabIndex = 21;
            this.AR_limitNumericBox.Tag = "2";
            this.AR_limitNumericBox.ValueChanged += new System.EventHandler(this.limitNumericBox_ValueChanged);
            // 
            // AR_useRubyNumericBox
            // 
            this.AR_useRubyNumericBox.Location = new System.Drawing.Point(124, 29);
            this.AR_useRubyNumericBox.Name = "AR_useRubyNumericBox";
            this.AR_useRubyNumericBox.Size = new System.Drawing.Size(37, 20);
            this.AR_useRubyNumericBox.TabIndex = 11;
            this.AR_useRubyNumericBox.ValueChanged += new System.EventHandler(this.AR_useRubyNumericBox_ValueChanged);
            // 
            // AR_limitCheckBox
            // 
            this.AR_limitCheckBox.Location = new System.Drawing.Point(315, 7);
            this.AR_limitCheckBox.Name = "AR_limitCheckBox";
            this.AR_limitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.AR_limitCheckBox.TabIndex = 20;
            this.AR_limitCheckBox.Tag = "2";
            this.AR_limitCheckBox.Text = "Limit";
            this.AR_limitCheckBox.UseVisualStyleBackColor = true;
            this.AR_limitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // AR_useRubyCheckBox
            // 
            this.AR_useRubyCheckBox.AutoSize = true;
            this.AR_useRubyCheckBox.Location = new System.Drawing.Point(14, 31);
            this.AR_useRubyCheckBox.Name = "AR_useRubyCheckBox";
            this.AR_useRubyCheckBox.Size = new System.Drawing.Size(107, 17);
            this.AR_useRubyCheckBox.TabIndex = 0;
            this.AR_useRubyCheckBox.Text = "Enter using Ruby";
            this.AR_useRubyCheckBox.UseVisualStyleBackColor = true;
            this.AR_useRubyCheckBox.CheckedChanged += new System.EventHandler(this.AR_useRubyCheckBox_CheckedChanged);
            // 
            // AR_mainPanel
            // 
            this.AR_mainPanel.Controls.Add(this.AR_skillGroupBox);
            this.AR_mainPanel.Location = new System.Drawing.Point(0, 61);
            this.AR_mainPanel.Name = "AR_mainPanel";
            this.AR_mainPanel.Size = new System.Drawing.Size(487, 247);
            this.AR_mainPanel.TabIndex = 15;
            // 
            // AR_skillGroupBox
            // 
            this.AR_skillGroupBox.Controls.Add(this.AR_masteryComboBox);
            this.AR_skillGroupBox.Controls.Add(this.AR_masteryLabel);
            this.AR_skillGroupBox.Location = new System.Drawing.Point(230, 80);
            this.AR_skillGroupBox.Name = "AR_skillGroupBox";
            this.AR_skillGroupBox.Size = new System.Drawing.Size(254, 43);
            this.AR_skillGroupBox.TabIndex = 26;
            this.AR_skillGroupBox.TabStop = false;
            this.AR_skillGroupBox.Tag = "2";
            this.AR_skillGroupBox.Text = "Skill Management";
            this.AR_skillGroupBox.Visible = false;
            // 
            // AR_masteryComboBox
            // 
            this.AR_masteryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AR_masteryComboBox.Enabled = false;
            this.AR_masteryComboBox.FormattingEnabled = true;
            this.AR_masteryComboBox.Items.AddRange(new object[] {
            "--",
            "1",
            "2",
            "3"});
            this.AR_masteryComboBox.Location = new System.Drawing.Point(197, 14);
            this.AR_masteryComboBox.Name = "AR_masteryComboBox";
            this.AR_masteryComboBox.Size = new System.Drawing.Size(46, 21);
            this.AR_masteryComboBox.TabIndex = 18;
            this.AR_masteryComboBox.Tag = "2";
            this.AR_masteryComboBox.SelectedIndexChanged += new System.EventHandler(this.masteryComboBox_SelectedIndexChanged);
            // 
            // AR_masteryLabel
            // 
            this.AR_masteryLabel.AutoSize = true;
            this.AR_masteryLabel.Enabled = false;
            this.AR_masteryLabel.Location = new System.Drawing.Point(145, 18);
            this.AR_masteryLabel.Name = "AR_masteryLabel";
            this.AR_masteryLabel.Size = new System.Drawing.Size(44, 13);
            this.AR_masteryLabel.TabIndex = 17;
            this.AR_masteryLabel.Text = "Mastery";
            // 
            // AR_enableCheckBox
            // 
            this.AR_enableCheckBox.AutoSize = true;
            this.AR_enableCheckBox.Checked = true;
            this.AR_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AR_enableCheckBox.Location = new System.Drawing.Point(9, 7);
            this.AR_enableCheckBox.Name = "AR_enableCheckBox";
            this.AR_enableCheckBox.Size = new System.Drawing.Size(90, 17);
            this.AR_enableCheckBox.TabIndex = 1;
            this.AR_enableCheckBox.Tag = "2";
            this.AR_enableCheckBox.Text = "Enable Arena";
            this.AR_enableCheckBox.UseVisualStyleBackColor = true;
            this.AR_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // raidTab
            // 
            this.raidTab.BackColor = System.Drawing.Color.Transparent;
            this.raidTab.Controls.Add(this.RD_RoundNumericUpDown);
            this.raidTab.Controls.Add(this.RD_DragonLimit_lbl);
            this.raidTab.Controls.Add(this.RD_mainPanel);
            this.raidTab.Controls.Add(this.RD_enableCheckBox);
            this.raidTab.Controls.Add(this.RD_DragonLimitCheckBox);
            this.raidTab.Location = new System.Drawing.Point(4, 22);
            this.raidTab.Name = "raidTab";
            this.raidTab.Size = new System.Drawing.Size(488, 309);
            this.raidTab.TabIndex = 4;
            this.raidTab.Text = "Raid";
            // 
            // RD_RoundNumericUpDown
            // 
            this.RD_RoundNumericUpDown.Location = new System.Drawing.Point(360, 5);
            this.RD_RoundNumericUpDown.Name = "RD_RoundNumericUpDown";
            this.RD_RoundNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.RD_RoundNumericUpDown.TabIndex = 36;
            this.RD_RoundNumericUpDown.Tag = "6";
            this.RD_RoundNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_RoundNumericUpDown.ValueChanged += new System.EventHandler(this.RD_RoundNumericUpDown_ValueChanged);
            // 
            // RD_DragonLimit_lbl
            // 
            this.RD_DragonLimit_lbl.AutoSize = true;
            this.RD_DragonLimit_lbl.Location = new System.Drawing.Point(399, 8);
            this.RD_DragonLimit_lbl.Name = "RD_DragonLimit_lbl";
            this.RD_DragonLimit_lbl.Size = new System.Drawing.Size(85, 13);
            this.RD_DragonLimit_lbl.TabIndex = 28;
            this.RD_DragonLimit_lbl.Text = "times per dragon";
            // 
            // RD_mainPanel
            // 
            this.RD_mainPanel.Controls.Add(this.groupBox1);
            this.RD_mainPanel.Controls.Add(this.RD_OwnerDragon);
            this.RD_mainPanel.Controls.Add(this.RD_masteryComboBox);
            this.RD_mainPanel.Controls.Add(this.label2);
            this.RD_mainPanel.Controls.Add(this.ARD_enableCheckBox);
            this.RD_mainPanel.Controls.Add(this.RD_StopOnDragonFound_Checkbox);
            this.RD_mainPanel.Controls.Add(this.RD_skillGroupBox);
            this.RD_mainPanel.Location = new System.Drawing.Point(0, 31);
            this.RD_mainPanel.Name = "RD_mainPanel";
            this.RD_mainPanel.Size = new System.Drawing.Size(487, 255);
            this.RD_mainPanel.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RD_DragonLVLimit);
            this.groupBox1.Controls.Add(this.RD_DragonHPLimit);
            this.groupBox1.Controls.Add(this.RD_LevelCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RD_DragonLV);
            this.groupBox1.Controls.Add(this.RD_DragonHP);
            this.groupBox1.Location = new System.Drawing.Point(27, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 82);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dragon Option";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(119, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(120, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "-";
            // 
            // RD_DragonLVLimit
            // 
            this.RD_DragonLVLimit.Location = new System.Drawing.Point(141, 24);
            this.RD_DragonLVLimit.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.RD_DragonLVLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonLVLimit.Name = "RD_DragonLVLimit";
            this.RD_DragonLVLimit.Size = new System.Drawing.Size(38, 20);
            this.RD_DragonLVLimit.TabIndex = 39;
            this.RD_DragonLVLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonLVLimit.ValueChanged += new System.EventHandler(this.RD_DragonLVLimit_ValueChanged);
            // 
            // RD_DragonHPLimit
            // 
            this.RD_DragonHPLimit.Location = new System.Drawing.Point(141, 51);
            this.RD_DragonHPLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonHPLimit.Name = "RD_DragonHPLimit";
            this.RD_DragonHPLimit.Size = new System.Drawing.Size(38, 20);
            this.RD_DragonHPLimit.TabIndex = 38;
            this.RD_DragonHPLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonHPLimit.ValueChanged += new System.EventHandler(this.RD_DragonHPLimit_ValueChanged);
            // 
            // RD_LevelCheckBox
            // 
            this.RD_LevelCheckBox.AutoSize = true;
            this.RD_LevelCheckBox.Location = new System.Drawing.Point(6, 23);
            this.RD_LevelCheckBox.Name = "RD_LevelCheckBox";
            this.RD_LevelCheckBox.Size = new System.Drawing.Size(67, 17);
            this.RD_LevelCheckBox.TabIndex = 34;
            this.RD_LevelCheckBox.Text = "Level >=";
            this.RD_LevelCheckBox.UseVisualStyleBackColor = true;
            this.RD_LevelCheckBox.CheckedChanged += new System.EventHandler(this.RD_LevelCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "% HP >=";
            // 
            // RD_DragonLV
            // 
            this.RD_DragonLV.Location = new System.Drawing.Point(75, 24);
            this.RD_DragonLV.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.RD_DragonLV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonLV.Name = "RD_DragonLV";
            this.RD_DragonLV.Size = new System.Drawing.Size(38, 20);
            this.RD_DragonLV.TabIndex = 35;
            this.RD_DragonLV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonLV.ValueChanged += new System.EventHandler(this.RD_DragonLV_ValueChanged);
            // 
            // RD_DragonHP
            // 
            this.RD_DragonHP.Location = new System.Drawing.Point(75, 51);
            this.RD_DragonHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonHP.Name = "RD_DragonHP";
            this.RD_DragonHP.Size = new System.Drawing.Size(38, 20);
            this.RD_DragonHP.TabIndex = 36;
            this.RD_DragonHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RD_DragonHP.ValueChanged += new System.EventHandler(this.RD_DragonHP_ValueChanged);
            // 
            // RD_OwnerDragon
            // 
            this.RD_OwnerDragon.AutoSize = true;
            this.RD_OwnerDragon.Location = new System.Drawing.Point(23, 50);
            this.RD_OwnerDragon.Name = "RD_OwnerDragon";
            this.RD_OwnerDragon.Size = new System.Drawing.Size(169, 17);
            this.RD_OwnerDragon.TabIndex = 33;
            this.RD_OwnerDragon.Text = "Fight My Dragon When Found";
            this.RD_OwnerDragon.UseVisualStyleBackColor = true;
            this.RD_OwnerDragon.CheckedChanged += new System.EventHandler(this.RD_OwnerDragon_CheckedChanged);
            // 
            // RD_masteryComboBox
            // 
            this.RD_masteryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RD_masteryComboBox.Enabled = false;
            this.RD_masteryComboBox.FormattingEnabled = true;
            this.RD_masteryComboBox.Items.AddRange(new object[] {
            "--",
            "1",
            "2",
            "3"});
            this.RD_masteryComboBox.Location = new System.Drawing.Point(402, 211);
            this.RD_masteryComboBox.Name = "RD_masteryComboBox";
            this.RD_masteryComboBox.Size = new System.Drawing.Size(46, 21);
            this.RD_masteryComboBox.TabIndex = 16;
            this.RD_masteryComboBox.Tag = "3";
            this.RD_masteryComboBox.Visible = false;
            this.RD_masteryComboBox.SelectedIndexChanged += new System.EventHandler(this.masteryComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(350, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mastery";
            this.label2.Visible = false;
            // 
            // ARD_enableCheckBox
            // 
            this.ARD_enableCheckBox.AutoSize = true;
            this.ARD_enableCheckBox.Location = new System.Drawing.Point(23, 4);
            this.ARD_enableCheckBox.Name = "ARD_enableCheckBox";
            this.ARD_enableCheckBox.Size = new System.Drawing.Size(120, 17);
            this.ARD_enableCheckBox.TabIndex = 31;
            this.ARD_enableCheckBox.Text = "Enable Raid Awake";
            this.ARD_enableCheckBox.UseVisualStyleBackColor = true;
            this.ARD_enableCheckBox.CheckedChanged += new System.EventHandler(this.ARD_enableCheckBox_CheckedChanged);
            // 
            // RD_StopOnDragonFound_Checkbox
            // 
            this.RD_StopOnDragonFound_Checkbox.AutoSize = true;
            this.RD_StopOnDragonFound_Checkbox.Location = new System.Drawing.Point(23, 27);
            this.RD_StopOnDragonFound_Checkbox.Name = "RD_StopOnDragonFound_Checkbox";
            this.RD_StopOnDragonFound_Checkbox.Size = new System.Drawing.Size(144, 17);
            this.RD_StopOnDragonFound_Checkbox.TabIndex = 29;
            this.RD_StopOnDragonFound_Checkbox.Text = "Pause On Dragon Found";
            this.RD_StopOnDragonFound_Checkbox.UseVisualStyleBackColor = true;
            this.RD_StopOnDragonFound_Checkbox.CheckedChanged += new System.EventHandler(this.RD_StopOnDragonFound_Checkbox_CheckedChanged);
            // 
            // RD_skillGroupBox
            // 
            this.RD_skillGroupBox.Controls.Add(this.RD_bothSkillRadio);
            this.RD_skillGroupBox.Controls.Add(this.RD_team2Panel);
            this.RD_skillGroupBox.Controls.Add(this.RD_manualSkillRadio);
            this.RD_skillGroupBox.Controls.Add(this.RD_autoSkillRadio);
            this.RD_skillGroupBox.Controls.Add(this.RD_team1Panel);
            this.RD_skillGroupBox.Location = new System.Drawing.Point(225, 3);
            this.RD_skillGroupBox.Name = "RD_skillGroupBox";
            this.RD_skillGroupBox.Size = new System.Drawing.Size(254, 189);
            this.RD_skillGroupBox.TabIndex = 25;
            this.RD_skillGroupBox.TabStop = false;
            this.RD_skillGroupBox.Tag = "2";
            this.RD_skillGroupBox.Text = "Skill Management";
            // 
            // RD_bothSkillRadio
            // 
            this.RD_bothSkillRadio.AutoSize = true;
            this.RD_bothSkillRadio.Location = new System.Drawing.Point(189, 24);
            this.RD_bothSkillRadio.Name = "RD_bothSkillRadio";
            this.RD_bothSkillRadio.Size = new System.Drawing.Size(47, 17);
            this.RD_bothSkillRadio.TabIndex = 7;
            this.RD_bothSkillRadio.Tag = "2";
            this.RD_bothSkillRadio.Text = "Both";
            this.RD_bothSkillRadio.UseVisualStyleBackColor = true;
            this.RD_bothSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // RD_team2Panel
            // 
            this.RD_team2Panel.Controls.Add(this.RD_team2LoopCheckBox);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill10Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill09Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill08Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill07Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill06Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill05Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill04Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill03Button);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill02Button);
            this.RD_team2Panel.Controls.Add(this.RD_team2Label);
            this.RD_team2Panel.Controls.Add(this.RD_t2Skill01Button);
            this.RD_team2Panel.Location = new System.Drawing.Point(9, 109);
            this.RD_team2Panel.Name = "RD_team2Panel";
            this.RD_team2Panel.Size = new System.Drawing.Size(241, 51);
            this.RD_team2Panel.TabIndex = 9;
            this.RD_team2Panel.Tag = "6";
            // 
            // RD_team2LoopCheckBox
            // 
            this.RD_team2LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RD_team2LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_team2LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.RD_team2LoopCheckBox.Name = "RD_team2LoopCheckBox";
            this.RD_team2LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.RD_team2LoopCheckBox.TabIndex = 12;
            this.RD_team2LoopCheckBox.Text = "Loop";
            this.RD_team2LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RD_team2LoopCheckBox.UseVisualStyleBackColor = true;
            this.RD_team2LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // RD_t2Skill10Button
            // 
            this.RD_t2Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill10Button.Location = new System.Drawing.Point(205, 26);
            this.RD_t2Skill10Button.Name = "RD_t2Skill10Button";
            this.RD_t2Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill10Button.TabIndex = 10;
            this.RD_t2Skill10Button.Tag = "9";
            this.RD_t2Skill10Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill09Button
            // 
            this.RD_t2Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill09Button.Location = new System.Drawing.Point(173, 26);
            this.RD_t2Skill09Button.Name = "RD_t2Skill09Button";
            this.RD_t2Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill09Button.TabIndex = 9;
            this.RD_t2Skill09Button.Tag = "8";
            this.RD_t2Skill09Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill08Button
            // 
            this.RD_t2Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill08Button.Location = new System.Drawing.Point(141, 26);
            this.RD_t2Skill08Button.Name = "RD_t2Skill08Button";
            this.RD_t2Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill08Button.TabIndex = 8;
            this.RD_t2Skill08Button.Tag = "7";
            this.RD_t2Skill08Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill07Button
            // 
            this.RD_t2Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill07Button.Location = new System.Drawing.Point(109, 26);
            this.RD_t2Skill07Button.Name = "RD_t2Skill07Button";
            this.RD_t2Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill07Button.TabIndex = 7;
            this.RD_t2Skill07Button.Tag = "6";
            this.RD_t2Skill07Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill06Button
            // 
            this.RD_t2Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill06Button.Location = new System.Drawing.Point(77, 26);
            this.RD_t2Skill06Button.Name = "RD_t2Skill06Button";
            this.RD_t2Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill06Button.TabIndex = 6;
            this.RD_t2Skill06Button.Tag = "5";
            this.RD_t2Skill06Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill05Button
            // 
            this.RD_t2Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill05Button.Location = new System.Drawing.Point(205, 2);
            this.RD_t2Skill05Button.Name = "RD_t2Skill05Button";
            this.RD_t2Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill05Button.TabIndex = 5;
            this.RD_t2Skill05Button.Tag = "4";
            this.RD_t2Skill05Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill04Button
            // 
            this.RD_t2Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill04Button.Location = new System.Drawing.Point(173, 2);
            this.RD_t2Skill04Button.Name = "RD_t2Skill04Button";
            this.RD_t2Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill04Button.TabIndex = 4;
            this.RD_t2Skill04Button.Tag = "3";
            this.RD_t2Skill04Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill03Button
            // 
            this.RD_t2Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill03Button.Location = new System.Drawing.Point(141, 2);
            this.RD_t2Skill03Button.Name = "RD_t2Skill03Button";
            this.RD_t2Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill03Button.TabIndex = 3;
            this.RD_t2Skill03Button.Tag = "2";
            this.RD_t2Skill03Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t2Skill02Button
            // 
            this.RD_t2Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill02Button.Location = new System.Drawing.Point(109, 2);
            this.RD_t2Skill02Button.Name = "RD_t2Skill02Button";
            this.RD_t2Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill02Button.TabIndex = 2;
            this.RD_t2Skill02Button.Tag = "1";
            this.RD_t2Skill02Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_team2Label
            // 
            this.RD_team2Label.Location = new System.Drawing.Point(6, 7);
            this.RD_team2Label.Name = "RD_team2Label";
            this.RD_team2Label.Size = new System.Drawing.Size(60, 13);
            this.RD_team2Label.TabIndex = 0;
            this.RD_team2Label.Text = "Team 2";
            // 
            // RD_t2Skill01Button
            // 
            this.RD_t2Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t2Skill01Button.Location = new System.Drawing.Point(77, 2);
            this.RD_t2Skill01Button.Name = "RD_t2Skill01Button";
            this.RD_t2Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t2Skill01Button.TabIndex = 1;
            this.RD_t2Skill01Button.Tag = "0";
            this.RD_t2Skill01Button.UseVisualStyleBackColor = true;
            this.RD_t2Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_manualSkillRadio
            // 
            this.RD_manualSkillRadio.AutoSize = true;
            this.RD_manualSkillRadio.Location = new System.Drawing.Point(97, 24);
            this.RD_manualSkillRadio.Name = "RD_manualSkillRadio";
            this.RD_manualSkillRadio.Size = new System.Drawing.Size(82, 17);
            this.RD_manualSkillRadio.TabIndex = 6;
            this.RD_manualSkillRadio.Tag = "1";
            this.RD_manualSkillRadio.Text = "Manual Skill";
            this.RD_manualSkillRadio.UseVisualStyleBackColor = true;
            this.RD_manualSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // RD_autoSkillRadio
            // 
            this.RD_autoSkillRadio.AutoSize = true;
            this.RD_autoSkillRadio.Checked = true;
            this.RD_autoSkillRadio.Location = new System.Drawing.Point(18, 24);
            this.RD_autoSkillRadio.Name = "RD_autoSkillRadio";
            this.RD_autoSkillRadio.Size = new System.Drawing.Size(69, 17);
            this.RD_autoSkillRadio.TabIndex = 5;
            this.RD_autoSkillRadio.TabStop = true;
            this.RD_autoSkillRadio.Tag = "0";
            this.RD_autoSkillRadio.Text = "Auto Skill";
            this.RD_autoSkillRadio.UseVisualStyleBackColor = true;
            this.RD_autoSkillRadio.CheckedChanged += new System.EventHandler(this.skillTypeRadio_CheckedChanged);
            // 
            // RD_team1Panel
            // 
            this.RD_team1Panel.Controls.Add(this.RD_team1LoopCheckBox);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill10Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill09Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill08Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill07Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill06Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill05Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill04Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill03Button);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill02Button);
            this.RD_team1Panel.Controls.Add(this.RD_team1Label);
            this.RD_team1Panel.Controls.Add(this.RD_t1Skill01Button);
            this.RD_team1Panel.Location = new System.Drawing.Point(9, 52);
            this.RD_team1Panel.Name = "RD_team1Panel";
            this.RD_team1Panel.Size = new System.Drawing.Size(241, 51);
            this.RD_team1Panel.TabIndex = 8;
            this.RD_team1Panel.Tag = "5";
            // 
            // RD_team1LoopCheckBox
            // 
            this.RD_team1LoopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RD_team1LoopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_team1LoopCheckBox.Location = new System.Drawing.Point(8, 23);
            this.RD_team1LoopCheckBox.Name = "RD_team1LoopCheckBox";
            this.RD_team1LoopCheckBox.Size = new System.Drawing.Size(40, 20);
            this.RD_team1LoopCheckBox.TabIndex = 12;
            this.RD_team1LoopCheckBox.Text = "Loop";
            this.RD_team1LoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RD_team1LoopCheckBox.UseVisualStyleBackColor = true;
            this.RD_team1LoopCheckBox.CheckedChanged += new System.EventHandler(this.skillLoopCheckBox_CheckedChanged);
            // 
            // RD_t1Skill10Button
            // 
            this.RD_t1Skill10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill10Button.Location = new System.Drawing.Point(205, 26);
            this.RD_t1Skill10Button.Name = "RD_t1Skill10Button";
            this.RD_t1Skill10Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill10Button.TabIndex = 10;
            this.RD_t1Skill10Button.Tag = "9";
            this.RD_t1Skill10Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill10Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill09Button
            // 
            this.RD_t1Skill09Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill09Button.Location = new System.Drawing.Point(173, 26);
            this.RD_t1Skill09Button.Name = "RD_t1Skill09Button";
            this.RD_t1Skill09Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill09Button.TabIndex = 9;
            this.RD_t1Skill09Button.Tag = "8";
            this.RD_t1Skill09Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill09Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill08Button
            // 
            this.RD_t1Skill08Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill08Button.Location = new System.Drawing.Point(141, 26);
            this.RD_t1Skill08Button.Name = "RD_t1Skill08Button";
            this.RD_t1Skill08Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill08Button.TabIndex = 8;
            this.RD_t1Skill08Button.Tag = "7";
            this.RD_t1Skill08Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill08Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill07Button
            // 
            this.RD_t1Skill07Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill07Button.Location = new System.Drawing.Point(109, 26);
            this.RD_t1Skill07Button.Name = "RD_t1Skill07Button";
            this.RD_t1Skill07Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill07Button.TabIndex = 7;
            this.RD_t1Skill07Button.Tag = "6";
            this.RD_t1Skill07Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill07Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill06Button
            // 
            this.RD_t1Skill06Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill06Button.Location = new System.Drawing.Point(77, 26);
            this.RD_t1Skill06Button.Name = "RD_t1Skill06Button";
            this.RD_t1Skill06Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill06Button.TabIndex = 6;
            this.RD_t1Skill06Button.Tag = "5";
            this.RD_t1Skill06Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill06Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill05Button
            // 
            this.RD_t1Skill05Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill05Button.Location = new System.Drawing.Point(205, 2);
            this.RD_t1Skill05Button.Name = "RD_t1Skill05Button";
            this.RD_t1Skill05Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill05Button.TabIndex = 5;
            this.RD_t1Skill05Button.Tag = "4";
            this.RD_t1Skill05Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill05Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill04Button
            // 
            this.RD_t1Skill04Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill04Button.Location = new System.Drawing.Point(173, 2);
            this.RD_t1Skill04Button.Name = "RD_t1Skill04Button";
            this.RD_t1Skill04Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill04Button.TabIndex = 4;
            this.RD_t1Skill04Button.Tag = "3";
            this.RD_t1Skill04Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill04Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill03Button
            // 
            this.RD_t1Skill03Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill03Button.Location = new System.Drawing.Point(141, 2);
            this.RD_t1Skill03Button.Name = "RD_t1Skill03Button";
            this.RD_t1Skill03Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill03Button.TabIndex = 3;
            this.RD_t1Skill03Button.Tag = "2";
            this.RD_t1Skill03Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill03Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_t1Skill02Button
            // 
            this.RD_t1Skill02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill02Button.Location = new System.Drawing.Point(109, 2);
            this.RD_t1Skill02Button.Name = "RD_t1Skill02Button";
            this.RD_t1Skill02Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill02Button.TabIndex = 2;
            this.RD_t1Skill02Button.Tag = "1";
            this.RD_t1Skill02Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill02Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_team1Label
            // 
            this.RD_team1Label.Location = new System.Drawing.Point(6, 7);
            this.RD_team1Label.Name = "RD_team1Label";
            this.RD_team1Label.Size = new System.Drawing.Size(60, 13);
            this.RD_team1Label.TabIndex = 0;
            this.RD_team1Label.Text = "Team 1";
            // 
            // RD_t1Skill01Button
            // 
            this.RD_t1Skill01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RD_t1Skill01Button.Location = new System.Drawing.Point(77, 2);
            this.RD_t1Skill01Button.Name = "RD_t1Skill01Button";
            this.RD_t1Skill01Button.Size = new System.Drawing.Size(23, 23);
            this.RD_t1Skill01Button.TabIndex = 1;
            this.RD_t1Skill01Button.Tag = "0";
            this.RD_t1Skill01Button.UseVisualStyleBackColor = true;
            this.RD_t1Skill01Button.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // RD_enableCheckBox
            // 
            this.RD_enableCheckBox.AutoSize = true;
            this.RD_enableCheckBox.Checked = true;
            this.RD_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RD_enableCheckBox.Location = new System.Drawing.Point(9, 7);
            this.RD_enableCheckBox.Name = "RD_enableCheckBox";
            this.RD_enableCheckBox.Size = new System.Drawing.Size(84, 17);
            this.RD_enableCheckBox.TabIndex = 1;
            this.RD_enableCheckBox.Tag = "3";
            this.RD_enableCheckBox.Text = "Enable Raid";
            this.RD_enableCheckBox.UseVisualStyleBackColor = true;
            this.RD_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // RD_DragonLimitCheckBox
            // 
            this.RD_DragonLimitCheckBox.Checked = true;
            this.RD_DragonLimitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RD_DragonLimitCheckBox.Location = new System.Drawing.Point(315, 7);
            this.RD_DragonLimitCheckBox.Name = "RD_DragonLimitCheckBox";
            this.RD_DragonLimitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.RD_DragonLimitCheckBox.TabIndex = 26;
            this.RD_DragonLimitCheckBox.Tag = "4";
            this.RD_DragonLimitCheckBox.Text = "Limit";
            this.RD_DragonLimitCheckBox.UseVisualStyleBackColor = true;
            this.RD_DragonLimitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // resourcesTab
            // 
            this.resourcesTab.BackColor = System.Drawing.Color.Transparent;
            this.resourcesTab.Controls.Add(this.RS_collectQuestsGroupBox);
            this.resourcesTab.Controls.Add(this.RS_sendHonorsGroupBox);
            this.resourcesTab.Controls.Add(this.RS_buyKeysGroupBox);
            this.resourcesTab.Controls.Add(this.RS_inboxGroupBox);
            this.resourcesTab.Controls.Add(this.RS_sellingGroupBox);
            this.resourcesTab.Controls.Add(this.RS_giftsGroupBox);
            this.resourcesTab.Location = new System.Drawing.Point(4, 22);
            this.resourcesTab.Name = "resourcesTab";
            this.resourcesTab.Size = new System.Drawing.Size(488, 309);
            this.resourcesTab.TabIndex = 6;
            this.resourcesTab.Text = "Resources";
            // 
            // RS_collectQuestsGroupBox
            // 
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsSocialCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsItemCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsHeroCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsBattleCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_specialQuestsMonthlyCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_specialQuestsWeeklyCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_specialQuestsDailyCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsNormalLabel);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsSpecialLabel);
            this.RS_collectQuestsGroupBox.Location = new System.Drawing.Point(183, 142);
            this.RS_collectQuestsGroupBox.Name = "RS_collectQuestsGroupBox";
            this.RS_collectQuestsGroupBox.Size = new System.Drawing.Size(296, 71);
            this.RS_collectQuestsGroupBox.TabIndex = 3;
            this.RS_collectQuestsGroupBox.TabStop = false;
            this.RS_collectQuestsGroupBox.Text = "Collect Quests";
            // 
            // RS_questsSocialCheckBox
            // 
            this.RS_questsSocialCheckBox.AutoSize = true;
            this.RS_questsSocialCheckBox.Location = new System.Drawing.Point(234, 44);
            this.RS_questsSocialCheckBox.Name = "RS_questsSocialCheckBox";
            this.RS_questsSocialCheckBox.Size = new System.Drawing.Size(55, 17);
            this.RS_questsSocialCheckBox.TabIndex = 8;
            this.RS_questsSocialCheckBox.Tag = "6";
            this.RS_questsSocialCheckBox.Text = "Social";
            this.RS_questsSocialCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsSocialCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsItemCheckBox
            // 
            this.RS_questsItemCheckBox.AutoSize = true;
            this.RS_questsItemCheckBox.Location = new System.Drawing.Point(178, 44);
            this.RS_questsItemCheckBox.Name = "RS_questsItemCheckBox";
            this.RS_questsItemCheckBox.Size = new System.Drawing.Size(46, 17);
            this.RS_questsItemCheckBox.TabIndex = 7;
            this.RS_questsItemCheckBox.Tag = "5";
            this.RS_questsItemCheckBox.Text = "Item";
            this.RS_questsItemCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsItemCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsHeroCheckBox
            // 
            this.RS_questsHeroCheckBox.AutoSize = true;
            this.RS_questsHeroCheckBox.Location = new System.Drawing.Point(121, 44);
            this.RS_questsHeroCheckBox.Name = "RS_questsHeroCheckBox";
            this.RS_questsHeroCheckBox.Size = new System.Drawing.Size(49, 17);
            this.RS_questsHeroCheckBox.TabIndex = 6;
            this.RS_questsHeroCheckBox.Tag = "4";
            this.RS_questsHeroCheckBox.Text = "Hero";
            this.RS_questsHeroCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsHeroCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsBattleCheckBox
            // 
            this.RS_questsBattleCheckBox.AutoSize = true;
            this.RS_questsBattleCheckBox.Location = new System.Drawing.Point(60, 44);
            this.RS_questsBattleCheckBox.Name = "RS_questsBattleCheckBox";
            this.RS_questsBattleCheckBox.Size = new System.Drawing.Size(53, 17);
            this.RS_questsBattleCheckBox.TabIndex = 5;
            this.RS_questsBattleCheckBox.Tag = "3";
            this.RS_questsBattleCheckBox.Text = "Battle";
            this.RS_questsBattleCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsBattleCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_specialQuestsMonthlyCheckBox
            // 
            this.RS_specialQuestsMonthlyCheckBox.AutoSize = true;
            this.RS_specialQuestsMonthlyCheckBox.Location = new System.Drawing.Point(203, 20);
            this.RS_specialQuestsMonthlyCheckBox.Name = "RS_specialQuestsMonthlyCheckBox";
            this.RS_specialQuestsMonthlyCheckBox.Size = new System.Drawing.Size(63, 17);
            this.RS_specialQuestsMonthlyCheckBox.TabIndex = 4;
            this.RS_specialQuestsMonthlyCheckBox.Tag = "2";
            this.RS_specialQuestsMonthlyCheckBox.Text = "Monthly";
            this.RS_specialQuestsMonthlyCheckBox.UseVisualStyleBackColor = true;
            this.RS_specialQuestsMonthlyCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_specialQuestsWeeklyCheckBox
            // 
            this.RS_specialQuestsWeeklyCheckBox.AutoSize = true;
            this.RS_specialQuestsWeeklyCheckBox.Location = new System.Drawing.Point(125, 20);
            this.RS_specialQuestsWeeklyCheckBox.Name = "RS_specialQuestsWeeklyCheckBox";
            this.RS_specialQuestsWeeklyCheckBox.Size = new System.Drawing.Size(62, 17);
            this.RS_specialQuestsWeeklyCheckBox.TabIndex = 3;
            this.RS_specialQuestsWeeklyCheckBox.Tag = "1";
            this.RS_specialQuestsWeeklyCheckBox.Text = "Weekly";
            this.RS_specialQuestsWeeklyCheckBox.UseVisualStyleBackColor = true;
            this.RS_specialQuestsWeeklyCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_specialQuestsDailyCheckBox
            // 
            this.RS_specialQuestsDailyCheckBox.AutoSize = true;
            this.RS_specialQuestsDailyCheckBox.Location = new System.Drawing.Point(60, 20);
            this.RS_specialQuestsDailyCheckBox.Name = "RS_specialQuestsDailyCheckBox";
            this.RS_specialQuestsDailyCheckBox.Size = new System.Drawing.Size(49, 17);
            this.RS_specialQuestsDailyCheckBox.TabIndex = 2;
            this.RS_specialQuestsDailyCheckBox.Tag = "0";
            this.RS_specialQuestsDailyCheckBox.Text = "Daily";
            this.RS_specialQuestsDailyCheckBox.UseVisualStyleBackColor = true;
            this.RS_specialQuestsDailyCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsNormalLabel
            // 
            this.RS_questsNormalLabel.AutoSize = true;
            this.RS_questsNormalLabel.Location = new System.Drawing.Point(7, 44);
            this.RS_questsNormalLabel.Name = "RS_questsNormalLabel";
            this.RS_questsNormalLabel.Size = new System.Drawing.Size(43, 13);
            this.RS_questsNormalLabel.TabIndex = 1;
            this.RS_questsNormalLabel.Text = "Normal:";
            // 
            // RS_questsSpecialLabel
            // 
            this.RS_questsSpecialLabel.AutoSize = true;
            this.RS_questsSpecialLabel.Location = new System.Drawing.Point(7, 20);
            this.RS_questsSpecialLabel.Name = "RS_questsSpecialLabel";
            this.RS_questsSpecialLabel.Size = new System.Drawing.Size(45, 13);
            this.RS_questsSpecialLabel.TabIndex = 0;
            this.RS_questsSpecialLabel.Text = "Special:";
            // 
            // RS_sendHonorsGroupBox
            // 
            this.RS_sendHonorsGroupBox.Controls.Add(this.RS_sendHonorsInGame);
            this.RS_sendHonorsGroupBox.Controls.Add(this.RS_sendHonorsFacebook);
            this.RS_sendHonorsGroupBox.Location = new System.Drawing.Point(9, 219);
            this.RS_sendHonorsGroupBox.Name = "RS_sendHonorsGroupBox";
            this.RS_sendHonorsGroupBox.Size = new System.Drawing.Size(168, 71);
            this.RS_sendHonorsGroupBox.TabIndex = 4;
            this.RS_sendHonorsGroupBox.TabStop = false;
            this.RS_sendHonorsGroupBox.Text = "Send Honors";
            // 
            // RS_sendHonorsInGame
            // 
            this.RS_sendHonorsInGame.AutoSize = true;
            this.RS_sendHonorsInGame.Location = new System.Drawing.Point(7, 44);
            this.RS_sendHonorsInGame.Name = "RS_sendHonorsInGame";
            this.RS_sendHonorsInGame.Size = new System.Drawing.Size(119, 17);
            this.RS_sendHonorsInGame.TabIndex = 1;
            this.RS_sendHonorsInGame.Tag = "1";
            this.RS_sendHonorsInGame.Text = "To In-Game Friends";
            this.toolTip.SetToolTip(this.RS_sendHonorsInGame, "BETA Function");
            this.RS_sendHonorsInGame.UseVisualStyleBackColor = true;
            this.RS_sendHonorsInGame.CheckedChanged += new System.EventHandler(this.RS_sendHonorsCheckBox_CheckedChanged);
            // 
            // RS_sendHonorsFacebook
            // 
            this.RS_sendHonorsFacebook.AutoSize = true;
            this.RS_sendHonorsFacebook.Location = new System.Drawing.Point(7, 20);
            this.RS_sendHonorsFacebook.Name = "RS_sendHonorsFacebook";
            this.RS_sendHonorsFacebook.Size = new System.Drawing.Size(127, 17);
            this.RS_sendHonorsFacebook.TabIndex = 0;
            this.RS_sendHonorsFacebook.Tag = "0";
            this.RS_sendHonorsFacebook.Text = "To Facebook Friends";
            this.toolTip.SetToolTip(this.RS_sendHonorsFacebook, "BETA Function");
            this.RS_sendHonorsFacebook.UseVisualStyleBackColor = true;
            this.RS_sendHonorsFacebook.CheckedChanged += new System.EventHandler(this.RS_sendHonorsCheckBox_CheckedChanged);
            // 
            // RS_buyKeysGroupBox
            // 
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesLabel);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesNumericBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesComboBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesCheckBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsLabel);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsNumericBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsComboBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsCheckBox);
            this.RS_buyKeysGroupBox.Location = new System.Drawing.Point(183, 219);
            this.RS_buyKeysGroupBox.Name = "RS_buyKeysGroupBox";
            this.RS_buyKeysGroupBox.Size = new System.Drawing.Size(296, 71);
            this.RS_buyKeysGroupBox.TabIndex = 5;
            this.RS_buyKeysGroupBox.TabStop = false;
            this.RS_buyKeysGroupBox.Text = "Buy Keys";
            // 
            // RS_buyKeyRubiesLabel
            // 
            this.RS_buyKeyRubiesLabel.Location = new System.Drawing.Point(256, 49);
            this.RS_buyKeyRubiesLabel.Name = "RS_buyKeyRubiesLabel";
            this.RS_buyKeyRubiesLabel.Size = new System.Drawing.Size(35, 13);
            this.RS_buyKeyRubiesLabel.TabIndex = 7;
            this.RS_buyKeyRubiesLabel.Text = "times";
            // 
            // RS_buyKeyRubiesNumericBox
            // 
            this.RS_buyKeyRubiesNumericBox.Location = new System.Drawing.Point(213, 45);
            this.RS_buyKeyRubiesNumericBox.Name = "RS_buyKeyRubiesNumericBox";
            this.RS_buyKeyRubiesNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_buyKeyRubiesNumericBox.TabIndex = 6;
            this.RS_buyKeyRubiesNumericBox.Tag = "1";
            this.RS_buyKeyRubiesNumericBox.ValueChanged += new System.EventHandler(this.RS_buyKeysNumericBox_ValueChanged);
            // 
            // RS_buyKeyRubiesComboBox
            // 
            this.RS_buyKeyRubiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_buyKeyRubiesComboBox.FormattingEnabled = true;
            this.RS_buyKeyRubiesComboBox.Items.AddRange(new object[] {
            "5 Keys with 10 Rubies",
            "10 Keys with 20 Rubies",
            "20 Keys with 35 Rubies",
            "40 Keys with 45 Rubies",
            "100 Keys with 100 Rubbies"});
            this.RS_buyKeyRubiesComboBox.Location = new System.Drawing.Point(57, 44);
            this.RS_buyKeyRubiesComboBox.Name = "RS_buyKeyRubiesComboBox";
            this.RS_buyKeyRubiesComboBox.Size = new System.Drawing.Size(150, 21);
            this.RS_buyKeyRubiesComboBox.TabIndex = 5;
            this.RS_buyKeyRubiesComboBox.Tag = "1";
            this.RS_buyKeyRubiesComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_buyKeysComboBox_SelectedIndexChanged);
            // 
            // RS_buyKeyRubiesCheckBox
            // 
            this.RS_buyKeyRubiesCheckBox.AutoSize = true;
            this.RS_buyKeyRubiesCheckBox.Location = new System.Drawing.Point(7, 48);
            this.RS_buyKeyRubiesCheckBox.Name = "RS_buyKeyRubiesCheckBox";
            this.RS_buyKeyRubiesCheckBox.Size = new System.Drawing.Size(44, 17);
            this.RS_buyKeyRubiesCheckBox.TabIndex = 4;
            this.RS_buyKeyRubiesCheckBox.Tag = "1";
            this.RS_buyKeyRubiesCheckBox.Text = "Buy";
            this.RS_buyKeyRubiesCheckBox.UseVisualStyleBackColor = true;
            this.RS_buyKeyRubiesCheckBox.CheckedChanged += new System.EventHandler(this.RS_buyKeysCheckBox_CheckedChanged);
            // 
            // RS_buyKeyHonorsLabel
            // 
            this.RS_buyKeyHonorsLabel.Location = new System.Drawing.Point(256, 21);
            this.RS_buyKeyHonorsLabel.Name = "RS_buyKeyHonorsLabel";
            this.RS_buyKeyHonorsLabel.Size = new System.Drawing.Size(35, 13);
            this.RS_buyKeyHonorsLabel.TabIndex = 3;
            this.RS_buyKeyHonorsLabel.Text = "times";
            // 
            // RS_buyKeyHonorsNumericBox
            // 
            this.RS_buyKeyHonorsNumericBox.Location = new System.Drawing.Point(213, 17);
            this.RS_buyKeyHonorsNumericBox.Name = "RS_buyKeyHonorsNumericBox";
            this.RS_buyKeyHonorsNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_buyKeyHonorsNumericBox.TabIndex = 2;
            this.RS_buyKeyHonorsNumericBox.Tag = "0";
            this.RS_buyKeyHonorsNumericBox.ValueChanged += new System.EventHandler(this.RS_buyKeysNumericBox_ValueChanged);
            // 
            // RS_buyKeyHonorsComboBox
            // 
            this.RS_buyKeyHonorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_buyKeyHonorsComboBox.FormattingEnabled = true;
            this.RS_buyKeyHonorsComboBox.Items.AddRange(new object[] {
            "1 Key with 10 Honors",
            "10 Keys with 100 Honors"});
            this.RS_buyKeyHonorsComboBox.Location = new System.Drawing.Point(57, 16);
            this.RS_buyKeyHonorsComboBox.Name = "RS_buyKeyHonorsComboBox";
            this.RS_buyKeyHonorsComboBox.Size = new System.Drawing.Size(150, 21);
            this.RS_buyKeyHonorsComboBox.TabIndex = 1;
            this.RS_buyKeyHonorsComboBox.Tag = "0";
            this.RS_buyKeyHonorsComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_buyKeysComboBox_SelectedIndexChanged);
            // 
            // RS_buyKeyHonorsCheckBox
            // 
            this.RS_buyKeyHonorsCheckBox.AutoSize = true;
            this.RS_buyKeyHonorsCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RS_buyKeyHonorsCheckBox.Name = "RS_buyKeyHonorsCheckBox";
            this.RS_buyKeyHonorsCheckBox.Size = new System.Drawing.Size(44, 17);
            this.RS_buyKeyHonorsCheckBox.TabIndex = 0;
            this.RS_buyKeyHonorsCheckBox.Tag = "0";
            this.RS_buyKeyHonorsCheckBox.Text = "Buy";
            this.RS_buyKeyHonorsCheckBox.UseVisualStyleBackColor = true;
            this.RS_buyKeyHonorsCheckBox.CheckedChanged += new System.EventHandler(this.RS_buyKeysCheckBox_CheckedChanged);
            // 
            // RS_inboxGroupBox
            // 
            this.RS_inboxGroupBox.Controls.Add(this.RS_inboxTickets);
            this.RS_inboxGroupBox.Controls.Add(this.RS_inboxRubies);
            this.RS_inboxGroupBox.Controls.Add(this.RS_inboxGold);
            this.RS_inboxGroupBox.Controls.Add(this.RS_inboxKeys);
            this.RS_inboxGroupBox.Controls.Add(this.RS_inboxHonors);
            this.RS_inboxGroupBox.Location = new System.Drawing.Point(9, 90);
            this.RS_inboxGroupBox.Name = "RS_inboxGroupBox";
            this.RS_inboxGroupBox.Size = new System.Drawing.Size(470, 46);
            this.RS_inboxGroupBox.TabIndex = 1;
            this.RS_inboxGroupBox.TabStop = false;
            this.RS_inboxGroupBox.Text = "Collect Inbox";
            // 
            // RS_inboxTickets
            // 
            this.RS_inboxTickets.AutoSize = true;
            this.RS_inboxTickets.Location = new System.Drawing.Point(367, 20);
            this.RS_inboxTickets.Name = "RS_inboxTickets";
            this.RS_inboxTickets.Size = new System.Drawing.Size(61, 17);
            this.RS_inboxTickets.TabIndex = 4;
            this.RS_inboxTickets.Tag = "4";
            this.RS_inboxTickets.Text = "Tickets";
            this.RS_inboxTickets.UseVisualStyleBackColor = true;
            this.RS_inboxTickets.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_inboxRubies
            // 
            this.RS_inboxRubies.AutoSize = true;
            this.RS_inboxRubies.Location = new System.Drawing.Point(277, 20);
            this.RS_inboxRubies.Name = "RS_inboxRubies";
            this.RS_inboxRubies.Size = new System.Drawing.Size(59, 17);
            this.RS_inboxRubies.TabIndex = 3;
            this.RS_inboxRubies.Tag = "3";
            this.RS_inboxRubies.Text = "Rubies";
            this.RS_inboxRubies.UseVisualStyleBackColor = true;
            this.RS_inboxRubies.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_inboxGold
            // 
            this.RS_inboxGold.AutoSize = true;
            this.RS_inboxGold.Location = new System.Drawing.Point(187, 20);
            this.RS_inboxGold.Name = "RS_inboxGold";
            this.RS_inboxGold.Size = new System.Drawing.Size(48, 17);
            this.RS_inboxGold.TabIndex = 2;
            this.RS_inboxGold.Tag = "2";
            this.RS_inboxGold.Text = "Gold";
            this.RS_inboxGold.UseVisualStyleBackColor = true;
            this.RS_inboxGold.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_inboxKeys
            // 
            this.RS_inboxKeys.AutoSize = true;
            this.RS_inboxKeys.Location = new System.Drawing.Point(97, 20);
            this.RS_inboxKeys.Name = "RS_inboxKeys";
            this.RS_inboxKeys.Size = new System.Drawing.Size(49, 17);
            this.RS_inboxKeys.TabIndex = 1;
            this.RS_inboxKeys.Tag = "1";
            this.RS_inboxKeys.Text = "Keys";
            this.RS_inboxKeys.UseVisualStyleBackColor = true;
            this.RS_inboxKeys.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_inboxHonors
            // 
            this.RS_inboxHonors.AutoSize = true;
            this.RS_inboxHonors.Location = new System.Drawing.Point(7, 20);
            this.RS_inboxHonors.Name = "RS_inboxHonors";
            this.RS_inboxHonors.Size = new System.Drawing.Size(60, 17);
            this.RS_inboxHonors.TabIndex = 0;
            this.RS_inboxHonors.Tag = "0";
            this.RS_inboxHonors.Text = "Honors";
            this.RS_inboxHonors.UseVisualStyleBackColor = true;
            this.RS_inboxHonors.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_sellingGroupBox
            // 
            this.RS_sellingGroupBox.Controls.Add(this.RS_itemRadioPanel);
            this.RS_sellingGroupBox.Controls.Add(this.RS_heroRadioPanel);
            this.RS_sellingGroupBox.Controls.Add(this.RS_itemAmountNumericBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_heroAmountNumericBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_itemStarsComboBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_heroStarsComboBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_sellHeroesCheckBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_sellItemsCheckBox);
            this.RS_sellingGroupBox.Location = new System.Drawing.Point(9, 8);
            this.RS_sellingGroupBox.Name = "RS_sellingGroupBox";
            this.RS_sellingGroupBox.Size = new System.Drawing.Size(470, 75);
            this.RS_sellingGroupBox.TabIndex = 0;
            this.RS_sellingGroupBox.TabStop = false;
            this.RS_sellingGroupBox.Text = "Selling";
            // 
            // RS_itemRadioPanel
            // 
            this.RS_itemRadioPanel.Controls.Add(this.RS_itemAmountRadioButton);
            this.RS_itemRadioPanel.Controls.Add(this.RS_itemAllRadioButton);
            this.RS_itemRadioPanel.Location = new System.Drawing.Point(319, 44);
            this.RS_itemRadioPanel.Name = "RS_itemRadioPanel";
            this.RS_itemRadioPanel.Size = new System.Drawing.Size(108, 25);
            this.RS_itemRadioPanel.TabIndex = 11;
            this.RS_itemRadioPanel.Tag = "1";
            // 
            // RS_itemAmountRadioButton
            // 
            this.RS_itemAmountRadioButton.Enabled = false;
            this.RS_itemAmountRadioButton.Location = new System.Drawing.Point(46, 4);
            this.RS_itemAmountRadioButton.Name = "RS_itemAmountRadioButton";
            this.RS_itemAmountRadioButton.Size = new System.Drawing.Size(61, 17);
            this.RS_itemAmountRadioButton.TabIndex = 10;
            this.RS_itemAmountRadioButton.TabStop = true;
            this.RS_itemAmountRadioButton.Tag = "1";
            this.RS_itemAmountRadioButton.Text = "Amount";
            this.RS_itemAmountRadioButton.UseVisualStyleBackColor = true;
            // 
            // RS_itemAllRadioButton
            // 
            this.RS_itemAllRadioButton.AutoSize = true;
            this.RS_itemAllRadioButton.Enabled = false;
            this.RS_itemAllRadioButton.Location = new System.Drawing.Point(3, 4);
            this.RS_itemAllRadioButton.Name = "RS_itemAllRadioButton";
            this.RS_itemAllRadioButton.Size = new System.Drawing.Size(36, 17);
            this.RS_itemAllRadioButton.TabIndex = 9;
            this.RS_itemAllRadioButton.TabStop = true;
            this.RS_itemAllRadioButton.Tag = "1";
            this.RS_itemAllRadioButton.Text = "All";
            this.RS_itemAllRadioButton.UseVisualStyleBackColor = true;
            this.RS_itemAllRadioButton.CheckedChanged += new System.EventHandler(this.RS_sellAllRadioButton_CheckedChanged);
            // 
            // RS_heroRadioPanel
            // 
            this.RS_heroRadioPanel.Controls.Add(this.RS_heroAmountRadioButton);
            this.RS_heroRadioPanel.Controls.Add(this.RS_heroAllRadioButton);
            this.RS_heroRadioPanel.Location = new System.Drawing.Point(319, 16);
            this.RS_heroRadioPanel.Name = "RS_heroRadioPanel";
            this.RS_heroRadioPanel.Size = new System.Drawing.Size(108, 25);
            this.RS_heroRadioPanel.TabIndex = 2;
            this.RS_heroRadioPanel.Tag = "0";
            // 
            // RS_heroAmountRadioButton
            // 
            this.RS_heroAmountRadioButton.Location = new System.Drawing.Point(46, 4);
            this.RS_heroAmountRadioButton.Name = "RS_heroAmountRadioButton";
            this.RS_heroAmountRadioButton.Size = new System.Drawing.Size(63, 17);
            this.RS_heroAmountRadioButton.TabIndex = 10;
            this.RS_heroAmountRadioButton.TabStop = true;
            this.RS_heroAmountRadioButton.Tag = "0";
            this.RS_heroAmountRadioButton.Text = "Amount";
            this.RS_heroAmountRadioButton.UseVisualStyleBackColor = true;
            // 
            // RS_heroAllRadioButton
            // 
            this.RS_heroAllRadioButton.AutoSize = true;
            this.RS_heroAllRadioButton.Location = new System.Drawing.Point(3, 4);
            this.RS_heroAllRadioButton.Name = "RS_heroAllRadioButton";
            this.RS_heroAllRadioButton.Size = new System.Drawing.Size(36, 17);
            this.RS_heroAllRadioButton.TabIndex = 9;
            this.RS_heroAllRadioButton.TabStop = true;
            this.RS_heroAllRadioButton.Tag = "0";
            this.RS_heroAllRadioButton.Text = "All";
            this.RS_heroAllRadioButton.UseVisualStyleBackColor = true;
            this.RS_heroAllRadioButton.CheckedChanged += new System.EventHandler(this.RS_sellAllRadioButton_CheckedChanged);
            // 
            // RS_itemAmountNumericBox
            // 
            this.RS_itemAmountNumericBox.Enabled = false;
            this.RS_itemAmountNumericBox.Location = new System.Drawing.Point(428, 47);
            this.RS_itemAmountNumericBox.Name = "RS_itemAmountNumericBox";
            this.RS_itemAmountNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_itemAmountNumericBox.TabIndex = 8;
            this.RS_itemAmountNumericBox.Tag = "1";
            this.RS_itemAmountNumericBox.ValueChanged += new System.EventHandler(this.RS_sellAmountNumericBox_ValueChanged);
            // 
            // RS_heroAmountNumericBox
            // 
            this.RS_heroAmountNumericBox.Location = new System.Drawing.Point(428, 19);
            this.RS_heroAmountNumericBox.Name = "RS_heroAmountNumericBox";
            this.RS_heroAmountNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_heroAmountNumericBox.TabIndex = 7;
            this.RS_heroAmountNumericBox.Tag = "0";
            this.RS_heroAmountNumericBox.ValueChanged += new System.EventHandler(this.RS_sellAmountNumericBox_ValueChanged);
            // 
            // RS_itemStarsComboBox
            // 
            this.RS_itemStarsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_itemStarsComboBox.Enabled = false;
            this.RS_itemStarsComboBox.FormattingEnabled = true;
            this.RS_itemStarsComboBox.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★",
            "★★★★★",
            "★★★★★★"});
            this.RS_itemStarsComboBox.Location = new System.Drawing.Point(235, 46);
            this.RS_itemStarsComboBox.Name = "RS_itemStarsComboBox";
            this.RS_itemStarsComboBox.Size = new System.Drawing.Size(78, 21);
            this.RS_itemStarsComboBox.TabIndex = 4;
            this.RS_itemStarsComboBox.Tag = "1";
            this.RS_itemStarsComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_sellStarsComboBox_SelectedIndexChanged);
            // 
            // RS_heroStarsComboBox
            // 
            this.RS_heroStarsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_heroStarsComboBox.FormattingEnabled = true;
            this.RS_heroStarsComboBox.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★"});
            this.RS_heroStarsComboBox.Location = new System.Drawing.Point(235, 18);
            this.RS_heroStarsComboBox.Name = "RS_heroStarsComboBox";
            this.RS_heroStarsComboBox.Size = new System.Drawing.Size(78, 21);
            this.RS_heroStarsComboBox.TabIndex = 3;
            this.RS_heroStarsComboBox.Tag = "0";
            this.RS_heroStarsComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_sellStarsComboBox_SelectedIndexChanged);
            // 
            // RS_sellHeroesCheckBox
            // 
            this.RS_sellHeroesCheckBox.AutoSize = true;
            this.RS_sellHeroesCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RS_sellHeroesCheckBox.Name = "RS_sellHeroesCheckBox";
            this.RS_sellHeroesCheckBox.Size = new System.Drawing.Size(220, 17);
            this.RS_sellHeroesCheckBox.TabIndex = 2;
            this.RS_sellHeroesCheckBox.Tag = "0";
            this.RS_sellHeroesCheckBox.Text = "Lv.30 heroes with ★ less than or equal to";
            this.toolTip.SetToolTip(this.RS_sellHeroesCheckBox, "BETA Function");
            this.RS_sellHeroesCheckBox.UseVisualStyleBackColor = true;
            this.RS_sellHeroesCheckBox.CheckedChanged += new System.EventHandler(this.RS_sellCheckBox_CheckedChanged);
            // 
            // RS_sellItemsCheckBox
            // 
            this.RS_sellItemsCheckBox.AutoSize = true;
            this.RS_sellItemsCheckBox.Enabled = false;
            this.RS_sellItemsCheckBox.Location = new System.Drawing.Point(7, 48);
            this.RS_sellItemsCheckBox.Name = "RS_sellItemsCheckBox";
            this.RS_sellItemsCheckBox.Size = new System.Drawing.Size(207, 17);
            this.RS_sellItemsCheckBox.TabIndex = 0;
            this.RS_sellItemsCheckBox.Tag = "1";
            this.RS_sellItemsCheckBox.Text = "Every item with ★ less than or equal to";
            this.RS_sellItemsCheckBox.UseVisualStyleBackColor = true;
            this.RS_sellItemsCheckBox.CheckedChanged += new System.EventHandler(this.RS_sellCheckBox_CheckedChanged);
            // 
            // RS_giftsGroupBox
            // 
            this.RS_giftsGroupBox.Controls.Add(this.RS_luckyBoxCheckBox);
            this.RS_giftsGroupBox.Controls.Add(this.RS_luckyChestCheckBox);
            this.RS_giftsGroupBox.Enabled = false;
            this.RS_giftsGroupBox.Location = new System.Drawing.Point(9, 142);
            this.RS_giftsGroupBox.Name = "RS_giftsGroupBox";
            this.RS_giftsGroupBox.Size = new System.Drawing.Size(168, 71);
            this.RS_giftsGroupBox.TabIndex = 2;
            this.RS_giftsGroupBox.TabStop = false;
            this.RS_giftsGroupBox.Text = "Gifts";
            // 
            // RS_luckyBoxCheckBox
            // 
            this.RS_luckyBoxCheckBox.AutoSize = true;
            this.RS_luckyBoxCheckBox.Location = new System.Drawing.Point(7, 44);
            this.RS_luckyBoxCheckBox.Name = "RS_luckyBoxCheckBox";
            this.RS_luckyBoxCheckBox.Size = new System.Drawing.Size(111, 17);
            this.RS_luckyBoxCheckBox.TabIndex = 1;
            this.RS_luckyBoxCheckBox.Tag = "1";
            this.RS_luckyBoxCheckBox.Text = "Collect Lucky Box";
            this.RS_luckyBoxCheckBox.UseVisualStyleBackColor = true;
            this.RS_luckyBoxCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectGiftCheckBox_CheckedChanged);
            // 
            // RS_luckyChestCheckBox
            // 
            this.RS_luckyChestCheckBox.AutoSize = true;
            this.RS_luckyChestCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RS_luckyChestCheckBox.Name = "RS_luckyChestCheckBox";
            this.RS_luckyChestCheckBox.Size = new System.Drawing.Size(150, 17);
            this.RS_luckyChestCheckBox.TabIndex = 0;
            this.RS_luckyChestCheckBox.Tag = "0";
            this.RS_luckyChestCheckBox.Text = "Collect May\'s Lucky Chest";
            this.RS_luckyChestCheckBox.UseVisualStyleBackColor = true;
            this.RS_luckyChestCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectGiftCheckBox_CheckedChanged);
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.Transparent;
            this.settingsTab.Controls.Add(this.ST_blueStacksGroupBox);
            this.settingsTab.Controls.Add(this.ST_profileGroupBox);
            this.settingsTab.Controls.Add(this.ST_foregroundMode);
            this.settingsTab.Controls.Add(this.ST_reconnectNumericUpDown);
            this.settingsTab.Controls.Add(this.ST_reconnectInterruptCheckBox);
            this.settingsTab.Controls.Add(this.ST_opacityLabel);
            this.settingsTab.Controls.Add(this.ST_opacityTrackBar);
            this.settingsTab.Controls.Add(this.ST_pushbulletGroupBox);
            this.settingsTab.Controls.Add(this.ST_delayValueLabel);
            this.settingsTab.Controls.Add(this.ST_delayLabel);
            this.settingsTab.Controls.Add(this.ST_delayTrackBar);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(488, 309);
            this.settingsTab.TabIndex = 5;
            this.settingsTab.Text = "Settings";
            // 
            // ST_blueStacksGroupBox
            // 
            this.ST_blueStacksGroupBox.Controls.Add(this.ST_forceActiveCheckBox);
            this.ST_blueStacksGroupBox.Controls.Add(this.ST_toggleBlueStacksButton);
            this.ST_blueStacksGroupBox.Location = new System.Drawing.Point(313, 101);
            this.ST_blueStacksGroupBox.Name = "ST_blueStacksGroupBox";
            this.ST_blueStacksGroupBox.Size = new System.Drawing.Size(165, 68);
            this.ST_blueStacksGroupBox.TabIndex = 7;
            this.ST_blueStacksGroupBox.TabStop = false;
            this.ST_blueStacksGroupBox.Text = "BlueStacks";
            // 
            // ST_forceActiveCheckBox
            // 
            this.ST_forceActiveCheckBox.AutoSize = true;
            this.ST_forceActiveCheckBox.Location = new System.Drawing.Point(36, 19);
            this.ST_forceActiveCheckBox.Name = "ST_forceActiveCheckBox";
            this.ST_forceActiveCheckBox.Size = new System.Drawing.Size(92, 17);
            this.ST_forceActiveCheckBox.TabIndex = 1;
            this.ST_forceActiveCheckBox.Text = "Always on top";
            this.ST_forceActiveCheckBox.UseVisualStyleBackColor = true;
            this.ST_forceActiveCheckBox.CheckedChanged += new System.EventHandler(this.ST_forceActiveCheckBox_CheckedChanged);
            // 
            // ST_toggleBlueStacksButton
            // 
            this.ST_toggleBlueStacksButton.Enabled = false;
            this.ST_toggleBlueStacksButton.Location = new System.Drawing.Point(6, 39);
            this.ST_toggleBlueStacksButton.Name = "ST_toggleBlueStacksButton";
            this.ST_toggleBlueStacksButton.Size = new System.Drawing.Size(153, 23);
            this.ST_toggleBlueStacksButton.TabIndex = 0;
            this.ST_toggleBlueStacksButton.Text = "Hide BlueStacks";
            this.ST_toggleBlueStacksButton.UseVisualStyleBackColor = true;
            this.ST_toggleBlueStacksButton.Click += new System.EventHandler(this.ST_toggleBlueStacksButton_Click);
            // 
            // ST_profileGroupBox
            // 
            this.ST_profileGroupBox.Controls.Add(this.ST_manageProfileButton);
            this.ST_profileGroupBox.Controls.Add(this.ST_hotTimeProfileComboBox);
            this.ST_profileGroupBox.Controls.Add(this.ST_AutoProfileCheckBox);
            this.ST_profileGroupBox.Controls.Add(this.ST_hotTimeProfileCheckBox);
            this.ST_profileGroupBox.Controls.Add(this.ST_currentProfileComboBox);
            this.ST_profileGroupBox.Controls.Add(this.ST_currentProfileLabel);
            this.ST_profileGroupBox.Location = new System.Drawing.Point(8, 79);
            this.ST_profileGroupBox.Name = "ST_profileGroupBox";
            this.ST_profileGroupBox.Size = new System.Drawing.Size(299, 90);
            this.ST_profileGroupBox.TabIndex = 6;
            this.ST_profileGroupBox.TabStop = false;
            this.ST_profileGroupBox.Text = "Profile";
            // 
            // ST_manageProfileButton
            // 
            this.ST_manageProfileButton.Enabled = false;
            this.ST_manageProfileButton.Location = new System.Drawing.Point(214, 15);
            this.ST_manageProfileButton.Name = "ST_manageProfileButton";
            this.ST_manageProfileButton.Size = new System.Drawing.Size(80, 23);
            this.ST_manageProfileButton.TabIndex = 2;
            this.ST_manageProfileButton.Text = "Manage";
            this.ST_manageProfileButton.UseVisualStyleBackColor = true;
            this.ST_manageProfileButton.Click += new System.EventHandler(this.ST_manageProfileButton_Click);
            // 
            // ST_hotTimeProfileComboBox
            // 
            this.ST_hotTimeProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ST_hotTimeProfileComboBox.FormattingEnabled = true;
            this.ST_hotTimeProfileComboBox.Location = new System.Drawing.Point(182, 59);
            this.ST_hotTimeProfileComboBox.Name = "ST_hotTimeProfileComboBox";
            this.ST_hotTimeProfileComboBox.Size = new System.Drawing.Size(112, 21);
            this.ST_hotTimeProfileComboBox.TabIndex = 4;
            this.ST_hotTimeProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.ST_hotTimeProfileComboBox_SelectedIndexChanged);
            // 
            // ST_AutoProfileCheckBox
            // 
            this.ST_AutoProfileCheckBox.AutoSize = true;
            this.ST_AutoProfileCheckBox.Location = new System.Drawing.Point(9, 62);
            this.ST_AutoProfileCheckBox.Name = "ST_AutoProfileCheckBox";
            this.ST_AutoProfileCheckBox.Size = new System.Drawing.Size(142, 17);
            this.ST_AutoProfileCheckBox.TabIndex = 3;
            this.ST_AutoProfileCheckBox.Text = "Use auto change profile ";
            this.ST_AutoProfileCheckBox.UseVisualStyleBackColor = true;
            this.ST_AutoProfileCheckBox.CheckedChanged += new System.EventHandler(this.ST_autoProfileCheckBox_CheckedChanged);
            // 
            // ST_hotTimeProfileCheckBox
            // 
            this.ST_hotTimeProfileCheckBox.AutoSize = true;
            this.ST_hotTimeProfileCheckBox.Enabled = false;
            this.ST_hotTimeProfileCheckBox.Location = new System.Drawing.Point(9, 42);
            this.ST_hotTimeProfileCheckBox.Name = "ST_hotTimeProfileCheckBox";
            this.ST_hotTimeProfileCheckBox.Size = new System.Drawing.Size(167, 17);
            this.ST_hotTimeProfileCheckBox.TabIndex = 3;
            this.ST_hotTimeProfileCheckBox.Text = "Use profile during \'HOT TIME\'";
            this.ST_hotTimeProfileCheckBox.UseVisualStyleBackColor = true;
            this.ST_hotTimeProfileCheckBox.CheckedChanged += new System.EventHandler(this.ST_hotTimeProfileCheckBox_CheckedChanged);
            // 
            // ST_currentProfileComboBox
            // 
            this.ST_currentProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ST_currentProfileComboBox.FormattingEnabled = true;
            this.ST_currentProfileComboBox.Location = new System.Drawing.Point(85, 16);
            this.ST_currentProfileComboBox.Name = "ST_currentProfileComboBox";
            this.ST_currentProfileComboBox.Size = new System.Drawing.Size(112, 21);
            this.ST_currentProfileComboBox.TabIndex = 1;
            this.ST_currentProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.ST_currentProfileComboBox_SelectedIndexChanged);
            // 
            // ST_currentProfileLabel
            // 
            this.ST_currentProfileLabel.AutoSize = true;
            this.ST_currentProfileLabel.Location = new System.Drawing.Point(6, 20);
            this.ST_currentProfileLabel.Name = "ST_currentProfileLabel";
            this.ST_currentProfileLabel.Size = new System.Drawing.Size(73, 13);
            this.ST_currentProfileLabel.TabIndex = 0;
            this.ST_currentProfileLabel.Text = "Current Profile";
            // 
            // ST_foregroundMode
            // 
            this.ST_foregroundMode.AutoSize = true;
            this.ST_foregroundMode.Location = new System.Drawing.Point(8, 285);
            this.ST_foregroundMode.Name = "ST_foregroundMode";
            this.ST_foregroundMode.Size = new System.Drawing.Size(110, 17);
            this.ST_foregroundMode.TabIndex = 9;
            this.ST_foregroundMode.Text = "Foreground Mode";
            this.ST_foregroundMode.UseVisualStyleBackColor = true;
            this.ST_foregroundMode.CheckedChanged += new System.EventHandler(this.ST_foregroundMode_CheckedChanged);
            // 
            // ST_reconnectNumericUpDown
            // 
            this.ST_reconnectNumericUpDown.Location = new System.Drawing.Point(224, 56);
            this.ST_reconnectNumericUpDown.Name = "ST_reconnectNumericUpDown";
            this.ST_reconnectNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.ST_reconnectNumericUpDown.TabIndex = 4;
            this.ST_reconnectNumericUpDown.ValueChanged += new System.EventHandler(this.ST_reconnectNumericBox_ValueChanged);
            // 
            // ST_reconnectInterruptCheckBox
            // 
            this.ST_reconnectInterruptCheckBox.AutoSize = true;
            this.ST_reconnectInterruptCheckBox.Location = new System.Drawing.Point(8, 56);
            this.ST_reconnectInterruptCheckBox.Name = "ST_reconnectInterruptCheckBox";
            this.ST_reconnectInterruptCheckBox.Size = new System.Drawing.Size(210, 17);
            this.ST_reconnectInterruptCheckBox.TabIndex = 3;
            this.ST_reconnectInterruptCheckBox.Text = "Reconnect on interrupt within (minutes)";
            this.ST_reconnectInterruptCheckBox.UseVisualStyleBackColor = true;
            this.ST_reconnectInterruptCheckBox.CheckedChanged += new System.EventHandler(this.ST_reconnectInterruptCheckBox_CheckedChanged);
            // 
            // ST_opacityLabel
            // 
            this.ST_opacityLabel.AutoSize = true;
            this.ST_opacityLabel.Location = new System.Drawing.Point(305, 283);
            this.ST_opacityLabel.Name = "ST_opacityLabel";
            this.ST_opacityLabel.Size = new System.Drawing.Size(72, 13);
            this.ST_opacityLabel.TabIndex = 10;
            this.ST_opacityLabel.Text = "Transparency";
            // 
            // ST_opacityTrackBar
            // 
            this.ST_opacityTrackBar.AutoSize = false;
            this.ST_opacityTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.ST_opacityTrackBar.Location = new System.Drawing.Point(376, 281);
            this.ST_opacityTrackBar.Maximum = 100;
            this.ST_opacityTrackBar.Minimum = 20;
            this.ST_opacityTrackBar.Name = "ST_opacityTrackBar";
            this.ST_opacityTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ST_opacityTrackBar.Size = new System.Drawing.Size(104, 27);
            this.ST_opacityTrackBar.TabIndex = 11;
            this.ST_opacityTrackBar.TickFrequency = 10;
            this.ST_opacityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ST_opacityTrackBar.Value = 100;
            this.ST_opacityTrackBar.ValueChanged += new System.EventHandler(this.ST_opacityTrackBar_ValueChanged);
            // 
            // ST_pushbulletGroupBox
            // 
            this.ST_pushbulletGroupBox.Controls.Add(this.ST_pushbulletHintLabel);
            this.ST_pushbulletGroupBox.Controls.Add(this.ST_pushbulletEmailLabel);
            this.ST_pushbulletGroupBox.Controls.Add(this.ST_pushbulletEmailTextBox);
            this.ST_pushbulletGroupBox.Controls.Add(this.ST_pushbulletCheckBox);
            this.ST_pushbulletGroupBox.Controls.Add(this.ST_pushbulletPictureBox);
            this.ST_pushbulletGroupBox.Location = new System.Drawing.Point(8, 175);
            this.ST_pushbulletGroupBox.Name = "ST_pushbulletGroupBox";
            this.ST_pushbulletGroupBox.Size = new System.Drawing.Size(470, 98);
            this.ST_pushbulletGroupBox.TabIndex = 8;
            this.ST_pushbulletGroupBox.TabStop = false;
            this.ST_pushbulletGroupBox.Text = "Pushbullet";
            // 
            // ST_pushbulletHintLabel
            // 
            this.ST_pushbulletHintLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ST_pushbulletHintLabel.Location = new System.Drawing.Point(68, 36);
            this.ST_pushbulletHintLabel.Name = "ST_pushbulletHintLabel";
            this.ST_pushbulletHintLabel.Size = new System.Drawing.Size(396, 13);
            this.ST_pushbulletHintLabel.TabIndex = 8;
            this.ST_pushbulletHintLabel.Text = "You will need to register a Pushbullet account and install the app on your device" +
    ".";
            // 
            // ST_pushbulletEmailLabel
            // 
            this.ST_pushbulletEmailLabel.AutoSize = true;
            this.ST_pushbulletEmailLabel.Location = new System.Drawing.Point(49, 56);
            this.ST_pushbulletEmailLabel.Name = "ST_pushbulletEmailLabel";
            this.ST_pushbulletEmailLabel.Size = new System.Drawing.Size(177, 13);
            this.ST_pushbulletEmailLabel.TabIndex = 7;
            this.ST_pushbulletEmailLabel.Text = "Enter your Pushbullet email address:";
            // 
            // ST_pushbulletEmailTextBox
            // 
            this.ST_pushbulletEmailTextBox.Location = new System.Drawing.Point(52, 73);
            this.ST_pushbulletEmailTextBox.Name = "ST_pushbulletEmailTextBox";
            this.ST_pushbulletEmailTextBox.Size = new System.Drawing.Size(225, 20);
            this.ST_pushbulletEmailTextBox.TabIndex = 6;
            this.ST_pushbulletEmailTextBox.TextChanged += new System.EventHandler(this.ST_pushbulletEmailTextBox_TextChanged);
            // 
            // ST_pushbulletCheckBox
            // 
            this.ST_pushbulletCheckBox.Location = new System.Drawing.Point(52, 19);
            this.ST_pushbulletCheckBox.Name = "ST_pushbulletCheckBox";
            this.ST_pushbulletCheckBox.Size = new System.Drawing.Size(184, 21);
            this.ST_pushbulletCheckBox.TabIndex = 5;
            this.ST_pushbulletCheckBox.Text = "Enable Push Notifications";
            this.ST_pushbulletCheckBox.UseVisualStyleBackColor = true;
            this.ST_pushbulletCheckBox.CheckedChanged += new System.EventHandler(this.ST_pushbulletCheckBox_CheckedChanged);
            // 
            // ST_pushbulletPictureBox
            // 
            this.ST_pushbulletPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ST_pushbulletPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_pushbullet;
            this.ST_pushbulletPictureBox.Location = new System.Drawing.Point(6, 19);
            this.ST_pushbulletPictureBox.Name = "ST_pushbulletPictureBox";
            this.ST_pushbulletPictureBox.Size = new System.Drawing.Size(40, 40);
            this.ST_pushbulletPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ST_pushbulletPictureBox.TabIndex = 4;
            this.ST_pushbulletPictureBox.TabStop = false;
            // 
            // ST_delayValueLabel
            // 
            this.ST_delayValueLabel.AutoSize = true;
            this.ST_delayValueLabel.Location = new System.Drawing.Point(219, 22);
            this.ST_delayValueLabel.Name = "ST_delayValueLabel";
            this.ST_delayValueLabel.Size = new System.Drawing.Size(47, 13);
            this.ST_delayValueLabel.TabIndex = 2;
            this.ST_delayValueLabel.Text = "1500 ms";
            // 
            // ST_delayLabel
            // 
            this.ST_delayLabel.Location = new System.Drawing.Point(5, 22);
            this.ST_delayLabel.Name = "ST_delayLabel";
            this.ST_delayLabel.Size = new System.Drawing.Size(49, 13);
            this.ST_delayLabel.TabIndex = 1;
            this.ST_delayLabel.Text = "Delay";
            // 
            // ST_delayTrackBar
            // 
            this.ST_delayTrackBar.AutoSize = false;
            this.ST_delayTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.ST_delayTrackBar.LargeChange = 100;
            this.ST_delayTrackBar.Location = new System.Drawing.Point(56, 19);
            this.ST_delayTrackBar.Maximum = 3000;
            this.ST_delayTrackBar.Minimum = 500;
            this.ST_delayTrackBar.Name = "ST_delayTrackBar";
            this.ST_delayTrackBar.Size = new System.Drawing.Size(162, 27);
            this.ST_delayTrackBar.SmallChange = 100;
            this.ST_delayTrackBar.TabIndex = 0;
            this.ST_delayTrackBar.TickFrequency = 100;
            this.ST_delayTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ST_delayTrackBar.Value = 1500;
            this.ST_delayTrackBar.ValueChanged += new System.EventHandler(this.ST_delayTrackBar_ValueChanged);
            // 
            // logTab
            // 
            this.logTab.BackColor = System.Drawing.Color.Transparent;
            this.logTab.Controls.Add(this.LG_SaveScreen);
            this.logTab.Controls.Add(this.LG_LogPixel);
            this.logTab.Controls.Add(this.LG_scrollCheckBox);
            this.logTab.Controls.Add(this.LG_exportButton);
            this.logTab.Controls.Add(this.LG_clearButton);
            this.logTab.Controls.Add(this.LG_logPanel);
            this.logTab.Location = new System.Drawing.Point(4, 22);
            this.logTab.Name = "logTab";
            this.logTab.Size = new System.Drawing.Size(488, 309);
            this.logTab.TabIndex = 7;
            this.logTab.Text = "Logs";
            // 
            // LG_SaveScreen
            // 
            this.LG_SaveScreen.Enabled = false;
            this.LG_SaveScreen.Location = new System.Drawing.Point(225, 280);
            this.LG_SaveScreen.Name = "LG_SaveScreen";
            this.LG_SaveScreen.Size = new System.Drawing.Size(87, 22);
            this.LG_SaveScreen.TabIndex = 4;
            this.LG_SaveScreen.Text = "Save Screen";
            this.toolTip.SetToolTip(this.LG_SaveScreen, "Requries bot to be running or paused\r\n\r\nMouse over pixel to Log while keeping the" +
        " bot focused\r\nPress Alt+L");
            this.LG_SaveScreen.UseVisualStyleBackColor = true;
            this.LG_SaveScreen.Click += new System.EventHandler(this.LG_SaveScreen_Click);
            // 
            // LG_LogPixel
            // 
            this.LG_LogPixel.Enabled = false;
            this.LG_LogPixel.Location = new System.Drawing.Point(144, 280);
            this.LG_LogPixel.Name = "LG_LogPixel";
            this.LG_LogPixel.Size = new System.Drawing.Size(75, 22);
            this.LG_LogPixel.TabIndex = 3;
            this.LG_LogPixel.Text = "&Log Pixel";
            this.toolTip.SetToolTip(this.LG_LogPixel, "Requries bot to be running or paused\r\n\r\nMouse over pixel to Log while keeping the" +
        " bot focused\r\nPress Alt+L");
            this.LG_LogPixel.UseVisualStyleBackColor = true;
            this.LG_LogPixel.Click += new System.EventHandler(this.LG_LogPixel_Click);
            // 
            // LG_scrollCheckBox
            // 
            this.LG_scrollCheckBox.AutoSize = true;
            this.LG_scrollCheckBox.Checked = true;
            this.LG_scrollCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LG_scrollCheckBox.Location = new System.Drawing.Point(391, 283);
            this.LG_scrollCheckBox.Name = "LG_scrollCheckBox";
            this.LG_scrollCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LG_scrollCheckBox.Size = new System.Drawing.Size(91, 17);
            this.LG_scrollCheckBox.TabIndex = 2;
            this.LG_scrollCheckBox.Text = "Auto Scrolling";
            this.LG_scrollCheckBox.UseVisualStyleBackColor = true;
            this.LG_scrollCheckBox.CheckedChanged += new System.EventHandler(this.LG_scrollCheckBox_CheckedChanged);
            // 
            // LG_exportButton
            // 
            this.LG_exportButton.Location = new System.Drawing.Point(74, 279);
            this.LG_exportButton.Name = "LG_exportButton";
            this.LG_exportButton.Size = new System.Drawing.Size(64, 23);
            this.LG_exportButton.TabIndex = 2;
            this.LG_exportButton.Text = "Export";
            this.LG_exportButton.UseVisualStyleBackColor = true;
            this.LG_exportButton.Click += new System.EventHandler(this.LG_exportButton_Click);
            // 
            // LG_clearButton
            // 
            this.LG_clearButton.Location = new System.Drawing.Point(4, 279);
            this.LG_clearButton.Name = "LG_clearButton";
            this.LG_clearButton.Size = new System.Drawing.Size(64, 23);
            this.LG_clearButton.TabIndex = 1;
            this.LG_clearButton.Text = "Clear";
            this.LG_clearButton.UseVisualStyleBackColor = true;
            this.LG_clearButton.Click += new System.EventHandler(this.LG_clearButton_Click);
            // 
            // LG_logPanel
            // 
            this.LG_logPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LG_logPanel.Controls.Add(this.LG_logTextBox);
            this.LG_logPanel.Location = new System.Drawing.Point(3, 4);
            this.LG_logPanel.Name = "LG_logPanel";
            this.LG_logPanel.Size = new System.Drawing.Size(480, 270);
            this.LG_logPanel.TabIndex = 0;
            // 
            // LG_logTextBox
            // 
            this.LG_logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LG_logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LG_logTextBox.Location = new System.Drawing.Point(0, 0);
            this.LG_logTextBox.Name = "LG_logTextBox";
            this.LG_logTextBox.ReadOnly = true;
            this.LG_logTextBox.Size = new System.Drawing.Size(478, 268);
            this.LG_logTextBox.TabIndex = 1;
            this.LG_logTextBox.Text = "";
            this.LG_logTextBox.TextChanged += new System.EventHandler(this.LG_logTextBox_TextChanged);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.Controls.Add(this.testdayofweek);
            this.Info.Controls.Add(this.label3);
            this.Info.Controls.Add(this.linkLabel10);
            this.Info.Controls.Add(this.linkLabel8);
            this.Info.Controls.Add(this.linkLabel5);
            this.Info.Controls.Add(this.linkLabel4);
            this.Info.Controls.Add(this.linkLabel3);
            this.Info.Controls.Add(this.linkLabel7);
            this.Info.Controls.Add(this.linkLabel6);
            this.Info.Controls.Add(this.linkLabel1);
            this.Info.Location = new System.Drawing.Point(4, 22);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(488, 309);
            this.Info.TabIndex = 8;
            this.Info.Text = "Info";
            // 
            // testdayofweek
            // 
            this.testdayofweek.AutoSize = true;
            this.testdayofweek.Location = new System.Drawing.Point(385, 265);
            this.testdayofweek.Name = "testdayofweek";
            this.testdayofweek.Size = new System.Drawing.Size(66, 13);
            this.testdayofweek.TabIndex = 7;
            this.testdayofweek.Text = "DayOfWeek";
            this.testdayofweek.Visible = false;
            this.testdayofweek.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label17_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(28, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thanks you.";
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.linkLabel10.LinkColor = System.Drawing.Color.Black;
            this.linkLabel10.Location = new System.Drawing.Point(118, 256);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(243, 24);
            this.linkLabel10.TabIndex = 5;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "Seven Knight AI Black Page";
            this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(52, 42);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(224, 13);
            this.linkLabel8.TabIndex = 3;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "https://www.facebook.com/groups/heartcold";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(52, 114);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(110, 13);
            this.linkLabel5.TabIndex = 2;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "https://www.nulled.to";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_MouseClick);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(52, 162);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(170, 13);
            this.linkLabel4.TabIndex = 2;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "https://www.nulled.to/user/4-lostit";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_MouseClick);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(52, 139);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(210, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://www.nulled.to/user/513548-daelus";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(52, 65);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(230, 13);
            this.linkLabel7.TabIndex = 1;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "https://github.com/dreammed/SevenKnightsAI";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(52, 188);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(204, 13);
            this.linkLabel6.TabIndex = 1;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "https://www.nulled.to/user/600594-xhum";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(52, 90);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(247, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Nulled-Daelus/SevenKnightsAI";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Silver;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripLabel,
            this.profileToolStripLabel,
            this.statusToolStripLabel,
            this.splitterStatusLabel,
            this.tsslCursorPosition,
            this.tsPixel,
            this.tsslBuildInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(504, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // adminToolStripLabel
            // 
            this.adminToolStripLabel.Name = "adminToolStripLabel";
            this.adminToolStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // profileToolStripLabel
            // 
            this.profileToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profileToolStripLabel.Name = "profileToolStripLabel";
            this.profileToolStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusToolStripLabel
            // 
            this.statusToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusToolStripLabel.Name = "statusToolStripLabel";
            this.statusToolStripLabel.Size = new System.Drawing.Size(103, 17);
            this.statusToolStripLabel.Text = "Status: AI Stopped";
            // 
            // splitterStatusLabel
            // 
            this.splitterStatusLabel.Name = "splitterStatusLabel";
            this.splitterStatusLabel.Size = new System.Drawing.Size(294, 17);
            this.splitterStatusLabel.Spring = true;
            // 
            // tsslCursorPosition
            // 
            this.tsslCursorPosition.Name = "tsslCursorPosition";
            this.tsslCursorPosition.Size = new System.Drawing.Size(0, 17);
            // 
            // tsPixel
            // 
            this.tsPixel.Name = "tsPixel";
            this.tsPixel.Size = new System.Drawing.Size(55, 17);
            this.tsPixel.Text = "Nulled.io";
            // 
            // tsslBuildInfo
            // 
            this.tsslBuildInfo.Name = "tsslBuildInfo";
            this.tsslBuildInfo.Size = new System.Drawing.Size(37, 17);
            this.tsslBuildInfo.Text = "Build:";
            // 
            // aiButton
            // 
            this.aiButton.Location = new System.Drawing.Point(396, 451);
            this.aiButton.Name = "aiButton";
            this.aiButton.Size = new System.Drawing.Size(102, 34);
            this.aiButton.TabIndex = 3;
            this.aiButton.Text = "Start AI";
            this.aiButton.UseVisualStyleBackColor = true;
            this.aiButton.Click += new System.EventHandler(this.aiButton_Click);
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.pictureBox1);
            this.summaryGroupBox.Controls.Add(this.GB_WaitForKeys);
            this.summaryGroupBox.Controls.Add(this.HeroCountLabel);
            this.summaryGroupBox.Controls.Add(this.raidPictureBox);
            this.summaryGroupBox.Controls.Add(this.goldChamberPictureBox);
            this.summaryGroupBox.Controls.Add(this.arenaPictureBox);
            this.summaryGroupBox.Controls.Add(this.adventurePictureBox);
            this.summaryGroupBox.Controls.Add(this.raidCountLabel);
            this.summaryGroupBox.Controls.Add(this.goldChamberCountLabel);
            this.summaryGroupBox.Controls.Add(this.arenaCountLabel);
            this.summaryGroupBox.Controls.Add(this.adventureCountLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(109, 445);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(281, 90);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SevenKnightsAI.Properties.Resources.icon_hero_356;
            this.pictureBox1.Location = new System.Drawing.Point(183, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Hero Count");
            // 
            // GB_WaitForKeys
            // 
            this.GB_WaitForKeys.AutoSize = true;
            this.GB_WaitForKeys.ForeColor = System.Drawing.Color.Blue;
            this.GB_WaitForKeys.Location = new System.Drawing.Point(188, 62);
            this.GB_WaitForKeys.Name = "GB_WaitForKeys";
            this.GB_WaitForKeys.Size = new System.Drawing.Size(72, 17);
            this.GB_WaitForKeys.TabIndex = 11;
            this.GB_WaitForKeys.Text = "Wait on 0";
            this.toolTip.SetToolTip(this.GB_WaitForKeys, "Wait Key");
            this.GB_WaitForKeys.UseVisualStyleBackColor = true;
            this.GB_WaitForKeys.CheckedChanged += new System.EventHandler(this.GB_WaitForKeys_CheckedChanged);
            // 
            // HeroCountLabel
            // 
            this.HeroCountLabel.AutoSize = true;
            this.HeroCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeroCountLabel.Location = new System.Drawing.Point(212, 27);
            this.HeroCountLabel.Name = "HeroCountLabel";
            this.HeroCountLabel.Size = new System.Drawing.Size(10, 13);
            this.HeroCountLabel.TabIndex = 14;
            this.HeroCountLabel.Text = "-";
            // 
            // raidPictureBox
            // 
            this.raidPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_raid;
            this.raidPictureBox.Location = new System.Drawing.Point(98, 57);
            this.raidPictureBox.Name = "raidPictureBox";
            this.raidPictureBox.Size = new System.Drawing.Size(25, 24);
            this.raidPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.raidPictureBox.TabIndex = 11;
            this.raidPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.raidPictureBox, "Raid");
            // 
            // goldChamberPictureBox
            // 
            this.goldChamberPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_gold_chamber;
            this.goldChamberPictureBox.Location = new System.Drawing.Point(98, 22);
            this.goldChamberPictureBox.Name = "goldChamberPictureBox";
            this.goldChamberPictureBox.Size = new System.Drawing.Size(25, 24);
            this.goldChamberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goldChamberPictureBox.TabIndex = 10;
            this.goldChamberPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.goldChamberPictureBox, "Gold Chamber");
            // 
            // arenaPictureBox
            // 
            this.arenaPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_arena;
            this.arenaPictureBox.Location = new System.Drawing.Point(15, 57);
            this.arenaPictureBox.Name = "arenaPictureBox";
            this.arenaPictureBox.Size = new System.Drawing.Size(25, 24);
            this.arenaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arenaPictureBox.TabIndex = 9;
            this.arenaPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.arenaPictureBox, "Arena");
            // 
            // adventurePictureBox
            // 
            this.adventurePictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_adventure;
            this.adventurePictureBox.Location = new System.Drawing.Point(15, 23);
            this.adventurePictureBox.Name = "adventurePictureBox";
            this.adventurePictureBox.Size = new System.Drawing.Size(25, 24);
            this.adventurePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adventurePictureBox.TabIndex = 8;
            this.adventurePictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.adventurePictureBox, "Adventure");
            // 
            // raidCountLabel
            // 
            this.raidCountLabel.AutoSize = true;
            this.raidCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.raidCountLabel.Location = new System.Drawing.Point(127, 62);
            this.raidCountLabel.Name = "raidCountLabel";
            this.raidCountLabel.Size = new System.Drawing.Size(10, 13);
            this.raidCountLabel.TabIndex = 4;
            this.raidCountLabel.Text = "-";
            // 
            // goldChamberCountLabel
            // 
            this.goldChamberCountLabel.AutoSize = true;
            this.goldChamberCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.goldChamberCountLabel.Location = new System.Drawing.Point(127, 27);
            this.goldChamberCountLabel.Name = "goldChamberCountLabel";
            this.goldChamberCountLabel.Size = new System.Drawing.Size(10, 13);
            this.goldChamberCountLabel.TabIndex = 3;
            this.goldChamberCountLabel.Text = "-";
            // 
            // arenaCountLabel
            // 
            this.arenaCountLabel.AutoSize = true;
            this.arenaCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.arenaCountLabel.Location = new System.Drawing.Point(44, 62);
            this.arenaCountLabel.Name = "arenaCountLabel";
            this.arenaCountLabel.Size = new System.Drawing.Size(10, 13);
            this.arenaCountLabel.TabIndex = 2;
            this.arenaCountLabel.Text = "-";
            // 
            // adventureCountLabel
            // 
            this.adventureCountLabel.AutoSize = true;
            this.adventureCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.adventureCountLabel.Location = new System.Drawing.Point(44, 28);
            this.adventureCountLabel.Name = "adventureCountLabel";
            this.adventureCountLabel.Size = new System.Drawing.Size(10, 13);
            this.adventureCountLabel.TabIndex = 1;
            this.adventureCountLabel.Text = "-";
            // 
            // arenaKeysLabel
            // 
            this.arenaKeysLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arenaKeysLabel.AutoSize = true;
            this.arenaKeysLabel.ForeColor = System.Drawing.Color.Blue;
            this.arenaKeysLabel.Location = new System.Drawing.Point(36, 69);
            this.arenaKeysLabel.Name = "arenaKeysLabel";
            this.arenaKeysLabel.Size = new System.Drawing.Size(10, 13);
            this.arenaKeysLabel.TabIndex = 10;
            this.arenaKeysLabel.Text = "-";
            // 
            // adventureKeyPictureBox
            // 
            this.adventureKeyPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_key_adventure;
            this.adventureKeyPictureBox.Location = new System.Drawing.Point(11, 15);
            this.adventureKeyPictureBox.Name = "adventureKeyPictureBox";
            this.adventureKeyPictureBox.Size = new System.Drawing.Size(19, 18);
            this.adventureKeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adventureKeyPictureBox.TabIndex = 0;
            this.adventureKeyPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.adventureKeyPictureBox, "Adventure Keys");
            // 
            // arenaKeyPictureBox
            // 
            this.arenaKeyPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_key_arena;
            this.arenaKeyPictureBox.Location = new System.Drawing.Point(11, 66);
            this.arenaKeyPictureBox.Name = "arenaKeyPictureBox";
            this.arenaKeyPictureBox.Size = new System.Drawing.Size(19, 18);
            this.arenaKeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arenaKeyPictureBox.TabIndex = 2;
            this.arenaKeyPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.arenaKeyPictureBox, "Arena Keys");
            // 
            // towerKeysLabel
            // 
            this.towerKeysLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.towerKeysLabel.AutoSize = true;
            this.towerKeysLabel.ForeColor = System.Drawing.Color.Blue;
            this.towerKeysLabel.Location = new System.Drawing.Point(36, 43);
            this.towerKeysLabel.Name = "towerKeysLabel";
            this.towerKeysLabel.Size = new System.Drawing.Size(10, 13);
            this.towerKeysLabel.TabIndex = 9;
            this.towerKeysLabel.Text = "-";
            // 
            // towerKeyPictureBox
            // 
            this.towerKeyPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_key_tower;
            this.towerKeyPictureBox.Location = new System.Drawing.Point(11, 40);
            this.towerKeyPictureBox.Name = "towerKeyPictureBox";
            this.towerKeyPictureBox.Size = new System.Drawing.Size(19, 18);
            this.towerKeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.towerKeyPictureBox.TabIndex = 1;
            this.towerKeyPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.towerKeyPictureBox, "Tower Keys");
            // 
            // adventureKeysLabel
            // 
            this.adventureKeysLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.adventureKeysLabel.AutoSize = true;
            this.adventureKeysLabel.ForeColor = System.Drawing.Color.Blue;
            this.adventureKeysLabel.Location = new System.Drawing.Point(36, 18);
            this.adventureKeysLabel.Name = "adventureKeysLabel";
            this.adventureKeysLabel.Size = new System.Drawing.Size(10, 13);
            this.adventureKeysLabel.TabIndex = 8;
            this.adventureKeysLabel.Text = "-";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(396, 506);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(102, 27);
            this.saveSettingsButton.TabIndex = 5;
            this.saveSettingsButton.Text = "Save Settings";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // Event
            // 
            this.Event.Name = "Event";
            // 
            // Time
            // 
            this.Time.Name = "Time";
            // 
            // Details
            // 
            this.Details.Name = "Details";
            // 
            // topheaderPictureBox
            // 
            this.topheaderPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topheaderPictureBox.Image = global::SevenKnightsAI.Properties.Resources.TitleSeason2;
            this.topheaderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.topheaderPictureBox.Name = "topheaderPictureBox";
            this.topheaderPictureBox.Size = new System.Drawing.Size(504, 80);
            this.topheaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topheaderPictureBox.TabIndex = 0;
            this.topheaderPictureBox.TabStop = false;
            // 
            // topazPictureBox
            // 
            this.topazPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_topaz;
            this.topazPictureBox.Location = new System.Drawing.Point(396, 3);
            this.topazPictureBox.Name = "topazPictureBox";
            this.topazPictureBox.Size = new System.Drawing.Size(19, 18);
            this.topazPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topazPictureBox.TabIndex = 11;
            this.topazPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.topazPictureBox, "Topaz");
            // 
            // honorPictureBox
            // 
            this.honorPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_honor;
            this.honorPictureBox.Location = new System.Drawing.Point(285, 3);
            this.honorPictureBox.Name = "honorPictureBox";
            this.honorPictureBox.Size = new System.Drawing.Size(19, 18);
            this.honorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.honorPictureBox.TabIndex = 2;
            this.honorPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.honorPictureBox, "Honor");
            // 
            // rubyPictureBox
            // 
            this.rubyPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_ruby;
            this.rubyPictureBox.Location = new System.Drawing.Point(174, 3);
            this.rubyPictureBox.Name = "rubyPictureBox";
            this.rubyPictureBox.Size = new System.Drawing.Size(19, 18);
            this.rubyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rubyPictureBox.TabIndex = 1;
            this.rubyPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.rubyPictureBox, "Ruby");
            // 
            // goldPictureBox
            // 
            this.goldPictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_gold;
            this.goldPictureBox.Location = new System.Drawing.Point(63, 3);
            this.goldPictureBox.Name = "goldPictureBox";
            this.goldPictureBox.Size = new System.Drawing.Size(19, 18);
            this.goldPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goldPictureBox.TabIndex = 0;
            this.goldPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.goldPictureBox, "Gold");
            // 
            // topazLabel
            // 
            this.topazLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.topazLabel.AutoSize = true;
            this.topazLabel.ForeColor = System.Drawing.Color.White;
            this.topazLabel.Location = new System.Drawing.Point(421, 5);
            this.topazLabel.Name = "topazLabel";
            this.topazLabel.Size = new System.Drawing.Size(10, 13);
            this.topazLabel.TabIndex = 13;
            this.topazLabel.Text = "-";
            // 
            // honorLabel
            // 
            this.honorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.honorLabel.AutoSize = true;
            this.honorLabel.ForeColor = System.Drawing.Color.White;
            this.honorLabel.Location = new System.Drawing.Point(310, 5);
            this.honorLabel.Name = "honorLabel";
            this.honorLabel.Size = new System.Drawing.Size(10, 13);
            this.honorLabel.TabIndex = 10;
            this.honorLabel.Text = "-";
            // 
            // rubyLabel
            // 
            this.rubyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rubyLabel.AutoSize = true;
            this.rubyLabel.ForeColor = System.Drawing.Color.White;
            this.rubyLabel.Location = new System.Drawing.Point(199, 5);
            this.rubyLabel.Name = "rubyLabel";
            this.rubyLabel.Size = new System.Drawing.Size(10, 13);
            this.rubyLabel.TabIndex = 9;
            this.rubyLabel.Text = "-";
            // 
            // goldLabel
            // 
            this.goldLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.goldLabel.AutoSize = true;
            this.goldLabel.ForeColor = System.Drawing.Color.White;
            this.goldLabel.Location = new System.Drawing.Point(88, 5);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(10, 13);
            this.goldLabel.TabIndex = 8;
            this.goldLabel.Text = "-";
            // 
            // resourcesTableLayoutPanel
            // 
            this.resourcesTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.resourcesTableLayoutPanel.ColumnCount = 9;
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resourcesTableLayoutPanel.Controls.Add(this.topazLabel, 8, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.goldPictureBox, 1, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.honorLabel, 6, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.topazPictureBox, 7, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.goldLabel, 2, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.rubyPictureBox, 3, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.rubyLabel, 4, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.honorPictureBox, 5, 0);
            this.resourcesTableLayoutPanel.Location = new System.Drawing.Point(0, 421);
            this.resourcesTableLayoutPanel.Name = "resourcesTableLayoutPanel";
            this.resourcesTableLayoutPanel.RowCount = 1;
            this.resourcesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resourcesTableLayoutPanel.Size = new System.Drawing.Size(504, 24);
            this.resourcesTableLayoutPanel.TabIndex = 7;
            // 
            // aiPause
            // 
            this.aiPause.Enabled = false;
            this.aiPause.Location = new System.Drawing.Point(396, 485);
            this.aiPause.Name = "aiPause";
            this.aiPause.Size = new System.Drawing.Size(102, 21);
            this.aiPause.TabIndex = 8;
            this.aiPause.Text = "&Pause";
            this.aiPause.UseVisualStyleBackColor = true;
            this.aiPause.Click += new System.EventHandler(this.aiPause_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.adventureKeyPictureBox);
            this.groupBox2.Controls.Add(this.adventureKeysLabel);
            this.groupBox2.Controls.Add(this.towerKeyPictureBox);
            this.groupBox2.Controls.Add(this.towerKeysLabel);
            this.groupBox2.Controls.Add(this.arenaKeyPictureBox);
            this.groupBox2.Controls.Add(this.arenaKeysLabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 445);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 90);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // MainForm
            // 
            this.AcceptButton = this.aiButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(504, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.aiPause);
            this.Controls.Add(this.resourcesTableLayoutPanel);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.aiButton);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.topheaderPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seven Knights AI Black";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.adventureTab.ResumeLayout(false);
            this.adventureTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AD_limitNumericBox)).EndInit();
            this.AD_mainPanel.ResumeLayout(false);
            this.AD_mainPanel.PerformLayout();
            this.AD_formationPanel.ResumeLayout(false);
            this.AD_formationPanel.PerformLayout();
            this.AD_skillGroupBox.ResumeLayout(false);
            this.AD_skillGroupBox.PerformLayout();
            this.AD_wave3Panel.ResumeLayout(false);
            this.AD_wave2Panel.ResumeLayout(false);
            this.AD_wave1Panel.ResumeLayout(false);
            this.goldChamberTab.ResumeLayout(false);
            this.goldChamberTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_limitNumericBox)).EndInit();
            this.GC_mainPanel.ResumeLayout(false);
            this.GC_mainPanel.PerformLayout();
            this.GC_skillGroupBox.ResumeLayout(false);
            this.GC_skillGroupBox.PerformLayout();
            this.GC_wave2Panel.ResumeLayout(false);
            this.GC_wave1Panel.ResumeLayout(false);
            this.GC_formationPanel.ResumeLayout(false);
            this.GC_formationPanel.PerformLayout();
            this.specialDungeonTab.ResumeLayout(false);
            this.specialDungeonTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_limitNumericBox)).EndInit();
            this.karinGroupBox.ResumeLayout(false);
            this.karinGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_karinLimitNumericBox)).EndInit();
            this.evanGroupBox.ResumeLayout(false);
            this.evanGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_evanLimitNumericBox)).EndInit();
            this.crystalGroupBox.ResumeLayout(false);
            this.crystalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_crystalLimitNumericBox)).EndInit();
            this.cakeGroupBox.ResumeLayout(false);
            this.cakeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_cakeLimitNumericBox)).EndInit();
            this.dailyGroupBox.ResumeLayout(false);
            this.dailyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_dailyLimitNumericBox)).EndInit();
            this.SP_skillGroupBox.ResumeLayout(false);
            this.SP_skillGroupBox.PerformLayout();
            this.SP_wave3Panel.ResumeLayout(false);
            this.SP_wave2Panel.ResumeLayout(false);
            this.SP_wave1Panel.ResumeLayout(false);
            this.arenaTab.ResumeLayout(false);
            this.arenaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AR_limitNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AR_useRubyNumericBox)).EndInit();
            this.AR_mainPanel.ResumeLayout(false);
            this.AR_skillGroupBox.ResumeLayout(false);
            this.AR_skillGroupBox.PerformLayout();
            this.raidTab.ResumeLayout(false);
            this.raidTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RD_RoundNumericUpDown)).EndInit();
            this.RD_mainPanel.ResumeLayout(false);
            this.RD_mainPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonLVLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonHPLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RD_DragonHP)).EndInit();
            this.RD_skillGroupBox.ResumeLayout(false);
            this.RD_skillGroupBox.PerformLayout();
            this.RD_team2Panel.ResumeLayout(false);
            this.RD_team1Panel.ResumeLayout(false);
            this.resourcesTab.ResumeLayout(false);
            this.RS_collectQuestsGroupBox.ResumeLayout(false);
            this.RS_collectQuestsGroupBox.PerformLayout();
            this.RS_sendHonorsGroupBox.ResumeLayout(false);
            this.RS_sendHonorsGroupBox.PerformLayout();
            this.RS_buyKeysGroupBox.ResumeLayout(false);
            this.RS_buyKeysGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyRubiesNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyHonorsNumericBox)).EndInit();
            this.RS_inboxGroupBox.ResumeLayout(false);
            this.RS_inboxGroupBox.PerformLayout();
            this.RS_sellingGroupBox.ResumeLayout(false);
            this.RS_sellingGroupBox.PerformLayout();
            this.RS_itemRadioPanel.ResumeLayout(false);
            this.RS_itemRadioPanel.PerformLayout();
            this.RS_heroRadioPanel.ResumeLayout(false);
            this.RS_heroRadioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_itemAmountNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_heroAmountNumericBox)).EndInit();
            this.RS_giftsGroupBox.ResumeLayout(false);
            this.RS_giftsGroupBox.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ST_blueStacksGroupBox.ResumeLayout(false);
            this.ST_blueStacksGroupBox.PerformLayout();
            this.ST_profileGroupBox.ResumeLayout(false);
            this.ST_profileGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ST_reconnectNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_opacityTrackBar)).EndInit();
            this.ST_pushbulletGroupBox.ResumeLayout(false);
            this.ST_pushbulletGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ST_pushbulletPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_delayTrackBar)).EndInit();
            this.logTab.ResumeLayout(false);
            this.logTab.PerformLayout();
            this.LG_logPanel.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raidPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldChamberPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventurePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureKeyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenaKeyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.towerKeyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topheaderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topazPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldPictureBox)).EndInit();
            this.resourcesTableLayoutPanel.ResumeLayout(false);
            this.resourcesTableLayoutPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		
		private global::System.Windows.Forms.ToolStripStatusLabel adminToolStripLabel;

		
		private global::System.Windows.Forms.Label adventureCountLabel;

		
		private global::System.Windows.Forms.PictureBox adventureKeyPictureBox;

		
		private global::System.Windows.Forms.Label adventureKeysLabel;

		
		private global::System.Windows.Forms.PictureBox adventurePictureBox;

		
		private global::System.Windows.Forms.TabPage adventureTab;

		
		private global::System.Windows.Forms.RadioButton AD_autoSkillRadio;

		
		private global::System.Windows.Forms.RadioButton AD_bothSkillRadio;

		
		private global::System.Windows.Forms.CheckBox AD_continuousCheckBox;

		
		private global::System.Windows.Forms.ComboBox AD_difficultyComboBox;

		
		private global::System.Windows.Forms.Label AD_difficultyLabel;

		
		private global::System.Windows.Forms.CheckBox AD_elementHeroesCheckBox;

		
		private global::System.Windows.Forms.CheckBox AD_enableCheckBox;

		
		private global::System.Windows.Forms.ComboBox AD_formationComboBox;

		
		private global::System.Windows.Forms.Label AD_formationLabel;

		
		private global::System.Windows.Forms.Panel AD_formationPanel;

		
		private global::System.Windows.Forms.CheckBox AD_limitCheckBox;

		
		private global::System.Windows.Forms.Label AD_limitLabel;

		
		private global::System.Windows.Forms.NumericUpDown AD_limitNumericBox;

		
		private global::System.Windows.Forms.Panel AD_mainPanel;

		
		private global::System.Windows.Forms.Label AD_manageHeroHelpLabel;

		
		private global::System.Windows.Forms.RadioButton AD_manualSkillRadio;

		
		private global::System.Windows.Forms.ComboBox AD_masteryComboBox;

		
		private global::System.Windows.Forms.Label AD_masteryLabel;

		
		private global::System.Windows.Forms.CheckBox AD_pos1CheckBox;

		
		private global::System.Windows.Forms.CheckBox AD_pos2CheckBox;

		
		private global::System.Windows.Forms.CheckBox AD_pos3CheckBox;

		
		private global::System.Windows.Forms.CheckBox AD_pos4CheckBox;

		
		private global::System.Windows.Forms.CheckBox AD_pos5CheckBox;

		
		private global::System.Windows.Forms.Button AD_sequenceButton;

		
		private global::System.Windows.Forms.GroupBox AD_skillGroupBox;

		
		private global::System.Windows.Forms.ComboBox AD_stageComboBox;

		
		private global::System.Windows.Forms.Label AD_stageLabel;

		
		private global::System.Windows.Forms.ComboBox AD_teamComboBox;

		
		private global::System.Windows.Forms.Label AD_teamLabel;

		
		private global::System.Windows.Forms.Button AD_w1Skill01Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill02Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill03Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill04Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill05Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill06Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill07Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill08Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill09Button;

		
		private global::System.Windows.Forms.Button AD_w1Skill10Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill01Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill02Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill03Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill04Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill05Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill06Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill07Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill08Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill09Button;

		
		private global::System.Windows.Forms.Button AD_w2Skill10Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill01Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill02Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill03Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill04Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill05Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill06Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill07Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill08Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill09Button;

		
		private global::System.Windows.Forms.Button AD_w3Skill10Button;

		
		private global::System.Windows.Forms.Label AD_wave1Label;

		
		private global::System.Windows.Forms.CheckBox AD_wave1LoopCheckBox;

		
		private global::System.Windows.Forms.Panel AD_wave1Panel;

		
		private global::System.Windows.Forms.Label AD_wave2Label;

		
		private global::System.Windows.Forms.CheckBox AD_wave2LoopCheckBox;

		
		private global::System.Windows.Forms.Panel AD_wave2Panel;

		
		private global::System.Windows.Forms.Label AD_wave3Label;

		
		private global::System.Windows.Forms.CheckBox AD_wave3LoopCheckBox;

		
		private global::System.Windows.Forms.Panel AD_wave3Panel;

		
		private global::System.Windows.Forms.ComboBox AD_worldComboBox;

		
		private global::System.Windows.Forms.Label AD_worldLabel;

		
		private global::System.Windows.Forms.Button aiButton;

		
		private global::System.Windows.Forms.Label arenaCountLabel;

		
		private global::System.Windows.Forms.PictureBox arenaKeyPictureBox;

		
		private global::System.Windows.Forms.Label arenaKeysLabel;

		
		private global::System.Windows.Forms.PictureBox arenaPictureBox;

		
		private global::System.Windows.Forms.TabPage arenaTab;

		
		private global::System.Windows.Forms.CheckBox AR_enableCheckBox;

		
		private global::System.Windows.Forms.CheckBox AR_limitCheckBox;

		
		private global::System.Windows.Forms.Label AR_limitLabel;

		
		private global::System.Windows.Forms.NumericUpDown AR_limitNumericBox;

		
		private global::System.Windows.Forms.Panel AR_mainPanel;

		
		private global::System.Windows.Forms.ComboBox AR_masteryComboBox;

		
		private global::System.Windows.Forms.Label AR_masteryLabel;

		
		private global::System.Windows.Forms.GroupBox AR_skillGroupBox;

		
		private global::System.Windows.Forms.CheckBox AR_useRubyCheckBox;

		
		private global::System.Windows.Forms.Label AR_useRubyLabel;

		
		private global::System.Windows.Forms.NumericUpDown AR_useRubyNumericBox;

		
		private global::System.ComponentModel.IContainer components;


		
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Details;

		
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Event;

		
		private global::System.Windows.Forms.RadioButton GC_autoSkillRadio;

		
		private global::System.Windows.Forms.RadioButton GC_bothSkillRadio;

		
		private global::System.Windows.Forms.CheckBox GC_enableCheckBox;

		
		private global::System.Windows.Forms.ComboBox GC_formationComboBox;

		
		private global::System.Windows.Forms.Label GC_formationLabel;

		
		private global::System.Windows.Forms.Panel GC_formationPanel;

		
		private global::System.Windows.Forms.CheckBox GC_limitCheckBox;

		
		private global::System.Windows.Forms.Label GC_limitLabel;

		
		private global::System.Windows.Forms.NumericUpDown GC_limitNumericBox;

		
		private global::System.Windows.Forms.Panel GC_mainPanel;

		
		private global::System.Windows.Forms.RadioButton GC_manualSkillRadio;

		
		private global::System.Windows.Forms.ComboBox GC_masteryComboBox;

		
		private global::System.Windows.Forms.Label GC_masteryLabel;

		
		private global::System.Windows.Forms.CheckBox GC_pos1CheckBox;

		
		private global::System.Windows.Forms.CheckBox GC_pos2CheckBox;

		
		private global::System.Windows.Forms.CheckBox GC_pos3CheckBox;

		
		private global::System.Windows.Forms.CheckBox GC_pos4CheckBox;

		
		private global::System.Windows.Forms.CheckBox GC_pos5CheckBox;

		
		private global::System.Windows.Forms.GroupBox GC_skillGroupBox;

		
		private global::System.Windows.Forms.ComboBox GC_teamComboBox;

		
		private global::System.Windows.Forms.Label GC_teamLabel;

		
		private global::System.Windows.Forms.Button GC_w1Skill01Button;

		
		private global::System.Windows.Forms.Button GC_w1Skill02Button;

		
		private global::System.Windows.Forms.Button GC_w1Skill03Button;

		
		private global::System.Windows.Forms.Button GC_w1Skill04Button;

		
		private global::System.Windows.Forms.Button GC_w1Skill05Button;

		
		private global::System.Windows.Forms.Button GC_w1Skill06Button;

		
		private global::System.Windows.Forms.Button GC_w1Skill07Button;

		
		private global::System.Windows.Forms.Button GC_w1Skill08Button;

		
		private global::System.Windows.Forms.Button GC_w1Skill09Button;

		
		private global::System.Windows.Forms.Button GC_w1Skill10Button;

		
		private global::System.Windows.Forms.Button GC_w2Skill01Button;

		
		private global::System.Windows.Forms.Button GC_w2Skill02Button;

		
		private global::System.Windows.Forms.Button GC_w2Skill03Button;

		
		private global::System.Windows.Forms.Button GC_w2Skill04Button;

		
		private global::System.Windows.Forms.Button GC_w2Skill05Button;

		
		private global::System.Windows.Forms.Button GC_w2Skill06Button;

		
		private global::System.Windows.Forms.Button GC_w2Skill07Button;

		
		private global::System.Windows.Forms.Button GC_w2Skill08Button;

		
		private global::System.Windows.Forms.Button GC_w2Skill09Button;

		
		private global::System.Windows.Forms.Button GC_w2Skill10Button;

		
		private global::System.Windows.Forms.Label GC_wave1Label;

		
		private global::System.Windows.Forms.CheckBox GC_wave1LoopCheckBox;

		
		private global::System.Windows.Forms.Panel GC_wave1Panel;

		
		private global::System.Windows.Forms.Label GC_wave2Label;

		
		private global::System.Windows.Forms.CheckBox GC_wave2LoopCheckBox;

		
		private global::System.Windows.Forms.Panel GC_wave2Panel;

		
		private global::System.Windows.Forms.Label goldChamberCountLabel;

		
		private global::System.Windows.Forms.PictureBox goldChamberPictureBox;

		
		private global::System.Windows.Forms.TabPage goldChamberTab;

		
		private global::System.Windows.Forms.Label goldLabel;

		
		private global::System.Windows.Forms.PictureBox goldPictureBox;

		
		private global::System.Windows.Forms.Label honorLabel;

		
		private global::System.Windows.Forms.PictureBox honorPictureBox;


		
		private global::System.Windows.Forms.Button LG_clearButton;

		
		private global::System.Windows.Forms.Button LG_exportButton;

		
		private global::System.Windows.Forms.Panel LG_logPanel;

		
		private global::System.Windows.Forms.RichTextBox LG_logTextBox;

		
		private global::System.Windows.Forms.CheckBox LG_scrollCheckBox;

		
		private global::System.Windows.Forms.TabPage logTab;

		
		private global::System.Windows.Forms.ToolStripStatusLabel profileToolStripLabel;

		
		private global::System.Windows.Forms.Label raidCountLabel;

		
		private global::System.Windows.Forms.PictureBox raidPictureBox;

		
		private global::System.Windows.Forms.TabPage raidTab;

		
		private global::System.Windows.Forms.RadioButton RD_autoSkillRadio;

		
		private global::System.Windows.Forms.RadioButton RD_bothSkillRadio;

		
		private global::System.Windows.Forms.CheckBox RD_enableCheckBox;




		
		private global::System.Windows.Forms.Panel RD_mainPanel;

		
		private global::System.Windows.Forms.RadioButton RD_manualSkillRadio;

		
		private global::System.Windows.Forms.GroupBox RD_skillGroupBox;

		
		private global::System.Windows.Forms.Button RD_t1Skill01Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill02Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill03Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill04Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill05Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill06Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill07Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill08Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill09Button;

		
		private global::System.Windows.Forms.Button RD_t1Skill10Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill01Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill02Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill03Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill04Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill05Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill06Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill07Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill08Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill09Button;

		
		private global::System.Windows.Forms.Button RD_t2Skill10Button;

		
		private global::System.Windows.Forms.Label RD_team1Label;

		
		private global::System.Windows.Forms.CheckBox RD_team1LoopCheckBox;

		
		private global::System.Windows.Forms.Panel RD_team1Panel;

		
		private global::System.Windows.Forms.Label RD_team2Label;

		
		private global::System.Windows.Forms.CheckBox RD_team2LoopCheckBox;

		
		private global::System.Windows.Forms.Panel RD_team2Panel;

		
		private global::System.Windows.Forms.TabPage resourcesTab;

		
		private global::System.Windows.Forms.TableLayoutPanel resourcesTableLayoutPanel;

		
		private global::System.Windows.Forms.CheckBox RS_buyKeyHonorsCheckBox;

		
		private global::System.Windows.Forms.ComboBox RS_buyKeyHonorsComboBox;

		
		private global::System.Windows.Forms.Label RS_buyKeyHonorsLabel;

		
		private global::System.Windows.Forms.NumericUpDown RS_buyKeyHonorsNumericBox;

		
		private global::System.Windows.Forms.CheckBox RS_buyKeyRubiesCheckBox;

		
		private global::System.Windows.Forms.ComboBox RS_buyKeyRubiesComboBox;

		
		private global::System.Windows.Forms.Label RS_buyKeyRubiesLabel;

		
		private global::System.Windows.Forms.NumericUpDown RS_buyKeyRubiesNumericBox;

		
		private global::System.Windows.Forms.GroupBox RS_buyKeysGroupBox;

		
		private global::System.Windows.Forms.GroupBox RS_collectQuestsGroupBox;

		
		private global::System.Windows.Forms.GroupBox RS_giftsGroupBox;

		
		private global::System.Windows.Forms.RadioButton RS_heroAllRadioButton;

		
		private global::System.Windows.Forms.NumericUpDown RS_heroAmountNumericBox;

		
		private global::System.Windows.Forms.RadioButton RS_heroAmountRadioButton;

		
		private global::System.Windows.Forms.Panel RS_heroRadioPanel;

		
		private global::System.Windows.Forms.ComboBox RS_heroStarsComboBox;

		
		private global::System.Windows.Forms.CheckBox RS_inboxGold;

		
		private global::System.Windows.Forms.GroupBox RS_inboxGroupBox;

		
		private global::System.Windows.Forms.CheckBox RS_inboxHonors;

		
		private global::System.Windows.Forms.CheckBox RS_inboxKeys;

		
		private global::System.Windows.Forms.CheckBox RS_inboxRubies;

		
		private global::System.Windows.Forms.CheckBox RS_inboxTickets;

		
		private global::System.Windows.Forms.RadioButton RS_itemAllRadioButton;

		
		private global::System.Windows.Forms.NumericUpDown RS_itemAmountNumericBox;

		
		private global::System.Windows.Forms.RadioButton RS_itemAmountRadioButton;

		
		private global::System.Windows.Forms.Panel RS_itemRadioPanel;

		
		private global::System.Windows.Forms.ComboBox RS_itemStarsComboBox;

		
		private global::System.Windows.Forms.CheckBox RS_luckyBoxCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_luckyChestCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_questsBattleCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_questsHeroCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_questsItemCheckBox;

		
		private global::System.Windows.Forms.Label RS_questsNormalLabel;

		
		private global::System.Windows.Forms.CheckBox RS_questsSocialCheckBox;

		
		private global::System.Windows.Forms.Label RS_questsSpecialLabel;

		
		private global::System.Windows.Forms.CheckBox RS_sellHeroesCheckBox;

		
		private global::System.Windows.Forms.GroupBox RS_sellingGroupBox;

		
		private global::System.Windows.Forms.CheckBox RS_sellItemsCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_sendHonorsFacebook;

		
		private global::System.Windows.Forms.GroupBox RS_sendHonorsGroupBox;

		
		private global::System.Windows.Forms.CheckBox RS_sendHonorsInGame;

		
		private global::System.Windows.Forms.CheckBox RS_specialQuestsDailyCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_specialQuestsMonthlyCheckBox;

		
		private global::System.Windows.Forms.CheckBox RS_specialQuestsWeeklyCheckBox;

		
		private global::System.Windows.Forms.Label rubyLabel;

		
		private global::System.Windows.Forms.PictureBox rubyPictureBox;

		
		private global::System.Windows.Forms.Button saveSettingsButton;

		
		private global::System.Windows.Forms.TabPage settingsTab;

		
		private global::System.Windows.Forms.ToolStripStatusLabel splitterStatusLabel;

		
		private global::System.Windows.Forms.StatusStrip statusStrip;

		
		private global::System.Windows.Forms.ToolStripStatusLabel statusToolStripLabel;

		
		private global::System.Windows.Forms.GroupBox ST_blueStacksGroupBox;

		
		private global::System.Windows.Forms.ComboBox ST_currentProfileComboBox;

		
		private global::System.Windows.Forms.Label ST_currentProfileLabel;

		
		private global::System.Windows.Forms.Label ST_delayLabel;

		
		private global::System.Windows.Forms.TrackBar ST_delayTrackBar;

		
		private global::System.Windows.Forms.Label ST_delayValueLabel;

		
		private global::System.Windows.Forms.CheckBox ST_forceActiveCheckBox;

		
		private global::System.Windows.Forms.CheckBox ST_foregroundMode;

		
		private global::System.Windows.Forms.CheckBox ST_hotTimeProfileCheckBox;

		
		private global::System.Windows.Forms.ComboBox ST_hotTimeProfileComboBox;

		
		private global::System.Windows.Forms.Button ST_manageProfileButton;

		
		private global::System.Windows.Forms.Label ST_opacityLabel;

		
		private global::System.Windows.Forms.TrackBar ST_opacityTrackBar;

		
		private global::System.Windows.Forms.GroupBox ST_profileGroupBox;

		
		private global::System.Windows.Forms.CheckBox ST_pushbulletCheckBox;

		
		private global::System.Windows.Forms.Label ST_pushbulletEmailLabel;

		
		private global::System.Windows.Forms.TextBox ST_pushbulletEmailTextBox;

		
		private global::System.Windows.Forms.GroupBox ST_pushbulletGroupBox;

		
		private global::System.Windows.Forms.Label ST_pushbulletHintLabel;

		
		private global::System.Windows.Forms.PictureBox ST_pushbulletPictureBox;

		
		private global::System.Windows.Forms.CheckBox ST_reconnectInterruptCheckBox;

		
		private global::System.Windows.Forms.NumericUpDown ST_reconnectNumericUpDown;

		
		private global::System.Windows.Forms.Button ST_toggleBlueStacksButton;

		
		private global::System.Windows.Forms.GroupBox summaryGroupBox;

		
		private global::System.Windows.Forms.TabControl tabControl;

		
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Time;

		
		private global::System.Windows.Forms.ToolTip toolTip;

		
		private global::System.Windows.Forms.Label topazLabel;

		
		private global::System.Windows.Forms.PictureBox topazPictureBox;

		
		private global::System.Windows.Forms.PictureBox topheaderPictureBox;

		
		private global::System.Windows.Forms.PictureBox towerKeyPictureBox;

		
		private global::System.Windows.Forms.Label towerKeysLabel;
        private System.Windows.Forms.Button aiPause;
        private System.Windows.Forms.ToolStripStatusLabel tsPixel;
        private System.Windows.Forms.Button LG_LogPixel;
        private System.Windows.Forms.CheckBox GB_WaitForKeys;
		private System.Windows.Forms.ToolStripStatusLabel tsslCursorPosition;
		private System.Windows.Forms.Label RD_DragonLimit_lbl;
		private System.Windows.Forms.CheckBox RD_DragonLimitCheckBox;
		private System.Windows.Forms.CheckBox AD_StopOnFullHeroes_Checkbox;
        private System.Windows.Forms.Button LG_SaveScreen;
        private System.Windows.Forms.Label HeroCountLabel;
        private System.Windows.Forms.CheckBox AD_CheckingHeroes_Checkbox;
		private System.Windows.Forms.ToolStripStatusLabel tsslBuildInfo;
        private System.Windows.Forms.ComboBox AD_difficultyComboBox2nd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AD_StopOnFullItems_Checkbox;
        private System.Windows.Forms.CheckBox ST_AutoProfileCheckBox;
        private System.Windows.Forms.CheckBox AD_StopOnLV30_Checkbox;
        private System.Windows.Forms.CheckBox RD_StopOnDragonFound_Checkbox;
        private System.Windows.Forms.ComboBox RD_masteryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ARD_enableCheckBox;
        private System.Windows.Forms.CheckBox AD_EnHottime_Checkbox;
        private System.Windows.Forms.CheckBox AD_UseFriendCheckBox;
        private System.Windows.Forms.CheckBox GC_UseFriendCheckBox;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox RD_OwnerDragon;
        private System.Windows.Forms.NumericUpDown RD_DragonLV;
        private System.Windows.Forms.CheckBox RD_LevelCheckBox;
        private System.Windows.Forms.NumericUpDown RD_RoundNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RD_DragonHP;
        private System.Windows.Forms.NumericUpDown RD_DragonLVLimit;
        private System.Windows.Forms.NumericUpDown RD_DragonHPLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox AD_teamComboBox2;
        private System.Windows.Forms.TabPage specialDungeonTab;
        private System.Windows.Forms.GroupBox SP_skillGroupBox;
        private System.Windows.Forms.RadioButton SP_bothSkillRadio;
        private System.Windows.Forms.Panel SP_wave2Panel;
        private System.Windows.Forms.CheckBox SP_wave2LoopCheckBox;
        private System.Windows.Forms.Button SP_w2Skill10Button;
        private System.Windows.Forms.Button SP_w2Skill09Button;
        private System.Windows.Forms.Button SP_w2Skill08Button;
        private System.Windows.Forms.Button SP_w2Skill07Button;
        private System.Windows.Forms.Button SP_w2Skill06Button;
        private System.Windows.Forms.Button SP_w2Skill05Button;
        private System.Windows.Forms.Button SP_w2Skill04Button;
        private System.Windows.Forms.Button SP_w2Skill03Button;
        private System.Windows.Forms.Button SP_w2Skill02Button;
        private System.Windows.Forms.Label SP_wave2Label;
        private System.Windows.Forms.Button SP_w2Skill01Button;
        private System.Windows.Forms.RadioButton SP_manualSkillRadio;
        private System.Windows.Forms.RadioButton SP_autoSkillRadio;
        private System.Windows.Forms.Panel SP_wave1Panel;
        private System.Windows.Forms.CheckBox SP_wave1LoopCheckBox;
        private System.Windows.Forms.Button SP_w1Skill10Button;
        private System.Windows.Forms.Button SP_w1Skill09Button;
        private System.Windows.Forms.Button SP_w1Skill08Button;
        private System.Windows.Forms.Button SP_w1Skill07Button;
        private System.Windows.Forms.Button SP_w1Skill06Button;
        private System.Windows.Forms.Button SP_w1Skill05Button;
        private System.Windows.Forms.Button SP_w1Skill04Button;
        private System.Windows.Forms.Button SP_w1Skill03Button;
        private System.Windows.Forms.Button SP_w1Skill02Button;
        private System.Windows.Forms.Label SP_wave1Label;
        private System.Windows.Forms.Button SP_w1Skill01Button;
        private System.Windows.Forms.CheckBox SP_enableCheckBox;
        private System.Windows.Forms.RadioButton SP_dailyHardRadioButton;
        private System.Windows.Forms.RadioButton SP_dailyNomalRadioButton;
        private System.Windows.Forms.Panel SP_wave3Panel;
        private System.Windows.Forms.CheckBox SP_wave3LoopCheckBox;
        private System.Windows.Forms.Button SP_w3Skill10Button;
        private System.Windows.Forms.Button SP_w3Skill09Button;
        private System.Windows.Forms.Button SP_w3Skill08Button;
        private System.Windows.Forms.Button SP_w3Skill07Button;
        private System.Windows.Forms.Button SP_w3Skill06Button;
        private System.Windows.Forms.Button SP_w3Skill05Button;
        private System.Windows.Forms.Button SP_w3Skill04Button;
        private System.Windows.Forms.Button SP_w3Skill03Button;
        private System.Windows.Forms.Button SP_w3Skill02Button;
        private System.Windows.Forms.Label SP_wave3Label;
        private System.Windows.Forms.Button SP_w3Skill01Button;
        private System.Windows.Forms.RadioButton SP_dailyHellRadioButton;
        private System.Windows.Forms.GroupBox cakeGroupBox;
        private System.Windows.Forms.CheckBox SP_cakeCheckBox;
        private System.Windows.Forms.NumericUpDown SP_cakeLimitNumericBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox dailyGroupBox;
        private System.Windows.Forms.CheckBox SP_dailyCheckBox;
        private System.Windows.Forms.NumericUpDown SP_dailyLimitNumericBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox karinGroupBox;
        private System.Windows.Forms.CheckBox SP_karinCheckBox;
        private System.Windows.Forms.RadioButton SP_karinHellRadioButton;
        private System.Windows.Forms.NumericUpDown SP_karinLimitNumericBox;
        private System.Windows.Forms.RadioButton SP_karinHardRadioButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton SP_karinNorRadioButton;
        private System.Windows.Forms.GroupBox evanGroupBox;
        private System.Windows.Forms.CheckBox SP_evanCheckBox;
        private System.Windows.Forms.RadioButton SP_evanHellRadioButton;
        private System.Windows.Forms.NumericUpDown SP_evanLimitNumericBox;
        private System.Windows.Forms.RadioButton SP_evanHardRadioButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton SP_evanNorRadioButton;
        private System.Windows.Forms.GroupBox crystalGroupBox;
        private System.Windows.Forms.CheckBox SP_crystalCheckBox;
        private System.Windows.Forms.RadioButton SP_crystalHardRadioButton;
        private System.Windows.Forms.NumericUpDown SP_crystalLimitNumericBox;
        private System.Windows.Forms.RadioButton SP_crystalNorRadioButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton SP_crystalEasyRadioButton;
        private System.Windows.Forms.RadioButton SP_cakeHardRadioButton;
        private System.Windows.Forms.RadioButton SP_cakeNormalRadioButton;
        private System.Windows.Forms.RadioButton SP_cakeEasyRadioButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label testdayofweek;
        private System.Windows.Forms.Button AD_w3Skill15Button;
        private System.Windows.Forms.Button AD_w3Skill11Button;
        private System.Windows.Forms.Button AD_w3Skill12Button;
        private System.Windows.Forms.Button AD_w3Skill13Button;
        private System.Windows.Forms.Button AD_w3Skill14Button;
        private System.Windows.Forms.Button SP_w3Skill11Button;
        private System.Windows.Forms.Button SP_w3Skill12Button;
        private System.Windows.Forms.Button SP_w3Skill13Button;
        private System.Windows.Forms.Button SP_w3Skill14Button;
        private System.Windows.Forms.Button SP_w3Skill15Button;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown SP_limitNumericBox;
        private System.Windows.Forms.CheckBox SP_limitCheckBox;
    }
}
