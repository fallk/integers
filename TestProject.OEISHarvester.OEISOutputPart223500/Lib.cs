using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A261882
{
public static readonly long[] Value={ 1L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261882Inst : IEnumerable<long>
{
public static readonly long[] Value=A261882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261882.Bytes);
public long this[int i]=>Value[i];

public static A261882Inst Instance=new A261882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261883
{
public static readonly long[] Value={ 2L,0L,6L,2L,9L,9L,4L,7L,4L,0L,1L,5L,9L,0L,0L,2L,6L,2L,6L,2L,4L,1L,4L,7L,1L,8L,0L,3L,6L,3L,8L,4L,5L,8L,6L,9L,8L,0L,4L,2L,5L,3L,3L,3L,6L,0L,5L,0L,0L,7L,3L,4L,9L,5L,0L,9L,5L,8L,5L,7L,1L,1L,9L,0L,8L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261883Inst : IEnumerable<long>
{
public static readonly long[] Value=A261883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261883.Bytes);
public long this[int i]=>Value[i];

public static A261883Inst Instance=new A261883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261884
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,0L,1L,2L,-1L,-1L,0L,0L,-1L,2L,-2L,0L,1L,0L,1L,2L,0L,-2L,0L,0L,1L,1L,-2L,-1L,2L,0L,0L,2L,-1L,0L,0L,0L,-1L,2L,-2L,-2L,0L,0L,2L,2L,0L,0L,0L,0L,-1L,3L,-1L,0L,2L,0L,1L,0L,-2L,-2L,0L,0L,0L,2L,-2L,-2L,1L,0L,0L,2L,0L,0L,0L,0L,1L,2L,-2L,-1L,2L,0L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261884Inst : IEnumerable<long>
{
public static readonly long[] Value=A261884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261884.Bytes);
public long this[int i]=>Value[i];

public static A261884Inst Instance=new A261884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261885
{
public static readonly BigInteger[] Value={ 0L,3L,-6L,33L,-288L,3240L,-41328L,538776L,-6772608L,108502848L,-3985200000L,160423053120L,-1094935449600L,-334098799856640L,6171528273039360L,2583214608931891200L,BigInteger.Parse("-150276838897808179200"),BigInteger.Parse("-27910708844766496358400"),BigInteger.Parse("3428432556793417713254400"),BigInteger.Parse("462153194693572097337753600"),BigInteger.Parse("-107869378361311784037187584000") };
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
public class A261885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261885Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261885.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261885.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261885Inst Instance=new A261885Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261886
{
public static readonly BigInteger[] Value={ 0L,1L,-2L,11L,-96L,1080L,-13776L,179592L,-2257536L,36167616L,-1328400000L,53474351040L,-364978483200L,-111366266618880L,2057176091013120L,861071536310630400L,BigInteger.Parse("-50092279632602726400"),BigInteger.Parse("-9303569614922165452800"),BigInteger.Parse("1142810852264472571084800"),BigInteger.Parse("154051064897857365779251200"),BigInteger.Parse("-35956459453770594679062528000") };
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
public class A261886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261886.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261886Inst Instance=new A261886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261887
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,2L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,2L,2L,3L,0L,3L,1L,2L,2L,1L,2L,2L,0L,2L,1L,2L,2L,2L,0L,1L,2L,3L,3L,1L,1L,1L,4L,3L,0L,3L,1L,3L,3L,0L,1L,2L,1L,3L,2L,1L,2L,3L,1L,3L,1L,3L,3L,2L,2L,0L,4L,2L,1L,2L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261887Inst : IEnumerable<long>
{
public static readonly long[] Value=A261887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261887.Bytes);
public long this[int i]=>Value[i];

public static A261887Inst Instance=new A261887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261888
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,16L,18L,21L,26L,27L,32L,37L,45L,51L,61L,66L,82L,108L,127L,178L,186L,192L,234L,252L,276L,306L,332L,336L,351L,402L,468L,582L,606L,612L,622L,642L,666L,702L,712L,738L,762L,798L,816L,822L,864L,882L,906L,930L,996L,1018L,1032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261888Inst : IEnumerable<long>
{
public static readonly long[] Value=A261888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261888.Bytes);
public long this[int i]=>Value[i];

public static A261888Inst Instance=new A261888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261889
{
public static readonly long[] Value={ 577L,1297L,7057L,14401L,41617L,90001L,147457L,156817L,484417L,746497L,1299601L,1742401L,2702737L,2944657L,4260097L,5308417L,6051601L,6780817L,8785297L,10497601L,14107537L,15210001L,16451137L,17438977L,18147601L,29419777L,38937601L,45968401L,51322897L,56791297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261889Inst : IEnumerable<long>
{
public static readonly long[] Value=A261889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261889.Bytes);
public long this[int i]=>Value[i];

public static A261889Inst Instance=new A261889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261890
{
public static readonly long[] Value={ 2L,4L,-8L,16L,-24L,20L,-7L,10L,-31L,32L,-24L,40L,-26L,-16L,-2L,34L,-36L,38L,2L,-20L,-46L,68L,-23L,26L,-52L,26L,-29L,28L,0L,32L,2L,-32L,0L,-36L,-2L,112L,-74L,-40L,-2L,40L,0L,44L,-43L,46L,-139L,140L,-47L,0L,51L,-102L,-2L,106L,2L,-110L,112L,-56L,-118L,176L,-120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261890Inst : IEnumerable<long>
{
public static readonly long[] Value=A261890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261890.Bytes);
public long this[int i]=>Value[i];

public static A261890Inst Instance=new A261890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261891
{
public static readonly long[] Value={ 2L,2L,4L,2L,2L,4L,8L,2L,2L,2L,12L,4L,10L,8L,16L,2L,2L,2L,4L,2L,2L,12L,24L,4L,4L,10L,12L,8L,10L,16L,32L,2L,2L,2L,4L,2L,2L,4L,40L,2L,2L,2L,12L,12L,10L,24L,48L,4L,4L,4L,4L,10L,34L,12L,56L,8L,18L,10L,12L,16L,42L,32L,64L,2L,2L,2L,4L,2L,2L,4L,8L,2L,2L,2L,12L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261891Inst : IEnumerable<long>
{
public static readonly long[] Value=A261891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261891.Bytes);
public long this[int i]=>Value[i];

public static A261891Inst Instance=new A261891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261892
{
public static readonly long[] Value={ 2L,4L,12L,8L,10L,24L,56L,16L,18L,20L,132L,48L,130L,112L,240L,32L,34L,36L,76L,40L,42L,264L,552L,96L,100L,260L,324L,224L,290L,480L,992L,64L,66L,68L,140L,72L,74L,152L,1560L,80L,82L,84L,516L,528L,450L,1104L,2256L,192L,196L,200L,204L,520L,1802L,648L,3080L,448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261892Inst : IEnumerable<long>
{
public static readonly long[] Value=A261892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261892.Bytes);
public long this[int i]=>Value[i];

public static A261892Inst Instance=new A261892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261893
{
public static readonly long[] Value={ 1L,7L,23L,55L,109L,191L,307L,463L,665L,919L,1231L,1607L,2053L,2575L,3179L,3871L,4657L,5543L,6535L,7639L,8861L,10207L,11683L,13295L,15049L,16951L,19007L,21223L,23605L,26159L,28891L,31807L,34913L,38215L,41719L,45431L,49357L,53503L,57875L,62479L,67321L,72407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261893Inst : IEnumerable<long>
{
public static readonly long[] Value=A261893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261893.Bytes);
public long this[int i]=>Value[i];

public static A261893Inst Instance=new A261893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261894
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,42L,131L,425L,1405L,4768L,16355L,57112L,200908L,715945L,2563950L,9275069L,33670472L,123183827L,451968108L,1668602686L,6173397451L,22959862085L,85535398344L,320037864300L,1199162682255L,4509735549128L,16979368985245L,64134400212097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261894Inst : IEnumerable<long>
{
public static readonly long[] Value=A261894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261894.Bytes);
public long this[int i]=>Value[i];

public static A261894Inst Instance=new A261894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261895
{
public static readonly long[] Value={ 2L,2L,5L,6L,5L,2L,9L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261895Inst : IEnumerable<long>
{
public static readonly long[] Value=A261895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261895.Bytes);
public long this[int i]=>Value[i];

public static A261895Inst Instance=new A261895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261896
{
public static readonly long[] Value={ 3L,5L,11L,25L,43L,89L,179L,361L,727L,1459L,2921L,5843L,11689L,23383L,46769L,93543L,187093L,374193L,748391L,1496785L,2993575L,5987157L,11974321L,23948647L,47897299L,95794607L,191589221L,383178449L,766356903L,1532713827L,3065427663L,6130855333L,12261710675L,24523421357L,49046842723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261896Inst : IEnumerable<long>
{
public static readonly long[] Value=A261896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261896.Bytes);
public long this[int i]=>Value[i];

public static A261896Inst Instance=new A261896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261897
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,0L,2L,3L,1L,0L,2L,5L,4L,1L,0L,0L,7L,9L,5L,1L,0L,0L,7L,16L,14L,6L,1L,0L,0L,7L,23L,30L,20L,7L,1L,0L,0L,7L,30L,53L,50L,27L,8L,1L,0L,0L,7L,37L,83L,103L,77L,35L,9L,1L,0L,0L,0L,44L,120L,186L,180L,112L,44L,10L,1L,0L,0L,0L,44L,164L,306L,366L,292L,156L,54L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261897Inst : IEnumerable<long>
{
public static readonly long[] Value=A261897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261897.Bytes);
public long this[int i]=>Value[i];

public static A261897Inst Instance=new A261897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261898
{
public static readonly BigInteger[] Value={ 1L,1L,4L,25L,210L,2205L,27720L,405405L,6756750L,126351225L,2618916300L,59580345825L,1475759335050L,39529267903125L,1138442915610000L,35078272337233125L,1151392703775063750L,BigInteger.Parse("40106845848164720625"),BigInteger.Parse("1477620636511331812500"),BigInteger.Parse("57405561728465240915625") };
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
public class A261898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261898Inst Instance=new A261898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261899
{
public static readonly BigInteger[] Value={ 1L,1L,5L,36L,340L,3955L,54495L,866250L,15585570L,312837525L,6926344425L,167610643200L,4399779384000L,124490841049575L,3776362727011875L,122240308063623750L,4205265824898888750L,BigInteger.Parse("153199195863404315625"),BigInteger.Parse("5891484566433038698125"),BigInteger.Parse("238487970732928954537500") };
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
public class A261899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261899.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261899Inst Instance=new A261899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261900
{
public static readonly BigInteger[] Value={ 1L,1L,6L,48L,496L,6251L,92638L,1574650L,30150120L,641425785L,14999294310L,382187185380L,10535027302800L,312263647871175L,9901291024374750L,334357521973224750L,11978152435322073000UL,BigInteger.Parse("453670047374482063125"),BigInteger.Parse("18110938144465399983750"),BigInteger.Parse("759996114581823934815000") };
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
public class A261900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261900Inst Instance=new A261900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261901
{
public static readonly BigInteger[] Value={ 1L,1L,7L,61L,679L,9150L,144186L,2594410L,52390030L,1171745575L,28726923225L,765549820035L,22022976400425L,679930906554900L,22417065396425700L,785869955615745000L,BigInteger.Parse("29184350973268491000"),BigInteger.Parse("1144300243940081353125"),BigInteger.Parse("47232865043365173046875"),BigInteger.Parse("2047016588845893645605625") };
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
public class A261901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261901Inst Instance=new A261901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261902
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,6L,2L,6L,2L,2L,24L,8L,4L,8L,4L,2L,120L,12L,8L,4L,20L,2L,2L,720L,72L,48L,8L,8L,12L,6L,2L,5040L,144L,48L,16L,8L,4L,42L,4L,2L,40320L,1152L,144L,128L,16L,8L,12L,23L,6L,2L,362880L,2880L,1296L,96L,64L,16L,8L,8L,54L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261902Inst : IEnumerable<long>
{
public static readonly long[] Value=A261902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261902.Bytes);
public long this[int i]=>Value[i];

public static A261902Inst Instance=new A261902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261903
{
public static readonly long[] Value={ 3L,4L,5L,10L,29L,0L,10L,0L,224L,3L,3L,0L,10L,11L,23L,32L,34L,35L,38L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261903Inst : IEnumerable<long>
{
public static readonly long[] Value=A261903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261903.Bytes);
public long this[int i]=>Value[i];

public static A261903Inst Instance=new A261903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261904
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,-1L,2L,3L,3L,3L,2L,3L,3L,-1L,4L,4L,4L,3L,4L,4L,3L,-1L,4L,5L,5L,5L,-1L,5L,5L,-1L,4L,5L,5L,5L,6L,6L,6L,-1L,6L,6L,5L,5L,6L,6L,6L,-1L,4L,7L,7L,7L,6L,7L,7L,-1L,6L,7L,7L,7L,-1L,6L,7L,-1L,8L,8L,8L,7L,8L,8L,6L,-1L,8L,8L,8L,7L,6L,8L,7L,-1L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261904Inst : IEnumerable<long>
{
public static readonly long[] Value=A261904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261904.Bytes);
public long this[int i]=>Value[i];

public static A261904Inst Instance=new A261904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261905
{
public static readonly long[] Value={ 1L,2L,5L,6L,8L,9L,11L,14L,17L,19L,22L,24L,29L,34L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261905Inst : IEnumerable<long>
{
public static readonly long[] Value=A261905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261905.Bytes);
public long this[int i]=>Value[i];

public static A261905Inst Instance=new A261905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261906
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,112L,113L,114L,115L,116L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261906Inst : IEnumerable<long>
{
public static readonly long[] Value=A261906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261906.Bytes);
public long this[int i]=>Value[i];

public static A261906Inst Instance=new A261906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261907
{
public static readonly long[] Value={ 10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,23L,24L,25L,26L,27L,28L,29L,30L,31L,34L,35L,36L,37L,38L,39L,40L,41L,42L,45L,46L,47L,48L,49L,50L,51L,52L,53L,56L,57L,58L,59L,60L,61L,62L,63L,64L,67L,68L,69L,70L,71L,72L,73L,74L,75L,78L,79L,80L,81L,82L,83L,84L,85L,86L,89L,90L,91L,92L,93L,94L,95L,96L,97L,100L,102L,103L,104L,105L,106L,107L,108L,109L,110L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261907Inst : IEnumerable<long>
{
public static readonly long[] Value=A261907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261907.Bytes);
public long this[int i]=>Value[i];

public static A261907Inst Instance=new A261907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261908
{
public static readonly long[] Value={ 9L,90L,99L,180L,189L,270L,279L,360L,369L,450L,459L,540L,549L,630L,639L,720L,729L,810L,819L,900L,990L,999L,1089L,1179L,1269L,1359L,1449L,1539L,1629L,1719L,1728L,1800L,1809L,1908L,1980L,2079L,2088L,2268L,2358L,2448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261908Inst : IEnumerable<long>
{
public static readonly long[] Value=A261908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261908.Bytes);
public long this[int i]=>Value[i];

public static A261908Inst Instance=new A261908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261909
{
public static readonly long[] Value={ 1L,10L,11L,20L,21L,30L,31L,40L,41L,50L,51L,60L,61L,70L,71L,80L,81L,90L,91L,100L,110L,111L,121L,131L,141L,151L,161L,171L,181L,191L,192L,200L,201L,212L,220L,231L,232L,252L,262L,272L,282L,292L,293L,300L,302L,312L,313L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261909Inst : IEnumerable<long>
{
public static readonly long[] Value=A261909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261909.Bytes);
public long this[int i]=>Value[i];

public static A261909Inst Instance=new A261909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261910
{
public static readonly long[] Value={ 21L,32L,43L,54L,65L,76L,87L,98L,201L,1031L,1041L,1042L,1051L,1052L,1053L,1061L,1062L,1063L,1064L,1071L,1072L,1073L,1074L,1075L,1081L,1082L,1083L,1084L,1085L,1086L,1091L,1092L,1093L,1094L,1095L,1096L,1097L,1101L,1103L,1104L,1105L,1106L,1107L,1108L,1109L,1123L,1124L,1125L,1126L,1127L,1128L,1129L,1134L,1135L,1136L,1137L,1138L,1139L,1145L,1146L,1147L,1148L,1149L,1153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261910Inst : IEnumerable<long>
{
public static readonly long[] Value=A261910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261910.Bytes);
public long this[int i]=>Value[i];

public static A261910Inst Instance=new A261910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261911
{
public static readonly long[] Value={ 1099L,1143L,1154L,1165L,1176L,1187L,1198L,1209L,1264L,1275L,1286L,1297L,1308L,1319L,1385L,1396L,1407L,1418L,1429L,1517L,1528L,1539L,1638L,1649L,1759L,10099L,10155L,10199L,10299L,10366L,10399L,10499L,10577L,10599L,10699L,10799L,11809L,12819L,13829L,14839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261911Inst : IEnumerable<long>
{
public static readonly long[] Value=A261911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261911.Bytes);
public long this[int i]=>Value[i];

public static A261911Inst Instance=new A261911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261912
{
public static readonly long[] Value={ 101073L,101082L,101100L,101155L,101199L,102192L,102299L,103275L,103293L,103366L,103399L,103502L,104332L,104342L,104352L,104362L,104372L,104382L,104392L,104499L,104602L,105432L,105442L,105452L,105462L,105472L,105482L,105492L,105493L,105544L,105577L,105599L,105702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261912Inst : IEnumerable<long>
{
public static readonly long[] Value=A261912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261912.Bytes);
public long this[int i]=>Value[i];

public static A261912Inst Instance=new A261912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261913
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261913Inst : IEnumerable<long>
{
public static readonly long[] Value=A261913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261913.Bytes);
public long this[int i]=>Value[i];

public static A261913Inst Instance=new A261913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261914
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,9L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,33L,33L,33L,33L,33L,33L,33L,33L,33L,33L,33L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261914Inst : IEnumerable<long>
{
public static readonly long[] Value=A261914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261914.Bytes);
public long this[int i]=>Value[i];

public static A261914Inst Instance=new A261914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261915
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,-1L,2L,2L,3L,3L,2L,3L,3L,-1L,4L,3L,3L,3L,4L,4L,3L,-1L,4L,4L,4L,3L,-1L,4L,5L,-1L,4L,4L,4L,5L,4L,6L,5L,-1L,6L,4L,5L,5L,6L,5L,6L,-1L,4L,6L,5L,5L,6L,6L,5L,-1L,6L,5L,7L,5L,-1L,6L,6L,-1L,8L,6L,5L,7L,6L,7L,6L,-1L,6L,6L,7L,5L,6L,6L,7L,-1L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261915Inst : IEnumerable<long>
{
public static readonly long[] Value=A261915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261915.Bytes);
public long this[int i]=>Value[i];

public static A261915Inst Instance=new A261915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261916
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,11L,11L,11L,11L,22L,11L,22L,22L,22L,22L,22L,22L,22L,22L,22L,33L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,44L,22L,33L,33L,33L,33L,33L,33L,33L,33L,33L,55L,22L,33L,33L,33L,33L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261916Inst : IEnumerable<long>
{
public static readonly long[] Value=A261916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261916.Bytes);
public long this[int i]=>Value[i];

public static A261916Inst Instance=new A261916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261917
{
public static readonly long[] Value={ 5L,7L,8L,9L,10L,13L,14L,15L,16L,19L,20L,21L,22L,25L,27L,28L,29L,30L,32L,33L,34L,35L,37L,38L,39L,40L,42L,43L,44L,45L,47L,48L,49L,50L,53L,54L,55L,56L,58L,59L,60L,61L,63L,64L,65L,66L,68L,69L,70L,71L,73L,74L,75L,76L,77L,79L,80L,81L,82L,84L,85L,86L,87L,89L,90L,91L,92L,94L,95L,96L,97L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261917Inst : IEnumerable<long>
{
public static readonly long[] Value=A261917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261917.Bytes);
public long this[int i]=>Value[i];

public static A261917Inst Instance=new A261917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261918
{
public static readonly long[] Value={ 11L,17L,23L,51L,131L,141L,146L,147L,149L,151L,153L,154L,163L,164L,169L,173L,175L,177L,179L,181L,184L,185L,194L,195L,199L,200L,201L,203L,205L,206L,211L,215L,221L,225L,226L,229L,231L,236L,237L,241L,251L,259L,261L,262L,263L,266L,267L,271L,281L,287L,289L,291L,296L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261918Inst : IEnumerable<long>
{
public static readonly long[] Value=A261918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261918.Bytes);
public long this[int i]=>Value[i];

public static A261918Inst Instance=new A261918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261919
{
public static readonly BigInteger[] Value={ 0L,0L,1L,3L,11L,62L,510L,7459L,197867L,9808968L,902893994L,153723380584L,48443158427276L,28363698856991892L,BigInteger.Parse("30996526139142442460"),BigInteger.Parse("63502034434187094606966"),BigInteger.Parse("244852545450108200518282934"),BigInteger.Parse("1783161611521019613186341526720"),BigInteger.Parse("24603891216946828886755056314074748") };
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
public class A261919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261919Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261919.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261919.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261919Inst Instance=new A261919Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261920
{
public static readonly long[] Value={ 10L,109L,110L,113L,114L,115L,116L,117L,118L,119L,120L,124L,125L,126L,127L,128L,129L,130L,135L,136L,137L,138L,139L,140L,146L,147L,148L,149L,150L,157L,158L,159L,160L,168L,169L,170L,179L,180L,190L,211L,221L,231L,241L,251L,261L,271L,281L,291L,302L,312L,322L,332L,342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261920Inst : IEnumerable<long>
{
public static readonly long[] Value=A261920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261920.Bytes);
public long this[int i]=>Value[i];

public static A261920Inst Instance=new A261920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261921
{
public static readonly long[] Value={ 12L,13L,14L,15L,16L,17L,18L,19L,20L,23L,24L,25L,26L,27L,28L,29L,30L,31L,34L,35L,36L,37L,38L,39L,40L,41L,42L,45L,46L,47L,48L,49L,50L,51L,52L,53L,56L,57L,58L,59L,60L,61L,62L,63L,64L,67L,68L,69L,70L,71L,72L,73L,74L,75L,78L,79L,80L,81L,82L,83L,84L,85L,86L,89L,90L,91L,92L,93L,94L,95L,96L,97L,100L,101L,102L,103L,104L,105L,106L,107L,108L,112L,122L,123L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261921Inst : IEnumerable<long>
{
public static readonly long[] Value=A261921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261921.Bytes);
public long this[int i]=>Value[i];

public static A261921Inst Instance=new A261921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261922
{
public static readonly long[] Value={ 1L,0L,3L,0L,3L,3L,4L,0L,3L,3L,3L,4L,5L,4L,4L,0L,3L,3L,3L,5L,3L,3L,4L,4L,5L,5L,4L,4L,5L,4L,4L,0L,3L,3L,3L,5L,3L,3L,5L,5L,3L,3L,3L,4L,7L,4L,4L,4L,5L,5L,5L,5L,7L,4L,4L,4L,5L,5L,4L,4L,5L,4L,4L,0L,3L,3L,3L,5L,3L,3L,5L,5L,3L,3L,3L,6L,5L,7L,5L,5L,3L,3L,3L,6L,3L,3L,4L,4L,7L,7L,4L,4L,8L,4L,4L,4L,5L,5L,5L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261922Inst : IEnumerable<long>
{
public static readonly long[] Value=A261922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261922.Bytes);
public long this[int i]=>Value[i];

public static A261922Inst Instance=new A261922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261923
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,2L,3L,1L,2L,2L,2L,3L,3L,3L,3L,1L,2L,2L,2L,3L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,3L,2L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,4L,3L,2L,3L,3L,2L,2L,2L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261923Inst : IEnumerable<long>
{
public static readonly long[] Value=A261923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261923.Bytes);
public long this[int i]=>Value[i];

public static A261923Inst Instance=new A261923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261924
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,22L,33L,44L,55L,66L,77L,88L,99L,110L,121L,132L,143L,154L,165L,176L,187L,198L,202L,212L,222L,232L,242L,252L,262L,272L,282L,292L,302L,303L,312L,313L,322L,323L,332L,333L,342L,343L,352L,353L,362L,363L,372L,373L,382L,383L,393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261924Inst : IEnumerable<long>
{
public static readonly long[] Value=A261924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261924.Bytes);
public long this[int i]=>Value[i];

public static A261924Inst Instance=new A261924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261925
{
public static readonly long[] Value={ 10L,12L,13L,14L,15L,16L,17L,18L,110L,132L,143L,154L,165L,176L,187L,198L,302L,312L,322L,332L,342L,352L,362L,372L,382L,403L,413L,423L,433L,443L,453L,463L,473L,483L,504L,514L,524L,534L,544L,554L,564L,574L,584L,605L,615L,625L,635L,645L,655L,665L,675L,685L,706L,716L,726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261925Inst : IEnumerable<long>
{
public static readonly long[] Value=A261925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261925.Bytes);
public long this[int i]=>Value[i];

public static A261925Inst Instance=new A261925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261926
{
public static readonly long[] Value={ 3L,3L,3L,6L,3L,3L,6L,9L,5L,6L,5L,7L,9L,5L,6L,3L,3L,6L,9L,5L,7L,5L,9L,3L,5L,3L,6L,3L,3L,6L,10L,6L,7L,7L,9L,5L,5L,5L,7L,7L,5L,5L,9L,9L,9L,5L,6L,3L,3L,6L,9L,5L,6L,5L,7L,10L,6L,7L,3L,6L,9L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261926Inst : IEnumerable<long>
{
public static readonly long[] Value=A261926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261926.Bytes);
public long this[int i]=>Value[i];

public static A261926Inst Instance=new A261926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261927
{
public static readonly long[] Value={ 0L,1L,2L,5L,3L,8L,11L,18L,13L,12L,16L,34L,28L,31L,37L,63L,50L,56L,44L,88L,59L,83L,73L,129L,93L,91L,100L,138L,105L,103L,123L,195L,151L,173L,169L,303L,201L,199L,219L,345L,255L,256L,298L,442L,341L,274L,289L,482L,380L,294L,255L,525L,401L,410L,270L,539L,422L,487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261927Inst : IEnumerable<long>
{
public static readonly long[] Value=A261927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261927.Bytes);
public long this[int i]=>Value[i];

public static A261927Inst Instance=new A261927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261928
{
public static readonly long[] Value={ 1L,3L,6L,8L,15L,18L,28L,28L,36L,45L,66L,48L,91L,84L,90L,96L,153L,108L,190L,120L,168L,198L,276L,168L,275L,273L,297L,224L,435L,270L,496L,368L,396L,459L,420L,288L,703L,570L,546L,420L,861L,504L,946L,528L,540L,828L,1128L,576L,1078L,825L,918L,728L,1431L,891L,990L,784L,1140L,1305L,1770L,720L,1891L,1488L,1008L,1408L,1365L,1188L,2278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261928Inst : IEnumerable<long>
{
public static readonly long[] Value=A261928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261928.Bytes);
public long this[int i]=>Value[i];

public static A261928Inst Instance=new A261928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261929
{
public static readonly long[] Value={ 0L,1L,3L,8L,10L,18L,21L,36L,45L,55L,55L,96L,78L,112L,135L,160L,136L,216L,171L,280L,273L,286L,253L,408L,350L,403L,432L,560L,406L,630L,465L,656L,693L,697L,805L,1008L,666L,874L,975L,1180L,820L,1260L,903L,1408L,1485L,1288L,1081L,1728L,1323L,1675L,1683L,1976L,1378L,2025L,2035L,2352L,2109L,2059L,1711L,2880L,1830L,2356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261929Inst : IEnumerable<long>
{
public static readonly long[] Value=A261929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261929.Bytes);
public long this[int i]=>Value[i];

public static A261929Inst Instance=new A261929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261930
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,22L,44L,88L,176L,352L,697L,1394L,2788L,5576L,11152L,22304L,44608L,89172L,178344L,356688L,713376L,1426752L,2853504L,5707008L,11414016L,22828032L,45655636L,91311272L,182622544L,365245088L,730490176L,1460980352L,2921960704L,5843921408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261930Inst : IEnumerable<long>
{
public static readonly long[] Value=A261930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261930.Bytes);
public long this[int i]=>Value[i];

public static A261930Inst Instance=new A261930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261931
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,20L,16L,5L,22L,7L,28L,14L,34L,11L,40L,13L,46L,26L,52L,17L,58L,19L,64L,38L,70L,23L,76L,25L,82L,50L,88L,29L,94L,31L,100L,62L,106L,35L,112L,37L,118L,74L,124L,41L,130L,43L,136L,86L,142L,47L,148L,49L,154L,98L,160L,53L,166L,55L,172L,110L,178L,59L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261931Inst : IEnumerable<long>
{
public static readonly long[] Value=A261931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261931.Bytes);
public long this[int i]=>Value[i];

public static A261931Inst Instance=new A261931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261932
{
public static readonly long[] Value={ 26L,48L,68L,126L,468L,866L,1226L,2268L,8406L,15548L,22008L,40706L,150848L,279006L,394926L,730448L,2706866L,5006568L,7086668L,13107366L,48572748L,89839226L,127165106L,235202148L,871602606L,1612099508L,2281885248L,4220531306L,15640274168L,28927951926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261932Inst : IEnumerable<long>
{
public static readonly long[] Value=A261932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261932.Bytes);
public long this[int i]=>Value[i];

public static A261932Inst Instance=new A261932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261933
{
public static readonly long[] Value={ 40L,91L,2743L,6364L,192004L,445423L,13437571L,31173280L,940438000L,2181684211L,65817222463L,152686721524L,4606265134444L,10685888822503L,322372742188651L,747859530853720L,22561485688071160L,52339481270937931L,1578981625422792583L,3663015829434801484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261933Inst : IEnumerable<long>
{
public static readonly long[] Value=A261933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261933.Bytes);
public long this[int i]=>Value[i];

public static A261933Inst Instance=new A261933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261934
{
public static readonly long[] Value={ 7L,17L,26L,52L,205L,383L,544L,1010L,3755L,6949L,9838L,18200L,67457L,124771L,176612L,326662L,1210543L,2239001L,3169250L,5861788L,21722389L,40177319L,56869960L,105185594L,389792531L,720952813L,1020490102L,1887478976L,6994543241L,12936973387L,18311951948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261934Inst : IEnumerable<long>
{
public static readonly long[] Value=A261934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261934.Bytes);
public long this[int i]=>Value[i];

public static A261934Inst Instance=new A261934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261935
{
public static readonly long[] Value={ 5L,23L,933L,2175L,65849L,152771L,4609041L,10692339L,322567565L,748311503L,22575121053L,52371113415L,1579935906689L,3665229628091L,110572938347721L,256513702853499L,7738525748434325L,17952293970117383L,541586229452055573L,1256404064205363855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261935Inst : IEnumerable<long>
{
public static readonly long[] Value=A261935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261935.Bytes);
public long this[int i]=>Value[i];

public static A261935Inst Instance=new A261935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261936
{
public static readonly long[] Value={ 0L,2L,218L,7943L,5488030L,1247810761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261936Inst : IEnumerable<long>
{
public static readonly long[] Value=A261936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261936.Bytes);
public long this[int i]=>Value[i];

public static A261936Inst Instance=new A261936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261937
{
public static readonly long[] Value={ 0L,2L,5L,12L,31L,57L,112L,296L,833L,1889L,5015L,11625L,30782L,80154L,202448L,526705L,1410549L,3698903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261937Inst : IEnumerable<long>
{
public static readonly long[] Value=A261937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261937.Bytes);
public long this[int i]=>Value[i];

public static A261937Inst Instance=new A261937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261938
{
public static readonly long[] Value={ 10L,61L,218L,1878L,9350L,57243L,352480L,2438528L,15405064L,102528319L,707008477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261938Inst : IEnumerable<long>
{
public static readonly long[] Value=A261938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261938.Bytes);
public long this[int i]=>Value[i];

public static A261938Inst Instance=new A261938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261939
{
public static readonly long[] Value={ 0L,147L,746L,7943L,50994L,367390L,2840132L,26703908L,234458622L,2153468514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261939Inst : IEnumerable<long>
{
public static readonly long[] Value=A261939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261939.Bytes);
public long this[int i]=>Value[i];

public static A261939Inst Instance=new A261939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261940
{
public static readonly long[] Value={ 46L,1215L,10906L,351513L,5488030L,115507073L,2499416567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261940Inst : IEnumerable<long>
{
public static readonly long[] Value=A261940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261940.Bytes);
public long this[int i]=>Value[i];

public static A261940Inst Instance=new A261940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261941
{
public static readonly long[] Value={ 0L,5826L,72186L,3016874L,52973290L,1247810761L,30673550964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261941Inst : IEnumerable<long>
{
public static readonly long[] Value=A261941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261941.Bytes);
public long this[int i]=>Value[i];

public static A261941Inst Instance=new A261941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261942
{
public static readonly long[] Value={ 0L,0L,0L,10L,2L,0L,0L,61L,5L,0L,46L,147L,218L,12L,0L,0L,1215L,746L,1878L,31L,0L,202L,5826L,10906L,7943L,9350L,57L,0L,415L,28021L,72186L,351513L,50994L,57243L,112L,0L,852L,110420L,588090L,3016874L,5488030L,367390L,352480L,296L,0L,1739L,527295L,3656900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261942Inst : IEnumerable<long>
{
public static readonly long[] Value=A261942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261942.Bytes);
public long this[int i]=>Value[i];

public static A261942Inst Instance=new A261942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261943
{
public static readonly long[] Value={ 0L,0L,10L,0L,46L,0L,202L,415L,852L,1739L,3532L,0L,14484L,29256L,58994L,0L,239144L,0L,966551L,1941541L,3898357L,7824445L,15699345L,31490743L,63151055L,126614175L,253804613L,508678162L,1019341796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261943Inst : IEnumerable<long>
{
public static readonly long[] Value=A261943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261943.Bytes);
public long this[int i]=>Value[i];

public static A261943Inst Instance=new A261943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261944
{
public static readonly long[] Value={ 0L,2L,61L,147L,1215L,5826L,28021L,110420L,527295L,2326284L,9514894L,38982570L,165423942L,702887228L,2961470604L,11652281882L,46921585497L,193805455945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261944Inst : IEnumerable<long>
{
public static readonly long[] Value=A261944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261944.Bytes);
public long this[int i]=>Value[i];

public static A261944Inst Instance=new A261944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261945
{
public static readonly long[] Value={ 0L,5L,218L,746L,10906L,72186L,588090L,3656900L,26647829L,180803752L,1093944096L,6533839983L,43705331783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261945Inst : IEnumerable<long>
{
public static readonly long[] Value=A261945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261945.Bytes);
public long this[int i]=>Value[i];

public static A261945Inst Instance=new A261945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261946
{
public static readonly long[] Value={ 0L,12L,1878L,7943L,351513L,3016874L,64650845L,773758878L,10301327801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261946Inst : IEnumerable<long>
{
public static readonly long[] Value=A261946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261946.Bytes);
public long this[int i]=>Value[i];

public static A261946Inst Instance=new A261946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261947
{
public static readonly long[] Value={ 0L,31L,9350L,50994L,5488030L,52973290L,2828445617L,58321826870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261947Inst : IEnumerable<long>
{
public static readonly long[] Value=A261947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261947.Bytes);
public long this[int i]=>Value[i];

public static A261947Inst Instance=new A261947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261948
{
public static readonly long[] Value={ 0L,57L,57243L,367390L,115507073L,1247810761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261948Inst : IEnumerable<long>
{
public static readonly long[] Value=A261948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261948.Bytes);
public long this[int i]=>Value[i];

public static A261948Inst Instance=new A261948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261949
{
public static readonly long[] Value={ 0L,112L,352480L,2840132L,2499416567L,30673550964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261949Inst : IEnumerable<long>
{
public static readonly long[] Value=A261949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261949.Bytes);
public long this[int i]=>Value[i];

public static A261949Inst Instance=new A261949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261950
{
public static readonly long[] Value={ 1L,3L,9L,12L,30L,18L,45L,27L,66L,33L,81L,42L,102L,48L,117L,57L,138L,63L,153L,72L,174L,78L,189L,87L,210L,93L,225L,102L,246L,108L,261L,117L,282L,123L,297L,132L,318L,138L,333L,147L,354L,153L,369L,162L,390L,168L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261950Inst : IEnumerable<long>
{
public static readonly long[] Value=A261950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261950.Bytes);
public long this[int i]=>Value[i];

public static A261950Inst Instance=new A261950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261951
{
public static readonly long[] Value={ 1L,3L,9L,12L,24L,24L,39L,27L,54L,33L,69L,42L,84L,54L,99L,57L,114L,63L,129L,72L,144L,84L,159L,87L,174L,93L,189L,102L,204L,114L,219L,117L,234L,123L,249L,132L,264L,144L,279L,147L,294L,153L,309L,162L,324L,174L,339L,177L,354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261951Inst : IEnumerable<long>
{
public static readonly long[] Value=A261951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261951.Bytes);
public long this[int i]=>Value[i];

public static A261951Inst Instance=new A261951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261952
{
public static readonly long[] Value={ 1L,3L,9L,18L,18L,24L,27L,33L,36L,42L,45L,51L,54L,60L,63L,69L,72L,78L,81L,87L,90L,96L,99L,105L,108L,114L,117L,123L,126L,132L,135L,141L,144L,150L,153L,159L,162L,168L,171L,177L,180L,186L,189L,195L,198L,204L,207L,213L,216L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261952Inst : IEnumerable<long>
{
public static readonly long[] Value=A261952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261952.Bytes);
public long this[int i]=>Value[i];

public static A261952Inst Instance=new A261952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261953
{
public static readonly long[] Value={ 1L,3L,9L,12L,18L,21L,27L,30L,36L,39L,45L,48L,54L,57L,63L,66L,72L,75L,81L,84L,90L,93L,99L,102L,108L,111L,117L,120L,126L,129L,135L,138L,144L,147L,153L,156L,162L,165L,171L,174L,180L,183L,189L,192L,198L,201L,207L,210L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261953Inst : IEnumerable<long>
{
public static readonly long[] Value=A261953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261953.Bytes);
public long this[int i]=>Value[i];

public static A261953Inst Instance=new A261953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261954
{
public static readonly long[] Value={ 1L,3L,3L,6L,12L,15L,21L,18L,30L,27L,39L,30L,48L,39L,57L,42L,66L,51L,75L,54L,84L,63L,93L,66L,102L,75L,111L,78L,120L,87L,129L,90L,138L,99L,147L,102L,156L,111L,165L,114L,174L,123L,183L,126L,192L,135L,201L,138L,210L,147L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261954Inst : IEnumerable<long>
{
public static readonly long[] Value=A261954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261954.Bytes);
public long this[int i]=>Value[i];

public static A261954Inst Instance=new A261954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261955
{
public static readonly long[] Value={ 1L,3L,6L,15L,12L,24L,15L,33L,21L,45L,39L,72L,36L,78L,39L,87L,45L,99L,63L,126L,60L,132L,63L,141L,69L,153L,87L,180L,84L,186L,87L,195L,93L,207L,111L,234L,108L,240L,111L,249L,117L,261L,135L,288L,132L,294L,135L,303L,141L,315L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261955Inst : IEnumerable<long>
{
public static readonly long[] Value=A261955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261955.Bytes);
public long this[int i]=>Value[i];

public static A261955Inst Instance=new A261955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261956
{
public static readonly long[] Value={ 1L,3L,6L,9L,12L,18L,15L,21L,21L,36L,39L,54L,36L,54L,39L,57L,45L,72L,63L,90L,60L,90L,63L,93L,69L,108L,87L,126L,84L,126L,87L,129L,93L,144L,111L,162L,108L,162L,111L,165L,117L,180L,135L,198L,132L,198L,135L,201L,141L,216L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261956Inst : IEnumerable<long>
{
public static readonly long[] Value=A261956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261956.Bytes);
public long this[int i]=>Value[i];

public static A261956Inst Instance=new A261956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261957
{
public static readonly long[] Value={ 1L,3L,9L,12L,24L,12L,24L,18L,36L,33L,57L,45L,81L,36L,78L,42L,90L,57L,111L,69L,135L,60L,132L,66L,144L,81L,165L,93L,189L,84L,186L,90L,198L,105L,219L,117L,243L,108L,240L,114L,252L,129L,273L,141L,297L,132L,294L,138L,306L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261957Inst : IEnumerable<long>
{
public static readonly long[] Value=A261957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261957.Bytes);
public long this[int i]=>Value[i];

public static A261957Inst Instance=new A261957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261958
{
public static readonly long[] Value={ 1L,4L,12L,16L,24L,32L,28L,36L,32L,44L,44L,56L,56L,72L,60L,76L,64L,84L,76L,96L,88L,112L,92L,116L,96L,124L,108L,136L,120L,152L,124L,156L,128L,164L,140L,176L,152L,192L,156L,196L,160L,204L,172L,216L,184L,232L,188L,236L,192L,244L,204L,256L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261958Inst : IEnumerable<long>
{
public static readonly long[] Value=A261958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261958.Bytes);
public long this[int i]=>Value[i];

public static A261958Inst Instance=new A261958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261959
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,1L,13L,1L,1L,1L,7L,75L,1L,1L,1L,7L,21L,541L,1L,1L,1L,7L,9L,81L,4683L,1L,1L,1L,7L,9L,31L,793L,47293L,1L,1L,1L,7L,9L,31L,403L,4929L,545835L,1L,1L,1L,7L,9L,31L,403L,1597L,33029L,7087261L,1L,1L,1L,7L,9L,31L,403L,757L,7913L,388537L,102247563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261959Inst : IEnumerable<long>
{
public static readonly long[] Value=A261959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261959.Bytes);
public long this[int i]=>Value[i];

public static A261959Inst Instance=new A261959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261960
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,3L,8L,1L,1L,1L,3L,4L,16L,1L,1L,1L,3L,3L,7L,32L,1L,1L,1L,3L,3L,5L,14L,64L,1L,1L,1L,3L,3L,5L,11L,23L,128L,1L,1L,1L,3L,3L,5L,11L,15L,39L,256L,1L,1L,1L,3L,3L,5L,11L,13L,23L,71L,512L,1L,1L,1L,3L,3L,5L,11L,13L,19L,37L,124L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261960Inst : IEnumerable<long>
{
public static readonly long[] Value=A261960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261960.Bytes);
public long this[int i]=>Value[i];

public static A261960Inst Instance=new A261960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261961
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,9L,31L,403L,1597L,7913L,68551L,539691L,4359037L,48419715L,560648557L,4985097601L,59798395027L,869794249513L,11143895125527L,159575614945315L,2593765421983597L,38615447492264219L,642012651525487501L,11768461266053785921UL,BigInteger.Parse("220201814964135821967") };
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
public class A261961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261961Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261961.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261961.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261961Inst Instance=new A261961Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261962
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,5L,11L,15L,23L,37L,67L,101L,165L,265L,419L,691L,1123L,1789L,2909L,4657L,7515L,12183L,19657L,31635L,51101L,82449L,132989L,214623L,346485L,558587L,901399L,1454949L,2347157L,3787197L,6111131L,9858931L,15908393L,25669125L,41416849L,66826277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261962Inst : IEnumerable<long>
{
public static readonly long[] Value=A261962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261962.Bytes);
public long this[int i]=>Value[i];

public static A261962Inst Instance=new A261962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261963
{
public static readonly long[] Value={ 2L,3L,6L,23L,31L,35L,65L,59L,95L,131L,173L,233L,203L,239L,257L,299L,317L,323L,473L,443L,635L,563L,671L,719L,809L,701L,779L,839L,803L,1109L,971L,1049L,1139L,1343L,1103L,1409L,1433L,1607L,1481L,1499L,1559L,1523L,1769L,1679L,1643L,2069L,2063L,2309L,2111L,2141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261963Inst : IEnumerable<long>
{
public static readonly long[] Value=A261963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261963.Bytes);
public long this[int i]=>Value[i];

public static A261963Inst Instance=new A261963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261964
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,6L,56L,56L,6L,24L,1712L,9408L,1712L,24L,120L,92800L,4948992L,4948992L,92800L,120L,720L,7918592L,6085088256L,63352393728L,6085088256L,7918592L,720L,5040L,984237056L,14782316470272L,2472100837326848L,2472100837326848L,14782316470272L,984237056L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261964Inst : IEnumerable<long>
{
public static readonly long[] Value=A261964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261964.Bytes);
public long this[int i]=>Value[i];

public static A261964Inst Instance=new A261964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261965
{
public static readonly BigInteger[] Value={ 1L,101L,10103L,10103011L,10103011013L,1010301101309L,10103011013090003L,BigInteger.Parse("101030110130900030009"),BigInteger.Parse("10103011013090003000903"),BigInteger.Parse("1010301101309000300090303"),BigInteger.Parse("1010301101309000300090303009"),BigInteger.Parse("1010301101309000300090303009059"),BigInteger.Parse("1010301101309000300090303009059061") };
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
public class A261965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261965Inst Instance=new A261965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261966
{
public static readonly BigInteger[] Value={ 1L,101L,101001L,101001011L,1010010110001L,1010010110001011L,BigInteger.Parse("101001011000101100101"),BigInteger.Parse("10100101100010110010100101"),BigInteger.Parse("101001011000101100101001010001"),BigInteger.Parse("101001011000101100101001010001000011"),BigInteger.Parse("10100101100010110010100101000100001101111") };
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
public class A261966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261966.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261966Inst Instance=new A261966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261967
{
public static readonly long[] Value={ 2L,151L,3061L,9517861L,11903341L,15344551L,15460771L,19975771L,37935091L,42234271L,52312411L,199938421L,228523501L,237049321L,270798991L,315266641L,315522931L,327445201L,354600601L,423223741L,466801171L,498309631L,499063711L,547916791L,585381361L,621504721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261967Inst : IEnumerable<long>
{
public static readonly long[] Value=A261967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261967.Bytes);
public long this[int i]=>Value[i];

public static A261967Inst Instance=new A261967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261968
{
public static readonly long[] Value={ 1L,-2L,4L,-8L,14L,-22L,36L,-56L,84L,-126L,184L,-264L,376L,-528L,732L,-1008L,1374L,-1856L,2492L,-3320L,4394L,-5784L,7568L,-9848L,12756L,-16442L,21096L,-26960L,34312L,-43500L,54956L,-69184L,86804L,-108576L,135392L,-168336L,208722L,-258096L,318320L,-391632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261968Inst : IEnumerable<long>
{
public static readonly long[] Value=A261968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261968.Bytes);
public long this[int i]=>Value[i];

public static A261968Inst Instance=new A261968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261969
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,2L,3L,10L,11L,2L,13L,14L,15L,2L,17L,3L,19L,2L,21L,22L,23L,2L,5L,26L,3L,2L,29L,30L,31L,2L,33L,34L,35L,6L,37L,38L,39L,2L,41L,42L,43L,2L,3L,46L,47L,2L,7L,5L,51L,2L,53L,3L,55L,2L,57L,58L,59L,2L,61L,62L,3L,2L,65L,66L,67L,2L,69L,70L,71L,2L,73L,74L,5L,2L,77L,78L,79L,2L,3L,82L,83L,2L,85L,86L,87L,2L,89L,3L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261969Inst : IEnumerable<long>
{
public static readonly long[] Value=A261969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261969.Bytes);
public long this[int i]=>Value[i];

public static A261969Inst Instance=new A261969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261970
{
public static readonly long[] Value={ 0L,60L,240L,13308L,52992L,53052L,53196L,3195132L,3208140L,3346188L,12795648L,12795900L,871563264L,871563312L,871563456L,871576368L,871576380L,871576524L,871615728L,871616268L,871616448L,1072939776L,1072939788L,1072939824L,3225157884L,3472949196L,3473670912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261970Inst : IEnumerable<long>
{
public static readonly long[] Value=A261970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261970.Bytes);
public long this[int i]=>Value[i];

public static A261970Inst Instance=new A261970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261971
{
public static readonly long[] Value={ 8L,26L,98L,218L,602L,866L,1538L,1946L,2906L,4706L,5402L,7778L,9602L,10586L,12698L,16226L,20186L,21602L,26138L,29402L,31106L,36506L,40346L,46466L,55298L,60002L,62426L,67418L,69986L,75266L,95258L,101402L,110978L,114266L,131426L,135002L,146018L,157466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261971Inst : IEnumerable<long>
{
public static readonly long[] Value=A261971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261971.Bytes);
public long this[int i]=>Value[i];

public static A261971Inst Instance=new A261971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261972
{
public static readonly BigInteger[] Value={ 25L,361L,5041L,70225L,978121L,13623481L,189750625L,2642885281L,36810643321L,512706121225L,7141075053841L,99462344632561L,1385331749802025L,19295182152595801L,268747218386539201L,3743165875258953025L,BigInteger.Parse("52135575035238803161"),BigInteger.Parse("726154884618084291241") };
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
public class A261972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261972Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261972.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261972.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261972Inst Instance=new A261972Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261973
{
public static readonly BigInteger[] Value={ 137L,6341L,291593L,13406981L,616429577L,28342353605L,1303131836297L,59915722116101L,2754820085504393L,126661808211086021L,5823688357624452617L,BigInteger.Parse("267763002642513734405"),BigInteger.Parse("12311274433198007330057"),BigInteger.Parse("566050860924465823448261"),BigInteger.Parse("26026028328092229871289993") };
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
public class A261973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261973Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261973.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261973.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261973Inst Instance=new A261973Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261974
{
public static readonly BigInteger[] Value={ 67L,3307L,152275L,7001563L,321919843L,14801311435L,680538406387L,31289965382587L,1438657869192835L,66146972017488043L,3041322054935257363L,BigInteger.Parse("139834667555004350875"),BigInteger.Parse("6429353385475264883107"),BigInteger.Parse("295610421064307180272267"),BigInteger.Parse("13591650015572655027641395") };
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
public class A261974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261974Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261974.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261974.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261974Inst Instance=new A261974Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261975
{
public static readonly long[] Value={ 1L,-8L,48L,-224L,864L,-2928L,9024L,-25792L,69312L,-176936L,432288L,-1016736L,2312832L,-5107504L,10983552L,-23060544L,47373696L,-95401872L,188637936L,-366744160L,701930304L,-1324016896L,2463662016L,-4526174784L,8216376576L,-14747939768L,26191413024L,-46048199360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261975Inst : IEnumerable<long>
{
public static readonly long[] Value=A261975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261975.Bytes);
public long this[int i]=>Value[i];

public static A261975Inst Instance=new A261975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261976
{
public static readonly long[] Value={ 1L,8L,16L,-32L,-96L,368L,960L,-3392L,-8896L,31528L,82656L,-292704L,-767616L,2719024L,7130496L,-25257408L,-66235776L,234616720L,615265872L,-2179359392L,-5715218752L,20244124928L,53088812352L,-188048196544L,-493143336192L,1746784492472L,4580821023328L,-16225925666624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261976Inst : IEnumerable<long>
{
public static readonly long[] Value=A261976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261976.Bytes);
public long this[int i]=>Value[i];

public static A261976Inst Instance=new A261976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261977
{
public static readonly long[] Value={ 1L,-4L,16L,-48L,112L,-248L,576L,-1248L,2272L,-3988L,8672L,-18192L,23616L,-23000L,100992L,-304032L,41152L,970552L,1972816L,-11299824L,-9904096L,80729472L,95978688L,-676487328L,-755649408L,5483063076L,6371808608L,-45452602080L,-53224627584L,378628636264L,449486486400L,-3179963494272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261977Inst : IEnumerable<long>
{
public static readonly long[] Value=A261977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261977.Bytes);
public long this[int i]=>Value[i];

public static A261977Inst Instance=new A261977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261978
{
public static readonly long[] Value={ 1L,-2L,6L,-12L,14L,-24L,84L,-144L,-42L,130L,1656L,-3036L,-9036L,17784L,76944L,-147984L,-591274L,1147068L,4784922L,-9277164L,-38983272L,75690528L,322116804L,-625832880L,-2687394012L,5224589254L,22613921832L,-43985741688L,-191670898032L,372970548504L,1634759644944L,-3182191744320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261978Inst : IEnumerable<long>
{
public static readonly long[] Value=A261978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261978.Bytes);
public long this[int i]=>Value[i];

public static A261978Inst Instance=new A261978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261979
{
public static readonly long[] Value={ 1L,4L,0L,-16L,16L,120L,-128L,-928L,1056L,7572L,-8960L,-63408L,77248L,540504L,-672000L,-4665824L,5888832L,40656072L,-51913728L,-356835664L,459890400L,3150052992L,-4090609024L,-27939033312L,36509767552L,248772971228L,-326815190784L,-2222432164768L,2932886151552L,19910399315736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261979Inst : IEnumerable<long>
{
public static readonly long[] Value=A261979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261979.Bytes);
public long this[int i]=>Value[i];

public static A261979Inst Instance=new A261979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261980
{
public static readonly long[] Value={ 1L,2L,-2L,-4L,14L,24L,-92L,-176L,694L,1342L,-5480L,-10612L,44532L,86408L,-369328L,-717616L,3109078L,6046724L,-26473950L,-51523620L,227477656L,442950880L,-1969014572L,-3835720208L,17147433572L,33415180858L,-150096433272L,-292574352808L,1319581377424L,2572787175656L,-11644937717296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261980Inst : IEnumerable<long>
{
public static readonly long[] Value=A261980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261980.Bytes);
public long this[int i]=>Value[i];

public static A261980Inst Instance=new A261980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261981
{
public static readonly long[] Value={ 1L,1L,4L,1L,9L,2L,18L,3L,41L,8L,2L,89L,16L,4L,185L,34L,10L,388L,57L,10L,810L,113L,30L,6L,1670L,213L,52L,12L,3435L,396L,104L,28L,7040L,733L,176L,50L,14360L,1333L,278L,62L,29226L,2419L,512L,152L,24L,59347L,4400L,878L,246L,48L,120229L,7934L,1492L,458L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261981Inst : IEnumerable<long>
{
public static readonly long[] Value=A261981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261981.Bytes);
public long this[int i]=>Value[i];

public static A261981Inst Instance=new A261981Inst();

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