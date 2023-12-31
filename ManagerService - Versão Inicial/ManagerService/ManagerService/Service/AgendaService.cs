﻿using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using ManagerService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Service
{
    internal class AgendaService
    {
        private AgendaRepository _repository;

        public AgendaService() => _repository = new AgendaRepository();

        public Agenda GetAgenda(int id) => _repository.GetById(id);

        public List<AgendaGetAllDto> GetAgendaSemana(DateTime dataInicio, DateTime dataFim) => _repository.GetBetweenDate(dataInicio, dataFim);

        public List<AgendaGetAllDto> GetAgendaHoje(DateTime dataAtual) => _repository.GetBetweenDate(dataAtual, dataAtual);

        public void IncluirAgenda(AgendaPostDto dto, List<int> servicos) => _repository.IncluirAgenda(dto, servicos);

        public float GetValorServicos(int idAgenda) => _repository.GetValorServicos(idAgenda);
    }
}
