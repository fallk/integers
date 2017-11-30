using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A181705
{
public static readonly BigInteger[] Value={ 56L,368L,128768L,2087936L,8589344768L,2199013818368L,BigInteger.Parse("36893488108764397568"),BigInteger.Parse("904625697166532776746648320380374279912262923807289020860114158381451706368") };
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
public class A181705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181705Inst Instance=new A181705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181706
{
public static readonly BigInteger[] Value={ 1504L,30592L,8353792L,2146926592L,34357510144L,549746900992L,8796057370624L,140737345748992L,9223372000347553792L,BigInteger.Parse("2361183240850707054592"),BigInteger.Parse("9671406556879650002305024"),BigInteger.Parse("154742504910523000781012992") };
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
public class A181706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181706Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181706.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181706Inst Instance=new A181706Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181707
{
public static readonly BigInteger[] Value={ 992L,28544L,122624L,507392L,34355412992L,8796023816192L,140737211531264L,144115179217485824L,BigInteger.Parse("9671406556844465630216192"),BigInteger.Parse("162259276829213066154002603835392"),BigInteger.Parse("11417981541647679048463794346093005918389141504") };
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
public class A181707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181707Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181707.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181707Inst Instance=new A181707Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181708
{
public static readonly long[] Value={ 4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,20L,21L,22L,24L,26L,27L,30L,32L,34L,37L,38L,42L,47L,52L,62L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181708Inst : IEnumerable<long>
{
public static readonly long[] Value=A181708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181708.Bytes);
public long this[int i]=>Value[i];

public static A181708Inst Instance=new A181708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181709
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,10L,11L,13L,14L,15L,16L,18L,20L,21L,23L,24L,25L,27L,28L,30L,33L,34L,35L,36L,37L,38L,43L,44L,46L,47L,50L,51L,53L,55L,56L,58L,60L,61L,64L,65L,66L,67L,71L,75L,76L,77L,78L,80L,81L,84L,86L,88L,90L,91L,93L,94L,95L,98L,103L,104L,105L,106L,111L,113L,116L,117L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181709Inst : IEnumerable<long>
{
public static readonly long[] Value=A181709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181709.Bytes);
public long this[int i]=>Value[i];

public static A181709Inst Instance=new A181709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181710
{
public static readonly long[] Value={ 24L,224L,15872L,1040384L,274844352512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181710Inst : IEnumerable<long>
{
public static readonly long[] Value=A181710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181710.Bytes);
public long this[int i]=>Value[i];

public static A181710Inst Instance=new A181710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181711
{
public static readonly BigInteger[] Value={ 18L,196L,15376L,1032256L,274810802176L,1125882727038976L,72057319160283136L,BigInteger.Parse("4951760152529835082242850816"),BigInteger.Parse("6129982163463555428116476125461573244012649752219877376") };
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
public class A181711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181711Inst Instance=new A181711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181712
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181712Inst : IEnumerable<long>
{
public static readonly long[] Value=A181712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181712.Bytes);
public long this[int i]=>Value[i];

public static A181712Inst Instance=new A181712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181713
{
public static readonly long[] Value={ 1L,2L,5L,7L,9L,10L,13L,14L,15L,17L,18L,22L,23L,26L,28L,30L,31L,34L,35L,36L,39L,43L,44L,47L,48L,49L,51L,52L,56L,57L,60L,62L,64L,65L,68L,69L,70L,73L,77L,78L,81L,83L,85L,86L,89L,90L,91L,94L,96L,98L,99L,102L,103L,104L,106L,107L,111L,112L,115L,117L,119L,120L,123L,124L,125L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181713Inst : IEnumerable<long>
{
public static readonly long[] Value=A181713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181713.Bytes);
public long this[int i]=>Value[i];

public static A181713Inst Instance=new A181713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181714
{
public static readonly long[] Value={ 3L,4L,6L,8L,11L,12L,16L,19L,20L,21L,24L,25L,27L,29L,32L,33L,37L,38L,40L,41L,42L,45L,46L,50L,53L,54L,55L,58L,59L,61L,63L,66L,67L,71L,72L,74L,75L,76L,79L,80L,82L,84L,87L,88L,92L,93L,95L,97L,100L,101L,105L,108L,109L,110L,113L,114L,116L,118L,121L,122L,126L,127L,129L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181714Inst : IEnumerable<long>
{
public static readonly long[] Value=A181714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181714.Bytes);
public long this[int i]=>Value[i];

public static A181714Inst Instance=new A181714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181715
{
public static readonly long[] Value={ 3L,2L,1L,2L,1L,1L,1L,3L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181715Inst : IEnumerable<long>
{
public static readonly long[] Value=A181715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181715.Bytes);
public long this[int i]=>Value[i];

public static A181715Inst Instance=new A181715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181716
{
public static readonly long[] Value={ 0L,1L,2L,2L,5L,6L,12L,17L,30L,46L,77L,122L,200L,321L,522L,842L,1365L,2206L,3572L,5777L,9350L,15126L,24477L,39602L,64080L,103681L,167762L,271442L,439205L,710646L,1149852L,1860497L,3010350L,4870846L,7881197L,12752042L,20633240L,33385281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181716Inst : IEnumerable<long>
{
public static readonly long[] Value=A181716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181716.Bytes);
public long this[int i]=>Value[i];

public static A181716Inst Instance=new A181716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181717
{
public static readonly long[] Value={ 0L,1L,4L,16L,10L,13L,70L,250L,160L,205L,1096L,3904L,2500L,3202L,2851L,18160L,63034L,40597L,310894L,1054474L,682684L,868579L,4653790L,16567108L,10610449L,81532672L,276429364L,178981018L,227705191L,1220058628L,4343291458L,2781675043L,21374899504L,72469723642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181717Inst : IEnumerable<long>
{
public static readonly long[] Value=A181717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181717.Bytes);
public long this[int i]=>Value[i];

public static A181717Inst Instance=new A181717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181718
{
public static readonly BigInteger[] Value={ 0L,12L,1122L,111222L,11112222L,1111122222L,111111222222L,11111112222222L,1111111122222222L,111111111222222222L,11111111112222222222UL,BigInteger.Parse("1111111111122222222222"),BigInteger.Parse("111111111111222222222222"),BigInteger.Parse("11111111111112222222222222"),BigInteger.Parse("1111111111111122222222222222") };
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
public class A181718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181718Inst Instance=new A181718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181719
{
public static readonly BigInteger[] Value={ 25L,1225L,112225L,11122225L,1111222225L,111112222225L,11111122222225L,1111111222222225L,111111112222222225L,11111111122222222225UL,BigInteger.Parse("1111111111222222222225"),BigInteger.Parse("111111111112222222222225"),BigInteger.Parse("11111111111122222222222225"),BigInteger.Parse("1111111111111222222222222225"),BigInteger.Parse("111111111111112222222222222225") };
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
public class A181719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181719Inst Instance=new A181719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181720
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1010L,11L,216L,312L,1414L,510L,1616L,714L,810L,912L,1020L,126L,22L,322L,2424L,525L,624L,729L,1820L,928L,3030L,713L,2304L,33L,3434L,3535L,3636L,1073L,836L,936L,1040L,1148L,924L,344L,44L,540L,644L,1974L,384L,294L,1050L,153L,2548L,3551L,1458L,55L,5656L,4275L,1856L,295L,3060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181720Inst : IEnumerable<long>
{
public static readonly long[] Value=A181720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181720.Bytes);
public long this[int i]=>Value[i];

public static A181720Inst Instance=new A181720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181721
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,101L,1L,18L,24L,101L,34L,101L,42L,45L,48L,51L,6L,1L,14L,101L,21L,24L,27L,65L,32L,101L,23L,72L,1L,101L,101L,101L,29L,22L,24L,26L,28L,22L,8L,1L,12L,14L,42L,8L,6L,21L,3L,49L,67L,27L,1L,101L,75L,32L,5L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181721Inst : IEnumerable<long>
{
public static readonly long[] Value=A181721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181721.Bytes);
public long this[int i]=>Value[i];

public static A181721Inst Instance=new A181721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181722
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,1L,5L,1L,13L,1L,1L,1L,901L,1L,-11L,1L,3647L,1L,-43825L,1L,1222387L,1L,-854507L,1L,1181821001L,1L,-76977925L,1L,23749461059L,1L,-8615841275543L,1L,28267510484519L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181722Inst : IEnumerable<long>
{
public static readonly long[] Value=A181722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181722.Bytes);
public long this[int i]=>Value[i];

public static A181722Inst Instance=new A181722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181723
{
public static readonly long[] Value={ 8L,9L,10L,12L,13L,20L,19L,22L,23L,30L,29L,35L,34L,39L,40L,37L,50L,44L,46L,49L,65L,52L,57L,68L,55L,58L,62L,73L,71L,79L,76L,85L,77L,80L,92L,82L,83L,86L,95L,102L,97L,103L,100L,96L,101L,145L,106L,109L,112L,117L,122L,113L,118L,124L,119L,127L,133L,130L,136L,135L,146L,140L,151L,156L,179L,150L,163L,148L,175L,157L,158L,160L,154L,166L,182L,177L,172L,190L,174L,199L,189L,176L,184L,180L,197L,193L,200L,191L,196L,195L,202L,208L,209L,204L,230L,240L,211L,220L,215L,218L,238L,223L,222L,233L,232L,235L,236L,258L,275L,255L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181723Inst : IEnumerable<long>
{
public static readonly long[] Value=A181723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181723.Bytes);
public long this[int i]=>Value[i];

public static A181723Inst Instance=new A181723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181724
{
public static readonly BigInteger[] Value={ 1L,40320L,214899027840L,2509137924026751360L,BigInteger.Parse("41795104403987233709518080"),BigInteger.Parse("852847938704373386478865686645120"),BigInteger.Parse("19846219244619878972245087341015659057280"),BigInteger.Parse("506348195597089273505079176351561351976609740160") };
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
public class A181724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181724Inst Instance=new A181724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181725
{
public static readonly BigInteger[] Value={ 1L,362880L,33007837322880L,BigInteger.Parse("7408611474125625953280"),BigInteger.Parse("2499611266020127048565292881280"),BigInteger.Parse("1064141699563485513180737844317706666240"),BigInteger.Parse("526577363627345975232160422620146408876598167680"),BigInteger.Parse("289514065258843883748159731480148589989905149052842682880") };
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
public class A181725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181725Inst Instance=new A181725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181726
{
public static readonly BigInteger[] Value={ 1L,3628800L,6290830003852800L,BigInteger.Parse("30306073546461323055916800"),BigInteger.Parse("231242270452155338291905203314956800"),BigInteger.Parse("2293197130058463838438742129627609575368940800"),BigInteger.Parse("26941822036577030394903099245279465611395585827577676800") };
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
public class A181726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181726Inst Instance=new A181726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181727
{
public static readonly BigInteger[] Value={ 1L,39916800L,1456812592995513600L,BigInteger.Parse("166369951631853645510591187200"),BigInteger.Parse("31707078596527364069316526441204831526400"),BigInteger.Parse("8089435115221815003427192379950659547969112311680000"),BigInteger.Parse("2492107900477900258313589438717998843635090670139189341868499200") };
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
public class A181727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181727Inst Instance=new A181727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181728
{
public static readonly BigInteger[] Value={ 1L,479001600L,BigInteger.Parse("402910665227270323200"),BigInteger.Parse("1193980357099103775859825737292800"),BigInteger.Parse("6221349234739584150822122029143772173312614400"),BigInteger.Parse("44698730304001991182769831137859339764690493418024756096000"),BigInteger.Parse("395245742455869432937361185087176756463979731526578123254618890928614400") };
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
public class A181728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181728Inst Instance=new A181728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181729
{
public static readonly BigInteger[] Value={ 3L,7L,43L,547L,9283L,BigInteger.Parse("593966822339511354494269574612265371991631567") };
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
public class A181729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181729Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181729.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181729Inst Instance=new A181729Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181730
{
public static readonly long[] Value={ 1L,2L,3L,5L,25L,33L,41L,60L,61L,64L,66L,72L,88L,129L,203L,212L,299L,313L,330L,380L,419L,442L,463L,480L,487L,517L,533L,560L,589L,603L,607L,633L,646L,649L,657L,658L,689L,703L,759L,776L,782L,791L,807L,814L,843L,853L,874L,907L,922L,953L,1034L,1075L,1127L,1140L,1143L,1149L,1156L,1232L,1237L,1243L,1270L,1288L,1339L,1341L,1395L,1409L,1518L,1525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181730Inst : IEnumerable<long>
{
public static readonly long[] Value=A181730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181730.Bytes);
public long this[int i]=>Value[i];

public static A181730Inst Instance=new A181730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181731
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,6L,14L,4L,1L,24L,222L,106L,8L,1L,120L,6384L,9918L,838L,16L,1L,720L,291720L,2306904L,486924L,6802L,32L,1L,5040L,19445040L,1085674320L,964948464L,25267236L,56190L,64L,1L,40320L,1781750880L,906140159280L,4927561419120L,439331916888L,1359631776L,470010L,128L,1L,362880L,214899027840L,1224777388630320L,54259623434853360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181731Inst : IEnumerable<long>
{
public static readonly long[] Value=A181731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181731.Bytes);
public long this[int i]=>Value[i];

public static A181731Inst Instance=new A181731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181732
{
public static readonly long[] Value={ 2L,3L,6L,7L,9L,11L,13L,17L,18L,20L,24L,25L,26L,28L,31L,33L,34L,37L,39L,41L,45L,47L,51L,54L,55L,62L,65L,68L,69L,70L,72L,73L,74L,76L,84L,86L,89L,90L,91L,94L,96L,97L,98L,100L,101L,102L,107L,108L,109L,110L,117L,119L,121L,123L,124L,125L,130L,133L,136L,138L,139L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181732Inst : IEnumerable<long>
{
public static readonly long[] Value=A181732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181732.Bytes);
public long this[int i]=>Value[i];

public static A181732Inst Instance=new A181732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181733
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,4L,1L,5L,3L,7L,2L,4L,6L,8L,1L,9L,5L,13L,3L,7L,11L,15L,2L,4L,6L,8L,10L,12L,14L,16L,1L,17L,9L,25L,5L,13L,21L,29L,3L,7L,11L,15L,19L,23L,27L,31L,2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181733Inst : IEnumerable<long>
{
public static readonly long[] Value=A181733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181733.Bytes);
public long this[int i]=>Value[i];

public static A181733Inst Instance=new A181733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181734
{
public static readonly long[] Value={ 1L,1L,2L,6L,19L,64L,227L,832L,3126L,11980L,46646L,184003L,733783L,2953434L,11982265L,48949631L,201182110L,831292029L,3451336467L,14390479996L,60232976244L,252992172572L,1066000599632L,4504710385216L,19086728370308L,81069926894797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181734Inst : IEnumerable<long>
{
public static readonly long[] Value=A181734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181734.Bytes);
public long this[int i]=>Value[i];

public static A181734Inst Instance=new A181734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181735
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,8L,12L,27L,162L,457L,1198L,3144L,8313L,21507L,57329L,152102L,400610L,1053254L,2750411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181735Inst : IEnumerable<long>
{
public static readonly long[] Value=A181735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181735.Bytes);
public long this[int i]=>Value[i];

public static A181735Inst Instance=new A181735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181736
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181736Inst : IEnumerable<long>
{
public static readonly long[] Value=A181736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181736.Bytes);
public long this[int i]=>Value[i];

public static A181736Inst Instance=new A181736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181737
{
public static readonly BigInteger[] Value={ 2L,6L,42L,546L,9282L,176358L,4056234L,117630786L,4822862226L,226674524622L,13373796952698L,1110025147073934L,98792238089580126L,9978016047047592726UL,BigInteger.Parse("1067647717034092421682"),BigInteger.Parse("146267737233670661770434") };
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
public class A181737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181737Inst Instance=new A181737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181738
{
public static readonly long[] Value={ 1L,1L,1L,-2L,2L,1L,-8L,-6L,3L,1L,-8L,-32L,-12L,4L,1L,16L,-40L,-80L,-20L,5L,1L,64L,96L,-120L,-160L,-30L,6L,1L,64L,448L,336L,-280L,-280L,-42L,7L,1L,-128L,512L,1792L,896L,-560L,-448L,-56L,8L,1L,-512L,-1152L,2304L,5376L,2016L,-1008L,-672L,-72L,9L,1L,-512L,-5120L,-5760L,7680L,13440L,4032L,-1680L,-960L,-90L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181738Inst : IEnumerable<long>
{
public static readonly long[] Value=A181738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181738.Bytes);
public long this[int i]=>Value[i];

public static A181738Inst Instance=new A181738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181739
{
public static readonly long[] Value={ 106L,111L,121L,133L,141L,155L,161L,177L,183L,194L,1101L,1111L,1121L,1133L,1141L,1154L,1165L,1174L,1186L,1191L,1202L,1211L,1226L,1234L,1241L,1253L,1261L,1271L,1282L,1293L,1306L,1313L,1322L,1333L,1343L,1351L,1363L,1371L,1382L,1391L,1401L,1411L,2426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181739Inst : IEnumerable<long>
{
public static readonly long[] Value=A181739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181739.Bytes);
public long this[int i]=>Value[i];

public static A181739Inst Instance=new A181739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181740
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,18L,28L,44L,88L,100L,152L,240L,370L,556L,882L,750L,1500L,2250L,2784L,4284L,6438L,6062L,9526L,14856L,22944L,26164L,39528L,35122L,54800L,80940L,81326L,122422L,244844L,234934L,356154L,309068L,388042L,589796L,900000L,813466L,1212450L,1837030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181740Inst : IEnumerable<long>
{
public static readonly long[] Value=A181740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181740.Bytes);
public long this[int i]=>Value[i];

public static A181740Inst Instance=new A181740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181741
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,23L,29L,31L,47L,59L,61L,127L,191L,223L,239L,251L,383L,479L,503L,509L,991L,1019L,1021L,2039L,3583L,3967L,4079L,4091L,4093L,6143L,8191L,15359L,16127L,16319L,16381L,63487L,65407L,65519L,129023L,131063L,131071L,245759L,253951L,261631L,261887L,262079L,262111L,262127L,262139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181741Inst : IEnumerable<long>
{
public static readonly long[] Value=A181741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181741.Bytes);
public long this[int i]=>Value[i];

public static A181741Inst Instance=new A181741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181742
{
public static readonly long[] Value={ 3L,3L,4L,4L,4L,5L,5L,6L,6L,6L,6L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,11L,12L,12L,12L,12L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181742Inst : IEnumerable<long>
{
public static readonly long[] Value=A181742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181742.Bytes);
public long this[int i]=>Value[i];

public static A181742Inst Instance=new A181742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181743
{
public static readonly long[] Value={ 2L,1L,3L,2L,1L,3L,1L,5L,4L,2L,1L,7L,6L,5L,4L,2L,7L,5L,3L,1L,5L,2L,1L,3L,9L,7L,4L,2L,1L,11L,13L,10L,8L,6L,1L,11L,7L,4L,11L,3L,17L,14L,13L,9L,8L,6L,5L,4L,2L,11L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181743Inst : IEnumerable<long>
{
public static readonly long[] Value=A181743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181743.Bytes);
public long this[int i]=>Value[i];

public static A181743Inst Instance=new A181743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181744
{
public static readonly long[] Value={ 3L,5L,6L,7L,8L,10L,11L,12L,13L,14L,17L,19L,20L,22L,23L,26L,28L,29L,31L,34L,37L,38L,41L,43L,44L,46L,47L,52L,53L,58L,59L,61L,62L,67L,68L,71L,73L,74L,76L,79L,82L,83L,86L,89L,92L,94L,97L,101L,103L,106L,107L,109L,113L,116L,118L,122L,124L,127L,131L,134L,137L,139L,142L,146L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181744Inst : IEnumerable<long>
{
public static readonly long[] Value=A181744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181744.Bytes);
public long this[int i]=>Value[i];

public static A181744Inst Instance=new A181744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181745
{
public static readonly BigInteger[] Value={ 23L,719L,479001599L,BigInteger.Parse("265252859812191058636308479999999") };
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
public class A181745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181745Inst Instance=new A181745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181746
{
public static readonly BigInteger[] Value={ 8634368000L,BigInteger.Parse("175898504162692612600853299200000"),BigInteger.Parse("569584588357708246352221171200000000000"),BigInteger.Parse("30903356351561222538825891668691517440000") };
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
public class A181746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181746Inst Instance=new A181746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181747
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,29L,41L,59L,71L,101L,107L,137L,149L,179L,191L,197L,227L,239L,269L,281L,311L,347L,419L,431L,461L,521L,569L,599L,617L,641L,659L,809L,821L,827L,857L,881L,1019L,1031L,1049L,1061L,1091L,1151L,1229L,1277L,1289L,1301L,1319L,1427L,1451L,1481L,1487L,1607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181747Inst : IEnumerable<long>
{
public static readonly long[] Value=A181747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181747.Bytes);
public long this[int i]=>Value[i];

public static A181747Inst Instance=new A181747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181748
{
public static readonly long[] Value={ 3L,149L,599L,809L,1019L,1619L,2789L,2999L,3119L,3299L,3539L,4001L,4229L,4271L,4649L,5099L,6269L,6449L,6659L,6791L,6869L,7331L,7547L,8087L,8387L,8429L,8861L,9239L,9431L,9929L,10007L,11069L,11171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181748Inst : IEnumerable<long>
{
public static readonly long[] Value=A181748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181748.Bytes);
public long this[int i]=>Value[i];

public static A181748Inst Instance=new A181748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181749
{
public static readonly BigInteger[] Value={ 1L,24L,6384L,2306904L,964948464L,439331916888L,211383647188320L,105734905550405400L,BigInteger.Parse("54434276297806242480"),BigInteger.Parse("28652982232251791825880"),BigInteger.Parse("15350736081585866511795024"),BigInteger.Parse("8343014042738696079671066904"),BigInteger.Parse("4588687856038215036178166258304") };
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
public class A181749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181749Inst Instance=new A181749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181750
{
public static readonly BigInteger[] Value={ 1L,120L,291720L,1085674320L,4927561419120L,25071989721176760L,BigInteger.Parse("137401053406474591320"),BigInteger.Parse("793279085081986319145120"),BigInteger.Parse("4760210822189950253433759120"),BigInteger.Parse("29426738284267047709626231969120"),BigInteger.Parse("186257720453050086737999575854359760"),BigInteger.Parse("1201788369927033696254110199515917069120") };
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
public class A181750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181750Inst Instance=new A181750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181751
{
public static readonly BigInteger[] Value={ 1L,720L,19445040L,906140159280L,54259623434853360L,BigInteger.Parse("3751591832963936408880"),BigInteger.Parse("284751719071722748492598160"),BigInteger.Parse("23074162542675887567516737575120"),BigInteger.Parse("1962510523766609850302634846653001840"),BigInteger.Parse("173256558851090756974435967247639154062480") };
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
public class A181751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181751Inst Instance=new A181751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181752
{
public static readonly BigInteger[] Value={ 1L,5040L,1781750880L,1224777388630320L,BigInteger.Parse("1139907455908263095760"),BigInteger.Parse("1261774625300967410997361200"),BigInteger.Parse("1562711749309729990152410055981840"),BigInteger.Parse("2093930745462011336917616846237237197680"),BigInteger.Parse("2973970378870521024883907518445574302750687520") };
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
public class A181752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181752Inst Instance=new A181752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181753
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,2L,5L,6L,8L,2L,3L,4L,7L,2L,3L,5L,7L,8L,1L,4L,7L,8L,2L,4L,5L,6L,1L,4L,5L,7L,1L,2L,3L,6L,1L,2L,4L,6L,7L,8L,3L,6L,7L,1L,3L,4L,5L,8L,3L,4L,6L,8L,1L,2L,5L,8L,1L,3L,5L,6L,7L,2L,5L,6L,8L,2L,3L,4L,7L,2L,3L,5L,7L,8L,1L,4L,7L,8L,2L,4L,5L,6L,1L,4L,5L,7L,1L,2L,3L,6L,1L,2L,4L,6L,7L,8L,3L,6L,7L,1L,3L,4L,5L,8L,3L,4L,6L,8L,1L,2L,5L,8L,1L,3L,5L,6L,7L,2L,5L,6L,8L,2L,3L,4L,7L,2L,3L,5L,7L,8L,1L,4L,7L,8L,2L,4L,5L,6L,1L,4L,5L,7L,1L,2L,3L,6L,1L,2L,4L,6L,7L,8L,3L,6L,7L,1L,3L,4L,5L,8L,3L,4L,6L,8L,1L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181753Inst : IEnumerable<long>
{
public static readonly long[] Value=A181753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181753.Bytes);
public long this[int i]=>Value[i];

public static A181753Inst Instance=new A181753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181754
{
public static readonly BigInteger[] Value={ 1L,2L,6L,21L,601L,21001L,60100001L,2100100000001L,BigInteger.Parse("601000010000000000001"),BigInteger.Parse("2100100000001000000000000000000001"),BigInteger.Parse("6010000100000000000010000000000000000000000000000000001") };
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
public class A181754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181754Inst Instance=new A181754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181755
{
public static readonly BigInteger[] Value={ 1L,5L,3L,51L,301L,51001L,30100001L,5100100000001L,BigInteger.Parse("301000010000000000001"),BigInteger.Parse("5100100000001000000000000000000001"),BigInteger.Parse("3010000100000000000010000000000000000000000000000000001") };
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
public class A181755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181755Inst Instance=new A181755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181756
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1001L,110001L,1001000001L,1100010000000001L,BigInteger.Parse("10010000010000000000000001"),BigInteger.Parse("110001000000000100000000000000000000000001"),BigInteger.Parse("10010000010000000000000001000000000000000000000000000000000000000001") };
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
public class A181756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181756Inst Instance=new A181756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181757
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,2L,5L,6L,8L,2L,3L,4L,7L,2L,3L,5L,7L,8L,1L,4L,7L,8L,2L,4L,5L,6L,1L,4L,5L,7L,1L,2L,3L,6L,1L,2L,4L,6L,7L,8L,3L,6L,7L,1L,3L,4L,5L,8L,2L,4L,6L,8L,1L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181757Inst : IEnumerable<long>
{
public static readonly long[] Value=A181757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181757.Bytes);
public long this[int i]=>Value[i];

public static A181757Inst Instance=new A181757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181758
{
public static readonly long[] Value={ 2L,7L,29L,67L,127L,211L,347L,509L,727L,997L,1327L,1733L,2203L,2741L,3373L,4099L,4909L,5827L,6857L,7993L,9257L,10651L,12163L,13829L,15629L,17579L,19681L,21961L,24391L,26993L,29789L,32771L,35933L,39301L,42863L,46663L,50651L,54869L,59333L,63997L,68917L,74093L,79493L,85193L,91127L,97327L,103813L,110597L,117643L,125003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181758Inst : IEnumerable<long>
{
public static readonly long[] Value=A181758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181758.Bytes);
public long this[int i]=>Value[i];

public static A181758Inst Instance=new A181758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181759
{
public static readonly long[] Value={ 1L,36L,9L,0L,9L,36L,1L,144L,225L,12L,441L,576L,81L,900L,1089L,48L,1521L,1764L,75L,2304L,2601L,324L,3249L,3600L,147L,4356L,4761L,64L,5625L,6084L,729L,7056L,7569L,100L,8649L,9216L,363L,10404L,11025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181759Inst : IEnumerable<long>
{
public static readonly long[] Value=A181759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181759.Bytes);
public long this[int i]=>Value[i];

public static A181759Inst Instance=new A181759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181760
{
public static readonly BigInteger[] Value={ 1L,1L,2L,120L,255024L,22869362880L,136434451994755200L,BigInteger.Parse("82262786502445667337542400"),BigInteger.Parse("6980114960816118346901632738195814400"),BigInteger.Parse("109099864394915605737486658299863377337267988480000") };
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
public class A181760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181760Inst Instance=new A181760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181761
{
public static readonly long[] Value={ 18L,9L,27L,9L,36L,9L,45L,9L,54L,9L,63L,9L,72L,9L,81L,9L,90L,9L,99L,18L,117L,9L,126L,9L,135L,9L,144L,9L,153L,9L,162L,9L,171L,9L,180L,9L,189L,18L,207L,9L,216L,9L,225L,9L,234L,9L,243L,9L,252L,9L,261L,9L,270L,9L,279L,18L,297L,18L,315L,9L,324L,9L,333L,9L,342L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181761Inst : IEnumerable<long>
{
public static readonly long[] Value=A181761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181761.Bytes);
public long this[int i]=>Value[i];

public static A181761Inst Instance=new A181761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181762
{
public static readonly long[] Value={ 0L,8L,1L,14L,2L,20L,3L,26L,4L,32L,5L,38L,6L,44L,7L,50L,8L,56L,9L,62L,10L,68L,11L,74L,12L,80L,13L,86L,14L,92L,15L,98L,16L,104L,17L,110L,18L,116L,19L,122L,20L,128L,21L,134L,22L,140L,23L,146L,24L,152L,25L,158L,26L,164L,27L,170L,28L,176L,29L,182L,30L,188L,31L,194L,32L,200L,33L,206L,34L,212L,35L,218L,36L,224L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181762Inst : IEnumerable<long>
{
public static readonly long[] Value=A181762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181762.Bytes);
public long this[int i]=>Value[i];

public static A181762Inst Instance=new A181762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181763
{
public static readonly long[] Value={ 0L,25L,9L,441L,4L,2025L,225L,5929L,36L,13689L,1225L,27225L,144L,48841L,3969L,81225L,400L,127449L,9801L,190969L,900L,275625L,20449L,385641L,1764L,525625L,38025L,700569L,3136L,915849L,65025L,1177225L,5184L,1490841L,104329L,1863225L,8100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181763Inst : IEnumerable<long>
{
public static readonly long[] Value=A181763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181763.Bytes);
public long this[int i]=>Value[i];

public static A181763Inst Instance=new A181763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181764
{
public static readonly long[] Value={ 6L,8L,10L,13L,14L,19L,20L,24L,25L,26L,28L,34L,38L,48L,54L,55L,59L,71L,75L,92L,109L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181764Inst : IEnumerable<long>
{
public static readonly long[] Value=A181764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181764.Bytes);
public long this[int i]=>Value[i];

public static A181764Inst Instance=new A181764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181765
{
public static readonly long[] Value={ 0L,2L,12L,54L,230L,948L,3860L,15624L,63014L,253588L,1019072L,4091174L,16412668L,65808044L,263755984L,1056789662L,4233176854L,16953418148L,67885557896L,271793651816L,1088059997732L,4355377285932L,17432688395816L,69770793302408L,279227252601884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181765Inst : IEnumerable<long>
{
public static readonly long[] Value=A181765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181765.Bytes);
public long this[int i]=>Value[i];

public static A181765Inst Instance=new A181765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181766
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,11L,13L,14L,15L,16L,17L,19L,21L,23L,25L,26L,27L,28L,29L,31L,33L,35L,36L,37L,38L,39L,41L,42L,43L,45L,46L,47L,49L,51L,53L,54L,55L,56L,57L,59L,60L,61L,63L,65L,66L,67L,69L,70L,71L,73L,75L,76L,77L,79L,80L,81L,82L,83L,84L,85L,86L,87L,89L,91L,93L,94L,95L,96L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181766Inst : IEnumerable<long>
{
public static readonly long[] Value=A181766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181766.Bytes);
public long this[int i]=>Value[i];

public static A181766Inst Instance=new A181766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181767
{
public static readonly long[] Value={ 95L,111L,119L,123L,125L,62L,31L,15L,71L,99L,113L,56L,92L,46L,87L,43L,85L,42L,21L,74L,37L,82L,41L,84L,106L,117L,122L,61L,94L,47L,23L,75L,101L,50L,25L,76L,102L,115L,57L,28L,78L,103L,51L,89L,44L,86L,107L,53L,26L,13L,70L,35L,17L,8L,68L,34L,81L,104L,116L,58L,93L,110L,55L,27L,77L,38L,19L,9L,4L,66L,97L,112L,120L,60L,30L,79L,39L,83L,105L,52L,90L,109L,118L,59L,29L,14L,7L,3L,65L,32L,80L,40L,20L,10L,69L,98L,49L,88L,108L,54L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181767Inst : IEnumerable<long>
{
public static readonly long[] Value=A181767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181767.Bytes);
public long this[int i]=>Value[i];

public static A181767Inst Instance=new A181767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181768
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,15L,51L,188L,731L,2950L,12235L,51822L,223191L,974427L,4302645L,19181100L,86211885L,390248055L,1777495635L,8140539950L,37463689775L,173164232965L,803539474345L,3741930523740L,17481709707825L,81912506777200L,384847173838501L,1812610804416698L,8556895079642921L,40480850291739165L,191884148712996795L,911225151259732188L,4334673398737025619L,BigInteger.Parse("20653004146207902678"),BigInteger.Parse("98551406393189773875") };
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
public class A181768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181768Inst Instance=new A181768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181769
{
public static readonly long[] Value={ 1L,1L,1L,3L,7L,22L,73L,298L,1581L,11079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181769Inst : IEnumerable<long>
{
public static readonly long[] Value=A181769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181769.Bytes);
public long this[int i]=>Value[i];

public static A181769Inst Instance=new A181769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181770
{
public static readonly long[] Value={ 1L,1L,2L,6L,19L,74L,353L,2080L,16023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181770Inst : IEnumerable<long>
{
public static readonly long[] Value=A181770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181770.Bytes);
public long this[int i]=>Value[i];

public static A181770Inst Instance=new A181770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181771
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,2L,5L,3L,8L,1L,9L,10L,11L,0L,7L,9L,15L,12L,17L,10L,9L,0L,21L,42L,34L,0L,65L,13L,27L,24L,29L,17L,11L,0L,15L,73L,35L,0L,13L,33L,39L,26L,41L,9L,45L,0L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181771Inst : IEnumerable<long>
{
public static readonly long[] Value=A181771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181771.Bytes);
public long this[int i]=>Value[i];

public static A181771Inst Instance=new A181771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181772
{
public static readonly long[] Value={ 2L,6L,240L,196560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181772Inst : IEnumerable<long>
{
public static readonly long[] Value=A181772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181772.Bytes);
public long this[int i]=>Value[i];

public static A181772Inst Instance=new A181772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181773
{
public static readonly long[] Value={ 0L,48L,240L,672L,1440L,2640L,4368L,6720L,9792L,13680L,18480L,24288L,31200L,39312L,48720L,59520L,71808L,85680L,101232L,118560L,137760L,158928L,182160L,207552L,235200L,265200L,297648L,332640L,370272L,410640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181773Inst : IEnumerable<long>
{
public static readonly long[] Value=A181773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181773.Bytes);
public long this[int i]=>Value[i];

public static A181773Inst Instance=new A181773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181774
{
public static readonly long[] Value={ 1L,4L,6L,4L,2L,4L,6L,12L,6L,12L,24L,6L,12L,6L,30L,36L,6L,60L,12L,6L,12L,24L,18L,36L,42L,30L,30L,18L,90L,6L,36L,42L,6L,54L,60L,48L,18L,12L,18L,30L,60L,6L,18L,6L,42L,30L,42L,18L,42L,12L,54L,12L,30L,42L,66L,42L,78L,36L,36L,12L,36L,12L,48L,66L,54L,24L,66L,24L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181774Inst : IEnumerable<long>
{
public static readonly long[] Value=A181774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181774.Bytes);
public long this[int i]=>Value[i];

public static A181774Inst Instance=new A181774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181775
{
public static readonly long[] Value={ 153L,729L,900L,3420L,4221L,4500L,4779L,4851L,5400L,9153L,13500L,13779L,22500L,24498L,31500L,36927L,40500L,46647L,49221L,49779L,50202L,55152L,61353L,68994L,69894L,77499L,80064L,82872L,83637L,84249L,90495L,102402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181775Inst : IEnumerable<long>
{
public static readonly long[] Value=A181775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181775.Bytes);
public long this[int i]=>Value[i];

public static A181775Inst Instance=new A181775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181776
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,4L,1L,2L,2L,2L,2L,4L,2L,6L,2L,2L,4L,10L,1L,4L,2L,6L,2L,6L,2L,4L,2L,4L,4L,2L,2L,6L,6L,2L,2L,4L,2L,6L,4L,2L,10L,22L,2L,6L,4L,4L,2L,12L,6L,4L,2L,6L,6L,28L,2L,4L,4L,2L,4L,2L,4L,10L,4L,10L,2L,12L,2L,6L,6L,4L,6L,4L,2L,12L,2L,18L,4L,40L,2L,4L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181776Inst : IEnumerable<long>
{
public static readonly long[] Value=A181776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181776.Bytes);
public long this[int i]=>Value[i];

public static A181776Inst Instance=new A181776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181777
{
public static readonly long[] Value={ 7L,16L,106L,46L,158L,224L,177L,450L,860L,1454L,1441L,1660L,6769L,8494L,17094L,29821L,30734L,43478L,55906L,60716L,129608L,134345L,153505L,265860L,293161L,312164L,598067L,1158876L,1482529L,1771117L,2906179L,10197081L,11568589L,16927967L,18807193L,40055567L,40663017L,93778449L,181209792L,282515044L,323346876L,349304386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181777Inst : IEnumerable<long>
{
public static readonly long[] Value=A181777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181777.Bytes);
public long this[int i]=>Value[i];

public static A181777Inst Instance=new A181777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181778
{
public static readonly long[] Value={ 3L,4L,8L,9L,2L,5L,1L,3L,1L,1L,6L,4L,3L,0L,6L,6L,5L,7L,6L,7L,1L,2L,7L,8L,4L,8L,9L,8L,0L,7L,7L,0L,6L,5L,1L,5L,4L,9L,1L,6L,3L,7L,1L,1L,3L,2L,6L,5L,0L,9L,8L,1L,7L,3L,3L,9L,6L,6L,2L,5L,0L,1L,5L,6L,5L,4L,2L,8L,1L,8L,0L,9L,7L,6L,3L,6L,3L,9L,4L,2L,1L,7L,6L,0L,7L,2L,0L,6L,0L,8L,9L,5L,4L,0L,2L,9L,0L,8L,3L,2L,8L,3L,6L,8L,5L,5L,0L,1L,7L,7L,0L,3L,7L,8L,9L,2L,6L,0L,8L,4L,9L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181778Inst : IEnumerable<long>
{
public static readonly long[] Value=A181778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181778.Bytes);
public long this[int i]=>Value[i];

public static A181778Inst Instance=new A181778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181779
{
public static readonly long[] Value={ 2L,5L,1L,1L,1L,10L,1L,1L,2L,8L,7643L,4L,1L,51L,2L,2L,8L,5L,2L,1L,6L,5L,4L,1L,42L,2L,1L,1L,1L,1L,1L,1L,1L,6L,2L,6L,2L,12L,2L,1L,6L,3L,13L,11L,2L,9L,2L,1L,4L,1L,2L,1L,6L,3L,1L,1L,1L,11L,3L,1L,2L,1L,1L,2L,3L,3L,1L,2L,3L,1L,56L,1L,24L,6L,20L,3L,27L,2L,1L,2L,1L,2L,5L,2L,1L,1L,14L,1L,91L,1L,2L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,36L,1L,1L,1L,4L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,16L,21L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181779Inst : IEnumerable<long>
{
public static readonly long[] Value=A181779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181779.Bytes);
public long this[int i]=>Value[i];

public static A181779Inst Instance=new A181779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181780
{
public static readonly long[] Value={ 15L,21L,25L,28L,33L,35L,39L,45L,49L,51L,52L,55L,57L,63L,65L,66L,69L,70L,75L,76L,77L,85L,87L,91L,93L,95L,99L,105L,111L,112L,115L,117L,119L,121L,123L,124L,125L,129L,130L,133L,135L,141L,143L,145L,147L,148L,153L,154L,155L,159L,161L,165L,169L,171L,172L,175L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181780Inst : IEnumerable<long>
{
public static readonly long[] Value=A181780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181780.Bytes);
public long this[int i]=>Value[i];

public static A181780Inst Instance=new A181780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181781
{
public static readonly long[] Value={ 21L,25L,33L,45L,49L,57L,65L,69L,77L,85L,91L,93L,105L,117L,121L,125L,129L,133L,141L,145L,153L,161L,165L,169L,175L,177L,185L,189L,201L,205L,209L,213L,217L,221L,225L,231L,237L,245L,247L,249L,253L,259L,261L,265L,273L,285L,289L,297L,301L,305L,309L,321L,325L,329L,333L,341L,343L,345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181781Inst : IEnumerable<long>
{
public static readonly long[] Value=A181781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181781.Bytes);
public long this[int i]=>Value[i];

public static A181781Inst Instance=new A181781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181782
{
public static readonly long[] Value={ 25L,49L,65L,85L,91L,121L,125L,133L,145L,169L,175L,185L,205L,217L,221L,231L,247L,259L,265L,289L,301L,305L,325L,341L,343L,361L,365L,377L,385L,403L,425L,427L,435L,445L,451L,469L,475L,481L,485L,493L,505L,511L,529L,533L,545L,553L,559L,561L,565L,589L,595L,625L,629L,637L,645L,651L,671L,679L,685L,689L,697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181782Inst : IEnumerable<long>
{
public static readonly long[] Value=A181782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181782.Bytes);
public long this[int i]=>Value[i];

public static A181782Inst Instance=new A181782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181783
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,5L,4L,1L,1L,1L,16L,21L,7L,1L,1L,1L,65L,142L,63L,11L,1L,1L,1L,326L,1201L,709L,151L,16L,1L,1L,1L,1957L,12336L,9709L,2521L,311L,22L,1L,1L,1L,13700L,149989L,157971L,50045L,7186L,575L,29L,1L,1L,1L,10960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181783Inst : IEnumerable<long>
{
public static readonly long[] Value=A181783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181783.Bytes);
public long this[int i]=>Value[i];

public static A181783Inst Instance=new A181783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181784
{
public static readonly long[] Value={ 1L,1L,4L,22L,140L,969L,7084L,53820L,420732L,3782992L,32389076L,275617830L,2350749914L,20140518790L,173429992350L,1500850805160L,14550277251918L,133009333771170L,1198324107797254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181784Inst : IEnumerable<long>
{
public static readonly long[] Value=A181784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181784.Bytes);
public long this[int i]=>Value[i];

public static A181784Inst Instance=new A181784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181785
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,25L,48L,107L,193L,365L,621L,1082L,1715L,2777L,4247L,6519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181785Inst : IEnumerable<long>
{
public static readonly long[] Value=A181785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181785.Bytes);
public long this[int i]=>Value[i];

public static A181785Inst Instance=new A181785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181786
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,1L,0L,3L,0L,2L,1L,1L,1L,3L,0L,2L,3L,3L,0L,6L,2L,3L,1L,2L,1L,8L,1L,3L,3L,4L,0L,10L,2L,5L,3L,4L,3L,8L,0L,5L,6L,6L,2L,11L,3L,6L,1L,8L,2L,12L,1L,6L,8L,8L,1L,15L,3L,8L,3L,7L,4L,20L,0L,6L,10L,9L,2L,16L,5L,9L,3L,9L,4L,15L,3L,15L,8L,10L,0L,22L,5L,11L,6L,9L,6L,18L,2L,11L,11L,14L,3L,21L,6L,13L,1L,12L,8L,31L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181786Inst : IEnumerable<long>
{
public static readonly long[] Value=A181786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181786.Bytes);
public long this[int i]=>Value[i];

public static A181786Inst Instance=new A181786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181787
{
public static readonly long[] Value={ 0L,0L,0L,3L,0L,0L,3L,6L,0L,12L,0L,9L,3L,6L,6L,15L,0L,9L,12L,15L,0L,33L,9L,18L,3L,12L,6L,39L,6L,18L,15L,24L,0L,48L,9L,30L,12L,24L,15L,45L,0L,27L,33L,33L,9L,60L,18L,36L,3L,48L,12L,60L,6L,36L,39L,45L,6L,78L,18L,45L,15L,42L,24L,114L,0L,36L,48L,51L,9L,93L,30L,54L,12L,51L,24L,87L,15L,87L,45L,60L,0L,120L,27L,63L,33L,51L,33L,105L,9L,63L,60L,84L,18L,123L,36L,75L,3L,69L,48L,165L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181787Inst : IEnumerable<long>
{
public static readonly long[] Value=A181787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181787.Bytes);
public long this[int i]=>Value[i];

public static A181787Inst Instance=new A181787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181788
{
public static readonly long[] Value={ 1L,3L,3L,6L,3L,9L,6L,9L,3L,15L,9L,12L,6L,15L,9L,24L,3L,18L,15L,18L,9L,36L,12L,21L,6L,27L,15L,42L,9L,27L,24L,27L,3L,51L,18L,39L,15L,33L,18L,54L,9L,36L,36L,36L,12L,69L,21L,39L,6L,51L,27L,69L,15L,45L,42L,54L,9L,81L,27L,48L,24L,51L,27L,117L,3L,63L,51L,54L,18L,96L,39L,57L,15L,60L,33L,102L,18L,90L,54L,63L,9L,123L,36L,66L,36L,78L,36L,114L,12L,72L,69L,93L,21L,126L,39L,84L,6L,78L,51L,168L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181788Inst : IEnumerable<long>
{
public static readonly long[] Value=A181788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181788.Bytes);
public long this[int i]=>Value[i];

public static A181788Inst Instance=new A181788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181789
{
public static readonly BigInteger[] Value={ BigInteger.Parse("183673469387755102041183673469387755102041"),BigInteger.Parse("326530612244897959184326530612244897959184"),BigInteger.Parse("734693877551020408164734693877551020408164"),BigInteger.Parse("132231404958677685950413223140496132231404958677685950413223140496") };
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
public class A181789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181789Inst Instance=new A181789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181790
{
public static readonly BigInteger[] Value={ BigInteger.Parse("183673469387755102041"),BigInteger.Parse("326530612244897959184"),BigInteger.Parse("734693877551020408164"),BigInteger.Parse("132231404958677685950413223140496"),BigInteger.Parse("206611570247933884297520661157025"),BigInteger.Parse("297520661157024793388429752066116"),BigInteger.Parse("404958677685950413223140495867769") };
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
public class A181790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181790Inst Instance=new A181790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181791
{
public static readonly BigInteger[] Value={ BigInteger.Parse("428571428571428571429"),BigInteger.Parse("571428571428571428572"),BigInteger.Parse("857142857142857142858"),BigInteger.Parse("363636363636363636363636363636364"),BigInteger.Parse("454545454545454545454545454545455"),BigInteger.Parse("545454545454545454545454545454546"),BigInteger.Parse("636363636363636363636363636363637") };
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
public class A181791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181791Inst Instance=new A181791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181792
{
public static readonly long[] Value={ 28L,52L,76L,84L,124L,148L,156L,172L,175L,228L,244L,252L,268L,292L,316L,325L,372L,388L,412L,436L,444L,468L,475L,508L,516L,525L,556L,604L,628L,652L,684L,700L,724L,732L,756L,772L,775L,796L,804L,844L,847L,876L,892L,916L,925L,948L,964L,975L,1075L,1084L,1108L,1116L,1132L,1164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181792Inst : IEnumerable<long>
{
public static readonly long[] Value=A181792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181792.Bytes);
public long this[int i]=>Value[i];

public static A181792Inst Instance=new A181792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181793
{
public static readonly long[] Value={ 28L,52L,76L,124L,148L,172L,175L,244L,268L,292L,316L,325L,388L,412L,436L,475L,508L,556L,604L,628L,652L,724L,772L,775L,796L,844L,847L,892L,916L,925L,964L,1075L,1084L,1108L,1132L,1228L,1252L,1324L,1348L,1396L,1468L,1492L,1516L,1525L,1573L,1588L,1636L,1675L,1684L,1732L,1756L,1825L,1828L,1852L,1948L,1975L,1996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181793Inst : IEnumerable<long>
{
public static readonly long[] Value=A181793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181793.Bytes);
public long this[int i]=>Value[i];

public static A181793Inst Instance=new A181793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181794
{
public static readonly long[] Value={ 4L,6L,10L,12L,14L,16L,20L,22L,24L,26L,28L,34L,36L,38L,44L,46L,48L,52L,58L,62L,68L,74L,76L,80L,82L,86L,90L,92L,94L,106L,112L,116L,118L,120L,122L,124L,126L,134L,142L,144L,146L,148L,150L,158L,160L,164L,166L,168L,172L,176L,178L,180L,188L,192L,194L,198L,202L,206L,208L,212L,214L,216L,218L,226L,234L,236L,240L,244L,252L,254L,256L,262L,264L,268L,272L,274L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181794Inst : IEnumerable<long>
{
public static readonly long[] Value=A181794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181794.Bytes);
public long this[int i]=>Value[i];

public static A181794Inst Instance=new A181794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181795
{
public static readonly long[] Value={ 4L,16L,36L,144L,256L,576L,900L,1764L,2304L,2500L,3600L,4356L,6084L,7056L,8100L,10000L,10404L,12996L,17424L,19044L,22500L,24336L,26244L,30276L,32400L,34596L,36864L,41616L,49284L,51984L,57600L,60516L,65536L,66564L,76176L,79524L,90000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181795Inst : IEnumerable<long>
{
public static readonly long[] Value=A181795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181795.Bytes);
public long this[int i]=>Value[i];

public static A181795Inst Instance=new A181795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181796
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,2L,4L,3L,3L,2L,5L,2L,3L,3L,5L,2L,5L,2L,5L,3L,3L,2L,7L,3L,3L,4L,5L,2L,4L,2L,6L,3L,3L,3L,7L,2L,3L,3L,7L,2L,4L,2L,5L,5L,3L,2L,9L,3L,5L,3L,5L,2L,7L,3L,7L,3L,3L,2L,7L,2L,3L,5L,7L,3L,4L,2L,5L,3L,4L,2L,10L,2L,3L,5L,5L,3L,4L,2L,9L,5L,3L,2L,7L,3L,3L,3L,7L,2L,7L,3L,5L,3L,3L,3L,11L,2L,5L,5L,7L,2L,4L,2L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181796Inst : IEnumerable<long>
{
public static readonly long[] Value=A181796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181796.Bytes);
public long this[int i]=>Value[i];

public static A181796Inst Instance=new A181796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181797
{
public static readonly long[] Value={ 1L,6L,12L,12L,30L,72L,56L,24L,36L,180L,132L,144L,182L,336L,360L,48L,306L,216L,380L,360L,672L,792L,552L,288L,150L,1092L,108L,672L,870L,2160L,992L,96L,1584L,1836L,1680L,432L,1406L,2280L,2184L,720L,1722L,4032L,1892L,1584L,1080L,3312L,2256L,576L,392L,900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181797Inst : IEnumerable<long>
{
public static readonly long[] Value=A181797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181797.Bytes);
public long this[int i]=>Value[i];

public static A181797Inst Instance=new A181797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181798
{
public static readonly long[] Value={ 1L,6L,12L,12L,24L,30L,36L,48L,56L,72L,96L,108L,132L,144L,150L,180L,182L,192L,216L,288L,306L,324L,336L,360L,360L,380L,384L,392L,432L,552L,576L,648L,672L,672L,720L,750L,768L,792L,864L,870L,900L,972L,992L,1080L,1092L,1152L,1296L,1344L,1406L,1440L,1452L,1536L,1584L,1584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181798Inst : IEnumerable<long>
{
public static readonly long[] Value=A181798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181798.Bytes);
public long this[int i]=>Value[i];

public static A181798Inst Instance=new A181798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181799
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,5L,9L,16L,7L,6L,32L,27L,11L,12L,25L,10L,13L,64L,18L,24L,17L,81L,14L,15L,20L,19L,128L,49L,36L,23L,48L,54L,21L,28L,40L,125L,256L,22L,72L,29L,50L,243L,31L,45L,26L,96L,108L,56L,37L,80L,121L,512L,33L,44L,35L,41L,144L,100L,34L,43L,162L,63L,30L,39L,52L,47L,38L,192L,98L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181799Inst : IEnumerable<long>
{
public static readonly long[] Value=A181799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181799.Bytes);
public long this[int i]=>Value[i];

public static A181799Inst Instance=new A181799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181800
{
public static readonly long[] Value={ 1L,4L,8L,16L,32L,36L,64L,72L,128L,144L,216L,256L,288L,432L,512L,576L,864L,900L,1024L,1152L,1296L,1728L,1800L,2048L,2304L,2592L,3456L,3600L,4096L,4608L,5184L,5400L,6912L,7200L,7776L,8192L,9216L,10368L,10800L,13824L,14400L,15552L,16384L,18432L,20736L,21600L,27000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181800Inst : IEnumerable<long>
{
public static readonly long[] Value=A181800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181800.Bytes);
public long this[int i]=>Value[i];

public static A181800Inst Instance=new A181800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181801
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,3L,1L,3L,1L,2L,1L,5L,1L,2L,1L,3L,1L,3L,1L,3L,1L,2L,1L,6L,1L,2L,1L,3L,1L,3L,1L,3L,1L,2L,1L,6L,1L,2L,1L,3L,1L,3L,1L,3L,1L,2L,1L,7L,1L,2L,1L,3L,1L,3L,1L,3L,1L,2L,1L,6L,1L,2L,1L,3L,1L,3L,1L,3L,1L,2L,1L,7L,1L,2L,1L,3L,1L,3L,1L,3L,1L,2L,1L,5L,1L,2L,1L,3L,1L,3L,1L,3L,1L,2L,1L,7L,1L,2L,1L,3L,1L,3L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181801Inst : IEnumerable<long>
{
public static readonly long[] Value=A181801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181801.Bytes);
public long this[int i]=>Value[i];

public static A181801Inst Instance=new A181801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181802
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,4L,1L,1L,2L,6L,1L,1L,2L,4L,1L,1L,2L,1L,1L,2L,4L,6L,12L,1L,1L,2L,1L,1L,2L,4L,1L,1L,2L,6L,1L,1L,2L,4L,1L,1L,2L,1L,1L,2L,4L,6L,12L,24L,1L,1L,2L,1L,1L,2L,4L,1L,1L,2L,6L,1L,1L,2L,4L,1L,1L,2L,1L,1L,2L,4L,6L,12L,36L,1L,1L,2L,1L,1L,2L,4L,1L,1L,2L,6L,1L,1L,2L,4L,1L,1L,2L,1L,1L,2L,4L,6L,12L,24L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181802Inst : IEnumerable<long>
{
public static readonly long[] Value=A181802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181802.Bytes);
public long this[int i]=>Value[i];

public static A181802Inst Instance=new A181802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181803
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,4L,5L,1L,3L,6L,7L,2L,4L,8L,9L,5L,10L,11L,1L,2L,3L,6L,12L,13L,7L,14L,15L,4L,8L,16L,17L,3L,9L,18L,19L,5L,10L,20L,21L,11L,22L,23L,1L,2L,4L,6L,12L,24L,25L,13L,26L,27L,7L,14L,28L,29L,5L,15L,30L,31L,8L,16L,32L,33L,17L,34L,35L,1L,3L,6L,9L,18L,36L,37L,19L,38L,39L,10L,20L,40L,41L,7L,21L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181803Inst : IEnumerable<long>
{
public static readonly long[] Value=A181803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181803.Bytes);
public long this[int i]=>Value[i];

public static A181803Inst Instance=new A181803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181804
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,24L,36L,48L,60L,72L,120L,144L,180L,240L,360L,720L,840L,1260L,1680L,2520L,5040L,7560L,10080L,15120L,20160L,25200L,27720L,30240L,45360L,50400L,55440L,60480L,75600L,83160L,90720L,100800L,110880L,151200L,166320L,181440L,221760L,226800L,277200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181804Inst : IEnumerable<long>
{
public static readonly long[] Value=A181804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181804.Bytes);
public long this[int i]=>Value[i];

public static A181804Inst Instance=new A181804Inst();

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