using Sepidar.Domain.Entities;
using Sepidar.Message.Commands;
using Sepidar.Message.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sepidar.Api.Controllers
{
    public partial class Mapper
    {
                
        
        public static CustomContact Map(AddCustomContactCommand inputItem)
        {
            var entity = new CustomContact() {
                  
  
		CustomContactId = inputItem.CustomContactId,  
  
		FullName = inputItem.FullName,  
  
		MarriageDate = inputItem.MarriageDate,  
  
		BirthDate = inputItem.BirthDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CustomContact Map(CustomContact entity ,EditCustomContactCommand inputItem)
        {
              
  
		entity.CustomContactId = inputItem.CustomContactId;  
  
		entity.FullName = inputItem.FullName;  
  
		entity.MarriageDate = inputItem.MarriageDate;  
  
		entity.BirthDate = inputItem.BirthDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CustomContactDto Map(CustomContact inputItem)
        {
            var dto = new CustomContactDto()
            {
                  
  
		CustomContactId = inputItem.CustomContactId,  
  
		FullName = inputItem.FullName,  
  
		MarriageDate = inputItem.MarriageDate,  
  
		BirthDate = inputItem.BirthDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<CustomContactDto> Map(ICollection<CustomContact> entities)
        {
            var dtos = new List<CustomContactDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CustomContactDto()
                {
                      
  
		CustomContactId = inputItem.CustomContactId,  
  
		FullName = inputItem.FullName,  
  
		MarriageDate = inputItem.MarriageDate,  
  
		BirthDate = inputItem.BirthDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CustomContactPhone Map(AddCustomContactPhoneCommand inputItem)
        {
            var entity = new CustomContactPhone() {
                  
  
		CustomContactPhoneId = inputItem.CustomContactPhoneId,  
  
		CustomContactRef = inputItem.CustomContactRef,  
  
		Phone = inputItem.Phone,  
  
		IsMain = inputItem.IsMain, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CustomContactPhone Map(CustomContactPhone entity ,EditCustomContactPhoneCommand inputItem)
        {
              
  
		entity.CustomContactPhoneId = inputItem.CustomContactPhoneId;  
  
		entity.CustomContactRef = inputItem.CustomContactRef;  
  
		entity.Phone = inputItem.Phone;  
  
		entity.IsMain = inputItem.IsMain; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CustomContactPhoneDto Map(CustomContactPhone inputItem)
        {
            var dto = new CustomContactPhoneDto()
            {
                  
  
		CustomContactPhoneId = inputItem.CustomContactPhoneId,  
  
		CustomContactRef = inputItem.CustomContactRef,  
  
		Phone = inputItem.Phone,  
  
		IsMain = inputItem.IsMain, 
            };
            return dto;
        }

        public static List<CustomContactPhoneDto> Map(ICollection<CustomContactPhone> entities)
        {
            var dtos = new List<CustomContactPhoneDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CustomContactPhoneDto()
                {
                      
  
		CustomContactPhoneId = inputItem.CustomContactPhoneId,  
  
		CustomContactRef = inputItem.CustomContactRef,  
  
		Phone = inputItem.Phone,  
  
		IsMain = inputItem.IsMain, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Inbox Map(AddInboxCommand inputItem)
        {
            var entity = new Inbox() {
                  
  
		InboxID = inputItem.InboxID,  
  
		Text = inputItem.Text,  
  
		Date = inputItem.Date,  
  
		SenderNumber = inputItem.SenderNumber,  
  
		ReceiverNumber = inputItem.ReceiverNumber,  
  
		ContactPhoneRef = inputItem.ContactPhoneRef,  
  
		ContactType = inputItem.ContactType,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Inbox Map(Inbox entity ,EditInboxCommand inputItem)
        {
              
  
		entity.InboxID = inputItem.InboxID;  
  
		entity.Text = inputItem.Text;  
  
		entity.Date = inputItem.Date;  
  
		entity.SenderNumber = inputItem.SenderNumber;  
  
		entity.ReceiverNumber = inputItem.ReceiverNumber;  
  
		entity.ContactPhoneRef = inputItem.ContactPhoneRef;  
  
		entity.ContactType = inputItem.ContactType;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InboxDto Map(Inbox inputItem)
        {
            var dto = new InboxDto()
            {
                  
  
		InboxID = inputItem.InboxID,  
  
		Text = inputItem.Text,  
  
		Date = inputItem.Date,  
  
		SenderNumber = inputItem.SenderNumber,  
  
		ReceiverNumber = inputItem.ReceiverNumber,  
  
		ContactPhoneRef = inputItem.ContactPhoneRef,  
  
		ContactType = inputItem.ContactType,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<InboxDto> Map(ICollection<Inbox> entities)
        {
            var dtos = new List<InboxDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InboxDto()
                {
                      
  
		InboxID = inputItem.InboxID,  
  
		Text = inputItem.Text,  
  
		Date = inputItem.Date,  
  
		SenderNumber = inputItem.SenderNumber,  
  
		ReceiverNumber = inputItem.ReceiverNumber,  
  
		ContactPhoneRef = inputItem.ContactPhoneRef,  
  
		ContactType = inputItem.ContactType,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Message1 Map(AddMessage1Command inputItem)
        {
            var entity = new Message1() {
                  
  
		MessageID = inputItem.MessageID,  
  
		Body = inputItem.Body,  
  
		Date = inputItem.Date,  
  
		IsDraft = inputItem.IsDraft,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Message1 Map(Message1 entity ,EditMessage1Command inputItem)
        {
              
  
		entity.MessageID = inputItem.MessageID;  
  
		entity.Body = inputItem.Body;  
  
		entity.Date = inputItem.Date;  
  
		entity.IsDraft = inputItem.IsDraft;  
  
		entity.TemplateRef = inputItem.TemplateRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static Message1Dto Map(Message1 inputItem)
        {
            var dto = new Message1Dto()
            {
                  
  
		MessageID = inputItem.MessageID,  
  
		Body = inputItem.Body,  
  
		Date = inputItem.Date,  
  
		IsDraft = inputItem.IsDraft,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<Message1Dto> Map(ICollection<Message1> entities)
        {
            var dtos = new List<Message1Dto>();
            foreach (var inputItem in entities)
            {
                var dto = new Message1Dto()
                {
                      
  
		MessageID = inputItem.MessageID,  
  
		Body = inputItem.Body,  
  
		Date = inputItem.Date,  
  
		IsDraft = inputItem.IsDraft,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MessageContact Map(AddMessageContactCommand inputItem)
        {
            var entity = new MessageContact() {
                  
  
		MessageContactID = inputItem.MessageContactID,  
  
		MessageRef = inputItem.MessageRef,  
  
		Phone = inputItem.Phone,  
  
		ContactPhoneRef = inputItem.ContactPhoneRef,  
  
		ContactType = inputItem.ContactType, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MessageContact Map(MessageContact entity ,EditMessageContactCommand inputItem)
        {
              
  
		entity.MessageContactID = inputItem.MessageContactID;  
  
		entity.MessageRef = inputItem.MessageRef;  
  
		entity.Phone = inputItem.Phone;  
  
		entity.ContactPhoneRef = inputItem.ContactPhoneRef;  
  
		entity.ContactType = inputItem.ContactType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MessageContactDto Map(MessageContact inputItem)
        {
            var dto = new MessageContactDto()
            {
                  
  
		MessageContactID = inputItem.MessageContactID,  
  
		MessageRef = inputItem.MessageRef,  
  
		Phone = inputItem.Phone,  
  
		ContactPhoneRef = inputItem.ContactPhoneRef,  
  
		ContactType = inputItem.ContactType, 
            };
            return dto;
        }

        public static List<MessageContactDto> Map(ICollection<MessageContact> entities)
        {
            var dtos = new List<MessageContactDto>();
            foreach (var inputItem in entities)
            {
                var dto = new MessageContactDto()
                {
                      
  
		MessageContactID = inputItem.MessageContactID,  
  
		MessageRef = inputItem.MessageRef,  
  
		Phone = inputItem.Phone,  
  
		ContactPhoneRef = inputItem.ContactPhoneRef,  
  
		ContactType = inputItem.ContactType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OutgoingMessage Map(AddOutgoingMessageCommand inputItem)
        {
            var entity = new OutgoingMessage() {
                  
  
		OutgoingMessageID = inputItem.OutgoingMessageID,  
  
		Text = inputItem.Text,  
  
		Date = inputItem.Date,  
  
		SenderNumber = inputItem.SenderNumber,  
  
		ReceiverNumber = inputItem.ReceiverNumber,  
  
		State = inputItem.State,  
  
		TrackingID = inputItem.TrackingID,  
  
		MessageContactRef = inputItem.MessageContactRef,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OutgoingMessage Map(OutgoingMessage entity ,EditOutgoingMessageCommand inputItem)
        {
              
  
		entity.OutgoingMessageID = inputItem.OutgoingMessageID;  
  
		entity.Text = inputItem.Text;  
  
		entity.Date = inputItem.Date;  
  
		entity.SenderNumber = inputItem.SenderNumber;  
  
		entity.ReceiverNumber = inputItem.ReceiverNumber;  
  
		entity.State = inputItem.State;  
  
		entity.TrackingID = inputItem.TrackingID;  
  
		entity.MessageContactRef = inputItem.MessageContactRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OutgoingMessageDto Map(OutgoingMessage inputItem)
        {
            var dto = new OutgoingMessageDto()
            {
                  
  
		OutgoingMessageID = inputItem.OutgoingMessageID,  
  
		Text = inputItem.Text,  
  
		Date = inputItem.Date,  
  
		SenderNumber = inputItem.SenderNumber,  
  
		ReceiverNumber = inputItem.ReceiverNumber,  
  
		State = inputItem.State,  
  
		TrackingID = inputItem.TrackingID,  
  
		MessageContactRef = inputItem.MessageContactRef,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<OutgoingMessageDto> Map(ICollection<OutgoingMessage> entities)
        {
            var dtos = new List<OutgoingMessageDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OutgoingMessageDto()
                {
                      
  
		OutgoingMessageID = inputItem.OutgoingMessageID,  
  
		Text = inputItem.Text,  
  
		Date = inputItem.Date,  
  
		SenderNumber = inputItem.SenderNumber,  
  
		ReceiverNumber = inputItem.ReceiverNumber,  
  
		State = inputItem.State,  
  
		TrackingID = inputItem.TrackingID,  
  
		MessageContactRef = inputItem.MessageContactRef,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PhoneLine Map(AddPhoneLineCommand inputItem)
        {
            var entity = new PhoneLine() {
                  
  
		PhoneLineID = inputItem.PhoneLineID,  
  
		Number = inputItem.Number,  
  
		Credit = inputItem.Credit,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PhoneLine Map(PhoneLine entity ,EditPhoneLineCommand inputItem)
        {
              
  
		entity.PhoneLineID = inputItem.PhoneLineID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Credit = inputItem.Credit;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PhoneLineDto Map(PhoneLine inputItem)
        {
            var dto = new PhoneLineDto()
            {
                  
  
		PhoneLineID = inputItem.PhoneLineID,  
  
		Number = inputItem.Number,  
  
		Credit = inputItem.Credit,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<PhoneLineDto> Map(ICollection<PhoneLine> entities)
        {
            var dtos = new List<PhoneLineDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PhoneLineDto()
                {
                      
  
		PhoneLineID = inputItem.PhoneLineID,  
  
		Number = inputItem.Number,  
  
		Credit = inputItem.Credit,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SentScheduledTemplateSchedulingDate Map(AddSentScheduledTemplateSchedulingDateCommand inputItem)
        {
            var entity = new SentScheduledTemplateSchedulingDate() {
                  
  
		SentScheduledTemplateSchedulingDateID = inputItem.SentScheduledTemplateSchedulingDateID,  
  
		TemplateSchedulingRef = inputItem.TemplateSchedulingRef,  
  
		SchedulingItemRef = inputItem.SchedulingItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SentScheduledTemplateSchedulingDate Map(SentScheduledTemplateSchedulingDate entity ,EditSentScheduledTemplateSchedulingDateCommand inputItem)
        {
              
  
		entity.SentScheduledTemplateSchedulingDateID = inputItem.SentScheduledTemplateSchedulingDateID;  
  
		entity.TemplateSchedulingRef = inputItem.TemplateSchedulingRef;  
  
		entity.SchedulingItemRef = inputItem.SchedulingItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SentScheduledTemplateSchedulingDateDto Map(SentScheduledTemplateSchedulingDate inputItem)
        {
            var dto = new SentScheduledTemplateSchedulingDateDto()
            {
                  
  
		SentScheduledTemplateSchedulingDateID = inputItem.SentScheduledTemplateSchedulingDateID,  
  
		TemplateSchedulingRef = inputItem.TemplateSchedulingRef,  
  
		SchedulingItemRef = inputItem.SchedulingItemRef, 
            };
            return dto;
        }

        public static List<SentScheduledTemplateSchedulingDateDto> Map(ICollection<SentScheduledTemplateSchedulingDate> entities)
        {
            var dtos = new List<SentScheduledTemplateSchedulingDateDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SentScheduledTemplateSchedulingDateDto()
                {
                      
  
		SentScheduledTemplateSchedulingDateID = inputItem.SentScheduledTemplateSchedulingDateID,  
  
		TemplateSchedulingRef = inputItem.TemplateSchedulingRef,  
  
		SchedulingItemRef = inputItem.SchedulingItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Template Map(AddTemplateCommand inputItem)
        {
            var entity = new Template() {
                  
  
		TemplateID = inputItem.TemplateID,  
  
		TemplateGUID = inputItem.TemplateGUID,  
  
		IsSystemTemplate = inputItem.IsSystemTemplate,  
  
		TemplateVersion = inputItem.TemplateVersion,  
  
		Title = inputItem.Title,  
  
		Body = inputItem.Body,  
  
		ShowOutgoingMessage = inputItem.ShowOutgoingMessage,  
  
		MessageParameterInfoFullName = inputItem.MessageParameterInfoFullName,  
  
		FilterMedianOperator = inputItem.FilterMedianOperator,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Template Map(Template entity ,EditTemplateCommand inputItem)
        {
              
  
		entity.TemplateID = inputItem.TemplateID;  
  
		entity.TemplateGUID = inputItem.TemplateGUID;  
  
		entity.IsSystemTemplate = inputItem.IsSystemTemplate;  
  
		entity.TemplateVersion = inputItem.TemplateVersion;  
  
		entity.Title = inputItem.Title;  
  
		entity.Body = inputItem.Body;  
  
		entity.ShowOutgoingMessage = inputItem.ShowOutgoingMessage;  
  
		entity.MessageParameterInfoFullName = inputItem.MessageParameterInfoFullName;  
  
		entity.FilterMedianOperator = inputItem.FilterMedianOperator;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TemplateDto Map(Template inputItem)
        {
            var dto = new TemplateDto()
            {
                  
  
		TemplateID = inputItem.TemplateID,  
  
		TemplateGUID = inputItem.TemplateGUID,  
  
		IsSystemTemplate = inputItem.IsSystemTemplate,  
  
		TemplateVersion = inputItem.TemplateVersion,  
  
		Title = inputItem.Title,  
  
		Body = inputItem.Body,  
  
		ShowOutgoingMessage = inputItem.ShowOutgoingMessage,  
  
		MessageParameterInfoFullName = inputItem.MessageParameterInfoFullName,  
  
		FilterMedianOperator = inputItem.FilterMedianOperator,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<TemplateDto> Map(ICollection<Template> entities)
        {
            var dtos = new List<TemplateDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TemplateDto()
                {
                      
  
		TemplateID = inputItem.TemplateID,  
  
		TemplateGUID = inputItem.TemplateGUID,  
  
		IsSystemTemplate = inputItem.IsSystemTemplate,  
  
		TemplateVersion = inputItem.TemplateVersion,  
  
		Title = inputItem.Title,  
  
		Body = inputItem.Body,  
  
		ShowOutgoingMessage = inputItem.ShowOutgoingMessage,  
  
		MessageParameterInfoFullName = inputItem.MessageParameterInfoFullName,  
  
		FilterMedianOperator = inputItem.FilterMedianOperator,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TemplateContact Map(AddTemplateContactCommand inputItem)
        {
            var entity = new TemplateContact() {
                  
  
		TemplateContactID = inputItem.TemplateContactID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		Phone = inputItem.Phone,  
  
		ContactPhoneRef = inputItem.ContactPhoneRef,  
  
		ContactType = inputItem.ContactType,  
  
		ParameterName = inputItem.ParameterName, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TemplateContact Map(TemplateContact entity ,EditTemplateContactCommand inputItem)
        {
              
  
		entity.TemplateContactID = inputItem.TemplateContactID;  
  
		entity.TemplateRef = inputItem.TemplateRef;  
  
		entity.Phone = inputItem.Phone;  
  
		entity.ContactPhoneRef = inputItem.ContactPhoneRef;  
  
		entity.ContactType = inputItem.ContactType;  
  
		entity.ParameterName = inputItem.ParameterName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TemplateContactDto Map(TemplateContact inputItem)
        {
            var dto = new TemplateContactDto()
            {
                  
  
		TemplateContactID = inputItem.TemplateContactID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		Phone = inputItem.Phone,  
  
		ContactPhoneRef = inputItem.ContactPhoneRef,  
  
		ContactType = inputItem.ContactType,  
  
		ParameterName = inputItem.ParameterName, 
            };
            return dto;
        }

        public static List<TemplateContactDto> Map(ICollection<TemplateContact> entities)
        {
            var dtos = new List<TemplateContactDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TemplateContactDto()
                {
                      
  
		TemplateContactID = inputItem.TemplateContactID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		Phone = inputItem.Phone,  
  
		ContactPhoneRef = inputItem.ContactPhoneRef,  
  
		ContactType = inputItem.ContactType,  
  
		ParameterName = inputItem.ParameterName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TemplateEvent Map(AddTemplateEventCommand inputItem)
        {
            var entity = new TemplateEvent() {
                  
  
		TemplateEventID = inputItem.TemplateEventID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		EventKey = inputItem.EventKey, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TemplateEvent Map(TemplateEvent entity ,EditTemplateEventCommand inputItem)
        {
              
  
		entity.TemplateEventID = inputItem.TemplateEventID;  
  
		entity.TemplateRef = inputItem.TemplateRef;  
  
		entity.EventKey = inputItem.EventKey; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TemplateEventDto Map(TemplateEvent inputItem)
        {
            var dto = new TemplateEventDto()
            {
                  
  
		TemplateEventID = inputItem.TemplateEventID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		EventKey = inputItem.EventKey, 
            };
            return dto;
        }

        public static List<TemplateEventDto> Map(ICollection<TemplateEvent> entities)
        {
            var dtos = new List<TemplateEventDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TemplateEventDto()
                {
                      
  
		TemplateEventID = inputItem.TemplateEventID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		EventKey = inputItem.EventKey, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TemplateFilter Map(AddTemplateFilterCommand inputItem)
        {
            var entity = new TemplateFilter() {
                  
  
		TemplateFilterID = inputItem.TemplateFilterID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		ParameterName = inputItem.ParameterName,  
  
		FilterCondition = inputItem.FilterCondition,  
  
		Value = inputItem.Value,  
  
		Operator = inputItem.Operator, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TemplateFilter Map(TemplateFilter entity ,EditTemplateFilterCommand inputItem)
        {
              
  
		entity.TemplateFilterID = inputItem.TemplateFilterID;  
  
		entity.TemplateRef = inputItem.TemplateRef;  
  
		entity.ParameterName = inputItem.ParameterName;  
  
		entity.FilterCondition = inputItem.FilterCondition;  
  
		entity.Value = inputItem.Value;  
  
		entity.Operator = inputItem.Operator; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TemplateFilterDto Map(TemplateFilter inputItem)
        {
            var dto = new TemplateFilterDto()
            {
                  
  
		TemplateFilterID = inputItem.TemplateFilterID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		ParameterName = inputItem.ParameterName,  
  
		FilterCondition = inputItem.FilterCondition,  
  
		Value = inputItem.Value,  
  
		Operator = inputItem.Operator, 
            };
            return dto;
        }

        public static List<TemplateFilterDto> Map(ICollection<TemplateFilter> entities)
        {
            var dtos = new List<TemplateFilterDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TemplateFilterDto()
                {
                      
  
		TemplateFilterID = inputItem.TemplateFilterID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		ParameterName = inputItem.ParameterName,  
  
		FilterCondition = inputItem.FilterCondition,  
  
		Value = inputItem.Value,  
  
		Operator = inputItem.Operator, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TemplateScheduling Map(AddTemplateSchedulingCommand inputItem)
        {
            var entity = new TemplateScheduling() {
                  
  
		TemplateSchedulingID = inputItem.TemplateSchedulingID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		SchedulingRef = inputItem.SchedulingRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TemplateScheduling Map(TemplateScheduling entity ,EditTemplateSchedulingCommand inputItem)
        {
              
  
		entity.TemplateSchedulingID = inputItem.TemplateSchedulingID;  
  
		entity.TemplateRef = inputItem.TemplateRef;  
  
		entity.SchedulingRef = inputItem.SchedulingRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TemplateSchedulingDto Map(TemplateScheduling inputItem)
        {
            var dto = new TemplateSchedulingDto()
            {
                  
  
		TemplateSchedulingID = inputItem.TemplateSchedulingID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		SchedulingRef = inputItem.SchedulingRef, 
            };
            return dto;
        }

        public static List<TemplateSchedulingDto> Map(ICollection<TemplateScheduling> entities)
        {
            var dtos = new List<TemplateSchedulingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TemplateSchedulingDto()
                {
                      
  
		TemplateSchedulingID = inputItem.TemplateSchedulingID,  
  
		TemplateRef = inputItem.TemplateRef,  
  
		SchedulingRef = inputItem.SchedulingRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
