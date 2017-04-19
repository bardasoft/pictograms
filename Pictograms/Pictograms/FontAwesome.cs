﻿#if !PORTABLE
namespace System.Drawing.Pictograms
#else

namespace Xamarin.Forms.Pictograms
#endif
{
    /// <summary>
    /// Font Awesome
    /// <see cref="http://fontawesome.io/"/>
    /// </summary>
    public class FontAwesome : Pictogram
    {
        #region Singleton

        /// <summary>
        /// Initializes the <see cref="Icon" /> class by loading the font from resources upon first use.
        /// </summary>
#if !PORTABLE
        private FontAwesome() : base(Properties.Resources.fontawesome_webfont)
#else

        private FontAwesome() : base()
#endif
        {
        }

        public static FontAwesome Instance
        {
            get
            {
                if (instance == null)
                    instance = new FontAwesome();
                return (FontAwesome)instance;
            }
        }

        #endregion Singleton

        public FontAwesome(bool @default) : this()
        {
        }

        public const string Typeface = "fontawesome-webfont";

#if PORTABLE

        public override string GetFontFace()
        {
            return FontAwesome.Typeface;
        }

#endif

        #region Statics

#if !PORTABLE
        public static Image GetImage(IconType type, int size, Brush brush)
        {
            return FontAwesome.Instance.GetImage((int)type, size, brush);
        }

        public static Image GetImage(IconType type, int size, Color color)
        {
            return FontAwesome.Instance.GetImage((int)type, size, color);
        }

        public static Image GetImage(IconType type, int size)
        {
            return FontAwesome.Instance.GetImage((int)type, size);
        }
#endif

        public static string GetText(IconType type)
        {
            return char.ConvertFromUtf32((int)type);
        }

#if !PORTABLE
        public static new Font GetFont(float size, GraphicsUnit units = GraphicsUnit.Point)
        {
            return new Font(FontAwesome.Instance.fonts.Families[0], size, units);
        }
#endif

        #endregion Statics

        /// <summary>
        /// Version 4.6.1
        /// </summary>
        public enum IconType : int
        {
            // 4.6.1 ->
            gitlab = 0xf296,

            wpbeginner = 0xf297,
            wpforms = 0xf298,
            envira = 0xf299,
            universal_access = 0xf29a,
            wheelchair_alt = 0xf29b,
            question_circle_o = 0xf29c,
            blind = 0xf29d,
            audio_description = 0xf29e,
            volume_control_phone = 0xf2a0,
            braille = 0xf2a1,
            assistive_listening_systems = 0xf2a2,
            asl_interpreting = 0xf2a3,
            american_sign_language_interpreting = asl_interpreting,
            deafness = 0xf2a4,
            hard_of_hearing = deafness,
            deaf = deafness,
            glide = 0xf2a5,
            glide_g = 0xf2a6,
            signing = 0xf2a7,
            sign_language = signing,
            low_vision = 0xf2a8,
            viadeo = 0xf2a9,
            viadeo_square = 0xf2aa,
            snapchat = 0xf2ab,
            snapchat_ghost = 0xf2ac,
            snapchat_square = 0xf2ad,

            // 4.6.1 <-
            glass = 0xf000,

            music = 0xf001,
            search = 0xf002,
            envelope_o = 0xf003,
            heart = 0xf004,
            star = 0xf005,
            star_o = 0xf006,
            user = 0xf007,
            film = 0xf008,
            th_large = 0xf009,
            th = 0xf00a,
            th_list = 0xf00b,
            check = 0xf00c,
            remove = times,
            close = times,
            times = 0xf00d,
            search_plus = 0xf00e,
            search_minus = 0xf010,
            power_off = 0xf011,
            signal = 0xf012,
            gear = cog,
            cog = 0xf013,
            trash_o = 0xf014,
            home = 0xf015,
            file_o = 0xf016,
            clock_o = 0xf017,
            road = 0xf018,
            download = 0xf019,
            arrow_circle_o_down = 0xf01a,
            arrow_circle_o_up = 0xf01b,
            inbox = 0xf01c,
            play_circle_o = 0xf01d,
            rotate_right = repeat,
            repeat = 0xf01e,
            refresh = 0xf021,
            list_alt = 0xf022,
            @lock = 0xf023,
            flag = 0xf024,
            headphones = 0xf025,
            volume_off = 0xf026,
            volume_down = 0xf027,
            volume_up = 0xf028,
            qrcode = 0xf029,
            barcode = 0xf02a,
            tag = 0xf02b,
            tags = 0xf02c,
            book = 0xf02d,
            bookmark = 0xf02e,
            print = 0xf02f,
            camera = 0xf030,
            font = 0xf031,
            bold = 0xf032,
            italic = 0xf033,
            text_height = 0xf034,
            text_width = 0xf035,
            align_left = 0xf036,
            align_center = 0xf037,
            align_right = 0xf038,
            align_justify = 0xf039,
            list = 0xf03a,
            dedent = outdent,
            outdent = 0xf03b,
            indent = 0xf03c,
            video_camera = 0xf03d,
            photo = picture_o,
            image = picture_o,
            picture_o = 0xf03e,
            pencil = 0xf040,
            map_marker = 0xf041,
            adjust = 0xf042,
            tint = 0xf043,
            edit = pencil_square_o,
            pencil_square_o = 0xf044,
            share_square_o = 0xf045,
            check_square_o = 0xf046,
            arrows = 0xf047,
            step_backward = 0xf048,
            fast_backward = 0xf049,
            backward = 0xf04a,
            play = 0xf04b,
            pause = 0xf04c,
            stop = 0xf04d,
            forward = 0xf04e,
            fast_forward = 0xf050,
            step_forward = 0xf051,
            eject = 0xf052,
            chevron_left = 0xf053,
            chevron_right = 0xf054,
            plus_circle = 0xf055,
            minus_circle = 0xf056,
            times_circle = 0xf057,
            check_circle = 0xf058,
            question_circle = 0xf059,
            info_circle = 0xf05a,
            crosshairs = 0xf05b,
            times_circle_o = 0xf05c,
            check_circle_o = 0xf05d,
            ban = 0xf05e,
            arrow_left = 0xf060,
            arrow_right = 0xf061,
            arrow_up = 0xf062,
            arrow_down = 0xf063,
            mail_forward = share,
            share = 0xf064,
            expand = 0xf065,
            compress = 0xf066,
            plus = 0xf067,
            minus = 0xf068,
            asterisk = 0xf069,
            exclamation_circle = 0xf06a,
            gift = 0xf06b,
            leaf = 0xf06c,
            fire = 0xf06d,
            eye = 0xf06e,
            eye_slash = 0xf070,
            warning = exclamation_triangle,
            exclamation_triangle = 0xf071,
            plane = 0xf072,
            calendar = 0xf073,
            random = 0xf074,
            comment = 0xf075,
            magnet = 0xf076,
            chevron_up = 0xf077,
            chevron_down = 0xf078,
            retweet = 0xf079,
            shopping_cart = 0xf07a,
            folder = 0xf07b,
            folder_open = 0xf07c,
            arrows_v = 0xf07d,
            arrows_h = 0xf07e,
            bar_chart_o = bar_chart,
            bar_chart = 0xf080,
            twitter_square = 0xf081,
            facebook_square = 0xf082,
            camera_retro = 0xf083,
            key = 0xf084,
            gears = cogs,
            cogs = 0xf085,
            comments = 0xf086,
            thumbs_o_up = 0xf087,
            thumbs_o_down = 0xf088,
            star_half = 0xf089,
            heart_o = 0xf08a,
            sign_out = 0xf08b,
            linkedin_square = 0xf08c,
            thumb_tack = 0xf08d,
            external_link = 0xf08e,
            sign_in = 0xf090,
            trophy = 0xf091,
            github_square = 0xf092,
            upload = 0xf093,
            lemon_o = 0xf094,
            phone = 0xf095,
            square_o = 0xf096,
            bookmark_o = 0xf097,
            phone_square = 0xf098,
            twitter = 0xf099,
            facebook_f = facebook,
            facebook = 0xf09a,
            github = 0xf09b,
            unlock = 0xf09c,
            credit_card = 0xf09d,
            feed = rss,
            rss = 0xf09e,
            hdd_o = 0xf0a0,
            bullhorn = 0xf0a1,
            bell = 0xf0f3,
            certificate = 0xf0a3,
            hand_o_right = 0xf0a4,
            hand_o_left = 0xf0a5,
            hand_o_up = 0xf0a6,
            hand_o_down = 0xf0a7,
            arrow_circle_left = 0xf0a8,
            arrow_circle_right = 0xf0a9,
            arrow_circle_up = 0xf0aa,
            arrow_circle_down = 0xf0ab,
            globe = 0xf0ac,
            wrench = 0xf0ad,
            tasks = 0xf0ae,
            filter = 0xf0b0,
            briefcase = 0xf0b1,
            arrows_alt = 0xf0b2,
            group = users,
            users = 0xf0c0,
            chain = link,
            link = 0xf0c1,
            cloud = 0xf0c2,
            flask = 0xf0c3,
            cut = scissors,
            scissors = 0xf0c4,
            copy = files_o,
            files_o = 0xf0c5,
            paperclip = 0xf0c6,
            save = floppy_o,
            floppy_o = 0xf0c7,
            square = 0xf0c8,
            navicon = bars,
            reorder = bars,
            bars = 0xf0c9,
            list_ul = 0xf0ca,
            list_ol = 0xf0cb,
            strikethrough = 0xf0cc,
            underline = 0xf0cd,
            table = 0xf0ce,
            magic = 0xf0d0,
            truck = 0xf0d1,
            pinterest = 0xf0d2,
            pinterest_square = 0xf0d3,
            google_plus_square = 0xf0d4,
            google_plus = 0xf0d5,
            money = 0xf0d6,
            caret_down = 0xf0d7,
            caret_up = 0xf0d8,
            caret_left = 0xf0d9,
            caret_right = 0xf0da,
            columns = 0xf0db,
            unsorted = sort,
            sort = 0xf0dc,
            sort_down = sort_desc,
            sort_desc = 0xf0dd,
            sort_up = sort_asc,
            sort_asc = 0xf0de,
            envelope = 0xf0e0,
            linkedin = 0xf0e1,
            rotate_left = undo,
            undo = 0xf0e2,
            legal = gavel,
            gavel = 0xf0e3,
            dashboard = tachometer,
            tachometer = 0xf0e4,
            comment_o = 0xf0e5,
            comments_o = 0xf0e6,
            flash = bolt,
            bolt = 0xf0e7,
            sitemap = 0xf0e8,
            umbrella = 0xf0e9,
            paste = clipboard,
            clipboard = 0xf0ea,
            lightbulb_o = 0xf0eb,
            exchange = 0xf0ec,
            cloud_download = 0xf0ed,
            cloud_upload = 0xf0ee,
            user_md = 0xf0f0,
            stethoscope = 0xf0f1,
            suitcase = 0xf0f2,
            bell_o = 0xf0a2,
            coffee = 0xf0f4,
            cutlery = 0xf0f5,
            file_text_o = 0xf0f6,
            building_o = 0xf0f7,
            hospital_o = 0xf0f8,
            ambulance = 0xf0f9,
            medkit = 0xf0fa,
            fighter_jet = 0xf0fb,
            beer = 0xf0fc,
            h_square = 0xf0fd,
            plus_square = 0xf0fe,
            angle_double_left = 0xf100,
            angle_double_right = 0xf101,
            angle_double_up = 0xf102,
            angle_double_down = 0xf103,
            angle_left = 0xf104,
            angle_right = 0xf105,
            angle_up = 0xf106,
            angle_down = 0xf107,
            desktop = 0xf108,
            laptop = 0xf109,
            tablet = 0xf10a,
            mobile_phone = mobile,
            mobile = 0xf10b,
            circle_o = 0xf10c,
            quote_left = 0xf10d,
            quote_right = 0xf10e,
            spinner = 0xf110,
            circle = 0xf111,
            mail_reply = reply,
            reply = 0xf112,
            github_alt = 0xf113,
            folder_o = 0xf114,
            folder_open_o = 0xf115,
            smile_o = 0xf118,
            frown_o = 0xf119,
            meh_o = 0xf11a,
            gamepad = 0xf11b,
            keyboard_o = 0xf11c,
            flag_o = 0xf11d,
            flag_checkered = 0xf11e,
            terminal = 0xf120,
            code = 0xf121,
            mail_reply_all = reply_all,
            reply_all = 0xf122,
            star_half_empty = star_half_o,
            star_half_full = star_half_o,
            star_half_o = 0xf123,
            location_arrow = 0xf124,
            crop = 0xf125,
            code_fork = 0xf126,
            unlink = chain_broken,
            chain_broken = 0xf127,
            question = 0xf128,
            info = 0xf129,
            exclamation = 0xf12a,
            superscript = 0xf12b,
            subscript = 0xf12c,
            eraser = 0xf12d,
            puzzle_piece = 0xf12e,
            microphone = 0xf130,
            microphone_slash = 0xf131,
            shield = 0xf132,
            calendar_o = 0xf133,
            fire_extinguisher = 0xf134,
            rocket = 0xf135,
            maxcdn = 0xf136,
            chevron_circle_left = 0xf137,
            chevron_circle_right = 0xf138,
            chevron_circle_up = 0xf139,
            chevron_circle_down = 0xf13a,
            html5 = 0xf13b,
            css3 = 0xf13c,
            anchor = 0xf13d,
            unlock_alt = 0xf13e,
            bullseye = 0xf140,
            ellipsis_h = 0xf141,
            ellipsis_v = 0xf142,
            rss_square = 0xf143,
            play_circle = 0xf144,
            ticket = 0xf145,
            minus_square = 0xf146,
            minus_square_o = 0xf147,
            level_up = 0xf148,
            level_down = 0xf149,
            check_square = 0xf14a,
            pencil_square = 0xf14b,
            external_link_square = 0xf14c,
            share_square = 0xf14d,
            compass = 0xf14e,
            toggle_down = caret_square_o_down,
            caret_square_o_down = 0xf150,
            toggle_up = caret_square_o_up,
            caret_square_o_up = 0xf151,
            toggle_right = caret_square_o_right,
            caret_square_o_right = 0xf152,
            euro = eur,
            eur = 0xf153,
            gbp = 0xf154,
            dollar = usd,
            usd = 0xf155,
            rupee = inr,
            inr = 0xf156,
            cny = jpy,
            rmb = jpy,
            yen = jpy,
            jpy = 0xf157,
            ruble = rub,
            rouble = rub,
            rub = 0xf158,
            won = krw,
            krw = 0xf159,
            bitcoin = btc,
            btc = 0xf15a,
            file = 0xf15b,
            file_text = 0xf15c,
            sort_alpha_asc = 0xf15d,
            sort_alpha_desc = 0xf15e,
            sort_amount_asc = 0xf160,
            sort_amount_desc = 0xf161,
            sort_numeric_asc = 0xf162,
            sort_numeric_desc = 0xf163,
            thumbs_up = 0xf164,
            thumbs_down = 0xf165,
            youtube_square = 0xf166,
            youtube = 0xf167,
            xing = 0xf168,
            xing_square = 0xf169,
            youtube_play = 0xf16a,
            dropbox = 0xf16b,
            stack_overflow = 0xf16c,
            instagram = 0xf16d,
            flickr = 0xf16e,
            adn = 0xf170,
            bitbucket = 0xf171,
            bitbucket_square = 0xf172,
            tumblr = 0xf173,
            tumblr_square = 0xf174,
            long_arrow_down = 0xf175,
            long_arrow_up = 0xf176,
            long_arrow_left = 0xf177,
            long_arrow_right = 0xf178,
            apple = 0xf179,
            windows = 0xf17a,
            android = 0xf17b,
            linux = 0xf17c,
            dribbble = 0xf17d,
            skype = 0xf17e,
            foursquare = 0xf180,
            trello = 0xf181,
            female = 0xf182,
            male = 0xf183,
            gittip = gratipay,
            gratipay = 0xf184,
            sun_o = 0xf185,
            moon_o = 0xf186,
            archive = 0xf187,
            bug = 0xf188,
            vk = 0xf189,
            weibo = 0xf18a,
            renren = 0xf18b,
            pagelines = 0xf18c,
            stack_exchange = 0xf18d,
            arrow_circle_o_right = 0xf18e,
            arrow_circle_o_left = 0xf190,
            toggle_left = caret_square_o_left,
            caret_square_o_left = 0xf191,
            dot_circle_o = 0xf192,
            wheelchair = 0xf193,
            vimeo_square = 0xf194,
            turkish_lira = @try,
            @try = 0xf195,
            plus_square_o = 0xf196,
            space_shuttle = 0xf197,
            slack = 0xf198,
            envelope_square = 0xf199,
            wordpress = 0xf19a,
            openid = 0xf19b,
            institution = university,
            bank = university,
            university = 0xf19c,
            mortar_board = graduation_cap,
            graduation_cap = 0xf19d,
            yahoo = 0xf19e,
            google = 0xf1a0,
            reddit = 0xf1a1,
            reddit_square = 0xf1a2,
            stumbleupon_circle = 0xf1a3,
            stumbleupon = 0xf1a4,
            delicious = 0xf1a5,
            digg = 0xf1a6,
            pied_piper = 0xf1a7,
            pied_piper_alt = 0xf1a8,
            drupal = 0xf1a9,
            joomla = 0xf1aa,
            language = 0xf1ab,
            fax = 0xf1ac,
            building = 0xf1ad,
            child = 0xf1ae,
            paw = 0xf1b0,
            spoon = 0xf1b1,
            cube = 0xf1b2,
            cubes = 0xf1b3,
            behance = 0xf1b4,
            behance_square = 0xf1b5,
            steam = 0xf1b6,
            steam_square = 0xf1b7,
            recycle = 0xf1b8,
            automobile = car,
            car = 0xf1b9,
            cab = taxi,
            taxi = 0xf1ba,
            tree = 0xf1bb,
            spotify = 0xf1bc,
            deviantart = 0xf1bd,
            soundcloud = 0xf1be,
            database = 0xf1c0,
            file_pdf_o = 0xf1c1,
            file_word_o = 0xf1c2,
            file_excel_o = 0xf1c3,
            file_powerpoint_o = 0xf1c4,
            file_photo_o = file_image_o,
            file_picture_o = file_image_o,
            file_image_o = 0xf1c5,
            file_zip_o = file_archive_o,
            file_archive_o = 0xf1c6,
            file_sound_o = file_audio_o,
            file_audio_o = 0xf1c7,
            file_movie_o = file_video_o,
            file_video_o = 0xf1c8,
            file_code_o = 0xf1c9,
            vine = 0xf1ca,
            codepen = 0xf1cb,
            jsfiddle = 0xf1cc,
            life_bouy = life_ring,
            life_buoy = life_ring,
            life_saver = life_ring,
            support = life_ring,
            life_ring = 0xf1cd,
            circle_o_notch = 0xf1ce,
            ra = rebel,
            rebel = 0xf1d0,
            ge = empire,
            empire = 0xf1d1,
            git_square = 0xf1d2,
            git = 0xf1d3,
            y_combinator_square = hacker_news,
            yc_square = hacker_news,
            hacker_news = 0xf1d4,
            tencent_weibo = 0xf1d5,
            qq = 0xf1d6,
            wechat = weixin,
            weixin = 0xf1d7,
            send = paper_plane,
            paper_plane = 0xf1d8,
            send_o = paper_plane_o,
            paper_plane_o = 0xf1d9,
            history = 0xf1da,
            circle_thin = 0xf1db,
            header = 0xf1dc,
            paragraph = 0xf1dd,
            sliders = 0xf1de,
            share_alt = 0xf1e0,
            share_alt_square = 0xf1e1,
            bomb = 0xf1e2,
            soccer_ball_o = futbol_o,
            futbol_o = 0xf1e3,
            tty = 0xf1e4,
            binoculars = 0xf1e5,
            plug = 0xf1e6,
            slideshare = 0xf1e7,
            twitch = 0xf1e8,
            yelp = 0xf1e9,
            newspaper_o = 0xf1ea,
            wifi = 0xf1eb,
            calculator = 0xf1ec,
            paypal = 0xf1ed,
            google_wallet = 0xf1ee,
            cc_visa = 0xf1f0,
            cc_mastercard = 0xf1f1,
            cc_discover = 0xf1f2,
            cc_amex = 0xf1f3,
            cc_paypal = 0xf1f4,
            cc_stripe = 0xf1f5,
            bell_slash = 0xf1f6,
            bell_slash_o = 0xf1f7,
            trash = 0xf1f8,
            copyright = 0xf1f9,
            at = 0xf1fa,
            eyedropper = 0xf1fb,
            paint_brush = 0xf1fc,
            birthday_cake = 0xf1fd,
            area_chart = 0xf1fe,
            pie_chart = 0xf200,
            line_chart = 0xf201,
            lastfm = 0xf202,
            lastfm_square = 0xf203,
            toggle_off = 0xf204,
            toggle_on = 0xf205,
            bicycle = 0xf206,
            bus = 0xf207,
            ioxhost = 0xf208,
            angellist = 0xf209,
            cc = 0xf20a,
            shekel = ils,
            sheqel = ils,
            ils = 0xf20b,
            meanpath = 0xf20c,
            buysellads = 0xf20d,
            connectdevelop = 0xf20e,
            dashcube = 0xf210,
            forumbee = 0xf211,
            leanpub = 0xf212,
            sellsy = 0xf213,
            shirtsinbulk = 0xf214,
            simplybuilt = 0xf215,
            skyatlas = 0xf216,
            cart_plus = 0xf217,
            cart_arrow_down = 0xf218,
            diamond = 0xf219,
            ship = 0xf21a,
            user_secret = 0xf21b,
            motorcycle = 0xf21c,
            street_view = 0xf21d,
            heartbeat = 0xf21e,
            venus = 0xf221,
            mars = 0xf222,
            mercury = 0xf223,
            intersex = transgender,
            transgender = 0xf224,
            transgender_alt = 0xf225,
            venus_double = 0xf226,
            mars_double = 0xf227,
            venus_mars = 0xf228,
            mars_stroke = 0xf229,
            mars_stroke_v = 0xf22a,
            mars_stroke_h = 0xf22b,
            neuter = 0xf22c,
            genderless = 0xf22d,
            facebook_official = 0xf230,
            pinterest_p = 0xf231,
            whatsapp = 0xf232,
            server = 0xf233,
            user_plus = 0xf234,
            user_times = 0xf235,
            hotel = bed,
            bed = 0xf236,
            viacoin = 0xf237,
            train = 0xf238,
            subway = 0xf239,
            medium = 0xf23a,
            yc = y_combinator,
            y_combinator = 0xf23b,
            optin_monster = 0xf23c,
            opencart = 0xf23d,
            expeditedssl = 0xf23e,
            battery_4 = battery_full,
            battery_full = 0xf240,
            battery_3 = battery_three_quarters,
            battery_three_quarters = 0xf241,
            battery_2 = battery_half,
            battery_half = 0xf242,
            battery_1 = battery_quarter,
            battery_quarter = 0xf243,
            battery_0 = battery_empty,
            battery_empty = 0xf244,
            mouse_pointer = 0xf245,
            i_cursor = 0xf246,
            object_group = 0xf247,
            object_ungroup = 0xf248,
            sticky_note = 0xf249,
            sticky_note_o = 0xf24a,
            cc_jcb = 0xf24b,
            cc_diners_club = 0xf24c,
            clone = 0xf24d,
            balance_scale = 0xf24e,
            hourglass_o = 0xf250,
            hourglass_1 = hourglass_start,
            hourglass_start = 0xf251,
            hourglass_2 = hourglass_half,
            hourglass_half = 0xf252,
            hourglass_3 = hourglass_end,
            hourglass_end = 0xf253,
            hourglass = 0xf254,
            hand_grab_o = hand_rock_o,
            hand_rock_o = 0xf255,
            hand_stop_o = hand_paper_o,
            hand_paper_o = 0xf256,
            hand_scissors_o = 0xf257,
            hand_lizard_o = 0xf258,
            hand_spock_o = 0xf259,
            hand_pointer_o = 0xf25a,
            hand_peace_o = 0xf25b,
            trademark = 0xf25c,
            registered = 0xf25d,
            creative_commons = 0xf25e,
            gg = 0xf260,
            gg_circle = 0xf261,
            tripadvisor = 0xf262,
            odnoklassniki = 0xf263,
            odnoklassniki_square = 0xf264,
            get_pocket = 0xf265,
            wikipedia_w = 0xf266,
            safari = 0xf267,
            chrome = 0xf268,
            firefox = 0xf269,
            opera = 0xf26a,
            internet_explorer = 0xf26b,
            tv = television,
            television = 0xf26c,
            contao = 0xf26d,
            _500px = 0xf26e,
            amazon = 0xf270,
            calendar_plus_o = 0xf271,
            calendar_minus_o = 0xf272,
            calendar_times_o = 0xf273,
            calendar_check_o = 0xf274,
            industry = 0xf275,
            map_pin = 0xf276,
            map_signs = 0xf277,
            map_o = 0xf278,
            map = 0xf279,
            commenting = 0xf27a,
            commenting_o = 0xf27b,
            houzz = 0xf27c,
            vimeo = 0xf27d,
            black_tie = 0xf27e,
            fonticons = 0xf280,
            reddit_alien = 0xf281,
            edge = 0xf282,
            credit_card_alt = 0xf283,
            codiepie = 0xf284,
            modx = 0xf285,
            fort_awesome = 0xf286,
            usb = 0xf287,
            product_hunt = 0xf288,
            mixcloud = 0xf289,
            scribd = 0xf28a,
            pause_circle = 0xf28b,
            pause_circle_o = 0xf28c,
            stop_circle = 0xf28d,
            stop_circle_o = 0xf28e,
            shopping_bag = 0xf290,
            shopping_basket = 0xf291,
            hashtag = 0xf292,
            bluetooth = 0xf293,
            bluetooth_b = 0xf294,
            percent = 0xf295
        }
    }
}