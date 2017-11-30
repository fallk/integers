using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A019698
{
public static readonly long[] Value={ 4L,8L,3L,3L,2L,1L,9L,4L,6L,7L,0L,6L,1L,2L,2L,0L,3L,6L,6L,8L,6L,5L,6L,0L,5L,2L,0L,5L,0L,4L,5L,3L,8L,9L,0L,5L,2L,6L,1L,1L,0L,2L,9L,8L,4L,5L,1L,9L,2L,4L,7L,0L,4L,9L,3L,8L,0L,7L,6L,0L,7L,0L,6L,5L,0L,8L,8L,9L,4L,8L,3L,1L,7L,3L,6L,3L,3L,9L,8L,4L,5L,9L,4L,2L,7L,7L,4L,5L,8L,8L,5L,1L,4L,1L,7L,1L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019698Inst : IEnumerable<long>
{
public static readonly long[] Value=A019698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019698.Bytes);
public long this[int i]=>Value[i];

public static A019698Inst Instance=new A019698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019697
{
public static readonly long[] Value={ 5L,7L,1L,1L,9L,8L,6L,6L,4L,2L,8L,9L,0L,5L,3L,3L,1L,6L,0L,8L,4L,1L,1L,6L,9L,7L,8L,7L,7L,8L,0L,9L,1L,4L,3L,3L,4L,9L,0L,3L,9L,4L,4L,3L,6L,2L,5L,0L,0L,1L,9L,2L,4L,0L,1L,7L,7L,2L,6L,2L,6L,5L,3L,1L,4L,6L,8L,7L,5L,7L,1L,0L,2L,3L,3L,8L,5L,6L,1L,8L,1L,5L,6L,8L,7L,3L,3L,6L,0L,4L,6L,0L,7L,6L,5L,7L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019697Inst : IEnumerable<long>
{
public static readonly long[] Value=A019697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019697.Bytes);
public long this[int i]=>Value[i];

public static A019697Inst Instance=new A019697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019696
{
public static readonly long[] Value={ 6L,9L,8L,1L,3L,1L,7L,0L,0L,7L,9L,7L,7L,3L,1L,8L,3L,0L,7L,6L,9L,4L,7L,6L,3L,0L,7L,3L,9L,5L,4L,4L,5L,0L,8L,5L,3L,7L,7L,1L,4L,8L,7L,5L,5L,4L,1L,6L,6L,9L,0L,1L,8L,2L,4L,3L,8L,8L,7L,6L,5L,7L,6L,0L,6L,8L,4L,0L,3L,6L,4L,5L,8L,4L,1L,3L,7L,9L,7L,7L,7L,4L,7L,2L,8L,9L,6L,6L,2L,7L,8L,5L,3L,8L,0L,3L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019696Inst : IEnumerable<long>
{
public static readonly long[] Value=A019696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019696.Bytes);
public long this[int i]=>Value[i];

public static A019696Inst Instance=new A019696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019695
{
public static readonly long[] Value={ 8L,9L,7L,5L,9L,7L,9L,0L,1L,0L,2L,5L,6L,5L,5L,2L,1L,0L,9L,8L,9L,3L,2L,6L,6L,8L,0L,9L,3L,7L,0L,0L,0L,8L,2L,4L,0L,5L,6L,3L,3L,4L,1L,1L,4L,1L,0L,7L,1L,7L,3L,0L,9L,1L,7L,0L,7L,1L,2L,7L,0L,2L,6L,3L,7L,3L,6L,6L,1L,8L,3L,0L,3L,6L,7L,4L,8L,8L,2L,8L,5L,3L,2L,2L,2L,9L,5L,6L,6L,4L,3L,8L,3L,4L,6L,2L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019695Inst : IEnumerable<long>
{
public static readonly long[] Value=A019695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019695.Bytes);
public long this[int i]=>Value[i];

public static A019695Inst Instance=new A019695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019694
{
public static readonly long[] Value={ 1L,2L,5L,6L,6L,3L,7L,0L,6L,1L,4L,3L,5L,9L,1L,7L,2L,9L,5L,3L,8L,5L,0L,5L,7L,3L,5L,3L,3L,1L,1L,8L,0L,1L,1L,5L,3L,6L,7L,8L,8L,6L,7L,7L,5L,9L,7L,5L,0L,0L,4L,2L,3L,2L,8L,3L,8L,9L,9L,7L,7L,8L,3L,6L,9L,2L,3L,1L,2L,6L,5L,6L,2L,5L,1L,4L,4L,8L,3L,5L,9L,9L,4L,5L,1L,2L,1L,3L,9L,3L,0L,1L,3L,6L,8L,4L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019694Inst : IEnumerable<long>
{
public static readonly long[] Value=A019694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019694.Bytes);
public long this[int i]=>Value[i];

public static A019694Inst Instance=new A019694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019677
{
public static readonly BigInteger[] Value={ 1L,24L,400L,5760L,77056L,989184L,12390400L,152862720L,1867841536L,22682271744L,274333696000L,3309180026880L,39847582498816L,479270434504704L,5760041038643200L,69190860134154240L,830853267268304896L,9974742789667160064UL,BigInteger.Parse("119732942204305408000") };
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
public class A019677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019677Inst Instance=new A019677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019676
{
public static readonly long[] Value={ 3L,4L,9L,0L,6L,5L,8L,5L,0L,3L,9L,8L,8L,6L,5L,9L,1L,5L,3L,8L,4L,7L,3L,8L,1L,5L,3L,6L,9L,7L,7L,2L,2L,5L,4L,2L,6L,8L,8L,5L,7L,4L,3L,7L,7L,7L,0L,8L,3L,4L,5L,0L,9L,1L,2L,1L,9L,4L,3L,8L,2L,8L,8L,0L,3L,4L,2L,0L,1L,8L,2L,2L,9L,2L,0L,6L,8L,9L,8L,8L,8L,7L,3L,6L,4L,4L,8L,3L,1L,3L,9L,2L,6L,9L,0L,1L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019676Inst : IEnumerable<long>
{
public static readonly long[] Value=A019676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019676.Bytes);
public long this[int i]=>Value[i];

public static A019676Inst Instance=new A019676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019675
{
public static readonly long[] Value={ 3L,9L,2L,6L,9L,9L,0L,8L,1L,6L,9L,8L,7L,2L,4L,1L,5L,4L,8L,0L,7L,8L,3L,0L,4L,2L,2L,9L,0L,9L,9L,3L,7L,8L,6L,0L,5L,2L,4L,6L,4L,6L,1L,7L,4L,9L,2L,1L,8L,8L,8L,2L,2L,7L,6L,2L,1L,8L,6L,8L,0L,7L,4L,0L,3L,8L,4L,7L,7L,0L,5L,0L,7L,8L,5L,7L,7L,6L,1L,2L,4L,8L,2L,8L,5L,0L,4L,3L,5L,3L,1L,6L,7L,7L,6L,4L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019675Inst : IEnumerable<long>
{
public static readonly long[] Value=A019675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019675.Bytes);
public long this[int i]=>Value[i];

public static A019675Inst Instance=new A019675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019674
{
public static readonly long[] Value={ 4L,4L,8L,7L,9L,8L,9L,5L,0L,5L,1L,2L,8L,2L,7L,6L,0L,5L,4L,9L,4L,6L,6L,3L,3L,4L,0L,4L,6L,8L,5L,0L,0L,4L,1L,2L,0L,2L,8L,1L,6L,7L,0L,5L,7L,0L,5L,3L,5L,8L,6L,5L,4L,5L,8L,5L,3L,5L,6L,3L,5L,1L,3L,1L,8L,6L,8L,3L,0L,9L,1L,5L,1L,8L,3L,7L,4L,4L,1L,4L,2L,6L,6L,1L,1L,4L,7L,8L,3L,2L,1L,9L,1L,7L,3L,1L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019674Inst : IEnumerable<long>
{
public static readonly long[] Value=A019674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019674.Bytes);
public long this[int i]=>Value[i];

public static A019674Inst Instance=new A019674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019673
{
public static readonly long[] Value={ 5L,2L,3L,5L,9L,8L,7L,7L,5L,5L,9L,8L,2L,9L,8L,8L,7L,3L,0L,7L,7L,1L,0L,7L,2L,3L,0L,5L,4L,6L,5L,8L,3L,8L,1L,4L,0L,3L,2L,8L,6L,1L,5L,6L,6L,5L,6L,2L,5L,1L,7L,6L,3L,6L,8L,2L,9L,1L,5L,7L,4L,3L,2L,0L,5L,1L,3L,0L,2L,7L,3L,4L,3L,8L,1L,0L,3L,4L,8L,3L,3L,1L,0L,4L,6L,7L,2L,4L,7L,0L,8L,9L,0L,3L,5L,2L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019673Inst : IEnumerable<long>
{
public static readonly long[] Value=A019673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019673.Bytes);
public long this[int i]=>Value[i];

public static A019673Inst Instance=new A019673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019672
{
public static readonly long[] Value={ 1L,23L,365L,4975L,62661L,753783L,8811805L,101107775L,1145674421L,12870591943L,143722946445L,1598128085775L,17716831119781L,195984586836503L,2164626279788285L,23881256748106975L,263256769887630741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019672Inst : IEnumerable<long>
{
public static readonly long[] Value=A019672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019672.Bytes);
public long this[int i]=>Value[i];

public static A019672Inst Instance=new A019672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019671
{
public static readonly long[] Value={ 1L,22L,332L,4280L,50736L,571872L,6238912L,66567040L,699159296L,7259766272L,74744097792L,764616652800L,7783588704256L,78935331561472L,798149140201472L,8051859072450560L,81081536382959616L,815318946277097472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019671Inst : IEnumerable<long>
{
public static readonly long[] Value=A019671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019671.Bytes);
public long this[int i]=>Value[i];

public static A019671Inst Instance=new A019671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019670
{
public static readonly long[] Value={ 1L,0L,4L,7L,1L,9L,7L,5L,5L,1L,1L,9L,6L,5L,9L,7L,7L,4L,6L,1L,5L,4L,2L,1L,4L,4L,6L,1L,0L,9L,3L,1L,6L,7L,6L,2L,8L,0L,6L,5L,7L,2L,3L,1L,3L,3L,1L,2L,5L,0L,3L,5L,2L,7L,3L,6L,5L,8L,3L,1L,4L,8L,6L,4L,1L,0L,2L,6L,0L,5L,4L,6L,8L,7L,6L,2L,0L,6L,9L,6L,6L,6L,2L,0L,9L,3L,4L,4L,9L,4L,1L,7L,8L,0L,7L,0L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019670Inst : IEnumerable<long>
{
public static readonly long[] Value=A019670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019670.Bytes);
public long this[int i]=>Value[i];

public static A019670Inst Instance=new A019670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019669
{
public static readonly long[] Value={ 1L,5L,7L,0L,7L,9L,6L,3L,2L,6L,7L,9L,4L,8L,9L,6L,6L,1L,9L,2L,3L,1L,3L,2L,1L,6L,9L,1L,6L,3L,9L,7L,5L,1L,4L,4L,2L,0L,9L,8L,5L,8L,4L,6L,9L,9L,6L,8L,7L,5L,5L,2L,9L,1L,0L,4L,8L,7L,4L,7L,2L,2L,9L,6L,1L,5L,3L,9L,0L,8L,2L,0L,3L,1L,4L,3L,1L,0L,4L,4L,9L,9L,3L,1L,4L,0L,1L,7L,4L,1L,2L,6L,7L,1L,0L,5L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019669Inst : IEnumerable<long>
{
public static readonly long[] Value=A019669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019669.Bytes);
public long this[int i]=>Value[i];

public static A019669Inst Instance=new A019669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019668
{
public static readonly long[] Value={ 1L,2L,1L,7L,6L,1L,7L,6L,5L,2L,2L,1L,7L,6L,1L,5L,7L,7L,6L,8L,9L,2L,3L,4L,2L,9L,4L,8L,3L,7L,8L,2L,0L,0L,9L,6L,4L,7L,4L,9L,1L,2L,8L,1L,4L,6L,9L,3L,6L,0L,6L,9L,5L,2L,4L,5L,9L,0L,7L,2L,5L,0L,0L,4L,7L,7L,9L,9L,8L,1L,7L,3L,8L,4L,8L,4L,5L,6L,5L,3L,6L,8L,5L,1L,8L,3L,1L,5L,2L,3L,6L,5L,6L,9L,6L,0L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019668Inst : IEnumerable<long>
{
public static readonly long[] Value=A019668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019668.Bytes);
public long this[int i]=>Value[i];

public static A019668Inst Instance=new A019668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019667
{
public static readonly long[] Value={ 1L,2L,7L,0L,5L,5L,7L,5L,5L,0L,1L,4L,0L,1L,2L,0L,8L,1L,0L,6L,7L,0L,2L,7L,0L,9L,0L,2L,6L,5L,5L,5L,1L,4L,0L,5L,0L,1L,7L,3L,0L,0L,3L,2L,8L,3L,7L,5L,9L,3L,7L,6L,8L,9L,5L,2L,2L,5L,1L,0L,4L,3L,5L,2L,8L,1L,3L,8L,9L,3L,9L,8L,7L,9L,8L,3L,8L,9L,4L,2L,9L,7L,5L,8L,4L,3L,2L,8L,9L,4L,2L,5L,0L,7L,4L,1L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019667Inst : IEnumerable<long>
{
public static readonly long[] Value=A019667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019667.Bytes);
public long this[int i]=>Value[i];

public static A019667Inst Instance=new A019667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019666
{
public static readonly long[] Value={ 1L,3L,2L,8L,3L,1L,0L,1L,6L,6L,0L,5L,5L,5L,8L,0L,8L,4L,7L,5L,1L,8L,9L,1L,9L,5L,8L,0L,0L,4L,8L,9L,4L,6L,5L,0L,6L,9L,9L,9L,0L,4L,8L,8L,8L,7L,5L,6L,6L,6L,2L,1L,2L,9L,9L,5L,5L,3L,5L,1L,8L,1L,8L,7L,0L,3L,2L,7L,0L,7L,3L,5L,1L,0L,7L,4L,0L,7L,1L,3L,1L,1L,1L,1L,0L,8L,8L,9L,3L,4L,8L,9L,8L,5L,0L,2L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019666Inst : IEnumerable<long>
{
public static readonly long[] Value=A019666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019666.Bytes);
public long this[int i]=>Value[i];

public static A019666Inst Instance=new A019666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019665
{
public static readonly long[] Value={ 1L,3L,9L,1L,5L,6L,3L,0L,3L,1L,1L,0L,5L,8L,4L,6L,6L,0L,2L,1L,6L,2L,6L,7L,7L,6L,5L,5L,2L,8L,9L,3L,7L,2L,5L,3L,1L,1L,4L,1L,8L,6L,0L,7L,3L,9L,3L,5L,5L,5L,0L,8L,0L,2L,8L,1L,0L,3L,6L,8L,5L,7L,1L,9L,7L,4L,8L,5L,5L,0L,5L,5L,8L,2L,6L,8L,0L,7L,4L,7L,0L,6L,8L,7L,8L,0L,7L,4L,5L,5L,6L,0L,7L,9L,5L,5L,1L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019665Inst : IEnumerable<long>
{
public static readonly long[] Value=A019665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019665.Bytes);
public long this[int i]=>Value[i];

public static A019665Inst Instance=new A019665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019664
{
public static readonly long[] Value={ 1L,21L,301L,3669L,40957L,433125L,4418317L,43942773L,428973853L,4128937989L,39306876973L,370937567637L,3475860284989L,32382187083813L,300235508341069L,2772487245505461L,25515330868003165L,234141560259529797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019664Inst : IEnumerable<long>
{
public static readonly long[] Value=A019664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019664.Bytes);
public long this[int i]=>Value[i];

public static A019664Inst Instance=new A019664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019663
{
public static readonly long[] Value={ 1L,5L,3L,8L,0L,4L,3L,3L,5L,0L,1L,6L,9L,6L,1L,9L,9L,2L,8L,7L,0L,6L,1L,1L,7L,4L,0L,8L,4L,7L,7L,7L,2L,7L,5L,3L,4L,4L,1L,9L,9L,5L,1L,3L,4L,3L,4L,9L,8L,1L,9L,3L,0L,8L,3L,6L,9L,3L,5L,4L,7L,3L,7L,4L,4L,5L,8L,9L,2L,4L,3L,0L,1L,2L,4L,3L,6L,6L,1L,5L,1L,8L,1L,2L,8L,3L,9L,8L,1L,9L,3L,5L,6L,1L,6L,0L,9L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019663Inst : IEnumerable<long>
{
public static readonly long[] Value=A019663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019663.Bytes);
public long this[int i]=>Value[i];

public static A019663Inst Instance=new A019663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019662
{
public static readonly long[] Value={ 1L,6L,2L,3L,4L,9L,0L,2L,0L,2L,9L,5L,6L,8L,2L,1L,0L,3L,5L,8L,5L,6L,4L,5L,7L,2L,6L,4L,5L,0L,4L,2L,6L,7L,9L,5L,2L,9L,9L,8L,8L,3L,7L,5L,2L,9L,2L,4L,8L,0L,9L,2L,6L,9L,9L,4L,5L,4L,3L,0L,0L,0L,0L,6L,3L,7L,3L,3L,0L,8L,9L,8L,4L,6L,4L,6L,0L,8L,7L,1L,5L,8L,0L,2L,4L,4L,2L,0L,3L,1L,5L,4L,2L,6L,1L,4L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019662Inst : IEnumerable<long>
{
public static readonly long[] Value=A019662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019662.Bytes);
public long this[int i]=>Value[i];

public static A019662Inst Instance=new A019662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019629
{
public static readonly long[] Value={ 4L,0L,6L,6L,5L,4L,0L,1L,0L,6L,0L,3L,5L,0L,3L,1L,9L,3L,5L,9L,3L,5L,0L,2L,4L,2L,2L,3L,5L,9L,3L,6L,0L,6L,9L,0L,2L,3L,9L,7L,5L,6L,5L,9L,6L,9L,4L,1L,1L,9L,5L,9L,5L,0L,5L,6L,5L,6L,9L,5L,2L,9L,1L,9L,1L,3L,2L,9L,6L,6L,0L,0L,5L,3L,1L,3L,0L,1L,4L,6L,7L,0L,2L,7L,2L,6L,4L,9L,4L,6L,1L,7L,6L,6L,8L,9L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019629Inst : IEnumerable<long>
{
public static readonly long[] Value=A019629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019629.Bytes);
public long this[int i]=>Value[i];

public static A019629Inst Instance=new A019629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019628
{
public static readonly long[] Value={ 1L,23L,369L,5143L,66977L,841575L,10367953L,126315191L,1529146113L,18443562247L,221980457777L,2668373663319L,32052757927009L,384859080003239L,4619891122628241L,55449769683406327L,665474773978915265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019628Inst : IEnumerable<long>
{
public static readonly long[] Value=A019628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019628.Bytes);
public long this[int i]=>Value[i];

public static A019628Inst Instance=new A019628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019627
{
public static readonly long[] Value={ 4L,4L,9L,4L,5L,9L,6L,9L,5L,9L,3L,0L,1L,8L,7L,7L,4L,0L,2L,8L,7L,5L,5L,5L,3L,0L,8L,9L,2L,3L,5L,0L,3L,9L,2L,0L,7L,9L,1L,3L,0L,9L,9L,2L,2L,9L,3L,5L,0L,0L,6L,0L,5L,0L,6L,2L,5L,2L,4L,2L,1L,6L,4L,7L,4L,6L,2L,7L,5L,1L,9L,0L,0L,6L,0L,9L,1L,2L,1L,4L,7L,7L,6L,6L,9L,7L,7L,0L,4L,5L,7L,7L,4L,2L,3L,5L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019627Inst : IEnumerable<long>
{
public static readonly long[] Value=A019627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019627.Bytes);
public long this[int i]=>Value[i];

public static A019627Inst Instance=new A019627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019626
{
public static readonly long[] Value={ 4L,7L,4L,4L,2L,9L,6L,7L,9L,0L,3L,7L,4L,2L,0L,3L,9L,2L,5L,2L,5L,7L,5L,2L,8L,2L,6L,0L,8L,5L,9L,2L,0L,8L,0L,5L,2L,7L,9L,7L,1L,6L,0L,2L,9L,7L,6L,4L,7L,2L,8L,6L,0L,8L,9L,9L,3L,3L,1L,1L,1L,7L,3L,8L,9L,8L,8L,4L,6L,0L,3L,3L,9L,5L,3L,1L,8L,5L,0L,4L,4L,8L,6L,5L,1L,4L,2L,4L,3L,7L,2L,0L,6L,1L,3L,7L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019626Inst : IEnumerable<long>
{
public static readonly long[] Value=A019626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019626.Bytes);
public long this[int i]=>Value[i];

public static A019626Inst Instance=new A019626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019625
{
public static readonly long[] Value={ 5L,0L,2L,3L,3L,7L,3L,0L,7L,2L,1L,6L,0L,9L,2L,1L,8L,0L,3L,2L,1L,3L,8L,5L,3L,4L,5L,2L,6L,7L,4L,4L,5L,5L,5L,8L,5L,3L,1L,4L,6L,4L,0L,3L,1L,5L,1L,5L,5L,9L,4L,9L,9L,7L,7L,5L,7L,6L,2L,3L,5L,9L,5L,8L,9L,2L,8L,9L,5L,8L,0L,0L,6L,5L,6L,3L,1L,3L,5L,7L,6L,9L,1L,6L,0L,3L,3L,1L,6L,8L,8L,0L,6L,4L,9L,8L,4L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019625Inst : IEnumerable<long>
{
public static readonly long[] Value=A019625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019625.Bytes);
public long this[int i]=>Value[i];

public static A019625Inst Instance=new A019625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019624
{
public static readonly long[] Value={ 5L,3L,3L,7L,3L,3L,3L,8L,8L,9L,1L,7L,0L,9L,7L,9L,4L,1L,5L,9L,1L,4L,7L,1L,9L,2L,9L,3L,4L,6L,6L,6L,0L,9L,0L,5L,9L,3L,9L,6L,8L,0L,5L,3L,3L,4L,8L,5L,3L,1L,9L,6L,8L,5L,1L,1L,7L,4L,7L,5L,0L,7L,0L,6L,3L,6L,2L,0L,1L,7L,8L,8L,1L,9L,7L,3L,3L,3L,1L,7L,5L,4L,7L,3L,2L,8L,5L,2L,4L,1L,8L,5L,6L,9L,0L,4L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019624Inst : IEnumerable<long>
{
public static readonly long[] Value=A019624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019624.Bytes);
public long this[int i]=>Value[i];

public static A019624Inst Instance=new A019624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019623
{
public static readonly long[] Value={ 1L,22L,335L,4400L,53661L,628122L,7178395L,80862100L,902846921L,10025125022L,110934086055L,1224883116600L,13505988249781L,148791855626722L,1638292574483315L,18032294531183900L,198432777621062241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019623Inst : IEnumerable<long>
{
public static readonly long[] Value=A019623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019623.Bytes);
public long this[int i]=>Value[i];

public static A019623Inst Instance=new A019623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019622
{
public static readonly long[] Value={ 6L,0L,9L,9L,8L,1L,0L,1L,5L,9L,0L,5L,2L,5L,4L,7L,9L,0L,3L,9L,0L,2L,5L,3L,6L,3L,3L,5L,3L,9L,0L,4L,1L,0L,3L,5L,3L,5L,9L,6L,3L,4L,8L,9L,5L,4L,1L,1L,7L,9L,3L,9L,2L,5L,8L,4L,8L,5L,4L,2L,9L,3L,7L,8L,6L,9L,9L,4L,4L,9L,0L,0L,7L,9L,6L,9L,5L,2L,2L,0L,0L,5L,4L,0L,8L,9L,7L,4L,1L,9L,2L,6L,5L,0L,3L,3L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019622Inst : IEnumerable<long>
{
public static readonly long[] Value=A019622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019622.Bytes);
public long this[int i]=>Value[i];

public static A019622Inst Instance=new A019622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019621
{
public static readonly long[] Value={ 6L,5L,6L,9L,0L,2L,6L,3L,2L,5L,1L,3L,3L,5L,1L,3L,1L,2L,7L,2L,7L,9L,6L,5L,4L,5L,1L,5L,0L,3L,5L,8L,2L,6L,5L,3L,4L,6L,4L,2L,2L,2L,1L,9L,5L,0L,5L,8L,8L,5L,4L,9L,9L,7L,0L,6L,7L,6L,6L,1L,6L,2L,5L,3L,9L,8L,4L,0L,2L,2L,0L,0L,8L,5L,8L,2L,5L,6L,2L,1L,5L,9L,6L,7L,1L,2L,0L,2L,9L,7L,6L,7L,0L,0L,3L,6L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019621Inst : IEnumerable<long>
{
public static readonly long[] Value=A019621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019621.Bytes);
public long this[int i]=>Value[i];

public static A019621Inst Instance=new A019621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019620
{
public static readonly long[] Value={ 7L,1L,1L,6L,4L,4L,5L,1L,8L,5L,5L,6L,1L,3L,0L,5L,8L,8L,7L,8L,8L,6L,2L,9L,2L,3L,9L,1L,2L,8L,8L,8L,1L,2L,0L,7L,9L,1L,9L,5L,7L,4L,0L,4L,4L,6L,4L,7L,0L,9L,2L,9L,1L,3L,4L,8L,9L,9L,6L,6L,7L,6L,0L,8L,4L,8L,2L,6L,9L,0L,5L,0L,9L,2L,9L,7L,7L,7L,5L,6L,7L,2L,9L,7L,7L,1L,3L,6L,5L,5L,8L,0L,9L,2L,0L,6L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019620Inst : IEnumerable<long>
{
public static readonly long[] Value=A019620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019620.Bytes);
public long this[int i]=>Value[i];

public static A019620Inst Instance=new A019620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019619
{
public static readonly long[] Value={ 7L,7L,6L,3L,3L,9L,4L,7L,4L,7L,8L,8L,5L,0L,6L,0L,9L,6L,8L,6L,0L,3L,2L,2L,8L,0L,6L,3L,2L,2L,4L,1L,5L,8L,6L,3L,1L,8L,4L,9L,8L,9L,8L,6L,6L,8L,8L,7L,7L,3L,7L,7L,2L,3L,8L,0L,7L,2L,3L,6L,4L,6L,6L,3L,7L,9L,9L,2L,9L,8L,7L,3L,7L,4L,1L,5L,7L,5L,5L,2L,7L,9L,6L,1L,1L,4L,2L,1L,6L,9L,9L,7L,3L,6L,7L,9L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019619Inst : IEnumerable<long>
{
public static readonly long[] Value=A019619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019619.Bytes);
public long this[int i]=>Value[i];

public static A019619Inst Instance=new A019619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019618
{
public static readonly long[] Value={ 1L,21L,303L,3745L,42711L,464961L,4918663L,51086385L,524227671L,5336085601L,54018566823L,544793838225L,5480212349431L,55028108373441L,551863246323783L,5529708675105265L,55374624529091991L,554289026917064481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019618Inst : IEnumerable<long>
{
public static readonly long[] Value=A019618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019618.Bytes);
public long this[int i]=>Value[i];

public static A019618Inst Instance=new A019618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019617
{
public static readonly long[] Value={ 9L,4L,8L,8L,5L,9L,3L,5L,8L,0L,7L,4L,8L,4L,0L,7L,8L,5L,0L,5L,1L,5L,0L,5L,6L,5L,2L,1L,7L,1L,8L,4L,1L,6L,1L,0L,5L,5L,9L,4L,3L,2L,0L,5L,9L,5L,2L,9L,4L,5L,7L,2L,1L,7L,9L,8L,6L,6L,2L,2L,3L,4L,7L,7L,9L,7L,6L,9L,2L,0L,6L,7L,9L,0L,6L,3L,7L,0L,0L,8L,9L,7L,3L,0L,2L,8L,4L,8L,7L,4L,4L,1L,2L,2L,7L,4L,8L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019617Inst : IEnumerable<long>
{
public static readonly long[] Value=A019617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019617.Bytes);
public long this[int i]=>Value[i];

public static A019617Inst Instance=new A019617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019616
{
public static readonly long[] Value={ 1L,0L,6L,7L,4L,6L,6L,7L,7L,7L,8L,3L,4L,1L,9L,5L,8L,8L,3L,1L,8L,2L,9L,4L,3L,8L,5L,8L,6L,9L,3L,3L,2L,1L,8L,1L,1L,8L,7L,9L,3L,6L,1L,0L,6L,6L,9L,7L,0L,6L,3L,9L,3L,7L,0L,2L,3L,4L,9L,5L,0L,1L,4L,1L,2L,7L,2L,4L,0L,3L,5L,7L,6L,3L,9L,4L,6L,6L,6L,3L,5L,0L,9L,4L,6L,5L,7L,0L,4L,8L,3L,7L,1L,3L,8L,0L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019616Inst : IEnumerable<long>
{
public static readonly long[] Value=A019616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019616.Bytes);
public long this[int i]=>Value[i];

public static A019616Inst Instance=new A019616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019615
{
public static readonly long[] Value={ 1L,2L,1L,9L,9L,6L,2L,0L,3L,1L,8L,1L,0L,5L,0L,9L,5L,8L,0L,7L,8L,0L,5L,0L,7L,2L,6L,7L,0L,7L,8L,0L,8L,2L,0L,7L,0L,7L,1L,9L,2L,6L,9L,7L,9L,0L,8L,2L,3L,5L,8L,7L,8L,5L,1L,6L,9L,7L,0L,8L,5L,8L,7L,5L,7L,3L,9L,8L,8L,9L,8L,0L,1L,5L,9L,3L,9L,0L,4L,4L,0L,1L,0L,8L,1L,7L,9L,4L,8L,3L,8L,5L,3L,0L,0L,6L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019615Inst : IEnumerable<long>
{
public static readonly long[] Value=A019615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019615.Bytes);
public long this[int i]=>Value[i];

public static A019615Inst Instance=new A019615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019614
{
public static readonly long[] Value={ 1L,4L,2L,3L,2L,8L,9L,0L,3L,7L,1L,1L,2L,2L,6L,1L,1L,7L,7L,5L,7L,7L,2L,5L,8L,4L,7L,8L,2L,5L,7L,7L,6L,2L,4L,1L,5L,8L,3L,9L,1L,4L,8L,0L,8L,9L,2L,9L,4L,1L,8L,5L,8L,2L,6L,9L,7L,9L,9L,3L,3L,5L,2L,1L,6L,9L,6L,5L,3L,8L,1L,0L,1L,8L,5L,9L,5L,5L,5L,1L,3L,4L,5L,9L,5L,4L,2L,7L,3L,1L,1L,6L,1L,8L,4L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019614Inst : IEnumerable<long>
{
public static readonly long[] Value=A019614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019614.Bytes);
public long this[int i]=>Value[i];

public static A019614Inst Instance=new A019614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019597
{
public static readonly long[] Value={ 1L,7L,0L,7L,9L,4L,6L,8L,4L,4L,5L,3L,4L,7L,1L,3L,4L,1L,3L,0L,9L,2L,7L,1L,0L,1L,7L,3L,9L,0L,9L,3L,1L,4L,8L,9L,9L,0L,0L,6L,9L,7L,7L,7L,0L,7L,1L,5L,3L,0L,2L,2L,9L,9L,2L,3L,7L,5L,9L,2L,0L,2L,2L,6L,0L,3L,5L,8L,4L,5L,7L,2L,2L,2L,3L,1L,4L,6L,6L,1L,6L,1L,5L,1L,4L,5L,1L,2L,7L,7L,3L,9L,4L,2L,0L,9L,4L,7L,8L,8L,7L,8L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019597Inst : IEnumerable<long>
{
public static readonly long[] Value=A019597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019597.Bytes);
public long this[int i]=>Value[i];

public static A019597Inst Instance=new A019597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019596
{
public static readonly long[] Value={ 2L,4L,47L,233L,477L,538L,1163L,4544L,23938L,47952L,74329L,385194L,424332L,838758L,3601963L,8880674L,9376182L,10177957L,10622608L,12051969L,14306604L,23190118L,25373883L,28661729L,138953419L,1150488807L,1204511338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019596Inst : IEnumerable<long>
{
public static readonly long[] Value=A019596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019596.Bytes);
public long this[int i]=>Value[i];

public static A019596Inst Instance=new A019596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019595
{
public static readonly long[] Value={ 1L,2L,3L,7L,14L,30L,33L,66L,177L,227L,686L,932L,1283L,1623L,1827L,3603L,7429L,15750L,16438L,18650L,22139L,22967L,31412L,35482L,36075L,62639L,128086L,175642L,201758L,239985L,261506L,301601L,786609L,853738L,2283613L,2510846L,2568758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019595Inst : IEnumerable<long>
{
public static readonly long[] Value=A019595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019595.Bytes);
public long this[int i]=>Value[i];

public static A019595Inst Instance=new A019595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019594
{
public static readonly long[] Value={ 1L,3L,2L,5L,8L,5L,9L,5L,10L,15L,9L,15L,21L,13L,20L,11L,19L,27L,16L,25L,13L,23L,33L,19L,30L,41L,25L,37L,20L,33L,46L,27L,41L,55L,34L,49L,27L,43L,59L,35L,52L,27L,45L,63L,36L,55L,74L,45L,65L,35L,56L,77L,45L,67L,34L,57L,80L,45L,69L,93L,56L,81L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019594Inst : IEnumerable<long>
{
public static readonly long[] Value=A019594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019594.Bytes);
public long this[int i]=>Value[i];

public static A019594Inst Instance=new A019594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019593
{
public static readonly long[] Value={ 2L,22L,38L,114L,219L,354L,3035L,6182L,6502L,11935L,22946L,33122L,58975L,137394L,865634L,1060511L,2604630L,3041138L,13633887L,30516651L,51664754L,73000543L,126052390L,469204879L,12224092843L,14479084326L,19560684367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019593Inst : IEnumerable<long>
{
public static readonly long[] Value=A019593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019593.Bytes);
public long this[int i]=>Value[i];

public static A019593Inst Instance=new A019593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019592
{
public static readonly long[] Value={ 1L,2L,7L,12L,17L,36L,41L,83L,275L,284L,307L,443L,444L,775L,869L,2523L,3485L,4069L,5772L,9689L,16403L,30902L,53359L,83792L,122933L,1090845L,1473689L,1510781L,1740110L,2652867L,2693291L,3008386L,3085790L,51051449L,55594816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019592Inst : IEnumerable<long>
{
public static readonly long[] Value=A019592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019592.Bytes);
public long this[int i]=>Value[i];

public static A019592Inst Instance=new A019592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019591
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,2L,3L,0L,1L,4L,0L,2L,4L,0L,2L,3L,0L,1L,4L,0L,2L,4L,0L,2L,6L,0L,1L,3L,0L,2L,5L,0L,2L,6L,0L,1L,8L,0L,2L,3L,0L,2L,6L,0L,1L,4L,0L,2L,4L,0L,2L,3L,0L,1L,4L,0L,2L,8L,0L,2L,8L,0L,1L,3L,0L,2L,5L,0L,2L,7L,0L,1L,8L,0L,2L,3L,0L,2L,8L,0L,1L,4L,0L,2L,4L,0L,2L,3L,0L,1L,4L,0L,2L,8L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019591Inst : IEnumerable<long>
{
public static readonly long[] Value=A019591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019591.Bytes);
public long this[int i]=>Value[i];

public static A019591Inst Instance=new A019591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019590
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019590Inst : IEnumerable<long>
{
public static readonly long[] Value=A019590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019590.Bytes);
public long this[int i]=>Value[i];

public static A019590Inst Instance=new A019590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019589
{
public static readonly long[] Value={ 1L,1L,2L,5L,16L,59L,246L,1105L,5270L,26231L,135036L,713898L,3857113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019589Inst : IEnumerable<long>
{
public static readonly long[] Value=A019589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019589.Bytes);
public long this[int i]=>Value[i];

public static A019589Inst Instance=new A019589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019588
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,2L,5L,1L,5L,9L,3L,8L,13L,5L,11L,2L,9L,16L,5L,13L,1L,10L,19L,5L,15L,25L,9L,20L,3L,15L,27L,8L,21L,34L,13L,27L,5L,20L,35L,11L,27L,2L,19L,36L,9L,27L,45L,16L,35L,5L,25L,45L,13L,34L,1L,23L,45L,10L,33L,56L,19L,43L,5L,30L,55L,15L,41L,67L,25L,52L,9L,37L,65L,20L,49L,3L,33L,63L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019588Inst : IEnumerable<long>
{
public static readonly long[] Value=A019588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019588.Bytes);
public long this[int i]=>Value[i];

public static A019588Inst Instance=new A019588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019587
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,5L,3L,8L,5L,2L,9L,5L,1L,10L,5L,15L,9L,3L,15L,8L,21L,13L,5L,20L,11L,2L,19L,9L,27L,16L,5L,25L,13L,1L,23L,10L,33L,19L,5L,30L,15L,41L,25L,9L,37L,20L,3L,33L,15L,46L,27L,8L,41L,21L,55L,34L,13L,49L,27L,5L,43L,20L,59L,35L,11L,52L,27L,2L,45L,19L,63L,36L,9L,55L,27L,74L,45L,16L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019587Inst : IEnumerable<long>
{
public static readonly long[] Value=A019587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019587.Bytes);
public long this[int i]=>Value[i];

public static A019587Inst Instance=new A019587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019586
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,0L,3L,2L,1L,4L,0L,5L,3L,2L,6L,1L,7L,4L,0L,8L,5L,3L,9L,2L,10L,6L,1L,11L,7L,4L,12L,0L,13L,8L,5L,14L,3L,15L,9L,2L,16L,10L,6L,17L,1L,18L,11L,7L,19L,4L,20L,12L,0L,21L,13L,8L,22L,5L,23L,14L,3L,24L,15L,9L,25L,2L,26L,16L,10L,27L,6L,28L,17L,1L,29L,18L,11L,30L,7L,31L,19L,4L,32L,20L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019586Inst : IEnumerable<long>
{
public static readonly long[] Value=A019586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019586.Bytes);
public long this[int i]=>Value[i];

public static A019586Inst Instance=new A019586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019585
{
public static readonly long[] Value={ 0L,-2L,-3L,-7L,-6L,-12L,-9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019585Inst : IEnumerable<long>
{
public static readonly long[] Value=A019585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019585.Bytes);
public long this[int i]=>Value[i];

public static A019585Inst Instance=new A019585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019584
{
public static readonly long[] Value={ 0L,0L,1L,18L,108L,400L,1125L,2646L,5488L,10368L,18225L,30250L,47916L,73008L,107653L,154350L,216000L,295936L,397953L,526338L,685900L,882000L,1120581L,1408198L,1752048L,2160000L,2640625L,3203226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019584Inst : IEnumerable<long>
{
public static readonly long[] Value=A019584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019584.Bytes);
public long this[int i]=>Value[i];

public static A019584Inst Instance=new A019584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019583
{
public static readonly long[] Value={ 0L,0L,1L,24L,162L,640L,1875L,4536L,9604L,18432L,32805L,55000L,87846L,134784L,199927L,288120L,405000L,557056L,751689L,997272L,1303210L,1680000L,2139291L,2693944L,3358092L,4147200L,5078125L,6169176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019583Inst : IEnumerable<long>
{
public static readonly long[] Value=A019583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019583.Bytes);
public long this[int i]=>Value[i];

public static A019583Inst Instance=new A019583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019582
{
public static readonly long[] Value={ 0L,0L,1L,12L,54L,160L,375L,756L,1372L,2304L,3645L,5500L,7986L,11232L,15379L,20580L,27000L,34816L,44217L,55404L,68590L,84000L,101871L,122452L,146004L,172800L,203125L,237276L,275562L,318304L,365835L,418500L,476656L,540672L,610929L,687820L,771750L,863136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019582Inst : IEnumerable<long>
{
public static readonly long[] Value=A019582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019582.Bytes);
public long this[int i]=>Value[i];

public static A019582Inst Instance=new A019582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019565
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,10L,15L,30L,7L,14L,21L,42L,35L,70L,105L,210L,11L,22L,33L,66L,55L,110L,165L,330L,77L,154L,231L,462L,385L,770L,1155L,2310L,13L,26L,39L,78L,65L,130L,195L,390L,91L,182L,273L,546L,455L,910L,1365L,2730L,143L,286L,429L,858L,715L,1430L,2145L,4290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019565Inst : IEnumerable<long>
{
public static readonly long[] Value=A019565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019565.Bytes);
public long this[int i]=>Value[i];

public static A019565Inst Instance=new A019565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019564
{
public static readonly long[] Value={ 1L,128L,2816L,27008L,157184L,658048L,2187520L,6140800L,15158272L,33830016L,69629696L,134110592L,244396544L,425000576L,710003968L,1145628544L,1793234944L,2732779648L,4066763520L,5924704640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019564Inst : IEnumerable<long>
{
public static readonly long[] Value=A019564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019564.Bytes);
public long this[int i]=>Value[i];

public static A019564Inst Instance=new A019564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019563
{
public static readonly long[] Value={ 1L,98L,1666L,12642L,59906L,209762L,596610L,1459810L,3188738L,6376034L,11879042L,20889442L,35011074L,56345954L,87588482L,132127842L,194158594L,278799458L,392220290L,541777250L,736156162L,985524066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019563Inst : IEnumerable<long>
{
public static readonly long[] Value=A019563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019563.Bytes);
public long this[int i]=>Value[i];

public static A019563Inst Instance=new A019563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019562
{
public static readonly long[] Value={ 1L,72L,912L,5336L,20256L,58728L,142000L,301560L,581184L,1038984L,1749456L,2805528L,4320608L,6430632L,9296112L,13104184L,18070656L,24442056L,32497680L,42551640L,54954912L,70097384L,88409904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019562Inst : IEnumerable<long>
{
public static readonly long[] Value=A019562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019562.Bytes);
public long this[int i]=>Value[i];

public static A019562Inst Instance=new A019562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019561
{
public static readonly long[] Value={ 1L,50L,450L,1970L,5890L,14002L,28610L,52530L,89090L,142130L,216002L,315570L,446210L,613810L,824770L,1086002L,1404930L,1789490L,2248130L,2789810L,3424002L,4160690L,5010370L,5984050L,7093250L,8350002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019561Inst : IEnumerable<long>
{
public static readonly long[] Value=A019561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019561.Bytes);
public long this[int i]=>Value[i];

public static A019561Inst Instance=new A019561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019560
{
public static readonly long[] Value={ 1L,32L,192L,608L,1408L,2720L,4672L,7392L,11008L,15648L,21440L,28512L,36992L,47008L,58688L,72160L,87552L,104992L,124608L,146528L,170880L,197792L,227392L,259808L,295168L,333600L,375232L,420192L,468608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019560Inst : IEnumerable<long>
{
public static readonly long[] Value=A019560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019560.Bytes);
public long this[int i]=>Value[i];

public static A019560Inst Instance=new A019560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019559
{
public static readonly long[] Value={ 4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019559Inst : IEnumerable<long>
{
public static readonly long[] Value=A019559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019559.Bytes);
public long this[int i]=>Value[i];

public static A019559Inst Instance=new A019559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019558
{
public static readonly long[] Value={ 1L,48L,384L,1392L,3456L,6960L,12288L,19824L,29952L,43056L,59520L,79728L,104064L,132912L,166656L,205680L,250368L,301104L,358272L,422256L,493440L,572208L,658944L,754032L,857856L,970800L,1093248L,1225584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019558Inst : IEnumerable<long>
{
public static readonly long[] Value=A019558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019558.Bytes);
public long this[int i]=>Value[i];

public static A019558Inst Instance=new A019558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019557
{
public static readonly long[] Value={ 1L,12L,30L,48L,66L,84L,102L,120L,138L,156L,174L,192L,210L,228L,246L,264L,282L,300L,318L,336L,354L,372L,390L,408L,426L,444L,462L,480L,498L,516L,534L,552L,570L,588L,606L,624L,642L,660L,678L,696L,714L,732L,750L,768L,786L,804L,822L,840L,858L,876L,894L,912L,930L,948L,966L,984L,1002L,1020L,1038L,1056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019557Inst : IEnumerable<long>
{
public static readonly long[] Value=A019557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019557.Bytes);
public long this[int i]=>Value[i];

public static A019557Inst Instance=new A019557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019556
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,4L,3L,3L,4L,3L,3L,4L,4L,3L,6L,4L,5L,5L,5L,3L,6L,6L,5L,6L,5L,6L,8L,6L,6L,6L,7L,5L,9L,7L,7L,8L,8L,7L,11L,9L,8L,9L,10L,8L,9L,8L,10L,11L,10L,7L,12L,10L,10L,13L,11L,9L,14L,11L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019556Inst : IEnumerable<long>
{
public static readonly long[] Value=A019556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019556.Bytes);
public long this[int i]=>Value[i];

public static A019556Inst Instance=new A019556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019555
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,2L,3L,10L,11L,6L,13L,14L,15L,4L,17L,6L,19L,10L,21L,22L,23L,6L,5L,26L,3L,14L,29L,30L,31L,4L,33L,34L,35L,6L,37L,38L,39L,10L,41L,42L,43L,22L,15L,46L,47L,12L,7L,10L,51L,26L,53L,6L,55L,14L,57L,58L,59L,30L,61L,62L,21L,4L,65L,66L,67L,34L,69L,70L,71L,6L,73L,74L,15L,38L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019555Inst : IEnumerable<long>
{
public static readonly long[] Value=A019555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019555.Bytes);
public long this[int i]=>Value[i];

public static A019555Inst Instance=new A019555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019554
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,4L,3L,10L,11L,6L,13L,14L,15L,4L,17L,6L,19L,10L,21L,22L,23L,12L,5L,26L,9L,14L,29L,30L,31L,8L,33L,34L,35L,6L,37L,38L,39L,20L,41L,42L,43L,22L,15L,46L,47L,12L,7L,10L,51L,26L,53L,18L,55L,28L,57L,58L,59L,30L,61L,62L,21L,8L,65L,66L,67L,34L,69L,70L,71L,12L,73L,74L,15L,38L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019554Inst : IEnumerable<long>
{
public static readonly long[] Value=A019554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019554.Bytes);
public long this[int i]=>Value[i];

public static A019554Inst Instance=new A019554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019553
{
public static readonly long[] Value={ 15L,210L,315L,420L,525L,630L,735L,840L,945L,1050L,1155L,1260L,1365L,1470L,1575L,1680L,1785L,1890L,1995L,20100L,21105L,22110L,23115L,24120L,25125L,26130L,27135L,28140L,29145L,30150L,31155L,32160L,33165L,34170L,35175L,36180L,37185L,38190L,39195L,40200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019553Inst : IEnumerable<long>
{
public static readonly long[] Value=A019553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019553.Bytes);
public long this[int i]=>Value[i];

public static A019553Inst Instance=new A019553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019552
{
public static readonly long[] Value={ 14L,28L,312L,416L,520L,624L,728L,832L,936L,1040L,1144L,1248L,1352L,1456L,1560L,1664L,1768L,1872L,1976L,2080L,2184L,2288L,2392L,2496L,25100L,26104L,27108L,28112L,29116L,30120L,31124L,32128L,33132L,34136L,35140L,36144L,37148L,38152L,39156L,40160L,41164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019552Inst : IEnumerable<long>
{
public static readonly long[] Value=A019552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019552.Bytes);
public long this[int i]=>Value[i];

public static A019552Inst Instance=new A019552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019551
{
public static readonly long[] Value={ 13L,26L,39L,412L,515L,618L,721L,824L,927L,1030L,1133L,1236L,1339L,1442L,1545L,1648L,1751L,1854L,1957L,2060L,2163L,2266L,2369L,2472L,2575L,2678L,2781L,2884L,2987L,3090L,3193L,3296L,3399L,34102L,35105L,36108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019551Inst : IEnumerable<long>
{
public static readonly long[] Value=A019551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019551.Bytes);
public long this[int i]=>Value[i];

public static A019551Inst Instance=new A019551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019550
{
public static readonly long[] Value={ 12L,24L,36L,48L,510L,612L,714L,816L,918L,1020L,1122L,1224L,1326L,1428L,1530L,1632L,1734L,1836L,1938L,2040L,2142L,2244L,2346L,2448L,2550L,2652L,2754L,2856L,2958L,3060L,3162L,3264L,3366L,3468L,3570L,3672L,3774L,3876L,3978L,4080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019550Inst : IEnumerable<long>
{
public static readonly long[] Value=A019550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019550.Bytes);
public long this[int i]=>Value[i];

public static A019550Inst Instance=new A019550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019533
{
public static readonly long[] Value={ 6L,10L,16L,31L,40L,68L,93L,154L,215L,354L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019533Inst : IEnumerable<long>
{
public static readonly long[] Value=A019533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019533.Bytes);
public long this[int i]=>Value[i];

public static A019533Inst Instance=new A019533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019532
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,12L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019532Inst : IEnumerable<long>
{
public static readonly long[] Value=A019532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019532.Bytes);
public long this[int i]=>Value[i];

public static A019532Inst Instance=new A019532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019531
{
public static readonly long[] Value={ 5L,15L,35L,84L,207L,498L,1202L,2970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019531Inst : IEnumerable<long>
{
public static readonly long[] Value=A019531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019531.Bytes);
public long this[int i]=>Value[i];

public static A019531Inst Instance=new A019531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019530
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,6L,7L,4L,3L,10L,11L,6L,13L,14L,15L,4L,17L,6L,19L,10L,21L,22L,23L,6L,5L,26L,3L,14L,29L,30L,31L,4L,33L,34L,35L,6L,37L,38L,39L,10L,41L,42L,43L,22L,15L,46L,47L,6L,7L,10L,51L,26L,53L,6L,55L,14L,57L,58L,59L,30L,61L,62L,21L,4L,65L,66L,67L,34L,69L,70L,71L,6L,73L,74L,15L,38L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019530Inst : IEnumerable<long>
{
public static readonly long[] Value=A019530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019530.Bytes);
public long this[int i]=>Value[i];

public static A019530Inst Instance=new A019530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019529
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,14L,18L,22L,27L,33L,39L,45L,52L,60L,68L,76L,85L,95L,105L,115L,126L,138L,150L,162L,175L,189L,202L,217L,232L,247L,263L,280L,297L,314L,332L,351L,370L,389L,409L,430L,451L,472L,494L,517L,540L,563L,587L,612L,637L,662L,688L,715L,741L,769L,797L,825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019529Inst : IEnumerable<long>
{
public static readonly long[] Value=A019529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019529.Bytes);
public long this[int i]=>Value[i];

public static A019529Inst Instance=new A019529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019528
{
public static readonly long[] Value={ 5L,5L,6L,8L,11L,16L,25L,38L,59L,93L,148L,235L,376L,602L,966L,1550L,2491L,4003L,6436L,10348L,16643L,26766L,43052L,69247L,111387L,179169L,288207L,463601L,745744L,1199593L,1929661L,3104041L,4993156L,8031978L,12920238L,20783483L,33432314L,53779215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019528Inst : IEnumerable<long>
{
public static readonly long[] Value=A019528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019528.Bytes);
public long this[int i]=>Value[i];

public static A019528Inst Instance=new A019528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019527
{
public static readonly long[] Value={ 4L,4L,5L,6L,8L,11L,15L,21L,30L,43L,62L,90L,131L,191L,279L,408L,597L,874L,1280L,1875L,2747L,4025L,5898L,8643L,12666L,18562L,27203L,39867L,58427L,85628L,125493L,183918L,269544L,395035L,578951L,848493L,1243526L,1822475L,2670966L,3914490L,5736963L,8407927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019527Inst : IEnumerable<long>
{
public static readonly long[] Value=A019527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019527.Bytes);
public long this[int i]=>Value[i];

public static A019527Inst Instance=new A019527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019526
{
public static readonly long[] Value={ 4L,5L,8L,13L,24L,44L,83L,158L,303L,582L,1120L,2157L,4156L,8009L,15436L,29752L,57347L,110538L,213067L,410698L,791644L,1525941L,2941344L,5669621L,10928544L,21065444L,40604947L,78268550L,150867479L,290806414L,560547384L,1080489821L,2082711092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019526Inst : IEnumerable<long>
{
public static readonly long[] Value=A019526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019526.Bytes);
public long this[int i]=>Value[i];

public static A019526Inst Instance=new A019526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019525
{
public static readonly long[] Value={ 2L,3L,6L,12L,27L,60L,138L,315L,726L,1668L,3843L,8844L,20370L,46899L,108006L,248700L,572715L,1318812L,3036954L,6993387L,16104246L,37084404L,85397139L,196650348L,452841762L,1042792803L,2401318086L,5529696492L,12733650747L,29322740220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019525Inst : IEnumerable<long>
{
public static readonly long[] Value=A019525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019525.Bytes);
public long this[int i]=>Value[i];

public static A019525Inst Instance=new A019525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019524
{
public static readonly BigInteger[] Value={ 11L,1212L,123123L,12341234L,1234512345L,123456123456L,12345671234567L,1234567812345678L,123456789123456789L,BigInteger.Parse("1234567891012345678910"),BigInteger.Parse("12345678910111234567891011"),BigInteger.Parse("123456789101112123456789101112") };
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
public class A019524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019524Inst Instance=new A019524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019523
{
public static readonly BigInteger[] Value={ 1L,11L,112L,1123L,11235L,112358L,11235813L,1123581321L,112358132134L,11235813213455L,1123581321345589L,1123581321345589144L,BigInteger.Parse("1123581321345589144233"),BigInteger.Parse("1123581321345589144233377"),BigInteger.Parse("1123581321345589144233377610"),BigInteger.Parse("1123581321345589144233377610987") };
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
public class A019523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019523Inst Instance=new A019523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019522
{
public static readonly BigInteger[] Value={ 1L,18L,1827L,182764L,182764125L,182764125216L,182764125216343L,182764125216343512L,BigInteger.Parse("182764125216343512729"),BigInteger.Parse("1827641252163435127291000"),BigInteger.Parse("18276412521634351272910001331"),BigInteger.Parse("182764125216343512729100013311728") };
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
public class A019522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019522Inst Instance=new A019522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019521
{
public static readonly BigInteger[] Value={ 1L,14L,149L,14916L,1491625L,149162536L,14916253649L,1491625364964L,149162536496481L,149162536496481100L,BigInteger.Parse("149162536496481100121"),BigInteger.Parse("149162536496481100121144"),BigInteger.Parse("149162536496481100121144169") };
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
public class A019521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019521Inst Instance=new A019521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019520
{
public static readonly BigInteger[] Value={ 2L,24L,246L,2468L,246810L,24681012L,2468101214L,246810121416L,24681012141618L,2468101214161820L,246810121416182022L,BigInteger.Parse("24681012141618202224"),BigInteger.Parse("2468101214161820222426"),BigInteger.Parse("246810121416182022242628"),BigInteger.Parse("24681012141618202224262830"),BigInteger.Parse("2468101214161820222426283032") };
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
public class A019520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019520Inst Instance=new A019520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019519
{
public static readonly BigInteger[] Value={ 1L,13L,135L,1357L,13579L,1357911L,135791113L,13579111315L,1357911131517L,135791113151719L,13579111315171921L,1357911131517192123L,BigInteger.Parse("135791113151719212325"),BigInteger.Parse("13579111315171921232527"),BigInteger.Parse("1357911131517192123252729"),BigInteger.Parse("135791113151719212325272931") };
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
public class A019519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019519Inst Instance=new A019519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019518
{
public static readonly BigInteger[] Value={ 2L,23L,235L,2357L,235711L,23571113L,2357111317L,235711131719L,23571113171923L,2357111317192329L,235711131719232931L,BigInteger.Parse("23571113171923293137"),BigInteger.Parse("2357111317192329313741"),BigInteger.Parse("235711131719232931374143"),BigInteger.Parse("23571113171923293137414347") };
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
public class A019518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019518Inst Instance=new A019518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019501
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,7L,28L,84L,210L,462L,924L,1758L,3444L,7602L,19278L,52458L,142044L,368130L,905136L,2130198L,4895919L,11280885L,26685540L,65491062L,165584034L,423910572L,1080774261L,2717940687L,6731334225L,16494155097L,40308269022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019501Inst : IEnumerable<long>
{
public static readonly long[] Value=A019501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019501.Bytes);
public long this[int i]=>Value[i];

public static A019501Inst Instance=new A019501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019500
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,6L,21L,56L,126L,252L,492L,1062L,2667L,7252L,19509L,49824L,121019L,286974L,687384L,1702308L,4357383L,11322408L,29307458L,74897808L,189349041L,477491356L,1211349276L,3103673406L,8017385416L,20780391882L,53812468392L,138999941172L,358502419242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019500Inst : IEnumerable<long>
{
public static readonly long[] Value=A019500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019500.Bytes);
public long this[int i]=>Value[i];

public static A019500Inst Instance=new A019500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019499
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,15L,35L,70L,146L,360L,980L,2620L,6620L,16276L,40740L,105820L,280780L,743700L,1950756L,5101470L,13429110L,35693650L,95433290L,255434106L,683340050L,1829832350L,4913953750L,13239959100L,35758234300L,96702404700L,261768987260L,709479051420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019499Inst : IEnumerable<long>
{
public static readonly long[] Value=A019499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019499.Bytes);
public long this[int i]=>Value[i];

public static A019499Inst Instance=new A019499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019498
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,10L,20L,47L,128L,340L,868L,2275L,6188L,16922L,46112L,126613L,351568L,981622L,2747876L,7723250L,21811856L,61828886L,175752728L,500984606L,1432111244L,4104175970L,11787811340L,33926475162L,97837209036L,282662156478L,818022923184L,2371103693427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019498Inst : IEnumerable<long>
{
public static readonly long[] Value=A019498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019498.Bytes);
public long this[int i]=>Value[i];

public static A019498Inst Instance=new A019498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019497
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,16L,42L,114L,322L,918L,2673L,7875L,23457L,70551L,213846L,652794L,2004864L,6190612L,19207416L,59850384L,187217679L,587689947L,1850692506L,5845013538L,18509607753L,58759391013L,186958014766L,596108115402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019497Inst : IEnumerable<long>
{
public static readonly long[] Value=A019497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019497.Bytes);
public long this[int i]=>Value[i];

public static A019497Inst Instance=new A019497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019496
{
public static readonly long[] Value={ 4L,11L,30L,81L,218L,586L,1575L,4233L,11377L,30578L,82185L,220890L,593690L,1595671L,4288713L,11526849L,30980914L,83267945L,223800714L,601513098L,1616697287L,4345225609L,11678738961L,31389151218L,84365171401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019496Inst : IEnumerable<long>
{
public static readonly long[] Value=A019496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019496.Bytes);
public long this[int i]=>Value[i];

public static A019496Inst Instance=new A019496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019495
{
public static readonly long[] Value={ 4L,11L,30L,81L,218L,586L,1575L,4233L,11376L,30572L,82159L,220793L,593356L,1594576L,4285239L,11516085L,30948148L,83169572L,223508615L,600653577L,1614187084L,4337941272L,11657715927L,31328764525L,84192434676L,226257439900L,608040726071L,1634039193249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019495Inst : IEnumerable<long>
{
public static readonly long[] Value=A019495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019495.Bytes);
public long this[int i]=>Value[i];

public static A019495Inst Instance=new A019495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019494
{
public static readonly long[] Value={ 4L,10L,24L,57L,135L,319L,753L,1777L,4193L,9893L,23341L,55069L,129925L,306533L,723205L,1706261L,4025589L,9497589L,22407701L,52866581L,124728341L,294272085L,694277333L,1638011349L,3864566869L,9117688405L,21511399509L,50751932757L,119739242325L,282501283669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019494Inst : IEnumerable<long>
{
public static readonly long[] Value=A019494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019494.Bytes);
public long this[int i]=>Value[i];

public static A019494Inst Instance=new A019494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019493
{
public static readonly long[] Value={ 4L,9L,20L,44L,96L,209L,455L,990L,2154L,4686L,10194L,22175L,48236L,104922L,228220L,496402L,1079712L,2348431L,5107921L,11109837L,24164007L,52556739L,114310581L,248624146L,540753403L,1176127722L,2558050589L,5563694894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019493Inst : IEnumerable<long>
{
public static readonly long[] Value=A019493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019493.Bytes);
public long this[int i]=>Value[i];

public static A019493Inst Instance=new A019493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019492
{
public static readonly long[] Value={ 4L,9L,20L,44L,96L,209L,455L,990L,2154L,4686L,10194L,22176L,48241L,104942L,228287L,496607L,1080300L,2350043L,5112193L,11120867L,24191904L,52626132L,114480851L,249037213L,541745915L,1178493097L,2563648273L,5576861234L,12131688091L,26390804748L,57409535261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019492Inst : IEnumerable<long>
{
public static readonly long[] Value=A019492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019492.Bytes);
public long this[int i]=>Value[i];

public static A019492Inst Instance=new A019492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019491
{
public static readonly long[] Value={ 10L,20L,27L,28L,29L,34L,38L,44L,45L,46L,51L,52L,53L,54L,60L,61L,62L,69L,70L,74L,77L,78L,79L,81L,82L,87L,88L,92L,93L,94L,95L,101L,102L,103L,104L,105L,106L,110L,111L,112L,113L,114L,115L,116L,117L,118L,120L,122L,124L,125L,126L,127L,130L,138L,139L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019491Inst : IEnumerable<long>
{
public static readonly long[] Value=A019491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019491.Bytes);
public long this[int i]=>Value[i];

public static A019491Inst Instance=new A019491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019490
{
public static readonly long[] Value={ 1L,22L,340L,4600L,58576L,724192L,8822080L,106672000L,1284971776L,15449370112L,185571742720L,2227940915200L,26741787774976L,320940501164032L,3851520569589760L,46219655242547200L,554644317650354176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019490Inst : IEnumerable<long>
{
public static readonly long[] Value=A019490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019490.Bytes);
public long this[int i]=>Value[i];

public static A019490Inst Instance=new A019490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019489
{
public static readonly long[] Value={ 3L,7L,16L,36L,80L,177L,391L,863L,1904L,4200L,9264L,20433L,45067L,99399L,219232L,483532L,1066464L,2352161L,5187855L,11442175L,25236512L,55660880L,122763936L,270764385L,597189651L,1317143239L,2905050864L,6407291380L,14131726000L,31168502865L,68744297111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019489Inst : IEnumerable<long>
{
public static readonly long[] Value=A019489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019489.Bytes);
public long this[int i]=>Value[i];

public static A019489Inst Instance=new A019489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019488
{
public static readonly long[] Value={ 1L,21L,307L,3897L,46243L,529953L,5961259L,66380889L,735097555L,8115781905L,89452902331L,985061928201L,10842178002787L,119303005894977L,1312567620466123L,14439652232597433L,158844629298359539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019488Inst : IEnumerable<long>
{
public static readonly long[] Value=A019488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019488.Bytes);
public long this[int i]=>Value[i];

public static A019488Inst Instance=new A019488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019487
{
public static readonly long[] Value={ 2L,6L,17L,48L,135L,379L,1064L,2987L,8385L,23538L,66075L,185483L,520680L,1461631L,4103029L,11517850L,32332423L,90762215L,254783864L,715218523L,2007731289L,5636018642L,15821193955L,44412588755L,124673147016L,349977202919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019487Inst : IEnumerable<long>
{
public static readonly long[] Value=A019487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019487.Bytes);
public long this[int i]=>Value[i];

public static A019487Inst Instance=new A019487Inst();

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