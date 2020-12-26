#include "razumpov_helpbrowser.h"

#include <QApplication>//#include <qapplication.h>
#include <QLayout>
#include <QPushButton>
#include <QTextBrowser>

#include "razumpov_helpbrowser.h"

razumpov_HelpBrowser::razumpov_HelpBrowser(const QString &path, const QString &page,
                         QWidget *parent, const char *name)
    : QWidget(parent, name, WGroupLeader | WDestructiveClose)
{
  textBrowser = new QTextBrowser(this);
  homeButton = new QPushButton(tr("&Home"), this);
  backButton = new QPushButton(tr("&Back"), this);
  closeButton = new QPushButton(tr("Close"), this);
  closeButton->setAccel(tr("Esc"));

  QVBoxLayout *mainLayout = new QVBoxLayout(this);
  QHBoxLayout *buttonLayout = new QHBoxLayout(mainLayout);
  buttonLayout->addWidget(homeButton);
  buttonLayout->addWidget(backButton);
  buttonLayout->addStretch(1);
  buttonLayout->addWidget(closeButton);
  mainLayout->addWidget(textBrowser);

  connect(homeButton, SIGNAL(clicked()),
          textBrowser, SLOT(home()));
  connect(backButton, SIGNAL(clicked()),
          textBrowser, SLOT(backward()));
  connect(closeButton, SIGNAL(clicked()),
          this, SLOT(close()));
  connect(textBrowser, SIGNAL(sourceChanged(const QString &)),
          this, SLOT(updateCaption()));

  textBrowser->mimeSourceFactory()->addFilePath(path);
  textBrowser->setSource(page);
}
