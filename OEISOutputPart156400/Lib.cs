using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199505
{
public static readonly long[] Value={ 6L,2L,6L,4L,7L,0L,1L,4L,9L,1L,6L,1L,3L,5L,9L,1L,8L,6L,5L,7L,0L,2L,4L,4L,2L,7L,0L,7L,0L,8L,7L,0L,4L,2L,8L,7L,0L,5L,8L,4L,7L,2L,3L,7L,1L,4L,2L,7L,3L,9L,7L,8L,8L,7L,7L,5L,3L,7L,3L,8L,4L,2L,5L,2L,9L,4L,9L,7L,3L,2L,1L,3L,7L,6L,9L,5L,0L,4L,7L,7L,4L,7L,6L,3L,0L,2L,5L,0L,0L,1L,9L,0L,7L,5L,9L,5L,3L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199505Inst : IEnumerable<long>
{
public static readonly long[] Value=A199505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199505.Bytes);
public long this[int i]=>Value[i];

public static A199505Inst Instance=new A199505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199506
{
public static readonly long[] Value={ 8L,0L,9L,4L,7L,6L,4L,1L,5L,8L,7L,5L,0L,6L,2L,2L,6L,6L,8L,3L,5L,3L,1L,7L,9L,1L,3L,8L,4L,5L,9L,8L,9L,1L,9L,4L,0L,0L,4L,1L,4L,8L,2L,5L,5L,6L,7L,1L,8L,2L,7L,6L,1L,6L,4L,1L,5L,5L,5L,8L,3L,5L,5L,2L,3L,5L,4L,4L,5L,5L,0L,7L,3L,5L,0L,8L,6L,3L,9L,7L,5L,5L,3L,1L,2L,9L,5L,5L,5L,5L,7L,0L,3L,8L,0L,3L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199506Inst : IEnumerable<long>
{
public static readonly long[] Value=A199506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199506.Bytes);
public long this[int i]=>Value[i];

public static A199506Inst Instance=new A199506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199507
{
public static readonly long[] Value={ 9L,2L,1L,5L,5L,7L,1L,1L,0L,1L,7L,0L,3L,2L,1L,7L,2L,5L,9L,9L,3L,7L,4L,8L,1L,2L,3L,1L,8L,8L,3L,0L,5L,6L,5L,5L,9L,3L,4L,3L,0L,5L,1L,9L,6L,4L,9L,7L,8L,9L,7L,8L,8L,4L,1L,8L,9L,1L,4L,0L,2L,5L,4L,4L,1L,6L,0L,0L,8L,7L,3L,9L,9L,6L,2L,9L,8L,5L,5L,5L,4L,1L,2L,5L,5L,5L,1L,4L,3L,3L,9L,8L,3L,5L,5L,5L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199507Inst : IEnumerable<long>
{
public static readonly long[] Value=A199507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199507.Bytes);
public long this[int i]=>Value[i];

public static A199507Inst Instance=new A199507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199508
{
public static readonly long[] Value={ 7L,7L,3L,9L,8L,1L,1L,1L,7L,4L,2L,7L,4L,6L,7L,1L,7L,7L,5L,2L,1L,6L,5L,7L,3L,0L,3L,9L,8L,6L,7L,2L,5L,3L,0L,3L,0L,1L,6L,7L,5L,0L,3L,8L,2L,4L,5L,6L,8L,1L,7L,2L,2L,8L,9L,4L,8L,8L,0L,9L,5L,8L,6L,5L,4L,7L,3L,7L,5L,2L,0L,7L,1L,3L,0L,3L,6L,9L,4L,8L,6L,9L,5L,3L,6L,3L,5L,9L,1L,3L,0L,4L,2L,1L,2L,0L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199508Inst : IEnumerable<long>
{
public static readonly long[] Value=A199508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199508.Bytes);
public long this[int i]=>Value[i];

public static A199508Inst Instance=new A199508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199509
{
public static readonly long[] Value={ 9L,5L,0L,2L,9L,4L,9L,7L,6L,8L,6L,9L,9L,4L,6L,6L,5L,8L,5L,6L,2L,0L,9L,2L,4L,9L,4L,1L,9L,4L,4L,0L,1L,7L,8L,3L,6L,7L,4L,8L,7L,2L,9L,6L,6L,6L,1L,7L,0L,5L,0L,8L,5L,3L,1L,1L,8L,6L,9L,8L,2L,8L,4L,9L,6L,1L,3L,2L,9L,0L,3L,4L,0L,5L,3L,6L,3L,4L,4L,0L,8L,9L,1L,0L,6L,7L,3L,2L,3L,4L,4L,8L,5L,2L,4L,5L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199509Inst : IEnumerable<long>
{
public static readonly long[] Value=A199509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199509.Bytes);
public long this[int i]=>Value[i];

public static A199509Inst Instance=new A199509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199510
{
public static readonly long[] Value={ 1L,0L,5L,1L,1L,1L,0L,2L,2L,8L,8L,4L,3L,7L,2L,8L,0L,1L,1L,4L,2L,5L,7L,1L,1L,4L,5L,8L,1L,1L,9L,4L,1L,9L,6L,8L,5L,1L,2L,4L,5L,1L,6L,6L,6L,3L,2L,2L,4L,9L,7L,1L,6L,7L,3L,6L,5L,4L,6L,3L,1L,8L,0L,3L,4L,1L,2L,6L,0L,5L,5L,7L,2L,6L,6L,1L,2L,0L,3L,1L,6L,1L,5L,6L,7L,4L,6L,9L,3L,5L,3L,2L,0L,3L,9L,3L,1L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199510Inst : IEnumerable<long>
{
public static readonly long[] Value=A199510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199510.Bytes);
public long this[int i]=>Value[i];

public static A199510Inst Instance=new A199510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199511
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,0L,4L,6L,7L,4L,6L,7L,4L,9L,5L,2L,1L,1L,5L,8L,9L,1L,5L,0L,3L,3L,9L,8L,3L,4L,0L,4L,5L,2L,4L,6L,0L,8L,8L,2L,7L,7L,3L,1L,5L,4L,4L,1L,5L,9L,5L,1L,3L,7L,7L,4L,8L,6L,0L,7L,7L,7L,8L,3L,3L,0L,7L,7L,9L,5L,1L,1L,5L,8L,3L,2L,4L,1L,0L,2L,9L,4L,8L,1L,4L,0L,3L,8L,9L,3L,2L,6L,5L,2L,0L,5L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199511Inst : IEnumerable<long>
{
public static readonly long[] Value=A199511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199511.Bytes);
public long this[int i]=>Value[i];

public static A199511Inst Instance=new A199511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199512
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,5L,3L,5L,8L,13L,5L,8L,13L,21L,34L,8L,13L,21L,34L,55L,89L,13L,21L,34L,55L,89L,144L,233L,21L,34L,55L,89L,144L,233L,377L,610L,34L,55L,89L,144L,233L,377L,610L,987L,1597L,55L,89L,144L,233L,377L,610L,987L,1597L,2584L,4181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199512Inst : IEnumerable<long>
{
public static readonly long[] Value=A199512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199512.Bytes);
public long this[int i]=>Value[i];

public static A199512Inst Instance=new A199512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199513
{
public static readonly long[] Value={ 1L,1L,4L,9L,6L,7L,4L,5L,4L,4L,0L,9L,4L,0L,7L,8L,3L,7L,0L,6L,0L,2L,8L,6L,5L,5L,8L,7L,5L,7L,5L,1L,5L,9L,4L,3L,0L,3L,4L,7L,1L,0L,5L,2L,0L,7L,6L,5L,5L,6L,5L,5L,7L,9L,0L,1L,0L,3L,2L,3L,8L,2L,5L,8L,5L,2L,1L,3L,6L,7L,5L,2L,8L,0L,0L,9L,3L,6L,0L,2L,7L,7L,5L,7L,1L,0L,3L,5L,0L,5L,8L,3L,4L,8L,0L,4L,0L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199513Inst : IEnumerable<long>
{
public static readonly long[] Value=A199513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199513.Bytes);
public long this[int i]=>Value[i];

public static A199513Inst Instance=new A199513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199514
{
public static readonly long[] Value={ 2L,3L,0L,5L,3L,7L,0L,0L,5L,11L,0L,13L,7L,15L,0L,17L,0L,19L,0L,7L,11L,23L,0L,0L,13L,0L,0L,29L,15L,31L,0L,33L,17L,35L,0L,37L,19L,13L,0L,41L,7L,43L,0L,0L,23L,47L,0L,0L,0L,51L,0L,53L,0L,11L,0L,19L,29L,59L,0L,61L,31L,0L,0L,65L,33L,67L,0L,69L,35L,71L,0L,73L,37L,0L,0L,77L,13L,79L,0L,0L,41L,83L,0L,85L,43L,87L,0L,89L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199514Inst : IEnumerable<long>
{
public static readonly long[] Value=A199514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199514.Bytes);
public long this[int i]=>Value[i];

public static A199514Inst Instance=new A199514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199515
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,4L,7L,1L,1L,1L,1L,1L,3L,6L,1L,1L,1L,7L,1L,1L,1L,11L,1L,1L,13L,9L,11L,1L,1L,10L,5L,1L,1L,5L,1L,1L,1L,12L,1L,1L,1L,1L,19L,1L,1L,1L,3L,1L,7L,15L,1L,1L,1L,16L,1L,1L,17L,23L,1L,1L,25L,23L,1L,1L,1L,19L,1L,1L,17L,9L,1L,1L,1L,21L,1L,1L,21L,22L,31L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199515Inst : IEnumerable<long>
{
public static readonly long[] Value=A199515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199515.Bytes);
public long this[int i]=>Value[i];

public static A199515Inst Instance=new A199515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199516
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,45L,105L,105L,1260L,6300L,15400L,15400L,200200L,1051050L,2627625L,2627625L,35735700L,192972780L,488864376L,488864376L,6844101264L,37642556952L,96197645544L,96197645544L,1374252079200L,7656547298400L,19688264481600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199516Inst : IEnumerable<long>
{
public static readonly long[] Value=A199516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199516.Bytes);
public long this[int i]=>Value[i];

public static A199516Inst Instance=new A199516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199517
{
public static readonly long[] Value={ 1L,1L,45L,105L,6300L,15400L,1030230L,2559433L,182663916L,457744440L,34150210658L,86068056429L,6629396556290L,16775738245132L,1323517639910370L,3359302469625303L,270024529787133744L,686970966254338640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199517Inst : IEnumerable<long>
{
public static readonly long[] Value=A199517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199517.Bytes);
public long this[int i]=>Value[i];

public static A199517Inst Instance=new A199517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199518
{
public static readonly BigInteger[] Value={ 1L,45L,1260L,15400L,2513869L,174524175L,5866391058L,78538951349L,14918883751196L,1134907763429651L,40321453946092356L,558398606969183196L,BigInteger.Parse("113331120839472129952"),BigInteger.Parse("8998123036816556850222"),BigInteger.Parse("328615244611727182223731") };
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
public class A199518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199518Inst Instance=new A199518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199519
{
public static readonly BigInteger[] Value={ 1L,105L,15400L,2491383L,425836476L,76066541392L,14045226977086L,2659503142845964L,513629992322483274L,BigInteger.Parse("100788315834577397826"),BigInteger.Parse("20037985877897676968942") };
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
public class A199519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199519Inst Instance=new A199519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199520
{
public static readonly long[] Value={ 10L,6300L,2513869L,425836476L,1036302685728L,1049206835165446L,506637005741617919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199520Inst : IEnumerable<long>
{
public static readonly long[] Value=A199520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199520.Bytes);
public long this[int i]=>Value[i];

public static A199520Inst Instance=new A199520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199521
{
public static readonly long[] Value={ 45L,15400L,174524175L,76066541392L,1049206835165446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199521Inst : IEnumerable<long>
{
public static readonly long[] Value=A199521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199521.Bytes);
public long this[int i]=>Value[i];

public static A199521Inst Instance=new A199521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199522
{
public static readonly long[] Value={ 105L,1030230L,5866391058L,14045226977086L,506637005741617919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199522Inst : IEnumerable<long>
{
public static readonly long[] Value=A199522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199522.Bytes);
public long this[int i]=>Value[i];

public static A199522Inst Instance=new A199522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199523
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,45L,45L,1L,10L,105L,1260L,105L,10L,45L,6300L,15400L,15400L,6300L,45L,105L,15400L,2513869L,2491383L,2513869L,15400L,105L,105L,1030230L,174524175L,425836476L,425836476L,174524175L,1030230L,105L,1260L,2559433L,5866391058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199523Inst : IEnumerable<long>
{
public static readonly long[] Value=A199523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199523.Bytes);
public long this[int i]=>Value[i];

public static A199523Inst Instance=new A199523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199524
{
public static readonly long[] Value={ 1L,4L,18L,72L,320L,1414L,6346L,28766L,131246L,602390L,2777638L,12857572L,59712940L,278096674L,1298309782L,6074112952L,28470828008L,133671581490L,628526085270L,2959291856816L,13950087683416L,65832860408434L,310987879638926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199524Inst : IEnumerable<long>
{
public static readonly long[] Value=A199524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199524.Bytes);
public long this[int i]=>Value[i];

public static A199524Inst Instance=new A199524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199525
{
public static readonly long[] Value={ 1L,6L,36L,212L,1324L,8342L,53302L,343710L,2232322L,14582218L,95702528L,630544704L,4168091856L,27630031358L,183604587444L,1222672695812L,8157398577024L,54515075729370L,364861668341252L,2445239266293460L,16407415704050100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199525Inst : IEnumerable<long>
{
public static readonly long[] Value=A199525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199525.Bytes);
public long this[int i]=>Value[i];

public static A199525Inst Instance=new A199525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199526
{
public static readonly long[] Value={ 1L,8L,60L,464L,3734L,30484L,252154L,2105064L,17701326L,149708146L,1272108368L,10851700690L,92875809416L,797134845184L,6858361265978L,59133629878796L,510815878314050L,4419961056157870L,38301854208088068L,332355738077962284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199526Inst : IEnumerable<long>
{
public static readonly long[] Value=A199526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199526.Bytes);
public long this[int i]=>Value[i];

public static A199526Inst Instance=new A199526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199527
{
public static readonly long[] Value={ 1L,10L,90L,860L,8470L,84852L,860854L,8815392L,90927530L,943302430L,9832131238L,102882332054L,1080105471952L,11371474312404L,120012768975248L,1269300095287288L,13449845528174042L,142756162602411602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199527Inst : IEnumerable<long>
{
public static readonly long[] Value=A199527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199527.Bytes);
public long this[int i]=>Value[i];

public static A199527Inst Instance=new A199527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199528
{
public static readonly long[] Value={ 1L,12L,126L,1432L,16682L,197962L,2378412L,28844590L,352355640L,4329146404L,53439881140L,662256127274L,8234161234932L,102668802658902L,1283270183281782L,16074009129375488L,201718956009659774L,2535677513896048744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199528Inst : IEnumerable<long>
{
public static readonly long[] Value=A199528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199528.Bytes);
public long this[int i]=>Value[i];

public static A199528Inst Instance=new A199528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199529
{
public static readonly long[] Value={ 1L,14L,168L,2212L,29750L,407946L,5662636L,79345982L,1119873360L,15897133212L,226731289148L,3246399497138L,46636478912912L,671855095655758L,9702557118121642L,140418234266554336L,2035998107250999870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199529Inst : IEnumerable<long>
{
public static readonly long[] Value=A199529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199529.Bytes);
public long this[int i]=>Value[i];

public static A199529Inst Instance=new A199529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199530
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,6L,1L,6L,18L,12L,1L,8L,36L,72L,32L,1L,10L,60L,212L,320L,80L,1L,12L,90L,464L,1324L,1414L,200L,1L,14L,126L,860L,3734L,8342L,6346L,520L,1L,16L,168L,1432L,8470L,30484L,53302L,28766L,1336L,1L,18L,216L,2212L,16682L,84852L,252154L,343710L,131246L,3472L,1L,20L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199530Inst : IEnumerable<long>
{
public static readonly long[] Value=A199530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199530.Bytes);
public long this[int i]=>Value[i];

public static A199530Inst Instance=new A199530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199531
{
public static readonly long[] Value={ 12L,72L,212L,464L,860L,1432L,2212L,3232L,4524L,6120L,8052L,10352L,13052L,16184L,19780L,23872L,28492L,33672L,39444L,45840L,52892L,60632L,69092L,78304L,88300L,99112L,110772L,123312L,136764L,151160L,166532L,182912L,200332L,218824L,238420L,259152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199531Inst : IEnumerable<long>
{
public static readonly long[] Value=A199531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199531.Bytes);
public long this[int i]=>Value[i];

public static A199531Inst Instance=new A199531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199532
{
public static readonly long[] Value={ 32L,320L,1324L,3734L,8470L,16682L,29750L,49284L,77124L,115340L,166232L,232330L,316394L,421414L,550610L,707432L,895560L,1118904L,1381604L,1688030L,2042782L,2450690L,2916814L,3446444L,4045100L,4718532L,5472720L,6313874L,7248434L,8283070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199532Inst : IEnumerable<long>
{
public static readonly long[] Value=A199532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199532.Bytes);
public long this[int i]=>Value[i];

public static A199532Inst Instance=new A199532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199533
{
public static readonly long[] Value={ 80L,1414L,8342L,30484L,84852L,197962L,407946L,766664L,1341816L,2219054L,3504094L,5324828L,7833436L,11208498L,15657106L,21416976L,28758560L,37987158L,49445030L,63513508L,80615108L,101215642L,125826330L,155005912L,189362760L,229556990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199533Inst : IEnumerable<long>
{
public static readonly long[] Value=A199533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199533.Bytes);
public long this[int i]=>Value[i];

public static A199533Inst Instance=new A199533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199534
{
public static readonly long[] Value={ 200L,6346L,53302L,252154L,860854L,2378412L,5662636L,12071420L,23627580L,43207238L,74751754L,123503206L,196263418L,301676536L,450535152L,656109976L,934503056L,1305024546L,1790593022L,2418159346L,3219154078L,4229958436L,5492398804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199534Inst : IEnumerable<long>
{
public static readonly long[] Value=A199534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199534.Bytes);
public long this[int i]=>Value[i];

public static A199534Inst Instance=new A199534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199535
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,6L,5L,11L,9L,10L,8L,18L,15L,17L,12L,13L,29L,24L,27L,19L,14L,21L,47L,39L,44L,31L,23L,16L,34L,76L,63L,71L,50L,37L,25L,20L,55L,123L,102L,115L,81L,60L,41L,33L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199535Inst : IEnumerable<long>
{
public static readonly long[] Value=A199535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199535.Bytes);
public long this[int i]=>Value[i];

public static A199535Inst Instance=new A199535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199536
{
public static readonly long[] Value={ 1L,4L,6L,10L,12L,14L,16L,20L,22L,26L,28L,30L,32L,36L,38L,40L,42L,46L,48L,52L,54L,56L,58L,62L,64L,68L,70L,72L,74L,78L,80L,82L,84L,88L,90L,94L,96L,98L,100L,104L,106L,108L,110L,114L,116L,120L,122L,124L,126L,130L,132L,136L,138L,140L,142L,146L,148L,150L,152L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199536Inst : IEnumerable<long>
{
public static readonly long[] Value=A199536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199536.Bytes);
public long this[int i]=>Value[i];

public static A199536Inst Instance=new A199536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199537
{
public static readonly long[] Value={ 2L,7L,9L,17L,19L,23L,25L,33L,35L,43L,45L,49L,51L,59L,61L,65L,67L,75L,77L,85L,87L,91L,93L,101L,103L,111L,113L,117L,119L,127L,129L,133L,135L,143L,145L,153L,155L,159L,161L,169L,171L,175L,177L,185L,187L,195L,197L,201L,203L,211L,213L,221L,223L,227L,229L,237L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199537Inst : IEnumerable<long>
{
public static readonly long[] Value=A199537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199537.Bytes);
public long this[int i]=>Value[i];

public static A199537Inst Instance=new A199537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199538
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,1L,3L,4L,2L,5L,1L,6L,3L,7L,4L,2L,5L,8L,1L,9L,6L,3L,7L,10L,4L,11L,2L,12L,5L,13L,8L,1L,9L,14L,6L,15L,3L,16L,7L,17L,10L,4L,11L,18L,2L,19L,12L,5L,13L,20L,8L,21L,1L,22L,9L,23L,14L,6L,15L,24L,3L,25L,16L,7L,17L,26L,10L,27L,4L,28L,11L,29L,18L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199538Inst : IEnumerable<long>
{
public static readonly long[] Value=A199538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199538.Bytes);
public long this[int i]=>Value[i];

public static A199538Inst Instance=new A199538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199539
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,2L,5L,2L,1L,3L,1L,6L,1L,3L,1L,2L,4L,2L,1L,7L,1L,2L,4L,2L,1L,3L,1L,5L,1L,3L,1L,2L,8L,2L,1L,3L,1L,5L,1L,3L,1L,2L,4L,2L,1L,6L,1L,2L,4L,2L,1L,3L,1L,9L,1L,3L,1L,2L,4L,2L,1L,6L,1L,2L,4L,2L,1L,3L,1L,5L,1L,3L,1L,2L,7L,2L,1L,3L,1L,5L,1L,3L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199539Inst : IEnumerable<long>
{
public static readonly long[] Value=A199539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199539.Bytes);
public long this[int i]=>Value[i];

public static A199539Inst Instance=new A199539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199540
{
public static readonly BigInteger[] Value={ 1L,1L,4L,24L,192L,-320L,-138240L,-10214400L,-669204480L,-43782488064L,-2628064051200L,-91419903590400L,14288196206592000L,5367226212019077120L,BigInteger.Parse("1259862249808204922880"),BigInteger.Parse("257126813359346810880000"),BigInteger.Parse("46529454048255997378560000") };
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
public class A199540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199540Inst Instance=new A199540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199541
{
public static readonly BigInteger[] Value={ 1L,-2L,3L,96L,-820L,5760L,189000L,1720320L,1632960L,1393459200L,430921814400L,2452488192000L,204726089018880L,8224795200061440L,10001273371689600000UL,BigInteger.Parse("47991858533498880000"),BigInteger.Parse("-33369402947130515865600") };
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
public class A199541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199541Inst Instance=new A199541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199542
{
public static readonly long[] Value={ 1L,0L,1L,-12L,0L,1L,0L,-96L,0L,1L,-320L,0L,-400L,0L,1L,0L,8640L,0L,-1200L,0L,1L,-53760L,0L,188160L,0L,-2940L,0L,1L,0L,4300800L,0L,1630720L,0L,-6272L,0L,1L,-27869184L,0L,3870720L,0L,9144576L,0L,-12096L,0L,1L,0L,4877107200L,0L,-1548288000L,0L,38949120L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199542Inst : IEnumerable<long>
{
public static readonly long[] Value=A199542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199542.Bytes);
public long this[int i]=>Value[i];

public static A199542Inst Instance=new A199542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199543
{
public static readonly BigInteger[] Value={ 1L,2L,9L,59L,462L,4011L,37253L,362877L,3662590L,38001809L,403118473L,4354812135L,47769686769L,530912871966L,5968147436150L,67766781921248L,776407323511627L,8967754230210974L,104351087348892229L,1222602680134075216L,14416253295843685409UL,BigInteger.Parse("171018068867340738997") };
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
public class A199543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199543Inst Instance=new A199543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199544
{
public static readonly BigInteger[] Value={ 1L,3L,23L,271L,3876L,61809L,1057324L,18999550L,354126904L,6790260312L,133193201306L,2661966127599L,54046089492190L,1112240570177203L,23161201079072759L,487383250552812705L,10353102122586909350UL,BigInteger.Parse("221819714961583800336"),BigInteger.Parse("4790442570608936302923") };
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
public class A199544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199544Inst Instance=new A199544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199545
{
public static readonly long[] Value={ 24L,48L,48L,72L,96L,96L,120L,240L,240L,288L,480L,576L,576L,1152L,1440L,1440L,2880L,2880L,5760L,5760L,6912L,17280L,34560L,34560L,69120L,414720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199545Inst : IEnumerable<long>
{
public static readonly long[] Value=A199545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199545.Bytes);
public long this[int i]=>Value[i];

public static A199545Inst Instance=new A199545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199546
{
public static readonly long[] Value={ 144L,144L,288L,360L,360L,360L,720L,720L,720L,720L,1800L,3456L,8640L,8640L,8640L,8640L,17280L,17280L,21600L,43200L,43200L,207360L,207360L,518400L,518400L,1036800L,12441600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199546Inst : IEnumerable<long>
{
public static readonly long[] Value=A199546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199546.Bytes);
public long this[int i]=>Value[i];

public static A199546Inst Instance=new A199546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199547
{
public static readonly long[] Value={ 26861L,616841L,616849L,616877L,616897L,616909L,616933L,616943L,616951L,616961L,616991L,616997L,616999L,617011L,617269L,617273L,617293L,617311L,617327L,617333L,617339L,617341L,617359L,617369L,617401L,617429L,617453L,617521L,617537L,617689L,617693L,617699L,617717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199547Inst : IEnumerable<long>
{
public static readonly long[] Value=A199547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199547.Bytes);
public long this[int i]=>Value[i];

public static A199547Inst Instance=new A199547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199548
{
public static readonly BigInteger[] Value={ 1L,3L,14L,88L,650L,5257L,45017L,401010L,3677344L,34481492L,329082191L,3186043296L,31214870385L,308901931412L,3083146893716L,31001118379636L,313734072027372L,3193097704841990L,32662597147529218L,335616736745247652L,3462524444288857191L,BigInteger.Parse("35853293611333010079") };
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
public class A199548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199548Inst Instance=new A199548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199549
{
public static readonly long[] Value={ 576L,576L,1152L,1440L,1440L,2880L,2880L,2880L,2880L,7200L,13824L,34560L,34560L,34560L,34560L,69120L,69120L,172800L,172800L,86400L,829440L,829440L,2073600L,2073600L,4147200L,49766400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199549Inst : IEnumerable<long>
{
public static readonly long[] Value=A199549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199549.Bytes);
public long this[int i]=>Value[i];

public static A199549Inst Instance=new A199549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199550
{
public static readonly long[] Value={ 1L,4L,7L,6L,6L,8L,4L,3L,3L,7L,3L,5L,7L,8L,6L,9L,9L,4L,7L,0L,8L,9L,2L,3L,5L,5L,8L,5L,3L,7L,3L,8L,8L,9L,8L,3L,8L,6L,5L,5L,1L,6L,8L,9L,3L,0L,9L,8L,5L,5L,2L,6L,9L,8L,4L,4L,6L,4L,4L,0L,3L,1L,4L,7L,6L,2L,1L,6L,9L,8L,0L,0L,2L,9L,1L,8L,8L,2L,1L,5L,2L,8L,5L,9L,7L,1L,4L,7L,2L,4L,0L,8L,4L,4L,0L,2L,6L,9L,5L,7L,9L,8L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199550Inst : IEnumerable<long>
{
public static readonly long[] Value=A199550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199550.Bytes);
public long this[int i]=>Value[i];

public static A199550Inst Instance=new A199550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199551
{
public static readonly long[] Value={ 1L,2L,33L,51L,69L,105L,195L,250L,294L,1250L,4913L,9583L,13778L,48778L,65603L,83521L,111265L,228939L,651695L,984150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199551Inst : IEnumerable<long>
{
public static readonly long[] Value=A199551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199551.Bytes);
public long this[int i]=>Value[i];

public static A199551Inst Instance=new A199551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199552
{
public static readonly long[] Value={ 5L,33L,257L,2049L,16385L,131073L,1048577L,8388609L,67108865L,536870913L,4294967297L,34359738369L,274877906945L,2199023255553L,17592186044417L,140737488355329L,1125899906842625L,9007199254740993L,72057594037927937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199552Inst : IEnumerable<long>
{
public static readonly long[] Value=A199552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199552.Bytes);
public long this[int i]=>Value[i];

public static A199552Inst Instance=new A199552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199553
{
public static readonly long[] Value={ 6L,41L,321L,2561L,20481L,163841L,1310721L,10485761L,83886081L,671088641L,5368709121L,42949672961L,343597383681L,2748779069441L,21990232555521L,175921860444161L,1407374883553281L,11258999068426241L,90071992547409921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199553Inst : IEnumerable<long>
{
public static readonly long[] Value=A199553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199553.Bytes);
public long this[int i]=>Value[i];

public static A199553Inst Instance=new A199553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199554
{
public static readonly long[] Value={ 7L,49L,385L,3073L,24577L,196609L,1572865L,12582913L,100663297L,805306369L,6442450945L,51539607553L,412316860417L,3298534883329L,26388279066625L,211106232532993L,1688849860263937L,13510798882111489L,108086391056891905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199554Inst : IEnumerable<long>
{
public static readonly long[] Value=A199554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199554.Bytes);
public long this[int i]=>Value[i];

public static A199554Inst Instance=new A199554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199555
{
public static readonly long[] Value={ 8L,57L,449L,3585L,28673L,229377L,1835009L,14680065L,117440513L,939524097L,7516192769L,60129542145L,481036337153L,3848290697217L,30786325577729L,246290604621825L,1970324836974593L,15762598695796737L,126100789566373889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199555Inst : IEnumerable<long>
{
public static readonly long[] Value=A199555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199555.Bytes);
public long this[int i]=>Value[i];

public static A199555Inst Instance=new A199555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199556
{
public static readonly long[] Value={ 10L,73L,577L,4609L,36865L,294913L,2359297L,18874369L,150994945L,1207959553L,9663676417L,77309411329L,618475290625L,4947802324993L,39582418599937L,316659348799489L,2533274790395905L,20266198323167233L,162129586585337857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199556Inst : IEnumerable<long>
{
public static readonly long[] Value=A199556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199556.Bytes);
public long this[int i]=>Value[i];

public static A199556Inst Instance=new A199556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199557
{
public static readonly long[] Value={ 11L,81L,641L,5121L,40961L,327681L,2621441L,20971521L,167772161L,1342177281L,10737418241L,85899345921L,687194767361L,5497558138881L,43980465111041L,351843720888321L,2814749767106561L,22517998136852481L,180143985094819841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199557Inst : IEnumerable<long>
{
public static readonly long[] Value=A199557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199557.Bytes);
public long this[int i]=>Value[i];

public static A199557Inst Instance=new A199557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199558
{
public static readonly long[] Value={ 12L,89L,705L,5633L,45057L,360449L,2883585L,23068673L,184549377L,1476395009L,11811160065L,94489280513L,755914244097L,6047313952769L,48378511622145L,387028092977153L,3096224743817217L,24769797950537729L,198158383604301825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199558Inst : IEnumerable<long>
{
public static readonly long[] Value=A199558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199558.Bytes);
public long this[int i]=>Value[i];

public static A199558Inst Instance=new A199558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199559
{
public static readonly long[] Value={ 3L,19L,163L,1459L,13123L,118099L,1062883L,9565939L,86093443L,774840979L,6973568803L,62762119219L,564859072963L,5083731656659L,45753584909923L,411782264189299L,3706040377703683L,33354363399333139L,300189270593998243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199559Inst : IEnumerable<long>
{
public static readonly long[] Value=A199559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199559.Bytes);
public long this[int i]=>Value[i];

public static A199559Inst Instance=new A199559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199560
{
public static readonly long[] Value={ 2L,14L,122L,1094L,9842L,88574L,797162L,7174454L,64570082L,581130734L,5230176602L,47071589414L,423644304722L,3812798742494L,34315188682442L,308836698141974L,2779530283277762L,25015772549499854L,225141952945498682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199560Inst : IEnumerable<long>
{
public static readonly long[] Value=A199560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199560.Bytes);
public long this[int i]=>Value[i];

public static A199560Inst Instance=new A199560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199561
{
public static readonly long[] Value={ 4L,28L,244L,2188L,19684L,177148L,1594324L,14348908L,129140164L,1162261468L,10460353204L,94143178828L,847288609444L,7625597484988L,68630377364884L,617673396283948L,5559060566555524L,50031545098999708L,450283905890997364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199561Inst : IEnumerable<long>
{
public static readonly long[] Value=A199561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199561.Bytes);
public long this[int i]=>Value[i];

public static A199561Inst Instance=new A199561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199562
{
public static readonly long[] Value={ 5L,37L,325L,2917L,26245L,236197L,2125765L,19131877L,172186885L,1549681957L,13947137605L,125524238437L,1129718145925L,10167463313317L,91507169819845L,823564528378597L,7412080755407365L,66708726798666277L,600378541187996485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199562Inst : IEnumerable<long>
{
public static readonly long[] Value=A199562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199562.Bytes);
public long this[int i]=>Value[i];

public static A199562Inst Instance=new A199562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199563
{
public static readonly long[] Value={ 6L,46L,406L,3646L,32806L,295246L,2657206L,23914846L,215233606L,1937102446L,17433922006L,156905298046L,1412147682406L,12709329141646L,114383962274806L,1029455660473246L,9265100944259206L,83385908498332846L,750473176484995606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199563Inst : IEnumerable<long>
{
public static readonly long[] Value=A199563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199563.Bytes);
public long this[int i]=>Value[i];

public static A199563Inst Instance=new A199563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199564
{
public static readonly long[] Value={ 7L,55L,487L,4375L,39367L,354295L,3188647L,28697815L,258280327L,2324522935L,20920706407L,188286357655L,1694577218887L,15251194969975L,137260754729767L,1235346792567895L,11118121133111047L,100063090197999415L,900567811781994727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199564Inst : IEnumerable<long>
{
public static readonly long[] Value=A199564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199564.Bytes);
public long this[int i]=>Value[i];

public static A199564Inst Instance=new A199564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199565
{
public static readonly long[] Value={ 2L,16L,142L,1276L,11482L,103336L,930022L,8370196L,75331762L,677985856L,6101872702L,54916854316L,494251688842L,4448265199576L,40034386796182L,360309481165636L,3242785330490722L,29185067974416496L,262665611769748462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199565Inst : IEnumerable<long>
{
public static readonly long[] Value=A199565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199565.Bytes);
public long this[int i]=>Value[i];

public static A199565Inst Instance=new A199565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199566
{
public static readonly long[] Value={ 4L,32L,284L,2552L,22964L,206672L,1860044L,16740392L,150663524L,1355971712L,12203745404L,109833708632L,988503377684L,8896530399152L,80068773592364L,720618962331272L,6485570660981444L,58370135948832992L,525331223539496924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199566Inst : IEnumerable<long>
{
public static readonly long[] Value=A199566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199566.Bytes);
public long this[int i]=>Value[i];

public static A199566Inst Instance=new A199566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199567
{
public static readonly long[] Value={ 8L,64L,568L,5104L,45928L,413344L,3720088L,33480784L,301327048L,2711943424L,24407490808L,219667417264L,1977006755368L,17793060798304L,160137547184728L,1441237924662544L,12971141321962888L,116740271897665984L,1050662447078993848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199567Inst : IEnumerable<long>
{
public static readonly long[] Value=A199567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199567.Bytes);
public long this[int i]=>Value[i];

public static A199567Inst Instance=new A199567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199568
{
public static readonly long[] Value={ 1L,0L,1L,-6L,0L,1L,0L,-48L,0L,1L,280L,0L,-200L,0L,1L,0L,8640L,0L,-600L,0L,1L,-52080L,0L,99960L,0L,-1470L,0L,1L,0L,-4300800L,0L,689920L,0L,-3136L,0L,1L,27651456L,0L,-110557440L,0L,3429216L,0L,-6048L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199568Inst : IEnumerable<long>
{
public static readonly long[] Value=A199568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199568.Bytes);
public long this[int i]=>Value[i];

public static A199568Inst Instance=new A199568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199569
{
public static readonly BigInteger[] Value={ 1L,1L,4L,30L,384L,7480L,207360L,7780080L,380190720L,23481311616L,1789201612800L,164904696633600L,18084647927808000L,2327418985883397120L,BigInteger.Parse("347368297708734382080"),BigInteger.Parse("59514548453599599360000"),BigInteger.Parse("11601363342443780505600000"),BigInteger.Parse("2552998389393196650531225600") };
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
public class A199569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199569Inst Instance=new A199569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199570
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,3L,2L,3L,1L,4L,1L,4L,2L,4L,1L,4L,3L,4L,1L,4L,3L,4L,2L,4L,3L,4L,1L,5L,1L,5L,2L,5L,1L,5L,3L,5L,1L,5L,3L,5L,2L,5L,3L,5L,1L,5L,4L,5L,1L,5L,4L,5L,2L,5L,4L,5L,1L,5L,4L,5L,3L,5L,4L,5L,1L,5L,4L,5L,3L,5L,4L,5L,2L,5L,4L,5L,3L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199570Inst : IEnumerable<long>
{
public static readonly long[] Value=A199570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199570.Bytes);
public long this[int i]=>Value[i];

public static A199570Inst Instance=new A199570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199571
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,4L,0L,1L,0L,0L,2L,0L,1L,0L,16L,2L,2L,0L,1L,0L,0L,6L,0L,2L,0L,1L,0L,64L,10L,8L,0L,2L,0L,1L,0L,0L,22L,0L,6L,0L,2L,0L,1L,0L,256L,42L,32L,2L,6L,0L,2L,0L,1L,0L,0L,86L,0L,20L,0L,6L,0L,2L,0L,1L,0L,1024L,170L,128L,14L,22L,0L,6L,0L,2L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199571Inst : IEnumerable<long>
{
public static readonly long[] Value=A199571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199571.Bytes);
public long this[int i]=>Value[i];

public static A199571Inst Instance=new A199571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199572
{
public static readonly long[] Value={ 1L,0L,4L,0L,16L,0L,64L,0L,256L,0L,1024L,0L,4096L,0L,16384L,0L,65536L,0L,262144L,0L,1048576L,0L,4194304L,0L,16777216L,0L,67108864L,0L,268435456L,0L,1073741824L,0L,4294967296L,0L,17179869184L,0L,68719476736L,0L,274877906944L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199572Inst : IEnumerable<long>
{
public static readonly long[] Value=A199572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199572.Bytes);
public long this[int i]=>Value[i];

public static A199572Inst Instance=new A199572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199573
{
public static readonly long[] Value={ 1L,0L,2L,0L,8L,0L,32L,0L,128L,0L,512L,0L,2048L,0L,8192L,0L,32768L,0L,131072L,0L,524288L,0L,2097152L,0L,8388608L,0L,33554432L,0L,134217728L,0L,536870912L,0L,2147483648L,0L,8589934592L,0L,34359738368L,0L,137438953472L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199573Inst : IEnumerable<long>
{
public static readonly long[] Value=A199573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199573.Bytes);
public long this[int i]=>Value[i];

public static A199573Inst Instance=new A199573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199574
{
public static readonly BigInteger[] Value={ 1L,2L,6L,40L,544L,16640L,1050624L,134250496L,34360262656L,17592202821632L,18014399046352896L,BigInteger.Parse("36893488181778841600"),BigInteger.Parse("151115727454027670093824"),BigInteger.Parse("1237940039285661749875834880"),BigInteger.Parse("20282409603651706452744270249984") };
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
public class A199574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199574Inst Instance=new A199574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199575
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,16L,18L,21L,23L,26L,30L,34L,38L,43L,48L,55L,62L,70L,79L,89L,100L,113L,127L,144L,162L,183L,207L,233L,263L,296L,334L,377L,426L,480L,541L,611L,689L,777L,876L,989L,1115L,1258L,1418L,1600L,1804L,2035L,2295L,2589L,2920L,3293L,3714L,4189L,4725L,5329L,6010L,6778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199575Inst : IEnumerable<long>
{
public static readonly long[] Value=A199575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199575.Bytes);
public long this[int i]=>Value[i];

public static A199575Inst Instance=new A199575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199576
{
public static readonly BigInteger[] Value={ 1L,2L,8L,54L,528L,7690L,159360L,4158014L,124676608L,4135694994L,150596213760L,6039479167942L,267570859708416L,13065427748191130L,697795440530685952L,BigInteger.Parse("40363581479632997070"),BigInteger.Parse("2506569447568159211520"),BigInteger.Parse("166039728985388864259874"),BigInteger.Parse("11683091140202632175419392") };
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
public class A199576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199576Inst Instance=new A199576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199577
{
public static readonly long[] Value={ 1L,-3L,1L,11L,-8L,1L,-50L,58L,-15L,1L,274L,-444L,177L,-24L,1L,-1764L,3708L,-2016L,416L,-35L,1L,13068L,-33984L,23544L,-6560L,835L,-48L,1L,-109584L,341136L,-288360L,101560L,-17370L,1506L,-63L,1L,1026576L,-3733920L,3736440L,-1595040L,343410L,-39900L,2513L,-80L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199577Inst : IEnumerable<long>
{
public static readonly long[] Value=A199577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199577.Bytes);
public long this[int i]=>Value[i];

public static A199577Inst Instance=new A199577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199578
{
public static readonly BigInteger[] Value={ 1L,-2L,4L,-6L,-16L,310L,-3144L,28826L,-260000L,2345094L,-20901880L,176084986L,-1216168944L,1862029910L,186232275544L,-6005924996070L,144514137334976L,-3177768345524954L,67577079942366120L,-1420754665075404166L,BigInteger.Parse("29799354626069718640") };
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
public class A199578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199578Inst Instance=new A199578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199579
{
public static readonly long[] Value={ 1L,4L,28L,232L,2056L,18784L,174112L,1625152L,15220288L,142777600L,1340416768L,12588825088L,118252556800L,1110898849792L,10436554713088L,98050271875072L,921180638875648L,8654518327066624L,81309636020912128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199579Inst : IEnumerable<long>
{
public static readonly long[] Value=A199579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199579.Bytes);
public long this[int i]=>Value[i];

public static A199579Inst Instance=new A199579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199580
{
public static readonly long[] Value={ 0L,2L,1L,-3L,0L,1L,8L,-4L,-4L,1L,-30L,30L,15L,-10L,1L,144L,-216L,-48L,84L,-18L,1L,-840L,1680L,0L,-700L,245L,-28L,1L,5760L,-14400L,2880L,6000L,-3120L,552L,-40L,1L,-45360L,136080L,-52920L,-52920L,39690L,-9702L,1071L,-54L,1L,403200L,-1411200L,806400L,470400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199580Inst : IEnumerable<long>
{
public static readonly long[] Value=A199580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199580.Bytes);
public long this[int i]=>Value[i];

public static A199580Inst Instance=new A199580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199581
{
public static readonly long[] Value={ 1L,2L,7L,29L,107L,431L,1619L,6079L,22937L,87083L,332393L,1273541L,4896103L,18877711L,72968563L,282664351L,1097088989L,4265342057L,16608401041L,64758466127L,252814859149L,988089813541L,3865761355523L,15138431958437L,59333638261529L,232737382916429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199581Inst : IEnumerable<long>
{
public static readonly long[] Value=A199581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199581.Bytes);
public long this[int i]=>Value[i];

public static A199581Inst Instance=new A199581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199582
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,13L,29L,53L,107L,211L,431L,809L,1619L,3037L,6079L,11467L,22937L,43541L,87083L,166183L,332393L,636761L,1273541L,2448049L,4896103L,9438851L,18877711L,36484271L,72968563L,141332173L,282664351L,548544487L,1097088989L,2132671027L,4265342057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199582Inst : IEnumerable<long>
{
public static readonly long[] Value=A199582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199582.Bytes);
public long this[int i]=>Value[i];

public static A199582Inst Instance=new A199582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199583
{
public static readonly BigInteger[] Value={ 2L,2L,3L,2L,5L,70L,7L,2L,3L,33L,11L,1155L,13L,78L,26L,2L,17L,2156564410L,19L,6006L,26L,114L,23L,2156564410L,5L,33L,3L,1365L,29L,110L,31L,2L,62L,15L,201L,2156564410L,37L,30L,14L,BigInteger.Parse("961380175077106319535"),41L,1385670L,43L,2805L,26L,266L,47L,BigInteger.Parse("961380175077106319535") };
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
public class A199583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199583Inst Instance=new A199583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199584
{
public static readonly long[] Value={ 0L,0L,0L,5L,35L,11L,495L,2645L,40637L,30867L,1260454L,2631033L,66043942L,64295478L,2600316008L,3797601337L,124025248853L,133588278925L,5375377028818L,6829626340182L,252066556346402L,284362587554599L,11455309274558540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199584Inst : IEnumerable<long>
{
public static readonly long[] Value=A199584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199584.Bytes);
public long this[int i]=>Value[i];

public static A199584Inst Instance=new A199584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199585
{
public static readonly BigInteger[] Value={ 0L,0L,20L,23L,1951L,60323L,592219L,3399003L,220861580L,6086397307L,79879768821L,386032959689L,29317433209618L,852122544867919L,11206152487777257L,56509336646678083L,4391723268352660596L,BigInteger.Parse("130483481066218119340") };
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
public class A199585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199585Inst Instance=new A199585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199586
{
public static readonly long[] Value={ 0L,5L,23L,2943L,69023L,4748991L,207722398L,12106398432L,637249804809L,36336881030430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199586Inst : IEnumerable<long>
{
public static readonly long[] Value=A199586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199586.Bytes);
public long this[int i]=>Value[i];

public static A199586Inst Instance=new A199586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199587
{
public static readonly long[] Value={ 0L,35L,1951L,69023L,46969504L,10056342898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199587Inst : IEnumerable<long>
{
public static readonly long[] Value=A199587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199587.Bytes);
public long this[int i]=>Value[i];

public static A199587Inst Instance=new A199587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199588
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,20L,5L,0L,0L,35L,23L,23L,35L,0L,0L,11L,1951L,2943L,1951L,11L,0L,1L,495L,60323L,69023L,69023L,60323L,495L,1L,4L,2645L,592219L,4748991L,46969504L,4748991L,592219L,2645L,4L,6L,40637L,3399003L,207722398L,10056342898L,10056342898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199588Inst : IEnumerable<long>
{
public static readonly long[] Value=A199588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199588.Bytes);
public long this[int i]=>Value[i];

public static A199588Inst Instance=new A199588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199589
{
public static readonly long[] Value={ 1L,1L,3L,7L,1L,5L,8L,0L,4L,2L,6L,0L,3L,2L,5L,7L,6L,1L,2L,8L,3L,7L,6L,6L,7L,9L,5L,1L,9L,2L,0L,0L,9L,8L,7L,6L,2L,5L,8L,1L,3L,6L,0L,3L,9L,4L,2L,2L,9L,9L,0L,6L,5L,8L,5L,9L,6L,2L,8L,8L,7L,9L,6L,4L,9L,4L,4L,2L,5L,1L,0L,6L,6L,5L,6L,8L,5L,0L,9L,4L,5L,4L,9L,8L,5L,3L,1L,6L,7L,7L,7L,6L,7L,8L,9L,9L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199589Inst : IEnumerable<long>
{
public static readonly long[] Value=A199589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199589.Bytes);
public long this[int i]=>Value[i];

public static A199589Inst Instance=new A199589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199590
{
public static readonly long[] Value={ 2L,5L,7L,7L,7L,2L,8L,0L,1L,0L,3L,1L,4L,4L,0L,8L,4L,4L,7L,2L,9L,4L,4L,9L,3L,9L,7L,2L,7L,0L,6L,3L,5L,8L,2L,2L,7L,0L,8L,9L,4L,4L,1L,2L,5L,7L,0L,0L,9L,7L,7L,3L,1L,9L,7L,8L,2L,3L,1L,4L,6L,3L,9L,3L,9L,5L,8L,0L,8L,6L,4L,4L,5L,7L,6L,7L,3L,0L,5L,3L,7L,0L,8L,5L,8L,2L,4L,9L,9L,8L,0L,0L,3L,1L,0L,1L,5L,7L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199590Inst : IEnumerable<long>
{
public static readonly long[] Value=A199590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199590.Bytes);
public long this[int i]=>Value[i];

public static A199590Inst Instance=new A199590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199591
{
public static readonly BigInteger[] Value={ 6L,26L,626L,390626L,152587890626L,BigInteger.Parse("23283064365386962890626"),BigInteger.Parse("542101086242752217003726400434970855712890626") };
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
public class A199591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199591Inst Instance=new A199591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199592
{
public static readonly BigInteger[] Value={ 12L,122L,14642L,214358882L,45949729863572162L,BigInteger.Parse("2111377674535255285545615254209922"),BigInteger.Parse("4457915684525902395869512133369841539490161434991526715513934826242") };
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
public class A199592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199592Inst Instance=new A199592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199593
{
public static readonly long[] Value={ 9L,12L,17L,19L,22L,26L,29L,31L,32L,39L,40L,41L,42L,45L,48L,49L,52L,54L,57L,59L,62L,63L,68L,69L,70L,72L,73L,74L,79L,82L,83L,85L,87L,89L,92L,96L,97L,99L,100L,101L,102L,107L,108L,109L,110L,112L,114L,115L,119L,121L,122L,124L,126L,129L,131L,132L,135L,136L,138L,139L,142L,143L,146L,149L,151L,152L,157L,158L,159L,161L,162L,165L,166L,169L,171L,172L,173L,176L,177L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199593Inst : IEnumerable<long>
{
public static readonly long[] Value=A199593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199593.Bytes);
public long this[int i]=>Value[i];

public static A199593Inst Instance=new A199593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199594
{
public static readonly long[] Value={ 0L,0L,0L,2L,3L,5L,10L,18L,31L,56L,100L,177L,315L,561L,997L,1773L,3154L,5609L,9975L,17741L,31552L,56114L,99798L,177489L,315660L,561395L,998430L,1775687L,3158023L,5616480L,9988795L,17764868L,31594456L,56190096L,99932940L,177728697L,316086865L,562154046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199594Inst : IEnumerable<long>
{
public static readonly long[] Value=A199594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199594.Bytes);
public long this[int i]=>Value[i];

public static A199594Inst Instance=new A199594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199595
{
public static readonly long[] Value={ 1L,4L,9L,11L,14L,18L,21L,23L,24L,31L,32L,33L,34L,37L,40L,41L,44L,46L,49L,51L,54L,55L,60L,61L,62L,64L,65L,66L,71L,74L,75L,77L,79L,81L,84L,88L,89L,91L,92L,93L,94L,99L,100L,101L,102L,104L,106L,107L,111L,113L,114L,116L,118L,121L,123L,124L,127L,128L,130L,131L,134L,135L,138L,141L,143L,144L,149L,150L,151L,153L,154L,157L,158L,161L,163L,164L,165L,168L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199595Inst : IEnumerable<long>
{
public static readonly long[] Value=A199595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199595.Bytes);
public long this[int i]=>Value[i];

public static A199595Inst Instance=new A199595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199596
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,3L,1L,1L,2L,2L,1L,3L,2L,1L,2L,2L,1L,2L,1L,1L,3L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,3L,1L,1L,3L,1L,1L,2L,2L,1L,3L,2L,0L,2L,2L,1L,3L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,1L,3L,2L,1L,2L,1L,1L,3L,2L,1L,2L,2L,1L,2L,2L,0L,3L,2L,1L,3L,1L,1L,3L,2L,1L,2L,1L,1L,2L,2L,1L,3L,2L,1L,2L,1L,1L,3L,2L,1L,2L,1L,1L,2L,2L,1L,3L,2L,1L,3L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199596Inst : IEnumerable<long>
{
public static readonly long[] Value=A199596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199596.Bytes);
public long this[int i]=>Value[i];

public static A199596Inst Instance=new A199596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199597
{
public static readonly long[] Value={ 1L,1L,8L,8L,1L,8L,5L,1L,3L,4L,4L,5L,1L,4L,3L,8L,8L,0L,3L,2L,1L,7L,8L,1L,0L,9L,7L,2L,9L,0L,7L,6L,5L,2L,5L,9L,7L,3L,8L,3L,2L,4L,2L,5L,6L,1L,2L,8L,4L,1L,4L,7L,1L,9L,4L,1L,8L,2L,3L,9L,5L,2L,8L,3L,2L,3L,4L,1L,8L,6L,0L,9L,9L,1L,3L,4L,2L,2L,9L,6L,0L,3L,4L,2L,6L,1L,8L,0L,9L,6L,9L,1L,8L,3L,4L,8L,8L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199597Inst : IEnumerable<long>
{
public static readonly long[] Value=A199597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199597.Bytes);
public long this[int i]=>Value[i];

public static A199597Inst Instance=new A199597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199598
{
public static readonly long[] Value={ 1L,8L,3L,8L,2L,4L,3L,4L,5L,4L,9L,7L,1L,0L,3L,9L,6L,4L,2L,3L,1L,9L,1L,9L,8L,8L,7L,1L,2L,2L,9L,0L,1L,0L,2L,1L,4L,4L,8L,8L,8L,0L,1L,5L,0L,0L,3L,3L,4L,7L,8L,3L,4L,0L,0L,4L,6L,9L,5L,6L,8L,7L,1L,4L,5L,3L,1L,4L,7L,2L,6L,3L,3L,5L,8L,4L,1L,5L,2L,5L,0L,7L,2L,3L,8L,7L,0L,9L,1L,9L,6L,4L,2L,7L,5L,3L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199598Inst : IEnumerable<long>
{
public static readonly long[] Value=A199598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199598.Bytes);
public long this[int i]=>Value[i];

public static A199598Inst Instance=new A199598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199599
{
public static readonly long[] Value={ 2L,1L,2L,5L,9L,8L,6L,5L,4L,9L,9L,7L,7L,7L,0L,3L,0L,4L,2L,5L,1L,2L,1L,6L,2L,5L,5L,7L,8L,8L,0L,4L,3L,1L,8L,4L,7L,2L,1L,0L,0L,7L,9L,4L,1L,4L,4L,8L,1L,7L,8L,7L,8L,7L,7L,6L,3L,0L,8L,5L,5L,5L,2L,6L,5L,9L,0L,7L,3L,8L,7L,4L,2L,9L,2L,8L,5L,4L,4L,8L,2L,8L,5L,5L,0L,2L,4L,6L,7L,5L,6L,2L,4L,7L,5L,7L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199599Inst : IEnumerable<long>
{
public static readonly long[] Value=A199599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199599.Bytes);
public long this[int i]=>Value[i];

public static A199599Inst Instance=new A199599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199600
{
public static readonly long[] Value={ 6L,5L,5L,5L,3L,8L,2L,9L,9L,5L,3L,9L,6L,9L,4L,5L,0L,7L,1L,8L,5L,8L,6L,6L,2L,4L,6L,3L,4L,3L,9L,9L,3L,0L,7L,3L,9L,2L,4L,2L,1L,1L,6L,4L,8L,9L,3L,5L,7L,8L,0L,4L,1L,0L,7L,7L,0L,6L,4L,5L,5L,0L,1L,6L,5L,7L,7L,8L,0L,5L,4L,3L,6L,1L,0L,6L,4L,1L,7L,4L,5L,9L,5L,2L,4L,0L,1L,1L,8L,4L,7L,9L,0L,9L,2L,2L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199600Inst : IEnumerable<long>
{
public static readonly long[] Value=A199600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199600.Bytes);
public long this[int i]=>Value[i];

public static A199600Inst Instance=new A199600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199601
{
public static readonly long[] Value={ 2L,3L,0L,6L,4L,7L,8L,3L,4L,7L,1L,0L,4L,8L,0L,2L,6L,8L,7L,7L,0L,5L,9L,0L,6L,4L,3L,9L,6L,6L,9L,2L,0L,9L,2L,4L,6L,6L,5L,8L,7L,8L,6L,5L,4L,2L,2L,7L,8L,7L,0L,3L,5L,8L,3L,1L,2L,8L,1L,4L,4L,5L,4L,6L,8L,0L,1L,3L,9L,1L,8L,3L,1L,5L,7L,4L,3L,0L,8L,2L,4L,7L,9L,5L,1L,8L,9L,0L,3L,4L,5L,1L,0L,4L,7L,2L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199601Inst : IEnumerable<long>
{
public static readonly long[] Value=A199601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199601.Bytes);
public long this[int i]=>Value[i];

public static A199601Inst Instance=new A199601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199602
{
public static readonly long[] Value={ 2L,5L,4L,0L,0L,9L,2L,4L,1L,8L,0L,4L,2L,7L,4L,7L,3L,6L,3L,8L,5L,0L,7L,9L,4L,3L,9L,3L,9L,9L,4L,8L,3L,4L,3L,7L,4L,4L,6L,3L,1L,5L,7L,7L,5L,4L,4L,3L,1L,5L,3L,2L,7L,4L,5L,9L,6L,7L,9L,8L,4L,0L,7L,8L,5L,5L,7L,7L,9L,6L,6L,2L,5L,6L,4L,7L,9L,3L,4L,9L,9L,2L,1L,3L,9L,2L,7L,0L,4L,1L,6L,8L,5L,5L,2L,6L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199602Inst : IEnumerable<long>
{
public static readonly long[] Value=A199602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199602.Bytes);
public long this[int i]=>Value[i];

public static A199602Inst Instance=new A199602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199603
{
public static readonly long[] Value={ 1L,1L,7L,0L,1L,2L,0L,9L,5L,0L,0L,0L,2L,6L,2L,6L,0L,5L,3L,7L,0L,6L,0L,4L,3L,0L,1L,1L,8L,5L,8L,9L,7L,1L,0L,8L,1L,9L,9L,9L,4L,0L,2L,0L,2L,5L,9L,5L,5L,5L,1L,5L,6L,4L,7L,4L,1L,6L,8L,1L,9L,7L,4L,4L,3L,7L,0L,0L,2L,4L,9L,2L,4L,7L,7L,1L,7L,3L,0L,8L,4L,2L,6L,4L,7L,9L,9L,0L,8L,0L,1L,1L,0L,0L,7L,0L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199603Inst : IEnumerable<long>
{
public static readonly long[] Value=A199603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199603.Bytes);
public long this[int i]=>Value[i];

public static A199603Inst Instance=new A199603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199604
{
public static readonly long[] Value={ 2L,9L,3L,8L,1L,0L,0L,3L,9L,3L,9L,7L,0L,8L,1L,1L,8L,0L,7L,6L,5L,8L,1L,3L,6L,4L,7L,8L,4L,2L,5L,9L,1L,2L,9L,5L,9L,6L,7L,0L,2L,1L,8L,6L,1L,7L,3L,2L,2L,3L,1L,0L,1L,7L,8L,4L,6L,7L,1L,7L,6L,3L,8L,5L,3L,5L,4L,6L,7L,8L,5L,9L,2L,9L,2L,8L,3L,6L,7L,4L,6L,4L,2L,0L,8L,0L,2L,3L,0L,3L,2L,4L,8L,7L,2L,5L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199604Inst : IEnumerable<long>
{
public static readonly long[] Value=A199604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199604.Bytes);
public long this[int i]=>Value[i];

public static A199604Inst Instance=new A199604Inst();

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