using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A278206
{
public static readonly BigInteger[] Value={ 0L,601L,34869L,1674402L,93838003L,5306819216L,297169006604L,16636687338399L,931945034345185L,52205261260655693L,2924300169544392520L,BigInteger.Parse("163806092390120341088"),BigInteger.Parse("9175698877050626080778"),BigInteger.Parse("513982345733812946152984") };
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
public class A278206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278206Inst Instance=new A278206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278207
{
public static readonly BigInteger[] Value={ 0L,2208L,251260L,23732454L,2644587148L,297169006604L,33056811286568L,3676498268449668L,409137247202506544L,BigInteger.Parse("45530553691308851854"),BigInteger.Parse("5066646847508250491070"),BigInteger.Parse("563817868393293695820130") };
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
public class A278207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278207Inst Instance=new A278207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278208
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,0L,15L,15L,0L,0L,46L,97L,46L,0L,0L,161L,666L,666L,161L,0L,0L,601L,4827L,8242L,4827L,601L,0L,0L,2208L,34869L,117088L,117088L,34869L,2208L,0L,0L,8053L,251260L,1674402L,3295771L,1674402L,251260L,8053L,0L,0L,29415L,1811189L,23732454L,93838003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278208Inst : IEnumerable<long>
{
public static readonly long[] Value=A278208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278208.Bytes);
public long this[int i]=>Value[i];

public static A278208Inst Instance=new A278208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278209
{
public static readonly long[] Value={ 1L,2L,3L,11L,30L,9L,73L,26L,56L,32L,202L,55L,41L,86L,45L,55L,54L,58L,43L,70L,107L,224L,92L,98L,110L,173L,73L,115L,102L,73L,140L,128L,335L,97L,132L,129L,109L,128L,129L,113L,133L,207L,253L,301L,310L,239L,180L,244L,122L,152L,178L,245L,249L,351L,536L,262L,252L,314L,202L,310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278209Inst : IEnumerable<long>
{
public static readonly long[] Value=A278209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278209.Bytes);
public long this[int i]=>Value[i];

public static A278209Inst Instance=new A278209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278210
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,6L,4L,8L,9L,10L,4L,6L,6L,4L,12L,0L,8L,10L,8L,6L,10L,18L,16L,21L,13L,16L,27L,24L,19L,27L,8L,10L,26L,29L,18L,25L,16L,0L,28L,27L,6L,32L,21L,19L,33L,13L,13L,13L,21L,0L,18L,23L,48L,28L,16L,26L,34L,26L,4L,33L,35L,4L,40L,52L,10L,65L,34L,62L,16L,40L,12L,66L,48L,21L,18L,6L,13L,72L,46L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278210Inst : IEnumerable<long>
{
public static readonly long[] Value=A278210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278210.Bytes);
public long this[int i]=>Value[i];

public static A278210Inst Instance=new A278210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278211
{
public static readonly long[] Value={ 0L,4L,12L,28L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278211Inst : IEnumerable<long>
{
public static readonly long[] Value=A278211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278211.Bytes);
public long this[int i]=>Value[i];

public static A278211Inst Instance=new A278211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278244
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,2L,6L,2L,6L,2L,6L,6L,2L,6L,2L,6L,6L,2L,6L,2L,4L,12L,2L,30L,2L,2L,6L,6L,24L,2L,2L,6L,2L,6L,2L,2L,30L,6L,6L,2L,6L,30L,2L,6L,6L,6L,12L,2L,6L,12L,2L,6L,6L,12L,6L,6L,6L,6L,12L,6L,2L,30L,6L,6L,6L,2L,30L,6L,6L,2L,2L,12L,2L,6L,6L,6L,6L,6L,60L,2L,6L,6L,2L,6L,2L,2L,30L,2L,30L,6L,2L,30L,6L,30L,6L,30L,24L,2L,6L,2L,2L,30L,2L,12L,2L,6L,30L,6L,30L,2L,2L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278244Inst : IEnumerable<long>
{
public static readonly long[] Value=A278244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278244.Bytes);
public long this[int i]=>Value[i];

public static A278244Inst Instance=new A278244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278245
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,8L,2L,6L,6L,6L,2L,144L,2L,6L,30L,30L,2L,120L,6L,210L,30L,6L,2L,10080L,12L,6L,210L,210L,2L,9240L,6L,210L,30L,6L,30L,166320L,30L,30L,30L,30030L,6L,9240L,2L,2310L,2310L,30L,2L,2882880L,30L,4620L,30L,210L,6L,120120L,210L,60060L,2310L,30L,6L,232792560L,6L,30L,2310L,30030L,30L,9240L,30L,2310L,2310L,510510L,6L,1396755360L,6L,210L,4620L,2310L,210L,120120L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278245Inst : IEnumerable<long>
{
public static readonly long[] Value=A278245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278245.Bytes);
public long this[int i]=>Value[i];

public static A278245Inst Instance=new A278245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278246
{
public static readonly long[] Value={ 2L,2L,4L,6L,12L,8L,6L,12L,24L,6L,6L,60L,24L,6L,24L,24L,30L,24L,6L,30L,180L,12L,6L,144L,60L,6L,48L,30L,48L,60L,6L,240L,120L,6L,30L,120L,60L,6L,60L,60L,30L,120L,6L,30L,1080L,12L,12L,360L,60L,12L,48L,210L,60L,48L,30L,60L,420L,6L,6L,840L,96L,30L,120L,96L,210L,60L,30L,30L,360L,30L,6L,1800L,30L,30L,180L,30L,840L,96L,6L,120L,480L,30L,6L,420L,420L,6L,120L,420L,30L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278246Inst : IEnumerable<long>
{
public static readonly long[] Value=A278246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278246.Bytes);
public long this[int i]=>Value[i];

public static A278246Inst Instance=new A278246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278247
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,6L,2L,6L,2L,2L,6L,6L,2L,2L,2L,6L,6L,2L,6L,2L,6L,2L,6L,2L,2L,6L,6L,6L,2L,8L,6L,2L,2L,6L,2L,12L,6L,2L,2L,2L,30L,2L,6L,2L,6L,30L,2L,2L,2L,2L,6L,6L,2L,2L,6L,30L,6L,2L,2L,2L,6L,2L,6L,2L,6L,6L,6L,6L,6L,2L,6L,6L,6L,30L,6L,6L,2L,12L,2L,2L,6L,6L,2L,6L,6L,30L,2L,2L,6L,2L,6L,6L,6L,2L,2L,30L,2L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,2L,2L,6L,30L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278247Inst : IEnumerable<long>
{
public static readonly long[] Value=A278247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278247.Bytes);
public long this[int i]=>Value[i];

public static A278247Inst Instance=new A278247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278248
{
public static readonly long[] Value={ 2L,0L,2L,2L,2L,2L,2L,2L,6L,12L,2L,6L,2L,6L,6L,12L,60L,6L,6L,6L,2L,2L,96L,60L,2L,30L,6L,6L,6L,840L,30L,6L,30L,6L,2L,6L,6L,60L,2L,420L,1260L,30L,30L,420L,210L,30L,30L,210L,6L,30L,30L,12L,6L,2310L,30L,840L,6L,240L,6L,30L,6L,420L,6L,6L,30L,420L,6L,210L,6L,6L,6L,4620L,60L,210L,30030L,2L,6L,30L,2310L,13860L,60L,210L,6L,6L,6L,120L,6L,2310L,210L,210L,6L,210L,30L,60L,4620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278248Inst : IEnumerable<long>
{
public static readonly long[] Value=A278248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278248.Bytes);
public long this[int i]=>Value[i];

public static A278248Inst Instance=new A278248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278249
{
public static readonly long[] Value={ 1L,2L,4L,6L,6L,6L,12L,6L,36L,6L,60L,6L,6L,30L,60L,6L,6L,30L,12L,210L,210L,180L,12L,30L,12L,30L,900L,60L,6L,6L,60L,30L,12L,210L,720L,30L,420L,30L,60L,6L,12L,30L,60L,6L,6L,60L,60L,30L,60L,210L,2520L,210L,210L,30L,180L,210L,60L,120L,60L,210L,6L,30L,60L,30L,6L,30L,60L,30L,6L,30L,12L,30L,60L,30L,420L,210L,60L,30L,420L,60L,6L,30L,2520L,30L,30L,210L,12L,210L,60L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278249Inst : IEnumerable<long>
{
public static readonly long[] Value=A278249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278249.Bytes);
public long this[int i]=>Value[i];

public static A278249Inst Instance=new A278249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278250
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,6L,2L,2L,6L,12L,12L,6L,2L,2L,60L,30L,2L,6L,120L,6L,6L,180L,2L,12L,30L,210L,6L,2L,2L,30L,210L,6L,30L,900900L,30L,180L,24L,210L,60060L,210L,13860L,120L,210L,210L,210L,96L,30L,60060L,6126120L,2310L,30L,60L,2310L,2310L,30L,4620L,210L,240L,210L,120L,30L,60L,2L,1260L,30L,30L,2310L,2310L,60L,18480L,30L,2310L,420L,30L,2310L,18480L,30L,3360L,210L,2L,420L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278250Inst : IEnumerable<long>
{
public static readonly long[] Value=A278250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278250.Bytes);
public long this[int i]=>Value[i];

public static A278250Inst Instance=new A278250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278251
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,6L,2L,2L,6L,2L,6L,6L,6L,2L,6L,2L,2L,30L,2L,8L,6L,2L,2L,12L,6L,2L,30L,6L,2L,6L,6L,12L,6L,6L,2L,6L,6L,6L,30L,2L,6L,6L,2L,6L,6L,6L,6L,30L,6L,6L,30L,2L,6L,6L,6L,2L,30L,6L,2L,30L,2L,6L,30L,2L,6L,30L,6L,2L,60L,12L,2L,6L,2L,6L,6L,30L,2L,6L,2L,2L,60L,2L,30L,6L,6L,6L,6L,6L,30L,30L,2L,2L,6L,6L,6L,30L,6L,6L,6L,6L,2L,210L,2L,30L,6L,6L,2L,30L,30L,6L,30L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278251Inst : IEnumerable<long>
{
public static readonly long[] Value=A278251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278251.Bytes);
public long this[int i]=>Value[i];

public static A278251Inst Instance=new A278251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278252
{
public static readonly long[] Value={ 1L,4L,6L,12L,6L,24L,60L,120L,30L,60L,30L,60L,30L,240L,120L,240L,30L,420L,210L,420L,30L,120L,180L,360L,180L,1260L,420L,420L,30L,480L,240L,480L,210L,4620L,2310L,420L,30L,840L,420L,840L,30L,420L,2310L,4620L,210L,240L,360L,3600L,180L,1260L,210L,1260L,420L,27720L,4620L,840L,30L,420L,210L,420L,210L,6720L,36960L,6720L,210L,420L,210L,4620L,210L,9240L,420L,840L,60L,1260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278252Inst : IEnumerable<long>
{
public static readonly long[] Value=A278252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278252.Bytes);
public long this[int i]=>Value[i];

public static A278252Inst Instance=new A278252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278253
{
public static readonly long[] Value={ 1L,2L,6L,6L,6L,6L,12L,36L,12L,6L,30L,30L,6L,30L,120L,24L,12L,12L,30L,210L,30L,6L,60L,180L,12L,24L,120L,30L,30L,30L,48L,240L,30L,30L,420L,60L,6L,30L,420L,60L,30L,30L,30L,420L,60L,6L,120L,360L,36L,60L,210L,30L,24L,120L,420L,420L,30L,6L,210L,210L,6L,60L,1440L,480L,210L,30L,30L,210L,210L,30L,180L,180L,6L,60L,420L,210L,210L,30L,120L,2160L,48L,6L,210L,2310L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278253Inst : IEnumerable<long>
{
public static readonly long[] Value=A278253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278253.Bytes);
public long this[int i]=>Value[i];

public static A278253Inst Instance=new A278253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278254
{
public static readonly long[] Value={ 1L,4L,4L,16L,4L,36L,4L,64L,16L,36L,4L,144L,4L,36L,36L,256L,4L,144L,4L,144L,36L,36L,4L,576L,16L,36L,64L,144L,4L,900L,4L,1024L,36L,36L,36L,1296L,4L,36L,36L,576L,4L,900L,4L,144L,144L,36L,4L,2304L,16L,144L,36L,144L,4L,576L,36L,576L,36L,36L,4L,3600L,4L,36L,144L,4096L,36L,900L,4L,144L,36L,900L,4L,5184L,4L,36L,144L,144L,36L,900L,4L,2304L,256L,36L,4L,3600L,36L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278254Inst : IEnumerable<long>
{
public static readonly long[] Value=A278254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278254.Bytes);
public long this[int i]=>Value[i];

public static A278254Inst Instance=new A278254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278255
{
public static readonly long[] Value={ 1L,2L,12L,6L,6L,6L,30L,12L,12L,6L,48L,210L,6L,6L,210L,24L,12L,12L,60L,30L,30L,30L,30L,60L,12L,30L,1080L,30L,6L,30L,30L,240L,60L,6L,420L,60L,30L,6L,210L,420L,6L,120L,192L,30L,60L,6L,210L,840L,12L,12L,420L,210L,6L,120L,210L,60L,210L,6L,120L,210L,30L,30L,420L,96L,30L,30L,180L,210L,30L,210L,30L,1260L,6L,30L,5040L,30L,210L,30L,30L,120L,144L,60L,60L,210L,30L,6L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278255Inst : IEnumerable<long>
{
public static readonly long[] Value=A278255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278255.Bytes);
public long this[int i]=>Value[i];

public static A278255Inst Instance=new A278255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278256
{
public static readonly long[] Value={ 2L,6L,12L,12L,30L,30L,24L,72L,60L,30L,60L,60L,30L,210L,240L,48L,60L,60L,60L,420L,210L,30L,120L,360L,60L,120L,360L,60L,210L,210L,96L,480L,210L,210L,1260L,180L,30L,210L,840L,120L,210L,210L,60L,1260L,420L,30L,240L,720L,180L,420L,420L,60L,120L,840L,840L,840L,210L,30L,420L,420L,30L,420L,2880L,960L,2310L,210L,60L,420L,2310L,210L,360L,360L,30L,420L,1260L,420L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278256Inst : IEnumerable<long>
{
public static readonly long[] Value=A278256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278256.Bytes);
public long this[int i]=>Value[i];

public static A278256Inst Instance=new A278256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278257
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,6L,2L,6L,16L,12L,2L,6L,2L,4L,6L,2L,32L,6L,6L,6L,6L,2L,30L,6L,2L,4L,12L,2L,24L,24L,6L,12L,64L,30L,2L,30L,2L,2L,6L,30L,2L,16L,6L,6L,6L,24L,2L,6L,6L,2L,12L,2L,30L,24L,30L,2L,30L,48L,2L,12L,12L,6L,120L,2L,128L,30L,2L,6L,24L,2L,30L,6L,6L,6L,6L,2L,60L,24L,12L,6L,6L,6L,48L,30L,6L,120L,4L,2L,30L,48L,6L,180L,2L,6L,24L,30L,2L,2L,6L,2L,60L,72L,6L,6L,6L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278257Inst : IEnumerable<long>
{
public static readonly long[] Value=A278257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278257.Bytes);
public long this[int i]=>Value[i];

public static A278257Inst Instance=new A278257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278258
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,30L,60L,30L,210L,210L,420L,2310L,4620L,13860L,360360L,60060L,1021020L,9699690L,58198140L,223092870L,446185740L,446185740L,892371480L,1338557220L,1338557220L,6692786100L,2677114440L,12939386460L,802241960520L,802241960520L,1604483921040L,200560490130L,14841476269620L,608500527054420L,608500527054420L,304250263527210L,608500527054420L,608500527054420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278258Inst : IEnumerable<long>
{
public static readonly long[] Value=A278258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278258.Bytes);
public long this[int i]=>Value[i];

public static A278258Inst Instance=new A278258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278259
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,4L,12L,16L,12L,4L,30L,36L,30L,4L,24L,64L,72L,16L,60L,36L,30L,4L,60L,144L,60L,4L,30L,36L,210L,36L,240L,256L,48L,4L,60L,144L,60L,4L,60L,144L,420L,36L,210L,36L,30L,4L,120L,576L,360L,16L,60L,36L,120L,64L,360L,144L,60L,4L,210L,900L,210L,4L,96L,1024L,480L,36L,210L,36L,210L,36L,1260L,1296L,180L,4L,30L,36L,210L,36L,840L,576L,120L,4L,210L,900L,210L,4L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278259Inst : IEnumerable<long>
{
public static readonly long[] Value=A278259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278259.Bytes);
public long this[int i]=>Value[i];

public static A278259Inst Instance=new A278259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278324
{
public static readonly BigInteger[] Value={ 56L,4991L,251892L,11947350L,570738085L,26606146271L,1159826452573L,46588303100299L,1741053359883624L,61687083048618477L,2105403821298913363L,BigInteger.Parse("69685735738121699248"),BigInteger.Parse("2231675758500253736280"),BigInteger.Parse("68674888544867993485304") };
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
public class A278324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278324Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278324.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278324Inst Instance=new A278324Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278325
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,1L,20L,20L,1L,6L,94L,236L,94L,6L,21L,395L,1678L,1678L,395L,21L,56L,1492L,9714L,19854L,9714L,1492L,56L,126L,4991L,51229L,186987L,186987L,51229L,4991L,126L,252L,14848L,251892L,1548002L,3058990L,1548002L,251892L,14848L,252L,462L,39832L,1144205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278325Inst : IEnumerable<long>
{
public static readonly long[] Value=A278325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278325.Bytes);
public long this[int i]=>Value[i];

public static A278325Inst Instance=new A278325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278326
{
public static readonly long[] Value={ 1L,2L,0L,1L,3L,9L,8L,7L,8L,0L,2L,7L,6L,5L,7L,7L,8L,2L,4L,1L,9L,4L,5L,1L,5L,0L,5L,5L,7L,5L,6L,1L,3L,5L,1L,1L,6L,8L,0L,8L,0L,2L,5L,2L,5L,0L,1L,5L,6L,0L,5L,3L,6L,0L,6L,6L,1L,9L,4L,0L,0L,5L,5L,1L,5L,6L,5L,7L,9L,2L,6L,2L,6L,5L,3L,6L,3L,6L,2L,1L,3L,8L,5L,1L,2L,2L,0L,8L,1L,5L,4L,1L,0L,3L,3L,7L,4L,5L,0L,9L,7L,6L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278326Inst : IEnumerable<long>
{
public static readonly long[] Value=A278326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278326.Bytes);
public long this[int i]=>Value[i];

public static A278326Inst Instance=new A278326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278327
{
public static readonly long[] Value={ 2L,3L,2L,5L,4L,4L,1L,5L,7L,9L,3L,4L,8L,2L,9L,6L,2L,9L,7L,0L,1L,5L,2L,4L,2L,7L,5L,1L,8L,8L,9L,7L,6L,4L,6L,4L,0L,3L,8L,1L,7L,9L,5L,8L,5L,1L,2L,2L,1L,9L,1L,9L,5L,3L,0L,3L,9L,6L,7L,7L,9L,2L,9L,0L,4L,3L,3L,8L,8L,1L,2L,1L,6L,4L,3L,4L,1L,2L,1L,1L,3L,4L,2L,0L,0L,4L,9L,1L,5L,1L,8L,5L,5L,2L,6L,2L,5L,9L,4L,9L,9L,1L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278327Inst : IEnumerable<long>
{
public static readonly long[] Value=A278327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278327.Bytes);
public long this[int i]=>Value[i];

public static A278327Inst Instance=new A278327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278328
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,15L,21L,22L,23L,26L,32L,33L,34L,37L,40L,43L,44L,45L,48L,51L,54L,55L,56L,59L,62L,65L,66L,67L,73L,76L,77L,78L,84L,87L,88L,89L,90L,95L,98L,99L,101L,111L,121L,131L,141L,151L,161L,171L,181L,191L,202L,212L,222L,232L,242L,252L,262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278328Inst : IEnumerable<long>
{
public static readonly long[] Value=A278328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278328.Bytes);
public long this[int i]=>Value[i];

public static A278328Inst Instance=new A278328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278329
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,29L,35L,340L,26579L,390480L,9514434L,145963193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278329Inst : IEnumerable<long>
{
public static readonly long[] Value=A278329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278329.Bytes);
public long this[int i]=>Value[i];

public static A278329Inst Instance=new A278329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278330
{
public static readonly long[] Value={ 1L,0L,2L,1L,12L,10L,59L,52L,276L,349L,1404L,1984L,7019L,11148L,35686L,62181L,182776L,339350L,942507L,1841208L,4887096L,9921685L,25442304L,53190380L,132928715L,284198328L,696276202L,1514363221L,3654567764L,8053235650L,19212546163L,42762014028L,101125071372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278330Inst : IEnumerable<long>
{
public static readonly long[] Value=A278330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278330.Bytes);
public long this[int i]=>Value[i];

public static A278330Inst Instance=new A278330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278331
{
public static readonly long[] Value={ 0L,-2L,-2L,6L,14L,-34L,-138L,310L,1918L,-4146L,-36154L,76454L,891342L,-1859138L,-27891050L,57641238L,1080832286L,-2219305810L,-50833628826L,103886563462L,2853207760750L,-5810302084962L,-188424521441482L,382659344967926L,14464296482284734L,-29311252309537394L,-1277229462293249018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278331Inst : IEnumerable<long>
{
public static readonly long[] Value=A278331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278331.Bytes);
public long this[int i]=>Value[i];

public static A278331Inst Instance=new A278331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278332
{
public static readonly long[] Value={ 1L,2L,9L,88L,905L,12666L,220297L,4506440L,104707521L,2758506850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278332Inst : IEnumerable<long>
{
public static readonly long[] Value=A278332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278332.Bytes);
public long this[int i]=>Value[i];

public static A278332Inst Instance=new A278332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278333
{
public static readonly long[] Value={ 1L,1L,3L,22L,181L,2111L,31471L,563305L,11634169L,275850685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278333Inst : IEnumerable<long>
{
public static readonly long[] Value=A278333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278333.Bytes);
public long this[int i]=>Value[i];

public static A278333Inst Instance=new A278333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278334
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,15L,20L,24L,41L,63L,66L,99L,281L,300L,462L,686L,726L,1196L,1574L,2543L,3023L,5322L,12161L,13677L,33797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278334Inst : IEnumerable<long>
{
public static readonly long[] Value=A278334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278334.Bytes);
public long this[int i]=>Value[i];

public static A278334Inst Instance=new A278334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278335
{
public static readonly long[] Value={ 1L,4L,5L,7L,9L,15L,26L,43L,75L,106L,129L,141L,147L,171L,351L,512L,927L,1156L,2563L,2689L,3274L,4211L,5709L,6908L,11781L,14464L,31451L,34921L,36635L,38087L,55707L,59617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278335Inst : IEnumerable<long>
{
public static readonly long[] Value=A278335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278335.Bytes);
public long this[int i]=>Value[i];

public static A278335Inst Instance=new A278335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278336
{
public static readonly long[] Value={ 0L,1L,4L,5L,9L,16L,20L,41L,43L,63L,127L,159L,413L,1591L,1812L,2031L,2315L,2437L,4177L,4860L,5771L,7060L,7389L,9925L,34103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278336Inst : IEnumerable<long>
{
public static readonly long[] Value=A278336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278336.Bytes);
public long this[int i]=>Value[i];

public static A278336Inst Instance=new A278336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278337
{
public static readonly long[] Value={ 15L,45L,99L,735L,1221L,1645L,1725L,1925L,2871L,4047L,8667L,13311L,16461L,19647L,21285L,27797L,39861L,52215L,52965L,65637L,67479L,74781L,106327L,124215L,126975L,155511L,181917L,240397L,244839L,257951L,315695L,344175L,412863L,442417L,445215L,449493L,707859L,1362079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278337Inst : IEnumerable<long>
{
public static readonly long[] Value=A278337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278337.Bytes);
public long this[int i]=>Value[i];

public static A278337Inst Instance=new A278337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278338
{
public static readonly long[] Value={ 561L,561L,1105L,2465L,561L,8911L,561L,46657L,52633L,1729L,1105L,2465L,561L,46657L,294409L,29341L,512461L,1105L,561L,1024651L,2821L,8911L,1729L,1909001L,2821L,162401L,1105L,2465L,561L,52633L,46657L,1729L,2465L,1729L,10585L,29341L,1105L,46657L,1193221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278338Inst : IEnumerable<long>
{
public static readonly long[] Value=A278338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278338.Bytes);
public long this[int i]=>Value[i];

public static A278338Inst Instance=new A278338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278339
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,0L,1L,23L,9L,41L,248L,277L,1556L,2854L,5233L,20701L,145137L,1626890L,4118910L,9963276L,9260756L,64027363L,365237571L,1002679107L,21594036300L,24465529531L,144914973347L,1921444799766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278339Inst : IEnumerable<long>
{
public static readonly long[] Value=A278339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278339.Bytes);
public long this[int i]=>Value[i];

public static A278339Inst Instance=new A278339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278372
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,59L,59L,0L,6L,1465L,3766L,1465L,6L,77L,19047L,184341L,184341L,19047L,77L,504L,194726L,5897660L,16073852L,5897660L,194726L,504L,2304L,1734714L,138641633L,1185617520L,1185617520L,138641633L,1734714L,2304L,8350L,13506810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278372Inst : IEnumerable<long>
{
public static readonly long[] Value=A278372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278372.Bytes);
public long this[int i]=>Value[i];

public static A278372Inst Instance=new A278372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278373
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,17L,18L,20L,22L,24L,25L,26L,28L,29L,30L,31L,32L,34L,36L,37L,38L,40L,41L,42L,44L,46L,48L,49L,50L,52L,54L,56L,57L,58L,60L,61L,62L,63L,64L,65L,66L,68L,70L,72L,73L,74L,75L,76L,77L,78L,80L,82L,84L,85L,86L,88L,89L,90L,91L,92L,93L,94L,96L,97L,98L,100L,102L,104L,106L,108L,109L,110L,111L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278373Inst : IEnumerable<long>
{
public static readonly long[] Value=A278373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278373.Bytes);
public long this[int i]=>Value[i];

public static A278373Inst Instance=new A278373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278374
{
public static readonly long[] Value={ 1L,4L,6L,8L,27L,125L,16L,12L,18L,20L,28L,50L,63L,32L,44L,98L,52L,24L,68L,42L,242L,40L,70L,338L,54L,36L,56L,116L,78L,578L,165L,130L,722L,135L,48L,164L,114L,1058L,104L,188L,285L,138L,100L,80L,230L,1682L,136L,128L,60L,1922L,244L,152L,741L,112L,225L,351L,72L,284L,2738L,90L,84L,651L,222L,3362L,711L,332L,3698L,459L,196L,96L,162L,356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278374Inst : IEnumerable<long>
{
public static readonly long[] Value=A278374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278374.Bytes);
public long this[int i]=>Value[i];

public static A278374Inst Instance=new A278374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278375
{
public static readonly long[] Value={ 1L,3L,4L,5L,5L,6L,7L,7L,7L,8L,8L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278375Inst : IEnumerable<long>
{
public static readonly long[] Value=A278375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278375.Bytes);
public long this[int i]=>Value[i];

public static A278375Inst Instance=new A278375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278376
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,7L,8L,20L,9L,11L,13L,15L,17L,21L,22L,23L,27L,26L,28L,29L,30L,31L,33L,34L,36L,38L,41L,42L,46L,47L,48L,49L,50L,51L,56L,59L,61L,62L,64L,65L,72L,75L,77L,79L,83L,82L,84L,85L,86L,87L,92L,95L,97L,99L,101L,102L,104L,105L,106L,110L,111L,113L,114L,115L,117L,118L,120L,122L,124L,126L,127L,129L,131L,133L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278376Inst : IEnumerable<long>
{
public static readonly long[] Value=A278376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278376.Bytes);
public long this[int i]=>Value[i];

public static A278376Inst Instance=new A278376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278377
{
public static readonly long[] Value={ 0L,0L,0L,4L,8L,16L,40L,36L,72L,60L,128L,92L,232L,144L,260L,284L,332L,252L,564L,324L,680L,568L,696L,492L,1184L,628L,984L,964L,1392L,796L,1920L,924L,1820L,1512L,1752L,1568L,2820L,1380L,2244L,2104L,3340L,1660L,3864L,1900L,3544L,3388L,3300L,2264L,5652L,2632L,4616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278377Inst : IEnumerable<long>
{
public static readonly long[] Value=A278377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278377.Bytes);
public long this[int i]=>Value[i];

public static A278377Inst Instance=new A278377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278378
{
public static readonly BigInteger[] Value={ 0L,0L,74L,23640L,8632118L,6204309386L,11105331450864L,55821544343692020L,BigInteger.Parse("843729327193891754770"),BigInteger.Parse("40033544602806238643588014") };
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
public class A278378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278378Inst Instance=new A278378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278379
{
public static readonly long[] Value={ 0L,0L,3L,40L,267L,1350L,5936L,23565L,84912L,278422L,835824L,2316601L,5980937L,14503972L,33282396L,72732358L,152195016L,306378420L,595704701L,1122541470L,2056128263L,3670127802L,6398217740L,10915088955L,18252749400L,29965289850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278379Inst : IEnumerable<long>
{
public static readonly long[] Value=A278379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278379.Bytes);
public long this[int i]=>Value[i];

public static A278379Inst Instance=new A278379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278380
{
public static readonly long[] Value={ 0L,3L,74L,1220L,12910L,100807L,652343L,3750182L,19784428L,96786947L,439906101L,1859501560L,7328752206L,27039030100L,93829708460L,307762056698L,958683800155L,2848583303210L,8105942966932L,22169003715353L,58456685214757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278380Inst : IEnumerable<long>
{
public static readonly long[] Value=A278380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278380.Bytes);
public long this[int i]=>Value[i];

public static A278380Inst Instance=new A278380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278381
{
public static readonly long[] Value={ 0L,40L,1220L,23640L,368421L,4703562L,50473056L,474255829L,4047341159L,32112086692L,239321493757L,1678998378973L,11080464577870L,68753466828933L,401430915176013L,2209957957528646L,11503598362204972L,56799460197673429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278381Inst : IEnumerable<long>
{
public static readonly long[] Value=A278381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278381.Bytes);
public long this[int i]=>Value[i];

public static A278381Inst Instance=new A278381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278382
{
public static readonly long[] Value={ 0L,267L,12910L,368421L,8632118L,179716850L,3325788157L,54735436424L,813247916326L,11132424779200L,142827255320422L,1735129660080135L,20034300716422826L,219810810847095930L,2288305542134926763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278382Inst : IEnumerable<long>
{
public static readonly long[] Value=A278382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278382.Bytes);
public long this[int i]=>Value[i];

public static A278382Inst Instance=new A278382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278383
{
public static readonly BigInteger[] Value={ 1L,1350L,100807L,4703562L,179716850L,6204309386L,198563803019L,5851197688577L,157794170262819L,3912513274701995L,90233123783207419L,1960361831058212555L,BigInteger.Parse("40518771843257636636"),BigInteger.Parse("801152317698519068308"),BigInteger.Parse("15177259705860270641696") };
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
public class A278383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278383Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278383.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278383Inst Instance=new A278383Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278384
{
public static readonly BigInteger[] Value={ 8L,5936L,652343L,50473056L,3325788157L,198563803019L,11105331450864L,586395701904408L,29015321337746085L,1335864857344408243L,BigInteger.Parse("57236190892283185233"),BigInteger.Parse("2296849324984530935992"),BigInteger.Parse("87126825773953105905476") };
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
public class A278384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278384Inst Instance=new A278384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278385
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,3L,3L,0L,0L,40L,74L,40L,0L,1L,267L,1220L,1220L,267L,1L,8L,1350L,12910L,23640L,12910L,1350L,8L,36L,5936L,100807L,368421L,368421L,100807L,5936L,36L,120L,23565L,652343L,4703562L,8632118L,4703562L,652343L,23565L,120L,330L,84912L,3750182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278385Inst : IEnumerable<long>
{
public static readonly long[] Value=A278385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278385.Bytes);
public long this[int i]=>Value[i];

public static A278385Inst Instance=new A278385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278386
{
public static readonly long[] Value={ 2L,2L,5L,9L,8L,7L,1L,5L,5L,9L,1L,3L,4L,9L,7L,3L,3L,2L,9L,8L,6L,3L,1L,1L,5L,2L,0L,6L,8L,8L,0L,8L,2L,3L,3L,7L,6L,1L,7L,0L,1L,1L,6L,8L,1L,4L,7L,5L,5L,6L,7L,9L,1L,6L,5L,4L,4L,0L,6L,4L,1L,3L,8L,8L,3L,0L,7L,4L,8L,9L,1L,6L,2L,0L,9L,7L,7L,5L,6L,6L,6L,6L,2L,2L,5L,4L,3L,9L,6L,9L,4L,1L,3L,8L,0L,4L,2L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278386Inst : IEnumerable<long>
{
public static readonly long[] Value=A278386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278386.Bytes);
public long this[int i]=>Value[i];

public static A278386Inst Instance=new A278386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278387
{
public static readonly long[] Value={ 2L,2L,1L,1L,2L,1L,2L,1L,3L,2L,7L,7L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278387Inst : IEnumerable<long>
{
public static readonly long[] Value=A278387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278387.Bytes);
public long this[int i]=>Value[i];

public static A278387Inst Instance=new A278387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278420
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,5L,4L,9L,10L,20L,18L,32L,45L,58L,82L,101L,148L,178L,274L,306L,452L,512L,785L,872L,1258L,1450L,2061L,2304L,3274L,3796L,5108L,6056L,7954L,9376L,12200L,14733L,18500L,22608L,28004L,34354L,41905L,51752L,62122L,77090L,91764L,114640L,134560L,167690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278420Inst : IEnumerable<long>
{
public static readonly long[] Value=A278420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278420.Bytes);
public long this[int i]=>Value[i];

public static A278420Inst Instance=new A278420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278421
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1100L,101L,110000L,111L,11110100L,10001L,1111000100L,10001L,111111000100L,1010001L,11111100000100L,1110101L,1111111101010000L,100000111L,111111110001110100L,101010001L,11111111110000000100UL,10101110001L,BigInteger.Parse("1111111111000001000100"),11100010001L };
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
public class A278421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278421Inst Instance=new A278421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278422
{
public static readonly BigInteger[] Value={ 1L,0L,100L,11L,10100L,11L,1110000L,101111L,100010000L,10001111L,10001000000L,1000111111L,1000101000000L,100000111111L,101011100000000L,101011111111L,11100000100000000L,1011100011111111L,1000101010000000000L,100000001111111111L,BigInteger.Parse("100011101010000000000") };
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
public class A278422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278422Inst Instance=new A278422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278423
{
public static readonly long[] Value={ 1L,0L,1L,12L,5L,48L,7L,244L,17L,964L,17L,4036L,81L,16132L,117L,65360L,263L,261236L,337L,1047556L,1393L,4190276L,1809L,16774468L,4117L,67094336L,5407L,268419156L,22337L,1073677596L,28753L,4294924036L,66929L,17179635796L,87809L,68719215732L,356689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278423Inst : IEnumerable<long>
{
public static readonly long[] Value=A278423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278423.Bytes);
public long this[int i]=>Value[i];

public static A278423Inst Instance=new A278423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278424
{
public static readonly long[] Value={ 1L,0L,4L,3L,20L,3L,112L,47L,272L,143L,1088L,575L,4416L,2111L,22272L,2815L,114944L,47359L,283648L,132095L,1168384L,558079L,4485120L,2273279L,22024192L,757759L,130367488L,44056575L,274546688L,237518847L,1158086656L,552271871L,4785766400L,2822307839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278424Inst : IEnumerable<long>
{
public static readonly long[] Value=A278424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278424.Bytes);
public long this[int i]=>Value[i];

public static A278424Inst Instance=new A278424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278425
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,2L,4L,1L,2L,3L,4L,9L,1L,6L,3L,7L,5L,6L,10L,4L,2L,5L,5L,8L,7L,2L,5L,11L,4L,3L,10L,9L,6L,15L,6L,8L,4L,3L,8L,5L,7L,5L,12L,2L,7L,3L,11L,6L,6L,10L,9L,10L,6L,2L,3L,5L,23L,9L,6L,4L,10L,4L,8L,6L,8L,20L,5L,9L,19L,4L,12L,7L,18L,7L,7L,2L,6L,17L,6L,14L,6L,16L,16L,6L,9L,13L,19L,15L,14L,18L,4L,18L,5L,14L,14L,13L,4L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278425Inst : IEnumerable<long>
{
public static readonly long[] Value=A278425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278425.Bytes);
public long this[int i]=>Value[i];

public static A278425Inst Instance=new A278425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278426
{
public static readonly long[] Value={ 1L,3L,4L,13L,15L,21L,27L,63L,70L,123L,136L,178L,208L,265L,411L,457L,856L,2401L,4642L,8017L,8211L,8385L,12337L,20793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278426Inst : IEnumerable<long>
{
public static readonly long[] Value=A278426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278426.Bytes);
public long this[int i]=>Value[i];

public static A278426Inst Instance=new A278426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278427
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,4L,3L,3L,1L,1L,5L,4L,5L,3L,1L,1L,6L,5L,7L,6L,4L,1L,1L,7L,6L,9L,9L,8L,4L,1L,1L,8L,7L,11L,12L,13L,9L,5L,1L,1L,9L,8L,13L,15L,18L,15L,12L,5L,1L,1L,10L,9L,15L,18L,23L,22L,21L,13L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278427Inst : IEnumerable<long>
{
public static readonly long[] Value=A278427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278427.Bytes);
public long this[int i]=>Value[i];

public static A278427Inst Instance=new A278427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278428
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,17L,46L,128L,373L,1119L,3405L,10464L,32478L,101781L,321642L,1023512L,3276326L,10543100L,34088806L,110690682L,360810160L,1180195810L,3872588051L,12743937024L,42049240694L,139082885503L,461072582522L,1531697761470L,5098246648103L,17000237006441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278428Inst : IEnumerable<long>
{
public static readonly long[] Value=A278428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278428.Bytes);
public long this[int i]=>Value[i];

public static A278428Inst Instance=new A278428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278429
{
public static readonly long[] Value={ 1L,3L,16L,102L,699L,4973L,36194L,267480L,1998565L,15057255L,114179652L,870351386L,6662847871L,51189449457L,394476780694L,3047878296556L,23602623675273L,183142111511819L,1423578146798168L,11082963785614926L,86405502413568259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278429Inst : IEnumerable<long>
{
public static readonly long[] Value=A278429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278429.Bytes);
public long this[int i]=>Value[i];

public static A278429Inst Instance=new A278429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278430
{
public static readonly long[] Value={ 6L,100L,1609L,19624L,178352L,1287838L,7795151L,41058743L,193149285L,826734193L,3264405727L,12016477160L,41579224479L,136142690453L,424140541353L,1263030700894L,3609095743983L,9929303441355L,26377932553959L,67838309686132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278430Inst : IEnumerable<long>
{
public static readonly long[] Value=A278430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278430.Bytes);
public long this[int i]=>Value[i];

public static A278430Inst Instance=new A278430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278431
{
public static readonly BigInteger[] Value={ 40L,1609L,57760L,2116789L,67971132L,1796061464L,39513263094L,743248079740L,12242795030458L,179948822861856L,2394561544941994L,29174653111810701L,328380943500399272L,3439574456695348801L,BigInteger.Parse("33729578625174035514") };
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
public class A278431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278431Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278431.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278431Inst Instance=new A278431Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278432
{
public static readonly BigInteger[] Value={ 155L,19624L,2116789L,223202074L,23450120081L,2266913897519L,191704868748703L,14075699487073288L,906324694033572285L,BigInteger.Parse("51875514109305962403"),BigInteger.Parse("2672849198449587976472"),BigInteger.Parse("125300087299510807859757") };
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
public class A278432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278432Inst Instance=new A278432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278433
{
public static readonly BigInteger[] Value={ 456L,178352L,67971132L,23450120081L,7817299555828L,2573951428892959L,803631265741510560L,BigInteger.Parse("228568783548126804702"),BigInteger.Parse("58279844921391047673160"),BigInteger.Parse("13321187192307993333262298"),BigInteger.Parse("2747056699156070175271175528") };
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
public class A278433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278433Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278433.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278433Inst Instance=new A278433Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278434
{
public static readonly BigInteger[] Value={ 1128L,1287838L,1796061464L,2266913897519L,2573951428892959L,2817080307689646420L,BigInteger.Parse("3058351651772615415451"),BigInteger.Parse("3218514217113422076011068"),BigInteger.Parse("3172598007779111848619027479"),BigInteger.Parse("2870266355084730530696055472589") };
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
public class A278434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278434Inst Instance=new A278434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278435
{
public static readonly long[] Value={ 0L,6L,6L,40L,100L,40L,155L,1609L,1609L,155L,456L,19624L,57760L,19624L,456L,1128L,178352L,2116789L,2116789L,178352L,1128L,2472L,1287838L,67971132L,223202074L,67971132L,1287838L,2472L,4950L,7795151L,1796061464L,23450120081L,23450120081L,1796061464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278435Inst : IEnumerable<long>
{
public static readonly long[] Value=A278435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278435.Bytes);
public long this[int i]=>Value[i];

public static A278435Inst Instance=new A278435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278468
{
public static readonly long[] Value={ 1L,0L,1L,12L,1L,60L,1L,252L,9L,992L,15L,4064L,15L,16356L,1L,65532L,201L,261632L,255L,1048140L,1L,4194300L,857L,16775296L,703L,67107280L,167L,268435104L,7631L,1073726084L,6449L,4294950916L,8181L,17179856200L,3L,68719476728L,3443L,274877899424L,3023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278468Inst : IEnumerable<long>
{
public static readonly long[] Value=A278468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278468.Bytes);
public long this[int i]=>Value[i];

public static A278468Inst Instance=new A278468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278469
{
public static readonly long[] Value={ 1L,0L,4L,3L,16L,15L,64L,63L,288L,31L,1920L,127L,7680L,2559L,16384L,16383L,75264L,511L,522240L,206847L,1048576L,1048575L,5070848L,73727L,33193984L,3047423L,120061952L,5767167L,511115264L,139526143L,1179385856L,537133055L,5904531456L,1255145471L,25769803776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278469Inst : IEnumerable<long>
{
public static readonly long[] Value=A278469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278469.Bytes);
public long this[int i]=>Value[i];

public static A278469Inst Instance=new A278469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278470
{
public static readonly long[] Value={ 13L,20L,40L,43L,73L,85L,576L,1676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278470Inst : IEnumerable<long>
{
public static readonly long[] Value=A278470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278470.Bytes);
public long this[int i]=>Value[i];

public static A278470Inst Instance=new A278470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278471
{
public static readonly long[] Value={ 16L,18L,38L,82L,98L,318L,1106L,1914L,2438L,2640L,3156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278471Inst : IEnumerable<long>
{
public static readonly long[] Value=A278471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278471.Bytes);
public long this[int i]=>Value[i];

public static A278471Inst Instance=new A278471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278472
{
public static readonly long[] Value={ 1L,5L,22L,92L,376L,1518L,6085L,24285L,96647L,383911L,1523117L,6037745L,23920853L,94737897L,375125126L,1485173396L,5879740780L,23277813786L,92160762514L,364906983652L,1444972555742L,5722488162840L,22665368420672L,89783494878902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278472Inst : IEnumerable<long>
{
public static readonly long[] Value=A278472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278472.Bytes);
public long this[int i]=>Value[i];

public static A278472Inst Instance=new A278472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278473
{
public static readonly long[] Value={ 1L,6L,25L,75L,76L,96L,99L,376L,625L,1376L,1875L,3568L,3751L,4375L,6875L,8001L,8125L,9376L,13568L,28125L,49376L,68751L,89376L,90625L,109375L,109376L,499999L,800001L,890624L,890625L,2890625L,5109376L,5781249L,6640625L,7109376L,8000001L,12109375L,12890625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278473Inst : IEnumerable<long>
{
public static readonly long[] Value=A278473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278473.Bytes);
public long this[int i]=>Value[i];

public static A278473Inst Instance=new A278473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278474
{
public static readonly long[] Value={ 24L,36L,76L,375L,376L,432L,624L,625L,693L,875L,999L,2499L,4557L,8307L,9375L,9376L,9999L,34375L,40625L,47943L,50001L,59375L,81249L,90624L,90625L,99999L,109376L,186432L,218751L,586432L,609375L,690624L,718751L,781249L,890625L,954193L,968751L,999999L,2109375L,2890624L,2890625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278474Inst : IEnumerable<long>
{
public static readonly long[] Value=A278474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278474.Bytes);
public long this[int i]=>Value[i];

public static A278474Inst Instance=new A278474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278475
{
public static readonly BigInteger[] Value={ 1L,29L,841L,24417L,708933L,20583473L,597629649L,17351843293L,503801085145L,14627583312497L,424703717147557L,12331035380591649L,358024729754305377L,10395048198255447581UL,BigInteger.Parse("301814422479162285225"),BigInteger.Parse("8763013300093961719105"),BigInteger.Parse("254429200125204052139269"),BigInteger.Parse("7387209816931011473757905") };
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
public class A278475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278475Inst Instance=new A278475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278476
{
public static readonly BigInteger[] Value={ 1L,14L,196L,2757L,38793L,545858L,7680804L,108077113L,1520760385L,21398722502L,301102875412L,4236838978269L,59616848571177L,838872718974746L,11803834914217620L,166092561518021425L,2337099696166517569L,BigInteger.Parse("32885488307849267390"),BigInteger.Parse("462733936006056261028") };
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
public class A278476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278476Inst Instance=new A278476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278477
{
public static readonly long[] Value={ 2L,3L,7L,23L,31L,127L,383L,991L,2039L,3583L,6143L,8191L,63487L,129023L,131071L,522239L,524287L,1966079L,4128767L,14680063L,33546239L,67108351L,201064447L,260046847L,536739839L,1073479679L,2147483647L,8581545983L,16911433727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278477Inst : IEnumerable<long>
{
public static readonly long[] Value=A278477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278477.Bytes);
public long this[int i]=>Value[i];

public static A278477Inst Instance=new A278477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278478
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,3L,0L,0L,0L,4L,0L,0L,0L,1L,0L,3L,1L,0L,0L,1L,2L,1L,1L,0L,2L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,2L,0L,1L,2L,2L,0L,0L,2L,0L,1L,1L,6L,0L,0L,0L,5L,0L,0L,0L,2L,3L,0L,0L,2L,1L,2L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,0L,0L,3L,0L,11L,1L,3L,0L,2L,1L,0L,1L,0L,0L,4L,0L,2L,7L,1L,0L,2L,2L,0L,0L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278478Inst : IEnumerable<long>
{
public static readonly long[] Value=A278478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278478.Bytes);
public long this[int i]=>Value[i];

public static A278478Inst Instance=new A278478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278479
{
public static readonly long[] Value={ 0L,2L,26L,11L,15L,70L,66L,109L,154L,478L,441L,96L,3693L,15005L,66934L,99420L,18978L,43002L,55943L,972190L,1151214L,2799146L,26801784L,46632889L,15519397L,122101417L,210553237L,289585489L,473093534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278479Inst : IEnumerable<long>
{
public static readonly long[] Value=A278479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278479.Bytes);
public long this[int i]=>Value[i];

public static A278479Inst Instance=new A278479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278480
{
public static readonly long[] Value={ 2L,4L,5L,5L,7L,5L,5L,8L,7L,5L,5L,8L,8L,7L,5L,5L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,7L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278480Inst : IEnumerable<long>
{
public static readonly long[] Value=A278480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278480.Bytes);
public long this[int i]=>Value[i];

public static A278480Inst Instance=new A278480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278481
{
public static readonly long[] Value={ 2L,4L,4L,4L,6L,4L,4L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278481Inst : IEnumerable<long>
{
public static readonly long[] Value=A278481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278481.Bytes);
public long this[int i]=>Value[i];

public static A278481Inst Instance=new A278481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278482
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,0L,3L,4L,2L,0L,4L,6L,6L,2L,0L,5L,8L,8L,6L,2L,0L,6L,10L,12L,12L,6L,2L,0L,7L,12L,14L,14L,12L,6L,2L,0L,8L,14L,18L,18L,18L,12L,6L,2L,0L,9L,16L,20L,24L,24L,18L,12L,6L,2L,0L,10L,18L,24L,26L,26L,26L,18L,12L,6L,2L,0L,11L,20L,26L,30L,30L,30L,26L,18L,12L,6L,2L,0L,12L,22L,30L,36L,38L,38L,38L,26L,18L,12L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278482Inst : IEnumerable<long>
{
public static readonly long[] Value=A278482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278482.Bytes);
public long this[int i]=>Value[i];

public static A278482Inst Instance=new A278482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278483
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,0L,2L,4L,3L,0L,2L,6L,6L,4L,0L,2L,6L,8L,8L,5L,0L,2L,6L,12L,12L,10L,6L,0L,2L,6L,12L,14L,14L,12L,7L,0L,2L,6L,12L,18L,18L,18L,14L,8L,0L,2L,6L,12L,18L,24L,24L,20L,16L,9L,0L,2L,6L,12L,18L,26L,26L,26L,24L,18L,10L,0L,2L,6L,12L,18L,26L,30L,30L,30L,26L,20L,11L,0L,2L,6L,12L,18L,26L,38L,38L,38L,36L,30L,22L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278483Inst : IEnumerable<long>
{
public static readonly long[] Value=A278483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278483.Bytes);
public long this[int i]=>Value[i];

public static A278483Inst Instance=new A278483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278676
{
public static readonly long[] Value={ 0L,1L,1L,4L,8L,4L,10L,33L,33L,10L,20L,99L,158L,99L,20L,35L,245L,579L,579L,245L,35L,56L,532L,1801L,2650L,1801L,532L,56L,84L,1050L,4999L,10584L,10584L,4999L,1050L,84L,120L,1926L,12727L,38848L,55854L,38848L,12727L,1926L,120L,165L,3333L,30218L,134265L,280616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278676Inst : IEnumerable<long>
{
public static readonly long[] Value=A278676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278676.Bytes);
public long this[int i]=>Value[i];

public static A278676Inst Instance=new A278676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278677
{
public static readonly long[] Value={ 1L,5L,23L,109L,544L,2876L,16113L,95495L,597155L,3929243L,27132324L,196122796L,1480531285L,11647194573L,95297546695L,809490850313L,7126717111964L,64930685865768L,611337506786061L,5940420217001199L,59502456129204083L,613689271227219015L,6510381400140132872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278677Inst : IEnumerable<long>
{
public static readonly long[] Value=A278677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278677.Bytes);
public long this[int i]=>Value[i];

public static A278677Inst Instance=new A278677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278678
{
public static readonly long[] Value={ 1L,4L,19L,94L,519L,3144L,20903L,151418L,1188947L,10064924L,91426347L,887296422L,9164847535L,100398851344L,1162831155151L,14198949045106L,182317628906283L,2455925711626404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278678Inst : IEnumerable<long>
{
public static readonly long[] Value=A278678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278678.Bytes);
public long this[int i]=>Value[i];

public static A278678Inst Instance=new A278678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278679
{
public static readonly long[] Value={ 1L,5L,24L,128L,770L,5190L,38864L,320704L,2894544L,28382800L,300575968L,3419882304L,41612735632L,539295974000L,7417120846080L,107904105986048L,1655634186628352L,26721851169634560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278679Inst : IEnumerable<long>
{
public static readonly long[] Value=A278679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278679.Bytes);
public long this[int i]=>Value[i];

public static A278679Inst Instance=new A278679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278680
{
public static readonly long[] Value={ 1L,4L,14L,40L,105L,251L,570L,1226L,2540L,5075L,9855L,18630L,34439L,62340L,110805L,193624L,333235L,565415L,947040L,1567130L,2564425L,4152535L,6658711L,10579380L,16663755L,26033200L,40357641L,62106290L,94912385L,144088840L,217368655L,325945320L,485950150L,720515475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278680Inst : IEnumerable<long>
{
public static readonly long[] Value=A278680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278680.Bytes);
public long this[int i]=>Value[i];

public static A278680Inst Instance=new A278680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278681
{
public static readonly long[] Value={ 3L,16L,85L,451L,2392L,12686L,67280L,356818L,1892376L,10036172L,53226604L,282286052L,1497097488L,7939821584L,42108658448L,223322287224L,1184384537744L,6281355751296L,33313023614352L,176674843181968L,936990907061504L,4969309405367264L,26354616443092800L,139771093164846816L,741272730213321216L,3931322622695991104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278681Inst : IEnumerable<long>
{
public static readonly long[] Value=A278681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278681.Bytes);
public long this[int i]=>Value[i];

public static A278681Inst Instance=new A278681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278682
{
public static readonly long[] Value={ 0L,0L,7L,45L,225L,709L,1974L,4524L,9614L,18382L,33425L,56895L,93447L,146715L,224280L,331814L,480844L,679724L,945099L,1288737L,1733725L,2296065L,3006762L,3886960L,4977210L,6304794L,7921589L,9862099L,12191459L,14952567L,18225900L,22064010L,26564952L,31792280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278682Inst : IEnumerable<long>
{
public static readonly long[] Value=A278682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278682.Bytes);
public long this[int i]=>Value[i];

public static A278682Inst Instance=new A278682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278683
{
public static readonly long[] Value={ 0L,0L,6L,92L,832L,4500L,18229L,58881L,163509L,401259L,898420L,1861146L,3625546L,6694982L,11829267L,20099815L,33036079L,52700901L,81916834L,124362664L,184907220L,269726216L,386776561L,545930397L,759628777L,1043027055L,1414873104L,1897655046L,2518755934L,3310591194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278683Inst : IEnumerable<long>
{
public static readonly long[] Value=A278683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278683.Bytes);
public long this[int i]=>Value[i];

public static A278683Inst Instance=new A278683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278684
{
public static readonly long[] Value={ 0L,0L,2L,99L,2102L,19987L,124676L,571418L,2122841L,6704061L,18711691L,47235845L,109938296L,238950999L,490309398L,957267228L,1790325363L,3224010105L,5615368229L,9493358359L,15627413290L,25112609019L,39484650296L,60859027054L,92114682749L,137111560949L,200972392655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278684Inst : IEnumerable<long>
{
public static readonly long[] Value=A278684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278684.Bytes);
public long this[int i]=>Value[i];

public static A278684Inst Instance=new A278684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278685
{
public static readonly long[] Value={ 0L,0L,1L,76L,3773L,66201L,651193L,4318451L,21754341L,89267490L,312974387L,968069337L,2704548145L,6942663519L,16594368633L,37311795887L,79570707969L,162013125016L,316669793867L,596873304925L,1089009784181L,1929545889877L,3329316638249L,5607471933963L,9238336533613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278685Inst : IEnumerable<long>
{
public static readonly long[] Value=A278685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278685.Bytes);
public long this[int i]=>Value[i];

public static A278685Inst Instance=new A278685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278686
{
public static readonly long[] Value={ 0L,0L,0L,27L,4860L,164423L,2651890L,25981150L,180378380L,971905679L,4316504623L,16457726539L,55463445891L,168782705327L,471407278652L,1223710587908L,2982045310010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278686Inst : IEnumerable<long>
{
public static readonly long[] Value=A278686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278686.Bytes);
public long this[int i]=>Value[i];

public static A278686Inst Instance=new A278686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278687
{
public static readonly long[] Value={ 1L,1L,7L,92L,2102L,66201L,2651890L,126928146L,7060794663L,447024321962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278687Inst : IEnumerable<long>
{
public static readonly long[] Value=A278687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278687.Bytes);
public long this[int i]=>Value[i];

public static A278687Inst Instance=new A278687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278688
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,6L,7L,6L,2L,1L,1L,3L,17L,45L,92L,99L,76L,27L,7L,1L,6L,43L,225L,832L,2102L,3773L,4860L,4643L,3356L,1868L,795L,248L,56L,8L,1L,1L,6L,84L,709L,4500L,19987L,66201L,164423L,314224L,465230L,540247L,492206L,352300L,195717L,83247L,26083L,5754L,780L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278688Inst : IEnumerable<long>
{
public static readonly long[] Value=A278688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278688.Bytes);
public long this[int i]=>Value[i];

public static A278688Inst Instance=new A278688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278689
{
public static readonly long[] Value={ 0L,1L,4L,25L,170L,1204L,8736L,64416L,480480L,3615040L,27382784L,208539136L,1595216896L,12247746560L,94330470400L,728474664960L,5638832087040L,43737154928640L,339856038297600L,2645063771750400L,20615846154731520L,160889637246074880L,1257082279931412480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278689Inst : IEnumerable<long>
{
public static readonly long[] Value=A278689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278689.Bytes);
public long this[int i]=>Value[i];

public static A278689Inst Instance=new A278689Inst();

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