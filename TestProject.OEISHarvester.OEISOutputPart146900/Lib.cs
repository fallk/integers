using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A176205
{
public static readonly long[] Value={ 1L,3L,8L,9L,23L,24L,49L,27L,68L,69L,139L,72L,169L,147L,272L,81L,203L,204L,409L,207L,484L,417L,767L,216L,529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176205Inst : IEnumerable<long>
{
public static readonly long[] Value=A176205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176205.Bytes);
public long this[int i]=>Value[i];

public static A176205Inst Instance=new A176205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176206
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,1L,4L,3L,2L,2L,1L,1L,1L,5L,4L,3L,3L,2L,2L,2L,1L,1L,1L,1L,1L,6L,5L,4L,4L,3L,3L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,7L,6L,5L,5L,4L,4L,4L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176206Inst : IEnumerable<long>
{
public static readonly long[] Value=A176206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176206.Bytes);
public long this[int i]=>Value[i];

public static A176206Inst Instance=new A176206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176207
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,1L,2L,3L,1L,4L,1L,3L,1L,1L,2L,2L,1L,2L,1L,1L,2L,4L,2L,3L,1L,1L,5L,1L,4L,1L,1L,3L,2L,1L,3L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176207Inst : IEnumerable<long>
{
public static readonly long[] Value=A176207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176207.Bytes);
public long this[int i]=>Value[i];

public static A176207Inst Instance=new A176207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176208
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,3L,4L,2L,3L,2L,3L,3L,4L,4L,5L,2L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,5L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176208Inst : IEnumerable<long>
{
public static readonly long[] Value=A176208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176208.Bytes);
public long this[int i]=>Value[i];

public static A176208Inst Instance=new A176208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176209
{
public static readonly long[] Value={ 8L,13L,20L,24L,29L,33L,34L,40L,44L,45L,53L,57L,58L,62L,68L,72L,73L,77L,80L,85L,89L,90L,94L,97L,104L,108L,109L,113L,116L,120L,125L,129L,130L,134L,137L,141L,148L,152L,153L,157L,160L,164L,168L,173L,177L,178L,182L,185L,189L,193L,194L,200L,204L,205L,209L,212L,216L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176209Inst : IEnumerable<long>
{
public static readonly long[] Value=A176209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176209.Bytes);
public long this[int i]=>Value[i];

public static A176209Inst Instance=new A176209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176210
{
public static readonly long[] Value={ 3L,4L,5L,6L,3L,3L,7L,4L,3L,8L,5L,3L,4L,4L,9L,6L,3L,5L,4L,3L,3L,3L,10L,7L,3L,6L,4L,5L,5L,4L,3L,3L,11L,8L,3L,7L,4L,6L,5L,5L,3L,3L,4L,4L,3L,12L,9L,3L,8L,4L,7L,5L,6L,6L,6L,3L,3L,5L,4L,3L,4L,4L,4L,3L,3L,3L,3L,13L,10L,3L,9L,4L,8L,5L,7L,6L,7L,3L,3L,6L,4L,3L,5L,5L,3L,5L,4L,4L,4L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176210Inst : IEnumerable<long>
{
public static readonly long[] Value=A176210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176210.Bytes);
public long this[int i]=>Value[i];

public static A176210Inst Instance=new A176210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176211
{
public static readonly long[] Value={ 6L,9L,13L,20L,31L,36L,49L,54L,78L,78L,81L,117L,120L,125L,169L,180L,186L,201L,216L,260L,279L,294L,324L,324L,400L,403L,441L,468L,468L,486L,523L,620L,637L,702L,702L,720L,729L,750L,845L,961L,980L,1014L,1014L,1053L,1080L,1116L,1125L,1206L,1296L,1366L,1519L,1521L,1560L,1560L,1620L,1625L,1674L,1764L,1809L,1944L,1944L,2197L,2209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176211Inst : IEnumerable<long>
{
public static readonly long[] Value=A176211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176211.Bytes);
public long this[int i]=>Value[i];

public static A176211Inst Instance=new A176211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176212
{
public static readonly long[] Value={ 6L,9L,13L,20L,31L,36L,49L,54L,78L,81L,117L,120L,125L,169L,180L,186L,201L,216L,260L,279L,294L,324L,400L,403L,441L,468L,486L,523L,620L,637L,702L,720L,729L,750L,845L,961L,980L,1014L,1053L,1080L,1116L,1125L,1206L,1296L,1366L,1519L,1521L,1560L,1620L,1625L,1674L,1764L,1809L,1944L,2197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176212Inst : IEnumerable<long>
{
public static readonly long[] Value=A176212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176212.Bytes);
public long this[int i]=>Value[i];

public static A176212Inst Instance=new A176212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176213
{
public static readonly long[] Value={ 4L,4L,4L,9L,4L,8L,9L,7L,4L,2L,7L,8L,3L,1L,7L,8L,0L,9L,8L,1L,9L,7L,2L,8L,4L,0L,7L,4L,7L,0L,5L,8L,9L,1L,3L,9L,1L,9L,6L,5L,9L,4L,7L,4L,8L,0L,6L,5L,6L,6L,7L,0L,1L,2L,8L,4L,3L,2L,6L,9L,2L,5L,6L,7L,2L,5L,0L,9L,6L,0L,3L,7L,7L,4L,5L,7L,3L,1L,5L,0L,2L,6L,5L,3L,9L,8L,5L,9L,4L,3L,3L,1L,0L,4L,6L,4L,0L,2L,3L,4L,8L,1L,8L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176213Inst : IEnumerable<long>
{
public static readonly long[] Value=A176213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176213.Bytes);
public long this[int i]=>Value[i];

public static A176213Inst Instance=new A176213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176214
{
public static readonly long[] Value={ 4L,3L,0L,9L,4L,0L,1L,0L,7L,6L,7L,5L,8L,5L,0L,3L,0L,5L,8L,0L,3L,6L,5L,9L,5L,1L,2L,2L,0L,0L,7L,8L,2L,9L,8L,2L,2L,5L,9L,0L,4L,0L,7L,0L,0L,5L,0L,8L,0L,5L,0L,7L,5L,0L,4L,0L,7L,4L,4L,0L,9L,3L,0L,5L,9L,3L,5L,9L,1L,0L,6L,8L,9L,2L,1L,1L,7L,3L,3L,3L,8L,2L,7L,7L,4L,8L,6L,1L,5L,8L,2L,3L,4L,2L,9L,9L,8L,1L,0L,0L,9L,0L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176214Inst : IEnumerable<long>
{
public static readonly long[] Value=A176214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176214.Bytes);
public long this[int i]=>Value[i];

public static A176214Inst Instance=new A176214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176215
{
public static readonly long[] Value={ 4L,1L,9L,0L,8L,9L,0L,2L,3L,0L,0L,2L,0L,6L,6L,4L,4L,5L,3L,8L,2L,7L,8L,7L,9L,1L,3L,1L,2L,0L,3L,2L,0L,8L,5L,3L,5L,8L,1L,0L,9L,7L,8L,7L,7L,9L,9L,9L,1L,9L,3L,3L,0L,1L,6L,9L,0L,7L,5L,7L,7L,7L,9L,8L,9L,2L,9L,9L,7L,3L,1L,0L,8L,4L,9L,0L,8L,9L,0L,9L,3L,5L,2L,0L,3L,4L,3L,3L,7L,4L,4L,6L,5L,5L,4L,8L,2L,5L,0L,3L,0L,5L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176215Inst : IEnumerable<long>
{
public static readonly long[] Value=A176215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176215.Bytes);
public long this[int i]=>Value[i];

public static A176215Inst Instance=new A176215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176216
{
public static readonly long[] Value={ 4L,1L,6L,0L,2L,4L,6L,8L,9L,9L,4L,6L,9L,2L,8L,6L,7L,4L,3L,6L,5L,5L,3L,2L,2L,4L,7L,8L,6L,9L,5L,9L,9L,8L,8L,8L,5L,9L,0L,1L,7L,3L,4L,7L,6L,9L,0L,1L,9L,4L,4L,8L,8L,4L,9L,9L,0L,3L,7L,8L,4L,7L,9L,9L,2L,6L,9L,8L,7L,2L,4L,5L,9L,2L,8L,1L,3L,4L,8L,1L,2L,3L,8L,0L,0L,1L,2L,0L,3L,0L,2L,2L,0L,1L,8L,7L,0L,0L,7L,8L,5L,5L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176216Inst : IEnumerable<long>
{
public static readonly long[] Value=A176216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176216.Bytes);
public long this[int i]=>Value[i];

public static A176216Inst Instance=new A176216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176217
{
public static readonly long[] Value={ 4L,1L,3L,8L,0L,8L,9L,9L,3L,5L,2L,9L,9L,3L,9L,5L,0L,7L,7L,4L,7L,6L,4L,2L,7L,8L,4L,7L,0L,3L,8L,0L,2L,8L,1L,7L,2L,4L,3L,2L,0L,1L,1L,3L,1L,8L,7L,3L,0L,7L,0L,1L,1L,1L,2L,1L,7L,3L,5L,6L,8L,8L,3L,8L,4L,6L,8L,5L,9L,1L,5L,1L,7L,8L,8L,9L,6L,7L,9L,4L,4L,4L,5L,5L,8L,1L,7L,7L,0L,8L,2L,9L,6L,8L,2L,1L,6L,8L,9L,8L,0L,0L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176217Inst : IEnumerable<long>
{
public static readonly long[] Value=A176217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176217.Bytes);
public long this[int i]=>Value[i];

public static A176217Inst Instance=new A176217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176218
{
public static readonly long[] Value={ 4L,1L,2L,1L,3L,2L,0L,3L,4L,3L,5L,5L,9L,6L,4L,2L,5L,7L,3L,2L,0L,2L,5L,3L,3L,0L,8L,6L,3L,1L,4L,5L,4L,7L,1L,1L,7L,8L,5L,4L,5L,0L,7L,8L,1L,3L,0L,6L,5L,4L,2L,2L,1L,0L,9L,7L,6L,5L,0L,1L,9L,6L,0L,6L,9L,8L,6L,0L,9L,8L,7L,1L,7L,6L,9L,3L,1L,6L,0L,5L,5L,8L,2L,7L,5L,5L,8L,1L,3L,0L,1L,4L,9L,1L,4L,6L,2L,3L,5L,9L,1L,0L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176218Inst : IEnumerable<long>
{
public static readonly long[] Value=A176218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176218.Bytes);
public long this[int i]=>Value[i];

public static A176218Inst Instance=new A176218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176219
{
public static readonly long[] Value={ 4L,1L,0L,8L,1L,8L,5L,1L,0L,6L,7L,7L,8L,9L,1L,9L,5L,5L,4L,6L,6L,5L,9L,2L,9L,0L,2L,9L,6L,2L,1L,8L,1L,2L,3L,5L,5L,8L,1L,3L,0L,3L,6L,7L,5L,9L,5L,5L,0L,1L,4L,4L,5L,5L,1L,2L,3L,8L,3L,3L,6L,5L,6L,8L,5L,2L,8L,3L,9L,6L,2L,9L,2L,4L,2L,6L,1L,5L,8L,8L,1L,4L,2L,2L,9L,4L,9L,8L,7L,3L,8L,9L,1L,9L,5L,3L,3L,5L,3L,0L,1L,2L,4L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176219Inst : IEnumerable<long>
{
public static readonly long[] Value=A176219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176219.Bytes);
public long this[int i]=>Value[i];

public static A176219Inst Instance=new A176219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176220
{
public static readonly long[] Value={ 4L,0L,9L,7L,6L,1L,7L,6L,9L,6L,3L,4L,0L,3L,0L,3L,0L,9L,3L,9L,8L,2L,9L,0L,7L,0L,2L,7L,3L,5L,9L,8L,7L,5L,1L,9L,6L,9L,5L,0L,5L,4L,3L,7L,1L,5L,3L,6L,3L,0L,0L,7L,9L,6L,9L,7L,5L,1L,5L,1L,1L,5L,2L,7L,1L,6L,0L,0L,1L,1L,8L,5L,1L,0L,0L,2L,2L,0L,1L,3L,8L,2L,8L,3L,8L,7L,7L,0L,5L,7L,7L,8L,6L,6L,3L,8L,8L,8L,3L,5L,6L,0L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176220Inst : IEnumerable<long>
{
public static readonly long[] Value=A176220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176220.Bytes);
public long this[int i]=>Value[i];

public static A176220Inst Instance=new A176220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176221
{
public static readonly long[] Value={ 1L,0L,4L,8L,8L,0L,8L,8L,4L,8L,1L,7L,0L,1L,5L,1L,5L,4L,6L,9L,9L,1L,4L,5L,3L,5L,1L,3L,6L,7L,9L,9L,3L,7L,5L,9L,8L,4L,7L,5L,2L,7L,1L,8L,5L,7L,6L,8L,1L,5L,0L,3L,9L,8L,4L,8L,7L,5L,7L,5L,5L,7L,6L,3L,5L,8L,0L,0L,0L,5L,9L,2L,5L,5L,0L,1L,1L,0L,0L,6L,9L,1L,4L,1L,9L,3L,8L,5L,2L,8L,8L,9L,3L,3L,1L,9L,4L,4L,1L,7L,8L,0L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176221Inst : IEnumerable<long>
{
public static readonly long[] Value=A176221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176221.Bytes);
public long this[int i]=>Value[i];

public static A176221Inst Instance=new A176221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176222
{
public static readonly long[] Value={ 0L,3L,5L,10L,14L,21L,27L,36L,44L,55L,65L,78L,90L,105L,119L,136L,152L,171L,189L,210L,230L,253L,275L,300L,324L,351L,377L,406L,434L,465L,495L,528L,560L,595L,629L,666L,702L,741L,779L,820L,860L,903L,945L,990L,1034L,1081L,1127L,1176L,1224L,1275L,1325L,1378L,1430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176222Inst : IEnumerable<long>
{
public static readonly long[] Value=A176222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176222.Bytes);
public long this[int i]=>Value[i];

public static A176222Inst Instance=new A176222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176223
{
public static readonly long[] Value={ 2L,5L,8L,17L,23L,35L,38L,47L,50L,68L,77L,80L,107L,110L,113L,140L,152L,170L,218L,227L,233L,245L,248L,278L,287L,317L,320L,332L,353L,365L,380L,392L,407L,437L,458L,467L,485L,500L,518L,542L,575L,590L,602L,605L,623L,635L,638L,710L,740L,743L,770L,803L,827L,842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176223Inst : IEnumerable<long>
{
public static readonly long[] Value=A176223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176223.Bytes);
public long this[int i]=>Value[i];

public static A176223Inst Instance=new A176223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176224
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,-2L,-2L,1L,1L,-6L,-8L,-6L,1L,1L,-14L,-20L,-20L,-14L,1L,1L,-30L,-44L,-48L,-44L,-30L,1L,1L,-62L,-92L,-104L,-104L,-92L,-62L,1L,1L,-126L,-188L,-216L,-224L,-216L,-188L,-126L,1L,1L,-254L,-380L,-440L,-464L,-464L,-440L,-380L,-254L,1L,1L,-510L,-764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176224Inst : IEnumerable<long>
{
public static readonly long[] Value=A176224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176224.Bytes);
public long this[int i]=>Value[i];

public static A176224Inst Instance=new A176224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176225
{
public static readonly long[] Value={ 1L,1L,1L,1L,-3L,1L,1L,-15L,-15L,1L,1L,-51L,-63L,-51L,1L,1L,-159L,-207L,-207L,-159L,1L,1L,-483L,-639L,-675L,-639L,-483L,1L,1L,-1455L,-1935L,-2079L,-2079L,-1935L,-1455L,1L,1L,-4371L,-5823L,-6291L,-6399L,-6291L,-5823L,-4371L,1L,1L,-13119L,-17487L,-18927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176225Inst : IEnumerable<long>
{
public static readonly long[] Value=A176225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176225.Bytes);
public long this[int i]=>Value[i];

public static A176225Inst Instance=new A176225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176226
{
public static readonly long[] Value={ 1L,1L,1L,1L,-15L,1L,1L,-95L,-95L,1L,1L,-495L,-575L,-495L,1L,1L,-2495L,-2975L,-2975L,-2495L,1L,1L,-12495L,-14975L,-15375L,-14975L,-12495L,1L,1L,-62495L,-74975L,-77375L,-77375L,-74975L,-62495L,1L,1L,-312495L,-374975L,-387375L,-389375L,-387375L,-374975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176226Inst : IEnumerable<long>
{
public static readonly long[] Value=A176226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176226.Bytes);
public long this[int i]=>Value[i];

public static A176226Inst Instance=new A176226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176227
{
public static readonly long[] Value={ 1L,1L,1L,1L,-8L,1L,1L,-44L,-44L,1L,1L,-188L,-224L,-188L,1L,1L,-764L,-944L,-944L,-764L,1L,1L,-3068L,-3824L,-3968L,-3824L,-3068L,1L,1L,-12284L,-15344L,-16064L,-16064L,-15344L,-12284L,1L,1L,-49148L,-61424L,-64448L,-65024L,-64448L,-61424L,-49148L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176227Inst : IEnumerable<long>
{
public static readonly long[] Value=A176227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176227.Bytes);
public long this[int i]=>Value[i];

public static A176227Inst Instance=new A176227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176228
{
public static readonly long[] Value={ 2L,3L,3L,3L,4L,3L,4L,6L,6L,4L,5L,8L,10L,8L,5L,7L,11L,16L,16L,11L,7L,10L,15L,24L,29L,24L,15L,10L,15L,21L,35L,49L,49L,35L,21L,15L,23L,30L,50L,78L,92L,78L,50L,30L,23L,36L,44L,71L,119L,161L,161L,119L,71L,44L,36L,57L,66L,101L,176L,266L,308L,266L,176L,101L,66L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176228Inst : IEnumerable<long>
{
public static readonly long[] Value=A176228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176228.Bytes);
public long this[int i]=>Value[i];

public static A176228Inst Instance=new A176228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176229
{
public static readonly long[] Value={ 7L,13L,19L,37L,67L,109L,127L,307L,379L,487L,499L,769L,877L,937L,1009L,1297L,1567L,2269L,2389L,2659L,2857L,3037L,3187L,3457L,3847L,3907L,3919L,4447L,4789L,4969L,4999L,5077L,5167L,5347L,5737L,6007L,6997L,7039L,7669L,8689L,8779L,9199L,10597L,11467L,11827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176229Inst : IEnumerable<long>
{
public static readonly long[] Value=A176229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176229.Bytes);
public long this[int i]=>Value[i];

public static A176229Inst Instance=new A176229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176230
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,1L,15L,45L,15L,1L,105L,420L,210L,28L,1L,945L,4725L,3150L,630L,45L,1L,10395L,62370L,51975L,13860L,1485L,66L,1L,135135L,945945L,945945L,315315L,45045L,3003L,91L,1L,2027025L,16216200L,18918900L,7567560L,1351350L,120120L,5460L,120L,1L,34459425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176230Inst : IEnumerable<long>
{
public static readonly long[] Value=A176230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176230.Bytes);
public long this[int i]=>Value[i];

public static A176230Inst Instance=new A176230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176231
{
public static readonly long[] Value={ 1L,-1L,1L,3L,-6L,1L,-15L,45L,-15L,1L,105L,-420L,210L,-28L,1L,-945L,4725L,-3150L,630L,-45L,1L,10395L,-62370L,51975L,-13860L,1485L,-66L,1L,-135135L,945945L,-945945L,315315L,-45045L,3003L,-91L,1L,2027025L,-16216200L,18918900L,-7567560L,1351350L,-120120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176231Inst : IEnumerable<long>
{
public static readonly long[] Value=A176231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176231.Bytes);
public long this[int i]=>Value[i];

public static A176231Inst Instance=new A176231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176232
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,459L,55099L,39671739L,199945619659L,8061807424322619L,BigInteger.Parse("2925468678338137602379"),BigInteger.Parse("10615940739961495538937237819"),BigInteger.Parse("423754383328897950597328272711061579"),BigInteger.Parse("202979027621555455188781938315330372976764219") };
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
public class A176232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176232Inst Instance=new A176232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176233
{
public static readonly BigInteger[] Value={ 1L,17L,747L,66305L,9828200L,2185188193L,679919101029L,281956264747009L,150277722869740455L,BigInteger.Parse("100090028003500150001"),BigInteger.Parse("81458362232421250207824"),BigInteger.Parse("79539026883848399173231873"),BigInteger.Parse("91771878445323959814042316673") };
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
public class A176233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176233Inst Instance=new A176233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176234
{
public static readonly long[] Value={ 2L,3L,4L,21L,26L,27L,33L,35L,38L,46L,58L,62L,74L,475L,605L,1083L,1719L,2007L,2151L,2169L,2259L,2313L,2421L,2431L,2439L,2493L,2529L,2547L,2637L,2737L,2763L,2799L,2979L,3123L,3303L,3357L,3367L,3451L,3619L,3681L,3698L,4255L,4465L,4625L,5035L,5125L,5185L,5695L,6205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176234Inst : IEnumerable<long>
{
public static readonly long[] Value=A176234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176234.Bytes);
public long this[int i]=>Value[i];

public static A176234Inst Instance=new A176234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176235
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,14L,15L,19L,21L,25L,26L,28L,30L,32L,33L,37L,38L,42L,44L,48L,49L,51L,53L,57L,58L,60L,61L,65L,66L,72L,73L,75L,77L,79L,81L,83L,84L,96L,97L,99L,100L,104L,106L,114L,116L,120L,121L,125L,126L,128L,129L,133L,134L,138L,140L,148L,150L,152L,154L,164L,165L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176235Inst : IEnumerable<long>
{
public static readonly long[] Value=A176235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176235.Bytes);
public long this[int i]=>Value[i];

public static A176235Inst Instance=new A176235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176236
{
public static readonly long[] Value={ 1L,2L,3L,17L,19L,23L,25L,35L,37L,40L,42L,46L,48L,55L,57L,63L,65L,68L,72L,86L,96L,102L,104L,108L,114L,118L,120L,123L,125L,131L,133L,136L,138L,142L,148L,156L,164L,167L,175L,185L,187L,191L,197L,200L,202L,205L,207L,210L,212L,216L,218L,225L,231L,234L,244L,254L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176236Inst : IEnumerable<long>
{
public static readonly long[] Value=A176236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176236.Bytes);
public long this[int i]=>Value[i];

public static A176236Inst Instance=new A176236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176237
{
public static readonly long[] Value={ 3L,6L,7L,9L,11L,12L,13L,14L,15L,18L,19L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,33L,35L,36L,37L,38L,39L,41L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,66L,67L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,82L,83L,86L,87L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176237Inst : IEnumerable<long>
{
public static readonly long[] Value=A176237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176237.Bytes);
public long this[int i]=>Value[i];

public static A176237Inst Instance=new A176237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176238
{
public static readonly long[] Value={ 4L,9L,16L,24L,25L,30L,36L,40L,42L,49L,54L,56L,64L,66L,70L,78L,81L,88L,100L,102L,104L,105L,110L,114L,121L,128L,130L,135L,136L,138L,144L,152L,154L,165L,169L,170L,174L,182L,184L,186L,189L,190L,192L,195L,196L,222L,225L,230L,231L,232L,238L,240L,246L,248L,250L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176238Inst : IEnumerable<long>
{
public static readonly long[] Value=A176238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176238.Bytes);
public long this[int i]=>Value[i];

public static A176238Inst Instance=new A176238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176239
{
public static readonly long[] Value={ 0L,-1L,1L,-1L,0L,2L,0L,1L,-2L,2L,0L,-5L,0L,0L,1L,-3L,5L,-5L,0L,14L,0L,0L,0L,1L,-4L,9L,-14L,14L,0L,-42L,0L,0L,0L,0L,1L,-5L,14L,-28L,42L,-42L,0L,132L,0L,0L,0L,0L,0L,1L,-6L,20L,-48L,90L,-132L,132L,0L,-429L,0L,0L,0L,0L,0L,0L,1L,-7L,27L,-75L,165L,-297L,429L,-429L,0L,1430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176239Inst : IEnumerable<long>
{
public static readonly long[] Value=A176239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176239.Bytes);
public long this[int i]=>Value[i];

public static A176239Inst Instance=new A176239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176240
{
public static readonly long[] Value={ 3L,37L,37L,61L,61L,61L,71L,89L,89L,107L,113L,139L,139L,181L,199L,223L,227L,227L,269L,283L,293L,313L,313L,331L,347L,347L,349L,373L,373L,379L,401L,433L,433L,487L,487L,487L,503L,521L,521L,523L,557L,569L,569L,593L,647L,653L,653L,743L,757L,761L,773L,787L,797L,809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176240Inst : IEnumerable<long>
{
public static readonly long[] Value=A176240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176240.Bytes);
public long this[int i]=>Value[i];

public static A176240Inst Instance=new A176240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176241
{
public static readonly long[] Value={ 1L,20L,21L,32L,33L,34L,35L,44L,45L,54L,56L,66L,67L,86L,90L,106L,107L,108L,122L,130L,134L,140L,141L,147L,154L,155L,156L,169L,170L,172L,182L,189L,190L,210L,211L,212L,220L,224L,225L,226L,242L,248L,249L,256L,279L,280L,281L,312L,316L,318L,321L,324L,329L,338L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176241Inst : IEnumerable<long>
{
public static readonly long[] Value=A176241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176241.Bytes);
public long this[int i]=>Value[i];

public static A176241Inst Instance=new A176241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176242
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,21L,13L,1L,1L,85L,125L,29L,1L,1L,341L,1085L,589L,61L,1L,1L,1365L,9021L,10509L,2541L,125L,1L,1L,5461L,73533L,177165L,91821L,10541L,253L,1L,1L,21845L,593725L,2908173L,3115437L,766445L,42925L,509L,1L,1L,87381L,4771645L,47124493L,102602157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176242Inst : IEnumerable<long>
{
public static readonly long[] Value=A176242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176242.Bytes);
public long this[int i]=>Value[i];

public static A176242Inst Instance=new A176242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176243
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,91L,37L,1L,1L,820L,1090L,118L,1L,1L,7381L,30250L,10648L,361L,1L,1L,66430L,824131L,892738L,98371L,1090L,1L,1L,597871L,22317967L,73135909L,24796891L,892981L,3277L,1L,1L,5380840L,603182980L,5946326596L,6098780422L,675780040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176243Inst : IEnumerable<long>
{
public static readonly long[] Value=A176243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176243.Bytes);
public long this[int i]=>Value[i];

public static A176243Inst Instance=new A176243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176244
{
public static readonly long[] Value={ 1L,1L,1L,1L,17L,1L,1L,273L,81L,1L,1L,4369L,5457L,337L,1L,1L,69905L,353617L,91729L,1361L,1L,1L,1118481L,22701393L,23836241L,1485393L,5457L,1L,1L,17895697L,1454007633L,6124779089L,1544878673L,23837265L,21841L,1L,1L,286331153L,93074384209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176244Inst : IEnumerable<long>
{
public static readonly long[] Value=A176244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176244.Bytes);
public long this[int i]=>Value[i];

public static A176244Inst Instance=new A176244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176245
{
public static readonly long[] Value={ 3L,37L,160001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176245Inst : IEnumerable<long>
{
public static readonly long[] Value=A176245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176245.Bytes);
public long this[int i]=>Value[i];

public static A176245Inst Instance=new A176245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176246
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,1L,3L,5L,1L,5L,3L,1L,3L,5L,5L,1L,5L,3L,1L,5L,3L,5L,7L,3L,1L,3L,1L,3L,13L,3L,5L,1L,9L,1L,5L,5L,3L,5L,5L,1L,9L,1L,3L,1L,11L,11L,3L,1L,3L,5L,1L,9L,5L,5L,5L,1L,5L,3L,1L,9L,13L,3L,1L,3L,13L,5L,9L,1L,3L,5L,7L,5L,5L,3L,5L,7L,3L,7L,9L,1L,9L,1L,5L,3L,5L,7L,3L,1L,3L,11L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176246Inst : IEnumerable<long>
{
public static readonly long[] Value=A176246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176246.Bytes);
public long this[int i]=>Value[i];

public static A176246Inst Instance=new A176246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176247
{
public static readonly long[] Value={ 2L,5L,17L,23L,47L,107L,113L,227L,233L,317L,353L,467L,743L,827L,1013L,1163L,1223L,1283L,1493L,1697L,1823L,1877L,2063L,2333L,2543L,2957L,3323L,3467L,3767L,3797L,4013L,4397L,4523L,5297L,5393L,5507L,5693L,5717L,5897L,5927L,6053L,6317L,6473L,6737L,6947L,6977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176247Inst : IEnumerable<long>
{
public static readonly long[] Value=A176247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176247.Bytes);
public long this[int i]=>Value[i];

public static A176247Inst Instance=new A176247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176248
{
public static readonly long[] Value={ 3L,1L,1L,15L,45L,3L,99L,45L,51L,141L,153L,177L,411L,45L,45L,267L,237L,75L,75L,207L,111L,111L,123L,159L,57L,375L,1419L,45L,291L,321L,489L,585L,525L,1623L,579L,45L,27L,1293L,1059L,255L,2265L,33L,465L,165L,405L,315L,315L,117L,411L,1725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176248Inst : IEnumerable<long>
{
public static readonly long[] Value=A176248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176248.Bytes);
public long this[int i]=>Value[i];

public static A176248Inst Instance=new A176248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176249
{
public static readonly long[] Value={ 3L,1L,5L,1L,71L,63L,5L,31L,35L,469L,209L,15L,33L,9L,105L,607L,1727L,259L,87L,247L,413L,81L,227L,271L,27L,153L,27L,205L,551L,435L,1175L,1195L,141L,109L,609L,19L,377L,1183L,705L,127L,27L,721L,449L,1815L,1143L,1803L,627L,1027L,845L,573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176249Inst : IEnumerable<long>
{
public static readonly long[] Value=A176249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176249.Bytes);
public long this[int i]=>Value[i];

public static A176249Inst Instance=new A176249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176250
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,11L,11L,12L,12L,79L,79L,347L,347L,5541L,5541L,-9206L,-9206L,3307613L,3307613L,-78393123L,-78393123L,932396477L,932396477L,-127419293864L,-127419293864L,6013748071263L,6013748071263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176250Inst : IEnumerable<long>
{
public static readonly long[] Value=A176250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176250.Bytes);
public long this[int i]=>Value[i];

public static A176250Inst Instance=new A176250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176251
{
public static readonly long[] Value={ 5L,23L,41L,113L,131L,311L,2111L,10211L,20021L,101021L,101111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176251Inst : IEnumerable<long>
{
public static readonly long[] Value=A176251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176251.Bytes);
public long this[int i]=>Value[i];

public static A176251Inst Instance=new A176251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176252
{
public static readonly long[] Value={ 7L,43L,61L,151L,223L,241L,313L,331L,421L,1033L,1123L,1213L,1231L,1321L,2113L,2131L,2221L,2311L,3121L,4111L,5011L,10141L,11113L,11131L,11311L,12211L,14011L,21121L,21211L,22111L,30211L,101221L,102121L,111121L,111211L,112111L,131011L,310111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176252Inst : IEnumerable<long>
{
public static readonly long[] Value=A176252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176252.Bytes);
public long this[int i]=>Value[i];

public static A176252Inst Instance=new A176252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176253
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,19L,21L,22L,24L,26L,27L,28L,30L,31L,32L,38L,42L,43L,44L,45L,46L,49L,68L,69L,78L,79L,81L,86L,88L,89L,90L,94L,97L,102L,116L,117L,137L,161L,164L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176253Inst : IEnumerable<long>
{
public static readonly long[] Value=A176253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176253.Bytes);
public long this[int i]=>Value[i];

public static A176253Inst Instance=new A176253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176254
{
public static readonly long[] Value={ 17L,53L,71L,233L,251L,431L,521L,1061L,1151L,1223L,1511L,2141L,2213L,2411L,3023L,3041L,3221L,4013L,4211L,6011L,10133L,10313L,10331L,11213L,11321L,11411L,12041L,12113L,13121L,20123L,20231L,21221L,23021L,30113L,31121L,41201L,50111L,100043L,101141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176254Inst : IEnumerable<long>
{
public static readonly long[] Value=A176254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176254.Bytes);
public long this[int i]=>Value[i];

public static A176254Inst Instance=new A176254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176255
{
public static readonly long[] Value={ 35L,55L,95L,115L,155L,175L,215L,235L,247L,275L,295L,299L,323L,335L,355L,391L,395L,403L,415L,455L,475L,515L,527L,535L,559L,575L,595L,611L,635L,655L,695L,715L,731L,755L,767L,775L,799L,815L,835L,871L,875L,895L,899L,923L,935L,955L,995L,1003L,1015L,1027L,1055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176255Inst : IEnumerable<long>
{
public static readonly long[] Value=A176255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176255.Bytes);
public long this[int i]=>Value[i];

public static A176255Inst Instance=new A176255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176256
{
public static readonly long[] Value={ 9L,21L,33L,45L,49L,57L,69L,77L,81L,93L,105L,117L,121L,129L,133L,141L,153L,161L,165L,177L,189L,201L,209L,213L,217L,225L,237L,249L,253L,261L,273L,285L,297L,301L,309L,321L,329L,333L,341L,345L,357L,361L,369L,381L,393L,405L,413L,417L,429L,437L,441L,453L,465L,469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176256Inst : IEnumerable<long>
{
public static readonly long[] Value=A176256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176256.Bytes);
public long this[int i]=>Value[i];

public static A176256Inst Instance=new A176256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176257
{
public static readonly long[] Value={ 15L,39L,51L,75L,87L,91L,111L,119L,123L,135L,143L,159L,183L,187L,195L,203L,219L,255L,259L,267L,287L,291L,303L,319L,327L,339L,351L,371L,375L,407L,411L,427L,435L,447L,451L,455L,459L,471L,507L,511L,519L,543L,551L,555L,579L,583L,591L,595L,615L,623L,663L,667L,671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176257Inst : IEnumerable<long>
{
public static readonly long[] Value=A176257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176257.Bytes);
public long this[int i]=>Value[i];

public static A176257Inst Instance=new A176257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176258
{
public static readonly long[] Value={ 9L,21L,33L,49L,57L,69L,77L,81L,93L,105L,121L,129L,133L,141L,161L,165L,177L,189L,201L,209L,213L,217L,237L,245L,249L,253L,285L,297L,301L,309L,321L,329L,341L,345L,361L,381L,385L,393L,413L,417L,437L,441L,453L,465L,469L,473L,489L,497L,501L,513L,517L,525L,529L,537L,553L,573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176258Inst : IEnumerable<long>
{
public static readonly long[] Value=A176258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176258.Bytes);
public long this[int i]=>Value[i];

public static A176258Inst Instance=new A176258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176259
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,-1L,-1L,-1L,1L,1L,-2L,-3L,-3L,-2L,1L,1L,-4L,-6L,-7L,-6L,-4L,1L,1L,-7L,-11L,-13L,-13L,-11L,-7L,1L,1L,-12L,-19L,-23L,-24L,-23L,-19L,-12L,1L,1L,-20L,-32L,-39L,-42L,-42L,-39L,-32L,-20L,1L,1L,-33L,-53L,-65L,-71L,-73L,-71L,-65L,-53L,-33L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176259Inst : IEnumerable<long>
{
public static readonly long[] Value=A176259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176259.Bytes);
public long this[int i]=>Value[i];

public static A176259Inst Instance=new A176259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176260
{
public static readonly long[] Value={ 5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176260Inst : IEnumerable<long>
{
public static readonly long[] Value=A176260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176260.Bytes);
public long this[int i]=>Value[i];

public static A176260Inst Instance=new A176260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176261
{
public static readonly long[] Value={ 1L,1L,1L,1L,-2L,1L,1L,-2L,-2L,1L,1L,-11L,-11L,-11L,1L,1L,-20L,-29L,-29L,-20L,1L,1L,-56L,-74L,-83L,-74L,-56L,1L,1L,-119L,-173L,-191L,-191L,-173L,-119L,1L,1L,-290L,-407L,-461L,-470L,-461L,-407L,-290L,1L,1L,-650L,-938L,-1055L,-1100L,-1100L,-1055L,-938L,-650L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176261Inst : IEnumerable<long>
{
public static readonly long[] Value=A176261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176261.Bytes);
public long this[int i]=>Value[i];

public static A176261Inst Instance=new A176261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176262
{
public static readonly long[] Value={ 4L,10L,16L,22L,25L,34L,40L,46L,55L,58L,64L,82L,85L,88L,94L,100L,106L,115L,118L,121L,136L,142L,145L,154L,160L,166L,178L,184L,187L,202L,205L,214L,220L,226L,232L,235L,238L,250L,253L,256L,262L,265L,274L,289L,295L,298L,319L,322L,328L,334L,340L,346L,352L,355L,358L,376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176262Inst : IEnumerable<long>
{
public static readonly long[] Value=A176262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176262.Bytes);
public long this[int i]=>Value[i];

public static A176262Inst Instance=new A176262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176263
{
public static readonly long[] Value={ 1L,1L,1L,1L,-4L,1L,1L,-4L,-4L,1L,1L,-29L,-29L,-29L,1L,1L,-54L,-79L,-79L,-54L,1L,1L,-204L,-254L,-279L,-254L,-204L,1L,1L,-479L,-679L,-729L,-729L,-679L,-479L,1L,1L,-1504L,-1979L,-2179L,-2204L,-2179L,-1979L,-1504L,1L,1L,-3904L,-5404L,-5879L,-6054L,-6054L,-5879L,-5404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176263Inst : IEnumerable<long>
{
public static readonly long[] Value=A176263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176263.Bytes);
public long this[int i]=>Value[i];

public static A176263Inst Instance=new A176263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176264
{
public static readonly long[] Value={ 1L,1L,1L,1L,-6L,1L,1L,-6L,-6L,1L,1L,-55L,-55L,-55L,1L,1L,-104L,-153L,-153L,-104L,1L,1L,-496L,-594L,-643L,-594L,-496L,1L,1L,-1231L,-1721L,-1819L,-1819L,-1721L,-1231L,1L,1L,-4710L,-5935L,-6425L,-6474L,-6425L,-5935L,-4710L,1L,1L,-13334L,-18038L,-19263L,-19704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176264Inst : IEnumerable<long>
{
public static readonly long[] Value=A176264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176264.Bytes);
public long this[int i]=>Value[i];

public static A176264Inst Instance=new A176264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176265
{
public static readonly long[] Value={ 0L,0L,2L,2L,1L,5L,5L,1L,8L,8L,0L,10L,11L,1L,11L,15L,4L,11L,18L,8L,11L,21L,12L,10L,24L,16L,7L,26L,21L,4L,28L,26L,0L,28L,31L,4L,28L,36L,10L,26L,40L,16L,23L,43L,23L,19L,46L,30L,14L,48L,37L,8L,48L,44L,1L,47L,51L,6L,45L,57L,15L,41L,62L,25L,36L,65L,34L,29L,68L,44L,21L,69L,53L,12L,69L,62L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176265Inst : IEnumerable<long>
{
public static readonly long[] Value=A176265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176265.Bytes);
public long this[int i]=>Value[i];

public static A176265Inst Instance=new A176265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176266
{
public static readonly long[] Value={ 1L,1L,2L,5L,42L,132L,1144L,3978L,35530L,1L,15L,210L,2470L,22386L,228459L,2908360L,37584261L,284291205L,3701413144L,35L,852L,19019L,349812L,6529292L,132435472L,2000945100L,24366118700L,328386663605L,3520256293710L,2072L,81375L,2271776L,59988852L,1227434238L,33401522154L,584134601050L,11919696387170L,234924043375476L,3924875235562164L,208335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176266Inst : IEnumerable<long>
{
public static readonly long[] Value=A176266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176266.Bytes);
public long this[int i]=>Value[i];

public static A176266Inst Instance=new A176266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176267
{
public static readonly long[] Value={ 5L,55L,1430L,4862L,1463L,1193010L,1015L,9414328L,18278L,749398L,370577311L,16723070L,225398683020L,7151980L,378683037040L,149846840L,8511300512L,272994644359580L,194480021970L,8516063242041795L,8175951659117794L,50L,42925L,3046258475L,391139588190L,1242164L,1646644081775L,2271776L,38642514470976L,4683175503770976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176267Inst : IEnumerable<long>
{
public static readonly long[] Value=A176267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176267.Bytes);
public long this[int i]=>Value[i];

public static A176267Inst Instance=new A176267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176268
{
public static readonly long[] Value={ 3467L,6947L,13907L,27827L,55667L,111347L,222707L,445427L,890867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176268Inst : IEnumerable<long>
{
public static readonly long[] Value=A176268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176268.Bytes);
public long this[int i]=>Value[i];

public static A176268Inst Instance=new A176268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176269
{
public static readonly long[] Value={ 3L,7L,7L,8L,3L,2L,3L,0L,1L,3L,3L,3L,7L,3L,5L,1L,5L,9L,9L,4L,0L,9L,9L,7L,3L,8L,4L,0L,0L,7L,3L,9L,6L,2L,2L,4L,6L,0L,6L,2L,2L,9L,2L,2L,7L,1L,0L,3L,1L,3L,6L,7L,4L,6L,2L,1L,7L,0L,4L,4L,8L,0L,6L,0L,8L,7L,6L,6L,6L,5L,3L,7L,1L,7L,0L,4L,8L,3L,3L,5L,5L,3L,6L,4L,9L,0L,5L,8L,4L,4L,7L,0L,5L,6L,7L,2L,7L,3L,1L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176269Inst : IEnumerable<long>
{
public static readonly long[] Value=A176269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176269.Bytes);
public long this[int i]=>Value[i];

public static A176269Inst Instance=new A176269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176270
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,-1L,-1L,1L,1L,-2L,-3L,-2L,1L,1L,-3L,-5L,-5L,-3L,1L,1L,-4L,-7L,-8L,-7L,-4L,1L,1L,-5L,-9L,-11L,-11L,-9L,-5L,1L,1L,-6L,-11L,-14L,-15L,-14L,-11L,-6L,1L,1L,-7L,-13L,-17L,-19L,-19L,-17L,-13L,-7L,1L,1L,-8L,-15L,-20L,-23L,-24L,-23L,-20L,-15L,-8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176270Inst : IEnumerable<long>
{
public static readonly long[] Value=A176270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176270.Bytes);
public long this[int i]=>Value[i];

public static A176270Inst Instance=new A176270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176271
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176271Inst : IEnumerable<long>
{
public static readonly long[] Value=A176271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176271.Bytes);
public long this[int i]=>Value[i];

public static A176271Inst Instance=new A176271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176272
{
public static readonly BigInteger[] Value={ 61L,66666667L,BigInteger.Parse("6666666666666666666666666666666666666666641") };
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
public class A176272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176272Inst Instance=new A176272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176273
{
public static readonly long[] Value={ 1L,17L,49L,113L,194L,322L,565L,821L,1333L,1958L,2687L,3711L,5007L,7055L,9242L,11643L,14235L,17360L,21248L,25344L,30528L,37089L,44865L,53057L,63057L,73425L,85089L,99730L,115282L,130907L,147291L,164098L,183781L,203781L,224517L,247845L,276406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176273Inst : IEnumerable<long>
{
public static readonly long[] Value=A176273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176273.Bytes);
public long this[int i]=>Value[i];

public static A176273Inst Instance=new A176273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176274
{
public static readonly long[] Value={ 14L,26L,35L,38L,56L,62L,65L,74L,86L,95L,98L,104L,122L,134L,140L,143L,146L,152L,155L,158L,182L,185L,194L,206L,209L,215L,218L,224L,245L,248L,254L,260L,266L,278L,296L,302L,305L,314L,323L,326L,335L,338L,341L,344L,350L,362L,365L,380L,386L,392L,395L,398L,407L,416L,422L,434L,446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176274Inst : IEnumerable<long>
{
public static readonly long[] Value=A176274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176274.Bytes);
public long this[int i]=>Value[i];

public static A176274Inst Instance=new A176274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176275
{
public static readonly long[] Value={ 25L,55L,85L,115L,121L,145L,175L,187L,205L,235L,253L,265L,289L,295L,319L,325L,355L,385L,391L,415L,445L,451L,475L,493L,505L,517L,529L,535L,565L,583L,595L,625L,649L,655L,667L,685L,697L,715L,745L,775L,781L,799L,805L,835L,841L,865L,895L,901L,913L,925L,943L,955L,979L,985L,1003L,1015L,1045L,1075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176275Inst : IEnumerable<long>
{
public static readonly long[] Value=A176275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176275.Bytes);
public long this[int i]=>Value[i];

public static A176275Inst Instance=new A176275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176276
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,3L,0L,7L,18L,11L,0L,15L,75L,110L,50L,0L,31L,270L,715L,750L,274L,0L,63L,903L,3850L,7000L,5754L,1764L,0L,127L,2898L,18711L,52500L,72884L,49392L,13068L,0L,255L,9075L,85470L,347550L,725004L,814968L,470448L,109584L,0L,511L,27990L,375155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176276Inst : IEnumerable<long>
{
public static readonly long[] Value=A176276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176276.Bytes);
public long this[int i]=>Value[i];

public static A176276Inst Instance=new A176276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176277
{
public static readonly ulong[] Value={ 0L,1L,3L,18L,125L,1020L,9667L,104790L,1281177L,17457840L,262493231L,4318429962L,77178551749L,1489209086820L,30859393432155L,683549418431934L,16118484827641841L,403156528379483160L,10661349675027656839UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176277Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A176277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176277.Bytes);
public ulong this[int i]=>Value[i];

public static A176277Inst Instance=new A176277Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176278
{
public static readonly long[] Value={ 77L,119L,161L,203L,221L,287L,299L,329L,371L,377L,413L,437L,497L,533L,539L,551L,581L,611L,623L,689L,707L,749L,767L,779L,791L,833L,893L,917L,923L,959L,1001L,1007L,1043L,1079L,1121L,1127L,1157L,1169L,1211L,1253L,1271L,1313L,1337L,1349L,1379L,1391L,1421L,1457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176278Inst : IEnumerable<long>
{
public static readonly long[] Value=A176278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176278.Bytes);
public long this[int i]=>Value[i];

public static A176278Inst Instance=new A176278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176279
{
public static readonly long[] Value={ 1L,2L,6L,7L,14L,15L,17L,18L,19L,20L,21L,26L,27L,28L,29L,31L,33L,35L,36L,38L,39L,42L,44L,45L,48L,49L,53L,55L,56L,57L,59L,61L,64L,65L,66L,69L,70L,71L,74L,76L,77L,78L,79L,80L,82L,84L,87L,88L,89L,90L,91L,92L,93L,96L,98L,99L,100L,102L,103L,104L,105L,107L,109L,112L,113L,115L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176279Inst : IEnumerable<long>
{
public static readonly long[] Value=A176279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176279.Bytes);
public long this[int i]=>Value[i];

public static A176279Inst Instance=new A176279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176280
{
public static readonly long[] Value={ 1L,2L,7L,26L,101L,402L,1625L,6638L,27319L,113054L,469811L,1958706L,8187063L,34290934L,143864999L,604402050L,2542083509L,10702020746L,45090876913L,190110250998L,801997354525L,3384971428258L,14292950533517L,60373808435046L,255102065046401L,1078202260326002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176280Inst : IEnumerable<long>
{
public static readonly long[] Value=A176280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176280.Bytes);
public long this[int i]=>Value[i];

public static A176280Inst Instance=new A176280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176281
{
public static readonly long[] Value={ 1L,3L,12L,56L,280L,1440L,7488L,39104L,204544L,1070592L,5604864L,29345792L,153653248L,804532224L,4212572160L,22057287680L,115493404672L,604731211776L,3166413520896L,16579556016128L,86811681488896L,454551863820288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176281Inst : IEnumerable<long>
{
public static readonly long[] Value=A176281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176281.Bytes);
public long this[int i]=>Value[i];

public static A176281Inst Instance=new A176281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176282
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,9L,9L,1L,1L,16L,21L,16L,1L,1L,25L,37L,37L,25L,1L,1L,36L,57L,64L,57L,36L,1L,1L,49L,81L,97L,97L,81L,49L,1L,1L,64L,109L,136L,145L,136L,109L,64L,1L,1L,81L,141L,181L,201L,201L,181L,141L,81L,1L,1L,100L,177L,232L,265L,276L,265L,232L,177L,100L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176282Inst : IEnumerable<long>
{
public static readonly long[] Value=A176282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176282.Bytes);
public long this[int i]=>Value[i];

public static A176282Inst Instance=new A176282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176283
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,27L,27L,1L,1L,64L,83L,64L,1L,1L,125L,181L,181L,125L,1L,1L,216L,333L,370L,333L,216L,1L,1L,343L,551L,649L,649L,551L,343L,1L,1L,512L,847L,1036L,1097L,1036L,847L,512L,1L,1L,729L,1233L,1549L,1701L,1701L,1549L,1233L,729L,1L,1L,1000L,1721L,2206L,2485L,2576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176283Inst : IEnumerable<long>
{
public static readonly long[] Value=A176283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176283.Bytes);
public long this[int i]=>Value[i];

public static A176283Inst Instance=new A176283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176284
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,19L,19L,1L,1L,37L,49L,37L,1L,1L,61L,91L,91L,61L,1L,1L,91L,145L,163L,145L,91L,1L,1L,127L,211L,253L,253L,211L,127L,1L,1L,169L,289L,361L,385L,361L,289L,169L,1L,1L,217L,379L,487L,541L,541L,487L,379L,217L,1L,1L,271L,481L,631L,721L,751L,721L,631L,481L,271L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176284Inst : IEnumerable<long>
{
public static readonly long[] Value=A176284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176284.Bytes);
public long this[int i]=>Value[i];

public static A176284Inst Instance=new A176284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176285
{
public static readonly BigInteger[] Value={ 1L,11L,316L,12011L,522376L,24593348L,1219951188L,62798884331L,3323228619736L,179665076698136L,9880531254032176L,550994628527745476L,BigInteger.Parse("31084678988906064016"),BigInteger.Parse("1770908612898043660556"),BigInteger.Parse("101738260887234550287316") };
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
public class A176285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176285Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176285.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176285Inst Instance=new A176285Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176286
{
public static readonly long[] Value={ 1L,1L,1L,1L,15L,1L,1L,65L,65L,1L,1L,175L,225L,175L,1L,1L,369L,529L,529L,369L,1L,1L,671L,1025L,1135L,1025L,671L,1L,1L,1105L,1761L,2065L,2065L,1761L,1105L,1L,1L,1695L,2785L,3391L,3585L,3391L,2785L,1695L,1L,1L,2465L,4145L,5185L,5681L,5681L,5185L,4145L,2465L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176286Inst : IEnumerable<long>
{
public static readonly long[] Value=A176286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176286.Bytes);
public long this[int i]=>Value[i];

public static A176286Inst Instance=new A176286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176287
{
public static readonly long[] Value={ 1L,2L,7L,23L,81L,291L,1066L,3955L,14818L,55937L,212428L,810664L,3106167L,11942261L,46047897L,178000950L,689580319L,2676598447L,10406929687L,40525045518L,158022343991L,616950024334L,2411395005316L,9434753907065L,36948692202031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176287Inst : IEnumerable<long>
{
public static readonly long[] Value=A176287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176287.Bytes);
public long this[int i]=>Value[i];

public static A176287Inst Instance=new A176287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176288
{
public static readonly long[] Value={ 1L,3L,15L,55L,131L,163L,-169L,-1521L,-4437L,-7429L,-2945L,26471L,101587L,207699L,201639L,-306497L,-1907461L,-4718165L,-6464305L,547863L,30463779L,93816323L,161591287L,97035119L,-400669877L,-1676486565L,-3504149217L,-3693262649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176288Inst : IEnumerable<long>
{
public static readonly long[] Value=A176288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176288.Bytes);
public long this[int i]=>Value[i];

public static A176288Inst Instance=new A176288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176289
{
public static readonly long[] Value={ 1L,1L,6L,1L,30L,1L,42L,1L,30L,1L,66L,1L,2730L,1L,6L,1L,510L,1L,798L,1L,330L,1L,138L,1L,2730L,1L,6L,1L,870L,1L,14322L,1L,510L,1L,6L,1L,1919190L,1L,6L,1L,13530L,1L,1806L,1L,690L,1L,282L,1L,46410L,1L,66L,1L,1590L,1L,798L,1L,870L,1L,354L,1L,56786730L,1L,6L,1L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176289Inst : IEnumerable<long>
{
public static readonly long[] Value=A176289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176289.Bytes);
public long this[int i]=>Value[i];

public static A176289Inst Instance=new A176289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176290
{
public static readonly long[] Value={ 1L,2L,-3L,-75L,-650L,-4507L,-28267L,-167406L,-955271L,-5310911L,-28962586L,-155616567L,-826329687L,-4345964510L,-22675946635L,-117526104883L,-605643805098L,-3105646720979L,-15856669574339L,-80653146223054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176290Inst : IEnumerable<long>
{
public static readonly long[] Value=A176290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176290.Bytes);
public long this[int i]=>Value[i];

public static A176290Inst Instance=new A176290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176291
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,13L,13L,1L,1L,58L,192L,58L,1L,1L,209L,1584L,1584L,209L,1L,1L,682L,10335L,23200L,10335L,682L,1L,1L,2125L,60267L,258745L,258745L,60267L,2125L,1L,1L,6482L,330942L,2482938L,4671488L,2482938L,330942L,6482L,1L,1L,19585L,1755262L,21702934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176291Inst : IEnumerable<long>
{
public static readonly long[] Value=A176291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176291.Bytes);
public long this[int i]=>Value[i];

public static A176291Inst Instance=new A176291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176292
{
public static readonly long[] Value={ 1L,4L,7L,10L,12L,15L,17L,18L,21L,22L,25L,28L,29L,40L,47L,53L,61L,62L,64L,68L,69L,72L,85L,87L,90L,91L,93L,100L,102L,106L,107L,110L,112L,114L,116L,120L,125L,130L,131L,132L,133L,136L,151L,154L,155L,158L,165L,166L,169L,170L,179L,181L,190L,191L,198L,212L,221L,222L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176292Inst : IEnumerable<long>
{
public static readonly long[] Value=A176292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176292.Bytes);
public long this[int i]=>Value[i];

public static A176292Inst Instance=new A176292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176293
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,17L,17L,1L,1L,55L,73L,55L,1L,1L,129L,193L,193L,129L,1L,1L,251L,401L,451L,401L,251L,1L,1L,433L,721L,865L,865L,721L,433L,1L,1L,687L,1177L,1471L,1569L,1471L,1177L,687L,1L,1L,1025L,1793L,2305L,2561L,2561L,2305L,1793L,1025L,1L,1L,1459L,2593L,3403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176293Inst : IEnumerable<long>
{
public static readonly long[] Value=A176293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176293.Bytes);
public long this[int i]=>Value[i];

public static A176293Inst Instance=new A176293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176294
{
public static readonly long[] Value={ 1L,15L,16L,17L,18L,19L,44L,45L,46L,47L,48L,116L,117L,118L,119L,245L,246L,290L,291L,292L,293L,294L,374L,375L,376L,425L,426L,427L,428L,429L,431L,432L,433L,434L,435L,436L,437L,438L,439L,441L,486L,487L,488L,489L,527L,528L,529L,580L,581L,582L,627L,628L,629L,684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176294Inst : IEnumerable<long>
{
public static readonly long[] Value=A176294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176294.Bytes);
public long this[int i]=>Value[i];

public static A176294Inst Instance=new A176294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176295
{
public static readonly long[] Value={ -4L,4L,8L,2L,-10L,0L,12L,0L,16L,-32L,-16L,32L,-4L,-4L,120L,-120L,-120L,120L,0L,-96L,-96L,960L,-480L,-864L,576L,80L,80L,-1680L,-1680L,8400L,-1680L,-6720L,3360L,0L,3840L,3840L,-26880L,-26880L,80640L,0L,-57600L,23040L,-6048L,-6048L,120960L,120960L,-423360L,-423360L,846720L,120960L,-544320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176295Inst : IEnumerable<long>
{
public static readonly long[] Value=A176295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176295.Bytes);
public long this[int i]=>Value[i];

public static A176295Inst Instance=new A176295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176296
{
public static readonly long[] Value={ 0L,2L,0L,4L,0L,6L,8L,0L,8L,12L,0L,10L,16L,18L,0L,12L,20L,24L,0L,14L,24L,30L,32L,0L,16L,28L,36L,40L,0L,18L,32L,42L,48L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176296Inst : IEnumerable<long>
{
public static readonly long[] Value=A176296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176296.Bytes);
public long this[int i]=>Value[i];

public static A176296Inst Instance=new A176296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176297
{
public static readonly long[] Value={ 8L,24L,27L,40L,54L,56L,72L,88L,104L,108L,120L,125L,135L,136L,152L,168L,184L,189L,200L,216L,232L,248L,250L,264L,270L,280L,296L,297L,312L,328L,343L,344L,351L,360L,375L,376L,378L,392L,408L,424L,432L,440L,456L,459L,472L,488L,500L,504L,513L,520L,536L,540L,552L,568L,584L,594L,600L,616L,621L,632L,648L,664L,675L,680L,686L,696L,702L,712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176297Inst : IEnumerable<long>
{
public static readonly long[] Value=A176297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176297.Bytes);
public long this[int i]=>Value[i];

public static A176297Inst Instance=new A176297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176298
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,2L,1L,1L,3L,4L,4L,3L,1L,1L,3L,4L,5L,4L,3L,1L,1L,4L,5L,6L,6L,5L,4L,1L,1L,4L,6L,6L,7L,6L,6L,4L,1L,1L,5L,6L,7L,8L,8L,7L,6L,5L,1L,1L,5L,7L,8L,8L,9L,8L,8L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176298Inst : IEnumerable<long>
{
public static readonly long[] Value=A176298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176298.Bytes);
public long this[int i]=>Value[i];

public static A176298Inst Instance=new A176298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176299
{
public static readonly BigInteger[] Value={ 1L,3L,16L,400L,176400L,31265312400L,BigInteger.Parse("977530816165936208400"),BigInteger.Parse("955566496615167328821016225384209913664400"),BigInteger.Parse("913107329453384594090655605142589591944555936335177523176387250981965992675658480400") };
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
public class A176299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176299Inst Instance=new A176299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176300
{
public static readonly long[] Value={ 1L,5L,21L,26L,27L,28L,33L,41L,45L,48L,66L,68L,74L,86L,90L,108L,111L,112L,140L,144L,146L,149L,156L,160L,166L,183L,184L,189L,192L,210L,212L,216L,225L,228L,231L,240L,265L,268L,278L,280L,299L,300L,301L,312L,314L,325L,333L,344L,360L,363L,366L,368L,370L,378L,384L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176300Inst : IEnumerable<long>
{
public static readonly long[] Value=A176300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176300.Bytes);
public long this[int i]=>Value[i];

public static A176300Inst Instance=new A176300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176301
{
public static readonly long[] Value={ 3L,6L,7L,13L,15L,18L,20L,23L,24L,26L,30L,34L,36L,43L,51L,54L,57L,68L,75L,78L,80L,86L,91L,98L,99L,106L,108L,116L,117L,118L,119L,125L,128L,132L,135L,138L,150L,151L,153L,154L,161L,171L,185L,186L,187L,192L,201L,204L,207L,212L,215L,217L,221L,223L,226L,228L,232L,233L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176301Inst : IEnumerable<long>
{
public static readonly long[] Value=A176301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176301.Bytes);
public long this[int i]=>Value[i];

public static A176301Inst Instance=new A176301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176302
{
public static readonly BigInteger[] Value={ 1L,5L,31L,289L,3446L,50653L,883883L,17850625L,409413666L,10510100501L,298523873866L,9294114390625L,314715395761089L,11514990476898413L,452702917746710142L,BigInteger.Parse("19031147999601100801"),BigInteger.Parse("851888944448164153708") };
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
public class A176302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176302Inst Instance=new A176302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176303
{
public static readonly long[] Value={ 126L,125L,123L,119L,111L,95L,63L,1L,129L,385L,897L,1921L,3969L,8065L,16257L,32641L,65409L,130945L,262017L,524161L,1048449L,2097025L,4194177L,8388481L,16777089L,33554305L,67108737L,134217601L,268435329L,536870785L,1073741697L,2147483521L,4294967169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176303Inst : IEnumerable<long>
{
public static readonly long[] Value=A176303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176303.Bytes);
public long this[int i]=>Value[i];

public static A176303Inst Instance=new A176303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176304
{
public static readonly long[] Value={ 0L,-1L,-3L,8L,31L,-156L,-937L,6558L,52463L,-472168L,-4721681L,51938490L,623261879L,-8102404428L,-113433661993L,1701504929894L,27224078878303L,-462809340931152L,-8330568136760737L,158280794598454002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176304Inst : IEnumerable<long>
{
public static readonly long[] Value=A176304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176304.Bytes);
public long this[int i]=>Value[i];

public static A176304Inst Instance=new A176304Inst();

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