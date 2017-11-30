using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A110241
{
public static readonly long[] Value={ 1L,2L,28L,152L,1456L,10592L,88768L,693632L,5614336L,44652032L,358263808L,2861914112L,22912086016L,183229571072L,1466104987648L,11727766126592L,93826423914496L,750594211315712L,6004822409740288L,48038304399491072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110241Inst : IEnumerable<long>
{
public static readonly long[] Value=A110241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110241.Bytes);
public long this[int i]=>Value[i];

public static A110241Inst Instance=new A110241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110242
{
public static readonly long[] Value={ 1L,1L,1L,-1L,-1L,1L,-1L,-1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,0L,-1L,1L,-1L,-1L,0L,-1L,1L,0L,1L,-1L,-1L,-1L,1L,0L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,-1L,-1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,0L,1L,1L,1L,-1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110242Inst : IEnumerable<long>
{
public static readonly long[] Value=A110242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110242.Bytes);
public long this[int i]=>Value[i];

public static A110242Inst Instance=new A110242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110243
{
public static readonly long[] Value={ 1L,2L,-1L,-1L,5L,1L,-1L,-1L,1L,7L,-1L,-1L,1L,1L,-1L,-1L,17L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,21L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,25L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,43L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,65L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,55L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110243Inst : IEnumerable<long>
{
public static readonly long[] Value=A110243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110243.Bytes);
public long this[int i]=>Value[i];

public static A110243Inst Instance=new A110243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110244
{
public static readonly long[] Value={ 1L,1L,0L,-2L,1L,2L,2L,-2L,1L,-1L,2L,-3L,1L,6L,0L,-4L,1L,-1L,5L,-2L,1L,-3L,2L,-1L,1L,11L,5L,-4L,1L,-1L,8L,-4L,1L,-3L,2L,-5L,1L,-1L,1L,-5L,1L,14L,8L,-3L,1L,-5L,5L,-3L,1L,-1L,-1L,-8L,1L,-3L,8L,-4L,1L,-3L,5L,-3L,1L,28L,5L,-2L,1L,-5L,14L,-3L,1L,-3L,8L,-5L,1L,-3L,-1L,-8L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110244Inst : IEnumerable<long>
{
public static readonly long[] Value=A110244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110244.Bytes);
public long this[int i]=>Value[i];

public static A110244Inst Instance=new A110244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110245
{
public static readonly long[] Value={ 1L,-1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,-3L,-1L,-1L,1L,0L,-3L,0L,-1L,1L,1L,0L,5L,1L,2L,-1L,0L,1L,0L,-7L,0L,-4L,2L,1L,-1L,1L,0L,5L,3L,1L,-1L,0L,0L,1L,1L,0L,3L,0L,2L,-2L,-1L,0L,-1L,0L,1L,0L,-13L,1L,-8L,5L,3L,-2L,2L,0L,-1L,1L,0L,-19L,-4L,-8L,8L,4L,-1L,1L,-1L,-2L,1L,1L,0L,-11L,-1L,-4L,3L,1L,-2L,0L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110245Inst : IEnumerable<long>
{
public static readonly long[] Value=A110245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110245.Bytes);
public long this[int i]=>Value[i];

public static A110245Inst Instance=new A110245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110246
{
public static readonly long[] Value={ 0L,1L,1L,1L,-3L,-3L,5L,-7L,5L,3L,-13L,-19L,-11L,-15L,-3L,37L,21L,99L,-27L,-63L,-13L,105L,-45L,67L,79L,-171L,-487L,-315L,-5L,929L,-55L,-15L,-1959L,-275L,1707L,1511L,-939L,3601L,4347L,-723L,4149L,5199L,77L,-3557L,-1937L,1175L,18697L,16705L,25613L,-57679L,-84349L,50321L,-211485L,-79177L,250103L,-466875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110246Inst : IEnumerable<long>
{
public static readonly long[] Value=A110246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110246.Bytes);
public long this[int i]=>Value[i];

public static A110246Inst Instance=new A110246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110247
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,-1L,1L,0L,1L,-1L,0L,1L,0L,1L,1L,-1L,1L,1L,0L,1L,1L,-1L,1L,-1L,1L,0L,1L,-1L,0L,1L,0L,0L,1L,0L,1L,-1L,1L,1L,-1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,-1L,0L,1L,0L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,0L,1L,-1L,-1L,1L,0L,-1L,-1L,1L,1L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110247Inst : IEnumerable<long>
{
public static readonly long[] Value=A110247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110247.Bytes);
public long this[int i]=>Value[i];

public static A110247Inst Instance=new A110247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110248
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,2L,2L,4L,3L,4L,3L,0L,1L,6L,3L,4L,6L,2L,4L,8L,3L,0L,5L,1L,6L,6L,4L,4L,9L,6L,2L,8L,3L,8L,7L,4L,2L,8L,5L,1L,9L,4L,6L,12L,6L,4L,8L,4L,0L,14L,5L,8L,9L,6L,8L,8L,6L,4L,10L,1L,6L,2L,5L,12L,15L,4L,2L,8L,9L,8L,10L,8L,0L,14L,7L,0L,12L,6L,10L,16L,3L,8L,11L,0L,6L,14L,2L,4L,15L,10L,8L,16L,6L,4L,13L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110248Inst : IEnumerable<long>
{
public static readonly long[] Value=A110248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110248.Bytes);
public long this[int i]=>Value[i];

public static A110248Inst Instance=new A110248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110249
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,0L,1L,2L,2L,0L,2L,3L,5L,0L,3L,3L,2L,0L,1L,4L,4L,0L,0L,5L,11L,0L,3L,4L,2L,0L,3L,2L,4L,0L,4L,7L,2L,0L,4L,5L,14L,0L,2L,6L,6L,0L,2L,8L,2L,0L,7L,5L,4L,0L,3L,8L,4L,0L,2L,10L,28L,0L,1L,5L,6L,0L,2L,2L,4L,0L,4L,10L,4L,0L,7L,7L,0L,0L,3L,10L,8L,0L,4L,11L,39L,0L,7L,2L,2L,0L,5L,8L,8L,0L,2L,13L,2L,0L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110249Inst : IEnumerable<long>
{
public static readonly long[] Value=A110249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110249.Bytes);
public long this[int i]=>Value[i];

public static A110249Inst Instance=new A110249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110250
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,-2L,1L,1L,0L,-2L,1L,0L,1L,0L,0L,-1L,1L,-1L,1L,0L,0L,-2L,2L,-2L,1L,1L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,2L,0L,-2L,1L,0L,-1L,-1L,1L,0L,6L,-4L,-2L,-2L,0L,0L,0L,1L,1L,0L,4L,-1L,-3L,1L,-1L,-1L,-1L,1L,0L,1L,0L,-14L,3L,11L,-3L,3L,3L,1L,-3L,-1L,-1L,1L,0L,-24L,6L,18L,-6L,4L,5L,3L,-5L,-2L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110250Inst : IEnumerable<long>
{
public static readonly long[] Value=A110250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110250.Bytes);
public long this[int i]=>Value[i];

public static A110250Inst Instance=new A110250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110251
{
public static readonly long[] Value={ 1L,10L,110L,910L,9910L,109110L,909110L,10009910L,110910910L,889111110L,9900110110L,111108908910L,901089008910L,10089889910110L,109110889111110L,889091091110910L,10090010109909910L,110010900901009110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110251Inst : IEnumerable<long>
{
public static readonly long[] Value=A110251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110251.Bytes);
public long this[int i]=>Value[i];

public static A110251Inst Instance=new A110251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110252
{
public static readonly long[] Value={ 1L,11L,89L,989L,11111L,89911L,1008989L,10900889L,89108911L,1011011011L,10990909889L,91109889089L,989010989011L,10890899089111L,91011088899089L,1001009008989989L,11111111111111111L,88909110109088911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110252Inst : IEnumerable<long>
{
public static readonly long[] Value=A110252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110252.Bytes);
public long this[int i]=>Value[i];

public static A110252Inst Instance=new A110252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110253
{
public static readonly long[] Value={ 2L,21L,199L,1899L,21021L,199021L,1918099L,20910799L,200019821L,1900122121L,20891019999L,202218797999L,1890099997921L,20980788999221L,200121978010199L,1890100100100899L,21201121221021021L,198920011010098021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110253Inst : IEnumerable<long>
{
public static readonly long[] Value=A110253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110253.Bytes);
public long this[int i]=>Value[i];

public static A110253Inst Instance=new A110253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110254
{
public static readonly long[] Value={ 1L,2L,5L,7L,17L,21L,25L,43L,65L,55L,81L,111L,97L,157L,169L,121L,257L,273L,217L,343L,321L,253L,441L,507L,385L,501L,625L,487L,673L,813L,481L,931L,1025L,661L,1089L,841L,865L,1333L,1369L,937L,1281L,1641L,1009L,1807L,1761L,1081L,2025L,2163L,1537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110254Inst : IEnumerable<long>
{
public static readonly long[] Value=A110254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110254.Bytes);
public long this[int i]=>Value[i];

public static A110254Inst Instance=new A110254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110255
{
public static readonly long[] Value={ 1L,3L,5L,28L,81L,704L,325L,768L,20825L,311296L,83349L,1507328L,1334025L,3145728L,5337189L,130023424L,1366504425L,7516192768L,5466528925L,12884901888L,87470372561L,2954937499648L,349899121845L,12919261626368L,22394407746529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110255Inst : IEnumerable<long>
{
public static readonly long[] Value=A110255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110255.Bytes);
public long this[int i]=>Value[i];

public static A110255Inst Instance=new A110255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110256
{
public static readonly long[] Value={ 1L,1L,4L,9L,64L,225L,256L,245L,16384L,99225L,65536L,480249L,1048576L,1002001L,4194304L,41409225L,1073741824L,2393453205L,4294967296L,4102737925L,68719476736L,940839860961L,274877906944L,4113258565689L,17592186044416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110256Inst : IEnumerable<long>
{
public static readonly long[] Value=A110256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110256.Bytes);
public long this[int i]=>Value[i];

public static A110256Inst Instance=new A110256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110257
{
public static readonly long[] Value={ 1L,5L,81L,325L,20825L,83349L,1334025L,5337189L,1366504425L,5466528925L,87470372561L,349899121845L,22394407746529L,89580335298125L,1433319858545625L,5733391194015525L,5871086572691471625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110257Inst : IEnumerable<long>
{
public static readonly long[] Value=A110257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110257.Bytes);
public long this[int i]=>Value[i];

public static A110257Inst Instance=new A110257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110258
{
public static readonly long[] Value={ 1L,4L,64L,256L,16384L,65536L,1048576L,4194304L,1073741824L,4294967296L,68719476736L,274877906944L,17592186044416L,70368744177664L,1125899906842624L,4503599627370496L,4611686018427387904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110258Inst : IEnumerable<long>
{
public static readonly long[] Value=A110258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110258.Bytes);
public long this[int i]=>Value[i];

public static A110258Inst Instance=new A110258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110259
{
public static readonly BigInteger[] Value={ 3L,28L,704L,768L,311296L,1507328L,3145728L,130023424L,7516192768L,12884901888L,2954937499648L,12919261626368L,52776558133248L,774056185954304L,66428094503714816L,31525197391593472L,BigInteger.Parse("308982963234634989568") };
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
public class A110259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110259Inst Instance=new A110259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110260
{
public static readonly BigInteger[] Value={ 1L,9L,225L,245L,99225L,480249L,1002001L,41409225L,2393453205L,4102737925L,940839860961L,4113258565689L,16802526820625L,246430431820125L,21147754404155625L,10036045423404225L,BigInteger.Parse("98363281194784809225") };
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
public class A110260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110260Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110260.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110260Inst Instance=new A110260Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110261
{
public static readonly long[] Value={ 1L,3L,3L,6L,6L,9L,9L,10L,12L,13L,13L,16L,16L,17L,17L,20L,20L,21L,21L,24L,24L,25L,25L,26L,28L,29L,29L,30L,30L,33L,33L,34L,34L,35L,34L,38L,38L,39L,39L,40L,40L,43L,43L,44L,45L,44L,44L,45L,48L,48L,50L,50L,50L,51L,51L,54L,55L,54L,54L,55L,55L,56L,57L,60L,60L,61L,61L,62L,62L,61L,61L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110261Inst : IEnumerable<long>
{
public static readonly long[] Value=A110261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110261.Bytes);
public long this[int i]=>Value[i];

public static A110261Inst Instance=new A110261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110262
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,9L,10L,12L,14L,16L,18L,20L,22L,24L,25L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,45L,49L,51L,54L,56L,57L,62L,63L,64L,66L,68L,72L,74L,75L,80L,81L,86L,87L,90L,92L,96L,98L,99L,100L,102L,104L,110L,111L,115L,120L,121L,122L,123L,128L,132L,134L,135L,140L,141L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110262Inst : IEnumerable<long>
{
public static readonly long[] Value=A110262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110262.Bytes);
public long this[int i]=>Value[i];

public static A110262Inst Instance=new A110262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110263
{
public static readonly long[] Value={ 1L,3L,6L,9L,10L,12L,13L,16L,17L,20L,21L,24L,25L,26L,28L,29L,30L,33L,34L,35L,38L,39L,40L,43L,44L,45L,48L,50L,51L,54L,55L,56L,57L,60L,61L,62L,65L,66L,68L,69L,72L,73L,75L,78L,79L,80L,81L,83L,84L,85L,87L,90L,92L,93L,94L,97L,98L,99L,101L,104L,105L,106L,107L,108L,110L,111L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110263Inst : IEnumerable<long>
{
public static readonly long[] Value=A110263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110263.Bytes);
public long this[int i]=>Value[i];

public static A110263Inst Instance=new A110263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110264
{
public static readonly long[] Value={ 35L,46L,58L,70L,76L,82L,94L,106L,118L,125L,129L,142L,143L,153L,154L,166L,177L,178L,189L,190L,201L,202L,213L,214L,226L,237L,238L,249L,250L,261L,262L,265L,274L,275L,282L,285L,286L,294L,297L,298L,309L,310L,321L,322L,323L,330L,334L,335L,345L,346L,354L,357L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110264Inst : IEnumerable<long>
{
public static readonly long[] Value=A110264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110264.Bytes);
public long this[int i]=>Value[i];

public static A110264Inst Instance=new A110264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110265
{
public static readonly long[] Value={ 5L,3L,7L,5L,10L,7L,7L,9L,9L,9L,11L,11L,12L,11L,14L,14L,14L,14L,17L,16L,17L,17L,17L,19L,20L,20L,20L,20L,23L,23L,23L,23L,24L,17L,26L,26L,27L,27L,27L,27L,30L,30L,31L,32L,23L,23L,23L,34L,25L,36L,35L,35L,35L,35L,38L,40L,29L,29L,29L,29L,29L,29L,43L,43L,43L,43L,32L,33L,32L,32L,35L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110265Inst : IEnumerable<long>
{
public static readonly long[] Value=A110265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110265.Bytes);
public long this[int i]=>Value[i];

public static A110265Inst Instance=new A110265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110266
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,3L,4L,5L,6L,6L,7L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110266Inst : IEnumerable<long>
{
public static readonly long[] Value=A110266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110266.Bytes);
public long this[int i]=>Value[i];

public static A110266Inst Instance=new A110266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110267
{
public static readonly long[] Value={ 1L,4L,7L,13L,17L,26L,31L,43L,50L,62L,73L,87L,99L,118L,131L,153L,168L,187L,207L,231L,252L,275L,298L,326L,352L,379L,405L,438L,468L,502L,533L,572L,598L,637L,666L,712L,744L,788L,826L,871L,918L,959L,1004L,1053L,1091L,1146L,1188L,1239L,1283L,1336L,1379L,1438L,1490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110267Inst : IEnumerable<long>
{
public static readonly long[] Value=A110267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110267.Bytes);
public long this[int i]=>Value[i];

public static A110267Inst Instance=new A110267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110268
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,5L,3L,1L,1L,3L,5L,1L,3L,1L,1L,1L,1L,1L,11L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,11L,1L,1L,1L,1L,7L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,11L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,11L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,25L,1L,1L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110268Inst : IEnumerable<long>
{
public static readonly long[] Value=A110268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110268.Bytes);
public long this[int i]=>Value[i];

public static A110268Inst Instance=new A110268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110269
{
public static readonly long[] Value={ 0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,3L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110269Inst : IEnumerable<long>
{
public static readonly long[] Value=A110269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110269.Bytes);
public long this[int i]=>Value[i];

public static A110269Inst Instance=new A110269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110270
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110270Inst : IEnumerable<long>
{
public static readonly long[] Value=A110270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110270.Bytes);
public long this[int i]=>Value[i];

public static A110270Inst Instance=new A110270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110271
{
public static readonly long[] Value={ 1L,-2L,1L,5L,-4L,1L,-16L,15L,-6L,1L,60L,-60L,29L,-8L,1L,-248L,256L,-136L,47L,-10L,1L,1092L,-1148L,644L,-252L,69L,-12L,1L,-5024L,5344L,-3104L,1312L,-416L,95L,-14L,1L,23868L,-25596L,15228L,-6780L,2364L,-636L,125L,-16L,1L,-116200L,125360L,-75896L,35072L,-13064L,3920L,-920L,159L,-18L,1L,576708L,-625020L,383460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110271Inst : IEnumerable<long>
{
public static readonly long[] Value=A110271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110271.Bytes);
public long this[int i]=>Value[i];

public static A110271Inst Instance=new A110271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110272
{
public static readonly long[] Value={ 0L,1L,8L,125L,1728L,24389L,343000L,4826809L,67917312L,955671625L,13447314152L,189218084021L,2662500456000L,37464224551181L,527161643971768L,7417727240640625L,104375343011770368L,1468672529408250769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110272Inst : IEnumerable<long>
{
public static readonly long[] Value=A110272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110272.Bytes);
public long this[int i]=>Value[i];

public static A110272Inst Instance=new A110272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110273
{
public static readonly long[] Value={ 1L,9L,133L,1853L,26117L,367389L,5169809L,72744121L,1023588937L,14402985777L,202665398173L,2851718540021L,40126725007181L,564625868522949L,7944888884612393L,111793070252410993L,1573047872420021137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110273Inst : IEnumerable<long>
{
public static readonly long[] Value=A110273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110273.Bytes);
public long this[int i]=>Value[i];

public static A110273Inst Instance=new A110273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110274
{
public static readonly long[] Value={ 16L,135L,1010L,7528L,56183L,419346L,3130024L,23362807L,174382354L,1301607592L,9715331319L,72516220178L,541268436136L,4040082608375L,30155587122450L,225084366546088L,1680052583878903L,12540083204846866L,93600455303259304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110274Inst : IEnumerable<long>
{
public static readonly long[] Value=A110274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110274.Bytes);
public long this[int i]=>Value[i];

public static A110274Inst Instance=new A110274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110275
{
public static readonly long[] Value={ 48L,345L,2558L,19096L,142537L,1063902L,7941080L,59273033L,442419934L,3302267352L,24648459081L,183978603230L,1373234989528L,10249965503305L,76506784068318L,571054410533336L,4262408147993417L,31815047541813982L,237470747742538200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110275Inst : IEnumerable<long>
{
public static readonly long[] Value=A110275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110275.Bytes);
public long this[int i]=>Value[i];

public static A110275Inst Instance=new A110275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110276
{
public static readonly long[] Value={ 1L,4L,16L,66L,280L,1218L,5422L,24666L,114540L,542278L,2614178L,12814102L,63772982L,321754290L,1643263134L,8483485886L,44214343344L,232362906298L,1230090777342L,6553657204178L,35113127086114L,189062666857686L,1022459506515674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110276Inst : IEnumerable<long>
{
public static readonly long[] Value=A110276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110276.Bytes);
public long this[int i]=>Value[i];

public static A110276Inst Instance=new A110276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110277
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,14L,16L,17L,24L,28L,32L,37L,38L,42L,44L,64L,72L,92L,98L,101L,110L,128L,134L,152L,170L,172L,180L,186L,192L,197L,206L,248L,252L,256L,257L,284L,374L,398L,401L,410L,428L,434L,474L,480L,496L,512L,577L,590L,604L,616L,632L,638L,677L,752L,760L,864L,884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110277Inst : IEnumerable<long>
{
public static readonly long[] Value=A110277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110277.Bytes);
public long this[int i]=>Value[i];

public static A110277Inst Instance=new A110277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110278
{
public static readonly long[] Value={ 1L,4L,5L,16L,37L,256L,65536L,80656L,3459600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110278Inst : IEnumerable<long>
{
public static readonly long[] Value=A110278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110278.Bytes);
public long this[int i]=>Value[i];

public static A110278Inst Instance=new A110278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110279
{
public static readonly long[] Value={ 0L,-1L,-3L,-5L,-6L,-5L,-2L,0L,9L,8L,5L,3L,-6L,-9L,-17L,-13L,-7L,-4L,10L,8L,13L,13L,5L,1L,-10L,-14L,-16L,-13L,-9L,-3L,11L,12L,15L,11L,8L,-7L,-10L,-16L,-27L,-10L,-14L,5L,12L,14L,27L,12L,11L,-9L,-16L,-22L,-28L,-11L,-15L,9L,19L,17L,30L,12L,14L,-8L,-23L,-25L,-36L,-20L,-18L,6L,23L,29L,38L,24L,18L,-8L,-27L,-37L,-44L,-32L,-22L,6L,27L,41L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110279Inst : IEnumerable<long>
{
public static readonly long[] Value=A110279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110279.Bytes);
public long this[int i]=>Value[i];

public static A110279Inst Instance=new A110279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110280
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,-2L,-3L,-3L,-2L,4L,5L,11L,10L,7L,4L,-6L,-7L,-13L,-10L,-3L,-1L,12L,12L,17L,15L,8L,3L,-7L,-10L,-14L,-11L,-4L,1L,13L,14L,20L,11L,11L,-4L,-11L,-13L,-24L,-7L,-11L,8L,16L,19L,29L,13L,14L,-7L,-13L,-18L,-26L,-8L,-9L,11L,22L,22L,35L,15L,15L,-7L,-20L,-24L,-35L,-17L,-13L,11L,26L,34L,43L,27L,19L,-7L,-24L,-36L,-43L,-29L,-17L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110280Inst : IEnumerable<long>
{
public static readonly long[] Value=A110280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110280.Bytes);
public long this[int i]=>Value[i];

public static A110280Inst Instance=new A110280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110281
{
public static readonly long[] Value={ 0L,-1L,-1L,-1L,0L,1L,2L,2L,1L,0L,-5L,-5L,-6L,-5L,-1L,1L,7L,6L,6L,4L,-3L,-3L,-9L,-9L,-8L,-6L,0L,3L,7L,7L,7L,4L,-3L,-5L,-10L,-9L,-10L,-2L,-1L,6L,12L,7L,12L,0L,-1L,-8L,-15L,-11L,-14L,-2L,0L,9L,13L,9L,13L,-1L,-4L,-10L,-18L,-12L,-17L,-3L,2L,10L,18L,14L,17L,3L,-4L,-14L,-22L,-20L,-21L,-7L,2L,14L,22L,22L,21L,7L,-4L,-18L,-26L,-28L,-25L,-11L,2L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110281Inst : IEnumerable<long>
{
public static readonly long[] Value=A110281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110281.Bytes);
public long this[int i]=>Value[i];

public static A110281Inst Instance=new A110281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110282
{
public static readonly long[] Value={ 2L,0L,-2L,-5L,-6L,-5L,-1L,3L,8L,15L,5L,1L,-7L,-16L,-17L,-20L,-4L,2L,12L,22L,12L,17L,4L,-6L,-14L,-24L,-20L,-16L,-5L,2L,15L,25L,17L,15L,2L,-7L,-25L,-19L,-29L,-21L,3L,1L,31L,21L,28L,23L,-3L,-8L,-36L,-28L,-34L,-18L,3L,5L,40L,28L,28L,23L,-6L,-6L,-43L,-38L,-38L,-29L,0L,8L,45L,44L,44L,31L,2L,-14L,-51L,-54L,-54L,-37L,-8L,16L,53L,60L,60L,39L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110282Inst : IEnumerable<long>
{
public static readonly long[] Value=A110282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110282.Bytes);
public long this[int i]=>Value[i];

public static A110282Inst Instance=new A110282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110283
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-2L,-2L,-1L,1L,2L,6L,5L,1L,0L,-5L,-6L,-8L,-5L,1L,2L,9L,7L,6L,6L,-1L,-3L,-8L,-9L,-7L,-4L,0L,3L,10L,9L,7L,4L,0L,-7L,-9L,-8L,-13L,-1L,0L,7L,13L,8L,14L,3L,-1L,-9L,-14L,-11L,-13L,0L,0L,10L,17L,9L,14L,2L,-1L,-9L,-19L,-13L,-16L,-4L,1L,11L,21L,17L,18L,6L,-1L,-13L,-23L,-21L,-20L,-8L,1L,15L,25L,25L,22L,10L,-1L,-17L,-27L,-29L,-24L,-12L,1L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110283Inst : IEnumerable<long>
{
public static readonly long[] Value=A110283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110283.Bytes);
public long this[int i]=>Value[i];

public static A110283Inst Instance=new A110283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110284
{
public static readonly long[] Value={ 9L,25L,49L,121L,169L,289L,625L,841L,961L,1225L,1681L,1849L,2401L,3025L,4489L,5929L,6889L,10201L,11881L,13225L,14161L,15625L,17689L,19321L,20449L,22801L,24025L,24649L,25921L,32041L,32761L,39601L,41209L,44521L,48841L,49729L,55225L,57121L,69169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110284Inst : IEnumerable<long>
{
public static readonly long[] Value=A110284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110284.Bytes);
public long this[int i]=>Value[i];

public static A110284Inst Instance=new A110284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110285
{
public static readonly long[] Value={ 168L,760L,2154L,9172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110285Inst : IEnumerable<long>
{
public static readonly long[] Value=A110285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110285.Bytes);
public long this[int i]=>Value[i];

public static A110285Inst Instance=new A110285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110286
{
public static readonly long[] Value={ 15L,30L,60L,120L,240L,480L,960L,1920L,3840L,7680L,15360L,30720L,61440L,122880L,245760L,491520L,983040L,1966080L,3932160L,7864320L,15728640L,31457280L,62914560L,125829120L,251658240L,503316480L,1006632960L,2013265920L,4026531840L,8053063680L,16106127360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110286Inst : IEnumerable<long>
{
public static readonly long[] Value=A110286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110286.Bytes);
public long this[int i]=>Value[i];

public static A110286Inst Instance=new A110286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110287
{
public static readonly long[] Value={ 17L,34L,68L,136L,272L,544L,1088L,2176L,4352L,8704L,17408L,34816L,69632L,139264L,278528L,557056L,1114112L,2228224L,4456448L,8912896L,17825792L,35651584L,71303168L,142606336L,285212672L,570425344L,1140850688L,2281701376L,4563402752L,9126805504L,18253611008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110287Inst : IEnumerable<long>
{
public static readonly long[] Value=A110287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110287.Bytes);
public long this[int i]=>Value[i];

public static A110287Inst Instance=new A110287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110288
{
public static readonly long[] Value={ 19L,38L,76L,152L,304L,608L,1216L,2432L,4864L,9728L,19456L,38912L,77824L,155648L,311296L,622592L,1245184L,2490368L,4980736L,9961472L,19922944L,39845888L,79691776L,159383552L,318767104L,637534208L,1275068416L,2550136832L,5100273664L,10200547328L,20401094656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110288Inst : IEnumerable<long>
{
public static readonly long[] Value=A110288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110288.Bytes);
public long this[int i]=>Value[i];

public static A110288Inst Instance=new A110288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110289
{
public static readonly long[] Value={ 320L,432L,448L,704L,720L,832L,972L,1088L,1216L,1472L,1584L,1680L,1856L,1984L,2000L,2268L,2352L,2368L,2448L,2624L,2700L,2752L,3008L,3120L,3312L,3392L,3645L,3696L,3776L,3904L,3920L,4176L,4212L,4288L,4368L,4400L,4544L,4672L,5056L,5103L,5200L,5312L,5488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110289Inst : IEnumerable<long>
{
public static readonly long[] Value=A110289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110289.Bytes);
public long this[int i]=>Value[i];

public static A110289Inst Instance=new A110289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110290
{
public static readonly long[] Value={ 128L,192L,288L,480L,648L,672L,800L,1008L,1056L,1080L,1120L,1200L,1248L,1458L,1512L,1568L,1620L,1632L,1760L,1800L,1824L,1872L,2080L,2187L,2208L,2376L,2430L,2464L,2520L,2640L,2720L,2736L,2784L,2800L,2808L,2912L,2976L,3000L,3040L,3402L,3528L,3552L,3564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110290Inst : IEnumerable<long>
{
public static readonly long[] Value=A110290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110290.Bytes);
public long this[int i]=>Value[i];

public static A110290Inst Instance=new A110290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110291
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,3L,5L,1L,1L,3L,9L,7L,1L,1L,3L,9L,19L,9L,1L,1L,3L,9L,27L,33L,11L,1L,1L,3L,17L,1L,1L,3L,9L,27L,81L,243L,473L,379L,129L,19L,1L,1L,3L,9L,27L,81L,243L,665L,939L,577L,163L,21L,1L,1L,3L,9L,27L,81L,243L,729L,1611L,1697L,835L,201L,23L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110291Inst : IEnumerable<long>
{
public static readonly long[] Value=A110291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110291.Bytes);
public long this[int i]=>Value[i];

public static A110291Inst Instance=new A110291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110292
{
public static readonly long[] Value={ 1L,-1L,1L,2L,-3L,1L,-8L,12L,-5L,1L,40L,-60L,26L,-7L,1L,-224L,336L,-148L,44L,-9L,1L,1344L,-2016L,896L,-280L,66L,-11L,1L,-8448L,12672L,-5664L,1824L,-464L,92L,-13L,1L,54912L,-82368L,36960L,-12144L,3240L,-708L,122L,-15L,1L,-366080L,549120L,-247104L,82368L,-22704L,5280L,-1020L,156L,-17L,1L,2489344L,-3734016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110292Inst : IEnumerable<long>
{
public static readonly long[] Value=A110292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110292.Bytes);
public long this[int i]=>Value[i];

public static A110292Inst Instance=new A110292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110293
{
public static readonly long[] Value={ 1L,7L,13L,97L,181L,1351L,2521L,18817L,35113L,262087L,489061L,3650401L,6811741L,50843527L,94875313L,708158977L,1321442641L,9863382151L,18405321661L,137379191137L,256353060613L,1913445293767L,3570537526921L,26650854921601L,49731172316281L,371198523608647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110293Inst : IEnumerable<long>
{
public static readonly long[] Value=A110293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110293.Bytes);
public long this[int i]=>Value[i];

public static A110293Inst Instance=new A110293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110294
{
public static readonly long[] Value={ 1L,-8L,15L,-112L,209L,-1560L,2911L,-21728L,40545L,-302632L,564719L,-4215120L,7865521L,-58709048L,109552575L,-817711552L,1525870529L,-11389252680L,21252634831L,-158631825968L,296011017105L,-2209456310872L,4122901604639L,-30773756526240L,57424611447841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110294Inst : IEnumerable<long>
{
public static readonly long[] Value=A110294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110294.Bytes);
public long this[int i]=>Value[i];

public static A110294Inst Instance=new A110294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110295
{
public static readonly long[] Value={ 2L,6L,20L,56L,176L,416L,1088L,2432L,5888L,14848L,31744L,75776L,167936L,352256L,770048L,1736704L,3866624L,7995392L,17563648L,37224448L,76546048L,165675008L,348127232L,746586112L,1627389952L,3388997632L,6912212992L,14361296896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110295Inst : IEnumerable<long>
{
public static readonly long[] Value=A110295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110295.Bytes);
public long this[int i]=>Value[i];

public static A110295Inst Instance=new A110295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110296
{
public static readonly long[] Value={ 384L,640L,864L,1408L,1664L,2016L,2176L,2400L,2432L,2944L,3240L,3712L,3744L,3968L,4374L,4536L,4736L,5248L,5280L,5472L,5504L,5600L,6016L,6240L,6784L,7128L,7392L,7552L,7808L,7840L,8424L,8576L,8800L,8928L,9088L,9120L,9344L,10112L,10400L,10584L,10624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110296Inst : IEnumerable<long>
{
public static readonly long[] Value=A110296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110296.Bytes);
public long this[int i]=>Value[i];

public static A110296Inst Instance=new A110296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110297
{
public static readonly long[] Value={ 256L,576L,896L,960L,1296L,1344L,1440L,1600L,1944L,2112L,2160L,2240L,2496L,2916L,3024L,3136L,3168L,3264L,3360L,3520L,3600L,3648L,4000L,4160L,4416L,4704L,4752L,4860L,4896L,4928L,5040L,5400L,5440L,5568L,5616L,5824L,5952L,6000L,6080L,6561L,6624L,6804L,7056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110297Inst : IEnumerable<long>
{
public static readonly long[] Value=A110297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110297.Bytes);
public long this[int i]=>Value[i];

public static A110297Inst Instance=new A110297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110298
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,2L,0L,1L,1L,4L,0L,1L,1L,2L,8L,0L,2L,1L,2L,4L,17L,0L,4L,2L,2L,4L,8L,37L,0L,8L,4L,4L,4L,8L,17L,82L,0L,17L,8L,8L,8L,8L,17L,37L,185L,0L,37L,17L,16L,16L,16L,17L,37L,82L,423L,0L,82L,37L,34L,32L,32L,34L,37L,82L,185L,978L,0L,185L,82L,74L,68L,64L,68L,74L,82L,185L,423L,2283L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110298Inst : IEnumerable<long>
{
public static readonly long[] Value=A110298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110298.Bytes);
public long this[int i]=>Value[i];

public static A110298Inst Instance=new A110298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110299
{
public static readonly long[] Value={ 2L,7L,19L,45L,101L,215L,447L,913L,1849L,3727L,7485L,15007L,30055L,60153L,120353L,240759L,481577L,963215L,1926497L,3853065L,7706203L,15412485L,30825053L,61650195L,123300487L,246601075L,493202253L,986404613L,1972809335L,3945618783L,7891237693L,15782475517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110299Inst : IEnumerable<long>
{
public static readonly long[] Value=A110299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110299.Bytes);
public long this[int i]=>Value[i];

public static A110299Inst Instance=new A110299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110300
{
public static readonly long[] Value={ 3L,4L,5L,6L,10L,14L,22L,34L,38L,58L,86L,94L,122L,142L,158L,178L,202L,214L,218L,302L,382L,394L,446L,502L,542L,634L,698L,718L,842L,878L,922L,1042L,1138L,1202L,1262L,1318L,1346L,1382L,1402L,1438L,1622L,1642L,1762L,1822L,1838L,1894L,1942L,1982L,2018L,2102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110300Inst : IEnumerable<long>
{
public static readonly long[] Value=A110300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110300.Bytes);
public long this[int i]=>Value[i];

public static A110300Inst Instance=new A110300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110301
{
public static readonly long[] Value={ 0L,1L,2L,21L,22L,32L,321L,322L,332L,432L,4321L,4322L,4332L,4432L,5432L,54321L,54322L,54332L,54432L,55432L,65432L,654321L,654322L,654332L,654432L,655432L,665432L,765432L,7654321L,7654322L,7654332L,7654432L,7655432L,7665432L,7765432L,8765432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110301Inst : IEnumerable<long>
{
public static readonly long[] Value=A110301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110301.Bytes);
public long this[int i]=>Value[i];

public static A110301Inst Instance=new A110301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110302
{
public static readonly long[] Value={ 1L,1L,1L,4L,14L,103L,2926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110302Inst : IEnumerable<long>
{
public static readonly long[] Value=A110302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110302.Bytes);
public long this[int i]=>Value[i];

public static A110302Inst Instance=new A110302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110303
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110303Inst : IEnumerable<long>
{
public static readonly long[] Value=A110303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110303.Bytes);
public long this[int i]=>Value[i];

public static A110303Inst Instance=new A110303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110304
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,121L,12L,52L,14L,30L,16L,34L,18L,38L,0L,21L,418L,23L,72L,25L,52L,27L,56L,29L,30L,341L,32L,165L,34L,70L,36L,74L,38L,78L,0L,41L,210L,43L,616L,45L,92L,47L,96L,49L,50L,561L,52L,212L,54L,165L,56L,456L,58L,236L,0L,61L,434L,63L,256L,65L,858L,67L,272L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110304Inst : IEnumerable<long>
{
public static readonly long[] Value=A110304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110304.Bytes);
public long this[int i]=>Value[i];

public static A110304Inst Instance=new A110304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110305
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,1L,4L,1L,2L,1L,2L,1L,2L,0L,1L,19L,1L,3L,1L,2L,1L,2L,1L,1L,11L,1L,5L,1L,2L,1L,2L,1L,2L,0L,1L,5L,1L,14L,1L,2L,1L,2L,1L,1L,11L,1L,4L,1L,3L,1L,8L,1L,4L,0L,1L,7L,1L,4L,1L,13L,1L,4L,1L,1L,11L,1L,4L,1L,6L,1L,5L,1L,6L,0L,1L,5L,1L,3L,1L,3L,1L,7L,1L,1L,12L,1L,18L,1L,23L,1L,34L,1L,111L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110305Inst : IEnumerable<long>
{
public static readonly long[] Value=A110305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110305.Bytes);
public long this[int i]=>Value[i];

public static A110305Inst Instance=new A110305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110306
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,128L,3079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110306Inst : IEnumerable<long>
{
public static readonly long[] Value=A110306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110306.Bytes);
public long this[int i]=>Value[i];

public static A110306Inst Instance=new A110306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110307
{
public static readonly long[] Value={ 1L,-4L,17L,-80L,384L,-1842L,8827L,-42292L,202631L,-970862L,4651680L,-22287540L,106786021L,-511642564L,2451426797L,-11745491420L,56276030304L,-269634660102L,1291897270207L,-6189851690932L,29657361184451L,-142096954231322L,680827409972160L,-3262040095629480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110307Inst : IEnumerable<long>
{
public static readonly long[] Value=A110307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110307.Bytes);
public long this[int i]=>Value[i];

public static A110307Inst Instance=new A110307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110308
{
public static readonly long[] Value={ 0L,-2L,11L,-52L,247L,-1182L,5664L,-27140L,130037L,-623044L,2985181L,-14302860L,68529120L,-328342742L,1573184591L,-7537580212L,36114716467L,-173036002122L,829065294144L,-3972290468600L,19032387048857L,-91189644775684L,436915836829561L,-2093389539372120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110308Inst : IEnumerable<long>
{
public static readonly long[] Value=A110308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110308.Bytes);
public long this[int i]=>Value[i];

public static A110308Inst Instance=new A110308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110309
{
public static readonly long[] Value={ 1L,-3L,12L,-57L,275L,-1320L,6325L,-30303L,145188L,-695637L,3332999L,-15969360L,76513801L,-366599643L,1756484412L,-8415822417L,40322627675L,-193197315960L,925663952125L,-4435122444663L,21249948271188L,-101814618911277L,487823146285199L,-2337301112514720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110309Inst : IEnumerable<long>
{
public static readonly long[] Value=A110309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110309.Bytes);
public long this[int i]=>Value[i];

public static A110309Inst Instance=new A110309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110310
{
public static readonly long[] Value={ 1L,-7L,36L,-173L,827L,-3960L,18973L,-90907L,435564L,-2086913L,9998999L,-47908080L,229541401L,-1099798927L,5269453236L,-25247467253L,120967883027L,-579591947880L,2776991856373L,-13305367333987L,63749844813564L,-305443856733833L,1463469438855599L,-7011903337544160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110310Inst : IEnumerable<long>
{
public static readonly long[] Value=A110310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110310.Bytes);
public long this[int i]=>Value[i];

public static A110310Inst Instance=new A110310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110311
{
public static readonly long[] Value={ 1L,-6L,29L,-138L,660L,-3162L,15151L,-72594L,347819L,-1666500L,7984680L,-38256900L,183299821L,-878242206L,4207911209L,-20161313838L,96598657980L,-462831976062L,2217561222331L,-10624974135594L,50907309455639L,-243911573142600L,1168650556257360L,-5599341208144200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110311Inst : IEnumerable<long>
{
public static readonly long[] Value=A110311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110311.Bytes);
public long this[int i]=>Value[i];

public static A110311Inst Instance=new A110311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110312
{
public static readonly long[] Value={ 4L,1L,6L,5L,7L,5L,9L,7L,10L,6L,11L,10L,11L,11L,12L,12L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110312Inst : IEnumerable<long>
{
public static readonly long[] Value=A110312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110312.Bytes);
public long this[int i]=>Value[i];

public static A110312Inst Instance=new A110312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110313
{
public static readonly BigInteger[] Value={ 1L,2L,7L,34L,221L,1786L,17347L,196442L,2542969L,37030546L,599172671L,10664259442L,207061905877L,4355429249354L,98661276360571L,2394559287772906L,61991654930903537L,1705178260099590562L,BigInteger.Parse("49662655090649112439") };
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
public class A110313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110313Inst Instance=new A110313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110314
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,-2L,1L,0L,-6L,-3L,1L,0L,0L,-12L,-4L,1L,0L,0L,0L,-20L,-5L,1L,0L,0L,0L,0L,-30L,-6L,1L,0L,0L,0L,0L,0L,-42L,-7L,1L,0L,0L,0L,0L,0L,0L,-56L,-8L,1L,0L,0L,0L,0L,0L,0L,0L,-72L,-9L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-90L,-10L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-110L,-11L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-132L,-12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110314Inst : IEnumerable<long>
{
public static readonly long[] Value=A110314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110314.Bytes);
public long this[int i]=>Value[i];

public static A110314Inst Instance=new A110314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110315
{
public static readonly long[] Value={ 1L,-1L,-1L,-2L,-5L,-3L,-11L,-4L,-19L,-5L,-29L,-6L,-41L,-7L,-55L,-8L,-71L,-9L,-89L,-10L,-109L,-11L,-131L,-12L,-155L,-13L,-181L,-14L,-209L,-15L,-239L,-16L,-271L,-17L,-305L,-18L,-341L,-19L,-379L,-20L,-419L,-21L,-461L,-22L,-505L,-23L,-551L,-24L,-599L,-25L,-649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110315Inst : IEnumerable<long>
{
public static readonly long[] Value=A110315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110315.Bytes);
public long this[int i]=>Value[i];

public static A110315Inst Instance=new A110315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110316
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,4L,1L,8L,16L,32L,16L,32L,16L,8L,1L,16L,64L,256L,256L,1024L,1024L,1024L,256L,1024L,1024L,1024L,256L,256L,64L,16L,1L,32L,256L,2048L,4096L,32768L,65536L,131072L,65536L,524288L,1048576L,2097152L,1048576L,2097152L,1048576L,524288L,65536L,524288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110316Inst : IEnumerable<long>
{
public static readonly long[] Value=A110316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110316.Bytes);
public long this[int i]=>Value[i];

public static A110316Inst Instance=new A110316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110317
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,7L,1L,12L,5L,21L,15L,1L,37L,37L,8L,65L,84L,35L,1L,114L,182L,115L,12L,200L,381L,323L,73L,1L,351L,777L,825L,313L,17L,616L,1554L,1977L,1087L,138L,1L,1081L,3062L,4524L,3291L,754L,23L,1897L,5962L,9999L,9063L,3209L,241L,1L,3329L,11496L,21515L,23300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110317Inst : IEnumerable<long>
{
public static readonly long[] Value=A110317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110317.Bytes);
public long this[int i]=>Value[i];

public static A110317Inst Instance=new A110317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110318
{
public static readonly long[] Value={ 1L,5L,17L,53L,157L,448L,1250L,3434L,9326L,25114L,67196L,178895L,474398L,1254072L,3306738L,8701193L,22857026L,59958380L,157098360L,411214120L,1075491286L,2810892598L,7342205478L,19168694232L,50023584613L,130497101659L,340325126923L,887307420361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110318Inst : IEnumerable<long>
{
public static readonly long[] Value=A110318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110318.Bytes);
public long this[int i]=>Value[i];

public static A110318Inst Instance=new A110318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110319
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,3L,1L,0L,0L,1L,6L,1L,0L,0L,0L,6L,10L,1L,0L,0L,0L,1L,20L,15L,1L,0L,0L,0L,0L,10L,50L,21L,1L,0L,0L,0L,0L,1L,50L,105L,28L,1L,0L,0L,0L,0L,0L,15L,175L,196L,36L,1L,0L,0L,0L,0L,0L,1L,105L,490L,336L,45L,1L,0L,0L,0L,0L,0L,0L,21L,490L,1176L,540L,55L,1L,0L,0L,0L,0L,0L,0L,1L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110319Inst : IEnumerable<long>
{
public static readonly long[] Value=A110319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110319.Bytes);
public long this[int i]=>Value[i];

public static A110319Inst Instance=new A110319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110320
{
public static readonly long[] Value={ 1L,2L,5L,13L,32L,80L,201L,505L,1273L,3217L,8146L,20668L,52531L,133726L,340909L,870213L,2223958L,5689807L,14571335L,37350585L,95821071L,246015677L,632088930L,1625119218L,4180845277L,10762096850L,27718352411L,71426753423L,184146711578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110320Inst : IEnumerable<long>
{
public static readonly long[] Value=A110320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110320.Bytes);
public long this[int i]=>Value[i];

public static A110320Inst Instance=new A110320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110321
{
public static readonly long[] Value={ 1L,1L,1L,6L,2L,1L,30L,18L,3L,1L,264L,120L,36L,4L,1L,2520L,1320L,300L,60L,5L,1L,30960L,15120L,3960L,600L,90L,6L,1L,428400L,216720L,52920L,9240L,1050L,126L,7L,1L,6894720L,3427200L,866880L,141120L,18480L,1680L,168L,8L,1L,123742080L,62052480L,15422400L,2600640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110321Inst : IEnumerable<long>
{
public static readonly long[] Value=A110321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110321.Bytes);
public long this[int i]=>Value[i];

public static A110321Inst Instance=new A110321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110322
{
public static readonly BigInteger[] Value={ 1L,2L,9L,52L,425L,4206L,50737L,708464L,11350257L,204171130L,4084757561L,89849981772L,2156575777369L,56068679418662L,1569955094823585L,47098171778191816L,1507149193966389857L,BigInteger.Parse("51242941744764975474") };
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
public class A110322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110322Inst Instance=new A110322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110323
{
public static readonly BigInteger[] Value={ 1L,1L,7L,32L,283L,2643L,32317L,443824L,7115461L,127222805L,2541399091L,55739417376L,1335729425647L,34666455314407L,969419191792633L,29046504524166368L,928541094344685577L,BigInteger.Parse("31540972026299055849") };
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
public class A110323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110323Inst Instance=new A110323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110324
{
public static readonly long[] Value={ 1L,-1L,1L,-4L,-2L,1L,0L,-12L,-3L,1L,0L,0L,-24L,-4L,1L,0L,0L,0L,-40L,-5L,1L,0L,0L,0L,0L,-60L,-6L,1L,0L,0L,0L,0L,0L,-84L,-7L,1L,0L,0L,0L,0L,0L,0L,-112L,-8L,1L,0L,0L,0L,0L,0L,0L,0L,-144L,-9L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-180L,-10L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-220L,-11L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-264L,-12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110324Inst : IEnumerable<long>
{
public static readonly long[] Value=A110324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110324.Bytes);
public long this[int i]=>Value[i];

public static A110324Inst Instance=new A110324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110325
{
public static readonly long[] Value={ 1L,0L,-5L,-14L,-27L,-44L,-65L,-90L,-119L,-152L,-189L,-230L,-275L,-324L,-377L,-434L,-495L,-560L,-629L,-702L,-779L,-860L,-945L,-1034L,-1127L,-1224L,-1325L,-1430L,-1539L,-1652L,-1769L,-1890L,-2015L,-2144L,-2277L,-2414L,-2555L,-2700L,-2849L,-3002L,-3159L,-3320L,-3485L,-3654L,-3827L,-4004L,-4185L,-4370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110325Inst : IEnumerable<long>
{
public static readonly long[] Value=A110325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110325.Bytes);
public long this[int i]=>Value[i];

public static A110325Inst Instance=new A110325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110326
{
public static readonly long[] Value={ 1L,-1L,-3L,-2L,-11L,-3L,-23L,-4L,-39L,-5L,-59L,-6L,-83L,-7L,-111L,-8L,-143L,-9L,-179L,-10L,-219L,-11L,-263L,-12L,-311L,-13L,-363L,-14L,-419L,-15L,-479L,-16L,-543L,-17L,-611L,-18L,-683L,-19L,-759L,-20L,-839L,-21L,-923L,-22L,-1011L,-23L,-1103L,-24L,-1199L,-25L,-1299L,-26L,-1403L,-27L,-1511L,-28L,-1623L,-29L,-1739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110326Inst : IEnumerable<long>
{
public static readonly long[] Value=A110326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110326.Bytes);
public long this[int i]=>Value[i];

public static A110326Inst Instance=new A110326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110327
{
public static readonly long[] Value={ 1L,2L,1L,10L,4L,1L,72L,30L,6L,1L,696L,288L,60L,8L,1L,8400L,3480L,720L,100L,10L,1L,121680L,50400L,10440L,1440L,150L,12L,1L,2056320L,851760L,176400L,24360L,2520L,210L,14L,1L,39715200L,16450560L,3407040L,470400L,48720L,4032L,280L,16L,1L,862928640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110327Inst : IEnumerable<long>
{
public static readonly long[] Value=A110327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110327.Bytes);
public long this[int i]=>Value[i];

public static A110327Inst Instance=new A110327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110328
{
public static readonly BigInteger[] Value={ 1L,3L,15L,109L,1053L,12711L,184123L,3111585L,60096249L,1305766603L,31523994471L,837162204693L,24253060182805L,761176868685039L,25727009276451603L,931657420717406281L,BigInteger.Parse("35987519689305385713"),BigInteger.Parse("1476986487871517622675") };
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
public class A110328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110328Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110328.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110328Inst Instance=new A110328Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110329
{
public static readonly BigInteger[] Value={ 1L,2L,11L,76L,727L,8694L,125221L,2107448L,40577501L,879557050L,21193809151L,561950634852L,16258832340451L,509717865337646L,17211690137010377L,622780718533047664L,BigInteger.Parse("24039198822957409081"),BigInteger.Parse("985985136339748008498") };
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
public class A110329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110329Inst Instance=new A110329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110330
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,-4L,1L,0L,-6L,-6L,1L,0L,0L,-12L,-8L,1L,0L,0L,0L,-20L,-10L,1L,0L,0L,0L,0L,-30L,-12L,1L,0L,0L,0L,0L,0L,-42L,-14L,1L,0L,0L,0L,0L,0L,0L,-56L,-16L,1L,0L,0L,0L,0L,0L,0L,0L,-72L,-18L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-90L,-20L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-110L,-22L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-132L,-24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110330Inst : IEnumerable<long>
{
public static readonly long[] Value=A110330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110330.Bytes);
public long this[int i]=>Value[i];

public static A110330Inst Instance=new A110330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110331
{
public static readonly long[] Value={ 1L,-1L,-5L,-11L,-19L,-29L,-41L,-55L,-71L,-89L,-109L,-131L,-155L,-181L,-209L,-239L,-271L,-305L,-341L,-379L,-419L,-461L,-505L,-551L,-599L,-649L,-701L,-755L,-811L,-869L,-929L,-991L,-1055L,-1121L,-1189L,-1259L,-1331L,-1405L,-1481L,-1559L,-1639L,-1721L,-1805L,-1891L,-1979L,-2069L,-2161L,-2255L,-2351L,-2449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110331Inst : IEnumerable<long>
{
public static readonly long[] Value=A110331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110331.Bytes);
public long this[int i]=>Value[i];

public static A110331Inst Instance=new A110331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110332
{
public static readonly long[] Value={ 1L,-2L,-1L,-4L,-5L,-6L,-11L,-8L,-19L,-10L,-29L,-12L,-41L,-14L,-55L,-16L,-71L,-18L,-89L,-20L,-109L,-22L,-131L,-24L,-155L,-26L,-181L,-28L,-209L,-30L,-239L,-32L,-271L,-34L,-305L,-36L,-341L,-38L,-379L,-40L,-419L,-42L,-461L,-44L,-505L,-46L,-551L,-48L,-599L,-50L,-649L,-52L,-701L,-54L,-755L,-56L,-811L,-58L,-869L,-60L,-929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110332Inst : IEnumerable<long>
{
public static readonly long[] Value=A110332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110332.Bytes);
public long this[int i]=>Value[i];

public static A110332Inst Instance=new A110332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110333
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,16L,1L,33L,4L,70L,12L,152L,32L,1L,336L,82L,5L,754L,206L,18L,1714L,512L,56L,1L,3940L,1264L,163L,6L,9145L,3109L,456L,25L,21406L,7634L,1243L,88L,1L,50478L,18737L,3326L,284L,7L,119814L,46006L,8781L,868L,33L,286045L,113062L,22955L,2556L,129L,1L,686456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110333Inst : IEnumerable<long>
{
public static readonly long[] Value=A110333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110333.Bytes);
public long this[int i]=>Value[i];

public static A110333Inst Instance=new A110333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110334
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,16L,33L,70L,152L,336L,754L,1714L,3940L,9145L,21406L,50478L,119814L,286045L,686456L,1655053L,4007131L,9738812L,23750895L,58106547L,142569506L,350738607L,864980279L,2138034715L,5295877279L,13143521437L,32679745904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110334Inst : IEnumerable<long>
{
public static readonly long[] Value=A110334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110334.Bytes);
public long this[int i]=>Value[i];

public static A110334Inst Instance=new A110334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110335
{
public static readonly long[] Value={ 1L,4L,12L,34L,92L,242L,627L,1608L,4096L,10388L,26269L,66304L,167161L,421162L,1060816L,2671908L,6730941L,16961430L,42758695L,107843080L,272136858L,687106696L,1735849310L,4387895300L,11098372185L,28088028612L,71128006458L,180224822694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110335Inst : IEnumerable<long>
{
public static readonly long[] Value=A110335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110335.Bytes);
public long this[int i]=>Value[i];

public static A110335Inst Instance=new A110335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110336
{
public static readonly BigInteger[] Value={ 3L,5L,7L,13441L,11L,13L,929901772801L,17L,19L,7380172801L,23L,20530298881L,21841L,29L,31L,59535361L,7591472824321L,37L,63841L,41L,43L,BigInteger.Parse("32611799187695769164215700373287163408678912000001"),47L };
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
public class A110336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110336Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110336.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110336Inst Instance=new A110336Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110337
{
public static readonly BigInteger[] Value={ 3L,5L,7L,101L,11L,13L,257L,17L,19L,9454727L,23L,677L,801011L,29L,31L,42737L,1297L,37L,1601L,41L,43L,5285387L,47L,410006013351009077L,148667L,53L,3137L,56284059197L,59L,61L,BigInteger.Parse("1529270318745462748663049625086428127"),4357L,67L,26822027L,71L,73L };
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
public class A110337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110337Inst Instance=new A110337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110338
{
public static readonly long[] Value={ 1L,3L,2L,5L,7L,9L,11L,4L,6L,8L,13L,15L,17L,19L,21L,23L,10L,12L,14L,16L,18L,25L,27L,29L,31L,33L,35L,37L,39L,20L,22L,24L,26L,28L,30L,32L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,34L,36L,38L,40L,42L,44L,46L,48L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110338Inst : IEnumerable<long>
{
public static readonly long[] Value=A110338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110338.Bytes);
public long this[int i]=>Value[i];

public static A110338Inst Instance=new A110338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110339
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,15L,8L,16L,28L,32L,5L,25L,35L,55L,65L,6L,12L,18L,24L,36L,48L,7L,49L,77L,91L,119L,133L,161L,40L,64L,80L,88L,104L,128L,136L,152L,27L,63L,81L,99L,117L,153L,171L,189L,207L,10L,20L,50L,70L,100L,130L,140L,160L,170L,190L,11L,121L,143L,187L,209L,253L,319L,341L,407L,451L,473L,60L,72L,84L,96L,108L,120L,144L,168L,180L,192L,204L,216L,13L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110339Inst : IEnumerable<long>
{
public static readonly long[] Value=A110339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110339.Bytes);
public long this[int i]=>Value[i];

public static A110339Inst Instance=new A110339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110340
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,6L,7L,40L,27L,10L,11L,60L,13L,14L,45L,176L,17L,54L,19L,200L,21L,22L,23L,264L,125L,26L,243L,280L,29L,30L,31L,544L,33L,34L,245L,612L,37L,38L,39L,1000L,41L,42L,43L,1012L,315L,46L,47L,1056L,343L,250L,51L,1040L,53L,702L,605L,1624L,57L,58L,59L,1320L,61L,62L,1323L,2752L,845L,66L,67L,1700L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110340Inst : IEnumerable<long>
{
public static readonly long[] Value=A110340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110340.Bytes);
public long this[int i]=>Value[i];

public static A110340Inst Instance=new A110340Inst();

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