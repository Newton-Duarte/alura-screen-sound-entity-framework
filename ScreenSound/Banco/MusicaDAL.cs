﻿using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal class MusicaDAL
{
    private readonly ScreenSoundContext context;

    public MusicaDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<Musica> Listar()
    {
        return context.Musicas.ToList();
    }

    public Musica? RecuperarPeloNome(string nome)
    {
        return context.Musicas.First((musica) => musica.Equals(nome));
    }

    public void Adicionar(Musica musica)
    {
        context.Musicas.Add(musica);
        context.SaveChanges();
    }

    public void Atualizar(Musica musica)
    {
        context.Musicas.Update(musica);
        context.SaveChanges();
    }

    public void Deletar(Musica musica)
    {
        context.Musicas.Remove(musica);
        context.SaveChanges();
    }
}