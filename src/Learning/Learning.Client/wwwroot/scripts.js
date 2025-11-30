        // Данные для наполнения сайта
        const courses = [
            {
                id: 'backend-java',
                title: 'Backend Java разработчик',
                description: 'Научитесь создавать серверные приложения на Java',
                level: 'Для начинающих',
                rating: 4.8,
                ratingsCount: 245,
                ratingDistribution: [5, 15, 30, 75, 120],
                status: 'enrolling',
                exam: true,
                duration: '6 месяцев',
                subject: 'Программирование'
            },
            {
                id: 'algorithms',
                title: 'Алгоритмы и структуры данных',
                description: 'Освойте фундаментальные алгоритмы программирования',
                level: 'С опытом',
                rating: 4.9,
                ratingsCount: 189,
                ratingDistribution: [2, 8, 25, 54, 100],
                status: 'completed',
                exam: true,
                duration: '4 месяца',
                subject: 'Программирование'
            },
            {
                id: 'math',
                title: 'Высшая математика',
                description: 'Полный курс высшей математики для технических специальностей',
                level: 'Для начинающих',
                rating: 4.7,
                ratingsCount: 156,
                ratingDistribution: [3, 12, 35, 46, 60],
                status: 'enrolling',
                exam: false,
                duration: '5 месяцев',
                subject: 'Математика'
            },
            {
                id: 'python-data',
                title: 'Python для анализа данных',
                description: 'Используйте Python для обработки и визуализации данных',
                level: 'Для начинающих',
                rating: 4.6,
                ratingsCount: 98,
                ratingDistribution: [1, 5, 22, 30, 40],
                status: 'enrolling',
                exam: false,
                duration: '3 месяца',
                subject: 'Data Science'
            }
        ];

        const books = [
            { id: 'clean-code', title: 'Чистый код', author: 'Роберт Мартин', description: 'Принципы, паттерны и приемы написания чистого кода', subject: 'Программирование', year: 2008, rating: 4.9 },
            { id: 'algorithms-book', title: 'Алгоритмы: построение и анализ', author: 'Томас Кормен', description: 'Фундаментальный труд по алгоритмам и структурам данных', subject: 'Алгоритмы', year: 2009, rating: 4.8 },
            { id: 'design-patterns', title: 'Паттерны проектирования', author: 'Эрих Гамма', description: 'Классические решения распространенных проблем проектирования', subject: 'Программирование', year: 1994, rating: 4.7 },
            { id: 'refactoring', title: 'Рефакторинг', author: 'Мартин Фаулер', description: 'Улучшение дизайна существующего кода', subject: 'Программирование', year: 1999, rating: 4.6 }
        ];

        const videoLessons = [
            { id: 'complex-numbers', title: 'Комплексные числа', description: 'Основы работы с комплексными числами в математике', subject: 'Математика', duration: '45 мин', rating: 4.7 },
            { id: 'cpp-basics', title: 'Основы C++', description: 'Введение в язык программирования C++', subject: 'Программирование', duration: '60 мин', rating: 4.5 },
            { id: 'oop', title: 'ООП в Java', description: 'Объектно-ориентированное программирование на Java', subject: 'Программирование', duration: '75 мин', rating: 4.8 },
            { id: 'sql-basics', title: 'Основы SQL', description: 'Изучение языка запросов к базам данных', subject: 'Базы данных', duration: '50 мин', rating: 4.6 }
        ];

        // Данные для чатов
        const chatData = {
            'petrov': [
                { text: 'Здравствуйте! У меня вопрос по домашнему заданию по REST API.', time: '10:30', type: 'received' },
                { text: 'Конечно, задавайте ваш вопрос.', time: '10:32', type: 'sent' },
                { text: 'Не понимаю, как правильно реализовать обработку ошибок в контроллере.', time: '10:33', type: 'received' },
                { text: 'Рекомендую использовать @ControllerAdvice для глобальной обработки исключений.', time: '10:35', type: 'sent' }
            ],
            'sidorov': [
                { text: 'Здравствуйте, когда можно будет получить консультацию по алгоритмам?', time: '15:20', type: 'received' },
                { text: 'Я свободен завтра с 14:00 до 16:00.', time: '15:22', type: 'sent' }
            ],
            'kuznetsov': [
                { text: 'Ваша работа по математике проверена. Оценка: 95/100.', time: '11:15', type: 'received' },
                { text: 'Спасибо! Посмотрю комментарии.', time: '11:20', type: 'sent' }
            ],
            'group-programming': [
                { text: 'Кто-нибудь разобрался с задачей №5?', time: '09:45', type: 'received' },
                { text: 'Да, я сделал. Нужно использовать паттерн Observer.', time: '09:50', type: 'sent' }
            ],
            'group-math': [
                { text: 'Завтра консультация в 15:00', time: '18:30', type: 'received' },
                { text: 'Спасибо за информацию!', time: '18:35', type: 'sent' }
            ]
        };

        // Данные для уведомлений
        const notifications = [
            { id: 1, title: 'Новое домашнее задание', content: 'Добавлено новое домашнее задание по Java', time: '2 часа назад', unread: true },
            { id: 2, title: 'Оценка за работу', content: 'Ваша работа по алгоритмам оценена на 95/100', time: '5 часов назад', unread: true },
            { id: 3, title: 'Новый курс', content: 'Доступен новый курс по машинному обучению', time: '1 день назад', unread: true },
            { id: 4, title: 'Консультация', content: 'Завтра консультация по математике в 15:00', time: '2 дня назад', unread: false }
        ];

        let currentChat = 'petrov';
        let currentRating = 0;
        let currentCourseId = '';

        // Функция для генерации карточек
        function generateCards(containerId, items, type) {
            const container = document.getElementById(containerId);
            if (!container) return;

            container.innerHTML = '';

            if (items.length === 0) {
                container.innerHTML = '<div class="no-results">Ничего не найдено</div>';
                return;
            }

            items.forEach(item => {
                const card = document.createElement('div');
                card.className = 'card';
                card.onclick = () => {
                    if (type === 'course') showCourseDetail(item.id);
                    if (type === 'book') showBookDetail(item.id);
                    if (type === 'video') showVideoDetail(item.id);
                };

                let statusTag = '';
                if (type === 'course') {
                    statusTag = item.status === 'enrolling' ?
                        '<span class="card-tag">Идет набор</span>' :
                        '<span class="card-tag">Завершен</span>';
                }

                card.innerHTML = `
                    <div class="card-img">${item.title}</div>
                    <div class="card-content">
                        <h3 class="card-title">${item.title}</h3>
                        <p class="card-description">${item.description}</p>
                        <div class="card-footer">
                            ${type === 'course' ? statusTag : `<span class="card-tag">${item.subject || item.level}</span>`}
                            <div class="card-rating">
                                <i class="fas fa-star"></i> ${item.rating}
                            </div>
                        </div>
                    </div>
                `;

                container.appendChild(card);
            });
        }

        // Функции фильтрации
        function filterVideos() {
            const subjectFilter = document.getElementById('videoSubjectFilter').value;
            const searchFilter = document.getElementById('videoSearch').value.toLowerCase();

            const filteredVideos = videoLessons.filter(video => {
                const matchesSubject = !subjectFilter || video.subject === subjectFilter;
                const matchesSearch = !searchFilter ||
                    video.title.toLowerCase().includes(searchFilter) ||
                    video.description.toLowerCase().includes(searchFilter);

                return matchesSubject && matchesSearch;
            });

            generateCards('video-lessons-container', filteredVideos, 'video');
        }

        function filterBooks() {
            const subjectFilter = document.getElementById('bookSubjectFilter').value;
            const authorFilter = document.getElementById('bookAuthorFilter').value;
            const searchFilter = document.getElementById('bookSearch').value.toLowerCase();

            const filteredBooks = books.filter(book => {
                const matchesSubject = !subjectFilter || book.subject === subjectFilter;
                const matchesAuthor = !authorFilter || book.author === authorFilter;
                const matchesSearch = !searchFilter ||
                    book.title.toLowerCase().includes(searchFilter) ||
                    book.author.toLowerCase().includes(searchFilter) ||
                    book.description.toLowerCase().includes(searchFilter);

                return matchesSubject && matchesAuthor && matchesSearch;
            });

            generateCards('library-container', filteredBooks, 'book');
        }

        function filterCourses() {
            const subjectFilter = document.getElementById('courseSubjectFilter').value;
            const statusFilter = document.getElementById('courseStatusFilter').value;
            const levelFilter = document.getElementById('courseLevelFilter').value;

            const filteredCourses = courses.filter(course => {
                const matchesSubject = !subjectFilter || course.subject === subjectFilter;
                const matchesStatus = !statusFilter || course.status === statusFilter;
                const matchesLevel = !levelFilter || course.level === levelFilter;

                return matchesSubject && matchesStatus && matchesLevel;
            });

            generateCards('courses-container', filteredCourses, 'course');
        }

        // Функция для выбора чата
        function selectChat(chatId, element) {
            // Убираем активный класс у всех чатов
            const chatItems = document.querySelectorAll('.chat-item');
            chatItems.forEach(item => {
                item.classList.remove('active');
            });

            // Добавляем активный класс выбранному чату
            element.classList.add('active');

            // Обновляем текущий чат
            currentChat = chatId;

            // Загружаем сообщения для выбранного чата
            loadChatMessages(chatId);
        }

        // Функция для загрузки сообщений чата
        function loadChatMessages(chatId) {
            const messagesContainer = document.getElementById('messages-container');
            messagesContainer.innerHTML = '';

            const messages = chatData[chatId] || [];

            messages.forEach(message => {
                const messageElement = document.createElement('div');
                messageElement.className = `message ${message.type}`;
                messageElement.innerHTML = `
                    <p>${message.text}</p>
                    <div class="message-time">${message.time}</div>
                `;
                messagesContainer.appendChild(messageElement);
            });

            // Прокрутка к последнему сообщению
            messagesContainer.scrollTop = messagesContainer.scrollHeight;
        }

        // Функция для отправки сообщения
        function sendMessage() {
            const messageInput = document.getElementById('message-input');
            const messageText = messageInput.value.trim();

            if (messageText) {
                const messagesContainer = document.getElementById('messages-container');
                const now = new Date();
                const timeString = `${now.getHours().toString().padStart(2, '0')}:${now.getMinutes().toString().padStart(2, '0')}`;

                // Добавляем сообщение в данные чата
                if (!chatData[currentChat]) {
                    chatData[currentChat] = [];
                }

                chatData[currentChat].push({
                    text: messageText,
                    time: timeString,
                    type: 'sent'
                });

                // Обновляем отображение
                loadChatMessages(currentChat);
                messageInput.value = '';

                // Авто-ответ (имитация)
                setTimeout(() => {
                    const responses = [
                        "Хороший вопрос! Давайте разберем его подробнее.",
                        "Спасибо за сообщение! Я помогу вам с этим.",
                        "Интересный вопрос! Давайте обсудим его на следующем занятии.",
                        "Я понял ваш вопрос. Давайте рассмотрим это вместе."
                    ];
                    const randomResponse = responses[Math.floor(Math.random() * responses.length)];

                    chatData[currentChat].push({
                        text: randomResponse,
                        time: `${now.getHours().toString().padStart(2, '0')}:${(now.getMinutes() + 1).toString().padStart(2, '0')}`,
                        type: 'received'
                    });

                    loadChatMessages(currentChat);
                }, 2000);
            }
        }

        // Система оценки курса
        function initializeRatingSystem(courseId) {
            currentCourseId = courseId;
            const course = courses.find(c => c.id === courseId);
            if (!course) return;

            // Обновляем отображение рейтинга
            document.getElementById('course-rating').textContent = course.rating;

            // Отображаем распределение оценок
            const distributionContainer = document.getElementById('rating-distribution');
            distributionContainer.innerHTML = '';

            for (let i = 5; i >= 1; i--) {
                const count = course.ratingDistribution[i-1] || 0;
                const percentage = course.ratingsCount > 0 ? (count / course.ratingsCount * 100).toFixed(1) : 0;

                const ratingElement = document.createElement('div');
                ratingElement.style.cssText = 'display: flex; align-items: center; gap: 10px; margin: 5px 0;';
                ratingElement.innerHTML = `
                    <span>${i}★</span>
                    <div style="flex-grow: 1; height: 8px; background: rgba(255,255,255,0.2); border-radius: 4px;">
                        <div style="height: 100%; background: gold; border-radius: 4px; width: ${percentage}%"></div>
                    </div>
                    <span>${percentage}%</span>
                `;
                distributionContainer.appendChild(ratingElement);
            }

            // Настройка звезд для оценки
            const stars = document.querySelectorAll('.star');
            stars.forEach(star => {
                star.addEventListener('mouseover', function() {
                    const rating = parseInt(this.getAttribute('data-rating'));
                    highlightStars(rating);
                });

                star.addEventListener('mouseout', function() {
                    highlightStars(currentRating);
                });

                star.addEventListener('click', function() {
                    currentRating = parseInt(this.getAttribute('data-rating'));
                    highlightStars(currentRating);
                });
            });

            // Блокировка кнопки записи для завершенных курсов
            const enrollButton = document.getElementById('enroll-button');
            if (course.status === 'completed') {
                enrollButton.disabled = true;
                enrollButton.innerHTML = '<i class="fas fa-lock"></i> Курс завершен';
            } else {
                enrollButton.disabled = false;
                enrollButton.innerHTML = '<i class="fas fa-user-plus"></i> Записаться на курс';
            }
        }

        function highlightStars(rating) {
            const stars = document.querySelectorAll('.star');
            stars.forEach((star, index) => {
                if (index < rating) {
                    star.classList.add('active');
                } else {
                    star.classList.remove('active');
                }
            });
        }

        function submitRating() {
            if (currentRating === 0) {
                alert('Пожалуйста, выберите оценку');
                return;
            }

            const course = courses.find(c => c.id === currentCourseId);
            if (course) {
                // Обновляем распределение оценок
                course.ratingDistribution[currentRating - 1]++;
                course.ratingsCount++;

                // Пересчитываем средний рейтинг
                let total = 0;
                course.ratingDistribution.forEach((count, index) => {
                    total += count * (index + 1);
                });
                course.rating = (total / course.ratingsCount).toFixed(1);

                // Обновляем интерфейс
                initializeRatingSystem(currentCourseId);
                alert(`Спасибо за вашу оценку: ${currentRating}★`);
                currentRating = 0;
                highlightStars(0);
            }
        }

        // Функция для переключения между вкладками
        function showTab(tabName) {
            const tabs = document.querySelectorAll('.tab-container');
            tabs.forEach(tab => {
                tab.classList.remove('active');
            });

            document.getElementById(tabName).classList.add('active');
        }

        // Функция для отображения/скрытия уведомлений
        function toggleNotifications() {
            const panel = document.getElementById('notificationsPanel');
            panel.classList.toggle('active');
        }

        // Функция для загрузки уведомлений
        function loadNotifications() {
            const notificationsList = document.getElementById('notificationsList');
            notificationsList.innerHTML = '';

            notifications.forEach(notification => {
                const notificationElement = document.createElement('div');
                notificationElement.className = `notification-item ${notification.unread ? 'unread' : ''}`;
                notificationElement.onclick = () => markNotificationAsRead(notification.id);

                notificationElement.innerHTML = `
                    <div class="notification-title">${notification.title}</div>
                    <div class="notification-content">${notification.content}</div>
                    <div class="notification-time">${notification.time}</div>
                `;

                notificationsList.appendChild(notificationElement);
            });
        }

        // Функция для отметки уведомления как прочитанного
        function markNotificationAsRead(notificationId) {
            const notification = notifications.find(n => n.id === notificationId);
            if (notification) {
                notification.unread = false;
                updateNotificationBadge();
                loadNotifications();
            }
        }

        // Функция для отметки всех уведомлений как прочитанных
        function markAllNotificationsAsRead() {
            notifications.forEach(notification => {
                notification.unread = false;
            });
            updateNotificationBadge();
            loadNotifications();
        }

        // Функция для обновления бейджа уведомлений
        function updateNotificationBadge() {
            const unreadCount = notifications.filter(n => n.unread).length;
            const badge = document.querySelector('.notification-badge');

            if (unreadCount > 0) {
                badge.textContent = unreadCount;
                badge.style.display = 'flex';
            } else {
                badge.style.display = 'none';
            }
        }

        // Функция для открытия чата с выбранным пользователем
        function openChatWith(user) {
            showTab('chat');
            alert(`Открыт чат с ${user}`);
        }

        // Функция переключения темы
        function toggleTheme() {
            document.body.classList.toggle('light-theme');
            const themeBtn = document.querySelector('.theme-btn i');
            if (document.body.classList.contains('light-theme')) {
                themeBtn.className = 'fas fa-sun';
            } else {
                themeBtn.className = 'fas fa-moon';
            }
        }

        // Функция для отображения детальной информации о видеоуроке
        function showVideoDetail(videoId) {
            showTab('video-detail');

            const video = videoLessons.find(v => v.id === videoId);
            if (video) {
                document.getElementById('video-title').textContent = video.title;
                document.getElementById('video-description').textContent = video.description;
                document.getElementById('video-player-title').textContent = video.title;
            }
        }

        // Функция для отображения детальной информации о книге
        function showBookDetail(bookId) {
            showTab('book-detail');

            const book = books.find(b => b.id === bookId);
            if (book) {
                document.getElementById('book-title').textContent = book.title;
                document.getElementById('book-author').textContent = book.author;
                document.getElementById('book-description').textContent = book.description;
                document.getElementById('book-subject').textContent = book.subject;
                document.getElementById('book-year').textContent = book.year;
                document.getElementById('book-cover').textContent = `Обложка: ${book.title}`;
            }
        }

        // Функция для отображения детальной информации о курсе
        function showCourseDetail(courseId) {
            showTab('course-detail');

            const course = courses.find(c => c.id === courseId);
            if (course) {
                document.getElementById('course-title').textContent = course.title;
                document.getElementById('course-status').textContent = course.status === 'enrolling' ? 'Идет набор' : 'Завершен';
                document.getElementById('course-level').textContent = course.level;
                document.getElementById('course-exam').textContent = course.exam ? 'Требуется' : 'Не требуется';
                document.getElementById('course-duration').textContent = course.duration;

                // Инициализируем систему оценки
                initializeRatingSystem(courseId);
            }
        }

        // Функция для входа в систему
        function login() {
            const username = document.getElementById('login-username').value;
            const password = document.getElementById('login-password').value;

            if (username && password) {
                alert(`Вход выполнен для пользователя: ${username}`);
                showTab('profile');
            } else {
                alert('Пожалуйста, заполните все поля');
            }
        }

        // Функция для регистрации
        function register() {
            const fullname = document.getElementById('register-fullname').value;
            const university = document.getElementById('register-university').value;
            const direction = document.getElementById('register-direction').value;
            const course = document.getElementById('register-course').value;
            const email = document.getElementById('register-email').value;
            const username = document.getElementById('register-username').value;
            const password = document.getElementById('register-password').value;

            if (fullname && university && direction && course && email && username && password) {
                alert(`Регистрация завершена для пользователя: ${fullname}`);
                showTab('login');
            } else {
                alert('Пожалуйста, заполните все поля');
            }
        }

        // Закрытие панели уведомлений при клике вне ее
        document.addEventListener('click', function(event) {
            const panel = document.getElementById('notificationsPanel');
            const notificationIcon = document.querySelector('.notification-icon');

            if (!panel.contains(event.target) && !notificationIcon.contains(event.target)) {
                panel.classList.remove('active');
            }
        });

        // Инициализация при загрузке
        document.addEventListener('DOMContentLoaded', function() {
            // Заполняем главную страницу
            generateCards('home-courses', courses.slice(0, 4), 'course');
            generateCards('home-books', books.slice(0, 4), 'book');
            generateCards('video-lessons-container', videoLessons, 'video');
            generateCards('library-container', books, 'book');
            generateCards('courses-container', courses, 'course');

            // Загружаем сообщения для активного чата
            loadChatMessages(currentChat);

            // Загружаем уведомления
            loadNotifications();
            updateNotificationBadge();

            // Добавляем анонсы и новости
            const announcementsContainer = document.getElementById('home-announcements');
            const newsContainer = document.getElementById('home-news');

            if (announcementsContainer) {
                const announcements = [
                    { title: 'Машинное обучение', description: 'Скоро запуск! Основы ML и Data Science', status: 'Скоро', tag: 'Идет набор' },
                    { title: 'Кибербезопасность', description: 'Новый курс по защите информации', status: 'Скоро', tag: 'Идет набор' }
                ];

                announcements.forEach(announcement => {
                    const card = document.createElement('div');
                    card.className = 'card';
                    card.innerHTML = `
                        <div class="card-img">${announcement.title}</div>
                        <div class="card-content">
                            <h3 class="card-title">${announcement.title}</h3>
                            <p class="card-description">${announcement.description}</p>
                            <div class="card-footer">
                                <span class="card-tag">${announcement.status}</span>
                                <span class="card-tag">${announcement.tag}</span>
                            </div>
                        </div>
                    `;
                    announcementsContainer.appendChild(card);
                });
            }

            if (newsContainer) {
                const news = [
                    { title: 'Цифровизация образования', description: 'Новые технологии меняют подход к обучению в вузах', date: '15.10.2023' },
                    { title: 'ИИ в образовании', description: 'Как искусственный интеллект помогает персонализировать обучение', date: '10.10.2023' },
                    { title: 'Онлайн-образование будущего', description: 'Тренды и перспективы развития EdTech', date: '05.10.2023' }
                ];

                news.forEach(item => {
                    const card = document.createElement('div');
                    card.className = 'card';
                    card.innerHTML = `
                        <div class="card-img">${item.title}</div>
                        <div class="card-content">
                            <h3 class="card-title">${item.title}</h3>
                            <p class="card-description">${item.description}</p>
                            <div class="card-footer">
                                <span>${item.date}</span>
                            </div>
                        </div>
                    `;
                    newsContainer.appendChild(card);
                });
            }
        });

        // Обработка нажатия Enter в поле ввода сообщения
        document.getElementById('message-input').addEventListener('keypress', function(e) {
            if (e.key === 'Enter') {
                sendMessage();
            }
        });