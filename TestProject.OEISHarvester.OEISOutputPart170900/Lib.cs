using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201357
{
public static readonly long[] Value={ 1L,13L,1468L,2701L,2959L,3735L,8686L };
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
public class A201357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201357Inst : IEnumerable<long>
{
public static readonly long[] Value=A201357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201357.Bytes);
public long this[int i]=>Value[i];

public static A201357Inst Instance=new A201357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201358
{
public static readonly long[] Value={ 1L,5L,49L,269L,2387L,2945L,5897L };
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
public class A201358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201358Inst : IEnumerable<long>
{
public static readonly long[] Value=A201358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201358.Bytes);
public long this[int i]=>Value[i];

public static A201358Inst Instance=new A201358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201359
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,18L,30L,48L,54L,278L,450L,464L,1425L,1428L,3029L,7314L };
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
public class A201359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201359Inst : IEnumerable<long>
{
public static readonly long[] Value=A201359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201359.Bytes);
public long this[int i]=>Value[i];

public static A201359Inst Instance=new A201359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201360
{
public static readonly long[] Value={ 1L,2L,39L,44L,62L,1478L,2306L };
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
public class A201360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201360Inst : IEnumerable<long>
{
public static readonly long[] Value=A201360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201360.Bytes);
public long this[int i]=>Value[i];

public static A201360Inst Instance=new A201360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201361
{
public static readonly long[] Value={ 1L,2L,3L,8L,14L,35L,75L,83L,89L,90L,215L,342L,753L,1452L,4578L };
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
public class A201361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201361Inst : IEnumerable<long>
{
public static readonly long[] Value=A201361.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201361.Bytes);
public long this[int i]=>Value[i];

public static A201361Inst Instance=new A201361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201362
{
public static readonly long[] Value={ 2L,7L,11L,13L,14L,20L,37L,53L,71L,132L,140L,613L,641L,665L,757L,788L,1878L,6774L,8777L };
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
public class A201362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201362Inst : IEnumerable<long>
{
public static readonly long[] Value=A201362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201362.Bytes);
public long this[int i]=>Value[i];

public static A201362Inst Instance=new A201362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201363
{
public static readonly long[] Value={ 2L,3L,7L };
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
public class A201363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201363Inst : IEnumerable<long>
{
public static readonly long[] Value=A201363.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201363.Bytes);
public long this[int i]=>Value[i];

public static A201363Inst Instance=new A201363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201364
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,14L,16L,25L,39L,41L,57L,67L,75L,120L,127L,147L,209L,229L,231L,290L,302L,320L,455L,547L,558L,747L,1553L,1947L,2027L,2458L,3313L,3508L,4262L,4727L,6210L,6393L,6539L,6838L,7312L,8242L,8557L,9431L,9450L };
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
public class A201364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201364Inst : IEnumerable<long>
{
public static readonly long[] Value=A201364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201364.Bytes);
public long this[int i]=>Value[i];

public static A201364Inst Instance=new A201364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201365
{
public static readonly BigInteger[] Value={ 1L,5L,45L,605L,10845L,243005L,6534045L,204972605L,7348546845L,296387331005L,13282361478045L,654762261324605L,35211177242722845L,2051349014835939005L,BigInteger.Parse("128701394409842982045"),BigInteger.Parse("8651475271312083756605"),BigInteger.Parse("620334325261670875138845"),BigInteger.Parse("47259638324026516284867005") };
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
public class A201365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201365Inst Instance=new A201365Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201366
{
public static readonly BigInteger[] Value={ 1L,5L,40L,470L,7360L,144080L,3384640L,92761520L,2905461760L,102379969280L,4008411658240L,172632406008320L,8110747682652160L,412820794294292480L,BigInteger.Parse("22628039202542755840"),BigInteger.Parse("1328909797186015877120"),BigInteger.Parse("83247808119808161218560"),BigInteger.Parse("5540883903212529402183680"),BigInteger.Parse("390489065613179063896637440") };
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
public class A201366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201366Inst Instance=new A201366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201367
{
public static readonly BigInteger[] Value={ 1L,5L,35L,345L,4515L,73905L,1451835L,33273945L,871529715L,25681042305L,840815302635L,30281769805545L,1189735610250915L,50638609760802705L,2321120945531697435L,BigInteger.Parse("113992686944812385145"),BigInteger.Parse("5971520591679167948115"),BigInteger.Parse("332369999588147180115105"),BigInteger.Parse("19587647624733292373756235") };
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
public class A201367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201367Inst Instance=new A201367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201368
{
public static readonly BigInteger[] Value={ 1L,5L,30L,230L,2280L,28280L,421680L,7336880L,145879680L,3263031680L,81097294080L,2217097729280L,66122900014080L,2136392343342080L,74335250629908480L,2771225281718343680L,BigInteger.Parse("110198981079416340480"),BigInteger.Parse("4655992415884353044480"),BigInteger.Parse("208291013498682750074880"),BigInteger.Parse("9835804726301090178990080") };
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
public class A201368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201368Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201368.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201368Inst Instance=new A201368Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201369
{
public static readonly long[] Value={ 0L,0L,0L,0L,27L,21792L,3324193L,119138166L,1979541332L,20142680752L,145977165234L,824771174978L,3850985758339L,15461577137802L,54912339921707L,176153338628674L,518569625849418L,1418340918023792L,3639736652346172L,8833161922947702L,20405252721413369L };
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
public class A201369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201369Inst : IEnumerable<long>
{
public static readonly long[] Value=A201369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201369.Bytes);
public long this[int i]=>Value[i];

public static A201369Inst Instance=new A201369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201370
{
public static readonly long[] Value={ 2L,3L,8L,36L,268L,3739L,115168L,8866257L,1799674094L,976134459840L };
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
public class A201370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201370Inst : IEnumerable<long>
{
public static readonly long[] Value=A201370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201370.Bytes);
public long this[int i]=>Value[i];

public static A201370Inst Instance=new A201370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201371
{
public static readonly long[] Value={ 2L,5L,14L,36L,80L,157L,280L,464L,726L,1085L,1562L,2180L,2964L,3941L,5140L,6592L,8330L,10389L,12806L,15620L,18872L,22605L,26864L,31696L,37150L,43277L,50130L,57764L,66236L,75605L,85932L,97280L,109714L,123301L,138110L,154212L,171680L,190589L,211016L };
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
public class A201371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201371Inst : IEnumerable<long>
{
public static readonly long[] Value=A201371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201371.Bytes);
public long this[int i]=>Value[i];

public static A201371Inst Instance=new A201371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201372
{
public static readonly long[] Value={ 2L,6L,22L,80L,268L,786L,2016L,4608L,9582L,18446L,33330L,57136L,93704L,147994L,226284L,336384L,487866L,692310L,963566L,1318032L,1774948L,2356706L,3089176L,4002048L,5129190L,6509022L,8184906L,10205552L,12625440L,15505258L,18912356L,22921216L };
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
public class A201372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201372Inst : IEnumerable<long>
{
public static readonly long[] Value=A201372.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201372.Bytes);
public long this[int i]=>Value[i];

public static A201372Inst Instance=new A201372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201373
{
public static readonly long[] Value={ 2L,7L,32L,157L,786L,3739L,15574L,55410L,170616L,465037L,1145954L,2597729L,5492076L,10947133L,20749996L,37660122L,65814022L,111254955L,182614908L,291980013L,455974718L,697104503L,1045401722L,1540424266L,2233662188L,3191413217L };
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
public class A201373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201373Inst : IEnumerable<long>
{
public static readonly long[] Value=A201373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201373.Bytes);
public long this[int i]=>Value[i];

public static A201373Inst Instance=new A201373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201374
{
public static readonly long[] Value={ 2L,8L,44L,280L,2016L,15574L,115168L,728078L,3793342L,16517460L,61759798L,203474642L,603403128L,1638153030L,4126393250L,9747403504L,21778931370L,46349684784L,94496712184L,185448946836L,351735813872L,646956766742L,1157359269036L };
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
public class A201374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201374Inst : IEnumerable<long>
{
public static readonly long[] Value=A201374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201374.Bytes);
public long this[int i]=>Value[i];

public static A201374Inst Instance=new A201374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201375
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,2L,2L,4L,4L,2L,2L,5L,8L,5L,2L,2L,6L,14L,14L,6L,2L,2L,7L,22L,36L,22L,7L,2L,2L,8L,32L,80L,80L,32L,8L,2L,2L,9L,44L,157L,268L,157L,44L,9L,2L,2L,10L,58L,280L,786L,786L,280L,58L,10L,2L,2L,11L,74L,464L,2016L,3739L,2016L,464L,74L,11L,2L,2L,12L,92L,726L,4608L,15574L,15574L,4608L };
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
public class A201375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201375Inst : IEnumerable<long>
{
public static readonly long[] Value=A201375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201375.Bytes);
public long this[int i]=>Value[i];

public static A201375Inst Instance=new A201375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201376
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,9L,3L,7L,16L,31L,5L,12L,29L,57L,109L,7L,19L,47L,97L,189L,339L,11L,30L,77L,162L,323L,589L,1043L,15L,45L,118L,257L,522L,975L,1752L,2998L,22L,67L,181L,401L,831L,1576L,2876L,4987L,8406L,30L,97L,267L,608L,1279L,2472L,4571L,8043L,13715L,22652L,42L,139L,392L,907L,1941L,3804L,7128L,12693L,21893L,36535L,59521L };
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
public class A201376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201376Inst : IEnumerable<long>
{
public static readonly long[] Value=A201376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201376.Bytes);
public long this[int i]=>Value[i];

public static A201376Inst Instance=new A201376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201377
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,5L,2L,5L,9L,17L,2L,7L,14L,27L,46L,3L,10L,21L,42L,74L,123L,4L,14L,31L,64L,116L,197L,323L,5L,19L,44L,93L,174L,303L,506L,809L,6L,25L,61L,132L,254L,452L,769L,1251L,1966L,8L,33L,83L,185L,363L,659L,1141L,1885L,3006L,4660L };
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
public class A201377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201377Inst : IEnumerable<long>
{
public static readonly long[] Value=A201377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201377.Bytes);
public long this[int i]=>Value[i];

public static A201377Inst Instance=new A201377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201378
{
public static readonly long[] Value={ 2L,3L,19L,121L,7148L,326650L,175765510L,74872992399L,400292326222730L,1748923742658486631L };
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
public class A201378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201378Inst : IEnumerable<long>
{
public static readonly long[] Value=A201378.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201378.Bytes);
public long this[int i]=>Value[i];

public static A201378Inst Instance=new A201378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201379
{
public static readonly long[] Value={ 2L,4L,19L,27L,115L,122L,467L,433L,1461L,1208L,3797L,2931L,8642L,6292L,17780L,12430L,33822L,22825L,60401L,39688L,102439L,65739L,166387L,104780L,260549L,161323L,395367L,241382L,583802L,351915L,841664L,501871L,1188050L,701410L,1645719L,963241L };
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
public class A201379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201379Inst : IEnumerable<long>
{
public static readonly long[] Value=A201379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201379.Bytes);
public long this[int i]=>Value[i];

public static A201379Inst Instance=new A201379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201380
{
public static readonly long[] Value={ 1L,7L,27L,121L,483L,1751L,5694L,16870L,46014L,116842L,278837L,630353L,1358517L,2806843L,5584567L,10741640L,20039166L,36362252L,64333159L,111214759L,188207532L,312302096L,508868575L,815256003L,1285706310L,1998034336L,3062559792L };
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
public class A201380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201380Inst : IEnumerable<long>
{
public static readonly long[] Value=A201380.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201380.Bytes);
public long this[int i]=>Value[i];

public static A201380Inst Instance=new A201380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201381
{
public static readonly long[] Value={ 2L,9L,115L,483L,7148L,24779L,295813L,804538L,7711613L,17135660L,137991357L,261853930L,1838296465L,3078156753L,19352193027L,29273561002L,168059197372L,233637796573L,1242746736360L,1608517392555L,8015798428649L,9756858004272L };
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
public class A201381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201381Inst : IEnumerable<long>
{
public static readonly long[] Value=A201381.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201381.Bytes);
public long this[int i]=>Value[i];

public static A201381Inst Instance=new A201381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201382
{
public static readonly long[] Value={ 1L,13L,122L,1751L,24779L,326650L,3826202L,39589830L,364013320L,3005372641L,22522846792L,154739772302L,983097718721L,5818909235791L,32292922468841L,168956847012130L,837348841763554L,3947230438308504L,17762594565022972L };
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
public class A201382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201382Inst : IEnumerable<long>
{
public static readonly long[] Value=A201382.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201382.Bytes);
public long this[int i]=>Value[i];

public static A201382Inst Instance=new A201382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201383
{
public static readonly long[] Value={ 2L,16L,467L,5694L,295813L,3826202L,175765510L,1819250859L,65629320845L,534428405524L,15483460261810L,102996778664996L,2488946990439369L,14017118437802211L,291386682009006888L,1427682924988875276L };
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
public class A201383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201383Inst : IEnumerable<long>
{
public static readonly long[] Value=A201383.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201383.Bytes);
public long this[int i]=>Value[i];

public static A201383Inst Instance=new A201383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201384
{
public static readonly long[] Value={ 2L,1L,1L,2L,3L,2L,1L,4L,4L,1L,2L,7L,19L,7L,2L,1L,9L,27L,27L,9L,1L,2L,13L,115L,121L,115L,13L,2L,1L,16L,122L,483L,483L,122L,16L,1L,2L,21L,467L,1751L,7148L,1751L,467L,21L,2L,1L,25L,433L,5694L,24779L,24779L,5694L,433L,25L,1L,2L,31L,1461L,16870L,295813L,326650L,295813L,16870L };
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
public class A201384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201384Inst : IEnumerable<long>
{
public static readonly long[] Value=A201384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201384.Bytes);
public long this[int i]=>Value[i];

public static A201384Inst Instance=new A201384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201385
{
public static readonly long[] Value={ 1L,3L,7L,3L,15L,10L,31L,25L,10L,63L,56L,35L,127L,119L,91L,35L };
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
public class A201385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201385Inst : IEnumerable<long>
{
public static readonly long[] Value=A201385.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201385.Bytes);
public long this[int i]=>Value[i];

public static A201385Inst Instance=new A201385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201386
{
public static readonly long[] Value={ 4L,8L,1606L,312604L,9842070647L,264043688162138L };
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
public class A201386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201386Inst : IEnumerable<long>
{
public static readonly long[] Value=A201386.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201386.Bytes);
public long this[int i]=>Value[i];

public static A201386Inst Instance=new A201386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201387
{
public static readonly long[] Value={ 6L,8L,137L,98L,1416L,715L,9424L,3977L,47509L,17474L,195020L,65271L,685365L,212409L,2127347L,621431L,5970292L,1659237L,15403848L,4110026L,37018776L,9536251L,83699540L,20927871L,179497978L,43720826L,367499724L,87495195L,722212122L };
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
public class A201387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201387Inst : IEnumerable<long>
{
public static readonly long[] Value=A201387.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201387.Bytes);
public long this[int i]=>Value[i];

public static A201387Inst Instance=new A201387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201388
{
public static readonly long[] Value={ 4L,137L,1606L,5897L,236224L,3364770L,19735330L,40088345L,1066040173L,10207216063L,41478543314L,60255150730L,1228071405908L,9109985067401L,29080781926297L,33671540790223L,567086887068128L,3500195283945353L,9371250160350500L };
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
public class A201388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201388Inst : IEnumerable<long>
{
public static readonly long[] Value=A201388.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201388.Bytes);
public long this[int i]=>Value[i];

public static A201388Inst Instance=new A201388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201389
{
public static readonly BigInteger[] Value={ 1L,98L,5897L,312604L,14027391L,539625139L,18131486831L,541077286873L,14533375222752L,355152145922937L,7965464463977638L,165169207300414826L,3186082489177522116L,BigInteger.Parse("57478616703131109039"),BigInteger.Parse("974288796548462899774") };
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
public class A201389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201389Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201389.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201389.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201389Inst Instance=new A201389Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201390
{
public static readonly long[] Value={ 4L,1416L,236224L,14027391L,9842070647L,2308382992901L,214888479967271L,6753117745581190L,2832539834014535065L };
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
public class A201390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201390Inst : IEnumerable<long>
{
public static readonly long[] Value=A201390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201390.Bytes);
public long this[int i]=>Value[i];

public static A201390Inst Instance=new A201390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201391
{
public static readonly long[] Value={ 6L,715L,3364770L,539625139L,2308382992901L,264043688162138L };
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
public class A201391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201391Inst : IEnumerable<long>
{
public static readonly long[] Value=A201391.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201391.Bytes);
public long this[int i]=>Value[i];

public static A201391Inst Instance=new A201391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201392
{
public static readonly long[] Value={ 4L,9424L,19735330L,18131486831L,214888479967271L };
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
public class A201392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201392Inst : IEnumerable<long>
{
public static readonly long[] Value=A201392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201392.Bytes);
public long this[int i]=>Value[i];

public static A201392Inst Instance=new A201392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201393
{
public static readonly long[] Value={ 4L,6L,6L,4L,8L,4L,1L,137L,137L,1L,4L,98L,1606L,98L,4L,6L,1416L,5897L,5897L,1416L,6L,4L,715L,236224L,312604L,236224L,715L,4L,1L,9424L,3364770L,14027391L,14027391L,3364770L,9424L,1L,4L,3977L,19735330L,539625139L,9842070647L,539625139L,19735330L,3977L,4L,6L };
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
public class A201393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201393Inst : IEnumerable<long>
{
public static readonly long[] Value=A201393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201393.Bytes);
public long this[int i]=>Value[i];

public static A201393Inst Instance=new A201393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201394
{
public static readonly long[] Value={ 1L,2L,8L,3L,6L,1L,6L,7L,2L,7L,0L,5L,9L,4L,7L,4L,2L,0L,9L,4L,3L,7L,8L,8L,8L,5L,9L,7L,4L,7L,7L,2L,7L,8L,7L,0L,3L,8L,8L,5L,5L,9L,0L,3L,7L,2L,0L,6L,9L,2L,8L,1L,0L,8L,8L,9L,9L,6L,0L,1L,8L,7L,7L,0L,6L,2L,7L,3L,3L,5L,8L,4L,9L,4L,5L,5L,8L,9L,3L,0L,9L,0L,1L,1L,8L,6L,2L,3L,2L,5L,7L,3L,8L,1L,3L,6L,2L,9L,0L };
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
public class A201394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201394Inst : IEnumerable<long>
{
public static readonly long[] Value=A201394.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201394.Bytes);
public long this[int i]=>Value[i];

public static A201394Inst Instance=new A201394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201395
{
public static readonly long[] Value={ 9L,5L,1L,0L,5L,5L,2L,3L,9L,6L,9L,6L,6L,3L,2L,7L,7L,9L,0L,0L,7L,4L,2L,1L,2L,0L,3L,7L,2L,1L,2L,0L,6L,5L,6L,2L,8L,3L,9L,5L,3L,8L,3L,6L,6L,3L,9L,6L,0L,5L,6L,9L,3L,8L,5L,2L,9L,0L,8L,4L,3L,5L,0L,7L,7L,7L,4L,3L,4L,3L,3L,6L,3L,5L,0L,6L,7L,3L,5L,5L,8L,3L,7L,7L,3L,2L,2L,2L,6L,5L,8L,5L,3L,3L,7L,1L,5L,5L,4L };
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
public class A201395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201395Inst : IEnumerable<long>
{
public static readonly long[] Value=A201395.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201395.Bytes);
public long this[int i]=>Value[i];

public static A201395Inst Instance=new A201395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201396
{
public static readonly long[] Value={ 2L,2L,0L,4L,1L,1L,7L,7L,3L,3L,1L,7L,1L,6L,2L,0L,2L,9L,5L,9L,9L,0L,9L,5L,4L,8L,7L,7L,7L,3L,2L,3L,8L,4L,9L,5L,3L,5L,8L,6L,5L,9L,8L,9L,3L,9L,9L,3L,0L,0L,9L,7L,9L,4L,2L,1L,1L,7L,4L,4L,7L,7L,4L,9L,2L,0L,2L,1L,1L,8L,2L,3L,8L,6L,5L,9L,0L,1L,0L,7L,3L,0L,3L,3L,5L,9L,3L,8L,3L,0L,8L,0L,9L,8L,4L,6L,5L,0L,1L };
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
public class A201396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201396Inst : IEnumerable<long>
{
public static readonly long[] Value=A201396.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201396.Bytes);
public long this[int i]=>Value[i];

public static A201396Inst Instance=new A201396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201397
{
public static readonly long[] Value={ 1L,2L,9L,5L,4L,5L,9L,6L,4L,6L,4L,1L,5L,4L,7L,8L,7L,6L,8L,6L,2L,9L,9L,1L,3L,2L,7L,0L,7L,1L,8L,6L,4L,1L,5L,8L,9L,7L,6L,7L,2L,7L,4L,8L,2L,7L,0L,6L,8L,7L,1L,3L,1L,6L,1L,6L,0L,5L,1L,8L,1L,4L,3L,0L,2L,1L,7L,4L,9L,5L,1L,2L,6L,5L,9L,9L,3L,0L,9L,5L,5L,9L,7L,8L,6L,7L,4L,3L,9L,4L,7L,1L,9L,8L,8L,4L,7L,9L,9L };
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
public class A201397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201397Inst : IEnumerable<long>
{
public static readonly long[] Value=A201397.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201397.Bytes);
public long this[int i]=>Value[i];

public static A201397Inst Instance=new A201397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201398
{
public static readonly long[] Value={ 1L,3L,6L,3L,5L,1L,9L,4L,6L,8L,4L,8L,6L,2L,0L,1L,8L,5L,7L,3L,5L,2L,2L,8L,1L,2L,8L,4L,5L,8L,4L,2L,3L,7L,8L,7L,7L,3L,2L,9L,5L,1L,4L,4L,9L,4L,6L,3L,1L,2L,5L,9L,4L,4L,8L,5L,3L,8L,7L,8L,9L,0L,6L,1L,7L,8L,7L,4L,8L,5L,4L,8L,4L,5L,6L,2L,7L,2L,1L,2L,4L,5L,7L,8L,9L,9L,5L,1L,3L,5L,3L,7L,2L,0L,8L,7L,7L,9L,4L };
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
public class A201398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201398Inst : IEnumerable<long>
{
public static readonly long[] Value=A201398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201398.Bytes);
public long this[int i]=>Value[i];

public static A201398Inst Instance=new A201398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201399
{
public static readonly long[] Value={ 1L,4L,0L,2L,4L,0L,6L,0L,3L,1L,2L,7L,6L,5L,1L,6L,4L,7L,2L,8L,6L,3L,7L,6L,5L,8L,5L,4L,6L,9L,3L,9L,7L,3L,0L,3L,2L,3L,0L,5L,2L,3L,1L,8L,9L,3L,8L,7L,0L,0L,8L,1L,0L,9L,3L,8L,2L,9L,8L,9L,9L,6L,6L,5L,5L,8L,2L,5L,2L,7L,7L,7L,8L,3L,4L,2L,4L,3L,5L,0L,8L,4L,7L,5L,7L,8L,1L,8L,5L,1L,9L,3L,9L,3L,4L,9L,5L,5L,5L };
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
public class A201399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201399Inst : IEnumerable<long>
{
public static readonly long[] Value=A201399.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201399.Bytes);
public long this[int i]=>Value[i];

public static A201399Inst Instance=new A201399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201400
{
public static readonly long[] Value={ 1L,4L,2L,8L,2L,6L,7L,7L,6L,5L,8L,3L,8L,2L,2L,2L,6L,4L,0L,3L,3L,9L,7L,6L,6L,3L,0L,1L,3L,2L,5L,2L,7L,7L,6L,0L,6L,6L,2L,8L,1L,3L,1L,0L,7L,4L,1L,3L,2L,3L,8L,0L,7L,8L,8L,4L,1L,0L,0L,4L,1L,5L,6L,5L,2L,4L,2L,1L,0L,7L,6L,0L,2L,9L,0L,4L,3L,2L,9L,3L,4L,0L,3L,3L,3L,5L,3L,6L,2L,7L,9L,5L,1L,4L,8L,7L,2L,6L,6L };
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
public class A201400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201400Inst : IEnumerable<long>
{
public static readonly long[] Value=A201400.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201400.Bytes);
public long this[int i]=>Value[i];

public static A201400Inst Instance=new A201400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201401
{
public static readonly long[] Value={ 1L,4L,4L,6L,9L,2L,5L,2L,6L,4L,8L,5L,3L,0L,3L,9L,2L,2L,3L,8L,8L,2L,5L,8L,9L,8L,8L,1L,4L,2L,8L,4L,9L,2L,1L,8L,1L,0L,5L,7L,9L,6L,4L,9L,6L,2L,1L,4L,2L,1L,7L,7L,5L,1L,4L,1L,7L,2L,7L,6L,0L,1L,6L,3L,3L,5L,8L,2L,4L,6L,2L,0L,2L,5L,5L,4L,2L,9L,0L,8L,4L,3L,8L,5L,8L,1L,7L,4L,0L,3L,5L,0L,2L,6L,9L,5L,6L,0L,8L };
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
public class A201401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201401Inst : IEnumerable<long>
{
public static readonly long[] Value=A201401.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201401.Bytes);
public long this[int i]=>Value[i];

public static A201401Inst Instance=new A201401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201402
{
public static readonly long[] Value={ 1L,4L,6L,1L,1L,0L,5L,3L,6L,4L,6L,3L,0L,1L,6L,7L,7L,8L,2L,2L,7L,7L,7L,8L,0L,7L,0L,2L,7L,3L,7L,6L,2L,2L,0L,7L,2L,6L,5L,2L,7L,6L,0L,9L,7L,5L,5L,9L,9L,9L,4L,2L,4L,9L,5L,8L,9L,4L,8L,7L,0L,4L,1L,8L,9L,8L,4L,8L,3L,9L,0L,9L,6L,5L,4L,3L,1L,6L,8L,7L,6L,7L,2L,8L,6L,8L,9L,6L,4L,2L,3L,0L,3L,7L,4L,4L,9L,6L,3L };
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
public class A201402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201402Inst : IEnumerable<long>
{
public static readonly long[] Value=A201402.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201402.Bytes);
public long this[int i]=>Value[i];

public static A201402Inst Instance=new A201402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201403
{
public static readonly long[] Value={ 1L,4L,7L,2L,2L,8L,5L,6L,9L,0L,4L,6L,1L,3L,4L,7L,6L,6L,2L,3L,7L,1L,4L,6L,4L,5L,4L,7L,8L,2L,4L,0L,4L,0L,1L,9L,5L,4L,5L,3L,2L,9L,4L,9L,3L,6L,6L,0L,9L,0L,1L,6L,2L,8L,3L,7L,4L,5L,4L,0L,1L,1L,7L,2L,4L,5L,1L,0L,4L,8L,4L,0L,8L,2L,2L,0L,9L,8L,2L,4L,3L,6L,7L,0L,1L,3L,8L,9L,2L,1L,7L,0L,7L,7L,5L,1L,4L,5L,7L };
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
public class A201403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201403Inst : IEnumerable<long>
{
public static readonly long[] Value=A201403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201403.Bytes);
public long this[int i]=>Value[i];

public static A201403Inst Instance=new A201403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201404
{
public static readonly long[] Value={ 1L,4L,8L,1L,3L,4L,6L,6L,1L,2L,6L,2L,9L,7L,1L,7L,6L,7L,5L,9L,7L,6L,5L,3L,6L,8L,4L,1L,5L,7L,9L,5L,6L,5L,2L,3L,0L,3L,0L,3L,3L,0L,0L,0L,1L,8L,1L,5L,5L,5L,1L,0L,5L,2L,7L,4L,8L,9L,3L,4L,5L,5L,0L,6L,7L,0L,9L,9L,9L,5L,7L,6L,2L,4L,3L,8L,4L,1L,7L,7L,8L,3L,8L,9L,3L,0L,4L,3L,4L,0L,3L,1L,7L,3L,3L,2L,6L,7L,2L };
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
public class A201404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201404Inst : IEnumerable<long>
{
public static readonly long[] Value=A201404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201404.Bytes);
public long this[int i]=>Value[i];

public static A201404Inst Instance=new A201404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201405
{
public static readonly long[] Value={ 1L,4L,8L,8L,8L,4L,9L,2L,8L,9L,1L,6L,4L,2L,2L,2L,1L,0L,6L,3L,3L,0L,9L,9L,6L,1L,5L,8L,9L,4L,1L,3L,3L,4L,3L,7L,5L,5L,3L,8L,1L,3L,6L,3L,6L,5L,0L,9L,7L,0L,2L,0L,5L,2L,1L,5L,5L,2L,9L,0L,4L,1L,0L,4L,8L,6L,7L,8L,8L,3L,4L,7L,3L,1L,4L,6L,5L,2L,1L,6L,9L,2L,1L,8L,2L,4L,4L,3L,0L,4L,5L,1L,4L,2L,8L,1L,5L,3L,1L };
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
public class A201405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201405Inst : IEnumerable<long>
{
public static readonly long[] Value=A201405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201405.Bytes);
public long this[int i]=>Value[i];

public static A201405Inst Instance=new A201405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201406
{
public static readonly long[] Value={ 8L,9L,2L,8L,7L,4L,3L,0L,6L,0L,5L,8L,9L,6L,1L,1L,2L,4L,4L,4L,7L,3L,7L,1L,9L,6L,9L,0L,1L,8L,6L,7L,7L,5L,1L,4L,6L,0L,1L,9L,5L,6L,8L,6L,1L,1L,9L,6L,7L,9L,4L,0L,3L,4L,0L,4L,7L,1L,7L,4L,5L,4L,5L,0L,3L,7L,8L,9L,5L,6L,9L,1L,0L,3L,2L,5L,6L,6L,5L,7L,7L,2L,1L,7L,1L,8L,2L,0L,4L,1L,5L,3L,4L,7L,5L,5L,1L,0L,7L };
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
public class A201406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201406Inst : IEnumerable<long>
{
public static readonly long[] Value=A201406.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201406.Bytes);
public long this[int i]=>Value[i];

public static A201406Inst Instance=new A201406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201407
{
public static readonly long[] Value={ 1L,2L,3L,9L,0L,8L,2L,6L,2L,0L,9L,2L,7L,5L,8L,1L,9L,1L,8L,7L,1L,5L,1L,0L,9L,2L,3L,9L,9L,0L,1L,9L,8L,5L,5L,3L,8L,0L,5L,9L,7L,0L,2L,3L,5L,0L,1L,4L,3L,6L,4L,9L,1L,5L,7L,2L,1L,6L,0L,1L,7L,3L,8L,1L,6L,9L,8L,5L,5L,6L,7L,6L,8L,9L,1L,6L,6L,6L,7L,5L,4L,8L,4L,3L,7L,7L,8L,8L,0L,8L,7L,6L,7L,7L,9L,7L,5L,9L,0L };
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
public class A201407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201407Inst : IEnumerable<long>
{
public static readonly long[] Value=A201407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201407.Bytes);
public long this[int i]=>Value[i];

public static A201407Inst Instance=new A201407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201408
{
public static readonly long[] Value={ 6L,4L,6L,1L,3L,7L,4L,5L,4L,0L,6L,2L,8L,9L,7L,2L,9L,7L,2L,9L,0L,1L,6L,7L,9L,1L,5L,9L,1L,0L,1L,1L,2L,5L,2L,2L,6L,9L,5L,2L,8L,5L,9L,6L,3L,3L,4L,5L,9L,2L,3L,2L,0L,0L,9L,7L,0L,9L,4L,5L,7L,1L,1L,4L,2L,5L,7L,7L,6L,9L,1L,3L,5L,1L,6L,4L,1L,3L,0L,4L,9L,6L,1L,4L,6L,0L,3L,0L,6L,0L,9L,0L,3L,4L,7L,3L,2L,1L,7L };
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
public class A201408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201408Inst : IEnumerable<long>
{
public static readonly long[] Value=A201408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201408.Bytes);
public long this[int i]=>Value[i];

public static A201408Inst Instance=new A201408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201409
{
public static readonly long[] Value={ 1L,3L,9L,9L,8L,6L,4L,1L,1L,9L,4L,4L,6L,0L,6L,4L,0L,6L,7L,2L,2L,9L,6L,3L,9L,5L,0L,5L,1L,8L,3L,6L,1L,0L,3L,7L,3L,9L,4L,1L,7L,8L,5L,0L,3L,3L,6L,2L,5L,3L,2L,6L,3L,4L,4L,2L,0L,4L,1L,4L,9L,8L,8L,7L,0L,4L,9L,5L,8L,0L,2L,7L,1L,7L,3L,5L,1L,0L,6L,0L,0L,3L,3L,5L,7L,9L,7L,0L,2L,0L,5L,7L,8L,1L,6L,5L,9L,1L,9L };
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
public class A201409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201409Inst : IEnumerable<long>
{
public static readonly long[] Value=A201409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201409.Bytes);
public long this[int i]=>Value[i];

public static A201409Inst Instance=new A201409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201410
{
public static readonly long[] Value={ 5L,3L,9L,8L,6L,1L,0L,8L,3L,9L,1L,2L,7L,7L,8L,4L,4L,3L,6L,3L,0L,6L,7L,3L,7L,3L,2L,7L,3L,2L,2L,8L,0L,7L,1L,4L,8L,0L,6L,2L,4L,1L,1L,2L,0L,9L,8L,1L,6L,0L,0L,5L,5L,4L,0L,8L,2L,8L,9L,8L,5L,4L,6L,1L,6L,0L,8L,1L,4L,4L,0L,2L,1L,2L,2L,0L,9L,8L,5L,5L,6L,0L,8L,2L,7L,8L,7L,3L,2L,0L,6L,5L,3L,0L,5L,9L,8L,2L,7L };
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
public class A201410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201410Inst : IEnumerable<long>
{
public static readonly long[] Value=A201410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201410.Bytes);
public long this[int i]=>Value[i];

public static A201410Inst Instance=new A201410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201411
{
public static readonly long[] Value={ 1L,4L,5L,1L,9L,2L,5L,7L,2L,2L,1L,2L,3L,2L,8L,7L,9L,9L,9L,4L,4L,6L,9L,4L,6L,6L,0L,4L,5L,0L,2L,0L,7L,9L,9L,6L,0L,0L,5L,4L,5L,0L,6L,4L,1L,0L,6L,1L,4L,3L,6L,1L,9L,1L,2L,0L,5L,3L,3L,0L,6L,1L,2L,7L,8L,5L,7L,2L,2L,2L,0L,7L,9L,9L,5L,1L,2L,9L,4L,9L,6L,7L,4L,4L,9L,9L,2L,8L,2L,5L,4L,6L,1L,0L,4L,5L,6L,3L,0L };
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
public class A201411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201411Inst : IEnumerable<long>
{
public static readonly long[] Value=A201411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201411.Bytes);
public long this[int i]=>Value[i];

public static A201411Inst Instance=new A201411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201412
{
public static readonly long[] Value={ 4L,7L,4L,1L,2L,7L,6L,9L,0L,4L,2L,0L,7L,7L,5L,4L,1L,5L,9L,3L,4L,7L,4L,8L,9L,3L,8L,5L,6L,9L,5L,5L,1L,5L,3L,8L,4L,3L,4L,8L,7L,2L,9L,2L,8L,5L,7L,5L,9L,9L,9L,6L,5L,6L,9L,8L,3L,4L,8L,5L,2L,3L,4L,5L,7L,3L,5L,4L,6L,4L,1L,8L,0L,4L,0L,1L,6L,8L,9L,7L,3L,3L,5L,6L,1L,0L,0L,2L,8L,4L,3L,3L,3L,8L,1L,2L,4L,9L,6L };
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
public class A201412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201412Inst : IEnumerable<long>
{
public static readonly long[] Value=A201412.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201412.Bytes);
public long this[int i]=>Value[i];

public static A201412Inst Instance=new A201412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201413
{
public static readonly long[] Value={ 1L,4L,7L,9L,2L,7L,1L,0L,6L,5L,2L,9L,0L,4L,1L,0L,7L,9L,3L,1L,0L,4L,2L,8L,5L,3L,4L,1L,5L,5L,3L,7L,6L,0L,2L,6L,3L,3L,4L,3L,0L,8L,8L,6L,0L,3L,8L,0L,1L,4L,0L,0L,2L,7L,0L,9L,5L,6L,1L,9L,9L,2L,7L,1L,9L,5L,9L,0L,7L,5L,2L,5L,0L,0L,9L,1L,6L,6L,2L,6L,7L,9L,0L,3L,1L,8L,6L,0L,5L,6L,7L,4L,1L,1L,1L,4L,2L,7L,1L };
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
public class A201413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201413Inst : IEnumerable<long>
{
public static readonly long[] Value=A201413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201413.Bytes);
public long this[int i]=>Value[i];

public static A201413Inst Instance=new A201413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201414
{
public static readonly long[] Value={ 4L,2L,8L,0L,0L,8L,9L,5L,0L,1L,0L,0L,4L,1L,0L,9L,7L,0L,0L,2L,7L,3L,9L,3L,4L,7L,7L,6L,9L,0L,6L,9L,1L,8L,0L,6L,5L,9L,8L,8L,9L,2L,9L,5L,9L,2L,8L,9L,4L,0L,5L,9L,6L,1L,9L,0L,8L,4L,8L,8L,6L,2L,3L,6L,8L,0L,3L,1L,4L,0L,1L,3L,7L,6L,6L,8L,3L,2L,6L,6L,7L,1L,4L,7L,2L,0L,8L,4L,8L,5L,8L,1L,4L,7L,9L,9L,9L,8L,5L };
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
public class A201414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201414Inst : IEnumerable<long>
{
public static readonly long[] Value=A201414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201414.Bytes);
public long this[int i]=>Value[i];

public static A201414Inst Instance=new A201414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201415
{
public static readonly long[] Value={ 1L,4L,9L,6L,2L,8L,5L,0L,4L,8L,6L,0L,7L,6L,5L,2L,9L,5L,3L,4L,7L,9L,2L,2L,9L,0L,4L,1L,7L,1L,2L,4L,2L,4L,4L,6L,9L,7L,5L,1L,2L,6L,6L,2L,6L,7L,9L,8L,7L,7L,1L,8L,2L,6L,4L,4L,9L,4L,1L,4L,8L,6L,8L,8L,7L,0L,5L,6L,1L,9L,9L,3L,2L,4L,9L,0L,6L,9L,7L,4L,6L,1L,6L,1L,7L,7L,7L,6L,8L,9L,8L,5L,8L,6L,6L,4L,9L,0L,8L };
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
public class A201415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201415Inst : IEnumerable<long>
{
public static readonly long[] Value=A201415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201415.Bytes);
public long this[int i]=>Value[i];

public static A201415Inst Instance=new A201415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201416
{
public static readonly long[] Value={ 3L,9L,3L,2L,7L,3L,8L,2L,7L,3L,2L,8L,8L,4L,1L,5L,0L,3L,8L,3L,2L,4L,5L,2L,0L,5L,7L,2L,0L,6L,2L,5L,3L,4L,2L,6L,5L,9L,1L,4L,5L,2L,1L,7L,7L,2L,0L,3L,0L,3L,2L,2L,0L,5L,9L,1L,8L,2L,9L,7L,1L,9L,8L,6L,8L,9L,1L,8L,8L,7L,1L,5L,2L,9L,8L,6L,0L,8L,6L,3L,5L,3L,9L,4L,1L,4L,6L,2L,8L,9L,1L,1L,5L,9L,4L,9L,3L,2L,6L };
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
public class A201416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201416Inst : IEnumerable<long>
{
public static readonly long[] Value=A201416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201416.Bytes);
public long this[int i]=>Value[i];

public static A201416Inst Instance=new A201416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201417
{
public static readonly long[] Value={ 1L,5L,0L,7L,9L,2L,8L,7L,9L,5L,3L,8L,0L,0L,9L,8L,2L,6L,6L,5L,6L,7L,8L,9L,9L,9L,9L,4L,0L,7L,0L,9L,9L,1L,4L,1L,3L,3L,9L,9L,6L,3L,0L,1L,1L,4L,6L,2L,2L,2L,1L,0L,4L,1L,8L,0L,3L,0L,5L,4L,5L,7L,3L,5L,2L,6L,3L,9L,4L,0L,3L,2L,6L,3L,3L,9L,6L,3L,2L,6L,5L,4L,9L,7L,2L,1L,7L,5L,5L,1L,3L,4L,9L,7L,3L,7L,6L,4L,3L };
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
public class A201417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201417Inst : IEnumerable<long>
{
public static readonly long[] Value=A201417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201417.Bytes);
public long this[int i]=>Value[i];

public static A201417Inst Instance=new A201417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201418
{
public static readonly long[] Value={ 3L,6L,5L,8L,6L,8L,4L,4L,2L,1L,8L,1L,0L,4L,6L,9L,0L,9L,4L,4L,4L,8L,8L,7L,9L,5L,0L,9L,1L,8L,0L,3L,6L,6L,4L,6L,0L,8L,1L,3L,8L,4L,5L,6L,4L,5L,7L,0L,2L,3L,0L,7L,3L,9L,7L,3L,1L,2L,9L,8L,0L,3L,0L,0L,6L,6L,9L,3L,5L,0L,8L,6L,2L,0L,3L,6L,5L,3L,7L,8L,9L,3L,1L,2L,1L,4L,9L,7L,5L,2L,2L,9L,3L,9L,9L,0L,4L,2L,3L };
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
public class A201418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201418Inst : IEnumerable<long>
{
public static readonly long[] Value=A201418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201418.Bytes);
public long this[int i]=>Value[i];

public static A201418Inst Instance=new A201418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201419
{
public static readonly long[] Value={ 1L,5L,1L,6L,4L,0L,9L,8L,4L,8L,1L,1L,1L,9L,3L,5L,5L,8L,9L,6L,3L,6L,2L,1L,8L,9L,4L,0L,7L,7L,5L,1L,9L,7L,0L,8L,0L,7L,6L,6L,7L,9L,5L,6L,1L,1L,8L,2L,4L,4L,3L,0L,6L,3L,4L,7L,6L,0L,8L,6L,1L,0L,3L,9L,9L,9L,5L,2L,4L,0L,4L,5L,1L,7L,0L,0L,0L,1L,2L,8L,9L,8L,1L,1L,2L,1L,9L,0L,3L,9L,7L,8L,2L,8L,9L,3L,9L,6L,6L };
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
public class A201419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201419Inst : IEnumerable<long>
{
public static readonly long[] Value=A201419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201419.Bytes);
public long this[int i]=>Value[i];

public static A201419Inst Instance=new A201419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201420
{
public static readonly long[] Value={ 3L,4L,3L,5L,1L,9L,3L,8L,4L,4L,4L,8L,7L,5L,1L,7L,2L,8L,5L,1L,5L,7L,9L,3L,7L,9L,1L,6L,0L,5L,4L,7L,6L,8L,6L,0L,1L,4L,4L,8L,5L,9L,7L,4L,9L,4L,9L,4L,2L,1L,8L,9L,6L,5L,0L,9L,4L,4L,1L,5L,8L,8L,5L,3L,7L,2L,3L,4L,6L,8L,9L,3L,0L,4L,9L,5L,5L,9L,8L,9L,1L,9L,6L,8L,4L,5L,8L,0L,9L,1L,9L,1L,9L,6L,2L,4L,0L,8L,6L };
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
public class A201420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201420Inst : IEnumerable<long>
{
public static readonly long[] Value=A201420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201420.Bytes);
public long this[int i]=>Value[i];

public static A201420Inst Instance=new A201420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201421
{
public static readonly long[] Value={ 1L,5L,2L,2L,8L,6L,7L,1L,7L,6L,6L,7L,7L,9L,3L,0L,0L,5L,7L,3L,8L,6L,9L,0L,7L,4L,7L,3L,3L,4L,5L,6L,2L,6L,0L,8L,2L,0L,5L,8L,9L,8L,9L,5L,1L,0L,6L,3L,5L,7L,4L,9L,4L,3L,0L,9L,9L,6L,1L,5L,5L,5L,4L,8L,9L,2L,2L,9L,8L,2L,8L,2L,9L,3L,9L,5L,7L,9L,4L,8L,6L,7L,6L,8L,2L,6L,7L,3L,7L,9L,2L,5L,3L,1L,0L,4L,2L,7L,7L };
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
public class A201421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201421Inst : IEnumerable<long>
{
public static readonly long[] Value=A201421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201421.Bytes);
public long this[int i]=>Value[i];

public static A201421Inst Instance=new A201421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201422
{
public static readonly long[] Value={ 3L,2L,4L,8L,3L,5L,7L,6L,2L,5L,5L,2L,6L,7L,2L,6L,3L,4L,3L,2L,7L,2L,1L,6L,8L,9L,0L,5L,9L,1L,8L,3L,5L,7L,0L,3L,0L,0L,8L,4L,8L,6L,6L,5L,9L,6L,3L,0L,4L,6L,3L,6L,6L,2L,0L,1L,2L,2L,0L,0L,8L,0L,9L,3L,4L,7L,0L,4L,7L,3L,0L,6L,0L,5L,4L,5L,6L,0L,1L,9L,8L,7L,1L,0L,1L,7L,2L,5L,7L,1L,5L,1L,3L,9L,3L,5L,8L,7L,8L };
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
public class A201422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201422Inst : IEnumerable<long>
{
public static readonly long[] Value=A201422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201422.Bytes);
public long this[int i]=>Value[i];

public static A201422Inst Instance=new A201422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201423
{
public static readonly long[] Value={ 1L,5L,2L,7L,9L,4L,9L,8L,9L,4L,6L,9L,8L,6L,1L,4L,4L,1L,9L,6L,4L,9L,2L,4L,4L,7L,5L,2L,4L,6L,8L,0L,1L,9L,8L,4L,7L,4L,3L,0L,5L,4L,9L,8L,4L,6L,9L,8L,8L,5L,8L,3L,4L,6L,0L,2L,2L,7L,6L,4L,3L,7L,4L,6L,8L,8L,0L,0L,1L,0L,6L,3L,7L,2L,5L,6L,8L,1L,3L,5L,5L,6L,2L,2L,9L,3L,9L,5L,4L,0L,8L,6L,8L,8L,6L,8L,1L,0L,8L };
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
public class A201423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201423Inst : IEnumerable<long>
{
public static readonly long[] Value=A201423.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201423.Bytes);
public long this[int i]=>Value[i];

public static A201423Inst Instance=new A201423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201424
{
public static readonly long[] Value={ 7L,0L,4L,2L,4L,9L,4L,4L,6L,8L,1L,3L,6L,2L,8L,0L,6L,2L,2L,7L,7L,8L,0L,6L,5L,5L,7L,8L,5L,1L,7L,0L,7L,0L,1L,3L,4L,3L,7L,5L,3L,4L,3L,6L,4L,2L,5L,0L,6L,7L,7L,4L,8L,9L,6L,2L,2L,5L,2L,0L,2L,5L,9L,4L,2L,3L,3L,5L,6L,3L,9L,3L,4L,3L,1L,2L,7L,4L,0L,9L,2L,1L,9L,8L,2L,4L,3L,6L,9L,7L,0L,8L,6L,0L,5L,8L,6L,8L,4L,7L,0L,5L,7L,4L,0L };
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
public class A201424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201424Inst : IEnumerable<long>
{
public static readonly long[] Value=A201424.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201424.Bytes);
public long this[int i]=>Value[i];

public static A201424Inst Instance=new A201424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201425
{
public static readonly long[] Value={ 3L,11L,99L,33740L,28384610L,54217235230L,6095310292410589L };
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
public class A201425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201425Inst : IEnumerable<long>
{
public static readonly long[] Value=A201425.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201425.Bytes);
public long this[int i]=>Value[i];

public static A201425Inst Instance=new A201425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201426
{
public static readonly long[] Value={ 3L,11L,13L,76L,160L,111L,560L,955L,539L,2447L,3717L,1873L,7920L,11174L,5237L,21055L,28217L,12573L,48685L,62818L,26965L,101426L,127110L,53017L,194865L,238629L,97285L,350910L,421718L,168763L,599302L,709093L,279423L,979289L,1143571L,444809L,1541462L };
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
public class A201426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201426Inst : IEnumerable<long>
{
public static readonly long[] Value=A201426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201426.Bytes);
public long this[int i]=>Value[i];

public static A201426Inst Instance=new A201426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201427
{
public static readonly long[] Value={ 1L,13L,99L,622L,3406L,16399L,70192L,272801L,974066L,3232454L,10054552L,29532523L,82397798L,219500791L,560691234L,1378470505L,3272266551L,7521401992L,16780966687L,36420942317L,77044661996L,159126985181L,321388308477L };
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
public class A201427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201427Inst : IEnumerable<long>
{
public static readonly long[] Value=A201427.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201427.Bytes);
public long this[int i]=>Value[i];

public static A201427Inst Instance=new A201427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201428
{
public static readonly long[] Value={ 3L,76L,622L,33740L,561271L,2740779L,96745050L,1042095316L,3442865393L,88529711419L,713489134252L,1807746313421L,37066136105268L,241902857874013L,503427752952568L,8681256219590301L,48116992979572975L,85825473881325409L };
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
public class A201428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201428Inst : IEnumerable<long>
{
public static readonly long[] Value=A201428.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201428.Bytes);
public long this[int i]=>Value[i];

public static A201428Inst Instance=new A201428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201429
{
public static readonly BigInteger[] Value={ 3L,160L,3406L,561271L,28384610L,416592852L,44447452442L,1424312724034L,13770911283918L,1035117249643794L,24070178476723034L,173702345363760195L,10115576398329878340UL,BigInteger.Parse("185469670935326613615"),BigInteger.Parse("1072779045109238566061") };
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
public class A201429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201429.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201429Inst Instance=new A201429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201430
{
public static readonly BigInteger[] Value={ 1L,111L,16399L,2740779L,416592852L,54217235230L,6052024146349L,587944908602174L,50476787849180641L,3880703069469115762L,BigInteger.Parse("270124665154345283826") };
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
public class A201430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201430.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201430Inst Instance=new A201430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201431
{
public static readonly long[] Value={ 3L,560L,70192L,96745050L,44447452442L,6052024146349L,6095310292410589L };
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
public class A201431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201431Inst : IEnumerable<long>
{
public static readonly long[] Value=A201431.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201431.Bytes);
public long this[int i]=>Value[i];

public static A201431Inst Instance=new A201431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201432
{
public static readonly long[] Value={ 3L,3L,3L,1L,11L,1L,3L,13L,13L,3L,3L,76L,99L,76L,3L,1L,160L,622L,622L,160L,1L,3L,111L,3406L,33740L,3406L,111L,3L,3L,560L,16399L,561271L,561271L,16399L,560L,3L,1L,955L,70192L,2740779L,28384610L,2740779L,70192L,955L,1L,3L,539L,272801L,96745050L,416592852L };
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
public class A201432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201432Inst : IEnumerable<long>
{
public static readonly long[] Value=A201432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201432.Bytes);
public long this[int i]=>Value[i];

public static A201432Inst Instance=new A201432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201433
{
public static readonly long[] Value={ 1L,3L,5L,15L,21L,37L,39L,65L,107L,183L,313L,527L,853L,1459L,2455L,4167L,7051L,11857L,20009L,33993L,57671L,98267L,167457L,285197L,487513L,833647L,1427739L,2448037L,4197785L,7202371L,12370905L,21249671L,36538153L,62845703L,108146777L,186184157L };
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
public class A201433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201433Inst : IEnumerable<long>
{
public static readonly long[] Value=A201433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201433.Bytes);
public long this[int i]=>Value[i];

public static A201433Inst Instance=new A201433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201434
{
public static readonly long[] Value={ 1L,3L,15L,29L,55L,167L,295L,647L,1427L,3399L,6987L,15915L,35035L,78815L,175659L,401885L,907063L,2070241L,4703563L,10756853L,24527921L,56167839L,128565473L,295006361L,677007927L,1556684111L,3580113745L,8243974707L,18993055553L,43795271957L };
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
public class A201434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201434Inst : IEnumerable<long>
{
public static readonly long[] Value=A201434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201434.Bytes);
public long this[int i]=>Value[i];

public static A201434Inst Instance=new A201434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201435
{
public static readonly long[] Value={ 1L,5L,21L,75L,111L,527L,1275L,3643L,10245L,30215L,82859L,239133L,688547L,1986411L,5743067L,16751055L,48750751L,142319063L,416145857L,1218638091L,3571823395L,10485601869L,30812312143L,90634015523L,266849118935L,786358091871L };
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
public class A201435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201435Inst : IEnumerable<long>
{
public static readonly long[] Value=A201435.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201435.Bytes);
public long this[int i]=>Value[i];

public static A201435Inst Instance=new A201435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201436
{
public static readonly long[] Value={ 1L,5L,27L,115L,479L,1341L,4285L,14655L,50273L,176501L,608601L,2124765L,7445803L,26215687L,92619475L,327842063L,1163529557L,4137930391L,14741976265L,52598018933L,187903914621L,672086812005L,2406551665793L,8625934717463L };
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
public class A201436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201436Inst : IEnumerable<long>
{
public static readonly long[] Value=A201436.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201436.Bytes);
public long this[int i]=>Value[i];

public static A201436Inst Instance=new A201436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201437
{
public static readonly long[] Value={ 1L,7L,47L,217L,837L,3067L,11591L,46521L,189527L,794867L,3212411L,13228131L,54776691L,227656973L,950625037L,3969330087L,16629156327L,69823182357L,293680456429L,1237245364673L,5218020323041L,22034867606649L,93154330773015L };
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
public class A201437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201437Inst : IEnumerable<long>
{
public static readonly long[] Value=A201437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201437.Bytes);
public long this[int i]=>Value[i];

public static A201437Inst Instance=new A201437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201438
{
public static readonly long[] Value={ 1L,7L,57L,297L,1333L,6019L,27087L,126147L,592487L,2795067L,13283639L,63243395L,302028473L,1447178413L,6955639001L,33526007827L,161977137395L,784134070729L,3802451672491L,18466210763809L,89797281724981L,437189848462945L };
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
public class A201438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201438Inst : IEnumerable<long>
{
public static readonly long[] Value=A201438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201438.Bytes);
public long this[int i]=>Value[i];

public static A201438Inst Instance=new A201438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201439
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,3L,5L,1L,1L,5L,15L,15L,5L,1L,5L,21L,29L,21L,9L,1L,7L,27L,75L,55L,37L,5L,1L,7L,47L,115L,111L,167L,39L,3L,1L,9L,57L,217L,479L,527L,295L,65L,5L,1L,9L,67L,297L,837L,1341L,1275L,647L,107L,3L,1L,11L,97L,479L,1333L,3067L,4285L,3643L,1427L,183L,5L,1L,11L,111L,609L,1989L };
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
public class A201439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201439Inst : IEnumerable<long>
{
public static readonly long[] Value=A201439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201439.Bytes);
public long this[int i]=>Value[i];

public static A201439Inst Instance=new A201439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201440
{
public static readonly long[] Value={ 5L,21L,55L,111L,479L,837L,1333L,1989L,2827L,5737L,7743L,10165L,13031L,16369L,26119L,32081L,38875L,46541L,55115L,78221L,91467L,106087L,122147L,139713L,184765L,209597L,236519L,265591L,296875L,374751L,416515L,461207L,508905L,559677L,683245L,748295L };
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
public class A201440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201440Inst : IEnumerable<long>
{
public static readonly long[] Value=A201440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201440.Bytes);
public long this[int i]=>Value[i];

public static A201440Inst Instance=new A201440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201441
{
public static readonly long[] Value={ 9L,37L,167L,527L,1341L,3067L,6019L,11353L,19601L,32099L,50621L,75931L,112125L,159765L,222517L,304463L,406447L,538245L,699187L,897049L,1138935L,1425355L,1774971L,2184135L,2666551L,3233507L,3883865L,4649645L,5521247L,6521027L,7664967L,8949325L };
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
public class A201441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201441Inst : IEnumerable<long>
{
public static readonly long[] Value=A201441.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201441.Bytes);
public long this[int i]=>Value[i];

public static A201441Inst Instance=new A201441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201442
{
public static readonly long[] Value={ 5L,39L,295L,1275L,4285L,11591L,27087L,57287L,111197L,203089L,349901L,576085L,913583L,1401163L,2091765L,3041933L,4328151L,6039055L,8278625L,11178429L,14870953L,19532181L,25349001L,32546367L,41378489L,52112595L,65077017L,80620049L,99147253L };
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
public class A201442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201442Inst : IEnumerable<long>
{
public static readonly long[] Value=A201442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201442.Bytes);
public long this[int i]=>Value[i];

public static A201442Inst Instance=new A201442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201443
{
public static readonly long[] Value={ 0L,0L,2L,3L,4L,3L,5L,2L,3L,2L,4L };
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
public class A201443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201443Inst : IEnumerable<long>
{
public static readonly long[] Value=A201443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201443.Bytes);
public long this[int i]=>Value[i];

public static A201443Inst Instance=new A201443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201444
{
public static readonly long[] Value={ 4L,2L,52L,112L,4544L,16334L,1129682L,5464208L,458459214L,2605975384L,253569083138L,1617730690396L };
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
public class A201444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201444Inst : IEnumerable<long>
{
public static readonly long[] Value=A201444.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201444.Bytes);
public long this[int i]=>Value[i];

public static A201444Inst Instance=new A201444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201445
{
public static readonly long[] Value={ 6L,2L,21L,9L,56L,13L,110L,32L,198L,41L,315L,78L,480L,94L,684L,155L,950L,180L,1265L,271L,1656L,307L,2106L,434L,2646L,483L,3255L,652L,3968L,716L,4760L,933L,5670L,1014L,6669L,1285L,7800L,1385L,9030L,1716L,10406L,1837L,11891L,2234L,13536L,2378L,15300L,2847L };
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
public class A201445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201445Inst : IEnumerable<long>
{
public static readonly long[] Value=A201445.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201445.Bytes);
public long this[int i]=>Value[i];

public static A201445Inst Instance=new A201445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201446
{
public static readonly long[] Value={ 4L,21L,52L,29L,246L,701L,844L,426L,2478L,5990L,6334L,2358L,13766L,29096L,26976L,9735L,50294L,100963L,89428L,29011L,149198L,283043L,237216L,75948L,368044L,680922L,557638L,169158L,816740L,1464838L,1163616L,350485L,1633894L,2887309L,2261850L };
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
public class A201446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201446Inst : IEnumerable<long>
{
public static readonly long[] Value=A201446.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201446.Bytes);
public long this[int i]=>Value[i];

public static A201446Inst Instance=new A201446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201447
{
public static readonly long[] Value={ 1L,9L,29L,112L,261L,846L,1720L,4193L,8065L,16693L,29073L,55954L,90874L,158301L,249828L,409302L,611841L,962288L,1392970L,2091478L,2957586L,4286258L,5893598L,8347259L,11221370L,15440747L,20464931L,27577548L,35834857L,47497364L,60856456L,79217039L };
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
public class A201447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201447Inst : IEnumerable<long>
{
public static readonly long[] Value=A201447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201447.Bytes);
public long this[int i]=>Value[i];

public static A201447Inst Instance=new A201447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201448
{
public static readonly long[] Value={ 4L,56L,246L,261L,4544L,22324L,45532L,32314L,313710L,1126721L,1675002L,879801L,7177332L,20808117L,25958138L,11930250L,83429402L,215418299L,242046848L,99077372L,640294388L,1516885224L,1571234990L,603846146L,3627055278L };
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
public class A201448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201448Inst : IEnumerable<long>
{
public static readonly long[] Value=A201448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201448.Bytes);
public long this[int i]=>Value[i];

public static A201448Inst Instance=new A201448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201449
{
public static readonly long[] Value={ 6L,13L,701L,846L,22324L,16334L,363693L,211755L,3708666L,1743841L,27486101L,11523462L,159251638L,59366033L,763865999L,265448264L,3148137956L,1014298362L,11451837500L,3516665645L,37535616517L,10943450873L,112627454165L,31695873391L };
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
public class A201449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201449Inst : IEnumerable<long>
{
public static readonly long[] Value=A201449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201449.Bytes);
public long this[int i]=>Value[i];

public static A201449Inst Instance=new A201449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201450
{
public static readonly long[] Value={ 4L,110L,844L,1720L,45532L,363693L,1129682L,1136762L,16354832L,80822317L,164740812L,118019739L,1269643884L,4872612379L,7910355612L,4617454222L,41308142036L,133824389250L,186755344178L,94854691897L,750329582592L,2169912953058L };
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
public class A201450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201450Inst : IEnumerable<long>
{
public static readonly long[] Value=A201450.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201450.Bytes);
public long this[int i]=>Value[i];

public static A201450Inst Instance=new A201450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201451
{
public static readonly long[] Value={ 4L,6L,6L,4L,2L,4L,1L,21L,21L,1L,4L,9L,52L,9L,4L,6L,56L,29L,29L,56L,6L,4L,13L,246L,112L,246L,13L,4L,1L,110L,701L,261L,261L,701L,110L,1L,4L,32L,844L,846L,4544L,846L,844L,32L,4L,6L,198L,426L,1720L,22324L,22324L,1720L,426L,198L,6L,4L,41L,2478L,4193L,45532L,16334L,45532L,4193L };
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
public class A201451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201451Inst : IEnumerable<long>
{
public static readonly long[] Value=A201451.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201451.Bytes);
public long this[int i]=>Value[i];

public static A201451Inst Instance=new A201451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201452
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,37L,248L,1749L,14284L,130343L,1318194L,14630853L,176881314L,2313878809L };
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
public class A201452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201452Inst : IEnumerable<long>
{
public static readonly long[] Value=A201452.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201452.Bytes);
public long this[int i]=>Value[i];

public static A201452Inst Instance=new A201452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201453
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,2L,1L,-2L,1L,-8L,1L,-10L,11L,-4L,8L,1L,-5L,29L,-5L,8L,-32L,1L,-7L,7L,-33L,26L,-8L,6112L,1L,-28L,602L,-100L,313L,-112L,512L,-3712L,1L,-4L,70L,-1268L,593L,-1816L,1936L,-2944L,362624L,1L,-15L,38L,-566L,9681L,-1481L,31568L,-960L,2432L,-71706112L,1L,-55L,176L,-1606L,5401L,-54499L,290362L,-58864L,44736L,-285568L,3341113856L };
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
public class A201453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201453Inst : IEnumerable<long>
{
public static readonly long[] Value=A201453.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201453.Bytes);
public long this[int i]=>Value[i];

public static A201453Inst Instance=new A201453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201454
{
public static readonly long[] Value={ 1L,3L,3L,5L,3L,15L,7L,5L,3L,105L,9L,21L,15L,9L,105L,11L,9L,21L,3L,9L,231L,13L,11L,3L,7L,5L,3L,15015L,15L,39L,165L,9L,15L,5L,45L,2145L,17L,5L,13L,55L,9L,15L,15L,45L,36465L,19L,17L,5L,13L,55L,3L,35L,1L,5L,969969L,21L,57L,17L,21L,13L,33L,63L,7L,5L,63L,4849845L };
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
public class A201454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201454Inst : IEnumerable<long>
{
public static readonly long[] Value=A201454.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201454.Bytes);
public long this[int i]=>Value[i];

public static A201454Inst Instance=new A201454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201455
{
public static readonly long[] Value={ 2L,3L,17L,63L,257L,1023L,4097L,16383L,65537L,262143L,1048577L,4194303L,16777217L,67108863L,268435457L,1073741823L,4294967297L,17179869183L,68719476737L,274877906943L,1099511627777L,4398046511103L,17592186044417L,70368744177663L,281474976710657L };
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
public class A201455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201455Inst : IEnumerable<long>
{
public static readonly long[] Value=A201455.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201455.Bytes);
public long this[int i]=>Value[i];

public static A201455Inst Instance=new A201455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201456
{
public static readonly long[] Value={ 3L,3L,9L,9L,3L,3L,51L,57L,101L,5L,23L,59L,51L,161L,3L,5L,93L,135L,41L,29L,57L,5L,111L,129L,113L,35L,11L,15L,107L,129L,167L,21L,11L,143L,261L,57L,137L,113L,203L,219L,53L,101L,263L,137L,309L,101L,261L,87L,99L,239L,369L,59L,123L,83L,3L,275L,227L,321L,221L,27L,81L,135L,57L,29L,17L,281L,71L,359L,27L,395L,261L,99L,21L,215L,323L,71L,63L,29L };
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
public class A201456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201456Inst : IEnumerable<long>
{
public static readonly long[] Value=A201456.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201456.Bytes);
public long this[int i]=>Value[i];

public static A201456Inst Instance=new A201456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}