using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjImplementacao2._0
{
    public partial class Form1 : Form
    {
        private EventManager eventManager = EventManager.Instance;
        private IEventFactory conferenceFactory = new ConferenceFactory();
        private IEventFactory workshopFactory = new WorkshopFactory();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string title = txtEventTitulo.Text;
            DateTime date = dtpEventData.Value;

            IEvent newEvent = null;
            if (rbConference.Checked)
            {
                newEvent = conferenceFactory.CreateEvent(title, date);
            }
            else if (rbWorkshop.Checked)
            {
                newEvent = workshopFactory.CreateEvent(title, date);
            }

            if (newEvent != null)
            {
                eventManager.AddEvent(newEvent);
                UpdateEventList();
            }
        }

        private void btnRemoveEvent_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItem is IEvent selectedEvent)
            {
                eventManager.RemoveEvent(selectedEvent);
                UpdateEventList();
            }
        }

        private void btnRegisterParticipant_Click(object sender, EventArgs e)
        {
            string participantNome = txtParticipaNome.Text;
            if (!string.IsNullOrEmpty(participantNome))
            {
                Participante participant = new Participante(participantNome);
                eventManager.RegistrarObserver(participant);
                UpdateParticipantList();
            }
        }

        private void btnUnregisterParticipant_Click(object sender, EventArgs e)
        {
            if (lstParticipa.SelectedItem is Participante selectedParticipant)
            {
                eventManager.SemRegistroObserver(selectedParticipant);
                UpdateParticipantList();
            }
        }

        private void UpdateEventList()
        {
            lstEvents.Items.Clear();
            foreach (var ev in eventManager.ListEvents())
            {
                lstEvents.Items.Add(ev);
            }
        }

        private void UpdateParticipantList()
        {
            lstParticipa.Items.Clear();
            foreach (var observer in eventManager.ListObservers())
            {
                if (observer is Participante participant)
                {
                    lstParticipa.Items.Add(participant);
                }
            }
        }
    }
}
