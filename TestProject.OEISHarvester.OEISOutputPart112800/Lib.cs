using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A238305
{
public static readonly long[] Value={ 2L,3L,3L,6L,4L,5L,14L,6L,5L,8L,27L,12L,6L,7L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238305Inst : IEnumerable<long>
{
public static readonly long[] Value=A238305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238305.Bytes);
public long this[int i]=>Value[i];

public static A238305Inst Instance=new A238305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238306
{
public static readonly long[] Value={ 256L,1776L,12372L,85984L,601408L,4181152L,29228452L,203246304L,1421071696L,9880770000L,69080413972L,480334502816L,3358287402480L,23350820066560L,163257404108900L,1135164126221856L,7936527281285216L,55184332702741168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238306Inst : IEnumerable<long>
{
public static readonly long[] Value=A238306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238306.Bytes);
public long this[int i]=>Value[i];

public static A238306Inst Instance=new A238306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238307
{
public static readonly long[] Value={ 1776L,20128L,227622L,2570594L,29039618L,328887234L,3724943100L,42156330796L,477092412942L,5400733421386L,61135784139176L,691996650421482L,7832804389781870L,88662745929663094L,1003604775495708714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238307Inst : IEnumerable<long>
{
public static readonly long[] Value=A238307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238307.Bytes);
public long this[int i]=>Value[i];

public static A238307Inst Instance=new A238307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238308
{
public static readonly BigInteger[] Value={ 12372L,227622L,4124382L,73547936L,1325192097L,23867403810L,431525615512L,7754964008116L,140102741116287L,2519445217835664L,45526526723208179L,818530641216657186L,14790136479124024049UL,BigInteger.Parse("265931224012975513088") };
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
public class A238308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238308Inst Instance=new A238308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238309
{
public static readonly BigInteger[] Value={ 85984L,2570594L,73547936L,2095353404L,60499288444L,1753568482738L,50670612949420L,1462889957511854L,42268524829620522L,1221720186835881882L,BigInteger.Parse("35302852126473381534"),BigInteger.Parse("1020006715783080630310"),BigInteger.Parse("29473663465626905494444") };
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
public class A238309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238309.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238309Inst Instance=new A238309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238310
{
public static readonly BigInteger[] Value={ 601408L,29039618L,1325192097L,60499288444L,2819884806312L,130981062733326L,6096647460404574L,282303059762478196L,13149403998932705913UL,BigInteger.Parse("609400686942882785958"),BigInteger.Parse("28378549702218304554967"),BigInteger.Parse("1314847906734574524772824") };
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
public class A238310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238310.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238310Inst Instance=new A238310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238311
{
public static readonly long[] Value={ 256L,1776L,1776L,12372L,20128L,12372L,85984L,227622L,227622L,85984L,601408L,2570594L,4124382L,2570594L,601408L,4181152L,29039618L,73547936L,73547936L,29039618L,4181152L,29228452L,328887234L,1325192097L,2095353404L,1325192097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238311Inst : IEnumerable<long>
{
public static readonly long[] Value=A238311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238311.Bytes);
public long this[int i]=>Value[i];

public static A238311Inst Instance=new A238311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238312
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,11L,25L,41L,82L,142L,260L,436L,785L,1287L,2199L,3592L,5959L,9511L,15453L,24268L,38565L,59838L,93232L,142589L,219089L,330848L,500658L,748140L,1117856L,1651987L,2441484L,3572470L,5223653L,7576447L,10971112L,15775735L,22649645L,32307553L,46001087L,65138447L,92045412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238312Inst : IEnumerable<long>
{
public static readonly long[] Value=A238312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238312.Bytes);
public long this[int i]=>Value[i];

public static A238312Inst Instance=new A238312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238313
{
public static readonly long[] Value={ 1L,1L,0L,1L,3L,1L,3L,3L,10L,18L,12L,26L,39L,57L,59L,116L,201L,219L,325L,416L,625L,810L,1074L,1447L,2345L,3078L,3530L,5084L,6790L,9063L,11674L,15580L,20887L,27537L,33640L,45065L,61297L,76883L,96889L,126243L,169268L,210005L,262068L,337445L,438197L,552346L,686794L,865904L,1128611L,1407533L,1732572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238313Inst : IEnumerable<long>
{
public static readonly long[] Value=A238313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238313.Bytes);
public long this[int i]=>Value[i];

public static A238313Inst Instance=new A238313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238314
{
public static readonly long[] Value={ 1L,1L,3L,7L,33L,91L,388L,1163L,4231L,13297L,44694L,136621L,444535L,1335335L,4149785L,12327698L,37154245L,108185961L,318923590L,913506701L,2633793550L,7443298426L,21073435606L,58715695683L,163805615535L,450730653566L,1239947467778L,3374934052348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238314Inst : IEnumerable<long>
{
public static readonly long[] Value=A238314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238314.Bytes);
public long this[int i]=>Value[i];

public static A238314Inst Instance=new A238314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238315
{
public static readonly long[] Value={ 1L,4L,5L,14L,13L,42L,29L,134L,69L,474L,197L,1798L,669L,7050L,2509L,28006L,9813L,111770L,38965L,446758L,155501L,1786634L,621565L,7146054L,2485733L,28583642L,9942309L,114333894L,39768509L,457334794L,159073197L,1829338278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238315Inst : IEnumerable<long>
{
public static readonly long[] Value=A238315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238315.Bytes);
public long this[int i]=>Value[i];

public static A238315Inst Instance=new A238315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238316
{
public static readonly BigInteger[] Value={ 3L,67L,4294L,721939L,459256128L,1266938409578L,13394202897232848L,BigInteger.Parse("504070949140994691397") };
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
public class A238316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238316.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238316Inst Instance=new A238316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238317
{
public static readonly long[] Value={ 9L,67L,376L,1867L,9489L,50232L,267174L,1408341L,7395987L,38886701L,204722786L,1077853232L,5673085286L,29856142160L,157133586571L,827031030519L,4352855509300L,22909846720541L,120578232671314L,634623931681625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238317Inst : IEnumerable<long>
{
public static readonly long[] Value=A238317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238317.Bytes);
public long this[int i]=>Value[i];

public static A238317Inst Instance=new A238317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238318
{
public static readonly long[] Value={ 22L,376L,4294L,41046L,405636L,4245918L,44773061L,466364332L,4831077908L,50118953924L,520906788265L,5414918911420L,56265498867083L,584547225602293L,6073257215133643L,63102941239457036L,655660370108720902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238318Inst : IEnumerable<long>
{
public static readonly long[] Value=A238318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238318.Bytes);
public long this[int i]=>Value[i];

public static A238318Inst Instance=new A238318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238319
{
public static readonly BigInteger[] Value={ 51L,1867L,41046L,721939L,13265123L,261676376L,5206684654L,102053610873L,1987295524193L,38770223731701L,758012281434166L,14822685184195262L,289709710098420174L,5661329642092072222L,BigInteger.Parse("110637907561833470425") };
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
public class A238319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238319.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238319Inst Instance=new A238319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238352
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,1L,1L,4L,2L,3L,2L,3L,7L,0L,1L,3L,7L,5L,4L,14L,4L,5L,19L,3L,3L,8L,24L,9L,0L,1L,9L,32L,11L,4L,12L,46L,15L,4L,13L,60L,21L,7L,17L,85L,28L,1L,4L,22L,109L,28L,16L,0L,1L,28L,140L,51L,7L,5L,34L,179L,57L,26L,1L,42L,239L,74L,25L,5L,48L,300L,107L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238352Inst : IEnumerable<long>
{
public static readonly long[] Value=A238352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238352.Bytes);
public long this[int i]=>Value[i];

public static A238352Inst Instance=new A238352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238353
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,2L,1L,0L,0L,3L,1L,1L,0L,0L,2L,3L,1L,1L,0L,0L,4L,3L,2L,1L,1L,0L,0L,2L,6L,3L,2L,1L,1L,0L,0L,4L,6L,6L,2L,2L,1L,1L,0L,0L,3L,10L,6L,5L,2L,2L,1L,1L,0L,0L,4L,11L,11L,6L,4L,2L,2L,1L,1L,0L,0L,2L,16L,13L,10L,5L,4L,2L,2L,1L,1L,0L,0L,6L,17L,19L,12L,9L,4L,4L,2L,2L,1L,1L,0L,0L,2L,24L,24L,18L,11L,8L,4L,4L,2L,2L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238353Inst : IEnumerable<long>
{
public static readonly long[] Value=A238353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238353.Bytes);
public long this[int i]=>Value[i];

public static A238353Inst Instance=new A238353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238354
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,2L,1L,0L,0L,4L,0L,1L,0L,0L,5L,1L,0L,1L,0L,0L,8L,1L,1L,0L,1L,0L,0L,11L,2L,0L,1L,0L,1L,0L,0L,17L,2L,1L,0L,1L,0L,1L,0L,0L,23L,3L,1L,1L,0L,1L,0L,1L,0L,0L,33L,4L,2L,0L,1L,0L,1L,0L,1L,0L,0L,45L,5L,2L,1L,0L,1L,0L,1L,0L,1L,0L,0L,63L,6L,3L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,84L,8L,3L,2L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,114L,10L,4L,2L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238354Inst : IEnumerable<long>
{
public static readonly long[] Value=A238354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238354.Bytes);
public long this[int i]=>Value[i];

public static A238354Inst Instance=new A238354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238355
{
public static readonly BigInteger[] Value={ 59520825L,8608033980L,672868675017L,37680386599440L,1692352190653740L,64755027944420400L,2190839204960030106L,BigInteger.Parse("67194704604610557072"),BigInteger.Parse("1901727022434216910002"),BigInteger.Parse("50322107898515282999256"),BigInteger.Parse("1257582616997225194094310"),BigInteger.Parse("29916524874047762719113408"),BigInteger.Parse("681758763997451748190036272"),BigInteger.Parse("14960113428664295584816860864") };
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
public class A238355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238355Inst Instance=new A238355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238356
{
public static readonly BigInteger[] Value={ 24325703325L,4416286056750L,425671555397220L,28948474436455224L,1558252224413413380L,BigInteger.Parse("70639804918689629112"),BigInteger.Parse("2802850363447807024080"),BigInteger.Parse("99911395098598706576856"),BigInteger.Parse("3259947795252652107008514"),BigInteger.Parse("98729808377337068918681196"),BigInteger.Parse("2805432194025270702468165744") };
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
public class A238356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238356Inst Instance=new A238356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238357
{
public static readonly BigInteger[] Value={ 14230536445125L,3128879373858000L,360626952084151500L,BigInteger.Parse("29001816720933903504"),BigInteger.Parse("1828003659229082834100"),BigInteger.Parse("96187365300257285300064"),BigInteger.Parse("4395215998078319892167640"),BigInteger.Parse("179153431308203084149883760"),BigInteger.Parse("6641365771586560905099092466"),BigInteger.Parse("227189907562197156785567456832"),BigInteger.Parse("7252879937219595844346639732688") };
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
public class A238357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238357Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238357.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238357Inst Instance=new A238357Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238358
{
public static readonly BigInteger[] Value={ 11288163762500625L,2927974178219879250L,BigInteger.Parse("394372363395179602125"),BigInteger.Parse("36751560969705187643982"),BigInteger.Parse("2663973075006196131775590"),BigInteger.Parse("160098273686603663417293308"),BigInteger.Parse("8303278159618015743881266599"),BigInteger.Parse("381958851175370643701603049354"),BigInteger.Parse("15896435050196091382215375181044"),BigInteger.Parse("607566907750822335161584110201960") };
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
public class A238358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238358Inst Instance=new A238358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238359
{
public static readonly BigInteger[] Value={ 11665426077721040625UL,BigInteger.Parse("3498878057690404966500"),BigInteger.Parse("540996834819906946713375"),BigInteger.Parse("57494374008560749302297480"),BigInteger.Parse("4724172886681078698955547790"),BigInteger.Parse("320061005837218582787265273000"),BigInteger.Parse("18618409220753939214291224549409"),BigInteger.Parse("956146512935178711199035220384800"),BigInteger.Parse("44232688287025023758415781081779828"),BigInteger.Parse("1871678026675570344184400604255444240") };
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
public class A238359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238359Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238359.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238359Inst Instance=new A238359Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238360
{
public static readonly BigInteger[] Value={ BigInteger.Parse("15230046989184655753125"),BigInteger.Parse("5199629454143883380553750"),BigInteger.Parse("909887917857275652461097750"),BigInteger.Parse("108861830345440643086946970900"),BigInteger.Parse("10021124647635764856828690342402"),BigInteger.Parse("757187906770815991999545249667404"),BigInteger.Parse("48918614114003431712044170834572688"),BigInteger.Parse("2779227352989564224315657269511192976"),BigInteger.Parse("141720718575991991799057452443438430580") };
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
public class A238360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238360Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238360.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238360Inst Instance=new A238360Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238361
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,8L,18L,39L,81L,164L,326L,639L,1239L,2382L,4548L,8635L,16319L,30722L,57650L,107885L,201425L,375322L,698162L,1296801L,2405707L,4457984L,8253228L,15266969L,28220967L,52134000L,96257558L,177640983L,327696621L,604287700L,1113981922L,2053015399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238361Inst : IEnumerable<long>
{
public static readonly long[] Value=A238361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238361.Bytes);
public long this[int i]=>Value[i];

public static A238361Inst Instance=new A238361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238362
{
public static readonly long[] Value={ 3L,11L,19L,59L,67L,107L,131L,179L,211L,227L,283L,307L,331L,419L,563L,587L,659L,787L,1019L,1051L,1123L,1163L,1171L,1187L,1291L,1531L,1571L,1667L,1787L,1979L,2011L,2027L,2099L,2131L,2243L,2339L,2371L,2579L,2819L,2939L,3083L,3203L,3323L,3331L,3547L,3571L,3803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238362Inst : IEnumerable<long>
{
public static readonly long[] Value=A238362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238362.Bytes);
public long this[int i]=>Value[i];

public static A238362Inst Instance=new A238362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238363
{
public static readonly long[] Value={ 1L,-1L,2L,2L,-3L,3L,-6L,8L,-6L,4L,24L,-30L,20L,-10L,5L,-120L,144L,-90L,40L,-15L,6L,720L,-840L,504L,-210L,70L,-21L,7L,-5040L,5760L,-3360L,1344L,-420L,112L,-28L,8L,40320L,-45360L,25920L,-10080L,3024L,-756L,168L,-36L,9L,-362880L,403200L,-226800L,86400L,-25200L,6048L,-1260L,240L,-45L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238363Inst : IEnumerable<long>
{
public static readonly long[] Value=A238363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238363.Bytes);
public long this[int i]=>Value[i];

public static A238363Inst Instance=new A238363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238364
{
public static readonly long[] Value={ 1L,2L,5L,7L,8L,18L,22L,46L,47L,51L,77L,82L,96L,103L,117L,126L,135L,151L,152L,165L,208L,240L,266L,275L,305L,327L,366L,383L,400L,420L,436L,455L,460L,498L,516L,522L,530L,553L,582L,596L,602L,616L,712L,735L,791L,803L,817L,852L,876L,882L,883L,910L,912L,966L,975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238364Inst : IEnumerable<long>
{
public static readonly long[] Value=A238364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238364.Bytes);
public long this[int i]=>Value[i];

public static A238364Inst Instance=new A238364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238365
{
public static readonly long[] Value={ 2L,4L,6L,6L,4L,6L,8L,10L,6L,4L,6L,8L,10L,10L,8L,10L,12L,14L,10L,8L,10L,12L,14L,14L,12L,14L,16L,18L,14L,12L,14L,16L,18L,18L,16L,18L,20L,22L,18L,7L,9L,11L,13L,13L,11L,13L,15L,17L,13L,3L,5L,7L,9L,9L,7L,9L,11L,13L,9L,7L,9L,11L,13L,13L,11L,13L,15L,17L,13L,11L,13L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238365Inst : IEnumerable<long>
{
public static readonly long[] Value=A238365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238365.Bytes);
public long this[int i]=>Value[i];

public static A238365Inst Instance=new A238365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238366
{
public static readonly long[] Value={ 1L,2L,7L,12L,37L,62L,187L,312L,937L,1562L,4687L,7812L,23437L,39062L,117187L,195312L,585937L,976562L,2929687L,4882812L,14648437L,24414062L,73242187L,122070312L,366210937L,610351562L,1831054687L,3051757812L,9155273437L,15258789062L,45776367187L,76293945312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238366Inst : IEnumerable<long>
{
public static readonly long[] Value=A238366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238366.Bytes);
public long this[int i]=>Value[i];

public static A238366Inst Instance=new A238366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238367
{
public static readonly long[] Value={ 30L,42L,66L,70L,78L,90L,102L,110L,114L,126L,130L,138L,150L,154L,170L,174L,182L,186L,190L,198L,210L,222L,230L,234L,238L,246L,258L,266L,270L,282L,286L,290L,294L,306L,310L,318L,322L,330L,342L,350L,354L,366L,370L,374L,378L,390L,402L,406L,410L,414L,418L,420L,426L,430L,434L,438L,442L,450L,462L,470L,474L,490L,494L,498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238367Inst : IEnumerable<long>
{
public static readonly long[] Value=A238367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238367.Bytes);
public long this[int i]=>Value[i];

public static A238367Inst Instance=new A238367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238400
{
public static readonly long[] Value={ 2L,3L,7L,1237L,66067L,525593L,974167L,1412473L,2675759L,4471237L,5264333L,8107961L,8308271L,12615151L,20145407L,34926433L,43167569L,94772749L,104612297L,115103327L,144450221L,153124973L,165108557L,196634723L,211696049L,213507241L,255963131L,263979101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238400Inst : IEnumerable<long>
{
public static readonly long[] Value=A238400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238400.Bytes);
public long this[int i]=>Value[i];

public static A238400Inst Instance=new A238400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238401
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238401Inst : IEnumerable<long>
{
public static readonly long[] Value=A238401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238401.Bytes);
public long this[int i]=>Value[i];

public static A238401Inst Instance=new A238401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238402
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,2L,2L,1L,1L,4L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,4L,3L,3L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,5L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,2L,3L,3L,2L,2L,2L,3L,4L,3L,2L,2L,2L,3L,3L,2L,3L,4L,3L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,2L,2L,2L,2L,4L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238402Inst : IEnumerable<long>
{
public static readonly long[] Value=A238402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238402.Bytes);
public long this[int i]=>Value[i];

public static A238402Inst Instance=new A238402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238403
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238403Inst : IEnumerable<long>
{
public static readonly long[] Value=A238403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238403.Bytes);
public long this[int i]=>Value[i];

public static A238403Inst Instance=new A238403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238404
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,3L,4L,1L,2L,1L,1L,1L,1L,3L,2L,2L,1L,1L,8L,1L,1L,2L,3L,2L,1L,1L,3L,2L,1L,1L,3L,1L,5L,4L,3L,1L,3L,1L,1L,4L,1L,1L,3L,2L,4L,1L,1L,3L,1L,1L,2L,1L,3L,2L,2L,1L,1L,3L,2L,5L,1L,1L,7L,8L,1L,3L,4L,1L,6L,3L,2L,12L,1L,1L,1L,1L,5L,2L,1L,9L,1L,1L,1L,2L,1L,5L,1L,2L,1L,3L,3L,1L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238404Inst : IEnumerable<long>
{
public static readonly long[] Value=A238404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238404.Bytes);
public long this[int i]=>Value[i];

public static A238404Inst Instance=new A238404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238405
{
public static readonly long[] Value={ 0L,0L,2L,0L,1L,0L,1L,2L,3L,3L,2L,2L,1L,3L,3L,1L,2L,1L,2L,5L,3L,3L,4L,1L,2L,2L,3L,3L,1L,2L,3L,4L,5L,6L,5L,3L,2L,2L,3L,3L,2L,5L,5L,4L,3L,2L,4L,3L,2L,3L,3L,2L,4L,6L,4L,6L,9L,8L,6L,4L,3L,2L,3L,4L,5L,3L,5L,6L,5L,5L,1L,1L,3L,5L,4L,4L,9L,7L,6L,6L,4L,6L,3L,3L,5L,8L,8L,5L,4L,7L,8L,4L,5L,3L,2L,3L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238405Inst : IEnumerable<long>
{
public static readonly long[] Value=A238405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238405.Bytes);
public long this[int i]=>Value[i];

public static A238405Inst Instance=new A238405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238406
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,2L,0L,1L,2L,0L,1L,3L,0L,1L,3L,1L,0L,1L,4L,3L,0L,1L,4L,4L,0L,1L,5L,6L,0L,1L,5L,7L,0L,1L,6L,9L,1L,0L,1L,6L,11L,4L,0L,1L,7L,13L,7L,0L,1L,7L,15L,11L,0L,1L,8L,18L,15L,0L,1L,8L,20L,19L,0L,1L,9L,23L,25L,1L,0L,1L,9L,26L,30L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238406Inst : IEnumerable<long>
{
public static readonly long[] Value=A238406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238406.Bytes);
public long this[int i]=>Value[i];

public static A238406Inst Instance=new A238406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238407
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,3L,4L,5L,3L,5L,5L,5L,5L,4L,6L,5L,6L,4L,5L,6L,5L,4L,6L,5L,6L,5L,4L,4L,6L,5L,5L,6L,4L,6L,7L,6L,6L,5L,5L,7L,6L,6L,4L,6L,7L,5L,5L,6L,5L,6L,5L,6L,7L,4L,7L,7L,4L,5L,7L,7L,5L,6L,6L,5L,8L,5L,7L,7L,6L,6L,8L,6L,6L,6L,7L,6L,7L,6L,5L,7L,6L,7L,7L,7L,6L,5L,7L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238407Inst : IEnumerable<long>
{
public static readonly long[] Value=A238407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238407.Bytes);
public long this[int i]=>Value[i];

public static A238407Inst Instance=new A238407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238408
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238408Inst : IEnumerable<long>
{
public static readonly long[] Value=A238408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238408.Bytes);
public long this[int i]=>Value[i];

public static A238408Inst Instance=new A238408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238409
{
public static readonly long[] Value={ 16L,16L,24L,24L,10L,10L,32L,32L,32L,23L,23L,23L,40L,9L,23L,35L,9L,31L,31L,40L,35L,23L,48L,35L,48L,25L,31L,43L,40L,10L,48L,31L,39L,37L,23L,23L,43L,31L,35L,38L,25L,39L,56L,48L,43L,24L,30L,51L,39L,38L,10L,50L,56L,28L,31L,43L,31L,45L,37L,48L,50L,10L,51L,51L,23L,30L,56L,46L,31L,38L,38L,37L,64L,28L,47L,50L,39L,32L,64L,43L,48L,41L,47L,38L,51L,39L,24L,58L,42L,50L,56L,56L,39L,25L,51L,40L,64L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238409Inst : IEnumerable<long>
{
public static readonly long[] Value=A238409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238409.Bytes);
public long this[int i]=>Value[i];

public static A238409Inst Instance=new A238409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238410
{
public static readonly long[] Value={ 0L,2L,6L,14L,24L,38L,54L,74L,96L,122L,150L,182L,216L,254L,294L,338L,384L,434L,486L,542L,600L,662L,726L,794L,864L,938L,1014L,1094L,1176L,1262L,1350L,1442L,1536L,1634L,1734L,1838L,1944L,2054L,2166L,2282L,2400L,2522L,2646L,2774L,2904L,3038L,3174L,3314L,3456L,3602L,3750L,3902L,4056L,4214L,4374L,4538L,4704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238410Inst : IEnumerable<long>
{
public static readonly long[] Value=A238410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238410.Bytes);
public long this[int i]=>Value[i];

public static A238410Inst Instance=new A238410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238411
{
public static readonly long[] Value={ 0L,4L,6L,16L,20L,36L,42L,64L,72L,100L,110L,144L,156L,196L,210L,256L,272L,324L,342L,400L,420L,484L,506L,576L,600L,676L,702L,784L,812L,900L,930L,1024L,1056L,1156L,1190L,1296L,1332L,1444L,1482L,1600L,1640L,1764L,1806L,1936L,1980L,2116L,2162L,2304L,2352L,2500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238411Inst : IEnumerable<long>
{
public static readonly long[] Value=A238411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238411.Bytes);
public long this[int i]=>Value[i];

public static A238411Inst Instance=new A238411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238412
{
public static readonly long[] Value={ 2L,9L,9L,36L,36L,64L,64L,144L,144L,144L,240L,240L,240L,576L,625L,240L,900L,625L,960L,960L,576L,900L,2250L,2304L,900L,3375L,1536L,960L,3600L,576L,7776L,2304L,960L,3840L,8100L,2250L,2250L,3600L,9000L,900L,5760L,1536L,3840L,13500L,3375L,3600L,27216L,6400L,14400L,3840L,5760L,7776L,29160L,9216L,14000L,9000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238412Inst : IEnumerable<long>
{
public static readonly long[] Value=A238412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238412.Bytes);
public long this[int i]=>Value[i];

public static A238412Inst Instance=new A238412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238413
{
public static readonly long[] Value={ 0L,2L,2L,2L,2L,6L,6L,2L,2L,2L,6L,6L,6L,2L,12L,6L,6L,12L,6L,6L,2L,6L,12L,2L,6L,6L,8L,6L,6L,2L,20L,2L,6L,6L,12L,12L,12L,6L,12L,6L,8L,8L,6L,6L,6L,6L,20L,10L,6L,6L,8L,20L,12L,2L,14L,12L,6L,6L,12L,12L,2L,8L,30L,6L,6L,12L,10L,6L,8L,12L,20L,8L,12L,6L,14L,6L,8L,6L,20L,12L,6L,6L,14L,6L,8L,6L,12L,20L,12L,10L,8L,2L,6L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238413Inst : IEnumerable<long>
{
public static readonly long[] Value=A238413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238413.Bytes);
public long this[int i]=>Value[i];

public static A238413Inst Instance=new A238413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238414
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,5L,3L,1L,1L,1L,10L,7L,3L,1L,1L,1L,17L,17L,7L,3L,1L,1L,1L,36L,38L,19L,7L,3L,1L,1L,1L,65L,93L,45L,19L,7L,3L,1L,1L,1L,134L,220L,118L,47L,19L,7L,3L,1L,1L,1L,264L,537L,296L,125L,47L,19L,7L,3L,1L,1L,1L,551L,1306L,775L,321L,127L,47L,19L,7L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238414Inst : IEnumerable<long>
{
public static readonly long[] Value=A238414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238414.Bytes);
public long this[int i]=>Value[i];

public static A238414Inst Instance=new A238414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238415
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,7L,3L,1L,11L,10L,1L,1L,17L,24L,5L,1L,25L,56L,22L,2L,1L,36L,114L,74L,10L,1L,50L,224L,219L,55L,2L,1L,70L,411L,576L,224L,19L,1L,94L,733L,1394L,807L,126L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238415Inst : IEnumerable<long>
{
public static readonly long[] Value=A238415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238415.Bytes);
public long this[int i]=>Value[i];

public static A238415Inst Instance=new A238415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238432
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,13L,22L,41L,74L,133L,233L,400L,714L,1209L,2091L,3591L,6089L,10316L,17477L,29413L,49515L,82474L,137659L,228461L,377936L,623710L,1025445L,1680418L,2746242L,4474654L,7270430L,11774128L,19020802L,30640812L,49222427L,78857338L,126033488L,200872080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238432Inst : IEnumerable<long>
{
public static readonly long[] Value=A238432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238432.Bytes);
public long this[int i]=>Value[i];

public static A238432Inst Instance=new A238432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238433
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,6L,8L,13L,12L,19L,23L,29L,35L,45L,52L,68L,80L,98L,111L,141L,163L,198L,230L,283L,320L,376L,443L,517L,585L,719L,799L,932L,1085L,1254L,1417L,1668L,1861L,2138L,2449L,2804L,3166L,3666L,4083L,4662L,5277L,5960L,6676L,7651L,8494L,9635L,10803L,12157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238433Inst : IEnumerable<long>
{
public static readonly long[] Value=A238433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238433.Bytes);
public long this[int i]=>Value[i];

public static A238433Inst Instance=new A238433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238434
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,4L,6L,9L,13L,19L,28L,42L,62L,91L,135L,200L,296L,438L,648L,960L,1421L,2103L,3114L,4611L,6827L,10107L,14964L,22157L,32806L,48572L,71917L,106483L,157661L,233436L,345632L,511755L,757720L,1121901L,1661122L,2459512L,3641632L,5391915L,7983443L,11820547L,17501885L,25913856L,38368900L,56810249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238434Inst : IEnumerable<long>
{
public static readonly long[] Value=A238434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238434.Bytes);
public long this[int i]=>Value[i];

public static A238434Inst Instance=new A238434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238435
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,34L,90L,241L,650L,1760L,4777L,12989L,35369L,96419L,263071L,718215L,1961708L,5359970L,14648860L,40043679L,109479810L,299356896L,818630450L,2238827146L,6123220904L,16747896604L,45809670800L,125304652189L,342758051845L,937597571659L,2564790809491L,7016051357877L,19192778123621L,52503269515758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238435Inst : IEnumerable<long>
{
public static readonly long[] Value=A238435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238435.Bytes);
public long this[int i]=>Value[i];

public static A238435Inst Instance=new A238435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238436
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,54L,131L,319L,773L,1876L,4570L,11153L,27230L,66494L,162420L,396856L,969918L,2370885L,5796072L,14170603L,34646935L,84714724L,207141788L,506510118L,1238559994L,3028671297L,7406137561L,18110681635L,44287420434L,108299872576L,264836004204L,647630466817L,1583719989406L,3872845689552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238436Inst : IEnumerable<long>
{
public static readonly long[] Value=A238436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238436.Bytes);
public long this[int i]=>Value[i];

public static A238436Inst Instance=new A238436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238437
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,26L,60L,140L,325L,758L,1764L,4110L,9573L,22302L,51953L,121035L,281967L,656894L,1530351L,3565236L,8305876L,19350101L,45079691L,105021642L,244667733L,569999699L,1327922000L,3093645310L,7207231567L,16790608551L,39116897242L,91130208230L,212305051009L,494604759540L,1152275309042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238437Inst : IEnumerable<long>
{
public static readonly long[] Value=A238437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238437.Bytes);
public long this[int i]=>Value[i];

public static A238437Inst Instance=new A238437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238438
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,50L,121L,297L,738L,1853L,4694L,11982L,30790L,79586L,206786L,539784L,1414905L,3722776L,9828501L,26028969L,69129150L,184076913L,491340306L,1314412198L,3523519135L,9463563168L,25462981484L,68626114915L,185246103584L,500779373140L,1355636896041L,3674558399538L,9972405246294L,27095580261125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238438Inst : IEnumerable<long>
{
public static readonly long[] Value=A238438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238438.Bytes);
public long this[int i]=>Value[i];

public static A238438Inst Instance=new A238438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238439
{
public static readonly long[] Value={ 1L,2L,4L,10L,20L,42L,90L,182L,370L,748L,1526L,3060L,6156L,12344L,24748L,49654L,99392L,198966L,398166L,796658L,1593694L,3188584L,6377714L,12756888L,25515312L,51033092L,102068728L,204141754L,408292220L,816590586L,1633192578L,3266399030L,6532817194L,13065657556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238439Inst : IEnumerable<long>
{
public static readonly long[] Value=A238439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238439.Bytes);
public long this[int i]=>Value[i];

public static A238439Inst Instance=new A238439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238440
{
public static readonly long[] Value={ 1L,1L,3L,9L,27L,79L,229L,657L,1873L,5304L,14944L,41895L,116947L,325133L,900617L,2486183L,6841490L,18770754L,51358188L,140154540L,381540434L,1036261537L,2808328337L,7594958401L,20499680869L,55227373266L,148520150761L,398726637407L,1068701794158L,2859956501816L,7642086948143L,20391083977989L,54333644617311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238440Inst : IEnumerable<long>
{
public static readonly long[] Value=A238440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238440.Bytes);
public long this[int i]=>Value[i];

public static A238440Inst Instance=new A238440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238441
{
public static readonly long[] Value={ 1L,1L,3L,7L,16L,36L,79L,171L,367L,776L,1625L,3379L,6969L,14262L,29001L,58644L,117951L,235994L,469904L,931642L,1839708L,3618893L,7092676L,13853271L,26970933L,52350092L,101316743L,195544281L,376411466L,722747148L,1384416306L,2645765058L,5045240163L,9600533209L,18231674112L,34554871809L,65369632350L,123440337791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238441Inst : IEnumerable<long>
{
public static readonly long[] Value=A238441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238441.Bytes);
public long this[int i]=>Value[i];

public static A238441Inst Instance=new A238441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238442
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,4L,3L,7L,4L,-5L,6L,7L,-1L,12L,6L,-3L,-7L,8L,12L,-4L,-1L,15L,8L,-7L,-3L,13L,15L,-6L,-4L,18L,13L,-12L,-7L,12L,18L,-8L,-6L,12L,28L,12L,-15L,-12L,1L,14L,28L,-13L,-8L,3L,24L,14L,-18L,-15L,4L,15L,24L,24L,-12L,-13L,7L,1L,31L,24L,-28L,-18L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238442Inst : IEnumerable<long>
{
public static readonly long[] Value=A238442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238442.Bytes);
public long this[int i]=>Value[i];

public static A238442Inst Instance=new A238442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238443
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,18L,20L,24L,28L,30L,32L,36L,40L,42L,48L,54L,56L,60L,64L,66L,72L,80L,84L,88L,90L,96L,100L,104L,108L,112L,120L,126L,128L,132L,140L,144L,150L,156L,160L,162L,168L,176L,180L,192L,196L,198L,200L,204L,208L,210L,216L,220L,224L,228L,234L,240L,252L,256L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238443Inst : IEnumerable<long>
{
public static readonly long[] Value=A238443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238443.Bytes);
public long this[int i]=>Value[i];

public static A238443Inst Instance=new A238443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238444
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,2L,4L,3L,7L,4L,3L,2L,2L,3L,3L,4L,7L,8L,5L,9L,4L,5L,7L,4L,4L,2L,5L,3L,4L,2L,3L,3L,6L,5L,6L,3L,2L,3L,3L,2L,3L,2L,3L,4L,2L,7L,3L,3L,7L,2L,6L,5L,2L,5L,4L,3L,4L,5L,4L,2L,3L,6L,7L,7L,2L,4L,5L,2L,3L,2L,2L,7L,3L,2L,5L,5L,6L,6L,10L,2L,5L,2L,5L,2L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238444Inst : IEnumerable<long>
{
public static readonly long[] Value=A238444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238444.Bytes);
public long this[int i]=>Value[i];

public static A238444Inst Instance=new A238444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238445
{
public static readonly long[] Value={ 3L,13L,61L,103L,193L,199L,307L,431L,569L,977L,1201L,1451L,1481L,1609L,1669L,1889L,2371L,2381L,2711L,2819L,3083L,3469L,4289L,4337L,4567L,5231L,5501L,6733L,7043L,7253L,7351L,7549L,8707L,9257L,9497L,10039L,10687L,11491L,12227L,12517L,12941L,13397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238445Inst : IEnumerable<long>
{
public static readonly long[] Value=A238445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238445.Bytes);
public long this[int i]=>Value[i];

public static A238445Inst Instance=new A238445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238446
{
public static readonly long[] Value={ 0L,1L,3L,11L,103L,343L,4095L,14571L,190651L,9586983L,35791471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238446Inst : IEnumerable<long>
{
public static readonly long[] Value=A238446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238446.Bytes);
public long this[int i]=>Value[i];

public static A238446Inst Instance=new A238446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238447
{
public static readonly long[] Value={ 3L,487L,617L,677L,751L,1201L,1289L,1579L,1747L,2027L,2267L,2269L,2309L,3259L,3947L,4457L,4567L,4621L,4637L,4799L,4951L,5701L,6029L,6991L,7151L,7687L,7867L,9187L,9209L,9341L,9587L,9829L,11321L,12301L,12541L,12781L,13177L,13649L,15919L,16349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238447Inst : IEnumerable<long>
{
public static readonly long[] Value=A238447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238447.Bytes);
public long this[int i]=>Value[i];

public static A238447Inst Instance=new A238447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238464
{
public static readonly BigInteger[] Value={ 1L,7L,105L,2359L,70665L,2646007L,118893705L,6232661239L,373405001865L,25167452766967L,1884759251911305L,155262005162499319L,13952854271421949065UL,BigInteger.Parse("1358385484966283220727"),BigInteger.Parse("142418920493123648992905"),BigInteger.Parse("15998363870912950298468599") };
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
public class A238464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238464Inst Instance=new A238464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238465
{
public static readonly BigInteger[] Value={ 1L,8L,136L,3464L,117640L,4993928L,254396296L,15119104904L,1026912225160L,78468091562888L,6662087721342856L,622186077361470344L,BigInteger.Parse("63389713864392140680"),BigInteger.Parse("6996476832548305415048"),BigInteger.Parse("831619554631233264449416"),BigInteger.Parse("105909083171031626820475784") };
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
public class A238465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238465Inst Instance=new A238465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238466
{
public static readonly BigInteger[] Value={ 1L,9L,171L,4869L,184851L,8772309L,499559571L,33190014069L,2520110222451L,215270320769109L,20431783142389971L,2133148392099721269L,BigInteger.Parse("242954208655633344051"),BigInteger.Parse("29977118969127060357909"),BigInteger.Parse("3983272698956314883956371"),BigInteger.Parse("567091857051921058649396469") };
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
public class A238466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238466Inst Instance=new A238466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238467
{
public static readonly BigInteger[] Value={ 1L,10L,210L,6610L,277410L,14553010L,916146210L,67285818610L,5647734061410L,533307215001010L,55954905981282210L,6457903731351210610L,BigInteger.Parse("813080459351919805410"),BigInteger.Parse("110901542660769629769010"),BigInteger.Parse("16290196917457939734258210") };
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
public class A238467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238467.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238467Inst Instance=new A238467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238468
{
public static readonly long[] Value={ 0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238468Inst : IEnumerable<long>
{
public static readonly long[] Value=A238468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238468.Bytes);
public long this[int i]=>Value[i];

public static A238468Inst Instance=new A238468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238469
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238469Inst : IEnumerable<long>
{
public static readonly long[] Value=A238469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238469.Bytes);
public long this[int i]=>Value[i];

public static A238469Inst Instance=new A238469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238470
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238470Inst : IEnumerable<long>
{
public static readonly long[] Value=A238470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238470.Bytes);
public long this[int i]=>Value[i];

public static A238470Inst Instance=new A238470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238471
{
public static readonly long[] Value={ 3L,66L,364L,1197L,2990L,6293L,11781L,20254L,32637L,49980L,73458L,104371L,144144L,194327L,256595L,332748L,424711L,534534L,664392L,816585L,993538L,1197801L,1432049L,1699082L,2001825L,2343328L,2726766L,3155439L,3632772L,4162315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238471Inst : IEnumerable<long>
{
public static readonly long[] Value=A238471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238471.Bytes);
public long this[int i]=>Value[i];

public static A238471Inst Instance=new A238471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238472
{
public static readonly long[] Value={ 7L,99L,476L,1463L,3510L,7192L,13209L,22386L,35673L,54145L,79002L,111569L,153296L,205758L,270655L,349812L,445179L,558831L,692968L,849915L,1032122L,1242164L,1482741L,1756678L,2066925L,2416557L,2808774L,3246901L,3734388L,4274810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238472Inst : IEnumerable<long>
{
public static readonly long[] Value=A238472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238472.Bytes);
public long this[int i]=>Value[i];

public static A238472Inst Instance=new A238472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238473
{
public static readonly long[] Value={ 14L,143L,612L,1771L,4095L,8184L,14763L,24682L,38916L,58565L,84854L,119133L,162877L,217686L,285285L,367524L,466378L,583947L,722456L,884255L,1071819L,1287748L,1534767L,1815726L,2133600L,2491489L,2892618L,3340337L,3838121L,4389570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238473Inst : IEnumerable<long>
{
public static readonly long[] Value=A238473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238473.Bytes);
public long this[int i]=>Value[i];

public static A238473Inst Instance=new A238473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238474
{
public static readonly BigInteger[] Value={ 3L,-6L,20L,-90L,504L,-3360L,25920L,-226800L,2217600L,-23950080L,283046400L,-3632428800L,50295168000L,-747242496000L,11856247603200L,-200074178304000L,3577797070848000L,-67580611338240000L,1344498478202880000L,BigInteger.Parse("-28100018194440192000"),BigInteger.Parse("615524208068689920000") };
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
public class A238474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238474.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238474Inst Instance=new A238474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238475
{
public static readonly long[] Value={ 1L,9L,5L,17L,37L,21L,25L,69L,149L,85L,33L,101L,277L,597L,341L,41L,133L,405L,1109L,2389L,1365L,49L,165L,533L,1621L,4437L,9557L,5461L,57L,197L,661L,2133L,6485L,17749L,38229L,21845L,65L,229L,789L,2645L,8533L,25941L,70997L,152917L,87381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238475Inst : IEnumerable<long>
{
public static readonly long[] Value=A238475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238475.Bytes);
public long this[int i]=>Value[i];

public static A238475Inst Instance=new A238475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238476
{
public static readonly long[] Value={ 3L,7L,13L,11L,29L,53L,15L,45L,117L,213L,19L,61L,181L,469L,853L,23L,77L,245L,725L,1877L,3413L,27L,93L,309L,981L,2901L,7509L,13653L,31L,109L,373L,1237L,3925L,11605L,30037L,54613L,35L,125L,437L,1493L,4949L,15701L,46421L,120149L,218453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238476Inst : IEnumerable<long>
{
public static readonly long[] Value=A238476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238476.Bytes);
public long this[int i]=>Value[i];

public static A238476Inst Instance=new A238476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238477
{
public static readonly long[] Value={ 5L,37L,69L,101L,133L,165L,197L,229L,261L,293L,325L,357L,389L,421L,453L,485L,517L,549L,581L,613L,645L,677L,709L,741L,773L,805L,837L,869L,901L,933L,965L,997L,1029L,1061L,1093L,1125L,1157L,1189L,1221L,1253L,1285L,1317L,1349L,1381L,1413L,1445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238477Inst : IEnumerable<long>
{
public static readonly long[] Value=A238477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238477.Bytes);
public long this[int i]=>Value[i];

public static A238477Inst Instance=new A238477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238478
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,8L,11L,17L,22L,32L,43L,59L,78L,105L,136L,181L,233L,302L,386L,496L,626L,796L,999L,1255L,1564L,1951L,2412L,2988L,3674L,4516L,5524L,6753L,8211L,9984L,12086L,14617L,17617L,21211L,25450L,30514L,36475L,43550L,51869L,61707L,73230L,86821L,102706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238478Inst : IEnumerable<long>
{
public static readonly long[] Value=A238478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238478.Bytes);
public long this[int i]=>Value[i];

public static A238478Inst Instance=new A238478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238479
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,4L,5L,8L,10L,13L,18L,23L,30L,40L,50L,64L,83L,104L,131L,166L,206L,256L,320L,394L,485L,598L,730L,891L,1088L,1318L,1596L,1932L,2326L,2797L,3360L,4020L,4804L,5735L,6824L,8108L,9624L,11392L,13468L,15904L,18737L,22048L,25914L,30400L,35619L,41686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238479Inst : IEnumerable<long>
{
public static readonly long[] Value=A238479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238479.Bytes);
public long this[int i]=>Value[i];

public static A238479Inst Instance=new A238479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238512
{
public static readonly BigInteger[] Value={ 295L,14407L,2074468L,232354383L,27474561391L,3210307720768L,376089959883919L,44034161734024287L,5156342833939923172L,BigInteger.Parse("603784568551904193175"),BigInteger.Parse("70700880287741698132135"),BigInteger.Parse("8278793823713613200756352") };
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
public class A238512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238512Inst Instance=new A238512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238513
{
public static readonly BigInteger[] Value={ 3113L,430504L,232354383L,91551538363L,38584530824835L,16025158797901442L,6676837417903850862L,BigInteger.Parse("2779967978428715019918"),BigInteger.Parse("1157640782440254067428502"),BigInteger.Parse("482051808011508558973140217"),BigInteger.Parse("200732033232989734955553186668") };
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
public class A238513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238513Inst Instance=new A238513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238514
{
public static readonly BigInteger[] Value={ 33837L,13398587L,27474561391L,38584530824835L,58732288304220246L,BigInteger.Parse("87855481702558599272"),BigInteger.Parse("131915336663905670854072"),BigInteger.Parse("197910372702390304392047107"),BigInteger.Parse("296973810221639781308857250194") };
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
public class A238514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238514Inst Instance=new A238514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238515
{
public static readonly long[] Value={ 4L,25L,25L,295L,401L,295L,3113L,14407L,14407L,3113L,33837L,430504L,2074468L,430504L,33837L,365740L,13398587L,232354383L,232354383L,13398587L,365740L,3958594L,413256106L,27474561391L,91551538363L,27474561391L,413256106L,3958594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238515Inst : IEnumerable<long>
{
public static readonly long[] Value=A238515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238515.Bytes);
public long this[int i]=>Value[i];

public static A238515Inst Instance=new A238515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238516
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,3L,3L,4L,5L,5L,2L,4L,6L,5L,3L,3L,3L,4L,1L,7L,7L,2L,6L,3L,8L,7L,4L,1L,6L,3L,4L,5L,8L,4L,4L,2L,2L,4L,9L,7L,6L,3L,6L,4L,2L,6L,6L,3L,8L,5L,6L,4L,7L,7L,4L,8L,7L,9L,1L,6L,7L,7L,3L,3L,7L,2L,5L,4L,10L,8L,5L,1L,8L,9L,1L,4L,6L,7L,12L,3L,2L,4L,10L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238516Inst : IEnumerable<long>
{
public static readonly long[] Value=A238516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238516.Bytes);
public long this[int i]=>Value[i];

public static A238516Inst Instance=new A238516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238517
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,5L,6L,11L,14L,26L,34L,52L,79L,110L,162L,231L,328L,446L,660L,872L,1236L,1660L,2327L,3060L,4238L,5586L,7595L,9988L,13376L,17470L,23318L,30286L,39744L,51676L,67276L,86929L,112390L,144472L,185428L,237826L,303171L,386468L,490838L,622882L,786068L,995118L,1249838L,1573522L,1970542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238517Inst : IEnumerable<long>
{
public static readonly long[] Value=A238517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238517.Bytes);
public long this[int i]=>Value[i];

public static A238517Inst Instance=new A238517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238518
{
public static readonly long[] Value={ 84L,588L,7056L,74676L,812028L,8777664L,95006100L,1028017452L,11124397872L,120377861940L,1302620868444L,14095781346528L,152531780288916L,1650560738719116L,17860873095687888L,193274188450247604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238518Inst : IEnumerable<long>
{
public static readonly long[] Value=A238518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238518.Bytes);
public long this[int i]=>Value[i];

public static A238518Inst Instance=new A238518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238519
{
public static readonly BigInteger[] Value={ 588L,9612L,345744L,10332060L,321566028L,9918146448L,306521859084L,9468890997276L,292536258921504L,9037550907769116L,279205473387683676L,8625745262429841312L,BigInteger.Parse("266482953705659809356"),BigInteger.Parse("8232698585182917536556") };
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
public class A238519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238519Inst Instance=new A238519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238520
{
public static readonly BigInteger[] Value={ 7056L,345744L,49787136L,5576504976L,659389472784L,77047385296896L,9026159037210000L,1056819881616572304L,BigInteger.Parse("123752228014558128384"),BigInteger.Parse("14490829645245700563600"),BigInteger.Parse("1696821126905800754981136") };
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
public class A238520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238520Inst Instance=new A238520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238521
{
public static readonly BigInteger[] Value={ 74676L,10332060L,5576504976L,2197236920100L,926028739793772L,384603811149627048L,BigInteger.Parse("160244098029692394444"),BigInteger.Parse("66719231482289160388356"),BigInteger.Parse("27783378778566097617975744"),BigInteger.Parse("11569243392276205415354307780") };
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
public class A238521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238521Inst Instance=new A238521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238522
{
public static readonly BigInteger[] Value={ 812028L,321566028L,659389472784L,926028739793772L,1409574919301273724L,BigInteger.Parse("2108531560861406325624"),BigInteger.Parse("3165968079933736100217252"),BigInteger.Parse("4749848944857367305407776644"),BigInteger.Parse("7127371445319354751412567415840") };
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
public class A238522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238522Inst Instance=new A238522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238523
{
public static readonly long[] Value={ 84L,588L,588L,7056L,9612L,7056L,74676L,345744L,345744L,74676L,812028L,10332060L,49787136L,10332060L,812028L,8777664L,321566028L,5576504976L,5576504976L,321566028L,8777664L,95006100L,9918146448L,659389472784L,2197236920100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238523Inst : IEnumerable<long>
{
public static readonly long[] Value=A238523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238523.Bytes);
public long this[int i]=>Value[i];

public static A238523Inst Instance=new A238523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238524
{
public static readonly long[] Value={ 3L,5L,7L,9L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,33L,34L,35L,37L,38L,39L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,57L,58L,59L,61L,62L,63L,65L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238524Inst : IEnumerable<long>
{
public static readonly long[] Value=A238524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238524.Bytes);
public long this[int i]=>Value[i];

public static A238524Inst Instance=new A238524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238525
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,2L,3L,3L,0L,5L,0L,5L,7L,0L,0L,2L,0L,2L,1L,9L,0L,6L,5L,11L,0L,6L,0L,0L,0L,2L,5L,15L,11L,6L,0L,17L,7L,7L,0L,6L,0L,14L,1L,21L,0L,4L,7L,2L,11L,1L,0L,10L,7L,4L,13L,27L,0L,0L,0L,29L,11L,4L,11L,2L,0L,5L,17L,0L,0L,0L,0L,35L,10L,7L,5L,6L,0L,2L,9L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238525Inst : IEnumerable<long>
{
public static readonly long[] Value=A238525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238525.Bytes);
public long this[int i]=>Value[i];

public static A238525Inst Instance=new A238525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238526
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,9L,11L,15L,17L,21L,27L,29L,35L,39L,41L,45L,51L,57L,59L,65L,69L,71L,77L,81L,87L,95L,99L,101L,105L,107L,111L,125L,129L,135L,137L,147L,149L,155L,161L,165L,171L,177L,179L,189L,191L,195L,197L,209L,221L,225L,227L,231L,237L,239L,249L,255L,261L,267L,269L,275L,279L,281L,291L,305L,309L,311L,315L,329L,335L,345L,347L,351L,357L,365L,371L,377L,381L,387L,395L,399L,407L,417L,419L,429L,431L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238526Inst : IEnumerable<long>
{
public static readonly long[] Value=A238526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238526.Bytes);
public long this[int i]=>Value[i];

public static A238526Inst Instance=new A238526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238527
{
public static readonly long[] Value={ 2L,3L,3L,5L,5L,7L,2L,2L,5L,11L,2L,5L,11L,17L,7L,7L,7L,2L,11L,7L,13L,29L,11L,11L,2L,5L,17L,7L,5L,2L,19L,41L,23L,3L,11L,11L,23L,5L,2L,2L,2L,31L,7L,3L,17L,3L,23L,11L,59L,19L,5L,2L,37L,3L,41L,23L,71L,11L,2L,11L,47L,11L,29L,13L,13L,2L,31L,5L,5L,53L,17L,19L,13L,61L,23L,101L,19L,29L,41L,23L,107L,67L,11L,3L,3L,47L,73L,2L,3L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238527Inst : IEnumerable<long>
{
public static readonly long[] Value=A238527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238527.Bytes);
public long this[int i]=>Value[i];

public static A238527Inst Instance=new A238527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238560
{
public static readonly BigInteger[] Value={ 0L,1L,5L,75L,4410L,1366617L,2559274110L,31328639384771L,2625213100478051111L,BigInteger.Parse("1553872467564223628517240"),BigInteger.Parse("6655897240266476140036201639917"),BigInteger.Parse("210488414263886836416720847147423569801"),BigInteger.Parse("49987740079047684574220644720678455290986424137") };
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
public class A238560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238560.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238560Inst Instance=new A238560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238561
{
public static readonly BigInteger[] Value={ 0L,1L,9L,374L,123464L,393073019L,13515852419746L,5357744226076852121L,BigInteger.Parse("25600195480450832892945051"),BigInteger.Parse("1525225328241455762364837330772150"),BigInteger.Parse("1164060788951887659290296574533366111395142"),BigInteger.Parse("11633609031659470387047660421170953987903118055988725") };
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
public class A238561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238561.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238561Inst Instance=new A238561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238562
{
public static readonly BigInteger[] Value={ 0L,1L,13L,1365L,1736385L,33432635477L,10815459920194632L,BigInteger.Parse("62725487942251841319705"),BigInteger.Parse("6831392910998237157682785667015"),BigInteger.Parse("14474273684384810126076369987535894403747"),BigInteger.Parse("613458701796516369003780850311157775345255117642867") };
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
public class A238562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238562Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238562.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238562.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238562Inst Instance=new A238562Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238563
{
public static readonly BigInteger[] Value={ 0L,1L,19L,3997L,15292153L,1274403730688L,2561606354507677872L,BigInteger.Parse("132653831108423573746282961"),BigInteger.Parse("185588704806236441807500779350272919"),BigInteger.Parse("7271336250750488290453701705473754841288395525"),BigInteger.Parse("8205182525221704785195056768847594152799767482152756236799") };
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
public class A238563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238563.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238563Inst Instance=new A238563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238564
{
public static readonly BigInteger[] Value={ 0L,1L,25L,9976L,96721601L,27755132198233L,BigInteger.Parse("260988425663232777762"),BigInteger.Parse("85980297709044488588773397089"),BigInteger.Parse("1041234796567281969389323426605470061650"),BigInteger.Parse("480592801966130874383703685770422428530605893693255"),BigInteger.Parse("8695567207026865032892758221262809270061815825979643751114435291") };
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
public class A238564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238564Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238564.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238564.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238564Inst Instance=new A238564Inst();

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