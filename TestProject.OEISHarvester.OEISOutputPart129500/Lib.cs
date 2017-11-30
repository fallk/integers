using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A158805
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,3L,3L,3L,7L,7L,9L,3L,3L,3L,3L,9L,9L,3L,3L,3L,19L,13L,21L,6L,6L,6L,3L,9L,9L,3L,3L,3L,21L,21L,27L,3L,3L,3L,3L,9L,9L,9L,9L,9L,37L,25L,39L,3L,3L,3L,6L,18L,18L,3L,3L,3L,21L,21L,27L,9L,9L,9L,3L,9L,9L,3L,3L,3L,57L,39L,63L,6L,6L,6L,3L,9L,9L,10L,10L,10L,21L,21L,27L,3L,3L,3L,9L,27L,27L,3L,3L,3L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158805Inst : IEnumerable<long>
{
public static readonly long[] Value=A158805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158805.Bytes);
public long this[int i]=>Value[i];

public static A158805Inst Instance=new A158805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158806
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,7L,11L,12L,13L,14L,16L,20L,23L,24L,25L,27L,28L,30L,33L,34L,35L,37L,41L,42L,46L,47L,48L,49L,51L,52L,53L,55L,56L,58L,59L,62L,66L,67L,69L,72L,74L,75L,79L,84L,88L,89L,90L,91L,100L,101L,102L,103L,105L,107L,108L,110L,115L,116L,117L,118L,123L,124L,125L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158806Inst : IEnumerable<long>
{
public static readonly long[] Value=A158806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158806.Bytes);
public long this[int i]=>Value[i];

public static A158806Inst Instance=new A158806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158807
{
public static readonly BigInteger[] Value={ 1L,-7L,11L,28L,-1547L,-980L,133691L,81172L,-10955627L,-11878244L,4448226055L,2674671076L,-49823872362737L,-855605816468L,40888881655517L,368601472639540L,-1711418530905680779L,-205700802920736452L,BigInteger.Parse("1681258656184674505817"),BigInteger.Parse("144338957346266943364") };
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
public class A158807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158807Inst Instance=new A158807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158808
{
public static readonly long[] Value={ 1L,18L,162L,729L,65610L,59049L,7440174L,4782969L,430467210L,387420489L,76709256822L,31381059609L,257010878197710L,2541865828329L,45753584909922L,205891132094649L,315013432104812970L,16677181699666569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158808Inst : IEnumerable<long>
{
public static readonly long[] Value=A158808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158808.Bytes);
public long this[int i]=>Value[i];

public static A158808Inst Instance=new A158808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158809
{
public static readonly BigInteger[] Value={ 1L,-11L,47L,-55L,-1187L,935L,134447L,-81235L,-10954907L,11878163L,4448228035L,-2674671175L,-49823872264457L,855605816351L,40888881655769L,-368601472639675L,-1711418530905656299L,205700802920736299L,BigInteger.Parse("1681258656184674548909"),BigInteger.Parse("-144338957346266943535") };
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
public class A158809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158809Inst Instance=new A158809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158810
{
public static readonly long[] Value={ 0L,-1L,0L,-2L,-1L,-2L,3L,0L,0L,0L,-4L,-1L,0L,0L,-4L,5L,0L,-2L,0L,-4L,0L,6L,-1L,-2L,3L,-4L,5L,6L,-7L,0L,0L,0L,0L,0L,0L,0L,-8L,-1L,0L,0L,0L,0L,0L,0L,-8L,9L,0L,-2L,0L,0L,0L,0L,0L,-8L,0L,10L,-1L,-2L,3L,0L,0L,0L,0L,-8L,9L,10L,-11L,0L,0L,0L,-4L,0L,0L,0L,-8L,0L,0L,0L,12L,-1L,0L,0L,-4L,5L,0L,0L,-8L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158810Inst : IEnumerable<long>
{
public static readonly long[] Value=A158810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158810.Bytes);
public long this[int i]=>Value[i];

public static A158810Inst Instance=new A158810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158811
{
public static readonly BigInteger[] Value={ 1L,2L,-14L,-100L,556L,8312L,-33416L,-964528L,2281360L,143454752L,-82670816L,-25987196992L,-35605572416L,5542023405440L,19415750756224L,-1357758396658432L,-7957769497497344L,375118879242633728L,3185315224719454720L,BigInteger.Parse("-115167886425174418432"),BigInteger.Parse("-1319713579704402351104") };
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
public class A158811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158811.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158811Inst Instance=new A158811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158812
{
public static readonly long[] Value={ 7L,7L,7L,7L,7L,13L,7L,7L,13L,13L,7L,7L,17L,13L,7L,17L,7L,7L,19L,7L,13L,17L,13L,7L,7L,19L,7L,13L,17L,7L,7L,17L,23L,13L,19L,7L,13L,7L,19L,13L,7L,17L,7L,23L,7L,13L,17L,19L,7L,23L,7L,17L,7L,7L,13L,19L,7L,13L,17L,19L,7L,29L,23L,13L,7L,19L,29L,17L,7L,13L,7L,23L,13L,7L,31L,7L,23L,17L,19L,13L,17L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158812Inst : IEnumerable<long>
{
public static readonly long[] Value=A158812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158812.Bytes);
public long this[int i]=>Value[i];

public static A158812Inst Instance=new A158812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158813
{
public static readonly long[] Value={ 7L,13L,17L,19L,23L,13L,29L,31L,17L,19L,37L,41L,17L,23L,43L,19L,47L,7L,19L,53L,29L,23L,31L,59L,61L,23L,67L,37L,29L,71L,73L,31L,23L,41L,29L,79L,43L,83L,31L,47L,89L,37L,13L,29L,97L,53L,41L,37L,101L,31L,103L,43L,107L,109L,59L,41L,113L,61L,47L,43L,17L,29L,37L,67L,127L,47L,31L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158813Inst : IEnumerable<long>
{
public static readonly long[] Value=A158813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158813.Bytes);
public long this[int i]=>Value[i];

public static A158813Inst Instance=new A158813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158814
{
public static readonly long[] Value={ 10L,20L,30L,40L,50L,60L,70L,80L,90L,100L,110L,120L,130L,140L,150L,160L,170L,180L,190L,200L,210L,220L,230L,240L,250L,260L,270L,280L,290L,300L,310L,320L,330L,350L,340L,360L,370L,380L,390L,400L,410L,420L,430L,440L,450L,460L,470L,480L,490L,500L,510L,520L,530L,540L,550L,560L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158814Inst : IEnumerable<long>
{
public static readonly long[] Value=A158814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158814.Bytes);
public long this[int i]=>Value[i];

public static A158814Inst Instance=new A158814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158815
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,13L,5L,1L,1L,46L,16L,6L,1L,1L,166L,58L,19L,7L,1L,1L,610L,211L,71L,22L,8L,1L,1L,2269L,781L,261L,85L,25L,9L,1L,1L,8518L,2920L,976L,316L,100L,28L,10L,1L,1L,32206L,11006L,3676L,1196L,376L,116L,31L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158815Inst : IEnumerable<long>
{
public static readonly long[] Value=A158815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158815.Bytes);
public long this[int i]=>Value[i];

public static A158815Inst Instance=new A158815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158816
{
public static readonly BigInteger[] Value={ 7L,80929L,1390916281L,2475486361L,BigInteger.Parse("48009215293052652841860443273079338843737271906291675944391068955229998769420319"),BigInteger.Parse("626322472637042112379617556574437460372478130091490111806135154280070248067062629972139895896953692975358576879266688023648639640273675162065398163911") };
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
public class A158816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158816Inst Instance=new A158816Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158817
{
public static readonly BigInteger[] Value={ 1L,8L,800L,18783360L,28634752192836096L,BigInteger.Parse("187118328452563147377366903401859072"),BigInteger.Parse("22533823529098462258163079522899558155141642796614195116180863201125539840") };
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
public class A158817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158817.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158817Inst Instance=new A158817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158818
{
public static readonly BigInteger[] Value={ 176L,12310L,2012558L,679903203L,435157697830L,495741934760846L,958728697912338045L,BigInteger.Parse("3031941282464413132742"),BigInteger.Parse("15209368375944215483241988"),BigInteger.Parse("117991131259998859170817958839"),BigInteger.Parse("1385397746569649033264079085023363"),BigInteger.Parse("24166113822086183031380235679888630795") };
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
public class A158818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158818Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158818.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158818.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158818Inst Instance=new A158818Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158819
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,1L,2L,1L,1L,2L,2L,2L,2L,1L,1L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158819Inst : IEnumerable<long>
{
public static readonly long[] Value=A158819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158819.Bytes);
public long this[int i]=>Value[i];

public static A158819Inst Instance=new A158819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158820
{
public static readonly BigInteger[] Value={ 1L,-5L,-1L,35L,-227L,-1435L,27599L,123095L,-2428187L,-18154423L,1002748195L,4095412475L,-11278566075977L,-1310672758291L,9265563303353L,564709713458975L,-387913690488413419L,-315149059886480239L,BigInteger.Parse("381102197975912820173"),BigInteger.Parse("221139612243078051395") };
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
public class A158820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158820.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158820Inst Instance=new A158820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158821
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,3L,0L,0L,1L,4L,0L,0L,0L,1L,5L,0L,0L,0L,0L,1L,6L,0L,0L,0L,0L,0L,1L,7L,0L,0L,0L,0L,0L,0L,1L,8L,0L,0L,0L,0L,0L,0L,0L,1L,9L,0L,0L,0L,0L,0L,0L,0L,0L,1L,10L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158821Inst : IEnumerable<long>
{
public static readonly long[] Value=A158821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158821.Bytes);
public long this[int i]=>Value[i];

public static A158821Inst Instance=new A158821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158822
{
public static readonly long[] Value={ 1L,3L,1L,6L,3L,2L,10L,6L,5L,3L,15L,10L,9L,7L,4L,21L,15L,14L,12L,9L,5L,28L,21L,20L,18L,15L,11L,6L,36L,28L,27L,25L,22L,18L,13L,7L,45L,36L,35L,33L,30L,26L,21L,15L,8L,55L,45L,44L,42L,39L,35L,30L,24L,17L,9L,66L,55L,54L,52L,49L,45L,40L,34L,27L,19L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158822Inst : IEnumerable<long>
{
public static readonly long[] Value=A158822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158822.Bytes);
public long this[int i]=>Value[i];

public static A158822Inst Instance=new A158822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158823
{
public static readonly long[] Value={ 1L,3L,1L,6L,2L,2L,10L,3L,4L,3L,15L,4L,6L,6L,4L,21L,5L,8L,9L,8L,5L,28L,6L,10L,12L,12L,10L,6L,36L,7L,12L,15L,16L,15L,12L,7L,45L,8L,14L,18L,20L,20L,18L,14L,8L,55L,9L,16L,21L,24L,25L,24L,21L,16L,9L,66L,10L,18L,24L,28L,30L,30L,28L,24L,18L,10L,78L,11L,20L,27L,32L,35L,36L,35L,32L,27L,20L,11L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158823Inst : IEnumerable<long>
{
public static readonly long[] Value=A158823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158823.Bytes);
public long this[int i]=>Value[i];

public static A158823Inst Instance=new A158823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158824
{
public static readonly long[] Value={ 1L,4L,1L,10L,3L,2L,20L,6L,6L,3L,35L,10L,12L,9L,4L,56L,15L,20L,18L,12L,5L,84L,21L,30L,30L,24L,15L,6L,120L,28L,42L,42L,40L,30L,18L,7L,165L,36L,56L,63L,60L,50L,36L,21L,8L,220L,45L,72L,84L,84L,75L,60L,42L,24L,9L,286L,55L,90L,108L,112L,105L,90L,70L,48L,27L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158824Inst : IEnumerable<long>
{
public static readonly long[] Value=A158824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158824.Bytes);
public long this[int i]=>Value[i];

public static A158824Inst Instance=new A158824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158825
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,6L,5L,1L,4L,12L,21L,14L,1L,5L,20L,54L,80L,42L,1L,6L,30L,110L,260L,322L,132L,1L,7L,42L,195L,640L,1310L,1348L,429L,1L,8L,56L,315L,1330L,3870L,6824L,5814L,1430L,1L,9L,72L,476L,2464L,9380L,24084L,36478L,25674L,4862L,1L,10L,90L,684L,4200L,19852L,67844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158825Inst : IEnumerable<long>
{
public static readonly long[] Value=A158825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158825.Bytes);
public long this[int i]=>Value[i];

public static A158825Inst Instance=new A158825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158826
{
public static readonly long[] Value={ 1L,3L,12L,54L,260L,1310L,6824L,36478L,199094L,1105478L,6227712L,35520498L,204773400L,1191572004L,6990859416L,41313818217L,245735825082L,1470125583756L,8840948601024L,53417237877396L,324123222435804L,1974317194619712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158826Inst : IEnumerable<long>
{
public static readonly long[] Value=A158826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158826.Bytes);
public long this[int i]=>Value[i];

public static A158826Inst Instance=new A158826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158827
{
public static readonly long[] Value={ 1L,4L,20L,110L,640L,3870L,24084L,153306L,993978L,6544242L,43652340L,294469974L,2006018748L,13784115468L,95444016984L,665407010349L,4667570034444L,32922870719664L,233389493503968L,1662048903052380L,11885333877149532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158827Inst : IEnumerable<long>
{
public static readonly long[] Value=A158827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158827.Bytes);
public long this[int i]=>Value[i];

public static A158827Inst Instance=new A158827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158828
{
public static readonly long[] Value={ 1L,5L,30L,195L,1330L,9380L,67844L,500619L,3755156L,28558484L,219767968L,1708590960L,13403300208L,105983648060L,844009565176L,6764300053390L,54525119251104L,441811163402124L,3597005618194848L,29412560840221272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158828Inst : IEnumerable<long>
{
public static readonly long[] Value=A158828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158828.Bytes);
public long this[int i]=>Value[i];

public static A158828Inst Instance=new A158828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158829
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,202L,861L,3972L,19648L,103500L,577443L,3396804L,20988116L,135770140L,916936351L,6449233093L,47137434787L,357331341987L,2804582808108L,22754919576652L,190578011064394L,1645490708244886L,14629351150837605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158829Inst : IEnumerable<long>
{
public static readonly long[] Value=A158829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158829.Bytes);
public long this[int i]=>Value[i];

public static A158829Inst Instance=new A158829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158830
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,0L,5L,1L,0L,0L,14L,10L,0L,0L,0L,42L,70L,8L,0L,0L,0L,132L,424L,160L,4L,0L,0L,0L,429L,2382L,1978L,250L,1L,0L,0L,0L,1430L,12804L,19508L,6276L,302L,0L,0L,0L,0L,4862L,66946L,168608L,106492L,15674L,298L,0L,0L,0L,0L,16796L,343772L,1337684L,1445208L,451948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158830Inst : IEnumerable<long>
{
public static readonly long[] Value=A158830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158830.Bytes);
public long this[int i]=>Value[i];

public static A158830Inst Instance=new A158830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158831
{
public static readonly BigInteger[] Value={ 1L,1L,6L,54L,640L,9380L,163576L,3305484L,75915708L,1952409954L,55573310936L,1734182983962L,58863621238500L,2159006675844616L,85088103159523296L,3585740237981536700L,BigInteger.Parse("160894462797493581048"),BigInteger.Parse("7658326127259130753070") };
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
public class A158831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158831Inst Instance=new A158831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158832
{
public static readonly BigInteger[] Value={ 1L,2L,12L,110L,1330L,19852L,351792L,7209036L,167607066L,4357308098L,125219900520L,3941126688798L,134808743674176L,4979127855477336L,197480359402576304L,8370550907396970684L,BigInteger.Parse("377599345119560766534"),BigInteger.Parse("18061714498169627460982") };
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
public class A158832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158832Inst Instance=new A158832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158833
{
public static readonly BigInteger[] Value={ 1L,3L,20L,195L,2464L,38052L,693048L,14528217L,344320262L,9100230282L,265305808404L,8456446272144L,292528760419440L,10913859037065560L,436812586581170976L,BigInteger.Parse("18668379209883807385"),BigInteger.Parse("848499254768957476312") };
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
public class A158833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158833Inst Instance=new A158833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158834
{
public static readonly BigInteger[] Value={ 1L,4L,30L,315L,4200L,67620L,1273668L,27454218L,666200106L,17968302638L,533188477536L,17261808531552L,605452449574320L,22870569475477112L,925663441858807096L,BigInteger.Parse("39964465820186753753"),BigInteger.Parse("1833332492818402014474") };
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
public class A158834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158834Inst Instance=new A158834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158835
{
public static readonly long[] Value={ 1L,1L,1L,4L,2L,1L,27L,11L,3L,1L,254L,94L,21L,4L,1L,3062L,1072L,217L,34L,5L,1L,45052L,15212L,2904L,412L,50L,6L,1L,783151L,257777L,47337L,6325L,695L,69L,7L,1L,15712342L,5074738L,906557L,116372L,12035L,1082L,91L,8L,1L,357459042L,113775490L,19910808L,2483706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158835Inst : IEnumerable<long>
{
public static readonly long[] Value=A158835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158835.Bytes);
public long this[int i]=>Value[i];

public static A158835Inst Instance=new A158835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158836
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,254L,3062L,45052L,783151L,15712342L,357459042L,9094926988L,255939571048L,7893741230500L,264806871279676L,9600056691219936L,374033821840909263L,15586672520501193866UL,BigInteger.Parse("691789220336675178652") };
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
public class A158836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158836Inst Instance=new A158836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158837
{
public static readonly BigInteger[] Value={ 1L,2L,11L,94L,1072L,15212L,257777L,5074738L,113775490L,2861365660L,79763482974L,2440866020252L,81343355108428L,2932370770780016L,113695507437209845L,4717853729131352186L,BigInteger.Parse("208615291319607614600"),BigInteger.Parse("9792578421235713418464") };
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
public class A158837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158837.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158837Inst Instance=new A158837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158838
{
public static readonly BigInteger[] Value={ 1L,3L,21L,217L,2904L,47337L,906557L,19910808L,492818850L,13564326950L,410807572044L,13573135469214L,485765085176420L,18717987193565613L,772565258231236269L,BigInteger.Parse("34002334709760133807"),BigInteger.Parse("1589555183231724515700") };
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
public class A158838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158838.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158838Inst Instance=new A158838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158839
{
public static readonly BigInteger[] Value={ 1L,4L,34L,412L,6325L,116372L,2483706L,60168736L,1628677692L,48672911296L,1590752204044L,56418074957840L,2157411204773415L,88464995576660084L,3871611011946560294L,BigInteger.Parse("180101399407072883012"),BigInteger.Parse("8873328068327122625596") };
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
public class A158839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158839Inst Instance=new A158839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158840
{
public static readonly BigInteger[] Value={ 1L,2L,7L,42L,374L,4391L,63637L,1095362L,21823226L,493898216L,12515588806L,351062669154L,10798972965266L,361471373319171L,13080119556342713L,508813238759275712L,BigInteger.Parse("21174032937728251318"),BigInteger.Parse("938646693399848483498") };
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
public class A158840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158840Inst Instance=new A158840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158841
{
public static readonly long[] Value={ 1L,3L,1L,7L,4L,2L,13L,9L,6L,3L,21L,16L,12L,8L,4L,31L,25L,20L,15L,10L,5L,43L,36L,30L,24L,18L,12L,6L,57L,49L,42L,35L,28L,21L,14L,7L,73L,64L,56L,48L,40L,32L,24L,16L,8L,91L,81L,72L,63L,54L,45L,36L,27L,18L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158841Inst : IEnumerable<long>
{
public static readonly long[] Value=A158841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158841.Bytes);
public long this[int i]=>Value[i];

public static A158841Inst Instance=new A158841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158842
{
public static readonly long[] Value={ 1L,4L,13L,31L,61L,106L,169L,253L,361L,496L,661L,859L,1093L,1366L,1681L,2041L,2449L,2908L,3421L,3991L,4621L,5314L,6073L,6901L,7801L,8776L,9829L,10963L,12181L,13486L,14881L,16369L,17953L,19636L,21421L,23311L,25309L,27418L,29641L,31981L,34441L,37024L,39733L,42571L,45541L,48646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158842Inst : IEnumerable<long>
{
public static readonly long[] Value=A158842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158842.Bytes);
public long this[int i]=>Value[i];

public static A158842Inst Instance=new A158842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158843
{
public static readonly BigInteger[] Value={ 1L,2L,20L,952L,336112L,742166496L,10043945021760L,814531629739559808L,BigInteger.Parse("393150002983518264270592"),BigInteger.Parse("1123538097532735360702239462912"),BigInteger.Parse("18948231465474675384343860006353603584"),BigInteger.Parse("1881331085022567366434813565917484763975526400") };
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
public class A158843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158843Inst Instance=new A158843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158844
{
public static readonly long[] Value={ 20L,31L,35L,39L,44L,99L,135L,139L,155L,164L,200L,211L,271L,275L,284L,340L,359L,360L,404L,416L,424L,444L,484L,496L,511L,564L,596L,611L,640L,676L,724L,800L,836L,859L,860L,871L,876L,884L,919L,940L,944L,951L,971L,976L,995L,1000L,1004L,1064L,1116L,1131L,1144L,1159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158844Inst : IEnumerable<long>
{
public static readonly long[] Value=A158844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158844.Bytes);
public long this[int i]=>Value[i];

public static A158844Inst Instance=new A158844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158845
{
public static readonly long[] Value={ 2L,13L,17L,18L,21L,38L,41L,62L,66L,77L,97L,98L,106L,117L,118L,133L,146L,153L,157L,161L,178L,181L,197L,198L,202L,206L,217L,222L,226L,233L,237L,242L,257L,261L,266L,286L,297L,301L,302L,318L,321L,322L,338L,346L,362L,373L,377L,393L,402L,413L,421L,422L,453L,461L,462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158845Inst : IEnumerable<long>
{
public static readonly long[] Value=A158845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158845.Bytes);
public long this[int i]=>Value[i];

public static A158845Inst Instance=new A158845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158846
{
public static readonly long[] Value={ 19L,29L,41L,47L,53L,59L,61L,97L,149L,167L,173L,233L,239L,251L,271L,283L,313L,331L,349L,373L,409L,433L,439L,499L,509L,521L,557L,563L,593L,641L,677L,743L,761L,797L,827L,887L,911L,941L,953L,1013L,1019L,1021L,1039L,1051L,1129L,1171L,1237L,1279L,1291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158846Inst : IEnumerable<long>
{
public static readonly long[] Value=A158846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158846.Bytes);
public long this[int i]=>Value[i];

public static A158846Inst Instance=new A158846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158847
{
public static readonly long[] Value={ 41L,47L,53L,59L,61L,97L,109L,149L,167L,173L,227L,233L,239L,251L,271L,283L,313L,331L,349L,373L,409L,433L,439L,499L,509L,521L,557L,563L,593L,641L,677L,743L,761L,827L,887L,911L,941L,953L,1013L,1019L,1021L,1039L,1051L,1129L,1171L,1237L,1279L,1291L,1297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158847Inst : IEnumerable<long>
{
public static readonly long[] Value=A158847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158847.Bytes);
public long this[int i]=>Value[i];

public static A158847Inst Instance=new A158847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158848
{
public static readonly long[] Value={ 67L,97L,109L,149L,167L,173L,197L,227L,233L,239L,251L,271L,283L,313L,331L,349L,373L,409L,433L,439L,499L,509L,521L,557L,563L,593L,641L,677L,743L,761L,887L,911L,941L,953L,971L,977L,983L,1013L,1019L,1021L,1039L,1051L,1129L,1171L,1237L,1279L,1291L,1297L,1321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158848Inst : IEnumerable<long>
{
public static readonly long[] Value=A158848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158848.Bytes);
public long this[int i]=>Value[i];

public static A158848Inst Instance=new A158848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158849
{
public static readonly long[] Value={ 1L,22L,333L,4444L,55555L,666666L,7777777L,88888888L,999999999L,0L,11L,222L,3333L,44444L,555555L,6666666L,77777777L,888888888L,9999999999L,0L,111L,2222L,33333L,444444L,5555555L,66666666L,777777777L,8888888888L,99999999999L,0L,1111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158849Inst : IEnumerable<long>
{
public static readonly long[] Value=A158849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158849.Bytes);
public long this[int i]=>Value[i];

public static A158849Inst Instance=new A158849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158850
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,11L,12L,13L,14L,15L,16L,18L,19L,21L,23L,26L,27L,30L,33L,34L,36L,40L,41L,42L,43L,46L,47L,49L,51L,53L,56L,62L,64L,65L,67L,68L,69L,70L,76L,77L,79L,81L,84L,85L,86L,89L,90L,92L,93L,95L,96L,97L,98L,99L,102L,103L,106L,109L,110L,111L,112L,114L,117L,121L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158850Inst : IEnumerable<long>
{
public static readonly long[] Value=A158850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158850.Bytes);
public long this[int i]=>Value[i];

public static A158850Inst Instance=new A158850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158851
{
public static readonly long[] Value={ 1L,2L,2L,2L,0L,4L,4L,3L,0L,1L,0L,4L,0L,0L,8L,5L,0L,14L,0L,0L,0L,15L,0L,5L,0L,18L,0L,1L,0L,20L,16L,0L,0L,0L,0L,2L,0L,0L,0L,15L,0L,15L,0L,0L,0L,8L,0L,21L,0L,0L,0L,29L,0L,0L,0L,0L,0L,21L,0L,16L,0L,0L,32L,0L,0L,29L,0L,0L,0L,23L,0L,22L,0L,0L,0L,0L,0L,30L,0L,54L,0L,71L,0L,0L,0L,0L,0L,37L,0L,0L,0L,0L,0L,0L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158851Inst : IEnumerable<long>
{
public static readonly long[] Value=A158851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158851.Bytes);
public long this[int i]=>Value[i];

public static A158851Inst Instance=new A158851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158852
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,2L,2L,0L,1L,5L,0L,3L,5L,0L,7L,19L,0L,8L,10L,0L,21L,52L,0L,26L,43L,0L,66L,205L,0L,79L,92L,0L,217L,397L,0L,279L,444L,0L,683L,1651L,0L,625L,1009L,0L,2135L,4831L,0L,3063L,3682L,0L,6851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158852Inst : IEnumerable<long>
{
public static readonly long[] Value=A158852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158852.Bytes);
public long this[int i]=>Value[i];

public static A158852Inst Instance=new A158852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158853
{
public static readonly long[] Value={ 2L,0L,3L,1L,0L,1L,5L,0L,3L,6L,0L,7L,18L,0L,8L,10L,0L,21L,50L,0L,26L,43L,0L,67L,204L,0L,79L,93L,0L,213L,398L,0L,279L,445L,0L,684L,1649L,0L,630L,1008L,0L,2135L,4890L,0L,3063L,3681L,0L,6852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158853Inst : IEnumerable<long>
{
public static readonly long[] Value=A158853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158853.Bytes);
public long this[int i]=>Value[i];

public static A158853Inst Instance=new A158853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158854
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-2L,1L,1L,-1L,-1L,1L,1L,-2L,0L,2L,-1L,1L,-1L,-2L,2L,1L,-1L,1L,-2L,-1L,4L,-1L,-2L,1L,1L,-1L,-3L,3L,3L,-3L,-1L,1L,1L,-2L,-2L,6L,0L,-6L,2L,2L,-1L,1L,-1L,-4L,4L,6L,-6L,-4L,4L,1L,-1L,1L,-2L,-3L,8L,2L,-12L,2L,8L,-3L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158854Inst : IEnumerable<long>
{
public static readonly long[] Value=A158854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158854.Bytes);
public long this[int i]=>Value[i];

public static A158854Inst Instance=new A158854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158855
{
public static readonly long[] Value={ 2L,0L,2L,5L,0L,4L,6L,0L,7L,18L,0L,8L,10L,0L,23L,51L,0L,25L,43L,0L,68L,206L,0L,79L,93L,0L,214L,397L,0L,280L,445L,0L,684L,1650L,0L,630L,1008L,0L,2136L,4894L,0L,3065L,3682L,0L,6853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158855Inst : IEnumerable<long>
{
public static readonly long[] Value=A158855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158855.Bytes);
public long this[int i]=>Value[i];

public static A158855Inst Instance=new A158855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158856
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,-1L,0L,-1L,1L,0L,1L,0L,0L,-1L,0L,-1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158856Inst : IEnumerable<long>
{
public static readonly long[] Value=A158856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158856.Bytes);
public long this[int i]=>Value[i];

public static A158856Inst Instance=new A158856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158857
{
public static readonly long[] Value={ 7L,0L,7L,7L,0L,8L,20L,0L,9L,10L,0L,23L,50L,0L,28L,42L,0L,69L,201L,0L,79L,93L,0L,216L,399L,0L,278L,445L,0L,684L,1649L,0L,630L,1008L,0L,2132L,4892L,0L,3066L,3681L,0L,6852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158857Inst : IEnumerable<long>
{
public static readonly long[] Value=A158857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158857.Bytes);
public long this[int i]=>Value[i];

public static A158857Inst Instance=new A158857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158858
{
public static readonly long[] Value={ 3L,5L,1L,7L,2L,27L,9L,3L,54L,9L,11L,4L,81L,18L,243L,13L,5L,108L,27L,486L,81L,15L,6L,135L,36L,729L,162L,2187L,17L,7L,162L,45L,972L,243L,4374L,729L,19L,8L,189L,54L,1215L,324L,6561L,1458L,19683L,21L,9L,216L,63L,1458L,405L,8748L,2187L,39366L,6561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158858Inst : IEnumerable<long>
{
public static readonly long[] Value=A158858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158858.Bytes);
public long this[int i]=>Value[i];

public static A158858Inst Instance=new A158858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158859
{
public static readonly BigInteger[] Value={ 1L,333L,55555L,7777777L,999999999L,11111111111L,3333333333333L,555555555555555L,77777777777777777L,9999999999999999999UL,BigInteger.Parse("111111111111111111111"),BigInteger.Parse("33333333333333333333333") };
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
public class A158859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158859Inst Instance=new A158859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158860
{
public static readonly long[] Value={ 1L,4L,1L,7L,2L,1L,10L,3L,2L,1L,13L,4L,3L,2L,1L,16L,5L,4L,3L,2L,1L,19L,6L,5L,4L,3L,2L,1L,22L,7L,6L,5L,4L,3L,2L,1L,25L,8L,7L,6L,5L,4L,3L,2L,1L,28L,9L,8L,7L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158860Inst : IEnumerable<long>
{
public static readonly long[] Value=A158860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158860.Bytes);
public long this[int i]=>Value[i];

public static A158860Inst Instance=new A158860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158861
{
public static readonly long[] Value={ 2999L,8999L,101999L,164999L,179999L,230999L,272999L,293999L,326999L,389999L,410999L,419999L,443999L,512999L,524999L,536999L,659999L,662999L,773999L,788999L,794999L,800999L,818999L,890999L,920999L,932999L,989999L,1028999L,1058999L,1136999L,1187999L,1238999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158861Inst : IEnumerable<long>
{
public static readonly long[] Value=A158861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158861.Bytes);
public long this[int i]=>Value[i];

public static A158861Inst Instance=new A158861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158862
{
public static readonly long[] Value={ 22L,46L,61L,82L,106L,118L,181L,286L,301L,373L,406L,433L,481L,493L,526L,562L,577L,661L,733L,802L,817L,886L,946L,961L,1033L,1162L,1177L,1246L,1258L,1261L,1297L,1342L,1426L,1513L,1546L,1558L,1573L,1618L,1741L,1813L,1822L,1846L,1873L,1882L,1918L,1921L,1957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158862Inst : IEnumerable<long>
{
public static readonly long[] Value=A158862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158862.Bytes);
public long this[int i]=>Value[i];

public static A158862Inst Instance=new A158862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158863
{
public static readonly long[] Value={ 4L,8L,36L,32L,76L,72L,124L,128L,180L,200L,244L,288L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158863Inst : IEnumerable<long>
{
public static readonly long[] Value=A158863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158863.Bytes);
public long this[int i]=>Value[i];

public static A158863Inst Instance=new A158863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158864
{
public static readonly long[] Value={ 13L,37L,73L,118L,166L,217L,313L,433L,457L,493L,538L,541L,553L,601L,613L,637L,706L,826L,853L,898L,958L,1042L,1057L,1138L,1222L,1357L,1441L,1513L,1666L,1681L,1777L,1858L,1966L,1993L,2173L,2281L,2341L,2422L,2446L,2518L,2626L,2638L,2653L,2686L,2701L,2737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158864Inst : IEnumerable<long>
{
public static readonly long[] Value=A158864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158864.Bytes);
public long this[int i]=>Value[i];

public static A158864Inst Instance=new A158864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158865
{
public static readonly long[] Value={ 0L,8L,20L,36L,56L,80L,108L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158865Inst : IEnumerable<long>
{
public static readonly long[] Value=A158865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158865.Bytes);
public long this[int i]=>Value[i];

public static A158865Inst Instance=new A158865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158866
{
public static readonly long[] Value={ 2L,5L,30L,31L,66L,73L,88L,91L,141L,147L,217L,513L,607L,637L,743L,760L,784L,845L,856L,911L,920L,938L,949L,958L,994L,1015L,1031L,1092L,1150L,1246L,1373L,1470L,1553L,1586L,1768L,1814L,1871L,2017L,2029L,2129L,2261L,2271L,2331L,2370L,2458L,2488L,2510L,2545L,2579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158866Inst : IEnumerable<long>
{
public static readonly long[] Value=A158866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158866.Bytes);
public long this[int i]=>Value[i];

public static A158866Inst Instance=new A158866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158867
{
public static readonly long[] Value={ 1L,5L,4L,14L,14L,12L,126L,108L,108L,96L,594L,594L,528L,528L,480L,7722L,6864L,6864L,6240L,6240L,5760L,51480L,51480L,46800L,46800L,43200L,43200L,40320L,875160L,795600L,795600L,734400L,734400L,685440L,685440L,645120L,7558200L,7558200L,6976800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158867Inst : IEnumerable<long>
{
public static readonly long[] Value=A158867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158867.Bytes);
public long this[int i]=>Value[i];

public static A158867Inst Instance=new A158867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158868
{
public static readonly long[] Value={ 1L,5L,2L,14L,7L,6L,126L,54L,54L,24L,594L,297L,264L,132L,120L,7722L,3432L,3432L,1560L,1560L,720L,51480L,25740L,23400L,11700L,10800L,5400L,5040L,875160L,397800L,397800L,183600L,183600L,85680L,85680L,40320L,7558200L,3779100L,3488400L,1744200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158868Inst : IEnumerable<long>
{
public static readonly long[] Value=A158868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158868.Bytes);
public long this[int i]=>Value[i];

public static A158868Inst Instance=new A158868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158869
{
public static readonly long[] Value={ 1L,5L,27L,147L,801L,4365L,23787L,129627L,706401L,3849525L,20977947L,114319107L,622980801L,3394927485L,18500622507L,100818952587L,549411848001L,2994014230245L,16315849837467L,88913056334067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158869Inst : IEnumerable<long>
{
public static readonly long[] Value=A158869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158869.Bytes);
public long this[int i]=>Value[i];

public static A158869Inst Instance=new A158869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158870
{
public static readonly long[] Value={ 13L,61L,1321L,1621L,4261L,5101L,6661L,6781L,11701L,12541L,21061L,66361L,83221L,88261L,107101L,110881L,114661L,127681L,130201L,140761L,141961L,144541L,148201L,149521L,157561L,161341L,163861L,175081L,186481L,204601L,230941L,249541L,267961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158870Inst : IEnumerable<long>
{
public static readonly long[] Value=A158870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158870.Bytes);
public long this[int i]=>Value[i];

public static A158870Inst Instance=new A158870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158871
{
public static readonly long[] Value={ 1L,10L,12L,18L,20L,21L,22L,24L,26L,28L,30L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,50L,52L,54L,55L,56L,57L,58L,60L,63L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,82L,84L,85L,86L,87L,88L,90L,92L,93L,94L,96L,98L,99L,100L,102L,104L,105L,106L,108L,110L,111L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158871Inst : IEnumerable<long>
{
public static readonly long[] Value=A158871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158871.Bytes);
public long this[int i]=>Value[i];

public static A158871Inst Instance=new A158871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158872
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,20L,182L,6552L,1517473L,4654013540L,520378069012098L,BigInteger.Parse("10766981089503125653501"),BigInteger.Parse("448728931430680787386854758969563"),BigInteger.Parse("1010943666488949958707946804366787268947495194377") };
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
public class A158872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158872Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158872.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158872.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158872Inst Instance=new A158872Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158873
{
public static readonly BigInteger[] Value={ 1L,3L,10L,59L,796L,38106L,10575020L,37219912979L,4683360721197196L,BigInteger.Parse("107669805691203995115748"),BigInteger.Parse("4936018245619051863546606625582972"),BigInteger.Parse("12131323997867394119748184355028213021384527189930") };
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
public class A158873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158873Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158873.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158873.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158873Inst Instance=new A158873Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158874
{
public static readonly long[] Value={ 0L,24L,144L,504L,1344L,3024L,6048L,11088L,19008L,30888L,48048L,72072L,104832L,148512L,205632L,279072L,372096L,488376L,632016L,807576L,1020096L,1275120L,1578720L,1937520L,2358720L,2850120L,3420144L,4077864L,4833024L,5696064L,6678144L,7791168L,9047808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158874Inst : IEnumerable<long>
{
public static readonly long[] Value=A158874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158874.Bytes);
public long this[int i]=>Value[i];

public static A158874Inst Instance=new A158874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158875
{
public static readonly long[] Value={ 1L,5L,15L,45L,107L,265L,615L,1485L,3227L,7225L,15735L,35325L,75019L,163145L,348135L,761805L,1589147L,3374905L,7077495L,15138045L,31390219L,66122825L,137816295L,292344525L,601532059L,1253593145L,2591401335L,5435447805L,11157226763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158875Inst : IEnumerable<long>
{
public static readonly long[] Value=A158875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158875.Bytes);
public long this[int i]=>Value[i];

public static A158875Inst Instance=new A158875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158876
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,217L,4041L,113611L,4532683L,244208049L,17085010897L,1504881245971L,162835665686211L,21219897528855433L,3276502399914104089L,BigInteger.Parse("591351260856215820507"),BigInteger.Parse("123322423833602768272891"),BigInteger.Parse("29423834155886520870184801"),BigInteger.Parse("7963056392690313008566254753") };
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
public class A158876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158876Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158876.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158876.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158876Inst Instance=new A158876Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158877
{
public static readonly long[] Value={ 1012L,102L,13L,1031345242L,103524563142L,1042L,10467842L,105263157894736842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158877Inst : IEnumerable<long>
{
public static readonly long[] Value=A158877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158877.Bytes);
public long this[int i]=>Value[i];

public static A158877Inst Instance=new A158877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158878
{
public static readonly long[] Value={ 3L,5L,37L,41L,43L,59L,71L,113L,181L,293L,383L,421L,1109L,1187L,1997L,3109L,4889L,5581L,67961L,74843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158878Inst : IEnumerable<long>
{
public static readonly long[] Value=A158878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158878.Bytes);
public long this[int i]=>Value[i];

public static A158878Inst Instance=new A158878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158879
{
public static readonly long[] Value={ 1L,5L,18L,67L,260L,1029L,4102L,16391L,65544L,262153L,1048586L,4194315L,16777228L,67108877L,268435470L,1073741839L,4294967312L,17179869201L,68719476754L,274877906963L,1099511627796L,4398046511125L,17592186044438L,70368744177687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158879Inst : IEnumerable<long>
{
public static readonly long[] Value=A158879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158879.Bytes);
public long this[int i]=>Value[i];

public static A158879Inst Instance=new A158879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158880
{
public static readonly BigInteger[] Value={ 6L,8100L,7741440L,7138643400L,6551815840350L,6009209192448000L,5511006731579419434L,BigInteger.Parse("5054037303588059379600"),BigInteger.Parse("4634949992739663836897280"),BigInteger.Parse("4250612670512943969574312500"),BigInteger.Parse("3898145031429828405122837863554") };
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
public class A158880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158880Inst Instance=new A158880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158881
{
public static readonly BigInteger[] Value={ 1L,1L,9L,625L,274625L,671898241L,8458700490625L,520900360822838529L,BigInteger.Parse("151632993506657159886849"),BigInteger.Parse("203635581444958952230203985921"),BigInteger.Parse("1239028497632876493535705227172341761") };
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
public class A158881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158881Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158881.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158881.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158881Inst Instance=new A158881Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158882
{
public static readonly long[] Value={ 1L,1L,-1L,3L,-13L,71L,-461L,3447L,-29093L,273343L,-2829325L,31998903L,-392743957L,5201061455L,-73943424413L,1123596277863L,-18176728317413L,311951144828863L,-5661698774848621L,108355864447215063L,-2181096921557783605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158882Inst : IEnumerable<long>
{
public static readonly long[] Value=A158882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158882.Bytes);
public long this[int i]=>Value[i];

public static A158882Inst Instance=new A158882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158883
{
public static readonly long[] Value={ 1L,1L,-2L,9L,-56L,425L,-3726L,36652L,-397440L,4695489L,-59941550L,821711605L,-12037503384L,187689245588L,-3104186515976L,54295661153700L,-1001685184237056L,19444296845046033L,-396260414466644574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158883Inst : IEnumerable<long>
{
public static readonly long[] Value=A158883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158883.Bytes);
public long this[int i]=>Value[i];

public static A158883Inst Instance=new A158883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158884
{
public static readonly long[] Value={ 1L,1L,-1L,4L,-23L,166L,-1410L,13602L,-145803L,1711690L,-21785618L,298370920L,-4372151566L,68234087624L,-1129894265272L,19788479904366L,-365520041466291L,7103187300763530L,-144897616964143050L,3096285550330959336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158884Inst : IEnumerable<long>
{
public static readonly long[] Value=A158884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158884.Bytes);
public long this[int i]=>Value[i];

public static A158884Inst Instance=new A158884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158885
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,191L,4291L,192831L,17339621L,3119465383L,1122599989581L,808041963462203L,1163291544547461767L,BigInteger.Parse("3349506451610075179659"),BigInteger.Parse("19288870394264558342477991"),BigInteger.Parse("222159361747812912367189564823") };
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
public class A158885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158885Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158885.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158885.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158885Inst Instance=new A158885Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158886
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,21L,-504L,21505L,-1432080L,137227545L,-17893715840L,3047775608241L,-657209398809600L,175036741783305325L,BigInteger.Parse("-56436686113876992000"),BigInteger.Parse("21667473499647065000625"),BigInteger.Parse("-9768377272589156352395264") };
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
public class A158886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158886.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158886Inst Instance=new A158886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158887
{
public static readonly BigInteger[] Value={ 1L,1L,4L,45L,1056L,43225L,2756160L,253586025L,31872332800L,5252921480961L,1099886703552000L,285322741626047125L,BigInteger.Parse("89844523369696972800"),BigInteger.Parse("33764841634845724313625"),BigInteger.Parse("14930493174337400252809216") };
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
public class A158887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158887Inst Instance=new A158887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158888
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,305L,8785L,497089L,55504321L,12305179649L,5437293562113L,4797448178045953L,8459278545576012801L,BigInteger.Parse("29821007074850747998209"),BigInteger.Parse("210213196038821563873677313"),BigInteger.Parse("2963378701144932768795387346945") };
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
public class A158888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158888Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158888.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158888.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158888Inst Instance=new A158888Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158889
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,23L,205L,3833L,148051L,11761606L,1909231503L,632185554036L,427306055229923L,589583957310155426L,BigInteger.Parse("1662328104286133851880"),BigInteger.Parse("9585835617647933412333536"),BigInteger.Parse("113145883593065457861894176545") };
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
public class A158889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158889Inst Instance=new A158889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158890
{
public static readonly long[] Value={ 67935525L,135460080L,1098298110L,1191370110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158890Inst : IEnumerable<long>
{
public static readonly long[] Value=A158890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158890.Bytes);
public long this[int i]=>Value[i];

public static A158890Inst Instance=new A158890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158891
{
public static readonly long[] Value={ 1L,7L,9L,15L,21L,31L,37L,39L,61L,75L,91L,115L,117L,121L,129L,141L,147L,151L,169L,171L,187L,195L,201L,217L,241L,249L,285L,301L,319L,339L,357L,399L,417L,421L,435L,457L,477L,481L,487L,499L,507L,529L,567L,577L,579L,595L,607L,621L,627L,631L,645L,691L,711L,715L,717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158891Inst : IEnumerable<long>
{
public static readonly long[] Value=A158891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158891.Bytes);
public long this[int i]=>Value[i];

public static A158891Inst Instance=new A158891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158892
{
public static readonly long[] Value={ 5L,7L,13L,107L,227L,491L,8009L,36779L,80513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158892Inst : IEnumerable<long>
{
public static readonly long[] Value=A158892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158892.Bytes);
public long this[int i]=>Value[i];

public static A158892Inst Instance=new A158892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158893
{
public static readonly long[] Value={ 1L,8L,1L,15L,2L,1L,22L,3L,2L,1L,29L,4L,3L,2L,1L,36L,5L,4L,3L,2L,1L,43L,6L,5L,4L,3L,2L,1L,50L,7L,6L,5L,4L,3L,2L,1L,57L,8L,7L,6L,5L,4L,3L,2L,1L,64L,9L,8L,7L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158893Inst : IEnumerable<long>
{
public static readonly long[] Value=A158893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158893.Bytes);
public long this[int i]=>Value[i];

public static A158893Inst Instance=new A158893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158894
{
public static readonly long[] Value={ 3L,3L,5L,3L,5L,7L,3L,5L,7L,9L,3L,5L,7L,9L,11L,3L,5L,7L,9L,11L,13L,3L,5L,7L,9L,11L,13L,15L,3L,5L,7L,9L,11L,13L,15L,17L,3L,5L,7L,9L,11L,13L,15L,17L,19L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,3L,5L,7L,9L,11L,13L,15L,17L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158894Inst : IEnumerable<long>
{
public static readonly long[] Value=A158894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158894.Bytes);
public long this[int i]=>Value[i];

public static A158894Inst Instance=new A158894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158895
{
public static readonly long[] Value={ 3L,5L,17L,11L,13L,43L,257L,19L,41L,683L,241L,2731L,29L,113L,331L,65537L,43691L,37L,109L,174763L,61681L,5419L,397L,2113L,2796203L,97L,673L,251L,4051L,53L,157L,1613L,87211L,15790321L,59L,3033169L,61L,1321L,715827883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158895Inst : IEnumerable<long>
{
public static readonly long[] Value=A158895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158895.Bytes);
public long this[int i]=>Value[i];

public static A158895Inst Instance=new A158895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158896
{
public static readonly long[] Value={ 5L,17L,53L,151L,157L,163L,173L,463L,467L,491L,523L,541L,1451L,1471L,1483L,1489L,1499L,1511L,1549L,1553L,1567L,1609L,1657L,1721L,1723L,4583L,4597L,4621L,4649L,4663L,4673L,4703L,4729L,4751L,4759L,4787L,4813L,4937L,4943L,4973L,4993L,5039L,5077L,5227L,5297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158896Inst : IEnumerable<long>
{
public static readonly long[] Value=A158896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158896.Bytes);
public long this[int i]=>Value[i];

public static A158896Inst Instance=new A158896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158897
{
public static readonly long[] Value={ 6L,0L,11L,0L,0L,18L,0L,0L,0L,27L,0L,0L,0L,0L,38L,0L,0L,0L,0L,0L,51L,0L,0L,0L,0L,0L,0L,66L,0L,0L,0L,0L,0L,0L,0L,83L,0L,0L,0L,0L,0L,0L,0L,0L,102L,0L,0L,0L,0L,0L,0L,0L,0L,0L,123L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,146L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,171L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,198L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158897Inst : IEnumerable<long>
{
public static readonly long[] Value=A158897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158897.Bytes);
public long this[int i]=>Value[i];

public static A158897Inst Instance=new A158897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158898
{
public static readonly BigInteger[] Value={ 7L,35287L,113742727L,347251215703L,1050773495363767L,3174564739209417463L,BigInteger.Parse("9588099190533549457408"),BigInteger.Parse("28957256518828921149989143"),BigInteger.Parse("87453655435340440175476698487"),BigInteger.Parse("264117827347202707929587420182327") };
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
public class A158898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158898Inst Instance=new A158898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158899
{
public static readonly long[] Value={ 14L,34L,38L,46L,58L,94L,118L,122L,194L,218L,226L,262L,298L,334L,358L,362L,386L,446L,458L,466L,514L,526L,538L,626L,674L,734L,758L,766L,778L,838L,866L,922L,974L,982L,998L,1006L,1018L,1082L,1142L,1154L,1186L,1238L,1294L,1318L,1402L,1418L,1454L,1486L,1622L,1642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158899Inst : IEnumerable<long>
{
public static readonly long[] Value=A158899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158899.Bytes);
public long this[int i]=>Value[i];

public static A158899Inst Instance=new A158899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158900
{
public static readonly long[] Value={ 1L,1L,4L,20L,116L,756L,5448L,43032L,370704L,3472656L,35303424L,388786176L,4628774016L,59431077504L,820503839232L,12140411779584L,191844739736064L,3226219598338560L,57540789020021760L,1084906603389864960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158900Inst : IEnumerable<long>
{
public static readonly long[] Value=A158900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158900.Bytes);
public long this[int i]=>Value[i];

public static A158900Inst Instance=new A158900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158901
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,9L,7L,12L,11L,15L,11L,23L,13L,21L,21L,27L,17L,34L,19L,37L,29L,33L,23L,53L,29L,39L,37L,51L,29L,65L,31L,58L,45L,51L,45L,83L,37L,57L,53L,83L,41L,89L,43L,79L,73L,69L,47L,115L,55L,88L,69L,93L,53L,113L,69L,113L,77L,87L,59L,157L,61L,93L,99L,121L,81L,137L,67L,121L,93L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158901Inst : IEnumerable<long>
{
public static readonly long[] Value=A158901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158901.Bytes);
public long this[int i]=>Value[i];

public static A158901Inst Instance=new A158901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158902
{
public static readonly long[] Value={ 1L,2L,1L,3L,0L,1L,5L,1L,0L,1L,5L,0L,0L,0L,1L,9L,1L,1L,0L,0L,1L,7L,0L,0L,0L,0L,0L,1L,12L,1L,0L,1L,0L,0L,0L,1L,11L,0L,1L,0L,0L,0L,0L,0L,1L,15L,1L,0L,0L,1L,0L,0L,0L,0L,1L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,23L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158902Inst : IEnumerable<long>
{
public static readonly long[] Value=A158902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158902.Bytes);
public long this[int i]=>Value[i];

public static A158902Inst Instance=new A158902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158903
{
public static readonly BigInteger[] Value={ 1L,4L,-2L,-152L,-500L,8944L,80776L,-642848L,-12749168L,41573440L,2231658976L,1443416704L,-436094810432L,-2056157249792L,93821556641920L,893437853515264L,-21758068879257344L,-344342377329425408L,5280599567735045632L,BigInteger.Parse("132689328525674014720"),BigInteger.Parse("-1275207738062689547264") };
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
public class A158903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A158903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A158903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A158903Inst Instance=new A158903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A158904
{
public static readonly long[] Value={ 0L,0L,2L,2970L,1346052L,190310900L,10284101190L,270774275982L,4231630881800L,44940276612072L,355458410080650L,2231437465657730L,11635407170995212L,52110833436028380L,205595759294267342L,728666611701477750L,2355900976191279120L,7034807710363658192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A158904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A158904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A158904Inst : IEnumerable<long>
{
public static readonly long[] Value=A158904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A158904.Bytes);
public long this[int i]=>Value[i];

public static A158904Inst Instance=new A158904Inst();

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