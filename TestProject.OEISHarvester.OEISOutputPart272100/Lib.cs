using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A046008
{
public static readonly long[] Value={ 167L,271L,659L,967L,1283L,1303L,1307L,1459L,1531L,1699L,2027L,2267L,2539L,2731L,2851L,2971L,3203L,3347L,3499L,3739L,3931L,4051L,5179L,5683L,6163L,6547L,7027L,7507L,7603L,7867L,8443L,9283L,9403L,9643L,9787L,10987L,13003L,13267L,14107L,14683L,15667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046008Inst : IEnumerable<long>
{
public static readonly long[] Value=A046008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046008.Bytes);
public long this[int i]=>Value[i];

public static A046008Inst Instance=new A046008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046009
{
public static readonly long[] Value={ 231L,255L,327L,356L,440L,516L,543L,655L,680L,687L,696L,728L,731L,744L,755L,804L,888L,932L,948L,964L,984L,996L,1011L,1067L,1096L,1144L,1208L,1235L,1236L,1255L,1272L,1336L,1355L,1371L,1419L,1464L,1480L,1491L,1515L,1547L,1572L,1668L,1720L,1732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046009Inst : IEnumerable<long>
{
public static readonly long[] Value=A046009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046009.Bytes);
public long this[int i]=>Value[i];

public static A046009Inst Instance=new A046009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046010
{
public static readonly long[] Value={ 191L,263L,607L,631L,727L,1019L,1451L,1499L,1667L,1907L,2131L,2143L,2371L,2659L,2963L,3083L,3691L,4003L,4507L,4643L,5347L,5419L,5779L,6619L,7243L,7963L,9547L,9739L,11467L,11587L,11827L,11923L,12043L,14347L,15787L,16963L,20563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046010Inst : IEnumerable<long>
{
public static readonly long[] Value=A046010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046010.Bytes);
public long this[int i]=>Value[i];

public static A046010Inst Instance=new A046010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046011
{
public static readonly long[] Value={ 215L,287L,391L,404L,447L,511L,535L,536L,596L,692L,703L,807L,899L,1112L,1211L,1396L,1403L,1527L,1816L,1851L,1883L,2008L,2123L,2147L,2171L,2335L,2427L,2507L,2536L,2571L,2612L,2779L,2931L,2932L,3112L,3227L,3352L,3579L,3707L,3715L,3867L,3988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046011Inst : IEnumerable<long>
{
public static readonly long[] Value=A046011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046011.Bytes);
public long this[int i]=>Value[i];

public static A046011Inst Instance=new A046011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046012
{
public static readonly long[] Value={ 239L,439L,751L,971L,1259L,1327L,1427L,1567L,1619L,2243L,2647L,2699L,2843L,3331L,3571L,3803L,4099L,4219L,5003L,5227L,5323L,5563L,5827L,5987L,6067L,6091L,6211L,6571L,7219L,7459L,7547L,8467L,8707L,8779L,9043L,9907L,10243L,10267L,10459L,10651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046012Inst : IEnumerable<long>
{
public static readonly long[] Value=A046012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046012.Bytes);
public long this[int i]=>Value[i];

public static A046012Inst Instance=new A046012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046013
{
public static readonly long[] Value={ 399L,407L,471L,559L,584L,644L,663L,740L,799L,884L,895L,903L,943L,1015L,1016L,1023L,1028L,1047L,1139L,1140L,1159L,1220L,1379L,1412L,1416L,1508L,1560L,1595L,1608L,1624L,1636L,1640L,1716L,1860L,1876L,1924L,1983L,2004L,2019L,2040L,2056L,2072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046013Inst : IEnumerable<long>
{
public static readonly long[] Value=A046013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046013.Bytes);
public long this[int i]=>Value[i];

public static A046013Inst Instance=new A046013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046014
{
public static readonly long[] Value={ 383L,991L,1091L,1571L,1663L,1783L,2531L,3323L,3947L,4339L,4447L,4547L,4651L,5483L,6203L,6379L,6451L,6827L,6907L,7883L,8539L,8731L,9883L,11251L,11443L,12907L,13627L,14083L,14779L,14947L,16699L,17827L,18307L,19963L,21067L,23563L,24907L,25243L,26083L,26107L,27763L,31627L,33427L,36523L,37123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046014Inst : IEnumerable<long>
{
public static readonly long[] Value=A046014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046014.Bytes);
public long this[int i]=>Value[i];

public static A046014Inst Instance=new A046014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046015
{
public static readonly long[] Value={ 335L,519L,527L,679L,1135L,1172L,1207L,1383L,1448L,1687L,1691L,1927L,2047L,2051L,2167L,2228L,2291L,2315L,2344L,2644L,2747L,2859L,3035L,3107L,3543L,3544L,3651L,3688L,4072L,4299L,4307L,4568L,4819L,4883L,5224L,5315L,5464L,5492L,5539L,5899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046015Inst : IEnumerable<long>
{
public static readonly long[] Value=A046015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046015.Bytes);
public long this[int i]=>Value[i];

public static A046015Inst Instance=new A046015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046016
{
public static readonly long[] Value={ 311L,359L,919L,1063L,1543L,1831L,2099L,2339L,2459L,3343L,3463L,3467L,3607L,4019L,4139L,4327L,5059L,5147L,5527L,5659L,6803L,8419L,8923L,8971L,9619L,10891L,11299L,15091L,15331L,16363L,16747L,17011L,17299L,17539L,17683L,19507L,21187L,21211L,21283L,23203L,24763L,26227L,27043L,29803L,31123L,37507L,38707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046016Inst : IEnumerable<long>
{
public static readonly long[] Value=A046016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046016.Bytes);
public long this[int i]=>Value[i];

public static A046016Inst Instance=new A046016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046017
{
public static readonly long[] Value={ 2L,9L,8L,7L,28L,18L,18L,46L,54L,82L,98L,108L,20L,91L,107L,133L,80L,172L,80L,90L,90L,90L,234L,252L,140L,306L,305L,90L,305L,396L,170L,388L,170L,387L,378L,388L,414L,468L,449L,250L,432L,280L,461L,280L,360L,360L,350L,370L,270L,685L,360L,625L,648L,370L,677L,684L,370L,667L,370L,694L,440L,855L,827L,430L,818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046017Inst : IEnumerable<long>
{
public static readonly long[] Value=A046017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046017.Bytes);
public long this[int i]=>Value[i];

public static A046017Inst Instance=new A046017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046018
{
public static readonly long[] Value={ 431L,503L,743L,863L,1931L,2503L,2579L,2767L,2819L,3011L,3371L,4283L,4523L,4691L,5011L,5647L,5851L,5867L,6323L,6691L,7907L,8059L,8123L,8171L,8243L,8387L,8627L,8747L,9091L,9187L,9811L,9859L,10067L,10771L,11731L,12107L,12547L,13171L,13291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046018Inst : IEnumerable<long>
{
public static readonly long[] Value=A046018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046018.Bytes);
public long this[int i]=>Value[i];

public static A046018Inst Instance=new A046018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046019
{
public static readonly long[] Value={ 1L,9L,2L,6L,6L,5L,5L,9L,4L,4L,7L,4L,2L,12L,6L,8L,7L,5L,3L,10L,4L,4L,8L,4L,4L,14L,5L,3L,7L,6L,2L,11L,2L,8L,4L,6L,3L,9L,3L,3L,7L,2L,5L,10L,6L,4L,9L,9L,5L,12L,2L,4L,5L,5L,6L,3L,2L,7L,4L,5L,5L,6L,3L,4L,5L,5L,4L,9L,2L,6L,4L,3L,3L,6L,5L,6L,4L,4L,5L,9L,5L,3L,5L,5L,2L,6L,3L,7L,7L,4L,3L,8L,4L,4L,9L,6L,2L,8L,2L,5L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046019Inst : IEnumerable<long>
{
public static readonly long[] Value=A046019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046019.Bytes);
public long this[int i]=>Value[i];

public static A046019Inst Instance=new A046019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046020
{
public static readonly long[] Value={ 647L,1039L,1103L,1279L,1447L,1471L,1811L,1979L,2411L,2671L,3491L,3539L,3847L,3923L,4211L,4783L,5387L,5507L,5531L,6563L,6659L,6703L,7043L,9587L,9931L,10867L,10883L,12203L,12739L,13099L,13187L,15307L,15451L,16267L,17203L,17851L,18379L,20323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046020Inst : IEnumerable<long>
{
public static readonly long[] Value=A046020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046020.Bytes);
public long this[int i]=>Value[i];

public static A046020Inst Instance=new A046020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046021
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,7L,32L,27L,25L,11L,243L,13L,49L,125L,4096L,17L,2187L,19L,625L,343L,121L,23L,59049L,3125L,169L,177147L,2401L,29L,78125L,31L,134217728L,1331L,289L,16807L,43046721L,37L,361L,2197L,1953125L,41L,117649L,43L,14641L,9765625L,529L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046021Inst : IEnumerable<long>
{
public static readonly long[] Value=A046021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046021.Bytes);
public long this[int i]=>Value[i];

public static A046021Inst Instance=new A046021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046022
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046022Inst : IEnumerable<long>
{
public static readonly long[] Value=A046022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046022.Bytes);
public long this[int i]=>Value[i];

public static A046022Inst Instance=new A046022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046023
{
public static readonly long[] Value={ 0L,1L,12L,87L,416L,1475L,4236L,10437L,22912L,45981L,85900L,151371L,254112L,409487L,637196L,962025L,1414656L,2032537L,2860812L,3953311L,5373600L,7196091L,9507212L,12406637L,16008576L,20443125L,25857676L,32418387L,40311712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046023Inst : IEnumerable<long>
{
public static readonly long[] Value=A046023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046023.Bytes);
public long this[int i]=>Value[i];

public static A046023Inst Instance=new A046023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046024
{
public static readonly long[] Value={ 1L,3L,59L,361139L,43922730588128390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046024Inst : IEnumerable<long>
{
public static readonly long[] Value=A046024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046024.Bytes);
public long this[int i]=>Value[i];

public static A046024Inst Instance=new A046024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046025
{
public static readonly long[] Value={ 1L,6L,35L,45L,51L,55L,56L,100L,121L,195L,206L,216L,255L,276L,370L,380L,426L,506L,510L,511L,710L,741L,800L,825L,871L,930L,975L,1025L,1060L,1115L,1140L,1161L,1270L,1280L,1281L,1311L,1336L,1361L,1365L,1381L,1420L,1421L,1441L,1490L,1515L,1696L,1805L,1875L,1885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046025Inst : IEnumerable<long>
{
public static readonly long[] Value=A046025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046025.Bytes);
public long this[int i]=>Value[i];

public static A046025Inst Instance=new A046025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046026
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,5L,7L,13L,7L,5L,17L,7L,7L,11L,23L,13L,5L,5L,5L,11L,17L,7L,23L,19L,13L,41L,7L,43L,23L,47L,17L,19L,11L,19L,29L,13L,17L,31L,13L,11L,67L,23L,7L,71L,53L,37L,11L,13L,29L,41L,83L,17L,43L,29L,89L,13L,31L,47L,19L,17L,101L,17L,103L,7L,53L,107L,109L,11L,37L,113L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046026Inst : IEnumerable<long>
{
public static readonly long[] Value=A046026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046026.Bytes);
public long this[int i]=>Value[i];

public static A046026Inst Instance=new A046026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046027
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,2L,5L,3L,2L,2L,2L,2L,2L,3L,2L,7L,5L,2L,3L,2L,2L,3L,2L,2L,2L,5L,2L,2L,3L,2L,2L,3L,2L,2L,7L,3L,2L,2L,2L,2L,2L,3L,2L,11L,2L,5L,3L,2L,2L,3L,2L,2L,2L,7L,2L,5L,2L,3L,2L,2L,3L,2L,2L,13L,3L,2L,5L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,11L,3L,2L,7L,2L,5L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046027Inst : IEnumerable<long>
{
public static readonly long[] Value=A046027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046027.Bytes);
public long this[int i]=>Value[i];

public static A046027Inst Instance=new A046027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046028
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,2L,5L,3L,2L,2L,3L,2L,2L,3L,2L,7L,5L,2L,3L,2L,2L,3L,2L,2L,3L,5L,2L,2L,3L,2L,2L,3L,2L,2L,7L,3L,5L,2L,3L,2L,2L,3L,2L,11L,2L,5L,3L,2L,2L,3L,2L,2L,3L,7L,2L,5L,2L,3L,2L,2L,3L,2L,2L,13L,3L,2L,5L,2L,3L,2L,2L,3L,2L,7L,3L,5L,2L,3L,2L,2L,3L,2L,2L,5L,2L,2L,3L,2L,2L,11L,3L,2L,7L,2L,5L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046028Inst : IEnumerable<long>
{
public static readonly long[] Value=A046028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046028.Bytes);
public long this[int i]=>Value[i];

public static A046028Inst Instance=new A046028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046077
{
public static readonly long[] Value={ 103L,138L,875L,949L,6617L,1802L,14545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046077Inst : IEnumerable<long>
{
public static readonly long[] Value=A046077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046077.Bytes);
public long this[int i]=>Value[i];

public static A046077Inst Instance=new A046077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046078
{
public static readonly long[] Value={ 5L,7L,19L,11L,41L,31L,53L,109L,47L,83L,127L,271L,107L,251L,191L,499L,311L,811L,239L,929L,659L,839L,431L,683L,503L,2161L,971L,3659L,2267L,3119L,1319L,4421L,4969L,2663L,2999L,1871L,4373L,4871L,6551L,9311L,5939L,10099L,5039L,8423L,11423L,13309L,9839L,16001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046078Inst : IEnumerable<long>
{
public static readonly long[] Value=A046078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046078.Bytes);
public long this[int i]=>Value[i];

public static A046078Inst Instance=new A046078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046079
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,2L,2L,1L,1L,4L,1L,1L,4L,3L,1L,2L,1L,4L,4L,1L,1L,7L,2L,1L,3L,4L,1L,4L,1L,4L,4L,1L,4L,7L,1L,1L,4L,7L,1L,4L,1L,4L,7L,1L,1L,10L,2L,2L,4L,4L,1L,3L,4L,7L,4L,1L,1L,13L,1L,1L,7L,5L,4L,4L,1L,4L,4L,4L,1L,12L,1L,1L,7L,4L,4L,4L,1L,10L,4L,1L,1L,13L,4L,1L,4L,7L,1L,7L,4L,4L,4L,1L,4L,13L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046079Inst : IEnumerable<long>
{
public static readonly long[] Value=A046079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046079.Bytes);
public long this[int i]=>Value[i];

public static A046079Inst Instance=new A046079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046080
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,2L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,2L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,4L,0L,0L,1L,0L,1L,0L,0L,1L,1L,2L,0L,0L,1L,0L,1L,0L,1L,0L,0L,4L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046080Inst : IEnumerable<long>
{
public static readonly long[] Value=A046080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046080.Bytes);
public long this[int i]=>Value[i];

public static A046080Inst Instance=new A046080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046081
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,1L,2L,2L,2L,1L,4L,2L,1L,5L,3L,2L,2L,1L,5L,4L,1L,1L,7L,4L,2L,3L,4L,2L,5L,1L,4L,4L,2L,5L,7L,2L,1L,5L,8L,2L,4L,1L,4L,8L,1L,1L,10L,2L,4L,5L,5L,2L,3L,5L,7L,4L,2L,1L,14L,2L,1L,7L,5L,8L,4L,1L,5L,4L,5L,1L,12L,2L,2L,9L,4L,4L,5L,1L,11L,4L,2L,1L,13L,8L,1L,5L,7L,2L,8L,5L,4L,4L,1L,5L,13L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046081Inst : IEnumerable<long>
{
public static readonly long[] Value=A046081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046081.Bytes);
public long this[int i]=>Value[i];

public static A046081Inst Instance=new A046081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046082
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,19L,139L,2319L,77423L,4909331L,554491273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046082Inst : IEnumerable<long>
{
public static readonly long[] Value=A046082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046082.Bytes);
public long this[int i]=>Value[i];

public static A046082Inst Instance=new A046082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046083
{
public static readonly long[] Value={ 3L,6L,5L,9L,8L,12L,15L,7L,10L,20L,18L,16L,21L,12L,15L,24L,9L,27L,30L,14L,24L,20L,28L,33L,40L,36L,11L,39L,33L,25L,16L,32L,42L,48L,24L,45L,21L,30L,48L,18L,51L,40L,36L,13L,60L,39L,54L,35L,57L,65L,60L,28L,20L,48L,40L,63L,56L,60L,66L,36L,15L,69L,80L,45L,56L,72L,22L,27L,75L,44L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046083Inst : IEnumerable<long>
{
public static readonly long[] Value=A046083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046083.Bytes);
public long this[int i]=>Value[i];

public static A046083Inst Instance=new A046083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046084
{
public static readonly long[] Value={ 4L,8L,12L,12L,15L,16L,20L,24L,24L,21L,24L,30L,28L,35L,36L,32L,40L,36L,40L,48L,45L,48L,45L,44L,42L,48L,60L,52L,56L,60L,63L,60L,56L,55L,70L,60L,72L,72L,64L,80L,68L,75L,77L,84L,63L,80L,72L,84L,76L,72L,80L,96L,99L,90L,96L,84L,90L,91L,88L,105L,112L,92L,84L,108L,105L,96L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046084Inst : IEnumerable<long>
{
public static readonly long[] Value=A046084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046084.Bytes);
public long this[int i]=>Value[i];

public static A046084Inst Instance=new A046084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046085
{
public static readonly long[] Value={ 14L,17L,21L,30L,33L,34L,39L,42L,46L,55L,57L,70L,73L,78L,82L,85L,93L,97L,102L,130L,133L,142L,155L,177L,190L,193L,195L,203L,219L,253L,259L,291L,323L,355L,435L,483L,555L,595L,627L,667L,715L,723L,763L,795L,955L,1003L,1027L,1227L,1243L,1387L,1411L,1435L,1507L,1555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046085Inst : IEnumerable<long>
{
public static readonly long[] Value=A046085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046085.Bytes);
public long this[int i]=>Value[i];

public static A046085Inst Instance=new A046085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046086
{
public static readonly long[] Value={ 3L,5L,8L,7L,20L,12L,9L,28L,11L,33L,16L,48L,36L,13L,39L,65L,20L,60L,15L,44L,88L,24L,17L,51L,85L,119L,52L,19L,104L,57L,95L,28L,133L,84L,140L,21L,60L,105L,120L,32L,96L,23L,69L,115L,160L,161L,68L,207L,136L,25L,75L,204L,36L,175L,180L,225L,76L,27L,252L,152L,135L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046086Inst : IEnumerable<long>
{
public static readonly long[] Value=A046086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046086.Bytes);
public long this[int i]=>Value[i];

public static A046086Inst Instance=new A046086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046087
{
public static readonly long[] Value={ 4L,12L,15L,24L,21L,35L,40L,45L,60L,56L,63L,55L,77L,84L,80L,72L,99L,91L,112L,117L,105L,143L,144L,140L,132L,120L,165L,180L,153L,176L,168L,195L,156L,187L,171L,220L,221L,208L,209L,255L,247L,264L,260L,252L,231L,240L,285L,224L,273L,312L,308L,253L,323L,288L,299L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046087Inst : IEnumerable<long>
{
public static readonly long[] Value=A046087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046087.Bytes);
public long this[int i]=>Value[i];

public static A046087Inst Instance=new A046087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046088
{
public static readonly long[] Value={ 1L,16L,206L,2371L,25761L,272376L,2848716L,29701906L,309654696L,3230358586L,33718475076L,352065356916L,3676515354356L,38394136371396L,400952138922036L,4187122750092776L,43725550173817616L,456617901788403056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046088Inst : IEnumerable<long>
{
public static readonly long[] Value=A046088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046088.Bytes);
public long this[int i]=>Value[i];

public static A046088Inst Instance=new A046088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046089
{
public static readonly long[] Value={ 1L,3L,1L,12L,9L,1L,60L,75L,18L,1L,360L,660L,255L,30L,1L,2520L,6300L,3465L,645L,45L,1L,20160L,65520L,47880L,12495L,1365L,63L,1L,181440L,740880L,687960L,235305L,35700L,2562L,84L,1L,1814400L,9072000L,10372320L,4452840L,877905L,86940L,4410L,108L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046089Inst : IEnumerable<long>
{
public static readonly long[] Value=A046089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046089.Bytes);
public long this[int i]=>Value[i];

public static A046089Inst Instance=new A046089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046090
{
public static readonly long[] Value={ 1L,4L,21L,120L,697L,4060L,23661L,137904L,803761L,4684660L,27304197L,159140520L,927538921L,5406093004L,31509019101L,183648021600L,1070379110497L,6238626641380L,36361380737781L,211929657785304L,1235216565974041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046090Inst : IEnumerable<long>
{
public static readonly long[] Value=A046090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046090.Bytes);
public long this[int i]=>Value[i];

public static A046090Inst Instance=new A046090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046091
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,12L,30L,79L,227L,709L,2318L,8049L,29372L,112000L,444855L,1833072L,7806724L,34252145L,154342391L,712231465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046091Inst : IEnumerable<long>
{
public static readonly long[] Value=A046091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046091.Bytes);
public long this[int i]=>Value[i];

public static A046091Inst Instance=new A046091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046092
{
public static readonly long[] Value={ 0L,4L,12L,24L,40L,60L,84L,112L,144L,180L,220L,264L,312L,364L,420L,480L,544L,612L,684L,760L,840L,924L,1012L,1104L,1200L,1300L,1404L,1512L,1624L,1740L,1860L,1984L,2112L,2244L,2380L,2520L,2664L,2812L,2964L,3120L,3280L,3444L,3612L,3784L,3960L,4140L,4324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046092Inst : IEnumerable<long>
{
public static readonly long[] Value=A046092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046092.Bytes);
public long this[int i]=>Value[i];

public static A046092Inst Instance=new A046092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046109
{
public static readonly long[] Value={ 1L,4L,4L,4L,4L,12L,4L,4L,4L,4L,12L,4L,4L,12L,4L,12L,4L,12L,4L,4L,12L,4L,4L,4L,4L,20L,12L,4L,4L,12L,12L,4L,4L,4L,12L,12L,4L,12L,4L,12L,12L,12L,4L,4L,4L,12L,4L,4L,4L,4L,20L,12L,12L,12L,4L,12L,4L,4L,12L,4L,12L,12L,4L,4L,4L,36L,4L,4L,12L,4L,12L,4L,4L,12L,12L,20L,4L,4L,12L,4L,12L,4L,12L,4L,4L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046109Inst : IEnumerable<long>
{
public static readonly long[] Value=A046109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046109.Bytes);
public long this[int i]=>Value[i];

public static A046109Inst Instance=new A046109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046110
{
public static readonly long[] Value={ 2L,2L,6L,2L,2L,2L,6L,6L,6L,2L,2L,2L,10L,2L,6L,2L,2L,6L,6L,6L,6L,2L,6L,2L,2L,6L,6L,6L,2L,2L,6L,2L,18L,2L,2L,2L,6L,10L,2L,2L,2L,2L,18L,6L,6L,6L,2L,6L,6L,2L,6L,2L,6L,2L,6L,6L,6L,6L,6L,6L,2L,6L,14L,2L,2L,2L,2L,6L,6L,2L,2L,6L,18L,2L,6L,2L,6L,6L,6L,6L,2L,2L,6L,2L,10L,2L,6L,10L,2L,2L,6L,6L,18L,6L,2L,2L,6L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046110Inst : IEnumerable<long>
{
public static readonly long[] Value=A046110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046110.Bytes);
public long this[int i]=>Value[i];

public static A046110Inst Instance=new A046110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046111
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,1L,3L,1L,1L,3L,1L,3L,1L,1L,5L,3L,1L,3L,1L,1L,3L,3L,3L,1L,3L,3L,1L,1L,1L,1L,1L,5L,3L,3L,3L,1L,3L,1L,3L,1L,1L,9L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,9L,1L,1L,3L,3L,1L,1L,3L,3L,1L,5L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,3L,1L,3L,1L,3L,1L,7L,1L,1L,9L,1L,1L,1L,3L,3L,1L,3L,1L,3L,9L,3L,3L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046111Inst : IEnumerable<long>
{
public static readonly long[] Value=A046111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046111.Bytes);
public long this[int i]=>Value[i];

public static A046111Inst Instance=new A046111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046112
{
public static readonly long[] Value={ 1L,5L,25L,125L,65L,3125L,15625L,325L,390625L,1953125L,1625L,48828125L,4225L,1105L,6103515625L,30517578125L,40625L,21125L,3814697265625L,203125L,95367431640625L,476837158203125L,5525L,11920928955078125L,274625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046112Inst : IEnumerable<long>
{
public static readonly long[] Value=A046112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046112.Bytes);
public long this[int i]=>Value[i];

public static A046112Inst Instance=new A046112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046113
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,2L,4L,0L,2L,4L,0L,0L,0L,0L,4L,2L,0L,0L,0L,0L,0L,4L,0L,2L,6L,0L,0L,4L,0L,0L,4L,0L,4L,0L,0L,2L,0L,0L,0L,4L,0L,4L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,2L,8L,0L,0L,4L,0L,4L,0L,0L,4L,2L,0L,0L,0L,0L,0L,8L,0L,0L,4L,0L,0L,0L,0L,0L,4L,0L,2L,0L,0L,0L,0L,0L,4L,4L,0L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046113Inst : IEnumerable<long>
{
public static readonly long[] Value=A046113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046113.Bytes);
public long this[int i]=>Value[i];

public static A046113Inst Instance=new A046113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046114
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,11L,15L,71L,228L,3035L,15403L,18438L,33841L,289166L,323007L,935180L,4063727L,4998907L,9062634L,367504267L,376566901L,4509740178L,13905787435L,101850252223L,115756039658L,912142529829L,1027898569487L,1940041099316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046114Inst : IEnumerable<long>
{
public static readonly long[] Value=A046114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046114.Bytes);
public long this[int i]=>Value[i];

public static A046114Inst Instance=new A046114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046115
{
public static readonly long[] Value={ 1L,1L,2L,5L,7L,19L,26L,123L,395L,5258L,26685L,31943L,58628L,500967L,559595L,1620157L,7040223L,8660380L,15700603L,636684500L,652385103L,7812920633L,24091147002L,176450949647L,200542096649L,1580245626190L,1780787722839L,3361033349029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046115Inst : IEnumerable<long>
{
public static readonly long[] Value=A046115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046115.Bytes);
public long this[int i]=>Value[i];

public static A046115Inst Instance=new A046115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046116
{
public static readonly long[] Value={ 92L,116L,156L,172L,184L,188L,232L,236L,260L,268L,292L,324L,356L,372L,376L,404L,412L,428L,436L,452L,472L,476L,508L,520L,532L,536L,584L,596L,604L,612L,652L,668L,712L,716L,732L,756L,764L,772L,808L,836L,852L,856L,872L,876L,892L,904L,932L,940L,944L,952L,956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046116Inst : IEnumerable<long>
{
public static readonly long[] Value=A046116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046116.Bytes);
public long this[int i]=>Value[i];

public static A046116Inst Instance=new A046116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046117
{
public static readonly long[] Value={ 11L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,89L,103L,107L,109L,113L,137L,157L,163L,173L,179L,197L,199L,229L,233L,239L,257L,263L,269L,277L,283L,313L,317L,337L,353L,359L,373L,379L,389L,439L,449L,463L,467L,509L,547L,563L,569L,577L,593L,599L,607L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046117Inst : IEnumerable<long>
{
public static readonly long[] Value=A046117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046117.Bytes);
public long this[int i]=>Value[i];

public static A046117Inst Instance=new A046117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046118
{
public static readonly long[] Value={ 7L,17L,31L,47L,67L,97L,101L,151L,167L,227L,257L,271L,347L,367L,557L,587L,607L,647L,727L,941L,971L,1097L,1117L,1181L,1217L,1277L,1291L,1361L,1427L,1447L,1487L,1607L,1657L,1747L,1777L,1867L,1901L,1987L,2131L,2281L,2377L,2411L,2677L,2687L,2707L,2791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046118Inst : IEnumerable<long>
{
public static readonly long[] Value=A046118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046118.Bytes);
public long this[int i]=>Value[i];

public static A046118Inst Instance=new A046118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046119
{
public static readonly long[] Value={ 13L,23L,37L,53L,73L,103L,107L,157L,173L,233L,263L,277L,353L,373L,563L,593L,613L,653L,733L,947L,977L,1103L,1123L,1187L,1223L,1283L,1297L,1367L,1433L,1453L,1493L,1613L,1663L,1753L,1783L,1873L,1907L,1993L,2137L,2287L,2383L,2417L,2683L,2693L,2713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046119Inst : IEnumerable<long>
{
public static readonly long[] Value=A046119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046119.Bytes);
public long this[int i]=>Value[i];

public static A046119Inst Instance=new A046119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046120
{
public static readonly long[] Value={ 19L,29L,43L,59L,79L,109L,113L,163L,179L,239L,269L,283L,359L,379L,569L,599L,619L,659L,739L,953L,983L,1109L,1129L,1193L,1229L,1289L,1303L,1373L,1439L,1459L,1499L,1619L,1669L,1759L,1789L,1879L,1913L,1999L,2143L,2293L,2389L,2423L,2689L,2699L,2719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046120Inst : IEnumerable<long>
{
public static readonly long[] Value=A046120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046120.Bytes);
public long this[int i]=>Value[i];

public static A046120Inst Instance=new A046120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046121
{
public static readonly long[] Value={ 5L,11L,41L,61L,251L,601L,641L,1091L,1481L,1601L,1741L,1861L,2371L,2671L,3301L,3911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046121Inst : IEnumerable<long>
{
public static readonly long[] Value=A046121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046121.Bytes);
public long this[int i]=>Value[i];

public static A046121Inst Instance=new A046121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046122
{
public static readonly long[] Value={ 11L,17L,47L,67L,257L,607L,647L,1097L,1487L,1607L,1747L,1867L,2377L,2677L,3307L,3917L,4007L,5107L,5387L,5437L,5647L,6317L,6367L,9467L,11827L,12107L,12647L,13457L,14627L,14747L,15797L,15907L,17477L,18217L,19477L,20347L,21487L,23327L,24097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046122Inst : IEnumerable<long>
{
public static readonly long[] Value=A046122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046122.Bytes);
public long this[int i]=>Value[i];

public static A046122Inst Instance=new A046122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046123
{
public static readonly long[] Value={ 17L,23L,53L,73L,263L,613L,653L,1103L,1493L,1613L,1753L,1873L,2383L,2683L,3313L,3923L,4013L,5113L,5393L,5443L,5653L,6323L,6373L,9473L,11833L,12113L,12653L,13463L,14633L,14753L,15803L,15913L,17483L,18223L,19483L,20353L,21493L,23333L,24103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046123Inst : IEnumerable<long>
{
public static readonly long[] Value=A046123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046123.Bytes);
public long this[int i]=>Value[i];

public static A046123Inst Instance=new A046123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046124
{
public static readonly long[] Value={ 23L,29L,59L,79L,269L,619L,659L,1109L,1499L,1619L,1759L,1879L,2389L,2689L,3319L,3929L,4019L,5119L,5399L,5449L,5659L,6329L,6379L,9479L,11839L,12119L,12659L,13469L,14639L,14759L,15809L,15919L,17489L,18229L,19489L,20359L,21499L,23339L,24109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046124Inst : IEnumerable<long>
{
public static readonly long[] Value=A046124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046124.Bytes);
public long this[int i]=>Value[i];

public static A046124Inst Instance=new A046124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046125
{
public static readonly long[] Value={ 9L,18L,16L,54L,25L,51L,31L,131L,34L,87L,41L,206L,37L,95L,68L,322L,45L,150L,47L,350L,85L,139L,68L,511L,95L,190L,93L,457L,83L,255L,73L,708L,101L,219L,103L,668L,85L,237L,115L,912L,109L,339L,106L,691L,154L,268L,107L,1365L,132L,345L,159L,770L,114L,427L,163L,1205L,179L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046125Inst : IEnumerable<long>
{
public static readonly long[] Value=A046125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046125.Bytes);
public long this[int i]=>Value[i];

public static A046125Inst Instance=new A046125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046126
{
public static readonly long[] Value={ 1L,3L,-3L,-15L,45L,315L,-1575L,-14175L,99225L,1091475L,-9823275L,-127702575L,1404728325L,21070924875L,-273922023375L,-4656674397375L,69850115960625L,1327152203251875L,-22561587455281875L,-473793336560919375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046126Inst : IEnumerable<long>
{
public static readonly long[] Value=A046126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046126.Bytes);
public long this[int i]=>Value[i];

public static A046126Inst Instance=new A046126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046127
{
public static readonly long[] Value={ 0L,2L,4L,8L,16L,30L,52L,84L,128L,186L,260L,352L,464L,598L,756L,940L,1152L,1394L,1668L,1976L,2320L,2702L,3124L,3588L,4096L,4650L,5252L,5904L,6608L,7366L,8180L,9052L,9984L,10978L,12036L,13160L,14352L,15614L,16948L,18356L,19840L,21402L,23044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046127Inst : IEnumerable<long>
{
public static readonly long[] Value=A046127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046127.Bytes);
public long this[int i]=>Value[i];

public static A046127Inst Instance=new A046127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046128
{
public static readonly long[] Value={ 3L,6L,5L,9L,4L,13L,9L,8L,11L,7L,12L,10L,13L,12L,15L,7L,10L,3L,17L,17L,20L,6L,18L,11L,8L,26L,5L,18L,16L,21L,8L,15L,25L,19L,15L,13L,12L,16L,17L,25L,10L,15L,22L,14L,24L,13L,25L,15L,9L,17L,20L,26L,15L,17L,27L,12L,13L,39L,29L,24L,30L,21L,39L,14L,27L,26L,20L,25L,13L,24L,27L,25L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046128Inst : IEnumerable<long>
{
public static readonly long[] Value=A046128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046128.Bytes);
public long this[int i]=>Value[i];

public static A046128Inst Instance=new A046128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046129
{
public static readonly long[] Value={ 4L,8L,12L,12L,13L,14L,10L,15L,13L,15L,16L,17L,20L,17L,20L,24L,24L,25L,25L,25L,21L,25L,24L,25L,26L,28L,29L,20L,30L,28L,29L,34L,29L,20L,26L,30L,35L,25L,28L,34L,35L,36L,26L,30L,32L,37L,39L,28L,40L,40L,34L,40L,37L,39L,36L,39L,40L,42L,35L,34L,40L,41L,41L,48L,30L,35L,37L,38L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046129Inst : IEnumerable<long>
{
public static readonly long[] Value=A046129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046129.Bytes);
public long this[int i]=>Value[i];

public static A046129Inst Instance=new A046129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046130
{
public static readonly long[] Value={ 5L,10L,13L,15L,15L,15L,17L,17L,20L,20L,20L,21L,21L,25L,25L,25L,26L,26L,26L,28L,29L,29L,30L,30L,30L,30L,30L,34L,34L,35L,35L,35L,36L,37L,37L,37L,37L,39L,39L,39L,39L,39L,40L,40L,40L,40L,40L,41L,41L,41L,42L,42L,44L,44L,45L,45L,45L,45L,48L,50L,50L,50L,50L,50L,51L,51L,51L,51L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046130Inst : IEnumerable<long>
{
public static readonly long[] Value=A046130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046130.Bytes);
public long this[int i]=>Value[i];

public static A046130Inst Instance=new A046130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046131
{
public static readonly long[] Value={ 6L,24L,30L,54L,24L,84L,36L,60L,66L,42L,96L,84L,126L,90L,150L,84L,120L,36L,204L,210L,210L,60L,216L,132L,96L,336L,72L,144L,240L,294L,84L,252L,360L,114L,156L,180L,210L,120L,210L,420L,168L,270L,264L,168L,384L,240L,468L,126L,180L,336L,336L,504L,264L,330L,486L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046131Inst : IEnumerable<long>
{
public static readonly long[] Value=A046131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046131.Bytes);
public long this[int i]=>Value[i];

public static A046131Inst Instance=new A046131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046132
{
public static readonly long[] Value={ 7L,11L,17L,23L,41L,47L,71L,83L,101L,107L,113L,131L,167L,197L,227L,233L,281L,311L,317L,353L,383L,401L,443L,461L,467L,491L,503L,617L,647L,677L,743L,761L,773L,827L,857L,863L,881L,887L,911L,941L,971L,1013L,1091L,1097L,1217L,1283L,1301L,1307L,1427L,1433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046132Inst : IEnumerable<long>
{
public static readonly long[] Value=A046132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046132.Bytes);
public long this[int i]=>Value[i];

public static A046132Inst Instance=new A046132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046133
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,29L,31L,41L,47L,59L,61L,67L,71L,89L,97L,101L,127L,137L,139L,151L,167L,179L,181L,199L,211L,227L,229L,239L,251L,257L,269L,271L,281L,337L,347L,367L,389L,397L,409L,419L,421L,431L,449L,467L,479L,487L,491L,509L,557L,587L,601L,607L,619L,631L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046133Inst : IEnumerable<long>
{
public static readonly long[] Value=A046133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046133.Bytes);
public long this[int i]=>Value[i];

public static A046133Inst Instance=new A046133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046134
{
public static readonly long[] Value={ 3L,5L,11L,29L,59L,71L,101L,149L,191L,269L,431L,569L,599L,821L,1031L,1061L,1229L,1289L,1319L,1451L,1481L,1619L,1871L,2081L,2129L,2339L,2381L,2549L,2711L,2789L,3251L,3299L,3461L,3539L,4019L,4049L,4091L,4649L,4721L,5099L,5441L,5519L,5639L,5651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046134Inst : IEnumerable<long>
{
public static readonly long[] Value=A046134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046134.Bytes);
public long this[int i]=>Value[i];

public static A046134Inst Instance=new A046134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046135
{
public static readonly long[] Value={ 5L,11L,17L,29L,41L,59L,71L,101L,137L,179L,227L,239L,269L,281L,347L,419L,431L,641L,809L,827L,1019L,1049L,1091L,1151L,1277L,1289L,1427L,1481L,1487L,1607L,1697L,1721L,1877L,2027L,2087L,2129L,2141L,2339L,2381L,2687L,2729L,2789L,2999L,3359L,3527L,3581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046135Inst : IEnumerable<long>
{
public static readonly long[] Value=A046135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046135.Bytes);
public long this[int i]=>Value[i];

public static A046135Inst Instance=new A046135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046136
{
public static readonly long[] Value={ 3L,7L,13L,19L,37L,43L,79L,97L,103L,127L,163L,223L,229L,307L,349L,379L,439L,457L,499L,643L,673L,853L,877L,937L,967L,1009L,1087L,1093L,1213L,1279L,1297L,1423L,1429L,1483L,1489L,1549L,1597L,1609L,1867L,1993L,2203L,2347L,2389L,2437L,2539L,2683L,2689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046136Inst : IEnumerable<long>
{
public static readonly long[] Value=A046136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046136.Bytes);
public long this[int i]=>Value[i];

public static A046136Inst Instance=new A046136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046137
{
public static readonly long[] Value={ 7L,19L,67L,97L,127L,229L,397L,487L,739L,757L,907L,1009L,1279L,1447L,1567L,1597L,1609L,1867L,1999L,2239L,2269L,2377L,2539L,2659L,2707L,3037L,3217L,3319L,3457L,3529L,3697L,3877L,3907L,3919L,4639L,4789L,4999L,5167L,5437L,5569L,5647L,5689L,5737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046137Inst : IEnumerable<long>
{
public static readonly long[] Value=A046137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046137.Bytes);
public long this[int i]=>Value[i];

public static A046137Inst Instance=new A046137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046138
{
public static readonly long[] Value={ 5L,11L,23L,53L,101L,131L,173L,191L,233L,263L,563L,593L,653L,821L,1013L,1223L,1283L,1481L,1601L,1613L,1871L,2081L,2333L,2543L,2963L,3251L,3323L,3461L,3533L,3761L,3911L,3923L,4013L,4211L,4253L,4643L,4793L,5003L,5273L,5471L,5651L,5843L,5861L,6263L,6353L,6563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046138Inst : IEnumerable<long>
{
public static readonly long[] Value=A046138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046138.Bytes);
public long this[int i]=>Value[i];

public static A046138Inst Instance=new A046138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046139
{
public static readonly long[] Value={ 7L,13L,31L,37L,61L,73L,97L,103L,157L,223L,271L,307L,373L,433L,457L,607L,733L,751L,853L,877L,1087L,1291L,1297L,1423L,1483L,1543L,1657L,1777L,1861L,1867L,1987L,1993L,2131L,2287L,2341L,2371L,2383L,2467L,2677L,2683L,2791L,2851L,3181L,3313L,3457L,3607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046139Inst : IEnumerable<long>
{
public static readonly long[] Value=A046139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046139.Bytes);
public long this[int i]=>Value[i];

public static A046139Inst Instance=new A046139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046140
{
public static readonly long[] Value={ 5L,7L,11L,17L,31L,41L,47L,61L,67L,97L,101L,151L,167L,227L,251L,257L,271L,347L,367L,557L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046140Inst : IEnumerable<long>
{
public static readonly long[] Value=A046140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046140.Bytes);
public long this[int i]=>Value[i];

public static A046140Inst Instance=new A046140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046157
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,2L,2L,3L,0L,3L,5L,3L,3L,3L,2L,0L,3L,2L,2L,2L,1L,1L,0L,2L,3L,4L,3L,3L,3L,7L,6L,7L,7L,8L,8L,13L,10L,10L,10L,12L,11L,6L,13L,14L,14L,14L,14L,15L,26L,16L,19L,14L,17L,18L,18L,19L,18L,20L,18L,21L,18L,20L,20L,21L,21L,19L,21L,15L,20L,23L,21L,21L,20L,22L,26L,21L,22L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046157Inst : IEnumerable<long>
{
public static readonly long[] Value=A046157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046157.Bytes);
public long this[int i]=>Value[i];

public static A046157Inst Instance=new A046157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046158
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,12L,19L,26L,97L,123L,149L,272L,395L,5258L,5653L,26685L,31943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046158Inst : IEnumerable<long>
{
public static readonly long[] Value=A046158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046158.Bytes);
public long this[int i]=>Value[i];

public static A046158Inst Instance=new A046158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046159
{
public static readonly long[] Value={ 3L,11L,15L,27L,35L,47L,51L,63L,75L,83L,99L,107L,111L,123L,143L,147L,155L,171L,191L,195L,207L,227L,243L,251L,267L,291L,299L,303L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046159Inst : IEnumerable<long>
{
public static readonly long[] Value=A046159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046159.Bytes);
public long this[int i]=>Value[i];

public static A046159Inst Instance=new A046159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046160
{
public static readonly long[] Value={ 2L,5L,6L,9L,11L,14L,15L,18L,21L,23L,27L,30L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046160Inst : IEnumerable<long>
{
public static readonly long[] Value=A046160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046160.Bytes);
public long this[int i]=>Value[i];

public static A046160Inst Instance=new A046160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046161
{
public static readonly long[] Value={ 1L,2L,8L,16L,128L,256L,1024L,2048L,32768L,65536L,262144L,524288L,4194304L,8388608L,33554432L,67108864L,2147483648L,4294967296L,17179869184L,34359738368L,274877906944L,549755813888L,2199023255552L,4398046511104L,70368744177664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046161Inst : IEnumerable<long>
{
public static readonly long[] Value=A046161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046161.Bytes);
public long this[int i]=>Value[i];

public static A046161Inst Instance=new A046161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046162
{
public static readonly long[] Value={ 0L,1L,4L,3L,16L,25L,12L,49L,64L,27L,100L,121L,48L,169L,196L,75L,256L,289L,108L,361L,400L,147L,484L,529L,192L,625L,676L,243L,784L,841L,300L,961L,1024L,363L,1156L,1225L,432L,1369L,1444L,507L,1600L,1681L,588L,1849L,1936L,675L,2116L,2209L,768L,2401L,2500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046162Inst : IEnumerable<long>
{
public static readonly long[] Value=A046162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046162.Bytes);
public long this[int i]=>Value[i];

public static A046162Inst Instance=new A046162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046163
{
public static readonly long[] Value={ 1L,7L,13L,7L,31L,43L,19L,73L,91L,37L,133L,157L,61L,211L,241L,91L,307L,343L,127L,421L,463L,169L,553L,601L,217L,703L,757L,271L,871L,931L,331L,1057L,1123L,397L,1261L,1333L,469L,1483L,1561L,547L,1723L,1807L,631L,1981L,2071L,721L,2257L,2353L,817L,2551L,2653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046163Inst : IEnumerable<long>
{
public static readonly long[] Value=A046163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046163.Bytes);
public long this[int i]=>Value[i];

public static A046163Inst Instance=new A046163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046164
{
public static readonly long[] Value={ 0L,10L,112L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046164Inst : IEnumerable<long>
{
public static readonly long[] Value=A046164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046164.Bytes);
public long this[int i]=>Value[i];

public static A046164Inst Instance=new A046164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046165
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,49L,462L,6424L,129425L,3731508L,152424420L,8780782707L,710389021036L,80610570275140L,12815915627480695L,2855758994821922882L,BigInteger.Parse("892194474524889501292"),BigInteger.Parse("391202163933291014701953"),BigInteger.Parse("240943718535427829240708786"),BigInteger.Parse("208683398342300491409959279244") };
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
public class A046165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046165Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046165.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046165Inst Instance=new A046165Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046166
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,171L,17066L,1298346L,83384427L,4762648737L,249485204452L,12226539786912L,568267449522773L,25296121946918823L,1086375882592194558L,BigInteger.Parse("45264846407024660598"),BigInteger.Parse("1837809636559394481439"),BigInteger.Parse("72965749033508656346829") };
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
public class A046166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046166Inst Instance=new A046166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046167
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,1L,420L,100814L,18151560L,2723868147L,359750257020L,43199991728608L,4817721638970240L,506352103838393813L,BigInteger.Parse("50691406225311551700"),BigInteger.Parse("4872449650707855334482"),BigInteger.Parse("452435489306282260691640") };
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
public class A046167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046167Inst Instance=new A046167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046168
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,2259L,2835075L,2609269245L,1964842113102L,1282310235724518L,751046094737039530L,BigInteger.Parse("403981152738311915910"),BigInteger.Parse("202813559477327441603103"),BigInteger.Parse("96164301413883629093787477") };
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
public class A046168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046168Inst Instance=new A046168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046169
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,5065L,14109865L,28586753635L,47057782540912L,66738127617591430L,BigInteger.Parse("84508389361603849070"),BigInteger.Parse("97838285747685771503930"),BigInteger.Parse("105306724888534860425617883"),BigInteger.Parse("106678207181565103216667658695") };
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
public class A046169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046169Inst Instance=new A046169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046170
{
public static readonly long[] Value={ 1L,2L,5L,12L,30L,73L,183L,456L,1151L,2900L,7361L,18684L,47652L,121584L,311259L,797311L,2047384L,5260692L,13542718L,34884239L,89991344L,232282110L,600281932L,1552096361L,4017128206L,10401997092L,26957667445L,69892976538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046170Inst : IEnumerable<long>
{
public static readonly long[] Value=A046170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046170.Bytes);
public long this[int i]=>Value[i];

public static A046170Inst Instance=new A046170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046171
{
public static readonly long[] Value={ 1L,2L,5L,13L,36L,98L,272L,740L,2034L,5513L,15037L,40617L,110188L,296806L,802075L,2155667L,5808335L,15582342L,41889578L,112212146L,301100754L,805570061L,2158326727L,5768299665L,15435169364L,41214098278L,110164686454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046171Inst : IEnumerable<long>
{
public static readonly long[] Value=A046171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046171.Bytes);
public long this[int i]=>Value[i];

public static A046171Inst Instance=new A046171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046172
{
public static readonly BigInteger[] Value={ 1L,81L,7921L,776161L,76055841L,7452696241L,730288175761L,71560788528321L,7012226987599681L,687126683996240401L,BigInteger.Parse("67331402804643959601"),BigInteger.Parse("6597790348171111800481"),BigInteger.Parse("646516122717964312487521"),BigInteger.Parse("63351982236012331511976561"),BigInteger.Parse("6207847743006490523861215441") };
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
public class A046172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046172Inst Instance=new A046172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046173
{
public static readonly BigInteger[] Value={ 1L,99L,9701L,950599L,93149001L,9127651499L,894416697901L,87643708742799L,8588189040096401L,841554882220704499L,BigInteger.Parse("82463790268588944501"),BigInteger.Parse("8080609891439495856599"),BigInteger.Parse("791817305570802005002201"),BigInteger.Parse("77590015336047156994359099"),BigInteger.Parse("7603029685627050583442189501") };
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
public class A046173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046173Inst Instance=new A046173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046174
{
public static readonly long[] Value={ 0L,1L,12L,165L,2296L,31977L,445380L,6203341L,86401392L,1203416145L,16761424636L,233456528757L,3251629977960L,45289363162681L,630799454299572L,8785902997031325L,122371842504138976L,1704419892060914337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046174Inst : IEnumerable<long>
{
public static readonly long[] Value=A046174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046174.Bytes);
public long this[int i]=>Value[i];

public static A046174Inst Instance=new A046174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046175
{
public static readonly BigInteger[] Value={ 0L,1L,20L,285L,3976L,55385L,771420L,10744501L,149651600L,2084377905L,29031639076L,404358569165L,5631988329240L,78443478040201L,1092576704233580L,15217630381229925L,211954248632985376L,2952141850480565345L,BigInteger.Parse("41118031658094929460"),BigInteger.Parse("572700301362848447101") };
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
public class A046175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046175Inst Instance=new A046175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046176
{
public static readonly BigInteger[] Value={ 1L,35L,1189L,40391L,1372105L,46611179L,1583407981L,53789260175L,1827251437969L,62072759630771L,2108646576008245L,71631910824649559L,2433376321462076761L,BigInteger.Parse("82663163018885960315"),BigInteger.Parse("2808114166320660573949") };
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
public class A046176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046176Inst Instance=new A046176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046177
{
public static readonly BigInteger[] Value={ 1L,1225L,1413721L,1631432881L,1882672131025L,2172602007770041L,2507180834294496361L,BigInteger.Parse("2893284510173841030625"),BigInteger.Parse("3338847817559778254844961"),BigInteger.Parse("3853027488179473932250054441"),BigInteger.Parse("4446390382511295358038307980025"),BigInteger.Parse("5131130648390546663702275158894481") };
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
public class A046177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046177Inst Instance=new A046177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046178
{
public static readonly BigInteger[] Value={ 1L,165L,31977L,6203341L,1203416145L,233456528757L,45289363162681L,8785902997031325L,1704419892060914337L,BigInteger.Parse("330648673156820350021"),BigInteger.Parse("64144138172531086989705"),BigInteger.Parse("12443632156797874055652717"),BigInteger.Parse("2414000494280615035709637361"),BigInteger.Parse("468303652258282519053613995285") };
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
public class A046178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046178Inst Instance=new A046178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046179
{
public static readonly BigInteger[] Value={ 1L,143L,27693L,5372251L,1042188953L,202179284583L,39221739020101L,7608815190614963L,1476070925240282673L,BigInteger.Parse("286350150681424223551"),BigInteger.Parse("55550453161271059086173"),BigInteger.Parse("10776501563135904038493963"),BigInteger.Parse("2090585752795204112408742601"),BigInteger.Parse("405562859540706461903257570583") };
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
public class A046179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046179Inst Instance=new A046179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046180
{
public static readonly BigInteger[] Value={ 1L,40755L,1533776805L,57722156241751L,2172315626468283465L,BigInteger.Parse("81752926228785223683195"),BigInteger.Parse("3076689623521787481625080301"),BigInteger.Parse("115788137209866023854693048367775"),BigInteger.Parse("4357570752679408318225730700647767185"),BigInteger.Parse("163992817590548715438241125333485021875651") };
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
public class A046180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046180Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046180.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046180.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046180Inst Instance=new A046180Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046181
{
public static readonly BigInteger[] Value={ 1L,3L,63L,261L,6141L,25543L,601723L,2502921L,58962681L,245260683L,5777740983L,24033043981L,566159653621L,2354993049423L,55477868313843L,230765285799441L,5436264935102961L,22612643015295763L,532698485771776303L,2215808250213185301L,BigInteger.Parse("52199015340698974701") };
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
public class A046181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046181Inst Instance=new A046181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046182
{
public static readonly long[] Value={ 1L,6L,153L,638L,15041L,62566L,1473913L,6130878L,144428481L,600763526L,14152517273L,58868694718L,1386802264321L,5768531318886L,135892469386233L,565257200556158L,13316075197586561L,55389437123184646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046182Inst : IEnumerable<long>
{
public static readonly long[] Value=A046182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046182.Bytes);
public long this[int i]=>Value[i];

public static A046182Inst Instance=new A046182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046183
{
public static readonly BigInteger[] Value={ 1L,21L,11781L,203841L,113123361L,1957283461L,1086210502741L,18793835590881L,10429793134197921L,180458407386358101L,BigInteger.Parse("100146872588357936901"),BigInteger.Parse("1732761608929974897121"),BigInteger.Parse("961610260163619775927681"),BigInteger.Parse("16637976788487211575799941"),BigInteger.Parse("9233381617944204500099658261"),BigInteger.Parse("159757851390292596620856138561") };
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
public class A046183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046183Inst Instance=new A046183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046184
{
public static readonly BigInteger[] Value={ 1L,9L,121L,1681L,23409L,326041L,4541161L,63250209L,880961761L,12270214441L,170902040409L,2380358351281L,33154114877521L,461777249934009L,6431727384198601L,89582406128846401L,1247721958419651009L,17378525011746267721UL,BigInteger.Parse("242051628206028097081") };
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
public class A046184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046184Inst Instance=new A046184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046185
{
public static readonly long[] Value={ 1L,2L,4L,8L,13L,21L,31L,45L,66L,81L,97L,123L,148L,182L,204L,252L,291L,324L,352L,415L,486L,540L,651L,706L,781L,864L,963L,1003L,1148L,1217L,1371L,1409L,1523L,1673L,1974L,2105L,2191L,2317L,2496L,2652L,2726L,2858L,3219L,3268L,3500L,3605L,3864L,3962L,4237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046185Inst : IEnumerable<long>
{
public static readonly long[] Value=A046185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046185.Bytes);
public long this[int i]=>Value[i];

public static A046185Inst Instance=new A046185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046186
{
public static readonly long[] Value={ 793234063L,793234067L,793234111L,793234139L,793234153L,793234171L,793234177L,793234193L,793234207L,793234243L,793234261L,793234289L,793234333L,793234357L,793234391L,793234427L,793234441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A046186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046186Inst : IEnumerable<long>
{
public static readonly long[] Value=A046186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A046186.Bytes);
public long this[int i]=>Value[i];

public static A046186Inst Instance=new A046186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A046187
{
public static readonly BigInteger[] Value={ 1L,11L,1025L,12507L,1182657L,14432875L,1364784961L,16655525051L,1574960662145L,19220461475787L,1817503239330177L,22180395887532955L,2097397163226361921L,BigInteger.Parse("25596157633751554091"),BigInteger.Parse("2420394508859982326465"),BigInteger.Parse("29537943728953405887867"),BigInteger.Parse("2793133165827256378378497") };
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
public class A046187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A046187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A046187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A046187.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A046187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A046187Inst Instance=new A046187Inst();

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