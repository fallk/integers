using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A016570
{
public static readonly long[] Value={ 3L,1L,2L,1L,125L,3L,1L,1L,1L,1L,6L,1L,2L,1L,2L,1L,2L,1L,5L,20L,1L,1L,1L,2L,3L,6L,2L,1L,8L,19L,1L,62L,1L,1L,6L,2L,3L,6L,2L,6L,1L,1L,1L,1L,1L,5L,6L,7L,8L,3L,2L,8L,8L,1L,6L,3L,4L,1L,11L,1L,1L,1L,1L,3L,7L,4L,1L,2L,1L,4L,1L,2L,7L,1L,14L,22L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016570Inst : IEnumerable<long>
{
public static readonly long[] Value=A016570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016570.Bytes);
public long this[int i]=>Value[i];

public static A016570Inst Instance=new A016570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016569
{
public static readonly long[] Value={ 3L,1L,2L,1L,1L,1L,4L,1L,1L,2L,11L,2L,5L,1L,3L,30L,1L,4L,1L,13L,2L,2L,2L,1L,1L,3L,4L,14L,13L,2L,1L,1L,1L,1L,1L,10L,1L,2L,1L,23L,1L,2L,2L,17L,1L,1L,3L,52L,1L,32L,1L,1L,1L,3L,2L,1L,2L,1L,1L,1L,8L,6L,1L,2L,1L,6L,1L,15L,2L,2L,1L,6L,3L,7L,35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016569Inst : IEnumerable<long>
{
public static readonly long[] Value=A016569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016569.Bytes);
public long this[int i]=>Value[i];

public static A016569Inst Instance=new A016569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016568
{
public static readonly long[] Value={ 3L,1L,2L,2L,1L,6L,1L,50L,1L,1L,1L,45L,1L,3L,4L,1L,1L,5L,27L,1L,10L,1L,1L,1L,1L,18L,1L,27L,7L,1L,1L,1L,3L,1L,49L,2L,9L,1L,20L,1L,5L,2L,1L,1L,2L,7L,3L,1L,36L,1L,2L,6L,1L,3L,26L,1L,54L,18L,1L,9L,4L,3L,1L,1L,16L,1L,1L,4L,1L,5L,4L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016568Inst : IEnumerable<long>
{
public static readonly long[] Value=A016568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016568.Bytes);
public long this[int i]=>Value[i];

public static A016568Inst Instance=new A016568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016567
{
public static readonly long[] Value={ 3L,1L,2L,11L,5L,355L,1L,2L,1L,4L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,8L,1L,2L,3L,2L,1L,3L,5L,4L,1L,11L,2L,3L,3L,1L,4L,2L,2L,1L,1L,15L,28L,5L,1L,2L,8L,2L,1L,6L,2L,6L,1L,13L,1L,1L,5L,8L,1L,2L,1L,5L,18L,1L,58L,2L,62L,1L,16L,5L,1L,1L,1L,1L,2L,5L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016567Inst : IEnumerable<long>
{
public static readonly long[] Value=A016567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016567.Bytes);
public long this[int i]=>Value[i];

public static A016567Inst Instance=new A016567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016566
{
public static readonly long[] Value={ 3L,1L,1L,1L,6L,3L,1L,1L,1L,5L,3L,1L,1L,96L,1L,1L,2L,2L,3L,2L,3L,2L,32L,1L,1L,1L,10L,7L,2L,8L,2L,5L,11L,1L,1L,2L,3L,1L,3L,1L,6L,5L,11L,2L,6L,3L,3L,1L,1L,3L,1L,2L,1L,1L,2L,2L,8L,3L,1L,2L,1L,1L,1L,5L,6L,1L,4L,3L,187L,1L,3L,1L,6L,1L,1L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016566Inst : IEnumerable<long>
{
public static readonly long[] Value=A016566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016566.Bytes);
public long this[int i]=>Value[i];

public static A016566Inst Instance=new A016566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016565
{
public static readonly long[] Value={ 3L,1L,1L,1L,1L,1L,23L,12L,11L,1L,15L,2L,15L,1L,1L,1L,1L,12L,1L,1L,1L,6L,2L,1L,2L,3L,1L,18L,1L,1L,3L,65L,26L,3L,3L,3L,1L,3L,101L,1L,1L,9L,1L,2L,3L,5L,1L,12L,2L,16L,1L,10L,1L,24L,5L,1L,1L,2L,3L,2L,6L,2L,10L,18L,1L,1L,2L,1L,25L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016565Inst : IEnumerable<long>
{
public static readonly long[] Value=A016565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016565.Bytes);
public long this[int i]=>Value[i];

public static A016565Inst Instance=new A016565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016564
{
public static readonly long[] Value={ 3L,1L,1L,2L,14L,2L,13L,1L,2L,2L,1L,14L,1L,106L,2L,1L,3L,5L,1L,51L,1L,1L,2L,4L,1L,13L,1L,6L,1L,1L,18L,1L,2L,1L,1L,3L,33L,3L,1L,3L,1L,3L,5L,8L,1L,126L,1L,9L,1L,1L,16L,4L,1L,2L,1L,4L,7L,1L,1L,17L,1L,1L,3L,1L,2L,6L,1L,3L,1L,2L,1L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016564Inst : IEnumerable<long>
{
public static readonly long[] Value=A016564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016564.Bytes);
public long this[int i]=>Value[i];

public static A016564Inst Instance=new A016564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016563
{
public static readonly long[] Value={ 3L,1L,1L,3L,10L,2L,11L,3L,2L,4L,1L,4L,4L,2L,32L,1L,3L,1L,50L,3L,4L,1L,1L,3L,1L,1L,1L,3L,1L,3L,2L,3L,3L,17L,1L,4L,5L,3L,5L,1L,6L,3L,1L,5L,1L,10L,2L,1L,4L,3L,1L,3L,3L,1L,3L,2L,1L,2L,9L,26L,1L,1L,20L,1L,1L,5L,1L,1L,4L,1L,2L,5L,1L,3L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016563Inst : IEnumerable<long>
{
public static readonly long[] Value=A016563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016563.Bytes);
public long this[int i]=>Value[i];

public static A016563Inst Instance=new A016563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016562
{
public static readonly long[] Value={ 3L,1L,1L,5L,1L,1L,1L,1L,10L,2L,5L,1L,7L,1L,32L,18L,2L,9L,1L,1L,1L,29L,1L,1L,2L,50L,1L,29L,1L,1L,10L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,3L,2L,3L,1L,2L,3L,1L,1L,6L,2L,4L,1L,4L,1L,10L,1L,40L,4L,2L,3L,1L,1L,12L,2L,28L,17L,1L,2L,18L,7L,1L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016562Inst : IEnumerable<long>
{
public static readonly long[] Value=A016562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016562.Bytes);
public long this[int i]=>Value[i];

public static A016562Inst Instance=new A016562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016561
{
public static readonly long[] Value={ 3L,1L,1L,21L,6L,1L,1L,21L,9L,2L,1L,1L,6L,1L,3L,102L,1L,1L,13L,1L,2L,1L,6L,1L,13L,5L,55L,1L,1L,1L,20L,1L,3L,1L,2L,8L,1L,2L,1L,1L,1L,6L,11L,2L,14L,1L,2L,1L,2L,1L,2L,4L,4L,3L,1L,4L,2L,23L,1L,1L,11L,10L,3L,2L,2L,9L,17L,5L,2L,1L,7L,3L,16L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016561Inst : IEnumerable<long>
{
public static readonly long[] Value=A016561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016561.Bytes);
public long this[int i]=>Value[i];

public static A016561Inst Instance=new A016561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016560
{
public static readonly long[] Value={ 3L,2L,12L,1L,4L,1L,3L,9L,13L,1L,1L,1L,1L,3L,1L,1L,1L,2L,2L,4L,52L,1L,1L,2L,1L,1L,2L,45L,1L,38L,60L,1L,1L,3L,100L,6L,28L,1L,3L,4L,2L,1L,91L,1L,165L,1L,5L,1L,3L,1L,1L,1L,18L,2L,1L,22L,1L,5L,5L,3L,2L,1L,1L,1L,3L,2L,4L,1L,3L,2L,1L,39L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016560Inst : IEnumerable<long>
{
public static readonly long[] Value=A016560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016560.Bytes);
public long this[int i]=>Value[i];

public static A016560Inst Instance=new A016560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016559
{
public static readonly long[] Value={ 3L,2L,4L,2L,200L,3L,2L,70L,51L,4L,2L,2L,7L,2L,12L,2L,1L,1L,1L,1L,1L,1L,1L,23L,80L,2L,2L,1L,7L,1L,2L,47L,1L,1L,1L,12L,1L,9L,2L,4L,1L,8L,1L,1L,1L,6L,1L,2L,2L,2L,4L,1L,11L,3L,7L,3L,1L,2L,1L,7L,1L,2L,1L,1L,2L,5L,1L,74L,1L,41L,22L,2L,21L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016559Inst : IEnumerable<long>
{
public static readonly long[] Value=A016559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016559.Bytes);
public long this[int i]=>Value[i];

public static A016559Inst Instance=new A016559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016558
{
public static readonly long[] Value={ 3L,2L,2L,1L,1L,5L,1L,30L,5L,1L,1L,1L,41L,1L,3L,1L,6L,8L,2L,1L,4L,2L,5L,3L,3L,376L,4L,2L,21L,4L,1L,1L,13L,13L,1L,1L,1L,15L,1L,1L,11L,2L,2L,3L,1L,5L,3L,1L,1L,4L,1L,1L,1L,3L,14L,1L,1L,1L,1L,3L,1L,4L,1L,1L,1L,2L,1L,5L,1L,1L,1L,1L,18L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016558Inst : IEnumerable<long>
{
public static readonly long[] Value=A016558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016558.Bytes);
public long this[int i]=>Value[i];

public static A016558Inst Instance=new A016558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016557
{
public static readonly long[] Value={ 3L,2L,1L,1L,1L,1L,25L,1L,2L,48L,1L,1L,1L,1L,1L,1L,18L,1L,60L,1L,2L,44L,1L,1L,8L,1L,1L,2L,2L,2L,1L,1L,1L,13L,157L,2L,6L,1L,1L,1L,8L,10L,4L,53L,1L,1L,1L,3L,2L,1L,2L,10L,6L,2L,1L,2L,1L,1L,1L,15L,1L,2L,2L,13L,2L,8L,2L,2L,1L,1L,2L,10L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016557Inst : IEnumerable<long>
{
public static readonly long[] Value=A016557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016557.Bytes);
public long this[int i]=>Value[i];

public static A016557Inst Instance=new A016557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016556
{
public static readonly long[] Value={ 3L,2L,1L,6L,25L,1L,10L,1L,4L,2L,2L,3L,1L,1L,2L,2L,1L,40L,1L,2L,3L,1L,1L,2L,1L,1L,1L,4L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,5L,1L,1L,4L,1L,73L,1L,6L,1L,6L,2L,1L,11L,1L,13L,74L,1L,1L,14L,1L,5L,67L,1L,52L,1L,2L,1L,2L,3L,2L,3L,1L,2L,1L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016556Inst : IEnumerable<long>
{
public static readonly long[] Value=A016556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016556.Bytes);
public long this[int i]=>Value[i];

public static A016556Inst Instance=new A016556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016555
{
public static readonly long[] Value={ 3L,3L,5L,2L,7L,1L,2L,1L,2L,2L,1L,3L,1L,2L,10L,1L,23L,1L,1L,1L,1L,3L,1L,1L,1L,1L,4L,5L,2L,8L,2L,4L,1L,37L,2L,2L,2L,1L,2L,74L,1L,11L,2L,1L,3L,1L,6L,3L,1L,6L,136L,1L,3L,9L,1L,2L,6L,6L,12L,1L,1L,2L,1L,1L,1L,29L,1L,4L,3L,5L,2L,1L,6L,6L,1L,11L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016555Inst : IEnumerable<long>
{
public static readonly long[] Value=A016555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016555.Bytes);
public long this[int i]=>Value[i];

public static A016555Inst Instance=new A016555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016554
{
public static readonly long[] Value={ 3L,3L,1L,1L,1L,1L,4L,3L,1L,3L,1L,1L,2L,3L,4L,1L,4L,3L,1L,1L,4L,2L,1L,5L,6L,3L,4L,1L,7L,1L,1L,6L,2L,2L,19L,1L,4L,2L,13L,1L,3L,1L,51L,8L,1L,7L,3L,1L,64L,1L,1L,1L,1L,2L,1L,1L,2L,1L,10L,1L,1L,4L,1L,1L,1L,3L,15L,2L,1L,24L,38L,4L,1L,3L,4L,1L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016554Inst : IEnumerable<long>
{
public static readonly long[] Value=A016554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016554.Bytes);
public long this[int i]=>Value[i];

public static A016554Inst Instance=new A016554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016553
{
public static readonly long[] Value={ 3L,4L,5L,3L,1L,2L,3L,3L,1L,5L,2L,16L,1L,90L,4L,1L,1L,2L,4L,18L,4L,2L,3L,3L,2L,1L,3L,1L,4L,1L,1L,2L,22L,138L,4L,14L,1L,1L,1L,6L,2L,1L,1L,8L,7L,1L,2L,1L,22L,2L,16L,3L,1L,1L,73L,1L,1L,1L,1L,1L,2L,9L,8L,2L,19L,3L,2L,1L,2L,1L,1L,63L,2L,2L,4L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016553Inst : IEnumerable<long>
{
public static readonly long[] Value=A016553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016553.Bytes);
public long this[int i]=>Value[i];

public static A016553Inst Instance=new A016553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016552
{
public static readonly long[] Value={ 3L,5L,29L,1L,17L,2L,7L,5L,1L,8L,9L,20L,1L,2L,1L,1L,1L,2L,4L,1L,4L,1L,4L,3L,1L,1L,1L,3L,1L,1L,1L,1L,5L,1L,22L,2L,2L,31L,2L,41L,1L,1L,1L,1L,2L,1L,7L,6L,3L,2L,3L,2L,1L,3L,1L,8L,1L,4L,1L,1L,1L,4L,20L,1L,1L,2L,1L,4L,1L,3L,4L,5L,1L,2L,1L,157L,1L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016552Inst : IEnumerable<long>
{
public static readonly long[] Value=A016552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016552.Bytes);
public long this[int i]=>Value[i];

public static A016552Inst Instance=new A016552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016551
{
public static readonly long[] Value={ 3L,6L,2L,1L,2L,2L,2L,2L,1L,1L,1L,2L,141L,2L,6L,19L,3L,4L,2L,3L,1L,4L,16L,1L,4L,3L,2L,6L,2L,1L,2L,12L,1L,1L,9L,18L,2L,1L,1L,12L,2L,1L,1L,2L,1L,13L,1L,3L,1L,6L,1L,3L,6L,1L,39L,2L,4L,2L,10L,2L,13L,2L,3L,2L,1L,2L,1L,4L,4L,3L,2L,3L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016551Inst : IEnumerable<long>
{
public static readonly long[] Value=A016551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016551.Bytes);
public long this[int i]=>Value[i];

public static A016551Inst Instance=new A016551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016550
{
public static readonly long[] Value={ 3L,8L,1L,4L,4L,16L,29L,1L,5L,2L,1L,54L,1L,18L,1L,1L,3L,16L,3L,1L,1L,1L,1L,24L,1L,2L,1L,2L,2L,1L,2L,1L,1L,1L,5L,8L,1L,2L,3L,7L,3L,1L,1L,12L,1L,2L,5L,1L,1L,3L,1L,4L,23L,186L,110L,20L,1L,7L,2L,121L,1L,5L,1L,1L,8L,1L,1L,1L,1L,1L,1L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016550Inst : IEnumerable<long>
{
public static readonly long[] Value=A016550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016550.Bytes);
public long this[int i]=>Value[i];

public static A016550Inst Instance=new A016550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016549
{
public static readonly long[] Value={ 3L,14L,1L,2L,3L,1L,2L,703L,1L,1L,59L,1L,1L,1L,1L,3L,12L,30L,1L,3L,1L,1L,4L,2L,8L,1L,2L,8L,2L,1L,9L,7L,12L,4L,3L,1L,31L,24L,1L,9L,3L,8L,1L,1L,1L,47L,1L,15L,1L,7L,2L,1L,1L,15L,2L,3L,9L,2L,2L,54L,33L,1L,1L,2L,1L,3L,1L,2L,4L,1L,3L,1L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016549Inst : IEnumerable<long>
{
public static readonly long[] Value=A016549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016549.Bytes);
public long this[int i]=>Value[i];

public static A016549Inst Instance=new A016549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016548
{
public static readonly long[] Value={ 3L,48L,1L,23L,1L,12L,1L,1L,19L,6L,1L,4L,15L,1440L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,5L,1L,2L,4L,1L,4L,1L,1L,4L,1L,1L,1L,26L,2L,1L,11L,4L,4L,1L,2L,1L,3L,3L,55L,26L,1L,22L,2L,1L,10L,1L,20L,5L,2L,336L,2L,1L,1L,3L,2L,1L,2L,2L,9L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016548Inst : IEnumerable<long>
{
public static readonly long[] Value=A016548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016548.Bytes);
public long this[int i]=>Value[i];

public static A016548Inst Instance=new A016548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016547
{
public static readonly long[] Value={ 2L,1L,32L,1L,4L,132L,4L,2L,1L,3L,8L,4L,9L,20L,1L,1L,1L,2L,1L,4L,4L,1L,6L,2L,1L,7L,1L,24L,3L,1L,1L,11L,2L,8L,2L,1L,23L,1L,1L,2L,1L,17L,1L,6L,34L,2L,3L,1L,39L,2L,4L,1L,10L,9L,1L,5L,1L,33L,2L,4L,1L,4L,2L,2L,1L,14L,1L,2L,2L,1L,1L,5L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016547Inst : IEnumerable<long>
{
public static readonly long[] Value=A016547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016547.Bytes);
public long this[int i]=>Value[i];

public static A016547Inst Instance=new A016547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016546
{
public static readonly long[] Value={ 2L,1L,11L,6L,4L,1L,5L,3L,3L,1L,1L,1L,3L,1L,1L,4L,2L,1L,5L,2L,2L,1L,12L,62L,2L,1L,1L,6L,5L,9L,1L,1L,1L,1L,1L,19L,1L,1L,1L,2L,1L,1L,1L,2L,8L,1L,73L,10L,1L,1L,1L,25L,1L,3L,10L,1L,1L,1L,1L,3L,2L,1L,9L,2L,3L,2L,4L,1L,11L,1L,1L,1L,3L,1L,6L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016546Inst : IEnumerable<long>
{
public static readonly long[] Value=A016546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016546.Bytes);
public long this[int i]=>Value[i];

public static A016546Inst Instance=new A016546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016545
{
public static readonly long[] Value={ 2L,1L,6L,3L,1L,8L,3L,1L,11L,3L,2L,3L,1L,1L,3L,6L,1L,950L,8L,1L,34L,1L,124L,2L,1L,2L,3L,1L,5L,1L,3L,1L,1L,5L,16L,7L,5L,2L,18L,1L,1L,11L,1L,1L,1L,4L,1L,2L,2L,4L,1L,1L,2L,12L,1L,1L,7L,1L,185L,2L,2L,38L,1L,8L,1L,710L,2L,1L,2L,1L,3L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016545Inst : IEnumerable<long>
{
public static readonly long[] Value=A016545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016545.Bytes);
public long this[int i]=>Value[i];

public static A016545Inst Instance=new A016545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016544
{
public static readonly long[] Value={ 2L,1L,4L,11L,1L,2L,2L,1L,2L,4L,2L,1L,16L,1L,1L,18L,1L,1L,5L,1L,8L,1L,6L,2L,1L,1L,20L,14L,4L,2L,3L,5L,29L,5L,4L,4L,1L,15L,2L,2L,5L,1L,4L,654L,12L,1L,1L,1L,2L,8L,1L,2L,4L,1L,2L,6L,2L,1L,1L,4L,14L,1L,3L,1L,4L,1L,84L,1L,5L,2L,3L,1L,8L,20L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016544Inst : IEnumerable<long>
{
public static readonly long[] Value=A016544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016544.Bytes);
public long this[int i]=>Value[i];

public static A016544Inst Instance=new A016544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016543
{
public static readonly long[] Value={ 2L,1L,2L,1L,6L,13L,1L,2L,67L,4L,1L,1L,2L,2L,1L,3L,4L,1L,11L,2L,1L,2L,2L,1L,3L,18L,4L,4L,1L,1L,1L,1L,4L,7L,1L,3L,2L,1L,1L,1L,3L,2L,1L,1L,3L,1L,3L,1L,1L,1L,2L,8L,30L,108L,1L,1L,1L,4L,2L,8L,903L,3L,1L,2L,2L,8L,1L,1L,1L,5L,3L,1L,1L,1L,3L,126L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016543Inst : IEnumerable<long>
{
public static readonly long[] Value=A016543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016543.Bytes);
public long this[int i]=>Value[i];

public static A016543Inst Instance=new A016543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016542
{
public static readonly long[] Value={ 2L,1L,2L,14L,1L,1L,14L,13L,1L,86L,1L,19L,1L,5L,1L,1L,1L,5L,1L,2L,1L,1L,9L,1L,16L,1L,35L,7L,1L,2L,1L,1L,8L,1L,5L,4L,3L,2L,1L,1L,1L,7L,12L,12L,3L,1L,4L,2L,1L,1L,3L,2L,1L,4L,1L,3L,7L,1L,1L,1L,1L,4L,3L,1L,22L,1L,238L,2L,13L,1L,5L,1L,7L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016542Inst : IEnumerable<long>
{
public static readonly long[] Value=A016542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016542.Bytes);
public long this[int i]=>Value[i];

public static A016542Inst Instance=new A016542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016541
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,14L,3L,1L,2L,7L,6L,1L,1L,1L,1L,1L,4L,1L,1L,1L,13L,1L,1L,1L,1L,1L,202L,1L,1L,1L,8L,1L,1L,4L,1L,1L,1L,3L,4L,1L,6L,1L,18L,17L,1L,1L,1L,2L,10L,30L,1L,1L,1L,1L,1L,3L,15L,5L,5L,5L,4L,12L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,6L,1L,12L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016541Inst : IEnumerable<long>
{
public static readonly long[] Value=A016541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016541.Bytes);
public long this[int i]=>Value[i];

public static A016541Inst Instance=new A016541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016540
{
public static readonly long[] Value={ 2L,1L,1L,9L,4L,1L,1L,1L,1L,2L,1L,1L,3L,8L,1L,31L,3L,1L,12L,1L,1L,5L,1L,4L,1L,7L,1L,4L,1L,1L,24L,111L,1L,2L,1L,1L,12L,6L,1L,4L,5L,1L,2L,3L,11L,1L,3L,1L,1L,45L,1L,1L,1L,1L,1L,2L,83L,1L,2L,2L,1L,1L,6L,1L,5L,9L,1L,4L,12L,1L,1L,4L,2L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016540Inst : IEnumerable<long>
{
public static readonly long[] Value=A016540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016540.Bytes);
public long this[int i]=>Value[i];

public static A016540Inst Instance=new A016540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016539
{
public static readonly long[] Value={ 2L,2L,3L,1L,5L,9L,4L,2L,2L,4L,1L,1L,1L,9L,1L,1L,16L,2L,6L,1L,2L,2L,1L,5L,2L,4L,1L,2L,1L,3L,3L,7L,2L,1L,4L,4L,1L,1L,4L,2L,1L,4L,1L,3L,427L,5L,5L,15L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,4L,1L,1L,1L,1L,8L,2L,1L,2L,7L,13L,15L,2L,1L,8L,4L,1L,38L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016539Inst : IEnumerable<long>
{
public static readonly long[] Value=A016539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016539.Bytes);
public long this[int i]=>Value[i];

public static A016539Inst Instance=new A016539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016538
{
public static readonly long[] Value={ 2L,2L,1L,5L,2L,30L,10L,2L,1L,1L,1L,1L,38L,1L,1L,1L,1L,6L,2L,2L,1L,26L,1L,1L,2L,2L,2L,1L,42L,2L,2L,1L,5L,2L,2L,7L,1L,1L,2L,5L,1L,1L,3L,1L,1L,1L,1L,1L,4L,1L,2L,2L,1L,1L,5L,2L,3L,1L,1L,1L,2L,9L,1L,1L,2L,1L,3L,2L,1L,1L,7L,2L,3L,2L,2L,2L,1L,21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016538Inst : IEnumerable<long>
{
public static readonly long[] Value=A016538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016538.Bytes);
public long this[int i]=>Value[i];

public static A016538Inst Instance=new A016538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016537
{
public static readonly long[] Value={ 2L,3L,1L,47L,1L,1L,1L,2L,1L,1L,4L,4L,3L,3L,3L,1L,3L,20L,2L,7L,1L,1L,1L,1L,2L,3L,3L,1L,60L,1L,15L,1L,2L,2L,4L,10L,1L,1L,1L,1L,4L,1L,29L,2L,3L,1L,1L,1L,16L,1L,3L,1L,3L,7L,1L,1L,6L,1L,2L,1L,7L,2L,2L,3L,1L,4L,1L,8L,1L,20L,1L,1L,1L,1L,6L,1L,2L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016537Inst : IEnumerable<long>
{
public static readonly long[] Value=A016537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016537.Bytes);
public long this[int i]=>Value[i];

public static A016537Inst Instance=new A016537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016536
{
public static readonly long[] Value={ 2L,7L,7L,5L,1L,9L,1L,1L,2L,11L,4L,1L,1L,3L,1L,1L,14L,1L,2L,3L,1L,4L,1L,8L,2L,1L,1L,2L,2L,1L,1L,1L,2L,6L,2L,51L,1L,1L,25L,1L,2L,18L,1L,1L,3L,3L,3L,1L,1L,2L,3L,1L,3L,8L,5L,1L,2L,6L,14L,1L,9L,3L,1L,1L,7L,2L,1L,2L,33L,1L,1L,2L,3L,2L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016536Inst : IEnumerable<long>
{
public static readonly long[] Value=A016536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016536.Bytes);
public long this[int i]=>Value[i];

public static A016536Inst Instance=new A016536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016535
{
public static readonly long[] Value={ 2L,67L,9L,1L,19L,2L,5L,28L,1L,10L,2L,4L,3L,1L,76L,1L,1L,1L,9L,3L,2L,2L,1L,1L,1L,2L,1L,1L,20L,2L,2L,1L,8L,18L,6L,2L,1L,1L,16L,1L,6L,2L,1L,16L,7L,5L,2L,1L,1L,7L,11L,5L,12L,3L,1L,8L,1L,11L,32L,2L,1L,1L,6L,1L,4020L,13L,1L,10L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016535Inst : IEnumerable<long>
{
public static readonly long[] Value=A016535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016535.Bytes);
public long this[int i]=>Value[i];

public static A016535Inst Instance=new A016535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016534
{
public static readonly long[] Value={ 1L,1L,6L,1L,4L,89L,1L,3L,1L,7L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,4L,3L,2L,365L,1L,1L,3L,2L,1L,1L,5L,1L,3L,2L,1L,1L,3L,3L,1L,2L,1L,4L,6L,20L,2L,4L,5L,2L,1L,5L,4L,1L,12L,56L,4L,7L,1L,1L,3L,10L,4L,3L,2L,1L,1L,1L,1L,5L,1L,16L,1L,5L,7L,3L,3L,7L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016534Inst : IEnumerable<long>
{
public static readonly long[] Value=A016534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016534.Bytes);
public long this[int i]=>Value[i];

public static A016534Inst Instance=new A016534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016533
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,2L,6L,6L,1L,3L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,4L,2L,1L,1L,3L,2L,73L,46L,3L,2L,3L,3L,4L,1L,3L,2L,6L,1L,1L,1L,1L,1L,8L,16L,1L,1L,2L,11L,1L,6L,1L,2L,3L,1L,16L,2L,6L,6L,1L,1L,3L,1L,1L,5L,14L,5L,1L,1L,2L,3L,4L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016533Inst : IEnumerable<long>
{
public static readonly long[] Value=A016533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016533.Bytes);
public long this[int i]=>Value[i];

public static A016533Inst Instance=new A016533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016532
{
public static readonly long[] Value={ 1L,1L,1L,60L,1L,4L,2L,1L,2L,1L,3L,3L,2L,1L,4L,2L,3L,1L,2L,8L,2L,2L,4L,1L,1L,1L,1L,3L,10L,10L,2L,1L,354L,1L,12L,521L,1L,1L,1L,3L,1L,1L,16L,1L,21L,10L,5L,1L,2L,2L,3L,2L,1L,9L,9L,1L,9L,1L,12L,1L,10L,1L,1L,4L,1L,62L,2L,1L,1L,1L,5L,8L,10L,2L,2L,1L,1L,7L,5L,1L,1L,1L,1L,22L,2L,14L,28L,1L,284L,1L,49L,1L,41L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016532Inst : IEnumerable<long>
{
public static readonly long[] Value=A016532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016532.Bytes);
public long this[int i]=>Value[i];

public static A016532Inst Instance=new A016532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016531
{
public static readonly long[] Value={ 1L,3L,1L,21L,1L,6L,1L,2L,1L,2L,13L,1L,1L,1L,1L,2L,2L,16L,5L,1L,2L,5L,1L,1L,9L,3L,4L,1L,9L,24L,1L,1L,1L,1L,8L,4L,2L,1L,1L,4L,3L,1L,1L,6L,1L,5L,12L,1L,1L,137L,26L,1L,2L,2L,2L,1L,7L,2L,9L,1L,7L,1L,1L,2L,60L,2L,1L,2L,1L,9L,6L,1L,1L,6L,3L,2L,1L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016531Inst : IEnumerable<long>
{
public static readonly long[] Value=A016531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016531.Bytes);
public long this[int i]=>Value[i];

public static A016531Inst Instance=new A016531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016530
{
public static readonly long[] Value={ 0L,1L,10L,1L,17L,1L,1L,3L,1L,48L,1L,9L,1L,1L,9L,1L,1L,2L,22L,2L,6L,2L,3L,1L,4L,3L,5L,107L,1L,3L,1L,2L,4L,4L,1L,1L,5L,3L,4L,109L,1L,4L,1L,18L,2L,1L,3L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,6L,1L,2L,6L,1L,1L,7L,1L,1L,1L,1L,79L,4L,1L,23L,1L,94L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016530Inst : IEnumerable<long>
{
public static readonly long[] Value=A016530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016530.Bytes);
public long this[int i]=>Value[i];

public static A016530Inst Instance=new A016530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016529
{
public static readonly long[] Value={ 0L,2L,2L,6L,1L,11L,2L,1L,2L,2L,1L,4L,3L,1L,1L,7L,2L,1L,1L,4L,1L,2L,1L,2L,1L,1L,10L,3L,1L,2L,1L,1L,2L,3L,1L,11L,3L,2L,31L,2L,2L,3L,1L,3L,13L,1L,1L,3L,9L,1L,2L,1L,1L,1L,1L,2L,4L,4L,1L,1L,553L,5L,3L,4L,4L,35L,5L,2L,1L,27L,3L,2L,1L,1L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016529Inst : IEnumerable<long>
{
public static readonly long[] Value=A016529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016529.Bytes);
public long this[int i]=>Value[i];

public static A016529Inst Instance=new A016529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016528
{
public static readonly long[] Value={ 4L,1L,1L,1L,1L,7L,7L,3L,6L,1L,1L,9L,1L,2L,1L,2L,1L,1L,1L,12L,1L,1L,2L,2L,11L,1L,4L,2L,2L,1L,1L,39L,1L,1L,1433L,2L,3L,1L,5L,1L,10L,1L,35L,2L,2L,6L,1L,1L,3L,6L,2L,1L,4L,3L,3L,1L,1L,3L,3L,1L,1L,1L,2L,32L,1L,1L,1L,2L,1L,1L,1L,58L,5L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016528Inst : IEnumerable<long>
{
public static readonly long[] Value=A016528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016528.Bytes);
public long this[int i]=>Value[i];

public static A016528Inst Instance=new A016528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016527
{
public static readonly long[] Value={ 4L,1L,1L,2L,7L,1L,3L,1L,10L,1L,1L,7L,1L,3L,1L,3L,1L,71L,2L,1L,1L,1L,4L,1L,3L,173L,1L,3L,6L,3L,2L,7L,2L,2L,30L,5L,2L,2L,1L,1L,11L,4L,7L,1L,6L,2L,1L,1L,4L,4L,1L,3L,4L,17L,2L,2L,25L,6L,2L,2L,1L,1L,1L,1L,13L,1L,3L,2L,10L,2L,3L,3L,117L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016527Inst : IEnumerable<long>
{
public static readonly long[] Value=A016527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016527.Bytes);
public long this[int i]=>Value[i];

public static A016527Inst Instance=new A016527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016526
{
public static readonly long[] Value={ 4L,1L,1L,2L,2L,3L,1L,4L,1L,66L,1L,1L,2L,4L,4L,3L,1L,1L,2L,1L,1L,1L,2L,52L,1L,1L,1L,1L,4L,2L,12L,1L,1L,1L,1L,1L,1L,1L,3L,3L,2L,3L,2L,1L,1L,1L,1L,2L,1L,14L,3L,1L,2L,2L,1L,1L,1L,4L,1L,1L,1L,2L,9L,4L,1L,3L,1L,18L,17L,4L,1L,3L,7L,1L,1L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016526Inst : IEnumerable<long>
{
public static readonly long[] Value=A016526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016526.Bytes);
public long this[int i]=>Value[i];

public static A016526Inst Instance=new A016526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016493
{
public static readonly long[] Value={ 4L,5L,1L,2L,1L,3L,4L,21L,22L,2L,4L,1L,2L,1L,2L,1L,1L,1L,1L,3L,22L,2L,1L,4L,4L,2L,2L,1L,1L,1L,278L,5L,1L,7L,2L,1L,1L,1L,4L,6L,22L,4L,2L,5L,1L,43L,1L,1L,8L,1L,22L,19L,2L,64L,1L,17L,2L,3L,3L,2L,1L,1L,2L,19L,5L,9L,2L,2L,2L,13L,1L,8L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016493Inst : IEnumerable<long>
{
public static readonly long[] Value=A016493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016493.Bytes);
public long this[int i]=>Value[i];

public static A016493Inst Instance=new A016493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016492
{
public static readonly long[] Value={ 4L,6L,3L,2L,2L,18L,1L,1L,1L,64L,1L,3L,1L,10L,1L,2L,1L,7L,2L,5L,3L,1L,2L,2L,3L,2L,1L,2L,1L,4L,1L,3L,3L,2L,1L,1L,1L,4L,1L,1L,7L,2L,1L,27L,2L,1L,1L,4L,4L,1L,1L,1L,4L,1L,1L,6L,20L,1L,8L,2L,2L,1L,5L,1L,11L,1L,10L,1L,5L,1L,1L,2L,5L,9L,1L,5L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016492Inst : IEnumerable<long>
{
public static readonly long[] Value=A016492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016492.Bytes);
public long this[int i]=>Value[i];

public static A016492Inst Instance=new A016492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016491
{
public static readonly long[] Value={ 4L,6L,1L,72L,1L,1L,1L,36L,4L,7L,1L,2L,5L,5L,1L,6L,2L,1L,9L,1L,4L,1L,1L,9L,2L,8L,1L,10L,1L,4L,1L,2L,1L,2L,2L,4L,6L,1L,33L,2L,8L,1L,1L,1L,1L,4L,1L,1L,12L,1L,1L,1L,1L,8L,7L,1L,2L,1L,1019L,4L,2L,6L,1604L,1L,1L,6L,3L,12L,1L,1L,7L,2L,1L,8L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016491Inst : IEnumerable<long>
{
public static readonly long[] Value=A016491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016491.Bytes);
public long this[int i]=>Value[i];

public static A016491Inst Instance=new A016491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016490
{
public static readonly long[] Value={ 4L,7L,1L,6L,2L,4L,10L,2L,1L,2L,4L,1L,7L,3L,3L,1L,43L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,3L,9L,1L,2L,6L,1L,13L,2L,1L,1L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,33L,1L,1L,9L,1L,1L,1L,9L,1L,15L,5L,6L,8L,1L,2L,185L,5L,1L,5L,2L,1L,1L,11L,4L,1L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016490Inst : IEnumerable<long>
{
public static readonly long[] Value=A016490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016490.Bytes);
public long this[int i]=>Value[i];

public static A016490Inst Instance=new A016490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016489
{
public static readonly long[] Value={ 4L,9L,51L,1L,12L,1L,1L,5L,1L,4L,1L,1L,1L,2L,1L,3L,6L,1L,2L,11L,1L,357L,2L,7L,5L,7L,2L,6L,1L,522L,1L,7L,3L,2L,2L,1L,2L,1L,3L,1L,1L,1L,1L,4L,1L,6L,4L,13L,3L,1L,4L,5L,5L,1L,1L,9L,1L,1L,21L,1L,17L,1L,6L,1L,16L,1L,11L,8L,20L,1L,2L,3L,37L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016489Inst : IEnumerable<long>
{
public static readonly long[] Value=A016489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016489.Bytes);
public long this[int i]=>Value[i];

public static A016489Inst Instance=new A016489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016488
{
public static readonly long[] Value={ 4L,10L,1L,1L,2L,71L,1L,2L,14L,14L,1L,1L,122L,1L,3L,1L,1L,87L,2L,2L,4L,2L,3L,3L,3L,4L,3L,5L,2L,4L,3L,1L,2L,2L,1L,3L,1L,3L,75L,1L,38L,2L,3L,10L,22L,1L,10L,4L,1L,2L,3L,1L,1L,7L,1L,2L,2L,1L,1L,1L,8L,2L,2L,8L,1L,3L,1L,2L,1L,1L,3L,1L,3L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016488Inst : IEnumerable<long>
{
public static readonly long[] Value=A016488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016488.Bytes);
public long this[int i]=>Value[i];

public static A016488Inst Instance=new A016488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016487
{
public static readonly long[] Value={ 4L,12L,1L,8L,1L,2L,2L,2L,1L,16L,1L,6L,2L,2L,3L,11L,1L,2L,1L,1L,4L,2L,1L,1L,1L,1L,7L,1L,6L,4L,1L,2L,5L,2L,2L,1L,4L,1L,4L,2L,11L,4L,4L,2L,3L,11L,1L,3L,15L,1L,1L,1L,3L,4L,2L,1L,6L,1L,1L,4L,3L,2L,1L,7L,1L,20L,8L,2L,3L,1L,3L,1L,47L,1L,1L,1L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016487Inst : IEnumerable<long>
{
public static readonly long[] Value=A016487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016487.Bytes);
public long this[int i]=>Value[i];

public static A016487Inst Instance=new A016487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016486
{
public static readonly long[] Value={ 4L,16L,1L,1L,5L,8L,1L,1L,3L,8L,5L,1L,2L,1L,3L,1L,9L,2L,1L,11L,1L,13L,1L,1L,4L,1L,1L,2L,2L,1L,5L,2L,2L,2L,3L,1L,1L,11L,1L,11L,5L,2L,2L,3L,2L,3L,7L,19L,1L,1L,4L,2L,1L,1L,4L,171L,2L,1L,1L,12L,1L,1L,1L,4L,1L,4L,2L,3L,11L,10L,1L,1L,2L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016486Inst : IEnumerable<long>
{
public static readonly long[] Value=A016486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016486.Bytes);
public long this[int i]=>Value[i];

public static A016486Inst Instance=new A016486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016485
{
public static readonly long[] Value={ 4L,23L,4L,2L,1L,1L,1L,1L,5L,1L,1L,1L,1L,4L,2L,1L,9L,4L,1L,94L,1L,1L,1L,1L,1L,1L,1L,1L,25L,1L,2L,3L,3L,13L,1L,4L,10L,1L,21L,1L,1L,1L,5L,2L,1L,1L,1L,1L,1L,1L,2L,4L,1L,5L,7L,2L,2L,4L,1L,3L,1L,2L,1L,1L,2L,32L,1L,5L,3L,13L,17L,1L,1L,1L,6L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016485Inst : IEnumerable<long>
{
public static readonly long[] Value=A016485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016485.Bytes);
public long this[int i]=>Value[i];

public static A016485Inst Instance=new A016485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016484
{
public static readonly long[] Value={ 4L,39L,2L,4L,18L,1L,1L,2L,1L,1L,91L,1L,7L,1L,3L,1L,3L,2L,1L,1L,1L,3L,1L,1L,1L,5L,8L,2L,1L,4L,16L,1L,7L,1L,2L,53L,2L,1L,3L,1L,6L,2L,11L,1L,11L,2L,1L,2L,8L,1L,1L,14L,49L,1L,7L,2L,1L,7L,2L,4L,257L,3L,5L,1L,5L,1L,99L,1L,4L,1L,1L,16L,11L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016484Inst : IEnumerable<long>
{
public static readonly long[] Value=A016484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016484.Bytes);
public long this[int i]=>Value[i];

public static A016484Inst Instance=new A016484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016483
{
public static readonly long[] Value={ 4L,136L,2L,1L,2L,1L,2L,3L,1L,1L,1L,8L,1L,1L,2L,1L,5L,1L,1L,2L,7L,3L,1L,22L,5L,3L,6L,1L,3L,4L,1L,1L,1L,1L,2L,2L,1L,5L,1L,1L,1L,2L,3L,2L,1L,1L,5L,2L,2L,25L,6L,1L,4L,1L,7L,2L,1L,2L,1L,15L,2L,3L,5L,1L,3L,1L,18L,8L,9L,1L,4L,1L,4L,2L,1L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016483Inst : IEnumerable<long>
{
public static readonly long[] Value=A016483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016483.Bytes);
public long this[int i]=>Value[i];

public static A016483Inst Instance=new A016483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016482
{
public static readonly long[] Value={ 3L,1L,89L,1L,3L,2L,35L,1L,1L,1L,1L,39L,3L,1L,1L,1L,14L,4L,13L,2L,6L,1L,3L,1L,1L,12L,1L,2L,12L,1L,3L,1L,1L,14L,2L,1L,10L,123L,1L,14L,2L,3L,1L,2L,1L,3L,1L,72L,2L,8L,21L,1L,1L,1L,5L,1L,25L,4L,4L,1L,1L,89L,3L,1L,2L,1L,1L,4L,3L,6L,1L,3L,5L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016482Inst : IEnumerable<long>
{
public static readonly long[] Value=A016482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016482.Bytes);
public long this[int i]=>Value[i];

public static A016482Inst Instance=new A016482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016481
{
public static readonly long[] Value={ 3L,1L,32L,1L,1L,1L,18L,2L,97L,2L,1L,1L,1L,28L,2L,2L,1L,331L,6L,1L,1L,1L,7L,2L,1L,1L,1L,3L,2L,1L,15L,1L,1L,1L,2L,1L,2L,7L,2L,1L,2L,7L,9L,2L,15L,1L,1L,1L,1L,3L,1L,26L,6L,1L,1L,2L,2L,6L,25L,1L,1L,14L,31L,1L,5L,11L,4L,2L,1L,2L,2L,1L,2L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016481Inst : IEnumerable<long>
{
public static readonly long[] Value=A016481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016481.Bytes);
public long this[int i]=>Value[i];

public static A016481Inst Instance=new A016481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016480
{
public static readonly long[] Value={ 3L,1L,19L,1L,1L,24L,15L,1L,3L,1L,12L,1L,7L,2L,5L,1L,6L,1L,3L,6L,1L,31L,1L,7L,39L,3L,2L,1L,1L,3L,8L,2L,1L,1L,1L,1L,8L,1L,6L,4L,2L,7L,1L,4L,1L,8L,7L,1L,1L,2L,39L,1L,7L,2L,1L,2L,6L,5L,2L,2L,20L,2L,1L,13L,2L,1L,1L,10L,4L,2L,2L,1L,2L,7L,5L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016480Inst : IEnumerable<long>
{
public static readonly long[] Value=A016480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016480.Bytes);
public long this[int i]=>Value[i];

public static A016480Inst Instance=new A016480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016479
{
public static readonly long[] Value={ 3L,1L,13L,1L,2L,68L,1L,59L,4L,9L,3L,1L,1L,3L,1L,17L,1L,2L,4L,4L,1L,4L,1L,1L,2L,3L,1L,9L,4L,5L,1L,1L,21L,186L,1L,1L,15L,1L,8L,25L,1L,1L,1L,1L,107L,163L,1L,2L,1L,1L,2L,9L,10L,2L,2L,4L,1L,1L,121L,1L,2L,19L,1L,2L,1L,47L,1L,2L,2L,1L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016479Inst : IEnumerable<long>
{
public static readonly long[] Value=A016479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016479.Bytes);
public long this[int i]=>Value[i];

public static A016479Inst Instance=new A016479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016478
{
public static readonly long[] Value={ 3L,1L,10L,2L,1L,2L,1L,2L,18L,1L,1L,6L,1L,1L,1L,7L,1L,9L,1L,9L,3L,1L,4L,1L,1L,3L,9L,5L,1L,1L,2L,1L,3L,5L,7L,1L,2L,1L,1L,2L,18L,1L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,13L,5L,515L,8L,4L,2L,2L,1L,1L,1L,44L,4L,6L,8L,4L,1L,5L,2L,3L,51L,2L,11L,2L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016478Inst : IEnumerable<long>
{
public static readonly long[] Value=A016478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016478.Bytes);
public long this[int i]=>Value[i];

public static A016478Inst Instance=new A016478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016461
{
public static readonly long[] Value={ 3L,2L,71L,12L,61L,1L,5L,12L,1L,5L,6L,6L,1L,9L,1L,1L,4L,1L,997L,1L,1L,1L,1L,8L,7L,8L,5L,1L,1L,1L,1L,4L,1L,1L,1L,1L,4L,1L,2L,53L,1L,3L,2L,3L,2L,1L,1L,1L,1L,82L,1L,1L,2L,2L,6L,3L,260L,1L,1L,6L,1L,3L,24L,4L,1L,3L,6L,1L,4L,2L,1L,3L,1L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016461Inst : IEnumerable<long>
{
public static readonly long[] Value=A016461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016461.Bytes);
public long this[int i]=>Value[i];

public static A016461Inst Instance=new A016461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016460
{
public static readonly long[] Value={ 3L,2L,6L,1L,3L,1L,9L,1L,10L,1L,3L,1L,1L,12L,1L,1L,1L,1L,2L,12L,3L,1L,2L,36L,13L,2L,2L,4L,2L,1L,1L,4L,4L,2L,1L,3L,1L,1L,1L,1L,3L,2L,3L,3L,2L,4L,1L,2L,1L,2L,1L,10L,1L,2L,5L,1L,69L,3L,5L,7L,2L,1L,1L,1L,1L,3L,3L,3L,1L,13L,6L,1L,1L,10L,1L,23L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016460Inst : IEnumerable<long>
{
public static readonly long[] Value=A016460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016460.Bytes);
public long this[int i]=>Value[i];

public static A016460Inst Instance=new A016460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016459
{
public static readonly long[] Value={ 3L,2L,3L,3L,2L,13L,1L,5L,3L,1L,32L,1L,6L,2L,2L,1L,24L,2L,5L,1L,6L,1L,16L,1L,1L,13L,14L,2L,1L,5L,4L,4L,1L,3L,5L,4L,19L,1L,16L,1L,2L,5L,2L,3L,1L,7L,1L,1L,1L,91L,26L,1L,16L,1L,13L,1L,6L,29L,2L,17L,1L,8L,2L,28L,1L,7L,6L,5L,1L,1L,1L,15L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016459Inst : IEnumerable<long>
{
public static readonly long[] Value=A016459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016459.Bytes);
public long this[int i]=>Value[i];

public static A016459Inst Instance=new A016459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016458
{
public static readonly long[] Value={ 3L,2L,2L,33L,160L,1L,2L,51L,1L,3L,22L,1L,7L,1L,2L,4L,7L,7L,1L,1L,1L,5L,4L,2L,18L,3L,12L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,5L,2L,7L,2L,1L,2L,2L,5L,4L,2L,1L,1L,3L,1L,2L,2L,12L,1L,1L,4L,2L,1L,1L,2L,2L,4L,2L,2L,3L,3L,2L,1L,3L,2L,2L,3L,1L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016458Inst : IEnumerable<long>
{
public static readonly long[] Value=A016458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016458.Bytes);
public long this[int i]=>Value[i];

public static A016458Inst Instance=new A016458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016457
{
public static readonly long[] Value={ 3L,2L,1L,2L,1L,1L,1L,1L,7L,1L,1L,6L,3L,1L,1L,1L,4L,2L,6L,2L,1L,1L,5L,2L,1L,1L,2L,2L,23L,358L,1L,5L,1L,3L,4L,3L,2L,3L,4L,3L,1L,6L,4L,1L,3L,8L,482L,4L,4L,2L,12L,2L,1L,17L,49L,7L,2L,1L,6L,1L,3L,2L,1L,1L,3L,1L,9L,1L,145L,41L,2L,480L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016457Inst : IEnumerable<long>
{
public static readonly long[] Value=A016457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016457.Bytes);
public long this[int i]=>Value[i];

public static A016457Inst Instance=new A016457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016456
{
public static readonly long[] Value={ 3L,3L,98L,10L,4L,17L,2L,1L,3L,10L,1L,1L,1L,1L,3L,8L,43L,1L,38L,2L,1L,1L,2L,2L,1L,11L,1L,1L,2L,1L,10L,12L,1L,72L,1L,3L,1L,2L,2L,2L,2L,1L,1L,8L,1L,1L,193L,7L,2L,1L,1L,5L,1L,6L,2L,1L,2L,1L,3L,1L,1L,10L,3L,1L,1L,2L,1L,6L,2L,1L,2L,1L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016456Inst : IEnumerable<long>
{
public static readonly long[] Value=A016456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016456.Bytes);
public long this[int i]=>Value[i];

public static A016456Inst Instance=new A016456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016455
{
public static readonly long[] Value={ 3L,3L,2L,1L,1L,1L,2L,2L,1L,4L,4L,1L,3L,10L,1L,4L,1L,5L,3L,5L,5L,1L,1L,1L,3L,108L,1L,7L,1L,1L,3L,3L,1L,1L,1L,8L,2L,1L,1L,1L,2L,3L,1L,3L,1L,7L,1L,1L,2L,12L,1L,50L,4L,3L,23L,3L,8L,3L,1L,5L,1L,4L,7L,1L,6L,1L,1L,5L,1L,1L,1L,1L,6L,15L,1L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016455Inst : IEnumerable<long>
{
public static readonly long[] Value=A016455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016455.Bytes);
public long this[int i]=>Value[i];

public static A016455Inst Instance=new A016455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016454
{
public static readonly long[] Value={ 3L,3L,1L,6L,1L,31L,1L,1L,1L,2L,1461L,1L,1L,2L,1L,3L,1L,4L,2L,5L,1L,1L,104L,6L,25L,10L,6L,12L,1L,2L,1L,156L,2L,1L,1L,7L,1L,139L,1L,8L,1L,3L,2L,1L,8L,7L,1L,8L,2L,3L,2L,9L,6L,46L,1L,3L,5L,1L,5L,1L,10L,1L,2L,7L,7L,2L,22L,2L,4L,3L,1L,177L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016454Inst : IEnumerable<long>
{
public static readonly long[] Value=A016454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016454.Bytes);
public long this[int i]=>Value[i];

public static A016454Inst Instance=new A016454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016453
{
public static readonly long[] Value={ 3L,4L,1L,1L,3L,7L,2L,12L,47L,2L,1L,1L,1L,1L,1L,1L,19L,1L,11L,1L,5L,15L,3L,1L,1L,3L,1L,1L,19L,8L,1L,1L,1L,1L,1L,20L,6L,1L,3L,2L,3L,4L,9L,3L,26L,8L,9L,8L,32L,1L,1L,1L,1L,5L,1L,8L,2L,4L,2L,10L,2L,7L,1L,1L,7L,20L,1L,27L,70L,1L,15L,1L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016453Inst : IEnumerable<long>
{
public static readonly long[] Value=A016453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016453.Bytes);
public long this[int i]=>Value[i];

public static A016453Inst Instance=new A016453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016452
{
public static readonly long[] Value={ 3L,5L,1L,1L,1L,1L,1L,1L,6L,35660L,1L,3L,1L,2L,1L,3L,3L,2L,1L,13L,2L,4L,1L,16L,3L,7L,10L,2L,16L,1L,3L,1L,1L,9L,1L,1L,5L,2L,6L,2L,4L,203L,1L,4L,7L,1L,1L,1L,1L,2L,33L,1L,8L,1L,5L,2L,12L,136L,3L,6L,1L,1L,1L,1L,1L,37L,8L,1L,1L,3L,1L,27L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016452Inst : IEnumerable<long>
{
public static readonly long[] Value=A016452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016452.Bytes);
public long this[int i]=>Value[i];

public static A016452Inst Instance=new A016452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016451
{
public static readonly long[] Value={ 3L,7L,2L,1L,1L,1L,2L,3L,1L,1L,1L,4L,158L,3L,2L,5L,1L,6L,4L,2L,72L,1L,2L,1L,5L,14L,3L,1L,5L,2L,2L,1L,4L,8L,1L,1L,1L,4L,18L,1L,1L,2L,1L,4L,2L,1L,1L,1L,2L,3L,3L,26L,1L,3L,1L,22L,3L,5L,1L,2L,2L,2L,1L,29L,2L,1L,2L,1L,8L,9L,2L,1L,2L,8L,19L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016451Inst : IEnumerable<long>
{
public static readonly long[] Value=A016451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016451.Bytes);
public long this[int i]=>Value[i];

public static A016451Inst Instance=new A016451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016450
{
public static readonly long[] Value={ 3L,10L,1L,61L,16L,2L,3L,3L,5L,6L,171L,2L,4L,5L,4L,1L,2L,1L,1L,3L,1L,1L,3L,22L,1L,13L,1L,17L,3L,2L,1L,3L,1L,1L,1L,4L,6L,1L,3L,2L,2L,1L,2L,1L,8L,2L,25L,5L,12L,1L,1L,1L,2L,1L,7L,3L,2L,1L,4L,4L,1L,17L,1L,66L,1L,2L,37L,1L,3L,3L,5L,1L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016450Inst : IEnumerable<long>
{
public static readonly long[] Value=A016450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016450.Bytes);
public long this[int i]=>Value[i];

public static A016450Inst Instance=new A016450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016449
{
public static readonly long[] Value={ 3L,22L,2L,5L,1L,5L,2L,1L,3L,2L,5L,2L,1L,9L,4L,1L,2L,26L,1L,1L,1L,51L,1L,2L,7L,11L,1L,1L,1L,10L,4L,1L,6L,19L,5L,1L,1L,3L,2L,6L,1L,5L,2L,3L,20L,11L,7L,2L,2L,1L,5L,1L,4L,1L,1L,1L,1L,1L,1L,18L,1L,13L,3L,2L,2L,3L,4L,3L,4L,1L,2L,10L,1L,6L,28L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016449Inst : IEnumerable<long>
{
public static readonly long[] Value=A016449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016449.Bytes);
public long this[int i]=>Value[i];

public static A016449Inst Instance=new A016449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016448
{
public static readonly long[] Value={ 2L,1L,233L,3L,6L,2L,1L,1L,2L,2L,2L,4L,8L,2L,2L,1L,27L,1L,6L,6L,2L,1L,4L,3L,1L,1L,1L,33L,2L,1L,2L,1L,1L,1L,3L,5L,3L,1L,3L,2L,2L,3L,7L,1L,2L,1L,4L,1L,5L,1L,2L,3L,4L,11L,2L,8L,2L,3L,5L,3L,1L,2L,1L,1L,2L,1L,5L,9L,1L,6L,7L,1L,6L,1L,3L,1L,47L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016448Inst : IEnumerable<long>
{
public static readonly long[] Value=A016448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016448.Bytes);
public long this[int i]=>Value[i];

public static A016448Inst Instance=new A016448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016447
{
public static readonly long[] Value={ 2L,1L,16L,1L,563L,1L,3L,1L,2L,1L,1L,7L,1L,2L,89L,1L,5L,2L,1L,31L,5L,3L,1L,1L,3L,1L,1L,31L,1L,1L,43L,1L,1L,14L,1L,1L,8L,2L,7L,2L,1L,2L,25L,1L,5L,165L,1L,4L,7L,1L,16L,1L,17L,1L,12L,29L,1L,1L,1L,1L,1L,6L,4L,1L,1L,1L,3L,1L,9L,5L,3L,3L,1L,1L,14L,2L,4L,1L,2L,2L,4L,1L,2L,1L,2L,4L,2L,1L,11L,2L,1L,1L,1L,2L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016447Inst : IEnumerable<long>
{
public static readonly long[] Value=A016447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016447.Bytes);
public long this[int i]=>Value[i];

public static A016447Inst Instance=new A016447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016446
{
public static readonly long[] Value={ 2L,1L,8L,8L,4L,1L,1L,1L,36L,14L,1L,1L,1L,65L,1L,1L,4L,27L,7L,1L,1L,2L,3L,8L,7L,4L,1L,7L,1L,4L,13L,1L,3L,1L,2L,3L,6L,1L,4L,2L,2L,1L,1L,2L,8L,2L,6L,2L,1L,5L,3L,1L,1L,1L,1L,116L,1L,48L,28L,1L,7L,1L,1L,23L,1L,15L,1L,10L,1L,9L,2L,1L,1L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016446Inst : IEnumerable<long>
{
public static readonly long[] Value=A016446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016446.Bytes);
public long this[int i]=>Value[i];

public static A016446Inst Instance=new A016446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016445
{
public static readonly long[] Value={ 2L,1L,4L,1L,230L,1L,2L,50L,1L,11L,2L,2L,1L,1L,7L,1L,8L,1L,90L,1L,3L,2L,5L,5L,1L,2L,3L,2L,4L,1L,17L,1L,401L,13L,2L,1L,22L,3L,1L,8L,1L,22L,1L,4L,1L,1L,3L,1L,2L,3L,3L,2L,7L,32L,1L,14L,2L,1L,1L,1L,3L,1L,6L,58L,1L,1L,1L,1L,1L,1L,3L,2L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016445Inst : IEnumerable<long>
{
public static readonly long[] Value=A016445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016445.Bytes);
public long this[int i]=>Value[i];

public static A016445Inst Instance=new A016445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016444
{
public static readonly long[] Value={ 2L,1L,3L,2L,1L,1L,14L,3L,9L,43L,1L,1L,7L,1L,1L,3L,1L,3L,2L,1L,2L,1L,3L,1L,1L,1L,4L,6L,1L,1L,6L,3L,1L,1L,21L,3L,1L,2L,1L,2L,4L,1L,8L,4L,1L,1L,3L,3L,28L,1L,6L,1L,4L,5L,3L,3L,5L,1L,19L,7L,1L,1L,70L,11L,8L,6L,1L,1L,3L,4L,1L,2L,7L,1L,5L,3L,2L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016444Inst : IEnumerable<long>
{
public static readonly long[] Value=A016444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016444.Bytes);
public long this[int i]=>Value[i];

public static A016444Inst Instance=new A016444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016443
{
public static readonly long[] Value={ 2L,1L,2L,2L,2L,1L,5L,2L,2L,1L,3L,3L,2L,58L,8L,1L,2L,1L,1L,4L,1L,1L,165L,1L,1L,7L,3L,1L,4L,7L,3L,2L,8L,2L,1L,1L,4L,23L,2L,8L,2L,2L,3L,2L,1L,13L,1L,2L,1L,3L,58L,3L,1L,3L,2L,3L,4L,2L,1L,110L,4L,3L,25L,1L,5L,1L,4L,24L,3L,2L,7L,1L,1L,2L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016443Inst : IEnumerable<long>
{
public static readonly long[] Value=A016443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016443.Bytes);
public long this[int i]=>Value[i];

public static A016443Inst Instance=new A016443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016442
{
public static readonly long[] Value={ 2L,1L,1L,1L,3L,2L,1L,3L,1L,7L,1L,4L,8L,4L,10L,1L,2L,1L,9L,1L,5L,4L,2L,4L,5L,2L,3L,123L,10L,12L,4L,1L,1L,1L,1L,1L,2L,2L,9L,4L,1L,4L,11L,2L,1L,8L,2L,2L,3L,3L,11L,16L,2L,2L,3L,7L,1L,1L,1L,95L,5L,34L,1L,2L,4L,1L,2L,3L,1L,1L,1L,37L,6L,38L,1L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016442Inst : IEnumerable<long>
{
public static readonly long[] Value=A016442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016442.Bytes);
public long this[int i]=>Value[i];

public static A016442Inst Instance=new A016442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016441
{
public static readonly long[] Value={ 2L,1L,1L,3L,2L,1L,6L,2L,1L,4L,47L,1L,1L,1L,1L,1L,11L,4L,2L,18L,1L,2L,2L,3L,1L,1L,2L,2L,3L,2L,40L,7L,1L,4L,1L,28L,6L,1L,2L,7L,1L,1L,1L,8L,1L,3L,1L,21L,1L,4L,1L,2L,4L,44L,3L,4L,4L,1L,3L,1L,23L,2L,2L,5L,1L,1L,33L,1L,1L,13L,1L,60L,115L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016441Inst : IEnumerable<long>
{
public static readonly long[] Value=A016441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016441.Bytes);
public long this[int i]=>Value[i];

public static A016441Inst Instance=new A016441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016440
{
public static readonly long[] Value={ 1L,4L,12L,23L,32L,49L,86L,124L,147L,167L,219L,280L,324L,373L,432L,501L,569L,636L,722L,811L,901L,980L,1064L,1162L,1260L,1399L,1545L,1631L,1700L,1817L,2017L,2196L,2289L,2380L,2521L,2723L,2903L,3037L,3214L,3383L,3550L,3729L,3888L,4097L,4301L,4495L,4729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016440Inst : IEnumerable<long>
{
public static readonly long[] Value=A016440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016440.Bytes);
public long this[int i]=>Value[i];

public static A016440Inst Instance=new A016440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016439
{
public static readonly long[] Value={ 1L,4L,12L,20L,35L,55L,81L,119L,142L,182L,216L,267L,322L,374L,456L,506L,542L,639L,722L,826L,893L,957L,1076L,1168L,1282L,1397L,1506L,1648L,1714L,1826L,1998L,2159L,2306L,2411L,2553L,2706L,2837L,3047L,3251L,3418L,3513L,3666L,3922L,4133L,4336L,4477L,4646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016439Inst : IEnumerable<long>
{
public static readonly long[] Value=A016439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016439.Bytes);
public long this[int i]=>Value[i];

public static A016439Inst Instance=new A016439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016438
{
public static readonly long[] Value={ 1L,4L,11L,21L,33L,53L,80L,112L,155L,187L,214L,257L,320L,385L,435L,499L,577L,638L,705L,796L,919L,1007L,1041L,1136L,1282L,1419L,1530L,1603L,1716L,1852L,1990L,2158L,2309L,2422L,2525L,2681L,2884L,3059L,3215L,3375L,3572L,3747L,3863L,4055L,4316L,4553L,4715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016438Inst : IEnumerable<long>
{
public static readonly long[] Value=A016438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016438.Bytes);
public long this[int i]=>Value[i];

public static A016438Inst Instance=new A016438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016437
{
public static readonly long[] Value={ 1L,4L,11L,19L,34L,56L,78L,116L,152L,184L,208L,256L,325L,385L,448L,499L,552L,642L,718L,809L,893L,984L,1062L,1148L,1292L,1408L,1508L,1614L,1719L,1865L,1976L,2129L,2328L,2439L,2544L,2659L,2830L,3103L,3242L,3366L,3531L,3706L,3923L,4086L,4315L,4532L,4643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016437Inst : IEnumerable<long>
{
public static readonly long[] Value=A016437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016437.Bytes);
public long this[int i]=>Value[i];

public static A016437Inst Instance=new A016437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016436
{
public static readonly long[] Value={ 1L,4L,11L,21L,41L,61L,77L,107L,134L,186L,232L,271L,322L,376L,436L,487L,571L,668L,713L,787L,879L,982L,1093L,1182L,1284L,1375L,1469L,1616L,1765L,1912L,1988L,2077L,2261L,2429L,2592L,2727L,2870L,3063L,3176L,3328L,3557L,3758L,3947L,4084L,4280L,4491L,4672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016436Inst : IEnumerable<long>
{
public static readonly long[] Value=A016436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016436.Bytes);
public long this[int i]=>Value[i];

public static A016436Inst Instance=new A016436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016435
{
public static readonly long[] Value={ 1L,4L,11L,22L,39L,62L,82L,104L,142L,178L,225L,283L,329L,370L,418L,495L,591L,662L,711L,772L,889L,1007L,1081L,1168L,1274L,1387L,1495L,1606L,1755L,1892L,2007L,2119L,2242L,2404L,2571L,2752L,2924L,3030L,3147L,3321L,3578L,3817L,3917L,4034L,4268L,4534L,4737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016435Inst : IEnumerable<long>
{
public static readonly long[] Value=A016435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016435.Bytes);
public long this[int i]=>Value[i];

public static A016435Inst Instance=new A016435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016434
{
public static readonly long[] Value={ 1L,4L,11L,21L,35L,58L,87L,103L,144L,188L,227L,261L,311L,390L,443L,498L,568L,627L,736L,811L,874L,971L,1079L,1197L,1275L,1377L,1504L,1602L,1762L,1877L,1980L,2121L,2264L,2460L,2578L,2681L,2866L,3027L,3242L,3397L,3514L,3706L,3920L,4161L,4289L,4441L,4706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016434Inst : IEnumerable<long>
{
public static readonly long[] Value=A016434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016434.Bytes);
public long this[int i]=>Value[i];

public static A016434Inst Instance=new A016434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016433
{
public static readonly long[] Value={ 1L,4L,11L,19L,35L,57L,83L,113L,137L,184L,231L,266L,322L,368L,429L,514L,575L,637L,706L,804L,908L,984L,1068L,1151L,1273L,1422L,1514L,1596L,1706L,1872L,2045L,2150L,2242L,2369L,2568L,2776L,2903L,2998L,3135L,3393L,3637L,3747L,3865L,4028L,4290L,4593L,4740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016433Inst : IEnumerable<long>
{
public static readonly long[] Value=A016433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016433.Bytes);
public long this[int i]=>Value[i];

public static A016433Inst Instance=new A016433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016432
{
public static readonly long[] Value={ 1L,4L,12L,22L,37L,60L,81L,112L,154L,192L,230L,284L,336L,394L,464L,524L,594L,684L,754L,832L,942L,1036L,1124L,1238L,1344L,1456L,1586L,1696L,1822L,1980L,2100L,2226L,2402L,2550L,2686L,2862L,3024L,3192L,3384L,3542L,3722L,3946L,4114L,4290L,4534L,4738L,4924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016432Inst : IEnumerable<long>
{
public static readonly long[] Value=A016432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016432.Bytes);
public long this[int i]=>Value[i];

public static A016432Inst Instance=new A016432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016431
{
public static readonly long[] Value={ 1L,4L,11L,22L,34L,52L,84L,120L,149L,180L,220L,276L,351L,422L,474L,516L,559L,632L,758L,892L,979L,1036L,1098L,1186L,1323L,1480L,1612L,1724L,1817L,1924L,2100L,2282L,2403L,2514L,2652L,2830L,3057L,3268L,3418L,3534L,3645L,3822L,4118L,4422L,4613L,4738L,4874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016431Inst : IEnumerable<long>
{
public static readonly long[] Value=A016431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016431.Bytes);
public long this[int i]=>Value[i];

public static A016431Inst Instance=new A016431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016430
{
public static readonly long[] Value={ 1L,4L,10L,21L,37L,57L,82L,111L,145L,189L,236L,280L,332L,392L,454L,525L,599L,671L,754L,841L,927L,1029L,1134L,1230L,1340L,1458L,1572L,1701L,1833L,1957L,2098L,2243L,2381L,2541L,2704L,2852L,3020L,3196L,3362L,3549L,3739L,3915L,4114L,4317L,4507L,4725L,4946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016430Inst : IEnumerable<long>
{
public static readonly long[] Value=A016430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016430.Bytes);
public long this[int i]=>Value[i];

public static A016430Inst Instance=new A016430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016429
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-1L,1L,0L,0L,0L,0L,1L,-1L,1L,0L,0L,0L,0L,2L,-2L,1L,1L,-2L,2L,0L,0L,0L,0L,1L,-1L,1L,0L,0L,0L,0L,2L,-3L,2L,1L,-3L,3L,-1L,0L,0L,0L,1L,-2L,2L,-1L,0L,0L,0L,1L,-3L,3L,-1L,-2L,3L,-2L,0L,0L,0L,0L,-1L,1L,-1L,0L,0L,0L,0L,-2L,2L,-1L,-1L,2L,-2L,0L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016429Inst : IEnumerable<long>
{
public static readonly long[] Value=A016429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016429.Bytes);
public long this[int i]=>Value[i];

public static A016429Inst Instance=new A016429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016428
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016428Inst : IEnumerable<long>
{
public static readonly long[] Value=A016428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016428.Bytes);
public long this[int i]=>Value[i];

public static A016428Inst Instance=new A016428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016427
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,-1L,1L,0L,-1L,1L,-1L,0L,1L,-2L,1L,0L,-1L,1L,-1L,0L,1L,-1L,0L,1L,-1L,1L,0L,-1L,1L,0L,-1L,1L,-1L,0L,1L,-2L,1L,0L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016427Inst : IEnumerable<long>
{
public static readonly long[] Value=A016427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016427.Bytes);
public long this[int i]=>Value[i];

public static A016427Inst Instance=new A016427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016426
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016426Inst : IEnumerable<long>
{
public static readonly long[] Value=A016426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016426.Bytes);
public long this[int i]=>Value[i];

public static A016426Inst Instance=new A016426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016425
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016425Inst : IEnumerable<long>
{
public static readonly long[] Value=A016425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016425.Bytes);
public long this[int i]=>Value[i];

public static A016425Inst Instance=new A016425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016424
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016424Inst : IEnumerable<long>
{
public static readonly long[] Value=A016424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016424.Bytes);
public long this[int i]=>Value[i];

public static A016424Inst Instance=new A016424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016423
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016423Inst : IEnumerable<long>
{
public static readonly long[] Value=A016423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016423.Bytes);
public long this[int i]=>Value[i];

public static A016423Inst Instance=new A016423Inst();

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