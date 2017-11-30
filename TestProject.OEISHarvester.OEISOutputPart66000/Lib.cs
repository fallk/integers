using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A093881
{
public static readonly long[] Value={ 0L,1L,11L,31L,311L,421L,4211L,7211L,7411L,8421L,84211L,105211L,1052111L,1152211L,1163211L,1563211L,15632111L,16832111L,168321111L,188421111L,189431111L,199432111L,1994321111L,2304321111L,2306321111L,2406322111L,2436322111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093881Inst : IEnumerable<long>
{
public static readonly long[] Value=A093881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093881.Bytes);
public long this[int i]=>Value[i];

public static A093881Inst Instance=new A093881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093882
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,8L,9L,10L,11L,12L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093882Inst : IEnumerable<long>
{
public static readonly long[] Value=A093882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093882.Bytes);
public long this[int i]=>Value[i];

public static A093882Inst Instance=new A093882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093883
{
public static readonly BigInteger[] Value={ 1L,3L,60L,12600L,38102400L,2112397056000L,2609908810629120000L,BigInteger.Parse("84645606509847871488000000"),BigInteger.Parse("82967862872337478796810649600000000"),BigInteger.Parse("2781259372192376861719959017613164544000000000") };
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
public class A093883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093883Inst Instance=new A093883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093884
{
public static readonly BigInteger[] Value={ 6L,3024L,2874009600L,BigInteger.Parse("159950125679984640000"),BigInteger.Parse("20708778572935434707683938140160000000"),BigInteger.Parse("302101709923756073800654275737927385319576932502732800000000000") };
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
public class A093884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093884.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093884Inst Instance=new A093884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093885
{
public static readonly BigInteger[] Value={ 0L,0L,5L,60L,876L,15820L,342490L,8659697L,250596841L,8170355939L,296392500231L,11842341000706L,516766134975841L,24454542316972336L,1247414741568401188L,BigInteger.Parse("68231675778495540368"),BigInteger.Parse("3983959314088980184276"),BigInteger.Parse("247324089280835008754847") };
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
public class A093885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093885Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093885.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093885.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093885Inst Instance=new A093885Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093886
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,16L,18L,26L,32L,40L,48L,60L,68L,80L,92L,108L,124L,136L,154L,172L,192L,208L,228L,252L,272L,296L,320L,344L,368L,394L,420L,452L,484L,512L,544L,580L,616L,648L,686L,724L,764L,800L,840L,880L,922L,964L,1008L,1050L,1096L,1144L,1192L,1240L,1288L,1340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093886Inst : IEnumerable<long>
{
public static readonly long[] Value=A093886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093886.Bytes);
public long this[int i]=>Value[i];

public static A093886Inst Instance=new A093886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093887
{
public static readonly BigInteger[] Value={ 1L,1L,2L,140L,105L,840840L,51051L,79755701025L,143400750442950L,BigInteger.Parse("122535439350874224675"),BigInteger.Parse("46705681584242830001657805"),BigInteger.Parse("65358008635496174751045143339993779875") };
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
public class A093887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093887Inst Instance=new A093887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093888
{
public static readonly long[] Value={ 1L,2L,6L,8L,8L,9L,252L,252L,252L,48384L,48384L,48384L,48384L,525525L,525525L,525525L,595595L,595595L,969969L,969969L,969969L,405909504L,5273993725L,5273993725L,5273993725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093888Inst : IEnumerable<long>
{
public static readonly long[] Value=A093888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093888.Bytes);
public long this[int i]=>Value[i];

public static A093888Inst Instance=new A093888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093889
{
public static readonly long[] Value={ 1L,1L,1L,3L,15L,80L,20L,160L,1440L,75L,825L,9900L,128700L,165888L,2488320L,39813120L,597196800L,10749542400L,125411328000L,2508226560000L,52672757760000L,2769091920000L,4901791334400L,117642992025600L,2941074800640000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093889Inst : IEnumerable<long>
{
public static readonly long[] Value=A093889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093889.Bytes);
public long this[int i]=>Value[i];

public static A093889Inst Instance=new A093889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093890
{
public static readonly long[] Value={ 0L,2L,1L,4L,1L,5L,1L,6L,2L,7L,1L,9L,1L,5L,4L,11L,1L,12L,1L,13L,5L,5L,1L,17L,2L,5L,4L,16L,1L,20L,1L,18L,4L,6L,6L,24L,1L,5L,5L,24L,1L,24L,1L,18L,11L,5L,1L,30L,1L,15L,3L,18L,1L,30L,6L,30L,5L,7L,1L,39L,1L,3L,18L,31L,6L,34L,1L,16L,3L,34L,1L,44L,1L,4L,13L,16L,4L,39L,1L,42L,5L,5L,1L,48L,5L,5L,2L,41L,1L,51L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093890Inst : IEnumerable<long>
{
public static readonly long[] Value=A093890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093890.Bytes);
public long this[int i]=>Value[i];

public static A093890Inst Instance=new A093890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093891
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,16L,18L,20L,24L,28L,30L,32L,36L,40L,42L,48L,54L,56L,60L,64L,66L,70L,72L,78L,80L,84L,88L,90L,96L,100L,104L,108L,112L,120L,126L,128L,132L,140L,144L,150L,156L,160L,162L,168L,176L,180L,192L,196L,198L,200L,204L,208L,210L,216L,220L,224L,228L,234L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093891Inst : IEnumerable<long>
{
public static readonly long[] Value=A093891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093891.Bytes);
public long this[int i]=>Value[i];

public static A093891Inst Instance=new A093891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093940
{
public static readonly BigInteger[] Value={ 47L,47777L,47777777777777L,BigInteger.Parse("47777777777777777777777777"),BigInteger.Parse("4777777777777777777777777777777777777") };
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
public class A093940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093940Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093940.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093940.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093940Inst Instance=new A093940Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093941
{
public static readonly BigInteger[] Value={ 5L,577L,577777777L,577777777777777L,577777777777777777L,5777777777777777777L,BigInteger.Parse("5777777777777777777777777777777777"),BigInteger.Parse("577777777777777777777777777777777777") };
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
public class A093941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093941Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093941.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093941.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093941Inst Instance=new A093941Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093942
{
public static readonly BigInteger[] Value={ 67L,677L,67777L,67777777777L,67777777777777L,BigInteger.Parse("67777777777777777777777777"),BigInteger.Parse("67777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777") };
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
public class A093942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093942Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093942.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093942.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093942Inst Instance=new A093942Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093943
{
public static readonly BigInteger[] Value={ 877L,8777777777L,8777777777777777L,BigInteger.Parse("877777777777777777777777777777777"),BigInteger.Parse("877777777777777777777777777777777777777"),BigInteger.Parse("877777777777777777777777777777777777777777777777777777777777777777") };
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
public class A093943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093943Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093943.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093943.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093943Inst Instance=new A093943Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093944
{
public static readonly BigInteger[] Value={ 97L,977L,97777L,BigInteger.Parse("97777777777777777777"),BigInteger.Parse("97777777777777777777777777777"),BigInteger.Parse("97777777777777777777777777777777777777777777777777777777777777777777777777") };
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
public class A093944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093944Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093944.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093944.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093944Inst Instance=new A093944Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093945
{
public static readonly BigInteger[] Value={ 499L,4999L,49999L,4999999L,499999999999999L,BigInteger.Parse("4999999999999999999999999999999999999999999999999999999") };
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
public class A093945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093945Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093945.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093945.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093945Inst Instance=new A093945Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093946
{
public static readonly BigInteger[] Value={ 5L,59L,599L,59999L,599999L,59999999L,59999999999L,59999999999999L,BigInteger.Parse("59999999999999999999999"),BigInteger.Parse("599999999999999999999999"),BigInteger.Parse("59999999999999999999999999999"),BigInteger.Parse("59999999999999999999999999999999999") };
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
public class A093946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093946Inst Instance=new A093946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093947
{
public static readonly BigInteger[] Value={ 7L,79L,79999L,799999L,799999999L,79999999999L,BigInteger.Parse("79999999999999999999999999"),BigInteger.Parse("79999999999999999999999999999999999999999999999999"),BigInteger.Parse("79999999999999999999999999999999999999999999999999999999999999999999999999999") };
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
public class A093947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093947.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093947Inst Instance=new A093947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093948
{
public static readonly BigInteger[] Value={ 89L,8999L,89999999L,BigInteger.Parse("89999999999999999999"),BigInteger.Parse("899999999999999999999999999999"),BigInteger.Parse("89999999999999999999999999999999999999"),BigInteger.Parse("8999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999") };
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
public class A093948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093948Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093948.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093948.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093948Inst Instance=new A093948Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093949
{
public static readonly long[] Value={ 1L,1L,2L,-2L,0L,-3L,1L,-5L,-3L,0L,2L,1L,-3L,1L,5L,0L,5L,5L,2L,0L,-5L,11L,-3L,-2L,0L,6L,0L,-7L,-13L,0L,-3L,5L,0L,-10L,0L,-1L,-6L,0L,-7L,5L,-7L,6L,7L,-3L,0L,9L,10L,-7L,0L,0L,1L,9L,5L,6L,0L,0L,19L,-10L,11L,0L,-6L,-10L,-7L,-2L,10L,9L,0L,-2L,-11L,0L,-11L,-11L,15L,-7L,0L,-11L,-6L,-20L,0L,0L,9L,0L,-3L,0L,0L,-5L,5L,-2L,1L,-10L,-7L,14L,0L,-11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093949Inst : IEnumerable<long>
{
public static readonly long[] Value=A093949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093949.Bytes);
public long this[int i]=>Value[i];

public static A093949Inst Instance=new A093949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093950
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,6L,7L,9L,12L,14L,18L,22L,28L,34L,41L,50L,60L,72L,86L,105L,124L,146L,174L,204L,240L,282L,332L,386L,450L,524L,606L,703L,812L,940L,1082L,1243L,1428L,1636L,1873L,2140L,2448L,2788L,3172L,3610L,4096L,4646L,5264L,5962L,6736L,7606L,8582L,9666L,10884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093950Inst : IEnumerable<long>
{
public static readonly long[] Value=A093950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093950.Bytes);
public long this[int i]=>Value[i];

public static A093950Inst Instance=new A093950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093951
{
public static readonly long[] Value={ 1L,2L,4L,8L,17L,36L,80L,176L,403L,910L,2128L,4896L,11628L,27132L,65208L,153824L,373175L,888030L,2170740L,5202600L,12797265L,30853680L,76292736L,184863168L,459162452L,1117370696L,2786017120L,6804995008L,17024247304L,41717833740L,104673837384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093951Inst : IEnumerable<long>
{
public static readonly long[] Value=A093951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093951.Bytes);
public long this[int i]=>Value[i];

public static A093951Inst Instance=new A093951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093952
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,5L,1L,6L,3L,2L,1L,5L,10L,9L,11L,7L,8L,7L,15L,7L,15L,12L,13L,15L,8L,18L,13L,22L,12L,24L,22L,29L,12L,2L,8L,13L,29L,23L,24L,18L,16L,2L,8L,23L,34L,34L,16L,9L,16L,26L,39L,9L,6L,1L,1L,31L,36L,22L,38L,47L,20L,16L,51L,62L,28L,56L,24L,59L,17L,38L,58L,55L,34L,4L,39L,67L,23L,44L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093952Inst : IEnumerable<long>
{
public static readonly long[] Value=A093952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093952.Bytes);
public long this[int i]=>Value[i];

public static A093952Inst Instance=new A093952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093953
{
public static readonly long[] Value={ 1L,10L,63L,344L,1781L,9030L,45403L,227524L,1138641L,5695250L,28480343L,142409904L,712065901L,3560362270L,17801876883L,89009515484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093953Inst : IEnumerable<long>
{
public static readonly long[] Value=A093953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093953.Bytes);
public long this[int i]=>Value[i];

public static A093953Inst Instance=new A093953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093954
{
public static readonly long[] Value={ 1L,1L,1L,0L,7L,2L,0L,7L,3L,4L,5L,3L,9L,5L,9L,1L,5L,6L,1L,7L,5L,3L,9L,7L,0L,2L,4L,7L,5L,1L,5L,1L,7L,3L,4L,2L,4L,6L,5L,3L,6L,5L,5L,4L,2L,2L,3L,4L,3L,9L,2L,2L,5L,5L,5L,7L,7L,1L,3L,4L,8L,9L,0L,1L,7L,3L,9L,1L,0L,8L,6L,9L,8L,2L,7L,4L,8L,6L,8L,4L,7L,7L,6L,4L,3L,8L,3L,1L,7L,3L,3L,6L,9L,1L,1L,9L,1L,3L,0L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093954Inst : IEnumerable<long>
{
public static readonly long[] Value=A093954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093954.Bytes);
public long this[int i]=>Value[i];

public static A093954Inst Instance=new A093954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093955
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,1L,2L,0L,0L,1L,0L,0L,1L,1L,1L,2L,1L,0L,0L,1L,0L,0L,1L,1L,1L,2L,0L,0L,1L,0L,0L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,0L,0L,1L,0L,0L,1L,1L,1L,2L,0L,0L,1L,0L,0L,1L,1L,1L,2L,1L,0L,0L,1L,0L,0L,1L,1L,1L,2L,0L,0L,1L,0L,0L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093955Inst : IEnumerable<long>
{
public static readonly long[] Value=A093955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093955.Bytes);
public long this[int i]=>Value[i];

public static A093955Inst Instance=new A093955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093988
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,35L,45L,47L,57L,87L,183L,325L,367L,447L,809L,1157L,2789L,5775L,14829L,20687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093988Inst : IEnumerable<long>
{
public static readonly long[] Value=A093988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093988.Bytes);
public long this[int i]=>Value[i];

public static A093988Inst Instance=new A093988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093989
{
public static readonly long[] Value={ 1L,1L,6L,35L,290L,2714L,27524L,291073L,3166124L,35169275L,397047529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093989Inst : IEnumerable<long>
{
public static readonly long[] Value=A093989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093989.Bytes);
public long this[int i]=>Value[i];

public static A093989Inst Instance=new A093989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093990
{
public static readonly long[] Value={ 1L,2L,8L,68L,550L,5404L,54768L,581868L,6329407L,70335294L,794064734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093990Inst : IEnumerable<long>
{
public static readonly long[] Value=A093990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093990.Bytes);
public long this[int i]=>Value[i];

public static A093990Inst Instance=new A093990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093991
{
public static readonly long[] Value={ 1L,0L,4L,2L,30L,24L,280L,278L,2841L,3256L,30324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093991Inst : IEnumerable<long>
{
public static readonly long[] Value=A093991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093991.Bytes);
public long this[int i]=>Value[i];

public static A093991Inst Instance=new A093991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093992
{
public static readonly long[] Value={ 0L,1L,2L,33L,260L,2690L,27244L,290795L,3163283L,35166019L,397017205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093992Inst : IEnumerable<long>
{
public static readonly long[] Value=A093992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093992.Bytes);
public long this[int i]=>Value[i];

public static A093992Inst Instance=new A093992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093993
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,0L,3L,2L,2L,0L,2L,0L,3L,3L,2L,1L,3L,2L,1L,1L,3L,1L,4L,0L,3L,2L,2L,2L,3L,0L,2L,1L,3L,1L,5L,1L,2L,2L,2L,1L,4L,2L,4L,1L,2L,0L,2L,2L,4L,1L,3L,0L,6L,1L,1L,3L,3L,2L,3L,1L,2L,2L,5L,0L,3L,0L,2L,3L,3L,2L,2L,0L,4L,1L,2L,1L,6L,2L,2L,2L,2L,1L,4L,1L,3L,1L,3L,1L,5L,0L,5L,2L,5L,1L,4L,0L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093993Inst : IEnumerable<long>
{
public static readonly long[] Value=A093993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093993.Bytes);
public long this[int i]=>Value[i];

public static A093993Inst Instance=new A093993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093994
{
public static readonly long[] Value={ 14L,21L,25L,49L,58L,94L,98L,115L,122L,166L,201L,203L,205L,274L,278L,287L,302L,319L,335L,346L,382L,386L,427L,445L,454L,458L,469L,517L,526L,562L,566L,575L,623L,634L,667L,674L,685L,706L,737L,746L,755L,791L,818L,841L,854L,865L,913L,917L,922L,926L,955L,959L,973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093994Inst : IEnumerable<long>
{
public static readonly long[] Value=A093994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093994.Bytes);
public long this[int i]=>Value[i];

public static A093994Inst Instance=new A093994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093995
{
public static readonly long[] Value={ 1L,4L,4L,9L,9L,9L,16L,16L,16L,16L,25L,25L,25L,25L,25L,36L,36L,36L,36L,36L,36L,49L,49L,49L,49L,49L,49L,49L,64L,64L,64L,64L,64L,64L,64L,64L,81L,81L,81L,81L,81L,81L,81L,81L,81L,100L,100L,100L,100L,100L,100L,100L,100L,100L,100L,121L,121L,121L,121L,121L,121L,121L,121L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093995Inst : IEnumerable<long>
{
public static readonly long[] Value=A093995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093995.Bytes);
public long this[int i]=>Value[i];

public static A093995Inst Instance=new A093995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093996
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,1L,0L,0L,1L,-1L,0L,0L,1L,-1L,-1L,1L,0L,0L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,0L,0L,0L,1L,-1L,-1L,0L,1L,0L,0L,1L,0L,-1L,-1L,1L,0L,0L,0L,0L,0L,0L,1L,-1L,-1L,0L,1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,-1L,0L,1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,-1L,0L,1L,0L,0L,1L,-1L,0L,0L,1L,-1L,-1L,1L,0L,0L,0L,1L,-1L,-1L,1L,0L,0L,-1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093996Inst : IEnumerable<long>
{
public static readonly long[] Value=A093996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093996.Bytes);
public long this[int i]=>Value[i];

public static A093996Inst Instance=new A093996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093997
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,1L,0L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,3L,1L,2L,2L,1L,2L,2L,2L,2L,0L,2L,2L,1L,3L,2L,3L,2L,1L,3L,2L,2L,3L,1L,2L,3L,2L,3L,1L,2L,2L,0L,3L,2L,2L,3L,2L,3L,3L,2L,4L,2L,2L,4L,1L,3L,3L,2L,4L,2L,3L,3L,1L,3L,3L,3L,4L,1L,3L,3L,1L,4L,2L,2L,2L,1L,3L,2L,2L,4L,2L,3L,4L,2L,4L,3L,3L,5L,1L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093997Inst : IEnumerable<long>
{
public static readonly long[] Value=A093997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093997.Bytes);
public long this[int i]=>Value[i];

public static A093997Inst Instance=new A093997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093998
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,1L,2L,1L,2L,1L,2L,1L,0L,2L,2L,2L,2L,1L,2L,2L,1L,3L,1L,1L,2L,1L,2L,2L,2L,3L,1L,2L,3L,1L,3L,2L,2L,3L,1L,3L,2L,1L,3L,2L,2L,2L,1L,2L,2L,2L,4L,1L,3L,3L,1L,4L,3L,3L,3L,1L,3L,3L,2L,4L,2L,3L,3L,1L,4L,2L,2L,4L,2L,3L,3L,2L,3L,2L,2L,3L,0L,2L,3L,2L,4L,2L,4L,3L,1L,5L,3L,3L,4L,2L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093998Inst : IEnumerable<long>
{
public static readonly long[] Value=A093998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093998.Bytes);
public long this[int i]=>Value[i];

public static A093998Inst Instance=new A093998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093999
{
public static readonly long[] Value={ 2L,3L,5L,13L,43L,53L,61L,79L,83L,127L,131L,139L,157L,223L,251L,313L,337L,347L,367L,397L,463L,479L,499L,541L,547L,557L,643L,659L,769L,797L,853L,859L,887L,991L,1031L,1049L,1201L,1213L,1231L,1237L,1249L,1279L,1291L,1297L,1303L,1321L,1327L,1381L,1399L,1583L,1601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093999Inst : IEnumerable<long>
{
public static readonly long[] Value=A093999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093999.Bytes);
public long this[int i]=>Value[i];

public static A093999Inst Instance=new A093999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094000
{
public static readonly BigInteger[] Value={ 1L,1L,3L,29L,1015L,126651L,53354350L,74698954306L,350688201987402L,5624061753186933530L,BigInteger.Parse("314512139441575825493524"),BigInteger.Parse("62498777166571927258267336860"),BigInteger.Parse("44831219113504221199415663547412096") };
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
public class A094000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094000Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094000.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094000.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094000Inst Instance=new A094000Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094001
{
public static readonly long[] Value={ 2L,5L,8L,4L,5L,9L,3L,7L,1L,9L,6L,6L,7L,4L,7L,2L,8L,8L,7L,1L,6L,1L,0L,7L,1L,0L,2L,1L,6L,8L,4L,2L,6L,9L,2L,4L,3L,6L,0L,6L,2L,2L,6L,1L,7L,4L,5L,1L,4L,4L,9L,8L,3L,5L,2L,3L,9L,3L,5L,6L,3L,4L,5L,7L,4L,0L,3L,4L,6L,4L,6L,8L,7L,7L,2L,0L,7L,7L,9L,3L,8L,6L,6L,3L,2L,4L,2L,1L,9L,6L,8L,3L,7L,9L,2L,9L,6L,4L,9L,7L,8L,9L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094001Inst : IEnumerable<long>
{
public static readonly long[] Value=A094001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094001.Bytes);
public long this[int i]=>Value[i];

public static A094001Inst Instance=new A094001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094002
{
public static readonly long[] Value={ 1L,5L,14L,33L,72L,151L,310L,629L,1268L,2547L,5106L,10225L,20464L,40943L,81902L,163821L,327660L,655339L,1310698L,2621417L,5242856L,10485735L,20971494L,41943013L,83886052L,167772131L,335544290L,671088609L,1342177248L,2684354527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094002Inst : IEnumerable<long>
{
public static readonly long[] Value=A094002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094002.Bytes);
public long this[int i]=>Value[i];

public static A094002Inst Instance=new A094002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094003
{
public static readonly BigInteger[] Value={ 2L,3L,13L,2380L,32098914298781L,BigInteger.Parse("34076243757937210559857502330309024747435410425446137941014310689706") };
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
public class A094003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094003Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094003.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094003.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094003Inst Instance=new A094003Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094036
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,6L,2005L,280971L,22795136L,1345702092L,65250058251L,2781911443317L,108660434574142L,3991349973006198L,140293749275697017L,4775521611056597583L,BigInteger.Parse("158758002632650598268"),BigInteger.Parse("5185922974307536588224") };
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
public class A094036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094036Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094036.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094036.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094036Inst Instance=new A094036Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094037
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,1345L,738741L,185165477L,29458046177L,3541242666045L,354515664467077L,31326419674855789L,2535191648955942273L,BigInteger.Parse("192567615994193565125"),BigInteger.Parse("13962461827318220986133"),BigInteger.Parse("978010022290154153870661") };
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
public class A094037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094037Inst Instance=new A094037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094038
{
public static readonly long[] Value={ 0L,1L,2L,8L,24L,84L,280L,960L,3264L,11152L,38048L,129920L,443520L,1514304L,5170048L,17651712L,60266496L,205762816L,702517760L,2398545920L,8189147136L,27959497728L,95459694592L,325919784960L,1112759746560L,3799199420416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094038Inst : IEnumerable<long>
{
public static readonly long[] Value=A094038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094038.Bytes);
public long this[int i]=>Value[i];

public static A094038Inst Instance=new A094038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094039
{
public static readonly long[] Value={ 0L,1L,2L,6L,16L,46L,132L,386L,1136L,3366L,10012L,29866L,89256L,267086L,799892L,2396946L,7185376L,21545206L,64613772L,193797626L,581305496L,1743741726L,5230875652L,15691927906L,47074385616L,141220360646L,423655489532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094039Inst : IEnumerable<long>
{
public static readonly long[] Value=A094039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094039.Bytes);
public long this[int i]=>Value[i];

public static A094039Inst Instance=new A094039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094040
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,6L,14L,12L,1L,10L,40L,75L,55L,1L,15L,90L,275L,429L,273L,1L,21L,175L,770L,1911L,2548L,1428L,1L,28L,308L,1820L,6370L,13328L,15504L,7752L,1L,36L,504L,3822L,17640L,51408L,93024L,95931L,43263L,1L,45L,780L,7350L,42840L,162792L,406980L,648945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094040Inst : IEnumerable<long>
{
public static readonly long[] Value=A094040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094040.Bytes);
public long this[int i]=>Value[i];

public static A094040Inst Instance=new A094040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094041
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,19L,21L,23L,25L,27L,29L,31L,33L,35L,38L,40L,42L,44L,46L,48L,50L,52L,54L,57L,59L,61L,63L,65L,67L,69L,71L,73L,76L,78L,80L,82L,84L,86L,88L,90L,92L,95L,97L,99L,101L,103L,105L,107L,109L,111L,114L,116L,118L,120L,122L,124L,126L,128L,130L,133L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094041Inst : IEnumerable<long>
{
public static readonly long[] Value=A094041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094041.Bytes);
public long this[int i]=>Value[i];

public static A094041Inst Instance=new A094041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094042
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,113L,115L,117L,119L,121L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094042Inst : IEnumerable<long>
{
public static readonly long[] Value=A094042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094042.Bytes);
public long this[int i]=>Value[i];

public static A094042Inst Instance=new A094042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094043
{
public static readonly long[] Value={ 1L,3L,9L,13L,63L,107L,27L,67L,39L,23L,49L,29L,99L,439L,207L,41L,357L,229L,77L,139L,69L,839L,133L,239L,121L,317L,187L,53L,33L,1291L,177L,557L,171L,1753L,323L,19L,519L,953L,231L,523L,321L,251L,327L,31L,299L,2203L,747L,101L,81L,1741L,291L,6779L,261L,1549L,1463L,97L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094043Inst : IEnumerable<long>
{
public static readonly long[] Value=A094043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094043.Bytes);
public long this[int i]=>Value[i];

public static A094043Inst Instance=new A094043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094044
{
public static readonly long[] Value={ 2L,9L,7L,1L,3L,49L,19L,33L,13L,21L,11L,51L,47L,87L,31L,63L,17L,77L,23L,39L,29L,27L,41L,57L,37L,69L,59L,81L,61L,99L,67L,91L,73L,93L,43L,117L,79L,111L,71L,119L,53L,129L,83L,177L,89L,123L,113L,143L,107L,171L,103L,141L,97L,159L,157L,133L,109L,121L,139L,169L,151L,153L,137L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094044Inst : IEnumerable<long>
{
public static readonly long[] Value=A094044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094044.Bytes);
public long this[int i]=>Value[i];

public static A094044Inst Instance=new A094044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094045
{
public static readonly long[] Value={ 1L,3L,49L,19L,9L,7L,27L,11L,51L,13L,21L,29L,39L,17L,33L,23L,57L,37L,69L,47L,87L,31L,63L,43L,91L,61L,99L,41L,77L,53L,81L,67L,93L,71L,119L,59L,123L,73L,121L,97L,117L,79L,111L,103L,141L,101L,159L,113L,143L,89L,153L,83L,177L,109L,133L,157L,189L,127L,207L,139L,169L,151L,171L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094045Inst : IEnumerable<long>
{
public static readonly long[] Value=A094045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094045.Bytes);
public long this[int i]=>Value[i];

public static A094045Inst Instance=new A094045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094046
{
public static readonly long[] Value={ 1L,4L,22L,1L,141L,15L,988L,171L,3L,7337L,1778L,77L,56749L,17758L,1300L,12L,452332L,173826L,18315L,435L,3689697L,1683055L,233695L,9680L,55L,30652931L,16195344L,2804637L,171226L,2574L,258465558L,155280489L,32306742L,2647580L,70980L,273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094046Inst : IEnumerable<long>
{
public static readonly long[] Value=A094046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094046.Bytes);
public long this[int i]=>Value[i];

public static A094046Inst Instance=new A094046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094047
{
public static readonly BigInteger[] Value={ 0L,0L,2L,12L,312L,9600L,416880L,23879520L,1749363840L,159591720960L,17747520940800L,2363738855385600L,371511874881100800L,BigInteger.Parse("68045361697964851200"),BigInteger.Parse("14367543450324474009600"),BigInteger.Parse("3464541314885011705344000") };
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
public class A094047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094047.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094047Inst Instance=new A094047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094048
{
public static readonly long[] Value={ 2L,18L,4L,70L,6L,32L,182L,29718L,1068L,500L,5604L,10L,8890182L,776L,1744L,113582L,4832118L,1118L,1111225770L,1764132L,14L,1710L,23156L,71011068L,16L,82L,8920484118L,1063532L,2482L,126862368L,352618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094048Inst : IEnumerable<long>
{
public static readonly long[] Value=A094048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094048.Bytes);
public long this[int i]=>Value[i];

public static A094048Inst Instance=new A094048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094049
{
public static readonly long[] Value={ 1L,5L,1L,13L,1L,5L,25L,3805L,125L,53L,569L,1L,851525L,73L,149L,9305L,385645L,85L,82596761L,126985L,1L,113L,1517L,4574225L,1L,5L,535979945L,63445L,145L,7170685L,19805L,55335641L,493L,3793L,265L,65L,1027776565L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094049Inst : IEnumerable<long>
{
public static readonly long[] Value=A094049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094049.Bytes);
public long this[int i]=>Value[i];

public static A094049Inst Instance=new A094049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094050
{
public static readonly long[] Value={ 1L,1L,2L,24L,1344L,1128960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094050Inst : IEnumerable<long>
{
public static readonly long[] Value=A094050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094050.Bytes);
public long this[int i]=>Value[i];

public static A094050Inst Instance=new A094050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094051
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,3L,5L,6L,4L,6L,8L,6L,11L,12L,14L,8L,10L,12L,12L,12L,20L,20L,16L,20L,16L,26L,18L,24L,18L,24L,32L,22L,36L,20L,24L,27L,41L,42L,44L,24L,36L,32L,42L,30L,24L,36L,56L,36L,56L,48L,32L,50L,64L,65L,66L,36L,44L,48L,46L,72L,48L,60L,48L,78L,40L,48L,86L,56L,80L,89L,60L,60L,54L,95L,96L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094051Inst : IEnumerable<long>
{
public static readonly long[] Value=A094051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094051.Bytes);
public long this[int i]=>Value[i];

public static A094051Inst Instance=new A094051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094084
{
public static readonly long[] Value={ 1L,3L,4L,27L,64L,675L,256L,3675L,16384L,297675L,65536L,1440747L,1048576L,27054027L,4194304L,124227675L,1073741824L,35901798075L,4294967296L,160006779075L,68719476736L,2822519582883L,274877906944L,12339775697067L,17592186044416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094084Inst : IEnumerable<long>
{
public static readonly long[] Value=A094084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094084.Bytes);
public long this[int i]=>Value[i];

public static A094084Inst Instance=new A094084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094085
{
public static readonly long[] Value={ 3L,96L,768L,6144L,49152L,393216L,3145728L,25165824L,201326592L,1610612736L,12884901888L,103079215104L,824633720832L,6597069766656L,52776558133248L,422212465065984L,3377699720527872L,27021597764222976L,216172782113783808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094085Inst : IEnumerable<long>
{
public static readonly long[] Value=A094085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094085.Bytes);
public long this[int i]=>Value[i];

public static A094085Inst Instance=new A094085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094086
{
public static readonly long[] Value={ 60L,30L,20L,15L,12L,10L,450L,400L,6L,5L,4L,225L,200L,3L,150L,144L,8000L,2L,6750L,100L,90L,80L,75L,72L,4000L,1L,3375L,50L,48L,45L,160000L,40L,2250L,36L,2000L,30L,1728L,101250L,1600L,25L,24L,1350L,80000L,20L,1125L,18L,1000L,16L,15L,3200000L,864L,50625L,800L,750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094086Inst : IEnumerable<long>
{
public static readonly long[] Value=A094086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094086.Bytes);
public long this[int i]=>Value[i];

public static A094086Inst Instance=new A094086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094087
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,12L,16L,18L,20L,27L,32L,38L,42L,45L,56L,64L,71L,76L,80L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094087Inst : IEnumerable<long>
{
public static readonly long[] Value=A094087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094087.Bytes);
public long this[int i]=>Value[i];

public static A094087Inst Instance=new A094087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094088
{
public static readonly BigInteger[] Value={ 1L,1L,7L,121L,3907L,202741L,15430207L,1619195761L,224061282907L,39531606447181L,8661323866026007L,2307185279184885001L,BigInteger.Parse("734307168916191403507"),BigInteger.Parse("275199311597682485597221"),BigInteger.Parse("119956934012963778952439407") };
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
public class A094088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094088.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094088Inst Instance=new A094088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094089
{
public static readonly BigInteger[] Value={ 1L,1L,5L,53L,873L,20457L,634541L,24950557L,1203940177L,69583310545L,4726132141013L,371490917377285L,33369568795430841L,3389380003596443833L,BigInteger.Parse("385790631214713169789"),BigInteger.Parse("48829461608868817380845"),BigInteger.Parse("6826282320001018166712481"),BigInteger.Parse("1047822371119145840154900897") };
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
public class A094089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094089.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094089Inst Instance=new A094089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094090
{
public static readonly long[] Value={ 4L,9L,6L,5L,1L,1L,4L,2L,3L,1L,7L,4L,4L,2L,7L,6L,3L,0L,3L,6L,9L,8L,7L,5L,9L,1L,3L,1L,3L,2L,2L,8L,9L,3L,9L,4L,4L,0L,5L,5L,5L,8L,4L,9L,8L,6L,7L,9L,7L,2L,5L,0L,9L,7L,2L,8L,1L,4L,4L,4L,6L,1L,4L,4L,7L,8L,0L,4L,6L,3L,9L,8L,7L,9L,5L,7L,4L,5L,2L,9L,7L,2L,2L,3L,8L,2L,7L,0L,4L,5L,0L,6L,6L,0L,0L,0L,9L,6L,0L,8L,2L,9L,7L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094090Inst : IEnumerable<long>
{
public static readonly long[] Value=A094090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094090.Bytes);
public long this[int i]=>Value[i];

public static A094090Inst Instance=new A094090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094091
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094091Inst : IEnumerable<long>
{
public static readonly long[] Value=A094091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094091.Bytes);
public long this[int i]=>Value[i];

public static A094091Inst Instance=new A094091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094092
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,8L,13L,18L,27L,38L,53L,73L,101L,139L,189L,256L,344L,460L,612L,811L,1070L,1406L,1842L,2403L,3125L,4050L,5233L,6742L,8662L,11098L,14183L,18080L,22993L,29173L,36933L,46656L,58816L,73998L,92917L,116455L,145689L,181940L,226821L,282303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094092Inst : IEnumerable<long>
{
public static readonly long[] Value=A094092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094092.Bytes);
public long this[int i]=>Value[i];

public static A094092Inst Instance=new A094092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094093
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,9L,14L,19L,27L,39L,54L,74L,102L,140L,190L,256L,345L,461L,613L,812L,1071L,1407L,1843L,2404L,3125L,4051L,5234L,6743L,8663L,11099L,14184L,18081L,22994L,29174L,36934L,46656L,58817L,73999L,92918L,116456L,145690L,181941L,226822L,282304L,350787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094093Inst : IEnumerable<long>
{
public static readonly long[] Value=A094093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094093.Bytes);
public long this[int i]=>Value[i];

public static A094093Inst Instance=new A094093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094094
{
public static readonly long[] Value={ 1L,5L,25L,139L,871L,6131L,48161L,419399L,4025071L,42359239L,486703009L,6081751259L,82345132871L,1203618149579L,18920122802881L,318578240878351L,5722495974697951L,109204791111380879L,2205128748183225281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094094Inst : IEnumerable<long>
{
public static readonly long[] Value=A094094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094094.Bytes);
public long this[int i]=>Value[i];

public static A094094Inst Instance=new A094094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094095
{
public static readonly long[] Value={ 103L,37L,59L,271L,37L,37L,67L,37L,59L,37L,101L,157L,37L,67L,59L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094095Inst : IEnumerable<long>
{
public static readonly long[] Value=A094095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094095.Bytes);
public long this[int i]=>Value[i];

public static A094095Inst Instance=new A094095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094096
{
public static readonly long[] Value={ 1L,5L,1L,494L,533L,133L,1L,361131L,998130L,318354L,389455L,275577L,42778L,14162L,1L,4436526107L,21759994113L,223006618265L,97254937860L,19669357917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094096Inst : IEnumerable<long>
{
public static readonly long[] Value=A094096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094096.Bytes);
public long this[int i]=>Value[i];

public static A094096Inst Instance=new A094096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094097
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,5L,4L,3L,2L,8L,4L,6L,47L,44L,6L,37L,6L,166L,462L,232L,372L,2130L,1589L,9093L,20896L,20314L,4118L,32367L,12815L,167796L,130528L,59173L,1942045L,2607312L,163775L,1297794L,18340336L,22304602L,5065878L,21005347L,3607762L,129164605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094097Inst : IEnumerable<long>
{
public static readonly long[] Value=A094097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094097.Bytes);
public long this[int i]=>Value[i];

public static A094097Inst Instance=new A094097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094098
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,0L,3L,0L,5L,0L,6L,0L,6L,0L,147L,1L,22L,2L,27L,165L,519L,0L,516L,2021L,1912L,506L,45658L,514L,7308L,1535L,30746L,68918L,145920L,1370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094098Inst : IEnumerable<long>
{
public static readonly long[] Value=A094098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094098.Bytes);
public long this[int i]=>Value[i];

public static A094098Inst Instance=new A094098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094099
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,4L,47L,6L,6L,462L,372L,1589L,20896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094099Inst : IEnumerable<long>
{
public static readonly long[] Value=A094099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094099.Bytes);
public long this[int i]=>Value[i];

public static A094099Inst Instance=new A094099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094116
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,7L,11L,16L,20L,25L,25L,26L,26L,27L,27L,32L,36L,41L,45L,50L,50L,51L,51L,52L,52L,77L,101L,126L,150L,175L,195L,216L,236L,257L,277L,302L,326L,351L,375L,400L,420L,441L,461L,482L,502L,527L,551L,576L,600L,625L,625L,626L,626L,627L,627L,632L,636L,641L,645L,650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094116Inst : IEnumerable<long>
{
public static readonly long[] Value=A094116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094116.Bytes);
public long this[int i]=>Value[i];

public static A094116Inst Instance=new A094116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094117
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,10L,16L,23L,29L,36L,42L,49L,49L,50L,50L,51L,51L,52L,52L,59L,65L,72L,78L,85L,91L,98L,98L,99L,99L,100L,100L,101L,101L,108L,114L,121L,127L,134L,140L,147L,147L,148L,148L,149L,149L,150L,150L,199L,247L,296L,344L,393L,441L,490L,532L,575L,617L,660L,702L,745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094117Inst : IEnumerable<long>
{
public static readonly long[] Value=A094117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094117.Bytes);
public long this[int i]=>Value[i];

public static A094117Inst Instance=new A094117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094118
{
public static readonly long[] Value={ 3L,6L,3L,0L,8L,8L,3L,0L,8L,2L,2L,8L,8L,2L,6L,9L,7L,5L,9L,5L,2L,5L,6L,1L,7L,9L,3L,1L,0L,1L,2L,7L,8L,2L,2L,7L,4L,9L,7L,3L,7L,3L,6L,1L,1L,2L,8L,6L,9L,2L,2L,8L,9L,0L,7L,4L,2L,3L,0L,6L,4L,9L,1L,4L,5L,5L,5L,3L,3L,3L,4L,9L,1L,1L,3L,2L,5L,9L,7L,7L,8L,5L,0L,0L,5L,9L,9L,0L,5L,8L,3L,1L,7L,2L,7L,0L,4L,8L,3L,5L,7L,4L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094118Inst : IEnumerable<long>
{
public static readonly long[] Value=A094118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094118.Bytes);
public long this[int i]=>Value[i];

public static A094118Inst Instance=new A094118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094119
{
public static readonly long[] Value={ 3L,1L,4L,1L,6L,4L,3L,2L,9L,7L,5L,6L,9L,3L,7L,8L,4L,0L,3L,2L,3L,7L,3L,1L,5L,0L,0L,4L,6L,3L,4L,1L,0L,3L,1L,4L,8L,1L,4L,4L,1L,4L,9L,0L,4L,6L,9L,4L,8L,8L,8L,8L,8L,2L,5L,3L,5L,4L,4L,7L,0L,3L,7L,0L,3L,1L,7L,7L,4L,9L,4L,0L,6L,7L,8L,0L,5L,4L,4L,1L,5L,4L,0L,3L,5L,9L,5L,7L,9L,6L,5L,9L,7L,9L,1L,8L,6L,3L,2L,2L,6L,1L,7L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094119Inst : IEnumerable<long>
{
public static readonly long[] Value=A094119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094119.Bytes);
public long this[int i]=>Value[i];

public static A094119Inst Instance=new A094119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094120
{
public static readonly long[] Value={ 0L,1L,0L,0L,4L,9L,12L,16L,12L,9L,4L,0L,0L,1L,0L,0L,16L,33L,48L,64L,84L,105L,124L,144L,156L,169L,180L,192L,208L,225L,240L,256L,240L,225L,208L,192L,180L,169L,156L,144L,124L,105L,84L,64L,48L,33L,16L,0L,0L,1L,0L,0L,4L,9L,12L,16L,12L,9L,4L,0L,0L,1L,0L,0L,64L,129L,192L,256L,324L,393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094120Inst : IEnumerable<long>
{
public static readonly long[] Value=A094120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094120.Bytes);
public long this[int i]=>Value[i];

public static A094120Inst Instance=new A094120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094121
{
public static readonly long[] Value={ 2L,7L,1L,8L,3L,2L,5L,6L,4L,8L,4L,6L,5L,2L,0L,3L,5L,4L,4L,7L,4L,5L,5L,2L,4L,7L,1L,5L,9L,4L,8L,5L,8L,8L,2L,1L,9L,2L,0L,9L,3L,5L,6L,3L,0L,6L,8L,4L,6L,6L,6L,8L,2L,0L,1L,7L,1L,2L,9L,4L,9L,0L,4L,1L,6L,1L,0L,3L,3L,2L,7L,6L,4L,3L,0L,0L,2L,7L,9L,0L,7L,8L,2L,5L,8L,0L,3L,5L,1L,3L,3L,8L,4L,0L,6L,4L,4L,1L,8L,4L,0L,9L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094121Inst : IEnumerable<long>
{
public static readonly long[] Value=A094121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094121.Bytes);
public long this[int i]=>Value[i];

public static A094121Inst Instance=new A094121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094122
{
public static readonly long[] Value={ 2L,3L,5L,2L,0L,4L,7L,5L,2L,1L,3L,7L,8L,6L,0L,6L,8L,1L,4L,0L,6L,3L,1L,8L,4L,7L,1L,6L,9L,9L,3L,0L,0L,5L,1L,0L,1L,5L,4L,2L,6L,6L,1L,1L,7L,8L,9L,1L,7L,8L,9L,8L,2L,4L,8L,7L,6L,9L,9L,3L,1L,6L,2L,0L,4L,3L,6L,1L,0L,7L,5L,5L,4L,6L,7L,1L,4L,9L,0L,5L,8L,2L,1L,0L,6L,6L,1L,9L,2L,5L,7L,6L,0L,5L,7L,1L,5L,7L,7L,7L,8L,3L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094122Inst : IEnumerable<long>
{
public static readonly long[] Value=A094122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094122.Bytes);
public long this[int i]=>Value[i];

public static A094122Inst Instance=new A094122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094123
{
public static readonly long[] Value={ 1L,7L,6L,0L,9L,0L,2L,5L,0L,1L,9L,1L,7L,8L,1L,3L,3L,7L,1L,4L,2L,8L,9L,8L,0L,7L,2L,9L,8L,6L,1L,9L,4L,1L,0L,3L,4L,9L,3L,1L,0L,8L,1L,6L,7L,3L,7L,0L,7L,7L,0L,7L,5L,3L,8L,1L,5L,1L,4L,3L,9L,3L,9L,7L,1L,5L,6L,2L,1L,7L,0L,8L,1L,0L,2L,4L,7L,5L,5L,8L,4L,9L,4L,7L,4L,9L,0L,1L,0L,4L,0L,8L,4L,5L,4L,7L,8L,7L,4L,4L,2L,7L,9L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094123Inst : IEnumerable<long>
{
public static readonly long[] Value=A094123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094123.Bytes);
public long this[int i]=>Value[i];

public static A094123Inst Instance=new A094123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094124
{
public static readonly long[] Value={ 3L,7L,5L,3L,7L,5L,3L,43L,13L,11L,19L,7L,5L,3L,11L,179L,7L,5L,3L,19L,17L,23L,13L,11L,17L,7L,5L,3L,373L,7L,5L,3L,17L,41L,13L,11L,53L,7L,5L,3L,97L,43L,23L,103L,19L,17L,97L,13L,11L,79L,7L,5L,3L,19L,17L,67L,13L,11L,61L,7L,5L,3L,31L,29L,61L,47L,23L,43L,19L,17L,37L,13L,11L,31L,7L,5L,3L,23L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094124Inst : IEnumerable<long>
{
public static readonly long[] Value=A094124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094124.Bytes);
public long this[int i]=>Value[i];

public static A094124Inst Instance=new A094124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094125
{
public static readonly long[] Value={ 5L,12L,30L,78L,210L,582L,1650L,4758L,13890L,40902L,121170L,360438L,1075170L,3213222L,9615090L,28796118L,86290050L,258673542L,775627410L,2326095798L,6976714530L,20926997862L,62774702130L,188311523478L,564909404610L,1694677882182L,5083932983250L,15251597623158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094125Inst : IEnumerable<long>
{
public static readonly long[] Value=A094125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094125.Bytes);
public long this[int i]=>Value[i];

public static A094125Inst Instance=new A094125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094126
{
public static readonly long[] Value={ 2L,0L,3L,5L,1L,2L,3L,1L,8L,1L,7L,8L,1L,6L,7L,7L,8L,9L,5L,5L,2L,7L,3L,8L,6L,3L,4L,8L,7L,8L,5L,2L,6L,8L,5L,0L,1L,7L,8L,3L,6L,4L,4L,8L,4L,0L,1L,1L,0L,9L,5L,9L,0L,4L,8L,1L,1L,3L,1L,7L,7L,9L,0L,5L,2L,5L,8L,9L,5L,3L,6L,9L,0L,9L,7L,8L,8L,8L,4L,7L,7L,5L,5L,0L,7L,3L,9L,4L,0L,5L,1L,0L,8L,6L,3L,6L,6L,7L,0L,4L,1L,4L,0L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094126Inst : IEnumerable<long>
{
public static readonly long[] Value=A094126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094126.Bytes);
public long this[int i]=>Value[i];

public static A094126Inst Instance=new A094126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094127
{
public static readonly long[] Value={ 9L,3L,0L,1L,9L,1L,3L,6L,7L,1L,0L,2L,6L,3L,2L,8L,5L,8L,6L,6L,8L,1L,2L,4L,6L,2L,3L,6L,3L,3L,3L,3L,1L,5L,5L,6L,0L,2L,9L,7L,1L,0L,9L,2L,0L,7L,0L,4L,2L,8L,8L,7L,2L,6L,4L,4L,5L,0L,0L,0L,6L,4L,8L,9L,8L,5L,5L,4L,2L,2L,3L,4L,5L,4L,6L,0L,2L,3L,4L,4L,8L,3L,8L,7L,2L,1L,5L,5L,7L,2L,3L,9L,4L,2L,6L,9L,9L,7L,6L,5L,9L,2L,9L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094127Inst : IEnumerable<long>
{
public static readonly long[] Value=A094127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094127.Bytes);
public long this[int i]=>Value[i];

public static A094127Inst Instance=new A094127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094128
{
public static readonly long[] Value={ 44L,116L,128L,132L,152L,296L,320L,332L,344L,348L,380L,384L,396L,440L,452L,456L,464L,476L,800L,872L,880L,888L,944L,960L,980L,992L,996L,1024L,1028L,1032L,1044L,1136L,1140L,1152L,1184L,1188L,1196L,1232L,1280L,1304L,1316L,1320L,1352L,1356L,1368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094128Inst : IEnumerable<long>
{
public static readonly long[] Value=A094128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094128.Bytes);
public long this[int i]=>Value[i];

public static A094128Inst Instance=new A094128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094129
{
public static readonly long[] Value={ 9L,5L,2L,9L,0L,1L,9L,2L,2L,3L,2L,9L,8L,5L,7L,1L,5L,8L,2L,6L,4L,6L,6L,1L,0L,0L,9L,1L,5L,9L,1L,0L,6L,1L,4L,2L,2L,0L,7L,9L,7L,4L,7L,7L,7L,7L,7L,7L,2L,4L,1L,1L,6L,1L,7L,1L,0L,4L,5L,7L,7L,4L,1L,7L,8L,6L,3L,1L,5L,0L,3L,4L,2L,1L,1L,8L,8L,0L,0L,8L,6L,5L,3L,2L,9L,4L,9L,7L,0L,9L,1L,6L,4L,0L,1L,1L,8L,8L,9L,9L,7L,6L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094129Inst : IEnumerable<long>
{
public static readonly long[] Value=A094129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094129.Bytes);
public long this[int i]=>Value[i];

public static A094129Inst Instance=new A094129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094130
{
public static readonly long[] Value={ 9L,6L,4L,4L,6L,4L,2L,9L,0L,2L,1L,6L,4L,0L,4L,4L,6L,5L,6L,4L,4L,4L,9L,4L,5L,8L,8L,2L,2L,4L,9L,5L,7L,6L,6L,9L,2L,4L,3L,4L,6L,3L,1L,8L,6L,3L,5L,2L,1L,2L,1L,8L,4L,5L,0L,2L,0L,2L,7L,0L,3L,1L,0L,4L,2L,2L,2L,1L,6L,7L,9L,7L,4L,0L,9L,7L,2L,6L,7L,0L,2L,9L,5L,3L,2L,4L,3L,0L,9L,1L,3L,1L,4L,1L,9L,1L,4L,0L,5L,3L,7L,4L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094130Inst : IEnumerable<long>
{
public static readonly long[] Value=A094130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094130.Bytes);
public long this[int i]=>Value[i];

public static A094130Inst Instance=new A094130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094131
{
public static readonly long[] Value={ 9L,7L,6L,1L,6L,6L,9L,5L,4L,1L,2L,7L,1L,3L,9L,6L,4L,6L,1L,5L,9L,5L,9L,3L,5L,7L,6L,8L,2L,4L,5L,2L,3L,1L,3L,6L,0L,5L,9L,6L,8L,3L,3L,5L,0L,4L,0L,4L,9L,9L,6L,5L,2L,1L,4L,1L,9L,0L,4L,5L,1L,2L,8L,0L,7L,4L,5L,4L,3L,1L,8L,6L,6L,9L,6L,5L,2L,1L,0L,7L,6L,1L,8L,4L,7L,4L,8L,4L,7L,0L,2L,3L,8L,4L,3L,6L,4L,0L,6L,1L,2L,2L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094131Inst : IEnumerable<long>
{
public static readonly long[] Value=A094131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094131.Bytes);
public long this[int i]=>Value[i];

public static A094131Inst Instance=new A094131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094292
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,25L,68L,182L,483L,1275L,3355L,8811L,23112L,60580L,158717L,415715L,1088661L,2850645L,7463884L,19541994L,51163695L,133951675L,350695511L,918141623L,2403740304L,6293097000L,16475579353L,43133687427L,112925557953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094292Inst : IEnumerable<long>
{
public static readonly long[] Value=A094292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094292.Bytes);
public long this[int i]=>Value[i];

public static A094292Inst Instance=new A094292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094293
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,4L,1L,2L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,5L,1L,2L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094293Inst : IEnumerable<long>
{
public static readonly long[] Value=A094293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094293.Bytes);
public long this[int i]=>Value[i];

public static A094293Inst Instance=new A094293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094294
{
public static readonly BigInteger[] Value={ 1L,2L,5L,18L,87L,518L,3621L,28962L,260651L,2606502L,28671513L,344058146L,4472755887L,62618582406L,939278736077L,15028459777218L,255483816212691L,4598708691828422L,87375465144740001L,1747509302894800002L,BigInteger.Parse("36697695360790800023"),BigInteger.Parse("807349297937397600486"),BigInteger.Parse("18569033852560144811157") };
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
public class A094294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094294.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094294Inst Instance=new A094294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094295
{
public static readonly long[] Value={ 1L,1L,2L,0L,0L,4L,4L,4L,7L,7L,2L,8L,4L,12L,2L,10L,4L,0L,6L,6L,9L,9L,21L,9L,19L,17L,24L,12L,19L,19L,17L,13L,29L,13L,3L,29L,1L,7L,24L,4L,32L,36L,5L,1L,6L,0L,28L,28L,17L,17L,12L,28L,15L,13L,53L,9L,49L,33L,32L,52L,6L,42L,14L,22L,32L,58L,61L,45L,45L,15L,38L,2L,21L,45L,70L,22L,71L,11L,5L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094295Inst : IEnumerable<long>
{
public static readonly long[] Value=A094295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094295.Bytes);
public long this[int i]=>Value[i];

public static A094295Inst Instance=new A094295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094296
{
public static readonly long[] Value={ 0L,3L,28L,224L,1866L,16000L,140005L,1244493L,11200444L,101822225L,933370397L,8615726748L,80003176948L,7466963181894L,70002779830257L,6588496925200718L,62224693182451228L,589497093307432686L,5600222386420610520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094296Inst : IEnumerable<long>
{
public static readonly long[] Value=A094296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094296.Bytes);
public long this[int i]=>Value[i];

public static A094296Inst Instance=new A094296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094297
{
public static readonly long[] Value={ 1L,3L,7L,18L,46L,120L,316L,840L,2248L,6048L,16336L,44256L,120160L,326784L,889792L,2424960L,6613120L,18043392L,49247488L,134450688L,367134208L,1002645504L,2738510848L,7480215552L,20433258496L,55818559488L,152486858752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094297Inst : IEnumerable<long>
{
public static readonly long[] Value=A094297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094297.Bytes);
public long this[int i]=>Value[i];

public static A094297Inst Instance=new A094297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094298
{
public static readonly long[] Value={ 4L,6L,14L,15L,26L,35L,38L,49L,51L,62L,65L,74L,85L,86L,91L,94L,111L,121L,122L,129L,134L,158L,159L,169L,183L,185L,187L,201L,206L,209L,215L,219L,221L,237L,247L,254L,287L,301L,302L,303L,305L,319L,321L,326L,329L,365L,371L,377L,386L,403L,411L,417L,427L,446L,447L,458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094298Inst : IEnumerable<long>
{
public static readonly long[] Value=A094298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094298.Bytes);
public long this[int i]=>Value[i];

public static A094298Inst Instance=new A094298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094299
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,15L,5L,35L,280L,2520L,252L,2772L,231L,3003L,429L,143L,2288L,38896L,19448L,369512L,92378L,1939938L,88179L,2028117L,676039L,16900975L,1300075L,35102025L,5014575L,145422675L,9694845L,300540195L,9617286240L,3205762080L,94287120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094299Inst : IEnumerable<long>
{
public static readonly long[] Value=A094299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094299.Bytes);
public long this[int i]=>Value[i];

public static A094299Inst Instance=new A094299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094300
{
public static readonly long[] Value={ 1L,2L,6L,3L,15L,5L,35L,35L,35L,7L,77L,77L,1001L,143L,143L,143L,2431L,2431L,46189L,46189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094300Inst : IEnumerable<long>
{
public static readonly long[] Value=A094300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094300.Bytes);
public long this[int i]=>Value[i];

public static A094300Inst Instance=new A094300Inst();

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