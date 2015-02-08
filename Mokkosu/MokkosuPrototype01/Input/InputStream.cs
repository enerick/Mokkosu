﻿using Mokkosu.Utils;
using System.Collections.Generic;
using System.IO;

namespace Mokkosu.Input
{
    class InputStream
    {
        Queue<SourceFile> _source_queue = new Queue<SourceFile>();
        Stack<SourceFile> _source_stack = new Stack<SourceFile>();
        SourceFile _current_srcfile = null;
        int _ch = -1;

        public void AddSourceFile(string fname)
        {
            var tr = new StreamReader(fname);
            var srcfile = new SourceFile(tr, fname);
            _source_queue.Enqueue(srcfile);
        }

        public void IncludeSourceFile(string fname)
        {
            _source_stack.Push(_current_srcfile);
            var tr = new StreamReader(fname);
            _current_srcfile = new SourceFile(tr, fname);
        }

        public void NextChar()
        {
            while (true)
            {
                if (_current_srcfile != null)
                {
                    _ch = _current_srcfile.Read();
                }
                if (_ch == -1)
                {
                    if (_source_stack.Count > 0)
                    {
                        _current_srcfile.Close();
                        _current_srcfile = _source_stack.Pop();
                        continue;
                    }
                    else if (_source_queue.Count > 0)
                    {
                        _current_srcfile.Close();
                        _current_srcfile = _source_queue.Dequeue();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public char Char
        {
            get
            {
                if (_ch == -1)
                {
                    throw new MError("構文エラー (予期しないファイル終端)");
                }
                else
                {
                    return (char)_ch;
                }
            }
        }

        public string Pos
        {
            get
            {
                return _current_srcfile.ToString();
            }
        }

        public bool IsEof()
        {
            return _ch == -1;
        }

        public bool IsWhiteSpace()
        {
            return !IsEof() && char.IsWhiteSpace(Char);
        }

        public bool IsDigit()
        {
            return !IsEof() && char.IsDigit(Char);
        }

        public bool IsIdStartChar()
        {
            return !IsEof() && (char.IsLetter(Char) || Char == '_');
        }

        public bool IsIdChar()
        {
            return !IsEof() && (char.IsLetterOrDigit(Char) || Char == '_');
        }

        public void SkipSpace()
        {
            while (IsWhiteSpace())
            {
                NextChar();
            }
        }
    }
}