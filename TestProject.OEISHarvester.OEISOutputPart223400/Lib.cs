using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A261782
{
public static readonly long[] Value={ 16L,32L,64L,128L,243L,256L,512L,1024L,2048L,2744L,4096L,6561L,8192L,16384L,32768L,65536L,131072L,177147L,185193L,262144L,474552L,524288L,614656L,810000L,941192L,1048576L,1124864L,1419857L,1500625L,2097152L,3241792L,4194304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261782Inst : IEnumerable<long>
{
public static readonly long[] Value=A261782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261782.Bytes);
public long this[int i]=>Value[i];

public static A261782Inst Instance=new A261782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261783
{
public static readonly BigInteger[] Value={ 1L,1L,7L,73L,1031L,18501L,403495L,10366833L,306717703L,10271072557L,384058268507L,15861842372465L,717135437119271L,35228475333207937L,1868440035684996207L,BigInteger.Parse("106412817671933423073"),BigInteger.Parse("6477200889282232394759"),BigInteger.Parse("419626639092214594301373"),BigInteger.Parse("28829330550533269570699411") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261783Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261783.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261783Inst Instance=new A261783Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261784
{
public static readonly BigInteger[] Value={ 1L,2L,66L,5546L,893490L,235804122L,92540869002L,50592275219138L,36763980389367378L,BigInteger.Parse("34277110454602760762"),BigInteger.Parse("39890088439337327537706"),BigInteger.Parse("56678337951284473917309346"),BigInteger.Parse("96562013312452672907356749786"),BigInteger.Parse("194303876852797223949281552591106"),BigInteger.Parse("455927121076167354458618221923117282") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261784Inst Instance=new A261784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261785
{
public static readonly BigInteger[] Value={ 1L,1L,4L,13L,101L,571L,6735L,54713L,873019L,9274471L,187278048L,2460190261L,60205154959L,942541045811L,27121249048036L,492972449490417L,16312991079531595L,337650093459084079L,12633283010644517490UL,BigInteger.Parse("293339323822142071021"),BigInteger.Parse("12245145846336974734339") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261785Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261785.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261785Inst Instance=new A261785Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261786
{
public static readonly long[] Value={ 1L,3L,5L,8L,9L,11L,15L,18L,19L,22L,25L,28L,30L,32L,36L,38L,43L,46L,49L,52L,55L,58L,61L,64L,68L,71L,74L,75L,79L,82L,84L,86L,90L,92L,96L,100L,104L,108L,110L,115L,120L,122L,125L,128L,131L,134L,137L,140L,143L,146L,150L,153L,156L,160L,163L,166L,169L,172L,176L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261786Inst : IEnumerable<long>
{
public static readonly long[] Value=A261786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261786.Bytes);
public long this[int i]=>Value[i];

public static A261786Inst Instance=new A261786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261787
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,3L,1L,3L,1L,2L,2L,4L,2L,2L,3L,3L,3L,3L,1L,3L,1L,4L,3L,3L,1L,3L,1L,2L,2L,4L,2L,2L,4L,4L,4L,4L,2L,2L,5L,2L,2L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,1L,3L,1L,4L,3L,3L,1L,3L,1L,4L,4L,4L,5L,3L,3L,3L,3L,3L,1L,3L,1L,4L,3L,3L,1L,3L,1L,2L,2L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261787Inst : IEnumerable<long>
{
public static readonly long[] Value=A261787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261787.Bytes);
public long this[int i]=>Value[i];

public static A261787Inst Instance=new A261787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261788
{
public static readonly long[] Value={ 1L,2L,5L,12L,30L,81L,224L,626L,1747L,4909L,13811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261788Inst : IEnumerable<long>
{
public static readonly long[] Value=A261788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261788.Bytes);
public long this[int i]=>Value[i];

public static A261788Inst Instance=new A261788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261789
{
public static readonly long[] Value={ 2L,2L,3L,1L,2L,4L,3L,1L,3L,3L,3L,2L,2L,4L,2L,5L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,1L,4L,3L,2L,2L,4L,2L,4L,4L,4L,4L,2L,5L,5L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,3L,3L,3L,4L,3L,3L,1L,4L,3L,4L,4L,5L,3L,3L,3L,3L,3L,1L,4L,3L,4L,3L,3L,1L,4L,3L,2L,2L,4L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261789Inst : IEnumerable<long>
{
public static readonly long[] Value=A261789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261789.Bytes);
public long this[int i]=>Value[i];

public static A261789Inst Instance=new A261789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261790
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,3L,3L,1L,1L,8L,4L,8L,1L,1L,5L,5L,5L,5L,1L,1L,12L,3L,4L,3L,12L,1L,1L,7L,7L,7L,7L,7L,7L,1L,1L,16L,8L,16L,4L,16L,8L,16L,1L,1L,9L,9L,3L,9L,9L,3L,9L,9L,1L,1L,20L,5L,20L,5L,4L,5L,20L,5L,20L,1L,1L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,1L,1L,24L,12L,8L,3L,24L,4L,24L,3L,8L,12L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261790Inst : IEnumerable<long>
{
public static readonly long[] Value=A261790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261790.Bytes);
public long this[int i]=>Value[i];

public static A261790Inst Instance=new A261790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261791
{
public static readonly long[] Value={ 19L,157L,532L,1263L,2467L,4263L,6770L,10106L,14389L,19739L,26272L,34109L,43367L,54164L,66619L,80851L,96978L,115119L,135391L,157913L,182804L,210183L,240166L,272874L,308425L,346936L,388526L,433315L,481419L,532958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261791Inst : IEnumerable<long>
{
public static readonly long[] Value=A261791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261791.Bytes);
public long this[int i]=>Value[i];

public static A261791Inst Instance=new A261791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261792
{
public static readonly long[] Value={ 5L,7L,17L,31L,59L,83L,89L,151L,167L,233L,251L,373L,443L,467L,479L,601L,643L,719L,863L,911L,1019L,1097L,1151L,1187L,1291L,1439L,1553L,1637L,1759L,1931L,2207L,2861L,3023L,3389L,3449L,3539L,3659L,3719L,3779L,3967L,4759L,4793L,4861L,5471L,5507L,6269L,6551L,6959L,7039L,7079L,7643L,7727L,7853L,7937L,8623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261792Inst : IEnumerable<long>
{
public static readonly long[] Value=A261792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261792.Bytes);
public long this[int i]=>Value[i];

public static A261792Inst Instance=new A261792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261793
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,9L,10L,12L,15L,17L,19L,21L,24L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261793Inst : IEnumerable<long>
{
public static readonly long[] Value=A261793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261793.Bytes);
public long this[int i]=>Value[i];

public static A261793Inst Instance=new A261793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261794
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261794Inst : IEnumerable<long>
{
public static readonly long[] Value=A261794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261794.Bytes);
public long this[int i]=>Value[i];

public static A261794Inst Instance=new A261794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261795
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,2L,2L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261795Inst : IEnumerable<long>
{
public static readonly long[] Value=A261795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261795.Bytes);
public long this[int i]=>Value[i];

public static A261795Inst Instance=new A261795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261796
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,5L,4L,4L,5L,6L,7L,8L,9L,9L,10L,12L,13L,14L,15L,16L,17L,20L,23L,24L,26L,28L,30L,33L,37L,40L,42L,46L,50L,55L,60L,65L,68L,72L,79L,86L,93L,101L,108L,114L,123L,134L,144L,153L,164L,174L,186L,203L,219L,233L,247L,263L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261796Inst : IEnumerable<long>
{
public static readonly long[] Value=A261796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261796.Bytes);
public long this[int i]=>Value[i];

public static A261796Inst Instance=new A261796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261797
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,6L,7L,11L,12L,16L,19L,25L,29L,37L,43L,55L,63L,78L,90L,110L,127L,153L,176L,211L,242L,286L,328L,386L,441L,515L,586L,682L,775L,895L,1016L,1169L,1323L,1514L,1711L,1953L,2201L,2502L,2815L,3191L,3582L,4048L,4536L,5113L,5719L,6429L,7179L,8052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261797Inst : IEnumerable<long>
{
public static readonly long[] Value=A261797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261797.Bytes);
public long this[int i]=>Value[i];

public static A261797Inst Instance=new A261797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261798
{
public static readonly long[] Value={ 0L,0L,0L,15L,59L,0L,361L,704L,1247L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261798Inst : IEnumerable<long>
{
public static readonly long[] Value=A261798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261798.Bytes);
public long this[int i]=>Value[i];

public static A261798Inst Instance=new A261798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261799
{
public static readonly BigInteger[] Value={ 1L,7L,77L,819L,8687L,92141L,977347L,10366833L,109962202L,1166381804L,12371946734L,131230670312L,1391978902090L,14764881252772L,156612803600094L,1661210126351328L,17620647995924820L,186904251828901124L,1982515022137687464L,BigInteger.Parse("21028766197355391048") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261799Inst Instance=new A261799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261800
{
public static readonly BigInteger[] Value={ 1L,8L,100L,1208L,14554L,175352L,2112772L,25456328L,306717703L,3695574048L,44527157584L,536497912672L,6464145163032L,77885061063584L,938419943222768L,11306815168562400L,136233325153964242L,1641445323534504928L,BigInteger.Parse("19777413104380161776"),BigInteger.Parse("238293693669343744032") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261800Inst Instance=new A261800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261801
{
public static readonly BigInteger[] Value={ 1L,9L,126L,1704L,22986L,310086L,4183260L,56435004L,761346207L,10271072557L,138563678736L,1869317246556L,25218347263608L,340212470558832L,4589695110222504L,61918074814238448L,835316485437693186L,11268981358631127288UL,BigInteger.Parse("152026139882340589466") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261801Inst Instance=new A261801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261802
{
public static readonly BigInteger[] Value={ 1L,10L,155L,2320L,34640L,517252L,7723970L,115339960L,1722340115L,25719233330L,384058268507L,5735036957760L,85639736481880L,1278834734405320L,19096488909285540L,285162639746429024L,4258255614078447290L,BigInteger.Parse("63587365059302801520"),BigInteger.Parse("949532710487622388080") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261802Inst Instance=new A261802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261803
{
public static readonly long[] Value={ 50L,334L,516L,670L,844L,1164L,1250L,1800L,2450L,9800L,14450L,20000L,24200L,101250L,105800L,135200L,162450L,168200L,204800L,304200L,336200L,451250L,480200L,490050L,530450L,696200L,924800L,966050L,1008200L,1125000L,1155200L,1428050L,1805000L,2332800L,2420000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261803Inst : IEnumerable<long>
{
public static readonly long[] Value=A261803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261803.Bytes);
public long this[int i]=>Value[i];

public static A261803Inst Instance=new A261803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261804
{
public static readonly long[] Value={ 1L,1L,2L,6L,7L,3L,3L,8L,6L,7L,3L,1L,7L,0L,5L,6L,6L,4L,6L,4L,2L,7L,8L,1L,2L,4L,9L,1L,8L,5L,4L,9L,8L,4L,2L,7L,2L,2L,2L,1L,9L,9L,6L,9L,5L,7L,4L,0L,3L,6L,0L,2L,9L,6L,3L,8L,4L,2L,3L,9L,6L,0L,3L,8L,6L,3L,6L,6L,7L,8L,3L,3L,7L,5L,8L,4L,3L,2L,1L,0L,4L,6L,8L,7L,2L,4L,0L,4L,1L,6L,4L,1L,5L,8L,5L,6L,9L,9L,6L,4L,6L,7L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261804Inst : IEnumerable<long>
{
public static readonly long[] Value=A261804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261804.Bytes);
public long this[int i]=>Value[i];

public static A261804Inst Instance=new A261804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261805
{
public static readonly long[] Value={ 2L,0L,5L,2L,4L,6L,6L,8L,2L,7L,2L,6L,9L,2L,7L,1L,2L,2L,8L,1L,7L,6L,3L,3L,7L,7L,9L,9L,1L,7L,3L,3L,8L,3L,9L,9L,1L,7L,0L,8L,3L,7L,7L,5L,2L,9L,9L,6L,5L,5L,8L,2L,1L,9L,3L,2L,3L,7L,3L,2L,4L,5L,7L,7L,5L,3L,4L,9L,9L,4L,1L,3L,2L,8L,7L,5L,2L,7L,0L,6L,1L,4L,6L,9L,8L,5L,1L,9L,8L,8L,3L,9L,4L,1L,3L,1L,7L,5L,1L,0L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261805Inst : IEnumerable<long>
{
public static readonly long[] Value=A261805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261805.Bytes);
public long this[int i]=>Value[i];

public static A261805Inst Instance=new A261805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261806
{
public static readonly long[] Value={ 7L,474L,42311L,3558614L,300169143L,25814402881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261806Inst : IEnumerable<long>
{
public static readonly long[] Value=A261806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261806.Bytes);
public long this[int i]=>Value[i];

public static A261806Inst Instance=new A261806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261807
{
public static readonly long[] Value={ 0L,0L,10L,24L,68L,120L,222L,336L,520L,720L,994L,1336L,1740L,2200L,2742L,3360L,4112L,4896L,5850L,6872L,8020L,9272L,10638L,12176L,13848L,15632L,17586L,19704L,21980L,24408L,26982L,29760L,32800L,35904L,39338L,42840L,46692L,50680L,54910L,59280L,64040L,68880L,74050L,79544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261807Inst : IEnumerable<long>
{
public static readonly long[] Value=A261807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261807.Bytes);
public long this[int i]=>Value[i];

public static A261807Inst Instance=new A261807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261808
{
public static readonly long[] Value={ 0L,1L,5L,8L,17L,37L,48L,65L,257L,288L,1025L,1088L,2305L,4097L,4224L,4357L,9217L,12320L,16385L,16640L,20737L,25920L,36865L,50624L,65537L,66048L,147457L,229440L,262145L,263168L,264197L,295937L,589825L,1048577L,1050624L,1052677L,2166785L,2359297L,4194305L,4198400L,4202501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261808Inst : IEnumerable<long>
{
public static readonly long[] Value=A261808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261808.Bytes);
public long this[int i]=>Value[i];

public static A261808Inst Instance=new A261808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261809
{
public static readonly BigInteger[] Value={ -1L,-1L,1L,17L,109L,707L,5023L,40301L,362857L,3628771L,39916769L,479001563L,6227020759L,87178291157L,1307674367953L,20922789887947L,355687428095941L,6402373705727939L,121645100408831933L,2432902008176639929L,BigInteger.Parse("51090942171709439927"),BigInteger.Parse("1124000727777607679921") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261809Inst Instance=new A261809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261810
{
public static readonly long[] Value={ 2L,3L,5L,11L,23L,59L,71L,113L,131L,137L,149L,179L,227L,257L,263L,269L,293L,317L,347L,353L,401L,419L,443L,449L,467L,557L,653L,659L,677L,683L,743L,773L,809L,839L,857L,881L,911L,929L,947L,977L,1019L,1049L,1277L,1301L,1319L,1433L,1571L,1697L,1847L,1871L,1901L,1913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261810Inst : IEnumerable<long>
{
public static readonly long[] Value=A261810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261810.Bytes);
public long this[int i]=>Value[i];

public static A261810Inst Instance=new A261810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261811
{
public static readonly long[] Value={ 4L,8L,12L,13L,16L,20L,24L,32L,36L,40L,44L,48L,52L,56L,64L,68L,72L,76L,77L,80L,84L,88L,96L,100L,104L,108L,112L,116L,120L,122L,128L,132L,136L,140L,141L,144L,148L,152L,160L,164L,168L,172L,176L,180L,184L,192L,196L,200L,204L,205L,208L,212L,216L,224L,228L,232L,236L,240L,244L,248L,256L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261811Inst : IEnumerable<long>
{
public static readonly long[] Value=A261811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261811.Bytes);
public long this[int i]=>Value[i];

public static A261811Inst Instance=new A261811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261812
{
public static readonly long[] Value={ -2L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261812Inst : IEnumerable<long>
{
public static readonly long[] Value=A261812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261812.Bytes);
public long this[int i]=>Value[i];

public static A261812Inst Instance=new A261812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261813
{
public static readonly long[] Value={ 9L,8L,1L,0L,5L,7L,9L,7L,3L,0L,8L,7L,6L,1L,1L,4L,9L,7L,7L,3L,9L,6L,8L,0L,2L,8L,1L,4L,2L,0L,0L,0L,5L,0L,8L,2L,5L,7L,0L,4L,0L,9L,5L,2L,1L,0L,2L,9L,9L,5L,8L,4L,8L,5L,6L,3L,5L,0L,4L,2L,0L,2L,5L,9L,4L,0L,7L,4L,9L,2L,1L,4L,1L,8L,5L,4L,3L,8L,3L,5L,5L,0L,9L,4L,8L,8L,3L,8L,9L,9L,8L,5L,9L,7L,0L,0L,6L,9L,5L,9L,5L,1L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261813Inst : IEnumerable<long>
{
public static readonly long[] Value=A261813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261813.Bytes);
public long this[int i]=>Value[i];

public static A261813Inst Instance=new A261813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261814
{
public static readonly long[] Value={ 2L,3L,6L,3L,3L,12L,9L,3L,18L,3L,7L,24L,7L,9L,30L,3L,7L,36L,25L,7L,42L,7L,15L,48L,33L,7L,54L,9L,19L,60L,27L,21L,66L,7L,15L,72L,43L,25L,78L,7L,27L,84L,57L,19L,90L,15L,27L,96L,43L,33L,102L,7L,15L,108L,73L,37L,114L,19L,39L,120L,27L,27L,126L,21L,43L,132L,39L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261814Inst : IEnumerable<long>
{
public static readonly long[] Value=A261814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261814.Bytes);
public long this[int i]=>Value[i];

public static A261814Inst Instance=new A261814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261815
{
public static readonly long[] Value={ 1L,0L,72L,549504L,4632344409600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261815Inst : IEnumerable<long>
{
public static readonly long[] Value=A261815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261815.Bytes);
public long this[int i]=>Value[i];

public static A261815Inst Instance=new A261815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261816
{
public static readonly long[] Value={ 1L,0L,1L,477L,160845292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261816Inst : IEnumerable<long>
{
public static readonly long[] Value=A261816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261816.Bytes);
public long this[int i]=>Value[i];

public static A261816Inst Instance=new A261816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261817
{
public static readonly long[] Value={ 0L,-1L,1L,2L,2L,1L,-1L,0L,16L,-3L,-87L,-242L,678L,-439L,-3620L,-3961L,4334L,-95L,95L,4524L,54001L,64350L,-87309L,-937766L,17314434L,-542208643L,3200800363L,3953925422L,-4558246642L,-15110328113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261817Inst : IEnumerable<long>
{
public static readonly long[] Value=A261817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261817.Bytes);
public long this[int i]=>Value[i];

public static A261817Inst Instance=new A261817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261818
{
public static readonly BigInteger[] Value={ 1L,313L,93139L,3931393L,11393139311L,1113931393111L,17111393139311171L,BigInteger.Parse("331711139313931117133"),BigInteger.Parse("3333171113931393111713333"),BigInteger.Parse("133331711139313931117133331"),BigInteger.Parse("1813333171113931393111713333181"),BigInteger.Parse("1951813333171113931393111713333181591") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261818Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261818.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261818Inst Instance=new A261818Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261819
{
public static readonly long[] Value={ 1L,6L,16L,40L,384L,576L,4096L,10240L,17408L,393216L,589824L,1081344L,16777216L,41943040L,71303168L,136314880L,6442450944L,9663676416L,17716740096L,34628173824L,1099511627776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261819Inst : IEnumerable<long>
{
public static readonly long[] Value=A261819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261819.Bytes);
public long this[int i]=>Value[i];

public static A261819Inst Instance=new A261819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261820
{
public static readonly BigInteger[] Value={ 111L,1311131L,113111311L,91131113119L,9911311131199L,12991131113119921L,BigInteger.Parse("771299113111311992177"),BigInteger.Parse("1077129911311131199217701"),BigInteger.Parse("11107712991131113119921770111"),BigInteger.Parse("101110771299113111311992177011101"),BigInteger.Parse("107101110771299113111311992177011101701") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261820Inst Instance=new A261820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261821
{
public static readonly BigInteger[] Value={ 4L,11411L,1114111L,18111411181L,741811141118147L,1674181114111814761L,BigInteger.Parse("90167418111411181476109"),BigInteger.Parse("3901674181114111814761093"),BigInteger.Parse("14390167418111411181476109341"),BigInteger.Parse("9143901674181114111814761093419"),BigInteger.Parse("75914390167418111411181476109341957") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261821Inst Instance=new A261821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261822
{
public static readonly BigInteger[] Value={ 5L,151L,31513L,3315133L,11331513311L,191133151331191L,9919113315133119199UL,BigInteger.Parse("39991911331513311919993"),BigInteger.Parse("353999191133151331191999353"),BigInteger.Parse("13539991911331513311919993531"),BigInteger.Parse("741353999191133151331191999353147") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261822Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261822.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261822Inst Instance=new A261822Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261823
{
public static readonly BigInteger[] Value={ 6L,10601L,3106013L,19310601391L,3193106013913L,30319310601391303L,3303193106013913033L,BigInteger.Parse("333031931060139130333"),BigInteger.Parse("33330319310601391303333"),BigInteger.Parse("303333031931060139130333303"),BigInteger.Parse("1130333303193106013913033330311"),BigInteger.Parse("19113033330319310601391303333031191") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261823Inst Instance=new A261823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261824
{
public static readonly BigInteger[] Value={ 7L,373L,93739L,129373921L,3212937392123L,34321293739212343L,BigInteger.Parse("353432129373921234353"),BigInteger.Parse("1335343212937392123435331"),BigInteger.Parse("1171335343212937392123435331711"),BigInteger.Parse("1051171335343212937392123435331711501"),BigInteger.Parse("74105117133534321293739212343533171150147") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261824Inst Instance=new A261824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261825
{
public static readonly BigInteger[] Value={ 8L,181L,1218121L,15121812151L,111512181215111L,3311151218121511133L,BigInteger.Parse("133111512181215111331"),BigInteger.Parse("1113311151218121511133111"),BigInteger.Parse("1141113311151218121511133111411"),BigInteger.Parse("73114111331115121812151113311141137"),BigInteger.Parse("30273114111331115121812151113311141137203") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261825Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261825.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261825Inst Instance=new A261825Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261826
{
public static readonly BigInteger[] Value={ 9L,191L,71917L,147191741L,3914719174193L,139147191741931L,7213914719174193127L,BigInteger.Parse("33721391471917419312733"),BigInteger.Parse("9337213914719174193127339"),BigInteger.Parse("1719337213914719174193127339171"),BigInteger.Parse("11171933721391471917419312733917111"),BigInteger.Parse("1111719337213914719174193127339171111") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261826Inst Instance=new A261826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261827
{
public static readonly long[] Value={ 6L,0L,3L,5L,7L,1L,1L,7L,1L,4L,3L,0L,6L,9L,2L,3L,3L,3L,4L,6L,2L,8L,3L,9L,9L,0L,5L,2L,9L,2L,6L,0L,9L,4L,6L,1L,8L,0L,8L,0L,6L,1L,7L,5L,7L,4L,8L,1L,3L,6L,8L,9L,5L,4L,6L,1L,0L,7L,0L,6L,6L,8L,5L,6L,8L,3L,6L,0L,6L,9L,2L,0L,3L,4L,8L,2L,2L,1L,1L,6L,6L,9L,3L,7L,3L,9L,5L,4L,6L,8L,6L,6L,3L,3L,3L,4L,2L,3L,3L,0L,5L,4L,4L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261827Inst : IEnumerable<long>
{
public static readonly long[] Value=A261827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261827.Bytes);
public long this[int i]=>Value[i];

public static A261827Inst Instance=new A261827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261828
{
public static readonly BigInteger[] Value={ 1L,1L,15L,832L,14791L,2008546L,55380132L,2868333476L,511805155863L,31512728488918L,2638310862477610L,926651539894899446L,BigInteger.Parse("74254761492776175196"),BigInteger.Parse("6851495812540548188072"),BigInteger.Parse("9541620342114654822145972"),BigInteger.Parse("611287722968440282212322702"),BigInteger.Parse("58354641005988089624088037623") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261828Inst Instance=new A261828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261829
{
public static readonly long[] Value={ 0L,8L,2L,7L,1L,0L,5L,7L,1L,8L,5L,0L,2L,2L,5L,4L,6L,4L,6L,0L,6L,9L,5L,9L,8L,3L,0L,1L,2L,1L,3L,9L,0L,3L,2L,1L,3L,8L,2L,0L,1L,8L,1L,9L,0L,1L,6L,7L,6L,0L,0L,8L,9L,1L,8L,3L,3L,2L,6L,1L,1L,5L,3L,1L,7L,8L,6L,7L,9L,8L,4L,9L,8L,3L,3L,2L,8L,8L,5L,8L,6L,3L,7L,9L,7L,6L,2L,5L,5L,0L,1L,6L,6L,2L,5L,4L,3L,7L,7L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261829Inst : IEnumerable<long>
{
public static readonly long[] Value=A261829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261829.Bytes);
public long this[int i]=>Value[i];

public static A261829Inst Instance=new A261829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261830
{
public static readonly long[] Value={ 0L,4L,2L,8L,5L,3L,7L,4L,0L,6L,5L,0L,2L,9L,0L,9L,4L,4L,5L,5L,6L,6L,2L,3L,0L,4L,0L,5L,5L,6L,1L,9L,9L,1L,9L,0L,2L,9L,7L,4L,7L,5L,9L,3L,2L,1L,2L,3L,4L,4L,3L,8L,8L,0L,7L,4L,0L,3L,4L,2L,4L,4L,2L,0L,3L,1L,4L,9L,9L,1L,4L,7L,7L,7L,0L,0L,8L,8L,6L,7L,9L,6L,3L,3L,1L,8L,3L,3L,3L,5L,6L,3L,9L,6L,5L,3L,2L,2L,3L,6L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261830Inst : IEnumerable<long>
{
public static readonly long[] Value=A261830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261830.Bytes);
public long this[int i]=>Value[i];

public static A261830Inst Instance=new A261830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261831
{
public static readonly long[] Value={ 1L,4L,3L,2L,5L,10L,7L,16L,9L,8L,11L,22L,13L,28L,15L,14L,17L,34L,19L,40L,21L,20L,23L,46L,25L,52L,27L,26L,29L,58L,31L,64L,33L,32L,35L,70L,37L,76L,39L,38L,41L,82L,43L,88L,45L,44L,47L,94L,49L,100L,51L,50L,53L,106L,55L,112L,57L,56L,59L,118L,61L,124L,63L,62L,65L,130L,67L,136L,69L,68L,71L,142L,73L,148L,75L,74L,77L,154L,79L,160L,81L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261831Inst : IEnumerable<long>
{
public static readonly long[] Value=A261831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261831.Bytes);
public long this[int i]=>Value[i];

public static A261831Inst Instance=new A261831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261832
{
public static readonly long[] Value={ 2L,4L,6L,24L,32L,34L,36L,84L,86L,88L,112L,172L,182L,200L,212L,240L,258L,290L,306L,320L,336L,360L,366L,396L,404L,406L,434L,480L,494L,504L,528L,536L,556L,558L,580L,612L,636L,718L,722L,732L,794L,906L,960L,966L,992L,994L,1008L,1020L,1116L,1132L,1176L,1184L,1186L,1212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261832Inst : IEnumerable<long>
{
public static readonly long[] Value=A261832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261832.Bytes);
public long this[int i]=>Value[i];

public static A261832Inst Instance=new A261832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261833
{
public static readonly BigInteger[] Value={ 1L,16L,406L,14866L,740026L,48026266L,3937533706L,397912444666L,48589663862026L,7053101481134266L,1200393616793282506L,BigInteger.Parse("236747809664852265466"),BigInteger.Parse("53564655768153719942026"),BigInteger.Parse("13780851677757681289022266"),BigInteger.Parse("4000515700684222714620799306"),BigInteger.Parse("1301419578177153109817779142266"),BigInteger.Parse("471541578407011294721978551670026") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261833Inst Instance=new A261833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261834
{
public static readonly long[] Value={ 1L,6L,48L,468L,5328L,68928L,994464L,15781920L,272594160L,5081825664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261834Inst : IEnumerable<long>
{
public static readonly long[] Value=A261834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261834.Bytes);
public long this[int i]=>Value[i];

public static A261834Inst Instance=new A261834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261835
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,3L,0L,1L,4L,6L,16L,3L,0L,1L,5L,10L,46L,21L,5L,0L,1L,6L,15L,100L,75L,50L,11L,0L,1L,7L,21L,185L,195L,231L,205L,13L,0L,1L,8L,28L,308L,420L,736L,1414L,292L,19L,0L,1L,9L,36L,476L,798L,1876L,6032L,2376L,587L,27L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261835Inst : IEnumerable<long>
{
public static readonly long[] Value=A261835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261835.Bytes);
public long this[int i]=>Value[i];

public static A261835Inst Instance=new A261835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261836
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,10L,7L,0L,3L,15L,21L,9L,0L,5L,40L,96L,92L,31L,0L,11L,183L,832L,1562L,1305L,403L,0L,13L,266L,1539L,3908L,4955L,3090L,757L,0L,19L,549L,4281L,14791L,26765L,26523L,13671L,2873L,0L,27L,1056L,10902L,50208L,124450L,178456L,148638L,66904L,12607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261836Inst : IEnumerable<long>
{
public static readonly long[] Value=A261836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261836.Bytes);
public long this[int i]=>Value[i];

public static A261836Inst Instance=new A261836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261837
{
public static readonly BigInteger[] Value={ 1L,1L,3L,46L,195L,1876L,51114L,322764L,3644355L,43916950L,2427338628L,18277511616L,272107762602L,3507931293608L,62485721142820L,5810222040368296L,53025343448015811L,913540133071336044L,13871534219465464002UL,BigInteger.Parse("253750203721349071650"),BigInteger.Parse("5307815745011707670820") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261837Inst Instance=new A261837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261838
{
public static readonly BigInteger[] Value={ 1L,1L,2L,20L,48L,264L,4296L,14528L,89472L,593248L,19115360L,75604544L,599169408L,4141674240L,40147321344L,2159264715776L,10240251475456L,92926573965184L,746025520714112L,7285397378650112L,82900557619046912L,7796186873306241024L,BigInteger.Parse("41825012467664893440") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261838Inst Instance=new A261838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261839
{
public static readonly long[] Value={ 5L,0L,5L,4L,2L,9L,4L,7L,4L,6L,8L,3L,5L,1L,9L,2L,4L,1L,6L,4L,2L,4L,5L,0L,4L,8L,1L,9L,0L,8L,4L,3L,2L,1L,4L,9L,1L,8L,8L,6L,6L,9L,0L,1L,4L,5L,6L,8L,2L,6L,2L,8L,6L,4L,9L,8L,2L,6L,6L,4L,7L,1L,2L,8L,7L,5L,7L,3L,3L,4L,7L,3L,3L,7L,6L,1L,7L,5L,9L,0L,6L,8L,2L,7L,1L,6L,4L,5L,3L,3L,1L,8L,1L,5L,0L,0L,1L,3L,6L,6L,1L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261839Inst : IEnumerable<long>
{
public static readonly long[] Value=A261839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261839.Bytes);
public long this[int i]=>Value[i];

public static A261839Inst Instance=new A261839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261840
{
public static readonly long[] Value={ 1L,2L,3L,16L,21L,50L,205L,292L,587L,1110L,4535L,5980L,12447L,20910L,40195L,142520L,196291L,372042L,635081L,1128872L,1873245L,6537466L,8553639L,16333532L,26470861L,46629886L,73222631L,127947300L,385293581L,518212198L,939401193L,1516760160L,2564361235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261840Inst : IEnumerable<long>
{
public static readonly long[] Value=A261840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261840.Bytes);
public long this[int i]=>Value[i];

public static A261840Inst Instance=new A261840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261841
{
public static readonly long[] Value={ 1L,3L,6L,46L,75L,231L,1414L,2376L,5985L,14151L,89454L,135330L,343677L,697017L,1657212L,9439826L,14381055L,33119667L,66361286L,141451860L,283907499L,1642516411L,2346737106L,5367877296L,10093521943L,20923900623L,38428831710L,80538197724L,416229711735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261841Inst : IEnumerable<long>
{
public static readonly long[] Value=A261841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261841.Bytes);
public long this[int i]=>Value[i];

public static A261841Inst Instance=new A261841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261842
{
public static readonly long[] Value={ 1L,4L,10L,100L,195L,736L,6032L,11712L,35285L,100260L,871386L,1492820L,4438573L,10525720L,29825140L,241360728L,405645867L,1086289116L,2489722574L,6158961820L,14573822743L,123303661384L,192326074572L,504783599080L,1073240557055L,2539006453740L,5337585654950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261842Inst : IEnumerable<long>
{
public static readonly long[] Value=A261842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261842.Bytes);
public long this[int i]=>Value[i];

public static A261842Inst Instance=new A261842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261843
{
public static readonly long[] Value={ 1L,5L,15L,185L,420L,1876L,19320L,42610L,149115L,495205L,5516001L,10570145L,35897010L,97383790L,320607680L,3412039628L,6292069835L,19106603405L,49239854095L,138462457915L,378598491878L,4312038483490L,7316190877970L,21527078513430L,50933081112485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261843Inst : IEnumerable<long>
{
public static readonly long[] Value=A261843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261843.Bytes);
public long this[int i]=>Value[i];

public static A261843Inst Instance=new A261843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261844
{
public static readonly long[] Value={ 1L,6L,21L,308L,798L,4116L,51114L,126288L,502947L,1912318L,26074881L,55301652L,210871038L,643901916L,2416831656L,32128430000L,64611765009L,218800524222L,625968110257L,1971079800312L,6127902153366L,88805517515284L,163129580373222L,530136843388056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261844Inst : IEnumerable<long>
{
public static readonly long[] Value=A261844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261844.Bytes);
public long this[int i]=>Value[i];

public static A261844Inst Instance=new A261844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261845
{
public static readonly long[] Value={ 1L,7L,28L,476L,1386L,8106L,117936L,322764L,1440579L,6172495L,99773646L,232110704L,981073576L,3329628176L,14040114012L,224848217580L,490210909629L,1828885568055L,5750093241172L,20040621544916L,69910543160794L,1238596672832718L,2451410591056280L,8705347941656016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261845Inst : IEnumerable<long>
{
public static readonly long[] Value=A261845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261845.Bytes);
public long this[int i]=>Value[i];

public static A261845Inst Instance=new A261845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261846
{
public static readonly long[] Value={ 1L,8L,36L,696L,2250L,14712L,245508L,737352L,3644355L,17376832L,325225824L,823612736L,3820113552L,14264475648L,66782014272L,1254553664640L,2949123559125L,12008271483720L,41150373332932L,157262062899640L,608878151760410L,12804954311547288L,27181470392583156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261846Inst : IEnumerable<long>
{
public static readonly long[] Value=A261846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261846.Bytes);
public long this[int i]=>Value[i];

public static A261846Inst Instance=new A261846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261847
{
public static readonly long[] Value={ 1L,9L,45L,975L,3465L,25047L,471669L,1542519L,8361540L,43916950L,934748298L,2560160538L,12924414750L,52656337800L,271075650210L,5853558884496L,14764118156523L,65116959410547L,241547985000289L,1004388404964615L,4276652360222781L,104392134731727315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261847Inst : IEnumerable<long>
{
public static readonly long[] Value=A261847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261847.Bytes);
public long this[int i]=>Value[i];

public static A261847Inst Instance=new A261847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261848
{
public static readonly long[] Value={ 1L,10L,55L,1320L,5115L,40502L,849695L,3005860L,17729140L,101710180L,2427338628L,7149947740L,39019448520L,172243529680L,967216439310L,23628910183516L,63666698290635L,302259439194130L,1206608816442095L,5423457474305640L,25200103664372021L,701550193438735410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261848Inst : IEnumerable<long>
{
public static readonly long[] Value=A261848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261848.Bytes);
public long this[int i]=>Value[i];

public static A261848Inst Instance=new A261848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261849
{
public static readonly long[] Value={ 0L,0L,1L,4L,9L,16L,21L,32L,45L,60L,69L,88L,101L,120L,145L,164L,185L,216L,241L,276L,293L,332L,365L,392L,437L,476L,509L,556L,593L,648L,681L,732L,785L,832L,885L,936L,989L,1052L,1109L,1176L,1225L,1288L,1353L,1428L,1489L,1560L,1625L,1696L,1781L,1860L,1933L,2016L,2085L,2180L,2241L,2340L,2425L,2512L,2609L,2700L,2793L,2876L,2973L,3080L,3173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261849Inst : IEnumerable<long>
{
public static readonly long[] Value=A261849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261849.Bytes);
public long this[int i]=>Value[i];

public static A261849Inst Instance=new A261849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261850
{
public static readonly long[] Value={ 5L,0L,2L,6L,7L,6L,5L,2L,1L,4L,7L,8L,2L,6L,9L,2L,8L,6L,4L,5L,4L,6L,7L,7L,4L,5L,9L,9L,7L,9L,3L,4L,8L,6L,3L,9L,6L,6L,4L,6L,0L,2L,6L,0L,0L,0L,9L,1L,6L,4L,0L,6L,6L,1L,4L,6L,8L,6L,2L,7L,6L,5L,2L,3L,2L,4L,8L,7L,1L,6L,1L,5L,0L,8L,8L,5L,4L,6L,3L,1L,2L,1L,1L,7L,6L,2L,3L,4L,1L,5L,7L,2L,7L,8L,4L,0L,5L,2L,7L,6L,7L,8L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261850Inst : IEnumerable<long>
{
public static readonly long[] Value=A261850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261850.Bytes);
public long this[int i]=>Value[i];

public static A261850Inst Instance=new A261850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261851
{
public static readonly long[] Value={ 5L,0L,1L,3L,2L,5L,8L,7L,2L,6L,8L,8L,1L,7L,8L,8L,0L,9L,4L,0L,2L,2L,9L,6L,7L,1L,0L,5L,5L,2L,7L,4L,9L,4L,4L,3L,7L,2L,6L,8L,7L,8L,3L,2L,9L,8L,5L,8L,0L,4L,5L,6L,8L,1L,5L,3L,6L,4L,5L,1L,2L,1L,7L,3L,3L,8L,8L,8L,7L,4L,1L,5L,8L,4L,5L,0L,6L,0L,6L,5L,3L,3L,0L,9L,0L,3L,1L,1L,3L,8L,8L,9L,7L,9L,4L,3L,9L,8L,9L,6L,1L,8L,1L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261851Inst : IEnumerable<long>
{
public static readonly long[] Value=A261851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261851.Bytes);
public long this[int i]=>Value[i];

public static A261851Inst Instance=new A261851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261852
{
public static readonly long[] Value={ 5L,0L,0L,6L,5L,8L,8L,9L,1L,2L,9L,7L,6L,7L,0L,5L,4L,3L,3L,1L,4L,5L,5L,7L,1L,2L,7L,0L,8L,2L,9L,8L,6L,8L,3L,8L,3L,8L,4L,0L,7L,3L,2L,5L,2L,3L,4L,0L,4L,5L,4L,0L,3L,8L,8L,8L,8L,6L,4L,3L,8L,0L,4L,7L,6L,6L,2L,1L,7L,1L,8L,2L,0L,3L,3L,4L,1L,3L,5L,8L,7L,6L,5L,4L,5L,6L,6L,2L,7L,0L,9L,0L,8L,1L,5L,1L,6L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261852Inst : IEnumerable<long>
{
public static readonly long[] Value=A261852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261852.Bytes);
public long this[int i]=>Value[i];

public static A261852Inst Instance=new A261852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261853
{
public static readonly long[] Value={ 1L,10L,15L,40L,183L,266L,549L,1056L,4421L,5850L,12245L,20644L,39809L,141818L,195421L,370808L,633379L,1126518L,1870135L,6531964L,8547045L,16324018L,26458275L,46612364L,73200021L,127916094L,385244951L,518151276L,939317459L,1516648678L,2564211485L,4008404972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261853Inst : IEnumerable<long>
{
public static readonly long[] Value=A261853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261853.Bytes);
public long this[int i]=>Value[i];

public static A261853Inst Instance=new A261853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261854
{
public static readonly long[] Value={ 7L,21L,96L,832L,1539L,4281L,10902L,76020L,117585L,306639L,634686L,1537206L,9013319L,13793487L,32005392L,64458596L,138068775L,278292429L,1622912266L,2321086080L,5318890971L,10014128239L,20784037248L,38209197732L,80154402633L,415073903937L,593664848658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261854Inst : IEnumerable<long>
{
public static readonly long[] Value=A261854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261854.Bytes);
public long this[int i]=>Value[i];

public static A261854Inst Instance=new A261854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261855
{
public static readonly long[] Value={ 9L,92L,1562L,3908L,14791L,50208L,540552L,987120L,3138143L,7862580L,23436690L,204455140L,349297653L,956040232L,2228084512L,5599922904L,13449425997L,116772809532L,182990434794L,483410072060L,1033025269277L,2455590595520L,5184309618676L,12755194552152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261855Inst : IEnumerable<long>
{
public static readonly long[] Value=A261855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261855.Bytes);
public long this[int i]=>Value[i];

public static A261855Inst Instance=new A261855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261856
{
public static readonly long[] Value={ 31L,1305L,4955L,26765L,124450L,2008546L,4399870L,17016950L,51516925L,187653115L,2298210803L,4405690315L,14002637160L,37448507530L,109070884580L,308549728478L,3711879979775L,6377942356265L,19056675979455L,45667548869495L,122550455798230L,293681447602030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261856Inst : IEnumerable<long>
{
public static readonly long[] Value=A261856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261856.Bytes);
public long this[int i]=>Value[i];

public static A261856Inst Instance=new A261856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261857
{
public static readonly long[] Value={ 403L,3090L,26523L,178456L,4328268L,11655792L,55380132L,203857488L,908020203L,15089942326L,32659354659L,119798424120L,366557119686L,1229877368940L,4069268482608L,64750089252368L,122070519766665L,408439013722194L,1090232738714433L,3275624230408044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261857Inst : IEnumerable<long>
{
public static readonly long[] Value=A261857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261857.Bytes);
public long this[int i]=>Value[i];

public static A261857Inst Instance=new A261857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261858
{
public static readonly long[] Value={ 757L,13671L,148638L,5623044L,19334910L,115231480L,522931570L,2868333476L,63481817735L,156363633615L,661651830728L,2317522429544L,8940138012274L,34465610055870L,703252581037436L,1456494080466446L,5428978793488341L,16082092961535517L,53836540488601696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261858Inst : IEnumerable<long>
{
public static readonly long[] Value=A261858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261858.Bytes);
public long this[int i]=>Value[i];

public static A261858Inst Instance=new A261858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261859
{
public static readonly long[] Value={ 2873L,66904L,4351388L,20331080L,157483354L,901563512L,6174438308L,180660353288L,511805155863L,2507827775824L,10089884785056L,44796664928048L,200977872433624L,5149800722642960L,11741438872834432L,48645418597510928L,159659060979170671L,593940633500376248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261859Inst : IEnumerable<long>
{
public static readonly long[] Value=A261859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261859.Bytes);
public long this[int i]=>Value[i];

public static A261859Inst Instance=new A261859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261860
{
public static readonly long[] Value={ 12607L,1850013L,13188465L,141059073L,1056825045L,9244127655L,358616974839L,1185100976313L,6776480736882L,31512728488918L,161603593094034L,844675656403032L,26805281002135578L,67485379090772970L,310715577607315770L,1129828504295753862L,4665897718158585321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261860Inst : IEnumerable<long>
{
public static readonly long[] Value=A261860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261860.Bytes);
public long this[int i]=>Value[i];

public static A261860Inst Instance=new A261860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261861
{
public static readonly BigInteger[] Value={ 333051L,4822430L,79871395L,832560780L,9644631215L,503145835150L,1977105518235L,13353202808060L,72444344358890L,431802346970780L,2638310862477610L,102808411342614000L,286995037461236030L,1470656290936993540L,5931973064021096010L,BigInteger.Parse("27203387338778029760") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261861Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261861.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261861Inst Instance=new A261861Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261862
{
public static readonly long[] Value={ 3L,7L,31L,73L,85L,127L,2047L,3133L,4369L,8191L,11275L,49981L,60787L,76627L,121369L,131071L,140911L,178481L,262657L,486737L,524287L,599479L,1082401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261862Inst : IEnumerable<long>
{
public static readonly long[] Value=A261862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261862.Bytes);
public long this[int i]=>Value[i];

public static A261862Inst Instance=new A261862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261863
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,12L,7L,13L,9L,16L,11L,29L,11L,23L,19L,22L,13L,36L,17L,40L,27L,37L,19L,53L,23L,41L,27L,43L,23L,79L,23L,43L,37L,47L,35L,72L,29L,59L,47L,71L,31L,103L,31L,64L,57L,61L,31L,89L,37L,79L,51L,71L,37L,107L,53L,89L,61L,79L,41L,149L,41L,83L,71L,82L,59L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261863Inst : IEnumerable<long>
{
public static readonly long[] Value=A261863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261863.Bytes);
public long this[int i]=>Value[i];

public static A261863Inst Instance=new A261863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261864
{
public static readonly long[] Value={ 0L,2L,4L,6L,16L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261864Inst : IEnumerable<long>
{
public static readonly long[] Value=A261864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261864.Bytes);
public long this[int i]=>Value[i];

public static A261864Inst Instance=new A261864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261865
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,7L,2L,2L,2L,3L,2L,2L,15L,2L,2L,2L,3L,2L,2L,7L,2L,2L,5L,2L,2L,2L,5L,2L,2L,7L,2L,2L,2L,3L,2L,2L,13L,2L,2L,2L,3L,2L,2L,6L,2L,2L,3L,2L,2L,2L,6L,2L,2L,3L,2L,2L,2L,6L,2L,2L,5L,2L,2L,3L,2L,2L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261865Inst : IEnumerable<long>
{
public static readonly long[] Value=A261865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261865.Bytes);
public long this[int i]=>Value[i];

public static A261865Inst Instance=new A261865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261866
{
public static readonly long[] Value={ 1L,0L,2L,2L,5L,6L,13L,16L,28L,38L,60L,80L,122L,162L,234L,312L,436L,576L,789L,1032L,1386L,1802L,2381L,3070L,4008L,5128L,6618L,8414L,10752L,13576L,17210L,21592L,27162L,33890L,42340L,52538L,65244L,80544L,99458L,122208L,150126L,183634L,224527L,273480L,332898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261866Inst : IEnumerable<long>
{
public static readonly long[] Value=A261866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261866.Bytes);
public long this[int i]=>Value[i];

public static A261866Inst Instance=new A261866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261867
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,2L,4L,3L,1L,2L,5L,3L,4L,1L,2L,4L,3L,6L,5L,1L,2L,3L,7L,6L,5L,4L,1L,2L,3L,5L,8L,4L,6L,7L,1L,2L,3L,4L,8L,5L,7L,9L,6L,1L,2L,3L,4L,6L,9L,8L,7L,10L,5L,1L,2L,3L,4L,6L,7L,5L,11L,8L,10L,9L,1L,2L,3L,4L,5L,8L,10L,6L,12L,9L,11L,7L,1L,2L,3L,4L,5L,6L,9L,12L,7L,10L,13L,11L,8L,1L,2L,3L,4L,5L,6L,10L,9L,14L,13L,8L,11L,12L,7L,1L,2L,3L,4L,5L,6L,8L,9L,12L,7L,14L,10L,15L,13L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261867Inst : IEnumerable<long>
{
public static readonly long[] Value=A261867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261867.Bytes);
public long this[int i]=>Value[i];

public static A261867Inst Instance=new A261867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261868
{
public static readonly long[] Value={ 1L,6L,28L,12L,56L,40L,24L,66L,30L,36L,48L,224L,160L,1196L,392L,96L,200L,198L,72L,276L,90L,126L,84L,60L,156L,400L,1330L,728L,280L,144L,324L,440L,910L,1000L,520L,552L,216L,378L,462L,264L,456L,168L,288L,120L,546L,798L,330L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261868Inst : IEnumerable<long>
{
public static readonly long[] Value=A261868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261868.Bytes);
public long this[int i]=>Value[i];

public static A261868Inst Instance=new A261868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261869
{
public static readonly long[] Value={ -3L,-1L,3L,-5L,11L,-13L,7L,0L,10L,-21L,11L,-13L,27L,1L,-15L,-17L,17L,-19L,19L,21L,1L,-45L,23L,0L,26L,-26L,0L,-29L,-1L,-1L,31L,33L,1L,1L,-35L,-37L,75L,1L,-39L,-41L,-1L,-1L,43L,0L,46L,-93L,47L,0L,0L,51L,-51L,-53L,53L,55L,-55L,57L,1L,-117L,59L,-61L,123L,-62L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261869Inst : IEnumerable<long>
{
public static readonly long[] Value=A261869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261869.Bytes);
public long this[int i]=>Value[i];

public static A261869Inst Instance=new A261869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261870
{
public static readonly long[] Value={ 0L,1L,4L,2L,15L,5L,13L,3L,16L,11L,6L,6L,19L,14L,9L,4L,35L,17L,17L,12L,25L,7L,20L,7L,33L,15L,15L,15L,10L,10L,23L,5L,36L,36L,18L,18L,31L,18L,13L,13L,26L,26L,8L,8L,26L,21L,21L,8L,34L,34L,21L,16L,16L,16L,29L,16L,29L,11L,11L,11L,24L,24L,24L,6L,37L,37L,24L,19L,19L,19L,19L,19L,32L,32L,19L,19L,14L,14L,14L,14L,27L,27L,27L,27L,27L,9L,40L,9L,27L,27L,22L,22L,22L,22L,22L,9L,35L,35L,35L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261870Inst : IEnumerable<long>
{
public static readonly long[] Value=A261870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261870.Bytes);
public long this[int i]=>Value[i];

public static A261870Inst Instance=new A261870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261871
{
public static readonly long[] Value={ 3L,7L,9L,15L,21L,27L,31L,33L,35L,39L,45L,49L,51L,57L,63L,69L,75L,77L,81L,87L,91L,93L,99L,105L,111L,117L,119L,123L,127L,129L,133L,135L,141L,147L,153L,155L,159L,161L,165L,171L,175L,177L,183L,189L,195L,201L,203L,207L,213L,217L,219L,225L,231L,237L,243L,245L,249L,255L,259L,261L,267L,273L,279L,285L,287L,291L,297L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261871Inst : IEnumerable<long>
{
public static readonly long[] Value=A261871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261871.Bytes);
public long this[int i]=>Value[i];

public static A261871Inst Instance=new A261871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261872
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,1L,4L,1L,4L,0L,4L,2L,1L,3L,3L,1L,1L,3L,3L,2L,0L,2L,3L,0L,2L,3L,2L,3L,3L,0L,1L,0L,1L,4L,2L,1L,3L,4L,1L,0L,2L,2L,0L,4L,2L,1L,1L,2L,0L,2L,4L,2L,3L,0L,4L,1L,3L,3L,1L,0L,0L,1L,2L,3L,0L,1L,2L,4L,4L,0L,4L,2L,1L,0L,1L,0L,4L,3L,2L,4L,0L,2L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261872Inst : IEnumerable<long>
{
public static readonly long[] Value=A261872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261872.Bytes);
public long this[int i]=>Value[i];

public static A261872Inst Instance=new A261872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261873
{
public static readonly long[] Value={ 0L,3L,7L,0L,0L,7L,2L,1L,6L,5L,8L,2L,2L,9L,0L,3L,0L,3L,2L,0L,9L,9L,2L,3L,7L,8L,9L,4L,4L,8L,9L,1L,9L,3L,3L,0L,0L,7L,0L,0L,7L,3L,9L,8L,0L,6L,2L,1L,3L,2L,8L,4L,7L,3L,6L,3L,8L,5L,0L,5L,7L,3L,0L,5L,9L,7L,0L,9L,3L,6L,6L,0L,0L,7L,7L,3L,2L,8L,3L,1L,2L,8L,0L,6L,7L,1L,0L,1L,0L,7L,7L,6L,7L,7L,9L,4L,9L,3L,7L,6L,4L,9L,6L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261873Inst : IEnumerable<long>
{
public static readonly long[] Value=A261873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261873.Bytes);
public long this[int i]=>Value[i];

public static A261873Inst Instance=new A261873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261874
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,12L,15L,18L,20L,21L,22L,24L,26L,27L,28L,30L,33L,36L,39L,40L,42L,44L,45L,46L,48L,50L,51L,54L,55L,57L,60L,62L,63L,64L,66L,68L,69L,70L,72L,75L,77L,78L,80L,81L,82L,84L,86L,87L,88L,90L,93L,96L,99L,102L,105L,108L,110L,111L,112L,114L,116L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261874Inst : IEnumerable<long>
{
public static readonly long[] Value=A261874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261874.Bytes);
public long this[int i]=>Value[i];

public static A261874Inst Instance=new A261874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261875
{
public static readonly long[] Value={ 2L,6L,8L,1L,1L,2L,8L,1L,4L,7L,2L,6L,7L,1L,1L,2L,2L,3L,8L,5L,7L,7L,3L,2L,8L,7L,8L,3L,7L,0L,3L,9L,3L,7L,0L,9L,3L,5L,4L,1L,7L,5L,3L,4L,7L,2L,0L,1L,1L,6L,1L,6L,6L,3L,5L,2L,7L,4L,9L,7L,0L,2L,5L,8L,8L,6L,4L,0L,2L,8L,4L,0L,3L,6L,5L,1L,6L,5L,3L,4L,5L,0L,6L,7L,2L,3L,9L,2L,0L,8L,5L,5L,8L,7L,7L,5L,9L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261875Inst : IEnumerable<long>
{
public static readonly long[] Value=A261875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261875.Bytes);
public long this[int i]=>Value[i];

public static A261875Inst Instance=new A261875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261876
{
public static readonly long[] Value={ 1L,3L,2L,1L,4L,5L,1L,3L,5L,5L,4L,2L,4L,7L,2L,1L,9L,9L,4L,4L,7L,5L,1L,5L,6L,12L,7L,1L,10L,9L,2L,3L,10L,9L,7L,5L,4L,11L,3L,5L,14L,10L,4L,4L,10L,9L,3L,2L,8L,17L,10L,4L,11L,18L,6L,7L,9L,6L,11L,2L,10L,15L,4L,1L,15L,17L,4L,9L,13L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261876Inst : IEnumerable<long>
{
public static readonly long[] Value=A261876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261876.Bytes);
public long this[int i]=>Value[i];

public static A261876Inst Instance=new A261876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261877
{
public static readonly long[] Value={ 1L,0L,0L,2L,1L,0L,4L,2L,0L,8L,4L,0L,15L,8L,0L,26L,14L,0L,44L,24L,0L,72L,40L,0L,115L,64L,0L,180L,100L,0L,276L,154L,0L,416L,232L,0L,618L,344L,0L,906L,505L,0L,1312L,730L,0L,1880L,1044L,0L,2666L,1480L,0L,3746L,2076L,0L,5220L,2888L,0L,7216L,3988L,0L,9903L,5464L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261877Inst : IEnumerable<long>
{
public static readonly long[] Value=A261877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261877.Bytes);
public long this[int i]=>Value[i];

public static A261877Inst Instance=new A261877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261878
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,15L,21L,28L,36L,45L,55L,64L,76L,89L,103L,118L,134L,151L,169L,187L,207L,228L,250L,273L,297L,322L,348L,375L,403L,432L,462L,493L,525L,558L,592L,627L,663L,700L,738L,777L,817L,858L,900L,943L,987L,1032L,1078L,1125L,1173L,1222L,1272L,1323L,1375L,1428L,1482L,1537L,1593L,1650L,1708L,1767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261878Inst : IEnumerable<long>
{
public static readonly long[] Value=A261878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261878.Bytes);
public long this[int i]=>Value[i];

public static A261878Inst Instance=new A261878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261879
{
public static readonly long[] Value={ 2L,1L,2L,7L,3L,9L,9L,5L,9L,2L,3L,9L,8L,5L,2L,6L,5L,5L,2L,7L,2L,3L,5L,4L,3L,9L,3L,3L,7L,5L,9L,3L,2L,0L,3L,7L,2L,9L,1L,7L,5L,2L,2L,7L,2L,9L,1L,5L,6L,9L,1L,8L,3L,3L,2L,5L,5L,1L,8L,4L,4L,5L,0L,4L,9L,7L,0L,2L,4L,4L,2L,6L,1L,4L,0L,7L,3L,0L,8L,6L,9L,8L,8L,9L,3L,3L,2L,2L,6L,5L,6L,6L,9L,7L,1L,4L,9L,7L,7L,7L,4L,4L,0L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261879Inst : IEnumerable<long>
{
public static readonly long[] Value=A261879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261879.Bytes);
public long this[int i]=>Value[i];

public static A261879Inst Instance=new A261879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261880
{
public static readonly long[] Value={ 1L,-1L,-2L,1L,2L,4L,-2L,-3L,-5L,-9L,5L,7L,10L,15L,24L,-16L,-21L,-28L,-38L,-53L,-77L,61L,77L,98L,126L,164L,217L,294L,-272L,-333L,-410L,-508L,-634L,-798L,-1015L,-1309L,1385L,1657L,1990L,2400L,2908L,3542L,4340L,5355L,6664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261880Inst : IEnumerable<long>
{
public static readonly long[] Value=A261880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261880.Bytes);
public long this[int i]=>Value[i];

public static A261880Inst Instance=new A261880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261881
{
public static readonly BigInteger[] Value={ 0L,101L,31013L,3310133L,933101339L,1093310133901L,30109331013390103L,BigInteger.Parse("333010933101339010333"),BigInteger.Parse("33330109331013390103333"),BigInteger.Parse("993333010933101339010333399"),BigInteger.Parse("104993333010933101339010333399401"),BigInteger.Parse("7810499333301093310133901033339940187") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261881Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261881.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261881Inst Instance=new A261881Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}