using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200205
{
public static readonly long[] Value={ 12L,68L,186L,422L,798L,1316L,2064L,3048L,4254L,5802L,7682L,9864L,12500L,15564L,19010L,23022L,27558L,32556L,38232L,44528L,51366L,58994L,67338L,76304L,86172L,96852L,108234L,120630L,133934L,148020L,163232L,179448L,196526L,214842L,234258L,254616L };
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
public class A200205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200205Inst : IEnumerable<long>
{
public static readonly long[] Value=A200205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200205.Bytes);
public long this[int i]=>Value[i];

public static A200205Inst Instance=new A200205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200206
{
public static readonly long[] Value={ 22L,246L,1106L,3196L,7450L,14842L,26932L,44910L,71050L,106802L,155056L,217506L,297896L,397820L,522032L,672214L,853824L,1068640L,1323238L,1619004L,1963760L,2358796L,2812794L,3326992L,3911394L,4566542L,5303990L,6124024L,7039122L,8049358L };
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
public class A200206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200206Inst : IEnumerable<long>
{
public static readonly long[] Value=A200206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200206.Bytes);
public long this[int i]=>Value[i];

public static A200206Inst Instance=new A200206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200207
{
public static readonly long[] Value={ 50L,1042L,6418L,24542L,70400L,168054L,352840L,672632L,1191380L,1990668L,3169582L,4851400L,7182342L,10332674L,14504130L,19925886L,26858060L,35599134L,46482708L,59877540L,76196440L,95896240L,119471266L,147472836L,180499346L,219187302L };
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
public class A200207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200207Inst : IEnumerable<long>
{
public static readonly long[] Value=A200207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200207.Bytes);
public long this[int i]=>Value[i];

public static A200207Inst Instance=new A200207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200208
{
public static readonly long[] Value={ 90L,3940L,37226L,187530L,667620L,1910006L,4664818L,10140128L,20184636L,37418930L,65462890L,109237270L,175066404L,271040286L,407440210L,596771596L,854269356L,1198528290L,1651314456L,2238353836L,2990103390L,3941357552L,5132247474L };
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
public class A200208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200208Inst : IEnumerable<long>
{
public static readonly long[] Value=A200208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200208.Bytes);
public long this[int i]=>Value[i];

public static A200208Inst Instance=new A200208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200209
{
public static readonly long[] Value={ 192L,16092L,217946L,1453304L,6428538L,21939870L,62361448L,154585536L,345422978L,710643132L,1366075526L,2483991350L,4309599382L,7180688000L,11557570298L,18048274072L,27438624488L,40742003838L,59232871060L,84489363024L };
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
public class A200209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200209Inst : IEnumerable<long>
{
public static readonly long[] Value=A200209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200209.Bytes);
public long this[int i]=>Value[i];

public static A200209Inst Instance=new A200209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200210
{
public static readonly long[] Value={ 360L,63326L,1282168L,11315108L,62141592L,253625670L,838749476L,2371034404L,5950389676L,13585723472L,28694253866L,56870615234L,106810248534L,191533300498L,330111908464L,549616167606L,887398698638L,1394638491438L };
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
public class A200210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200210Inst : IEnumerable<long>
{
public static readonly long[] Value=A200210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200210.Bytes);
public long this[int i]=>Value[i];

public static A200210Inst Instance=new A200210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200211
{
public static readonly long[] Value={ 752L,256314L,7609122L,88657470L,604864626L,2949336370L,11349503058L,36580061138L,103109058584L,261224766796L,606238931956L,1309542607976L,2662545910816L,5138238853810L,9483237615484L,16833404882270L,28865075618702L };
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
public class A200211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200211Inst : IEnumerable<long>
{
public static readonly long[] Value=A200211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200211.Bytes);
public long this[int i]=>Value[i];

public static A200211Inst Instance=new A200211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200212
{
public static readonly long[] Value={ 1L,1L,3L,11L,42L,174L,763L,3457L,16075L,76351L,368767L,1805682L,8943948L,44736096L,225646033L,1146461185L,5862224756L,30144922281L,155791900727L,808773877919L,4215675455503L,22054576750972L,115765182718467L,609508331610920L,3218059655553030L,17034314889643633L };
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
public class A200212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200212Inst : IEnumerable<long>
{
public static readonly long[] Value=A200212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200212.Bytes);
public long this[int i]=>Value[i];

public static A200212Inst Instance=new A200212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200213
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,0L,2L,0L,2L,0L,4L,0L,2L,2L,2L,0L,4L,0L,4L,2L,2L,0L,6L,0L,2L,2L,4L,0L,6L,0L,4L,2L,2L,2L,6L,0L,2L,2L,6L,0L,6L,0L,4L,4L,2L,0L,8L,0L,4L,2L,4L,0L,6L,2L,6L,2L,2L,0L,10L,0L,2L,4L,4L,2L,6L,0L,4L,2L,6L,0L,10L,0L,2L,4L,4L,2L,6L,0L,8L,2L,2L,0L,10L,2L };
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
public class A200213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200213Inst : IEnumerable<long>
{
public static readonly long[] Value=A200213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200213.Bytes);
public long this[int i]=>Value[i];

public static A200213Inst Instance=new A200213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200214
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,6L,0L,0L,0L,6L,0L,6L,0L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,6L,0L,6L,0L,0L,0L,18L,0L,0L,0L,6L,0L,6L,0L,0L,0L,6L,0L,18L,0L,0L,0L,0L,0L,6L,0L,12L,0L,0L,0L,18L };
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
public class A200214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200214Inst : IEnumerable<long>
{
public static readonly long[] Value=A200214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200214.Bytes);
public long this[int i]=>Value[i];

public static A200214Inst Instance=new A200214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200215
{
public static readonly long[] Value={ 1L,1L,3L,13L,61L,306L,1623L,8937L,50565L,292283L,1718827L,10250916L,61854848L,376949934L,2316738789L,14343701657L,89379109846L,560108223900L,3527723269978L,22318890516413L,141778326349191L,903936594232782L,5782447430948438L,37102633354583532L,238729798670985104L };
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
public class A200215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200215Inst : IEnumerable<long>
{
public static readonly long[] Value=A200215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200215.Bytes);
public long this[int i]=>Value[i];

public static A200215Inst Instance=new A200215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200216
{
public static readonly BigInteger[] Value={ 93844L,322001299796379844L,BigInteger.Parse("1114592308630995805123571151844"),BigInteger.Parse("3858108676488182444301031186675778188809844"),BigInteger.Parse("13354661111806898918013326915229994453818137920195953844") };
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
public class A200216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200216Inst Instance=new A200216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200217
{
public static readonly BigInteger[] Value={ 28748141L,BigInteger.Parse("182720147509505842286585077"),BigInteger.Parse("1176722513851727970194784616032383058302343205"),BigInteger.Parse("7578123615032687003769196301877008424487234722410713810234126013") };
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
public class A200217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200217Inst Instance=new A200217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200218
{
public static readonly BigInteger[] Value={ -297L,548147655L,-1019827620252441L,BigInteger.Parse("1897387247823873407415"),BigInteger.Parse("-3530085179800800999132960777"),BigInteger.Parse("6567716416847133270037051381858983"),BigInteger.Parse("-12219223258107727669457593220846745613305"),BigInteger.Parse("22733840433256343397153666138928891468676446359") };
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
public class A200218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200218Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200218.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200218Inst Instance=new A200218Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200219
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,4L,3L,2L,1L,4L,1L,2L,0L,8L,1L,6L,1L,4L,1L,2L,1L,8L,0L,2L,9L,2L,1L,4L,1L,16L,0L,2L,0L,12L,1L,2L,0L,8L,1L,4L,1L,2L,3L,2L,1L,16L,7L,10L,2L,2L,1L,18L,0L,8L,0L,2L,1L,8L,1L,2L,3L,32L,2L,4L,1L,4L,0L,2L,1L,24L,1L,2L,0L,4L,6L,4L,1L,16L,27L,2L,1L,8L };
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
public class A200219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200219Inst : IEnumerable<long>
{
public static readonly long[] Value=A200219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200219.Bytes);
public long this[int i]=>Value[i];

public static A200219Inst Instance=new A200219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200220
{
public static readonly long[] Value={ 1L,1L,2L,6L,10L,24L,52L,105L,238L,495L,1068L,2304L,4893L,10556L,22570L,48363L,103805L,222224L,476634L,1021515L,2189200L,4693415L,10058607L,21561120L,46215400L,99056688L,212327858L,455105352L,975492413L,2090916520L,4481729501L,9606342690L,20590584676L,44134642493L,94599971180L };
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
public class A200220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200220Inst : IEnumerable<long>
{
public static readonly long[] Value=A200220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200220.Bytes);
public long this[int i]=>Value[i];

public static A200220Inst Instance=new A200220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200221
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,0L,3L,0L,3L,0L,3L,0L,0L,0L,9L,0L,0L,1L,3L,0L,6L,0L,6L,0L,0L,0L,12L,0L,0L,0L,9L,0L,6L,0L,3L,3L,0L,0L,18L,0L,3L,0L,3L,0L,9L,0L,9L,0L,0L,0L,21L,0L,0L,3L,10L,0L,6L,0L,3L,0L,6L,0L,27L,0L,0L,3L,3L,0L,6L,0L,18L,3L,0L,0L,21L };
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
public class A200221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200221Inst : IEnumerable<long>
{
public static readonly long[] Value=A200221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200221.Bytes);
public long this[int i]=>Value[i];

public static A200221Inst Instance=new A200221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200222
{
public static readonly long[] Value={ 1L,2L,4L,12L,42L,164L,688L,3024L,13680L,63110L,295520L,1401012L,6713280L,32470468L,158343504L,777725264L,3843992546L,19104857608L,95419519076L,478668009828L,2410698765472L,12184259877320L,61782045169312L,314202878599696L,1602270787137472L,8191160756085318L,41971595130249968L,215522156779513584L };
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
public class A200222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200222Inst : IEnumerable<long>
{
public static readonly long[] Value=A200222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200222.Bytes);
public long this[int i]=>Value[i];

public static A200222Inst Instance=new A200222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200223
{
public static readonly long[] Value={ 3L,2L,3L,1L,1L,4L,3L,3L,3L,8L,8L,6L,2L,2L,6L,2L,8L,4L,5L,3L,5L,6L,3L,7L,0L,4L,9L,2L,3L,1L,1L,7L,1L,4L,9L,1L,1L,9L,9L,1L,6L,3L,6L,2L,8L,8L,2L,6L,6L,1L,5L,9L,4L,3L,8L,5L,8L,7L,5L,7L,8L,7L,3L,5L,7L,6L,5L,0L,5L,3L,8L,8L,8L,6L,0L,1L,7L,1L,0L,9L,8L,2L,8L,0L,4L,8L,2L,3L,7L,4L,7L,7L,2L,7L,6L,2L,7L,0L,6L };
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
public class A200223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200223Inst : IEnumerable<long>
{
public static readonly long[] Value=A200223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200223.Bytes);
public long this[int i]=>Value[i];

public static A200223Inst Instance=new A200223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200224
{
public static readonly long[] Value={ 8L,4L,8L,9L,0L,5L,1L,8L,8L,3L,2L,9L,5L,2L,2L,3L,6L,1L,7L,3L,4L,5L,6L,3L,8L,1L,6L,2L,6L,6L,1L,3L,2L,6L,7L,6L,8L,3L,4L,5L,9L,5L,3L,3L,8L,7L,9L,9L,7L,8L,6L,6L,5L,2L,5L,8L,0L,4L,1L,9L,1L,3L,6L,6L,3L,5L,7L,5L,7L,3L,3L,0L,4L,0L,5L,9L,1L,3L,7L,2L,4L,9L,5L,3L,8L,3L,2L,3L,5L,4L,5L,6L,3L,8L,6L,2L,5L,8L,6L };
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
public class A200224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200224Inst : IEnumerable<long>
{
public static readonly long[] Value=A200224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200224.Bytes);
public long this[int i]=>Value[i];

public static A200224Inst Instance=new A200224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200225
{
public static readonly long[] Value={ 2L,5L,8L,3L,7L,5L,8L,6L,0L,0L,8L,3L,4L,8L,6L,9L,4L,8L,5L,9L,8L,4L,3L,8L,2L,6L,1L,2L,2L,9L,7L,3L,3L,0L,9L,2L,9L,7L,5L,3L,9L,3L,8L,6L,9L,2L,8L,8L,7L,3L,0L,8L,4L,4L,2L,5L,8L,4L,9L,6L,2L,5L,0L,9L,9L,9L,8L,6L,0L,7L,4L,8L,4L,6L,5L,9L,9L,3L,6L,8L,5L,2L,5L,8L,6L,9L,6L,6L,4L,7L,7L,0L,7L,6L,1L,3L,9L,8L,4L };
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
public class A200225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200225Inst : IEnumerable<long>
{
public static readonly long[] Value=A200225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200225.Bytes);
public long this[int i]=>Value[i];

public static A200225Inst Instance=new A200225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200226
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,6L,5L,5L,6L,2L,9L,6L,9L,2L,0L,9L,4L,1L,7L,3L,3L,4L,5L,5L,4L,4L,1L,9L,9L,3L,8L,2L,7L,2L,1L,4L,5L,5L,8L,9L,6L,1L,2L,7L,1L,3L,9L,8L,2L,8L,6L,8L,9L,9L,1L,3L,1L,2L,1L,0L,7L,8L,3L,4L,0L,7L,3L,9L,5L,8L,9L,3L,1L,6L,8L,9L,8L,9L,6L,3L,8L,0L,4L,1L,5L,9L,0L,7L,5L,0L,4L,6L,8L,3L,4L,6L,0L,0L,5L };
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
public class A200226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200226Inst : IEnumerable<long>
{
public static readonly long[] Value=A200226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200226.Bytes);
public long this[int i]=>Value[i];

public static A200226Inst Instance=new A200226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200227
{
public static readonly long[] Value={ 2L,1L,2L,2L,0L,7L,2L,6L,1L,5L,9L,7L,9L,1L,8L,2L,9L,8L,9L,7L,8L,2L,3L,7L,4L,0L,5L,0L,1L,0L,3L,7L,5L,4L,0L,3L,7L,3L,2L,0L,7L,9L,1L,5L,7L,5L,0L,6L,1L,9L,7L,1L,1L,7L,0L,2L,4L,0L,1L,5L,1L,2L,3L,5L,4L,5L,2L,5L,4L,6L,3L,6L,4L,7L,4L,6L,8L,2L,1L,5L,3L,4L,7L,1L,5L,8L,9L,5L,1L,0L,6L,7L,2L,1L,5L,0L,0L,5L,7L };
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
public class A200227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200227Inst : IEnumerable<long>
{
public static readonly long[] Value=A200227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200227.Bytes);
public long this[int i]=>Value[i];

public static A200227Inst Instance=new A200227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200228
{
public static readonly long[] Value={ 1L,1L,6L,4L,7L,2L,0L,1L,3L,2L,6L,0L,0L,0L,8L,6L,5L,4L,8L,1L,4L,4L,1L,7L,3L,6L,0L,3L,9L,1L,7L,6L,2L,9L,3L,4L,2L,8L,3L,8L,8L,5L,9L,8L,2L,9L,2L,3L,6L,1L,6L,8L,4L,5L,0L,1L,3L,9L,9L,2L,3L,7L,8L,1L,6L,7L,5L,4L,2L,8L,8L,0L,2L,7L,2L,0L,0L,6L,5L,0L,9L,7L,8L,3L,9L,7L,1L,5L,4L,7L,9L,2L,5L,5L,4L,8L,9L,5L,0L };
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
public class A200228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200228Inst : IEnumerable<long>
{
public static readonly long[] Value=A200228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200228.Bytes);
public long this[int i]=>Value[i];

public static A200228Inst Instance=new A200228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200229
{
public static readonly long[] Value={ 6L,0L,1L,0L,8L,4L,6L,0L,8L,5L,4L,4L,7L,4L,4L,5L,7L,8L,0L,8L,4L,0L,9L,1L,5L,7L,5L,7L,9L,3L,7L,9L,2L,4L,3L,7L,0L,9L,6L,4L,9L,2L,5L,9L,9L,3L,5L,3L,1L,9L,7L,6L,9L,7L,2L,6L,3L,5L,3L,5L,4L,8L,0L,6L,8L,5L,1L,4L,2L,3L,0L,5L,2L,9L,4L,8L,1L,1L,0L,4L,5L,6L,6L,1L,1L,3L,2L,2L,1L,0L,5L,2L,6L,2L,2L,3L,1L,5L,1L };
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
public class A200229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200229Inst : IEnumerable<long>
{
public static readonly long[] Value=A200229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200229.Bytes);
public long this[int i]=>Value[i];

public static A200229Inst Instance=new A200229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200230
{
public static readonly long[] Value={ 8L,3L,3L,6L,2L,0L,4L,7L,0L,3L,0L,7L,4L,5L,4L,0L,7L,8L,2L,7L,4L,1L,7L,0L,1L,7L,8L,7L,1L,2L,5L,3L,2L,1L,2L,3L,7L,6L,7L,9L,6L,5L,3L,2L,7L,8L,9L,8L,2L,4L,5L,2L,5L,4L,1L,1L,9L,4L,2L,2L,6L,0L,7L,2L,6L,4L,5L,0L,6L,9L,6L,2L,9L,4L,9L,8L,9L,7L,3L,7L,4L,7L,5L,9L,4L,9L,1L,0L,9L,8L,5L,1L,9L,8L,7L,7L,1L,3L,1L };
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
public class A200230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200230Inst : IEnumerable<long>
{
public static readonly long[] Value=A200230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200230.Bytes);
public long this[int i]=>Value[i];

public static A200230Inst Instance=new A200230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200231
{
public static readonly long[] Value={ 5L,0L,8L,0L,6L,6L,6L,8L,3L,7L,0L,1L,8L,6L,8L,1L,3L,4L,6L,5L,3L,0L,5L,9L,4L,8L,4L,2L,0L,3L,5L,0L,9L,8L,2L,1L,8L,9L,4L,8L,2L,6L,2L,6L,7L,3L,3L,4L,2L,3L,8L,3L,3L,0L,9L,1L,6L,6L,9L,1L,7L,6L,3L,5L,0L,8L,2L,6L,5L,1L,1L,8L,0L,2L,3L,3L,0L,6L,1L,7L,3L,4L,6L,3L,9L,0L,2L,2L,0L,8L,5L,4L,5L,9L,6L,4L,8L,7L,0L };
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
public class A200231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200231Inst : IEnumerable<long>
{
public static readonly long[] Value=A200231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200231.Bytes);
public long this[int i]=>Value[i];

public static A200231Inst Instance=new A200231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200232
{
public static readonly long[] Value={ 9L,6L,3L,2L,9L,1L,3L,7L,6L,6L,1L,9L,6L,7L,9L,1L,0L,4L,6L,5L,5L,6L,4L,1L,8L,2L,9L,6L,6L,4L,1L,6L,4L,2L,3L,0L,2L,3L,0L,3L,9L,1L,9L,8L,6L,7L,2L,7L,0L,6L,2L,5L,1L,0L,1L,2L,1L,4L,5L,6L,4L,6L,1L,4L,8L,6L,2L,1L,1L,4L,2L,3L,8L,3L,8L,8L,9L,9L,3L,5L,1L,0L,0L,4L,1L,0L,9L,7L,1L,9L,4L,2L,1L,6L,6L,1L,4L,4L,8L };
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
public class A200232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200232Inst : IEnumerable<long>
{
public static readonly long[] Value=A200232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200232.Bytes);
public long this[int i]=>Value[i];

public static A200232Inst Instance=new A200232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200233
{
public static readonly long[] Value={ 4L,3L,2L,0L,5L,2L,7L,6L,0L,4L,2L,5L,7L,2L,3L,1L,3L,1L,9L,9L,6L,3L,8L,3L,6L,0L,7L,4L,5L,5L,3L,7L,2L,2L,8L,0L,5L,2L,2L,3L,5L,0L,2L,1L,7L,0L,6L,9L,8L,9L,9L,8L,4L,6L,3L,1L,2L,6L,8L,8L,5L,4L,9L,9L,4L,2L,0L,0L,8L,9L,3L,8L,0L,5L,2L,1L,6L,6L,7L,1L,4L,8L,1L,7L,7L,7L,5L,4L,4L,3L,8L,3L,6L,7L,9L,0L,7L,0L,4L };
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
public class A200233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200233Inst : IEnumerable<long>
{
public static readonly long[] Value=A200233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200233.Bytes);
public long this[int i]=>Value[i];

public static A200233Inst Instance=new A200233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200234
{
public static readonly long[] Value={ 1L,0L,9L,2L,9L,6L,1L,3L,1L,2L,6L,1L,9L,6L,9L,4L,2L,6L,9L,6L,4L,3L,3L,8L,2L,9L,1L,2L,5L,5L,6L,6L,2L,2L,1L,9L,2L,9L,1L,4L,5L,1L,8L,5L,8L,8L,1L,8L,0L,2L,8L,9L,8L,8L,9L,9L,6L,1L,7L,6L,3L,5L,6L,9L,6L,8L,9L,4L,4L,7L,6L,1L,6L,7L,6L,3L,4L,5L,1L,0L,2L,5L,1L,1L,5L,0L,5L,4L,3L,1L,2L,2L,5L,4L,0L,3L,8L,6L,4L };
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
public class A200234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200234Inst : IEnumerable<long>
{
public static readonly long[] Value=A200234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200234.Bytes);
public long this[int i]=>Value[i];

public static A200234Inst Instance=new A200234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200235
{
public static readonly long[] Value={ 3L,7L,1L,1L,2L,2L,3L,4L,9L,4L,6L,9L,2L,7L,2L,8L,0L,5L,3L,3L,4L,1L,9L,9L,9L,9L,6L,8L,8L,0L,9L,3L,8L,5L,6L,5L,6L,5L,1L,2L,3L,2L,4L,3L,8L,8L,6L,7L,4L,2L,5L,0L,8L,9L,6L,7L,6L,3L,4L,5L,2L,4L,2L,0L,1L,5L,5L,2L,9L,8L,3L,5L,9L,4L,0L,9L,7L,0L,6L,9L,2L,5L,8L,1L,2L,3L,2L,9L,9L,9L,3L,5L,7L,3L,5L,1L,3L,4L,1L };
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
public class A200235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200235Inst : IEnumerable<long>
{
public static readonly long[] Value=A200235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200235.Bytes);
public long this[int i]=>Value[i];

public static A200235Inst Instance=new A200235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200236
{
public static readonly long[] Value={ 1L,2L,1L,7L,2L,4L,5L,4L,2L,8L,9L,4L,5L,4L,5L,9L,0L,2L,7L,6L,9L,3L,2L,4L,5L,8L,6L,3L,5L,4L,5L,6L,0L,7L,5L,9L,8L,0L,1L,4L,4L,3L,6L,1L,3L,7L,3L,3L,1L,6L,6L,6L,9L,9L,0L,4L,7L,4L,1L,7L,5L,2L,2L,5L,7L,9L,2L,2L,5L,5L,9L,2L,8L,8L,9L,6L,7L,8L,5L,5L,1L,4L,3L,9L,4L,3L,5L,4L,6L,8L,8L,7L,5L,3L,5L,3L,3L,4L,4L };
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
public class A200236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200236Inst : IEnumerable<long>
{
public static readonly long[] Value=A200236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200236.Bytes);
public long this[int i]=>Value[i];

public static A200236Inst Instance=new A200236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200237
{
public static readonly long[] Value={ 7L,2L,5L,7L,7L,3L,9L,3L,1L,3L,7L,5L,0L,9L,8L,1L,4L,8L,9L,5L,1L,8L,1L,3L,2L,6L,4L,6L,5L,2L,3L,1L,3L,6L,2L,0L,5L,0L,7L,1L,0L,0L,3L,6L,3L,9L,2L,4L,3L,7L,9L,1L,2L,8L,7L,9L,4L,2L,5L,4L,9L,7L,2L,3L,0L,8L,5L,0L,1L,2L,8L,3L,0L,9L,4L,0L,3L,4L,8L,6L,7L,3L,5L,7L,4L,1L,1L,8L,6L,2L,0L,6L,8L,6L,3L,3L,7L,9L,2L };
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
public class A200237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200237Inst : IEnumerable<long>
{
public static readonly long[] Value=A200237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200237.Bytes);
public long this[int i]=>Value[i];

public static A200237Inst Instance=new A200237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200238
{
public static readonly long[] Value={ 9L,3L,0L,0L,5L,7L,1L,1L,0L,0L,9L,2L,4L,8L,9L,2L,4L,6L,7L,8L,8L,2L,4L,6L,8L,1L,4L,4L,0L,5L,6L,4L,2L,9L,8L,7L,6L,1L,2L,8L,2L,5L,6L,1L,0L,1L,9L,3L,3L,3L,0L,7L,7L,4L,3L,6L,2L,1L,4L,0L,0L,8L,2L,0L,5L,2L,4L,8L,3L,3L,0L,7L,8L,7L,5L,2L,4L,1L,7L,9L,3L,2L,7L,7L,1L,6L,9L,0L,3L,3L,2L,7L,7L,5L,3L,4L,1L,0L,7L };
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
public class A200238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200238Inst : IEnumerable<long>
{
public static readonly long[] Value=A200238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200238.Bytes);
public long this[int i]=>Value[i];

public static A200238Inst Instance=new A200238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200239
{
public static readonly long[] Value={ 6L,3L,7L,6L,6L,1L,1L,5L,7L,9L,4L,6L,0L,7L,3L,1L,3L,4L,1L,1L,9L,8L,9L,5L,4L,5L,6L,5L,8L,8L,1L,9L,6L,2L,0L,1L,3L,7L,3L,3L,9L,9L,2L,2L,8L,0L,7L,2L,7L,3L,3L,8L,6L,9L,5L,5L,6L,1L,0L,6L,2L,3L,0L,9L,0L,1L,0L,1L,4L,0L,5L,4L,5L,4L,4L,3L,3L,0L,7L,9L,6L,8L,0L,0L,1L,4L,3L,8L,4L,6L,5L,1L,0L,7L,1L,4L,4L,7L,8L };
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
public class A200239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200239Inst : IEnumerable<long>
{
public static readonly long[] Value=A200239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200239.Bytes);
public long this[int i]=>Value[i];

public static A200239Inst Instance=new A200239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200240
{
public static readonly long[] Value={ 1L,0L,3L,9L,8L,2L,9L,6L,9L,3L,3L,2L,4L,6L,0L,7L,5L,9L,6L,0L,7L,1L,7L,9L,3L,5L,3L,2L,1L,2L,0L,3L,8L,7L,7L,6L,2L,6L,4L,1L,3L,2L,0L,9L,3L,9L,9L,9L,6L,8L,7L,3L,4L,1L,4L,4L,0L,5L,9L,2L,6L,3L,0L,4L,7L,3L,9L,8L,1L,6L,8L,8L,9L,6L,2L,3L,0L,3L,5L,4L,8L,8L,6L,6L,3L,9L,1L,6L,5L,0L,2L,9L,3L,0L,7L,2L,3L,3L,6L };
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
public class A200240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200240Inst : IEnumerable<long>
{
public static readonly long[] Value=A200240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200240.Bytes);
public long this[int i]=>Value[i];

public static A200240Inst Instance=new A200240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200241
{
public static readonly long[] Value={ 4L,9L,5L,5L,9L,4L,2L,3L,2L,7L,9L,8L,1L,1L,0L,8L,0L,3L,9L,6L,6L,6L,9L,4L,0L,8L,1L,3L,6L,0L,6L,6L,6L,2L,3L,4L,8L,1L,2L,3L,0L,0L,4L,8L,8L,5L,5L,2L,1L,1L,1L,9L,5L,6L,6L,1L,7L,6L,5L,0L,5L,3L,3L,1L,4L,8L,8L,0L,6L,1L,9L,9L,6L,4L,2L,7L,5L,6L,6L,0L,3L,9L,4L,8L,5L,9L,8L,0L,7L,7L,1L,0L,7L,1L,4L,6L,6L,2L,3L };
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
public class A200241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200241Inst : IEnumerable<long>
{
public static readonly long[] Value=A200241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200241.Bytes);
public long this[int i]=>Value[i];

public static A200241Inst Instance=new A200241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200242
{
public static readonly long[] Value={ 1L,2L,5L,5L,9L,6L,7L,0L,2L,4L,9L,4L,3L,7L,2L,9L,6L,2L,8L,8L,5L,4L,2L,8L,3L,2L,1L,5L,3L,9L,7L,6L,4L,4L,4L,0L,2L,9L,8L,0L,6L,0L,3L,7L,6L,1L,1L,7L,9L,2L,9L,5L,7L,7L,3L,0L,3L,4L,6L,6L,1L,3L,9L,2L,6L,3L,8L,4L,5L,3L,4L,5L,3L,8L,0L,0L,6L,5L,3L,6L,1L,7L,3L,8L,6L,7L,1L,5L,5L,0L,1L,4L,0L,1L,0L,6L,1L,5L,2L };
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
public class A200242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200242Inst : IEnumerable<long>
{
public static readonly long[] Value=A200242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200242.Bytes);
public long this[int i]=>Value[i];

public static A200242Inst Instance=new A200242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200243
{
public static readonly long[] Value={ 1L,3L,8L,5L,6L,4L,0L,6L,4L,6L,0L,5L,5L,1L,0L,1L,8L,3L,4L,8L,2L,1L,9L,5L,7L,0L,7L,3L,2L,0L,4L,6L,9L,7L,8L,9L,3L,5L,5L,4L,2L,4L,4L,2L,0L,3L,0L,4L,8L,3L,0L,4L,5L,0L,2L,4L,4L,4L,6L,4L,5L,5L,8L,3L,5L,6L,1L,5L,4L,6L,4L,1L,3L,5L,2L,7L,0L,4L,0L,0L,2L,9L,6L,6L,4L,9L,1L,6L,9L,4L,9L,4L,0L,5L,7L,9L,8L,8L,6L,0L,5L,4L,0L,5L,0L };
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
public class A200243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200243Inst : IEnumerable<long>
{
public static readonly long[] Value=A200243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200243.Bytes);
public long this[int i]=>Value[i];

public static A200243Inst Instance=new A200243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200244
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
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
public class A200244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200244Inst : IEnumerable<long>
{
public static readonly long[] Value=A200244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200244.Bytes);
public long this[int i]=>Value[i];

public static A200244Inst Instance=new A200244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200245
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,3L,3L,4L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,17L,18L,19L,19L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,26L,27L };
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
public class A200245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200245Inst : IEnumerable<long>
{
public static readonly long[] Value=A200245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200245.Bytes);
public long this[int i]=>Value[i];

public static A200245Inst Instance=new A200245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200246
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L };
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
public class A200246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200246Inst : IEnumerable<long>
{
public static readonly long[] Value=A200246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200246.Bytes);
public long this[int i]=>Value[i];

public static A200246Inst Instance=new A200246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200247
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,4L,5L,5L,5L,6L,7L,8L,8L,9L,9L,10L,11L,12L,12L,13L,14L,14L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,21L,21L,22L,23L,23L,24L,25L,26L,27L,28L,29L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,38L,38L,38L,39L,39L,39L,40L,40L,41L,41L,42L,42L,43L,43L,43L };
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
public class A200247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200247Inst : IEnumerable<long>
{
public static readonly long[] Value=A200247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200247.Bytes);
public long this[int i]=>Value[i];

public static A200247Inst Instance=new A200247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200248
{
public static readonly BigInteger[] Value={ 0L,1L,2L,9L,68L,710L,9414L,151032L,2840648L,61247664L,1488691530L,40262372480L,1199047315212L,38984874829056L,1373954963380622L,52171222364513280L,2123286652815757200L,BigInteger.Parse("92201888436661409792"),BigInteger.Parse("4255016114128163220882"),BigInteger.Parse("207954945060162884960256") };
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
public class A200248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200248Inst Instance=new A200248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200249
{
public static readonly long[] Value={ 6L,21L,75L,267L,951L,3387L,12063L,42963L,153015L,544971L,1940943L,6912771L,24620199L,87686139L,312298815L,1112268723L,3961403799L,14108748843L,50249054127L,178964660067L,637392088455L,2270105585499L,8085100933407L,28795513971219L };
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
public class A200249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200249Inst : IEnumerable<long>
{
public static readonly long[] Value=A200249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200249.Bytes);
public long this[int i]=>Value[i];

public static A200249Inst Instance=new A200249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200250
{
public static readonly long[] Value={ 8L,36L,164L,750L,3434L,15724L,71970L,329455L,1508139L,6903702L,31602661L,144665637L,662227235L,3031438038L,13876832881L,63523149100L,290786125630L,1331114279973L,6093362338144L,27893220846536L,127685131134366L,584496598744029L };
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
public class A200250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200250Inst : IEnumerable<long>
{
public static readonly long[] Value=A200250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200250.Bytes);
public long this[int i]=>Value[i];

public static A200250Inst Instance=new A200250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200251
{
public static readonly long[] Value={ 2L,3L,3L,4L,6L,5L,5L,10L,12L,8L,6L,15L,26L,24L,13L,7L,21L,45L,69L,48L,21L,8L,28L,75L,135L,181L,96L,34L,9L,36L,112L,267L,405L,476L,192L,55L,10L,45L,164L,448L,951L,1215L,1252L,384L,89L,11L,55L,225L,750L,1792L,3387L,3645L,3292L,768L,144L,12L,66L,305L,1125L,3434L,7168L,12063L };
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
public class A200251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200251Inst : IEnumerable<long>
{
public static readonly long[] Value=A200251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200251.Bytes);
public long this[int i]=>Value[i];

public static A200251Inst Instance=new A200251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200252
{
public static readonly long[] Value={ 5L,12L,26L,45L,75L,112L,164L,225L,305L,396L,510L,637L,791L,960L,1160L,1377L,1629L,1900L,2210L,2541L,2915L,3312L,3756L,4225L,4745L,5292L,5894L,6525L,7215L,7936L,8720L,9537L,10421L,11340L,12330L,13357L,14459L,15600L,16820L,18081L,19425L,20812L,22286L,23805L };
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
public class A200252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200252Inst : IEnumerable<long>
{
public static readonly long[] Value=A200252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200252.Bytes);
public long this[int i]=>Value[i];

public static A200252Inst Instance=new A200252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200253
{
public static readonly long[] Value={ 8L,24L,69L,135L,267L,448L,750L,1125L,1690L,2376L,3339L,4459L,5957L,7680L,9900L,12393L,15516L,19000L,23265L,27951L,33583L,39744L,47034L,54925L,64142L,74088L,85575L,97875L,111945L,126976L,144024L,162129L,182512L,204120L,228285L,253783L,282131L,312000L };
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
public class A200253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200253Inst : IEnumerable<long>
{
public static readonly long[] Value=A200253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200253.Bytes);
public long this[int i]=>Value[i];

public static A200253Inst Instance=new A200253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200254
{
public static readonly long[] Value={ 13L,48L,181L,405L,951L,1792L,3434L,5625L,9365L,14256L,21855L,31213L,44863L,61440L,84500L,111537L,147789L,190000L,244905L,307461L,386903L,476928L,588990L,714025L,867061L,1037232L,1242451L,1468125L,1736895L,2031616L,2378792L,2756193L,3196493L };
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
public class A200254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200254Inst : IEnumerable<long>
{
public static readonly long[] Value=A200254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200254.Bytes);
public long this[int i]=>Value[i];

public static A200254Inst Instance=new A200254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200255
{
public static readonly long[] Value={ 21L,96L,476L,1215L,3387L,7168L,15724L,28125L,51895L,85536L,143052L,218491L,337869L,491520L,721208L,1003833L,1407681L,1900000L,2578060L,3382071L,4457431L,5723136L,7375716L,9282325L,11720787L,14521248L,18038972L,22021875L,26948985L,32505856L };
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
public class A200255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200255Inst : IEnumerable<long>
{
public static readonly long[] Value=A200255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200255.Bytes);
public long this[int i]=>Value[i];

public static A200255Inst Instance=new A200255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200256
{
public static readonly long[] Value={ 34L,192L,1252L,3645L,12063L,28672L,71970L,140625L,287570L,513216L,936348L,1529437L,2544535L,3932160L,6155908L,9034497L,13408074L,19000000L,27138660L,37202781L,51353159L,68677632L,92363430L,120670225L,158439658L,203297472L,261905308L };
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
public class A200256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200256Inst : IEnumerable<long>
{
public static readonly long[] Value=A200256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200256.Bytes);
public long this[int i]=>Value[i];

public static A200256Inst Instance=new A200256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200257
{
public static readonly long[] Value={ 5L,5L,0L,6L,2L,9L,9L,6L,3L,8L,6L,6L,8L,1L,3L,1L,8L,1L,9L,8L,8L,4L,3L,9L,5L,0L,6L,3L,3L,1L,3L,1L,8L,8L,1L,6L,6L,3L,2L,5L,3L,5L,3L,9L,0L,5L,5L,1L,8L,2L,7L,9L,2L,0L,0L,0L,3L,9L,6L,8L,0L,3L,8L,8L,6L,5L,0L,1L,1L,9L,7L,7L,6L,2L,9L,3L,6L,2L,9L,1L,1L,1L,8L,8L,9L };
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
public class A200257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200257Inst : IEnumerable<long>
{
public static readonly long[] Value=A200257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200257.Bytes);
public long this[int i]=>Value[i];

public static A200257Inst Instance=new A200257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200258
{
public static readonly BigInteger[] Value={ 32L,1508L,70844L,3328160L,156352676L,7345247612L,345070285088L,16210958151524L,761569962836540L,35777577295165856L,1680784562909958692L,BigInteger.Parse("78961096879472892668"),BigInteger.Parse("3709490768772315996704"),BigInteger.Parse("174267105035419378952420"),BigInteger.Parse("8186844445895938494767036") };
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
public class A200258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200258Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200258.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200258Inst Instance=new A200258Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200259
{
public static readonly long[] Value={ 1L,5L,6L,7L,8L,11L,12L,16L,17L,20L,21L,22L,25L,26L,27L,28L,29L,31L,35L,38L,39L,42L,47L,51L,52L,54L,55L,58L,59L,62L,63L,69L,70L,73L,76L,77L,81L,83L,84L,85L,88L,92L,94L,95L,96L,97L,98L,99L,100L,101L,103L,104L,107L,112L,113L,114L,115L,119L,120L,122L,123L,125L };
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
public class A200259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200259Inst : IEnumerable<long>
{
public static readonly long[] Value=A200259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200259.Bytes);
public long this[int i]=>Value[i];

public static A200259Inst Instance=new A200259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200260
{
public static readonly long[] Value={ 2L,3L,4L,9L,10L,13L,14L,15L,18L,19L,23L,24L,30L,32L,33L,34L,36L,37L,40L,41L,43L,44L,45L,46L,48L,49L,50L,53L,56L,57L,60L,61L,64L,65L,66L,67L,68L,71L,72L,74L,75L,78L,79L,80L,82L,86L,87L,89L,90L,91L,93L,102L,105L,106L,108L,109L,110L,111L,116L,117L,118L,121L,124L };
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
public class A200260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200260Inst : IEnumerable<long>
{
public static readonly long[] Value=A200260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200260.Bytes);
public long this[int i]=>Value[i];

public static A200260Inst Instance=new A200260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200261
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L };
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
public class A200261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200261Inst : IEnumerable<long>
{
public static readonly long[] Value=A200261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200261.Bytes);
public long this[int i]=>Value[i];

public static A200261Inst Instance=new A200261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200262
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,5L,5L,6L,7L,7L,7L,7L,8L,9L,9L,9L,10L,11L,12L,12L,12L,13L,14L,15L,16L,17L,17L,18L,18L,18L,18L,19L,19L,19L,20L,21L,21L,21L,22L,22L,22L,22L,22L,23L,23L,23L,23L,24L,25L,25L,26L,27L,27L,27L,28L,29L,29L,29L,30L,31L,31L,31L,31L,31L,31L,32L };
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
public class A200262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200262Inst : IEnumerable<long>
{
public static readonly long[] Value=A200262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200262.Bytes);
public long this[int i]=>Value[i];

public static A200262Inst Instance=new A200262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200263
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L };
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
public class A200263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200263Inst : IEnumerable<long>
{
public static readonly long[] Value=A200263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200263.Bytes);
public long this[int i]=>Value[i];

public static A200263Inst Instance=new A200263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200264
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,3L,3L,3L,4L,5L,5L,5L,6L,7L,8L,8L,8L,9L,10L,10L,10L,10L,11L,12L,12L,12L,12L,12L,12L,13L,13L,14L,15L,16L,16L,17L,18L,18L,18L,19L,20L,20L,21L,22L,23L,24L,24L,25L,26L,27L,27L,27L,28L,28L,28L,29L,30L,30L,30L,31L,32L,32L,32L,33L,34L,35L,36L,37L,37L };
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
public class A200264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200264Inst : IEnumerable<long>
{
public static readonly long[] Value=A200264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200264.Bytes);
public long this[int i]=>Value[i];

public static A200264Inst Instance=new A200264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200265
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,11L,2L,21L,84L,131L,6L,92L,588L,1908L,2666L,24L,490L,4380L,22020L,62860L,81534L,120L,3084L,35790L,246480L,1075020L,2823180L,3478014L,720L,22428L,322224L,2838570L,16775640L,66811920L,165838848L,196993194L };
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
public class A200265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200265Inst : IEnumerable<long>
{
public static readonly long[] Value=A200265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200265.Bytes);
public long this[int i]=>Value[i];

public static A200265Inst Instance=new A200265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200266
{
public static readonly long[] Value={ 1L,3L,3L,3L,5L,5L,5L,7L,3L,3L,7L,9L,11L,17L,5L,3L,13L,17L,15L,21L,5L,9L,21L,19L,9L,13L,3L,5L,21L,17L };
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
public class A200266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200266Inst : IEnumerable<long>
{
public static readonly long[] Value=A200266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200266.Bytes);
public long this[int i]=>Value[i];

public static A200266Inst Instance=new A200266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200267
{
public static readonly long[] Value={ 1L,4L,4L,6L,8L,8L,8L,16L,4L,10L,12L,36L,20L,48L,8L,20L,28L,70L,28L,154L,8L,32L,40L,174L,16L,100L,4L,38L,44L,118L };
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
public class A200267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200267Inst : IEnumerable<long>
{
public static readonly long[] Value=A200267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200267.Bytes);
public long this[int i]=>Value[i];

public static A200267Inst Instance=new A200267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200268
{
public static readonly long[] Value={ 1L,5L,7L,9L,13L,13L,21L,31L,19L,37L,75L,139L,97L,181L,101L,225L,277L,505L,465L,971L,225L };
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
public class A200268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200268Inst : IEnumerable<long>
{
public static readonly long[] Value=A200268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200268.Bytes);
public long this[int i]=>Value[i];

public static A200268Inst Instance=new A200268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200269
{
public static readonly long[] Value={ 1L,6L,10L,14L,18L,26L,34L,52L,34L,104L,172L,392L,186L,546L,226L,766L,806L,2474L,1202L,4214L,442L,2328L };
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
public class A200269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200269Inst : IEnumerable<long>
{
public static readonly long[] Value=A200269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200269.Bytes);
public long this[int i]=>Value[i];

public static A200269Inst Instance=new A200269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200270
{
public static readonly long[] Value={ 1L,7L,13L,25L,37L,53L,53L,83L,119L,261L,477L,955L,615L,1617L,937L,2447L,5409L,13829L,9379L,17547L };
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
public class A200270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200270Inst : IEnumerable<long>
{
public static readonly long[] Value=A200270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200270.Bytes);
public long this[int i]=>Value[i];

public static A200270Inst Instance=new A200270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200271
{
public static readonly long[] Value={ 1L,8L,16L,36L,64L,112L,118L,228L,236L,574L,958L,2110L,1434L,4316L,2560L,8448L,18834L,60888L,38672L,73250L,15518L,42050L,48352L,309524L };
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
public class A200271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200271Inst : IEnumerable<long>
{
public static readonly long[] Value=A200271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200271.Bytes);
public long this[int i]=>Value[i];

public static A200271Inst Instance=new A200271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200272
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,7L,6L,5L,2L,1L,7L,10L,9L,8L,5L,2L,1L,8L,13L,14L,13L,8L,5L,2L,1L,9L,16L,25L,18L,13L,8L,7L,2L,1L,10L,21L,36L,37L,26L,21L,16L,3L,2L,1L,11L,26L,47L,64L,53L,34L,31L,4L,3L,2L,1L,12L,31L,64L,97L,112L,53L,52L,19L,10L,7L,2L,1L,13L,36L,87L,140L,197L,118L,83L };
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
public class A200272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200272Inst : IEnumerable<long>
{
public static readonly long[] Value=A200272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200272.Bytes);
public long this[int i]=>Value[i];

public static A200272Inst Instance=new A200272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200273
{
public static readonly long[] Value={ 2L,3L,6L,9L,14L,25L,36L,47L,64L,87L,110L,143L,176L,209L,258L,311L,364L,431L,498L,575L,666L,761L,856L,969L,1092L,1219L,1364L,1513L,1662L,1847L,2032L,2221L,2432L,2647L,2876L,3135L,3394L,3657L,3946L,4257L,4568L,4913L,5258L,5607L,6004L,6409L,6814L,7257L,7700L,8169L };
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
public class A200273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200273Inst : IEnumerable<long>
{
public static readonly long[] Value=A200273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200273.Bytes);
public long this[int i]=>Value[i];

public static A200273Inst Instance=new A200273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200274
{
public static readonly long[] Value={ 2L,5L,8L,13L,18L,37L,64L,97L,140L,207L,286L,399L,528L,687L,878L,1127L,1408L,1749L,2130L,2607L,3128L,3743L,4414L,5191L,6056L,7067L,8156L,9387L,10706L,12241L,13876L,15717L,17670L,19829L,22172L,24787L,27542L,30571L,33752L,37317L,41058L,45153L,49440L,54073L };
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
public class A200274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200274Inst : IEnumerable<long>
{
public static readonly long[] Value=A200274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200274.Bytes);
public long this[int i]=>Value[i];

public static A200274Inst Instance=new A200274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200275
{
public static readonly long[] Value={ 2L,5L,8L,13L,26L,53L,112L,197L,302L,465L,688L,1013L,1406L,1995L,2790L,3759L,4990L,6419L,8132L,10281L,13134L,16521L,20352L,24767L,30018L,36095L,43022L,51469L,60976L,71993L,84356L,98137L,113366L,130095L,150630L,173315L,198134L,225225L,254604L,287725L };
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
public class A200275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200275Inst : IEnumerable<long>
{
public static readonly long[] Value=A200275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200275.Bytes);
public long this[int i]=>Value[i];

public static A200275Inst Instance=new A200275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200276
{
public static readonly long[] Value={ 2L,5L,8L,21L,34L,53L,118L,267L,516L,901L,1454L,2249L,3264L,5135L,7616L,11061L,15434L,21089L,28008L,36687L,49294L,65037L,84056L,107327L,134670L,167275L,204986L,256111L,315260L,385087L,464742L,557425L,661956L,781471L,930978L,1102693L,1294980L };
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
public class A200276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200276Inst : IEnumerable<long>
{
public static readonly long[] Value=A200276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200276.Bytes);
public long this[int i]=>Value[i];

public static A200276Inst Instance=new A200276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200277
{
public static readonly long[] Value={ 8L,1L,7L,7L,1L,5L,2L,1L,8L,7L,9L,2L,3L,0L,4L,5L,4L,5L,1L,1L,1L,9L,1L,4L,5L,4L,2L,0L,8L,3L,6L,5L,7L,7L,7L,1L,5L,3L,9L,3L,9L,1L,6L,5L,1L,3L,2L,7L,1L,2L,0L,1L,5L,3L,7L,2L,7L,9L,0L,7L,5L,0L,9L,9L,8L,6L,2L,4L,1L,4L,4L,1L,9L,7L,2L,7L,4L,5L,8L,0L,2L,7L,4L,7L,1L,3L,8L,1L,9L,8L,3L,6L,2L,7L,8L,7L,2L,9L,0L };
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
public class A200277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200277Inst : IEnumerable<long>
{
public static readonly long[] Value=A200277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200277.Bytes);
public long this[int i]=>Value[i];

public static A200277Inst Instance=new A200277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200278
{
public static readonly long[] Value={ 1L,0L,0L,0L,3L,0L,3L,6L,3L,9L,2L,8L,3L,5L,9L,0L,1L,8L,5L,1L,8L,7L,2L,2L,5L,0L,3L,5L,7L,4L,4L,1L,8L,0L,0L,1L,2L,2L,5L,8L,5L,6L,5L,6L,1L,8L,5L,2L,9L,2L,0L,2L,6L,4L,2L,6L,3L,2L,2L,5L,7L,4L,9L,5L,4L,6L,0L,9L,3L,0L,3L,2L,3L,5L,9L,3L,8L,1L,8L,7L,9L,0L,3L,9L,0L,6L,4L,2L,4L,1L,8L,6L,9L,7L,4L,6L,3L,5L,4L };
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
public class A200278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200278Inst : IEnumerable<long>
{
public static readonly long[] Value=A200278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200278.Bytes);
public long this[int i]=>Value[i];

public static A200278Inst Instance=new A200278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200279
{
public static readonly long[] Value={ 7L,3L,5L,6L,3L,8L,0L,7L,6L,4L,4L,4L,6L,8L,2L,0L,8L,6L,1L,4L,7L,7L,6L,9L,5L,5L,6L,1L,2L,3L,1L,1L,6L,8L,1L,9L,6L,8L,7L,7L,6L,5L,5L,3L,8L,3L,9L,9L,4L,8L,2L,5L,4L,5L,9L,7L,7L,0L,5L,1L,1L,3L,8L,7L,9L,4L,5L,8L,4L,1L,7L,8L,0L,7L,1L,9L,1L,9L,7L,3L,5L,5L,2L,8L,4L,2L,2L,0L,3L,5L,6L,5L,9L,2L,8L,5L,8L,5L,3L };
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
public class A200279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200279Inst : IEnumerable<long>
{
public static readonly long[] Value=A200279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200279.Bytes);
public long this[int i]=>Value[i];

public static A200279Inst Instance=new A200279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200280
{
public static readonly long[] Value={ 1L,0L,9L,6L,4L,0L,6L,9L,9L,2L,4L,2L,1L,2L,6L,7L,9L,4L,7L,2L,2L,1L,9L,8L,7L,6L,8L,1L,3L,1L,4L,0L,2L,0L,2L,2L,9L,8L,2L,3L,2L,2L,7L,4L,2L,6L,9L,9L,9L,1L,0L,5L,7L,2L,0L,4L,6L,6L,1L,8L,9L,3L,1L,7L,4L,9L,4L,3L,5L,6L,1L,2L,7L,3L,8L,5L,4L,7L,7L,3L,2L,9L,1L,5L,8L,4L,9L,3L,8L,2L,9L,1L,5L,0L,3L,7L,5L,9L,2L };
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
public class A200280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200280Inst : IEnumerable<long>
{
public static readonly long[] Value=A200280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200280.Bytes);
public long this[int i]=>Value[i];

public static A200280Inst Instance=new A200280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200281
{
public static readonly long[] Value={ 6L,6L,1L,5L,7L,2L,3L,7L,8L,1L,8L,7L,9L,8L,9L,9L,9L,2L,0L,6L,2L,8L,9L,9L,3L,0L,7L,3L,2L,8L,9L,8L,9L,3L,6L,5L,5L,7L,5L,7L,4L,9L,6L,3L,1L,7L,5L,0L,6L,4L,6L,6L,2L,7L,2L,2L,8L,7L,0L,8L,1L,1L,3L,0L,6L,7L,7L,3L,1L,5L,1L,9L,9L,2L,2L,4L,8L,9L,9L,0L,3L,5L,9L,8L,6L,7L,4L,3L,9L,2L,8L,6L,7L,4L,4L,9L,6L,0L,3L };
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
public class A200281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200281Inst : IEnumerable<long>
{
public static readonly long[] Value=A200281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200281.Bytes);
public long this[int i]=>Value[i];

public static A200281Inst Instance=new A200281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200282
{
public static readonly long[] Value={ 1L,1L,9L,2L,4L,0L,4L,5L,5L,0L,0L,7L,6L,8L,1L,5L,6L,5L,9L,2L,9L,0L,0L,9L,5L,4L,9L,6L,6L,1L,3L,6L,9L,0L,6L,9L,9L,6L,9L,8L,5L,2L,7L,5L,5L,6L,4L,2L,1L,0L,0L,3L,5L,5L,4L,4L,8L,2L,3L,5L,9L,1L,8L,3L,1L,4L,6L,8L,9L,9L,9L,4L,8L,6L,2L,2L,0L,2L,9L,2L,8L,7L,6L,5L,4L,6L,6L,0L,3L,9L,8L,9L,5L,8L,2L,9L,8L,5L,6L };
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
public class A200282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200282Inst : IEnumerable<long>
{
public static readonly long[] Value=A200282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200282.Bytes);
public long this[int i]=>Value[i];

public static A200282Inst Instance=new A200282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200283
{
public static readonly long[] Value={ 5L,9L,5L,9L,2L,9L,4L,5L,4L,1L,2L,0L,2L,2L,3L,4L,2L,6L,3L,2L,2L,3L,4L,8L,0L,6L,7L,3L,5L,2L,6L,2L,1L,4L,9L,7L,8L,7L,4L,8L,9L,4L,9L,4L,8L,5L,0L,7L,5L,1L,6L,1L,3L,7L,3L,9L,7L,9L,0L,9L,8L,6L,9L,1L,2L,5L,8L,6L,4L,4L,0L,4L,6L,2L,0L,4L,3L,4L,1L,3L,0L,8L,5L,5L,7L,1L,8L,2L,4L,9L,2L,8L,2L,6L,2L,1L,8L,7L,0L };
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
public class A200283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200283Inst : IEnumerable<long>
{
public static readonly long[] Value=A200283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200283.Bytes);
public long this[int i]=>Value[i];

public static A200283Inst Instance=new A200283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200284
{
public static readonly long[] Value={ 1L,2L,8L,6L,1L,2L,8L,0L,2L,6L,7L,4L,5L,9L,0L,9L,9L,6L,5L,2L,7L,9L,1L,5L,1L,1L,2L,6L,1L,4L,6L,3L,7L,9L,4L,2L,3L,5L,1L,2L,6L,4L,2L,7L,5L,6L,5L,2L,8L,4L,4L,1L,9L,4L,6L,0L,0L,6L,6L,9L,7L,2L,2L,3L,6L,1L,3L,0L,5L,8L,2L,2L,0L,3L,8L,5L,4L,0L,6L,3L,0L,8L,7L,8L,1L,6L,4L,5L,6L,4L,8L,4L,3L,6L,3L,8L,2L,8L,2L };
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
public class A200284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200284Inst : IEnumerable<long>
{
public static readonly long[] Value=A200284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200284.Bytes);
public long this[int i]=>Value[i];

public static A200284Inst Instance=new A200284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200285
{
public static readonly long[] Value={ 3L,7L,5L,4L,0L,3L,6L,4L,9L,9L,6L,1L,1L,3L,9L,8L,4L,8L,6L,9L,2L,9L,5L,7L,7L,3L,5L,8L,3L,7L,1L,5L,4L,4L,2L,9L,2L,9L,9L,7L,6L,1L,4L,4L,3L,4L,6L,5L,7L,3L,0L,8L,5L,7L,0L,2L,2L,9L,3L,2L,6L,0L,8L,6L,4L,5L,3L,1L,4L,7L,9L,1L,5L,9L,0L,0L,2L,3L,7L,6L,2L,0L,0L,4L,8L,2L,8L,6L,4L,7L,6L,2L,8L,2L,4L,9L,1L,2L,5L };
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
public class A200285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200285Inst : IEnumerable<long>
{
public static readonly long[] Value=A200285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200285.Bytes);
public long this[int i]=>Value[i];

public static A200285Inst Instance=new A200285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200286
{
public static readonly long[] Value={ 5L,8L,8L,8L,5L,1L,7L,4L,2L,6L,7L,5L,0L,4L,1L,1L,7L,9L,9L,9L,9L,6L,5L,9L,7L,1L,4L,6L,4L,4L,8L,4L,8L,0L,3L,8L,1L,8L,0L,1L,6L,1L,3L,7L,1L,7L,0L,6L,1L,7L,3L,1L,0L,3L,1L,5L,9L,4L,8L,7L,4L,1L,6L,6L,3L,8L,7L,9L,2L,3L,6L,2L,6L,0L,5L,0L,4L,2L,8L,3L,7L,4L,8L,0L,4L,0L,8L,0L,9L,8L,6L,0L,4L,9L,9L,8L,2L,2L,7L };
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
public class A200286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200286Inst : IEnumerable<long>
{
public static readonly long[] Value=A200286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200286.Bytes);
public long this[int i]=>Value[i];

public static A200286Inst Instance=new A200286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200287
{
public static readonly long[] Value={ 3L,0L,0L,9L,3L,1L,8L,8L,5L,4L,2L,1L,9L,0L,2L,3L,7L,0L,0L,3L,1L,0L,0L,6L,2L,4L,0L,7L,1L,7L,5L,1L,4L,9L,5L,6L,3L,1L,9L,8L,7L,9L,8L,0L,3L,3L,2L,2L,2L,6L,8L,8L,4L,5L,0L,8L,3L,5L,0L,3L,3L,3L,7L,2L,3L,5L,3L,1L,6L,0L,8L,9L,4L,3L,2L,6L,1L,3L,9L,1L,9L,2L,8L,1L,6L,6L,5L,7L,1L,9L,5L,2L,0L,1L,6L,2L,3L,0L,2L };
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
public class A200287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200287Inst : IEnumerable<long>
{
public static readonly long[] Value=A200287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200287.Bytes);
public long this[int i]=>Value[i];

public static A200287Inst Instance=new A200287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200288
{
public static readonly long[] Value={ 7L,1L,9L,3L,8L,4L,2L,6L,0L,4L,5L,9L,8L,7L,5L,8L,3L,2L,1L,0L,7L,5L,5L,2L,4L,1L,1L,5L,9L,1L,3L,8L,0L,6L,1L,7L,5L,5L,7L,6L,3L,3L,7L,2L,7L,5L,5L,4L,2L,4L,6L,3L,4L,1L,9L,6L,7L,5L,8L,9L,1L,7L,2L,4L,8L,5L,5L,8L,5L,3L,7L,4L,4L,4L,3L,4L,0L,5L,7L,4L,5L,9L,8L,7L,5L,5L,2L,9L,0L,4L,2L,5L,1L,9L,8L,0L,5L,8L,3L };
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
public class A200288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200288Inst : IEnumerable<long>
{
public static readonly long[] Value=A200288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200288.Bytes);
public long this[int i]=>Value[i];

public static A200288Inst Instance=new A200288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200289
{
public static readonly long[] Value={ 2L,4L,5L,4L,6L,3L,0L,3L,1L,8L,3L,0L,8L,2L,4L,2L,4L,2L,4L,7L,0L,6L,1L,7L,6L,6L,0L,4L,7L,0L,7L,3L,8L,4L,5L,8L,1L,6L,4L,2L,5L,7L,7L,4L,2L,9L,7L,6L,4L,7L,9L,0L,9L,3L,7L,0L,2L,2L,5L,4L,1L,0L,9L,6L,0L,5L,9L,1L,2L,8L,3L,6L,7L,0L,6L,9L,3L,3L,6L,3L,2L,7L,8L,1L,3L,7L,7L,8L,9L,3L,8L,6L,6L,5L,6L,9L,8L,4L,6L };
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
public class A200289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200289Inst : IEnumerable<long>
{
public static readonly long[] Value=A200289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200289.Bytes);
public long this[int i]=>Value[i];

public static A200289Inst Instance=new A200289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200290
{
public static readonly long[] Value={ 8L,5L,4L,2L,5L,8L,4L,7L,7L,2L,9L,9L,7L,1L,2L,1L,4L,7L,8L,6L,6L,9L,4L,7L,0L,3L,2L,6L,3L,5L,3L,6L,1L,9L,3L,4L,5L,7L,3L,3L,8L,4L,5L,6L,4L,5L,1L,7L,7L,6L,5L,6L,6L,2L,4L,5L,3L,7L,3L,3L,9L,0L,9L,0L,1L,2L,0L,7L,1L,3L,2L,0L,1L,9L,3L,6L,7L,7L,4L,3L,8L,2L,1L,1L,1L,9L,5L,1L,5L,5L,5L,7L,3L,9L,9L,9L,0L,1L,4L };
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
public class A200290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200290Inst : IEnumerable<long>
{
public static readonly long[] Value=A200290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200290.Bytes);
public long this[int i]=>Value[i];

public static A200290Inst Instance=new A200290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200291
{
public static readonly long[] Value={ 2L,0L,4L,4L,2L,5L,5L,0L,1L,5L,3L,7L,7L,8L,0L,7L,1L,3L,1L,3L,6L,4L,9L,2L,9L,3L,9L,8L,7L,9L,7L,9L,5L,5L,2L,5L,2L,4L,5L,8L,6L,8L,5L,1L,0L,3L,1L,2L,4L,5L,4L,0L,5L,4L,4L,6L,4L,0L,5L,5L,3L,1L,6L,6L,9L,9L,0L,1L,8L,8L,2L,2L,8L,9L,3L,8L,5L,8L,2L,1L,8L,9L,8L,6L,8L,7L,3L,2L,9L,6L,3L,6L,5L,1L,7L,0L,3L,1L,8L };
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
public class A200291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200291Inst : IEnumerable<long>
{
public static readonly long[] Value=A200291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200291.Bytes);
public long this[int i]=>Value[i];

public static A200291Inst Instance=new A200291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200292
{
public static readonly long[] Value={ 9L,8L,5L,7L,7L,6L,3L,8L,1L,7L,0L,3L,9L,0L,0L,4L,5L,5L,0L,3L,0L,7L,9L,4L,0L,5L,3L,8L,7L,9L,8L,1L,9L,7L,0L,2L,6L,4L,6L,4L,5L,4L,7L,6L,8L,0L,5L,5L,7L,6L,8L,2L,0L,7L,6L,9L,5L,1L,3L,0L,6L,1L,3L,2L,4L,7L,8L,8L,7L,1L,1L,4L,4L,3L,5L,5L,7L,6L,3L,0L,7L,3L,6L,6L,1L,0L,7L,1L,6L,8L,3L,1L,1L,7L,4L,8L,2L,1L,5L };
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
public class A200292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200292Inst : IEnumerable<long>
{
public static readonly long[] Value=A200292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200292.Bytes);
public long this[int i]=>Value[i];

public static A200292Inst Instance=new A200292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200293
{
public static readonly long[] Value={ 5L,4L,5L,5L,9L,7L,3L,8L,8L,4L,8L,1L,4L,7L,5L,7L,3L,9L,5L,0L,4L,2L,1L,4L,8L,8L,4L,7L,8L,5L,7L,7L,0L,8L,2L,9L,5L,6L,7L,1L,6L,1L,0L,9L,4L,3L,0L,5L,0L,7L,0L,8L,5L,7L,7L,6L,2L,5L,1L,5L,3L,7L,5L,2L,4L,9L,3L,9L,3L,1L,6L,9L,6L,6L,6L,8L,7L,1L,7L,6L,5L,7L,1L,8L,2L,1L,1L,6L,7L,3L,3L,3L,3L,5L,7L,9L,4L,4L,5L };
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
public class A200293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200293Inst : IEnumerable<long>
{
public static readonly long[] Value=A200293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200293.Bytes);
public long this[int i]=>Value[i];

public static A200293Inst Instance=new A200293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200294
{
public static readonly long[] Value={ 7L,3L,3L,9L,7L,2L,6L,2L,7L,9L,4L,0L,2L,8L,9L,6L,1L,4L,3L,3L,4L,5L,0L,5L,0L,5L,6L,0L,0L,3L,9L,2L,9L,9L,2L,2L,0L,8L,5L,4L,5L,1L,3L,5L,6L,9L,6L,3L,5L,3L,9L,8L,1L,5L,0L,7L,6L,2L,5L,5L,4L,7L,2L,6L,5L,7L,2L,8L,2L,7L,5L,2L,5L,7L,8L,5L,8L,9L,3L,8L,3L,1L,7L,1L,7L,4L,0L,3L,8L,2L,6L,2L,1L,8L,4L,2L,6L,9L,5L };
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
public class A200294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200294Inst : IEnumerable<long>
{
public static readonly long[] Value=A200294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200294.Bytes);
public long this[int i]=>Value[i];

public static A200294Inst Instance=new A200294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200295
{
public static readonly long[] Value={ 4L,0L,5L,0L,0L,7L,1L,4L,9L,6L,7L,3L,3L,0L,6L,8L,1L,3L,5L,3L,0L,1L,0L,1L,2L,5L,6L,3L,6L,7L,3L,0L,1L,2L,9L,4L,7L,4L,7L,4L,6L,9L,7L,5L,9L,6L,2L,6L,2L,8L,2L,3L,1L,1L,5L,4L,6L,1L,0L,3L,4L,9L,1L,3L,8L,3L,3L,9L,0L,8L,0L,9L,3L,5L,8L,3L,8L,0L,4L,1L,8L,0L,5L,9L,0L,0L,8L,1L,2L,7L,9L,6L,0L,9L,3L,2L,7L,2L,3L };
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
public class A200295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200295Inst : IEnumerable<long>
{
public static readonly long[] Value=A200295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200295.Bytes);
public long this[int i]=>Value[i];

public static A200295Inst Instance=new A200295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200296
{
public static readonly long[] Value={ 9L,4L,9L,1L,4L,5L,7L,1L,9L,4L,2L,3L,0L,0L,9L,8L,4L,4L,8L,1L,8L,9L,1L,9L,6L,7L,0L,8L,5L,7L,2L,5L,6L,6L,1L,0L,8L,7L,9L,0L,6L,6L,3L,3L,3L,0L,0L,2L,9L,8L,9L,2L,3L,1L,7L,5L,6L,2L,8L,7L,1L,6L,4L,0L,4L,2L,2L,9L,8L,6L,6L,4L,6L,6L,4L,9L,9L,0L,2L,8L,0L,0L,7L,2L,8L,4L,5L,1L,8L,0L,1L,9L,4L,7L,2L,4L,3L,7L,8L };
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
public class A200296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200296Inst : IEnumerable<long>
{
public static readonly long[] Value=A200296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200296.Bytes);
public long this[int i]=>Value[i];

public static A200296Inst Instance=new A200296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200297
{
public static readonly long[] Value={ 5L,8L,8L,4L,7L,0L,8L,6L,9L,2L,8L,6L,8L,5L,2L,6L,1L,6L,4L,9L,9L,7L,9L,8L,6L,4L,8L,5L,6L,0L,3L,6L,6L,1L,8L,8L,2L,9L,8L,3L,2L,9L,5L,4L,3L,1L,0L,7L,1L,1L,9L,3L,6L,5L,0L,0L,9L,1L,7L,5L,7L,7L,4L,4L,8L,9L,7L,9L,1L,0L,8L,7L,6L,1L,0L,5L,0L,6L,5L,4L,1L,1L,8L,9L,1L,8L,1L,9L,7L,5L,0L,0L,7L,4L,4L,7L,5L,3L,6L };
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
public class A200297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200297Inst : IEnumerable<long>
{
public static readonly long[] Value=A200297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200297.Bytes);
public long this[int i]=>Value[i];

public static A200297Inst Instance=new A200297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200298
{
public static readonly long[] Value={ 9L,2L,2L,6L,9L,7L,3L,3L,6L,5L,4L,8L,3L,1L,4L,7L,9L,4L,6L,0L,3L,9L,0L,6L,5L,5L,1L,7L,9L,1L,5L,6L,2L,3L,6L,8L,8L,9L,4L,9L,0L,9L,0L,4L,9L,0L,7L,7L,2L,5L,7L,0L,5L,8L,6L,7L,3L,2L,2L,9L,0L,3L,3L,1L,1L,2L,1L,4L,2L,4L,9L,0L,9L,0L,3L,3L,9L,7L,3L,4L,8L,4L,2L,3L,0L,2L,3L,5L,1L,4L,5L,3L,8L,5L,5L,6L,8L,7L,4L };
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
public class A200298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200298Inst : IEnumerable<long>
{
public static readonly long[] Value=A200298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200298.Bytes);
public long this[int i]=>Value[i];

public static A200298Inst Instance=new A200298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200299
{
public static readonly long[] Value={ 6L,6L,1L,8L,2L,6L,1L,4L,1L,1L,8L,8L,8L,5L,0L,9L,9L,3L,7L,4L,3L,0L,2L,6L,1L,2L,3L,3L,5L,7L,0L,9L,4L,9L,8L,9L,9L,7L,5L,1L,0L,6L,5L,0L,4L,6L,2L,1L,0L,8L,6L,4L,2L,4L,6L,4L,5L,8L,2L,2L,2L,9L,2L,0L,0L,8L,7L,1L,3L,6L,7L,6L,2L,5L,6L,7L,4L,1L,1L,2L,3L,6L,0L,8L,5L,7L,6L,5L,1L,0L,0L,8L,9L,0L,2L,7L,5L,3L,4L };
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
public class A200299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200299Inst : IEnumerable<long>
{
public static readonly long[] Value=A200299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200299.Bytes);
public long this[int i]=>Value[i];

public static A200299Inst Instance=new A200299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200300
{
public static readonly long[] Value={ 8L,3L,0L,8L,5L,0L,3L,2L,7L,6L,6L,0L,5L,4L,7L,4L,0L,2L,7L,6L,6L,6L,2L,0L,9L,9L,3L,5L,6L,6L,5L,9L,7L,2L,8L,9L,7L,8L,5L,3L,0L,3L,0L,1L,5L,7L,3L,0L,2L,8L,1L,4L,8L,0L,7L,4L,7L,1L,6L,5L,1L,2L,1L,8L,3L,5L,0L,0L,1L,8L,5L,4L,8L,1L,3L,3L,8L,1L,5L,2L,2L,3L,2L,5L,4L,0L,6L,8L,6L,3L,2L,0L,8L,3L,6L,2L,8L,0L,6L };
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
public class A200300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200300Inst : IEnumerable<long>
{
public static readonly long[] Value=A200300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200300.Bytes);
public long this[int i]=>Value[i];

public static A200300Inst Instance=new A200300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200301
{
public static readonly long[] Value={ 5L,2L,3L,7L,7L,4L,1L,5L,6L,7L,5L,3L,2L,5L,5L,7L,2L,1L,7L,1L,7L,8L,4L,0L,4L,9L,6L,7L,3L,9L,4L,4L,5L,2L,8L,5L,3L,9L,0L,6L,0L,2L,4L,7L,1L,1L,0L,3L,1L,6L,0L,9L,9L,7L,1L,6L,8L,4L,8L,7L,8L,1L,5L,3L,9L,7L,3L,9L,2L,9L,3L,2L,3L,9L,5L,9L,6L,2L,6L,5L,2L,2L,3L,5L,6L,8L,4L,2L,6L,0L,2L,5L,3L,5L,8L,7L,5L,3L,6L };
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
public class A200301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200301Inst : IEnumerable<long>
{
public static readonly long[] Value=A200301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200301.Bytes);
public long this[int i]=>Value[i];

public static A200301Inst Instance=new A200301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200302
{
public static readonly long[] Value={ 1L,0L,1L,6L,1L,4L,3L,9L,5L,6L,7L,2L,3L,5L,5L,8L,7L,3L,3L,7L,9L,9L,4L,5L,5L,9L,0L,1L,2L,9L,6L,8L,6L,4L,7L,4L,6L,8L,7L,7L,9L,9L,4L,9L,2L,5L,9L,9L,2L,1L,9L,8L,1L,9L,8L,1L,9L,0L,3L,6L,6L,3L,3L,4L,1L,4L,8L,1L,0L,7L,6L,3L,7L,0L,8L,3L,4L,4L,0L,9L,5L,0L,4L,4L,0L,1L,3L,4L,3L,9L,8L,5L,6L,2L,0L,2L,9L,6L,9L };
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
public class A200302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200302Inst : IEnumerable<long>
{
public static readonly long[] Value=A200302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200302.Bytes);
public long this[int i]=>Value[i];

public static A200302Inst Instance=new A200302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200303
{
public static readonly long[] Value={ 4L,6L,7L,6L,4L,3L,6L,3L,2L,2L,2L,9L,0L,5L,6L,5L,3L,4L,2L,0L,3L,5L,4L,0L,0L,4L,9L,4L,7L,7L,1L,6L,5L,0L,1L,3L,9L,2L,4L,1L,6L,9L,8L,1L,7L,2L,2L,4L,0L,2L,6L,3L,5L,7L,1L,6L,8L,7L,3L,2L,8L,1L,2L,7L,5L,7L,8L,8L,0L,9L,5L,9L,8L,2L,5L,0L,6L,1L,3L,9L,9L,5L,1L,3L,0L,2L,3L,8L,8L,9L,3L,3L,8L,9L,3L,9L,4L,0L,3L };
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
public class A200303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200303Inst : IEnumerable<long>
{
public static readonly long[] Value=A200303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200303.Bytes);
public long this[int i]=>Value[i];

public static A200303Inst Instance=new A200303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200304
{
public static readonly long[] Value={ 1L,1L,0L,8L,8L,1L,1L,8L,8L,2L,9L,7L,1L,7L,2L,7L,6L,2L,1L,8L,5L,8L,4L,9L,5L,3L,5L,2L,2L,8L,5L,8L,9L,1L,7L,2L,5L,5L,4L,0L,0L,8L,9L,9L,4L,0L,1L,9L,4L,8L,5L,0L,6L,8L,1L,9L,7L,6L,4L,9L,9L,3L,1L,5L,7L,1L,7L,8L,4L,8L,7L,1L,3L,8L,8L,5L,5L,5L,9L,5L,8L,9L,9L,7L,8L,4L,3L,9L,2L,3L,8L,0L,5L,3L,6L,3L,5L,7L,8L };
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
public class A200304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200304Inst : IEnumerable<long>
{
public static readonly long[] Value=A200304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200304.Bytes);
public long this[int i]=>Value[i];

public static A200304Inst Instance=new A200304Inst();

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