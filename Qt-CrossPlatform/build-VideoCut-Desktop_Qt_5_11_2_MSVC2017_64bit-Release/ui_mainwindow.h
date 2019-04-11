/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.11.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QGroupBox>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QRadioButton>
#include <QtWidgets/QSpacerItem>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QTextBrowser>
#include <QtWidgets/QToolBar>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralWidget;
    QHBoxLayout *horizontalLayout;
    QGridLayout *gridLayout;
    QGroupBox *boxFreq;
    QVBoxLayout *verticalLayout_2;
    QRadioButton *rdb05;
    QRadioButton *rdb1;
    QRadioButton *rdb3;
    QRadioButton *rdb5;
    QGroupBox *boxSave;
    QVBoxLayout *verticalLayout;
    QPushButton *btnPath;
    QRadioButton *rdbOneFolder;
    QRadioButton *rdbNewFolder;
    QPushButton *btnStart;
    QPushButton *btnStop;
    QSpacerItem *verticalSpacer_2;
    QSpacerItem *horizontalSpacer_3;
    QSpacerItem *horizontalSpacer;
    QPushButton *btnFolder;
    QLabel *lblNumber;
    QSpacerItem *verticalSpacer;
    QSpacerItem *horizontalSpacer_2;
    QPushButton *btnFile;
    QTextBrowser *textBrowser;
    QMenuBar *menuBar;
    QToolBar *mainToolBar;
    QStatusBar *statusBar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName(QStringLiteral("MainWindow"));
        MainWindow->resize(800, 459);
        centralWidget = new QWidget(MainWindow);
        centralWidget->setObjectName(QStringLiteral("centralWidget"));
        horizontalLayout = new QHBoxLayout(centralWidget);
        horizontalLayout->setSpacing(6);
        horizontalLayout->setContentsMargins(11, 11, 11, 11);
        horizontalLayout->setObjectName(QStringLiteral("horizontalLayout"));
        gridLayout = new QGridLayout();
        gridLayout->setSpacing(6);
        gridLayout->setObjectName(QStringLiteral("gridLayout"));
        boxFreq = new QGroupBox(centralWidget);
        boxFreq->setObjectName(QStringLiteral("boxFreq"));
        verticalLayout_2 = new QVBoxLayout(boxFreq);
        verticalLayout_2->setSpacing(6);
        verticalLayout_2->setContentsMargins(11, 11, 11, 11);
        verticalLayout_2->setObjectName(QStringLiteral("verticalLayout_2"));
        rdb05 = new QRadioButton(boxFreq);
        rdb05->setObjectName(QStringLiteral("rdb05"));

        verticalLayout_2->addWidget(rdb05);

        rdb1 = new QRadioButton(boxFreq);
        rdb1->setObjectName(QStringLiteral("rdb1"));
        rdb1->setChecked(true);

        verticalLayout_2->addWidget(rdb1);

        rdb3 = new QRadioButton(boxFreq);
        rdb3->setObjectName(QStringLiteral("rdb3"));

        verticalLayout_2->addWidget(rdb3);

        rdb5 = new QRadioButton(boxFreq);
        rdb5->setObjectName(QStringLiteral("rdb5"));

        verticalLayout_2->addWidget(rdb5);

        boxSave = new QGroupBox(boxFreq);
        boxSave->setObjectName(QStringLiteral("boxSave"));
        verticalLayout = new QVBoxLayout(boxSave);
        verticalLayout->setSpacing(6);
        verticalLayout->setContentsMargins(11, 11, 11, 11);
        verticalLayout->setObjectName(QStringLiteral("verticalLayout"));
        btnPath = new QPushButton(boxSave);
        btnPath->setObjectName(QStringLiteral("btnPath"));

        verticalLayout->addWidget(btnPath);

        rdbOneFolder = new QRadioButton(boxSave);
        rdbOneFolder->setObjectName(QStringLiteral("rdbOneFolder"));
        rdbOneFolder->setChecked(true);

        verticalLayout->addWidget(rdbOneFolder);

        rdbNewFolder = new QRadioButton(boxSave);
        rdbNewFolder->setObjectName(QStringLiteral("rdbNewFolder"));

        verticalLayout->addWidget(rdbNewFolder);


        verticalLayout_2->addWidget(boxSave);

        btnStart = new QPushButton(boxFreq);
        btnStart->setObjectName(QStringLiteral("btnStart"));

        verticalLayout_2->addWidget(btnStart);

        btnStop = new QPushButton(boxFreq);
        btnStop->setObjectName(QStringLiteral("btnStop"));

        verticalLayout_2->addWidget(btnStop);

        verticalSpacer_2 = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout_2->addItem(verticalSpacer_2);


        gridLayout->addWidget(boxFreq, 2, 0, 3, 1);

        horizontalSpacer_3 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        gridLayout->addItem(horizontalSpacer_3, 0, 5, 1, 1);

        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        gridLayout->addItem(horizontalSpacer, 0, 3, 1, 1);

        btnFolder = new QPushButton(centralWidget);
        btnFolder->setObjectName(QStringLiteral("btnFolder"));

        gridLayout->addWidget(btnFolder, 0, 4, 1, 1);

        lblNumber = new QLabel(centralWidget);
        lblNumber->setObjectName(QStringLiteral("lblNumber"));

        gridLayout->addWidget(lblNumber, 1, 3, 1, 1);

        verticalSpacer = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        gridLayout->addItem(verticalSpacer, 1, 1, 1, 1);

        horizontalSpacer_2 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        gridLayout->addItem(horizontalSpacer_2, 0, 0, 1, 1);

        btnFile = new QPushButton(centralWidget);
        btnFile->setObjectName(QStringLiteral("btnFile"));

        gridLayout->addWidget(btnFile, 0, 1, 1, 1);

        textBrowser = new QTextBrowser(centralWidget);
        textBrowser->setObjectName(QStringLiteral("textBrowser"));

        gridLayout->addWidget(textBrowser, 2, 1, 2, 5);

        gridLayout->setRowStretch(0, 1);
        gridLayout->setRowStretch(1, 1);
        gridLayout->setRowStretch(2, 10);

        horizontalLayout->addLayout(gridLayout);

        MainWindow->setCentralWidget(centralWidget);
        menuBar = new QMenuBar(MainWindow);
        menuBar->setObjectName(QStringLiteral("menuBar"));
        menuBar->setGeometry(QRect(0, 0, 800, 23));
        MainWindow->setMenuBar(menuBar);
        mainToolBar = new QToolBar(MainWindow);
        mainToolBar->setObjectName(QStringLiteral("mainToolBar"));
        MainWindow->addToolBar(Qt::TopToolBarArea, mainToolBar);
        statusBar = new QStatusBar(MainWindow);
        statusBar->setObjectName(QStringLiteral("statusBar"));
        MainWindow->setStatusBar(statusBar);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QApplication::translate("MainWindow", "TeguVideoCutter", nullptr));
        boxFreq->setTitle(QApplication::translate("MainWindow", "Select Frequency", nullptr));
        rdb05->setText(QApplication::translate("MainWindow", "0.5s per image", nullptr));
        rdb1->setText(QApplication::translate("MainWindow", "1s per image", nullptr));
        rdb3->setText(QApplication::translate("MainWindow", "3s per image", nullptr));
        rdb5->setText(QApplication::translate("MainWindow", "5s per image", nullptr));
        boxSave->setTitle(QApplication::translate("MainWindow", "Save Settings", nullptr));
        btnPath->setText(QApplication::translate("MainWindow", "Select save path", nullptr));
        rdbOneFolder->setText(QApplication::translate("MainWindow", "Save all files in one folder", nullptr));
        rdbNewFolder->setText(QApplication::translate("MainWindow", "Create folder for every video file", nullptr));
        btnStart->setText(QApplication::translate("MainWindow", "Start Cutting", nullptr));
        btnStop->setText(QApplication::translate("MainWindow", "Cancel Cutting", nullptr));
        btnFolder->setText(QApplication::translate("MainWindow", "Select Folder", nullptr));
        lblNumber->setText(QApplication::translate("MainWindow", "0 Files Selected", nullptr));
        btnFile->setText(QApplication::translate("MainWindow", "Select File", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
