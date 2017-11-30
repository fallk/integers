using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A073041
{
public static readonly long[] Value={ 2L,12L,21L,30L,36L,60L,63L,90L,114L,132L,150L,162L,174L,192L,198L,204L,231L,237L,240L,246L,255L,261L,264L,291L,306L,330L,360L,378L,390L,402L,411L,420L,438L,447L,456L,462L,471L,477L,495L,510L,552L,588L,594L,603L,609L,627L,630L,642L,654L,669L,690L,726L,732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073041Inst : IEnumerable<long>
{
public static readonly long[] Value=A073041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073041.Bytes);
public long this[int i]=>Value[i];

public static A073041Inst Instance=new A073041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073042
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,10L,16L,25L,36L,40L,49L,64L,80L,81L,100L,121L,125L,144L,160L,169L,196L,216L,225L,250L,256L,270L,289L,324L,343L,360L,361L,400L,441L,484L,490L,512L,529L,576L,625L,640L,676L,729L,784L,800L,810L,841L,900L,961L,1000L,1024L,1089L,1156L,1210L,1225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073042Inst : IEnumerable<long>
{
public static readonly long[] Value=A073042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073042.Bytes);
public long this[int i]=>Value[i];

public static A073042Inst Instance=new A073042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073043
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,8L,12L,21L,26L,38L,35L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073043Inst : IEnumerable<long>
{
public static readonly long[] Value=A073043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073043.Bytes);
public long this[int i]=>Value[i];

public static A073043Inst Instance=new A073043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073044
{
public static readonly long[] Value={ 2L,2L,1L,2L,2L,1L,2L,3L,2L,1L,2L,4L,4L,2L,1L,2L,5L,6L,5L,2L,1L,2L,6L,9L,8L,6L,2L,1L,2L,7L,12L,14L,10L,7L,2L,1L,2L,8L,16L,20L,20L,12L,8L,2L,1L,2L,9L,20L,30L,30L,27L,14L,9L,2L,1L,2L,10L,25L,40L,50L,42L,35L,16L,10L,2L,1L,2L,11L,30L,55L,70L,77L,56L,44L,18L,11L,2L,1L,2L,12L,36L,70L,105L,112L,112L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073044Inst : IEnumerable<long>
{
public static readonly long[] Value=A073044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073044.Bytes);
public long this[int i]=>Value[i];

public static A073044Inst Instance=new A073044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073045
{
public static readonly long[] Value={ 4L,9L,25L,27L,49L,121L,125L,169L,289L,343L,361L,529L,625L,841L,961L,1331L,1369L,1681L,1849L,2197L,2209L,2401L,2809L,3125L,3481L,3721L,4489L,4913L,5041L,5329L,6241L,6859L,6889L,7921L,9409L,10201L,10609L,11449L,11881L,12167L,12769L,14641L,16129L,16807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073045Inst : IEnumerable<long>
{
public static readonly long[] Value=A073045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073045.Bytes);
public long this[int i]=>Value[i];

public static A073045Inst Instance=new A073045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073046
{
public static readonly long[] Value={ 4L,9L,15L,21L,35L,33L,39L,65L,51L,57L,95L,69L,115L,161L,87L,93L,155L,217L,111L,185L,123L,129L,215L,141L,235L,329L,159L,265L,371L,177L,183L,305L,427L,201L,335L,213L,219L,365L,511L,237L,395L,249L,415L,581L,267L,445L,623L,1501L,291L,485L,303L,309L,515L,321L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073046Inst : IEnumerable<long>
{
public static readonly long[] Value=A073046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073046.Bytes);
public long this[int i]=>Value[i];

public static A073046Inst Instance=new A073046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073047
{
public static readonly long[] Value={ 2L,3L,3L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073047Inst : IEnumerable<long>
{
public static readonly long[] Value=A073047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073047.Bytes);
public long this[int i]=>Value[i];

public static A073047Inst Instance=new A073047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073048
{
public static readonly long[] Value={ 5L,10L,1L,191L,13L,1134L,157L,1169312L,100149391L,1016258233L,107375450119L,10271593487494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073048Inst : IEnumerable<long>
{
public static readonly long[] Value=A073048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073048.Bytes);
public long this[int i]=>Value[i];

public static A073048Inst Instance=new A073048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073049
{
public static readonly long[] Value={ 2L,3L,28L,5L,0L,7L,225L,153L,640L,11L,6348L,13L,19474560L,0L,976L,17L,1225L,19L,1521L,81L,0L,23L,343000L,49L,2601L,2133L,3025L,29L,1495296000L,31L,20063232L,4225L,15262600L,4761L,19236456L,37L,25462407801600L,5929L,34633600L,41L,0L,43L,7569L,356445L,8281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073049Inst : IEnumerable<long>
{
public static readonly long[] Value=A073049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073049.Bytes);
public long this[int i]=>Value[i];

public static A073049Inst Instance=new A073049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073050
{
public static readonly long[] Value={ 1L,1L,5L,1L,1L,3L,5L,5L,3L,3L,9L,11L,5L,21L,1L,3L,23L,1L,31L,15L,17L,17L,15L,91L,9L,13L,9L,41L,43L,7L,97L,69L,7L,35L,7L,23L,5L,19L,63L,5L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073050Inst : IEnumerable<long>
{
public static readonly long[] Value=A073050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073050.Bytes);
public long this[int i]=>Value[i];

public static A073050Inst Instance=new A073050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073051
{
public static readonly long[] Value={ 1L,3L,8L,23L,33L,45L,29L,281L,98L,153L,188L,262L,366L,428L,589L,737L,216L,1182L,3301L,2190L,1878L,1830L,7969L,3076L,3426L,2224L,3792L,8027L,4611L,4521L,3643L,8687L,14861L,12541L,15782L,3384L,34201L,19025L,17005L,44772L,23282L,38589L,14356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073051Inst : IEnumerable<long>
{
public static readonly long[] Value=A073051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073051.Bytes);
public long this[int i]=>Value[i];

public static A073051Inst Instance=new A073051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073052
{
public static readonly long[] Value={ 9L,0L,0L,9L,6L,8L,8L,6L,7L,9L,0L,2L,4L,1L,9L,1L,2L,6L,2L,3L,6L,1L,0L,2L,3L,1L,9L,5L,0L,7L,4L,4L,5L,0L,5L,1L,1L,6L,5L,9L,1L,9L,1L,6L,2L,1L,3L,1L,8L,5L,7L,1L,5L,0L,0L,5L,3L,5L,6L,2L,4L,2L,3L,1L,9L,9L,4L,3L,2L,4L,2L,0L,4L,2L,7L,9L,3L,9L,9L,6L,5L,5L,0L,1L,3L,6L,1L,4L,5L,4L,7L,1L,8L,5L,1L,2L,4L,1L,5L,3L,1L,8L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073052Inst : IEnumerable<long>
{
public static readonly long[] Value=A073052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073052.Bytes);
public long this[int i]=>Value[i];

public static A073052Inst Instance=new A073052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073053
{
public static readonly long[] Value={ 11L,101L,11L,101L,11L,101L,11L,101L,11L,112L,22L,112L,22L,112L,22L,112L,22L,112L,22L,202L,112L,202L,112L,202L,112L,202L,112L,202L,112L,112L,22L,112L,22L,112L,22L,112L,22L,112L,22L,202L,112L,202L,112L,202L,112L,202L,112L,202L,112L,112L,22L,112L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073053Inst : IEnumerable<long>
{
public static readonly long[] Value=A073053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073053.Bytes);
public long this[int i]=>Value[i];

public static A073053Inst Instance=new A073053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073054
{
public static readonly long[] Value={ 5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073054Inst : IEnumerable<long>
{
public static readonly long[] Value=A073054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073054.Bytes);
public long this[int i]=>Value[i];

public static A073054Inst Instance=new A073054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073055
{
public static readonly long[] Value={ 1L,3L,3L,12L,12L,60L,540L,1080L,6480L,32400L,97200L,486000L,3888000L,34992000L,244944000L,2204496000L,6613488000L,13226976000L,39680928000L,317447424000L,1269789696000L,7618738176000L,15237476352000L,91424858112000L,365699432448000L,1097098297344000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073055Inst : IEnumerable<long>
{
public static readonly long[] Value=A073055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073055.Bytes);
public long this[int i]=>Value[i];

public static A073055Inst Instance=new A073055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073056
{
public static readonly long[] Value={ 4L,1L,9L,6L,8L,7L,3L,4L,4L,7L,5L,1L,6L,3L,7L,2L,4L,5L,8L,0L,2L,9L,2L,2L,0L,8L,1L,8L,5L,8L,6L,5L,3L,7L,2L,4L,4L,1L,0L,2L,5L,6L,5L,9L,8L,9L,6L,4L,4L,2L,8L,6L,2L,4L,6L,6L,1L,4L,6L,1L,3L,4L,0L,0L,3L,8L,9L,2L,6L,3L,9L,6L,5L,8L,5L,8L,5L,6L,3L,3L,5L,0L,8L,9L,7L,0L,4L,3L,6L,7L,6L,2L,9L,8L,1L,3L,6L,8L,0L,1L,1L,0L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073056Inst : IEnumerable<long>
{
public static readonly long[] Value=A073056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073056.Bytes);
public long this[int i]=>Value[i];

public static A073056Inst Instance=new A073056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073057
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,2L,1L,3L,4L,2L,4L,3L,1L,2L,1L,3L,4L,2L,4L,3L,1L,2L,1L,3L,1L,2L,4L,2L,4L,3L,1L,3L,4L,3L,4L,2L,1L,2L,1L,3L,4L,2L,4L,3L,1L,2L,1L,3L,1L,2L,4L,2L,4L,3L,1L,3L,4L,3L,4L,2L,1L,2L,1L,3L,1L,2L,4L,2L,4L,3L,1L,3L,4L,3L,4L,2L,1L,2L,1L,3L,1L,2L,4L,2L,1L,2L,1L,3L,4L,3L,1L,3L,4L,3L,4L,2L,1L,2L,4L,2L,4L,3L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073057Inst : IEnumerable<long>
{
public static readonly long[] Value=A073057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073057.Bytes);
public long this[int i]=>Value[i];

public static A073057Inst Instance=new A073057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073058
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,1L,3L,1L,1L,2L,1L,3L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,2L,1L,3L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073058Inst : IEnumerable<long>
{
public static readonly long[] Value=A073058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073058.Bytes);
public long this[int i]=>Value[i];

public static A073058Inst Instance=new A073058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073059
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073059Inst : IEnumerable<long>
{
public static readonly long[] Value=A073059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073059.Bytes);
public long this[int i]=>Value[i];

public static A073059Inst Instance=new A073059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073140
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,11L,11L,14L,16L,21L,21L,25L,21L,25L,25L,30L,32L,41L,41L,47L,41L,47L,47L,53L,41L,47L,47L,53L,47L,53L,53L,62L,64L,81L,81L,91L,81L,91L,91L,99L,81L,91L,91L,99L,91L,99L,99L,109L,81L,91L,91L,99L,91L,99L,99L,109L,91L,99L,99L,109L,99L,109L,109L,126L,128L,161L,161L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073140Inst : IEnumerable<long>
{
public static readonly long[] Value=A073140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073140.Bytes);
public long this[int i]=>Value[i];

public static A073140Inst Instance=new A073140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073141
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,30L,30L,49L,64L,108L,108L,154L,108L,154L,154L,225L,256L,408L,408L,532L,408L,532L,532L,690L,408L,532L,532L,690L,532L,690L,690L,961L,1024L,1584L,1584L,1960L,1584L,1960L,1960L,2340L,1584L,1960L,1960L,2340L,1960L,2340L,2340L,2914L,1584L,1960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073141Inst : IEnumerable<long>
{
public static readonly long[] Value=A073141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073141.Bytes);
public long this[int i]=>Value[i];

public static A073141Inst Instance=new A073141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073142
{
public static readonly long[] Value={ 0L,2178L,11436678L,108811891188L,118722683079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073142Inst : IEnumerable<long>
{
public static readonly long[] Value=A073142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073142.Bytes);
public long this[int i]=>Value[i];

public static A073142Inst Instance=new A073142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073143
{
public static readonly long[] Value={ 1L,2L,14L,22L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073143Inst : IEnumerable<long>
{
public static readonly long[] Value=A073143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073143.Bytes);
public long this[int i]=>Value[i];

public static A073143Inst Instance=new A073143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073144
{
public static readonly long[] Value={ 0L,1012L,10001145L,100000114412L,100010505595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073144Inst : IEnumerable<long>
{
public static readonly long[] Value=A073144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073144.Bytes);
public long this[int i]=>Value[i];

public static A073144Inst Instance=new A073144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073145
{
public static readonly long[] Value={ 3L,-1L,-1L,5L,-5L,-1L,11L,-15L,3L,23L,-41L,21L,43L,-105L,83L,65L,-253L,271L,47L,-571L,795L,-177L,-1189L,2161L,-1149L,-2201L,5511L,-4459L,-3253L,13223L,-14429L,-2047L,29699L,-42081L,10335L,61445L,-113861L,62751L,112555L,-289167L,239363L,162359L,-690889L,767893L,85355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073145Inst : IEnumerable<long>
{
public static readonly long[] Value=A073145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073145.Bytes);
public long this[int i]=>Value[i];

public static A073145Inst Instance=new A073145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073146
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,13L,16L,20L,26L,75L,88L,104L,124L,150L,541L,616L,704L,808L,932L,1082L,4683L,5224L,5840L,6544L,7352L,8284L,9366L,47293L,51976L,57200L,63040L,69584L,76936L,85220L,94586L,545835L,593128L,645104L,702304L,765344L,834928L,911864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073146Inst : IEnumerable<long>
{
public static readonly long[] Value=A073146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073146.Bytes);
public long this[int i]=>Value[i];

public static A073146Inst Instance=new A073146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073147
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,12L,15L,18L,30L,55L,67L,76L,88L,143L,273L,328L,364L,400L,455L,728L,1428L,1701L,1866L,2010L,2175L,2448L,3876L,7752L,9180L,9999L,10659L,11319L,12138L,13566L,21318L,43263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073147Inst : IEnumerable<long>
{
public static readonly long[] Value=A073147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073147.Bytes);
public long this[int i]=>Value[i];

public static A073147Inst Instance=new A073147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073148
{
public static readonly long[] Value={ 1L,2L,3L,7L,9L,12L,30L,37L,43L,55L,143L,173L,194L,218L,273L,728L,871L,961L,1045L,1155L,1428L,3876L,4604L,5033L,5393L,5778L,6324L,7752L,21318L,25194L,27378L,29094L,30744L,32655L,35511L,43263L,120175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073148Inst : IEnumerable<long>
{
public static readonly long[] Value=A073148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073148.Bytes);
public long this[int i]=>Value[i];

public static A073148Inst Instance=new A073148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073149
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,10L,13L,16L,26L,36L,46L,55L,65L,101L,137L,173L,203L,233L,269L,406L,543L,680L,788L,888L,996L,1133L,1676L,2219L,2762L,3173L,3533L,3893L,4304L,4847L,7066L,9285L,11504L,13133L,14503L,15799L,17169L,18798L,21017L,30302L,39587L,48872L,55529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073149Inst : IEnumerable<long>
{
public static readonly long[] Value=A073149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073149.Bytes);
public long this[int i]=>Value[i];

public static A073149Inst Instance=new A073149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073150
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,16L,22L,34L,46L,68L,90L,134L,170L,214L,304L,394L,574L,706L,838L,1018L,1412L,1806L,2594L,3134L,3618L,4158L,4946L,6752L,8558L,12170L,14534L,16514L,18494L,20858L,24470L,33028L,41586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073150Inst : IEnumerable<long>
{
public static readonly long[] Value=A073150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073150.Bytes);
public long this[int i]=>Value[i];

public static A073150Inst Instance=new A073150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073151
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,9L,16L,20L,24L,40L,68L,84L,100L,116L,184L,304L,372L,436L,500L,568L,872L,1412L,1716L,1988L,2244L,2516L,2820L,4232L,6752L,8164L,9380L,10468L,11556L,12772L,14184L,20936L,33028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073151Inst : IEnumerable<long>
{
public static readonly long[] Value=A073151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073151.Bytes);
public long this[int i]=>Value[i];

public static A073151Inst Instance=new A073151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073152
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,9L,12L,15L,24L,31L,40L,49L,58L,89L,113L,144L,171L,198L,229L,342L,431L,544L,637L,718L,811L,924L,1355L,1697L,2128L,2467L,2746L,3025L,3364L,3795L,5492L,6847L,8544L,9837L,10854L,11815L,12832L,14125L,15822L,22669L,28161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073152Inst : IEnumerable<long>
{
public static readonly long[] Value=A073152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073152.Bytes);
public long this[int i]=>Value[i];

public static A073152Inst Instance=new A073152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073153
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,9L,14L,18L,22L,36L,56L,70L,86L,100L,156L,237L,293L,349L,405L,461L,698L,1046L,1283L,1507L,1703L,1927L,2164L,3210L,4762L,5808L,6756L,6980L,7204L,8152L,9198L,13960L,21078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073153Inst : IEnumerable<long>
{
public static readonly long[] Value=A073153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073153.Bytes);
public long this[int i]=>Value[i];

public static A073153Inst Instance=new A073153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073154
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,14L,18L,28L,38L,56L,70L,106L,131L,167L,237L,293L,433L,523L,613L,753L,1046L,1283L,1869L,2219L,2543L,2893L,3479L,4762L,5808L,8374L,9839L,11099L,12359L,13824L,16390L,22198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073154Inst : IEnumerable<long>
{
public static readonly long[] Value=A073154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073154.Bytes);
public long this[int i]=>Value[i];

public static A073154Inst Instance=new A073154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073155
{
public static readonly long[] Value={ 1L,1L,4L,14L,56L,237L,1046L,4762L,22198L,105430L,508384L,2482297L,12248416L,60980875L,305955356L,1545397464L,7852100294L,40105277640L,205798130604L,1060467961508L,5485199090812L,28469067353686L,148220323891460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073155Inst : IEnumerable<long>
{
public static readonly long[] Value=A073155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073155.Bytes);
public long this[int i]=>Value[i];

public static A073155Inst Instance=new A073155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073156
{
public static readonly long[] Value={ 1L,2L,9L,36L,156L,698L,3210L,15080L,72060L,349184L,1711869L,8475494L,42318018L,212843826L,1077391794L,5484472880L,28058940086L,144195777552L,744017466318L,3852968380624L,20019113126120L,104329129258596L,545214946753377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073156Inst : IEnumerable<long>
{
public static readonly long[] Value=A073156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073156.Bytes);
public long this[int i]=>Value[i];

public static A073156Inst Instance=new A073156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073157
{
public static readonly long[] Value={ 1L,2L,5L,18L,70L,293L,1283L,5808L,26960L,127628L,613814L,2990681L,14730713L,73229291L,366936231L,1851352820L,9397497758L,47957377934L,245903408244L,1266266092112L,6545667052320L,33954266444498L,176689391245146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073157Inst : IEnumerable<long>
{
public static readonly long[] Value=A073157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073157.Bytes);
public long this[int i]=>Value[i];

public static A073157Inst Instance=new A073157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073158
{
public static readonly long[] Value={ 1L,2L,4L,7L,5L,8L,10L,14L,15L,19L,16L,20L,21L,22L,26L,28L,27L,30L,32L,33L,37L,38L,40L,39L,44L,45L,47L,46L,49L,50L,51L,52L,56L,58L,60L,61L,59L,64L,66L,68L,72L,67L,74L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073158Inst : IEnumerable<long>
{
public static readonly long[] Value=A073158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073158.Bytes);
public long this[int i]=>Value[i];

public static A073158Inst Instance=new A073158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073159
{
public static readonly long[] Value={ 3L,6L,11L,12L,13L,18L,24L,29L,34L,35L,36L,41L,43L,48L,54L,55L,57L,62L,65L,70L,75L,78L,79L,83L,89L,92L,93L,95L,99L,101L,103L,108L,114L,118L,121L,120L,123L,130L,128L,140L,139L,141L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073159Inst : IEnumerable<long>
{
public static readonly long[] Value=A073159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073159.Bytes);
public long this[int i]=>Value[i];

public static A073159Inst Instance=new A073159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073160
{
public static readonly long[] Value={ 9L,17L,23L,25L,31L,42L,53L,63L,69L,71L,77L,84L,91L,102L,109L,112L,119L,127L,135L,145L,153L,157L,162L,172L,181L,185L,188L,194L,200L,204L,211L,222L,232L,239L,241L,243L,253L,258L,268L,279L,280L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073160Inst : IEnumerable<long>
{
public static readonly long[] Value=A073160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073160.Bytes);
public long this[int i]=>Value[i];

public static A073160Inst Instance=new A073160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073161
{
public static readonly long[] Value={ 1L,4L,6L,10L,12L,20L,21L,26L,28L,36L,38L,46L,50L,56L,57L,64L,69L,80L,81L,87L,92L,99L,104L,112L,116L,122L,126L,133L,140L,146L,147L,155L,169L,172L,176L,185L,188L,198L,202L,210L,213L,222L,228L,237L,242L,253L,254L,264L,270L,279L,280L,289L,298L,303L,305L,318L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073161Inst : IEnumerable<long>
{
public static readonly long[] Value=A073161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073161.Bytes);
public long this[int i]=>Value[i];

public static A073161Inst Instance=new A073161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073162
{
public static readonly long[] Value={ 1L,3L,17L,37L,9107L,156335L,679083L,1068131L,4883039L,101691357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073162Inst : IEnumerable<long>
{
public static readonly long[] Value=A073162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073162.Bytes);
public long this[int i]=>Value[i];

public static A073162Inst Instance=new A073162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073163
{
public static readonly long[] Value={ 0L,3L,68L,259L,5500628L,1180641920L,19503263760L,46464766631L,863653341852L,306757978180563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073163Inst : IEnumerable<long>
{
public static readonly long[] Value=A073163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073163.Bytes);
public long this[int i]=>Value[i];

public static A073163Inst Instance=new A073163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073164
{
public static readonly long[] Value={ 0L,1L,4L,7L,604L,7552L,28720L,43501L,176868L,3016559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073164Inst : IEnumerable<long>
{
public static readonly long[] Value=A073164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073164.Bytes);
public long this[int i]=>Value[i];

public static A073164Inst Instance=new A073164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073165
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,10L,8L,1L,1L,5L,20L,35L,16L,1L,1L,6L,35L,112L,126L,32L,1L,1L,7L,56L,294L,672L,462L,64L,1L,1L,8L,84L,672L,2772L,4224L,1716L,128L,1L,1L,9L,120L,1386L,9504L,28314L,27456L,6435L,256L,1L,1L,10L,165L,2640L,28314L,151008L,306735L,183040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073165Inst : IEnumerable<long>
{
public static readonly long[] Value=A073165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073165.Bytes);
public long this[int i]=>Value[i];

public static A073165Inst Instance=new A073165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073166
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,2L,2L,1L,1L,5L,10L,5L,1L,1L,3L,5L,5L,3L,1L,1L,7L,7L,35L,7L,7L,1L,1L,4L,28L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073166Inst : IEnumerable<long>
{
public static readonly long[] Value=A073166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073166.Bytes);
public long this[int i]=>Value[i];

public static A073166Inst Instance=new A073166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073167
{
public static readonly long[] Value={ 4L,6L,12L,36L,158L,871L,5802L,44996L,396465L,3905769L,42492571L,505638346L,6530063762L,90937897520L,1358169957289L,21652573590950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073167Inst : IEnumerable<long>
{
public static readonly long[] Value=A073167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073167.Bytes);
public long this[int i]=>Value[i];

public static A073167Inst Instance=new A073167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073168
{
public static readonly long[] Value={ 1L,5L,9L,9L,9L,15L,16L,17L,18L,17L,25L,19L,21L,27L,31L,26L,21L,22L,21L,35L,38L,31L,35L,31L,34L,33L,37L,39L,49L,49L,33L,52L,49L,47L,39L,43L,47L,47L,48L,48L,41L,49L,48L,60L,59L,59L,49L,52L,58L,58L,63L,71L,75L,65L,65L,67L,71L,79L,75L,81L,84L,77L,65L,69L,72L,72L,67L,69L,61L,65L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073168Inst : IEnumerable<long>
{
public static readonly long[] Value=A073168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073168.Bytes);
public long this[int i]=>Value[i];

public static A073168Inst Instance=new A073168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073169
{
public static readonly long[] Value={ 3L,4L,5L,5L,5L,6L,7L,7L,7L,8L,9L,9L,9L,10L,10L,10L,10L,10L,11L,12L,12L,12L,12L,12L,13L,13L,13L,14L,15L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,18L,19L,19L,19L,19L,19L,20L,20L,20L,21L,22L,22L,22L,22L,22L,23L,23L,23L,24L,24L,24L,24L,24L,25L,25L,25L,25L,25L,25L,25L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073169Inst : IEnumerable<long>
{
public static readonly long[] Value=A073169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073169.Bytes);
public long this[int i]=>Value[i];

public static A073169Inst Instance=new A073169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073170
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,6L,7L,10L,11L,14L,19L,20L,25L,28L,29L,32L,37L,42L,43L,48L,51L,52L,57L,60L,65L,72L,75L,76L,79L,80L,83L,96L,99L,104L,105L,114L,115L,120L,125L,128L,133L,138L,139L,148L,149L,152L,153L,164L,175L,178L,179L,182L,187L,188L,197L,202L,207L,212L,213L,218L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073170Inst : IEnumerable<long>
{
public static readonly long[] Value=A073170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073170.Bytes);
public long this[int i]=>Value[i];

public static A073170Inst Instance=new A073170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073171
{
public static readonly long[] Value={ 4L,9L,16L,26L,38L,52L,69L,88L,111L,133L,159L,187L,217L,250L,287L,323L,362L,404L,448L,495L,542L,592L,648L,703L,760L,818L,882L,945L,1011L,1081L,1152L,1225L,1302L,1377L,1457L,1539L,1628L,1712L,1800L,1891L,1981L,2077L,2176L,2275L,2378L,2484L,2586L,2697L,2811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073171Inst : IEnumerable<long>
{
public static readonly long[] Value=A073171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073171.Bytes);
public long this[int i]=>Value[i];

public static A073171Inst Instance=new A073171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073332
{
public static readonly long[] Value={ 18L,36L,48L,50L,72L,98L,100L,144L,196L,200L,242L,338L,375L,392L,400L,484L,578L,676L,722L,784L,800L,968L,1029L,1058L,1125L,1156L,1280L,1352L,1444L,1568L,1600L,1682L,1922L,1936L,2116L,2312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073332Inst : IEnumerable<long>
{
public static readonly long[] Value=A073332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073332.Bytes);
public long this[int i]=>Value[i];

public static A073332Inst Instance=new A073332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073333
{
public static readonly long[] Value={ 5L,8L,1L,9L,7L,6L,7L,0L,6L,8L,6L,9L,3L,2L,6L,4L,2L,4L,3L,8L,5L,0L,0L,2L,0L,0L,5L,1L,0L,9L,0L,1L,1L,5L,5L,8L,5L,4L,6L,8L,6L,9L,3L,0L,1L,0L,7L,5L,3L,9L,6L,1L,3L,6L,2L,6L,6L,7L,8L,7L,0L,5L,9L,6L,4L,8L,0L,4L,3L,8L,1L,7L,3L,9L,1L,6L,6L,9L,7L,4L,3L,2L,8L,7L,2L,0L,4L,7L,0L,9L,4L,0L,4L,8L,7L,5L,0L,5L,7L,6L,5L,4L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073333Inst : IEnumerable<long>
{
public static readonly long[] Value=A073333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073333.Bytes);
public long this[int i]=>Value[i];

public static A073333Inst Instance=new A073333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073334
{
public static readonly long[] Value={ 3L,5L,8L,5L,8L,13L,8L,5L,8L,13L,21L,13L,8L,13L,8L,5L,8L,13L,21L,13L,21L,34L,21L,13L,8L,13L,21L,13L,8L,13L,8L,5L,8L,13L,21L,13L,21L,34L,21L,13L,21L,34L,55L,34L,21L,34L,21L,13L,8L,13L,21L,13L,21L,34L,21L,13L,8L,13L,21L,13L,8L,13L,8L,5L,8L,13L,21L,13L,21L,34L,21L,13L,21L,34L,55L,34L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073334Inst : IEnumerable<long>
{
public static readonly long[] Value=A073334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073334.Bytes);
public long this[int i]=>Value[i];

public static A073334Inst Instance=new A073334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073335
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,15L,23L,39L,58L,89L,128L,189L,264L,375L,515L,713L,960L,1301L,1726L,2298L,3011L,3948L,5113L,6625L,8492L,10880L,13825L,17545L,22108L,27823L,34800L,43465L,54003L,66983L,82709L,101960L,125180L,153432L,187397L,228490L,277707L,336972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073335Inst : IEnumerable<long>
{
public static readonly long[] Value=A073335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073335.Bytes);
public long this[int i]=>Value[i];

public static A073335Inst Instance=new A073335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073336
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,13L,21L,33L,51L,76L,111L,159L,226L,315L,435L,593L,805L,1077L,1435L,1893L,2486L,3237L,4198L,5405L,6935L,8843L,11235L,14201L,17893L,22437L,28052L,34929L,43371L,53653L,66201L,81410L,99876L,122155L,149063L,181399L,220280L,266811L,322524L,388960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073336Inst : IEnumerable<long>
{
public static readonly long[] Value=A073336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073336.Bytes);
public long this[int i]=>Value[i];

public static A073336Inst Instance=new A073336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073337
{
public static readonly long[] Value={ 7L,3L,13L,31L,241L,307L,463L,757L,1123L,1723L,3307L,3541L,4831L,5113L,5701L,6007L,8011L,9901L,10303L,11131L,12433L,13807L,14281L,17293L,20023L,20593L,21757L,23563L,24181L,26083L,28057L,30103L,35911L,41413L,43891L,46441L,53593L,60271L,78121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073337Inst : IEnumerable<long>
{
public static readonly long[] Value=A073337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073337.Bytes);
public long this[int i]=>Value[i];

public static A073337Inst Instance=new A073337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073338
{
public static readonly long[] Value={ 2L,3L,4L,9L,10L,12L,15L,18L,22L,30L,31L,36L,37L,39L,40L,46L,51L,52L,54L,57L,60L,61L,67L,72L,73L,75L,78L,79L,82L,85L,88L,96L,103L,106L,109L,117L,124L,141L,145L,148L,156L,166L,177L,180L,186L,192L,193L,199L,204L,219L,225L,228L,229L,246L,249L,264L,267L,268L,270L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073338Inst : IEnumerable<long>
{
public static readonly long[] Value=A073338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073338.Bytes);
public long this[int i]=>Value[i];

public static A073338Inst Instance=new A073338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073339
{
public static readonly long[] Value={ 2L,5L,5L,69L,69L,12L,69L,69L,69L,29L,69L,19L,69L,69L,29L,29L,631L,28L,30L,631L,69L,69L,69L,631L,72L,42L,1167L,631L,72L,631L,631L,1167L,51L,631L,1167L,631L,631L,1167L,102L,103L,69L,1167L,1167L,69L,72L,631L,631L,631L,631L,1167L,631L,130L,631L,83L,631L,1167L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073339Inst : IEnumerable<long>
{
public static readonly long[] Value=A073339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073339.Bytes);
public long this[int i]=>Value[i];

public static A073339Inst Instance=new A073339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073340
{
public static readonly long[] Value={ 3L,5L,5L,7L,11L,13L,431L,433L,569L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073340Inst : IEnumerable<long>
{
public static readonly long[] Value=A073340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073340.Bytes);
public long this[int i]=>Value[i];

public static A073340Inst Instance=new A073340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073341
{
public static readonly long[] Value={ 3L,2L,3L,8L,1L,1L,3L,2L,2L,3L,2L,2L,1L,1L,7L,4L,4L,2L,4L,3L,1L,1L,2L,4L,2L,8L,4L,3L,1L,1L,6L,4L,3L,2L,5L,4L,1L,1L,5L,2L,2L,3L,2L,2L,1L,1L,4L,5L,6L,2L,3L,5L,1L,1L,2L,3L,2L,4L,3L,6L,1L,1L,7L,8L,3L,2L,4L,5L,1L,1L,3L,2L,2L,3L,2L,2L,1L,1L,7L,3L,4L,2L,7L,6L,1L,1L,2L,5L,2L,5L,5L,3L,1L,1L,3L,3L,3L,2L,10L,3L,1L,1L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073341Inst : IEnumerable<long>
{
public static readonly long[] Value=A073341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073341.Bytes);
public long this[int i]=>Value[i];

public static A073341Inst Instance=new A073341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073342
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,2L,4L,5L,3L,6L,2L,5L,3L,4L,6L,4L,7L,4L,7L,4L,5L,8L,6L,9L,8L,1L,1L,3L,3L,2L,3L,2L,4L,4L,5L,2L,4L,3L,5L,4L,6L,3L,4L,4L,6L,6L,1L,2L,4L,4L,3L,5L,2L,3L,5L,4L,6L,3L,5L,4L,4L,5L,3L,2L,2L,4L,2L,4L,5L,5L,4L,6L,5L,4L,6L,5L,7L,6L,2L,4L,5L,2L,3L,3L,5L,4L,6L,5L,4L,4L,6L,7L,6L,5L,7L,3L,5L,3L,3L,3L,5L,6L,5L,7L,4L,6L,7L,6L,8L,2L,4L,3L,5L,5L,3L,4L,4L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073342Inst : IEnumerable<long>
{
public static readonly long[] Value=A073342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073342.Bytes);
public long this[int i]=>Value[i];

public static A073342Inst Instance=new A073342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073343
{
public static readonly long[] Value={ 1L,1L,1L,6L,33L,75L,877L,2075L,38692L,239794L,1250340L,18495201L,43023264L,4554211553L,70490483945L,911526001064L,182477118528L,219638126087356L,13070186026272L,79249480638985626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073343Inst : IEnumerable<long>
{
public static readonly long[] Value=A073343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073343.Bytes);
public long this[int i]=>Value[i];

public static A073343Inst Instance=new A073343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073344
{
public static readonly long[] Value={ 0L,0L,2L,7L,23L,105L,386L,1674L,6121L,25072L,89070L,391317L,1432287L,5414201L,20125565L,80661495L,273257927L,1073041080L,3588277692L,13732078994L,49417761548L,176544997915L,551992576980L,2143844160219L,7367037483012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073344Inst : IEnumerable<long>
{
public static readonly long[] Value=A073344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073344.Bytes);
public long this[int i]=>Value[i];

public static A073344Inst Instance=new A073344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073345
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,6L,8L,0L,0L,0L,0L,0L,0L,0L,4L,20L,0L,0L,0L,0L,0L,0L,0L,0L,1L,40L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,68L,56L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,94L,152L,32L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,114L,376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073345Inst : IEnumerable<long>
{
public static readonly long[] Value=A073345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073345.Bytes);
public long this[int i]=>Value[i];

public static A073345Inst Instance=new A073345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073346
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,0L,0L,0L,0L,2L,4L,0L,0L,0L,0L,1L,0L,8L,8L,0L,0L,0L,0L,0L,0L,12L,16L,0L,0L,0L,0L,0L,0L,2L,12L,40L,16L,0L,0L,0L,0L,0L,0L,2L,12L,80L,48L,0L,0L,0L,0L,0L,0L,0L,0L,12L,136L,144L,32L,0L,0L,0L,0L,0L,0L,0L,2L,20L,224L,384L,128L,0L,0L,0L,0L,0L,0L,0L,0L,0L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073346Inst : IEnumerable<long>
{
public static readonly long[] Value=A073346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073346.Bytes);
public long this[int i]=>Value[i];

public static A073346Inst Instance=new A073346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073347
{
public static readonly long[] Value={ 5L,14L,28L,46L,69L,97L,130L,168L,211L,259L,311L,368L,430L,497L,569L,646L,728L,815L,907L,1004L,1105L,1211L,1322L,1438L,1559L,1685L,1816L,1952L,2093L,2239L,2390L,2546L,2706L,2871L,3041L,3216L,3396L,3581L,3771L,3966L,4166L,4371L,4581L,4796L,5016L,5240L,5469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073347Inst : IEnumerable<long>
{
public static readonly long[] Value=A073347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073347.Bytes);
public long this[int i]=>Value[i];

public static A073347Inst Instance=new A073347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073364
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,9L,4L,36L,36L,676L,400L,9216L,3600L,44100L,36100L,1223236L,583696L,14130081L,5461569L,158180929L,96275344L,5486661184L,2454013444L,179677645456L,108938283364L,5446753133584L,4551557699844L,280114147765321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073364Inst : IEnumerable<long>
{
public static readonly long[] Value=A073364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073364.Bytes);
public long this[int i]=>Value[i];

public static A073364Inst Instance=new A073364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073365
{
public static readonly long[] Value={ 1L,3L,5L,1L,6L,8L,7L,0L,1L,6L,2L,0L,5L,2L,9L,6L,2L,7L,6L,9L,9L,9L,5L,8L,1L,2L,8L,2L,3L,5L,1L,5L,9L,2L,9L,8L,6L,6L,8L,4L,2L,1L,8L,9L,5L,7L,3L,2L,0L,6L,4L,2L,5L,0L,4L,2L,0L,5L,3L,6L,0L,7L,4L,6L,0L,6L,5L,9L,8L,2L,6L,9L,3L,7L,7L,0L,3L,0L,4L,4L,7L,0L,9L,6L,9L,7L,3L,4L,6L,8L,5L,9L,0L,9L,3L,8L,5L,7L,4L,3L,3L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073365Inst : IEnumerable<long>
{
public static readonly long[] Value=A073365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073365.Bytes);
public long this[int i]=>Value[i];

public static A073365Inst Instance=new A073365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073366
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,3L,4L,1L,1L,5L,1L,7L,8L,5L,1L,7L,5L,1L,1L,5L,5L,7L,5L,1L,17L,1L,18L,13L,11L,11L,7L,11L,7L,13L,13L,11L,11L,17L,13L,23L,19L,17L,13L,25L,31L,29L,25L,23L,23L,25L,29L,29L,29L,29L,25L,31L,29L,31L,35L,43L,41L,37L,35L,2L,1L,4L,49L,3L,2L,10L,9L,8L,5L,4L,5L,9L,10L,13L,8L,18L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073366Inst : IEnumerable<long>
{
public static readonly long[] Value=A073366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073366.Bytes);
public long this[int i]=>Value[i];

public static A073366Inst Instance=new A073366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073367
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,3L,0L,3L,4L,3L,1L,8L,0L,8L,0L,10L,9L,8L,9L,8L,8L,7L,6L,6L,8L,7L,8L,8L,7L,6L,5L,4L,6L,5L,4L,3L,4L,4L,6L,5L,4L,3L,4L,4L,3L,2L,2L,2L,3L,2L,1L,0L,0L,40L,0L,0L,1L,0L,43L,43L,44L,44L,45L,45L,45L,45L,46L,47L,48L,48L,49L,50L,50L,50L,52L,53L,53L,53L,55L,55L,55L,55L,55L,55L,56L,56L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073367Inst : IEnumerable<long>
{
public static readonly long[] Value=A073367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073367.Bytes);
public long this[int i]=>Value[i];

public static A073367Inst Instance=new A073367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073368
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,0L,1L,0L,1L,0L,7L,7L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,18L,18L,19L,19L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,22L,22L,22L,22L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073368Inst : IEnumerable<long>
{
public static readonly long[] Value=A073368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073368.Bytes);
public long this[int i]=>Value[i];

public static A073368Inst Instance=new A073368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073369
{
public static readonly long[] Value={ 3L,2L,4L,4L,12L,3L,9L,3L,5L,5L,9L,5L,11L,13L,15L,13L,15L,4L,8L,10L,14L,4L,6L,4L,8L,6L,10L,6L,8L,10L,12L,10L,18L,6L,10L,12L,14L,12L,14L,14L,20L,16L,18L,14L,16L,14L,26L,16L,24L,5L,7L,9L,11L,9L,15L,11L,13L,15L,17L,5L,9L,5L,9L,7L,9L,5L,7L,9L,13L,9L,11L,7L,9L,11L,21L,11L,15L,7L,9L,9L,11L,11L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073369Inst : IEnumerable<long>
{
public static readonly long[] Value=A073369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073369.Bytes);
public long this[int i]=>Value[i];

public static A073369Inst Instance=new A073369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073370
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,5L,7L,3L,1L,11L,16L,12L,4L,1L,21L,41L,34L,18L,5L,1L,43L,94L,99L,60L,25L,6L,1L,85L,219L,261L,195L,95L,33L,7L,1L,171L,492L,678L,576L,340L,140L,42L,8L,1L,341L,1101L,1692L,1644L,1106L,546L,196L,52L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073370Inst : IEnumerable<long>
{
public static readonly long[] Value=A073370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073370.Bytes);
public long this[int i]=>Value[i];

public static A073370Inst Instance=new A073370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073371
{
public static readonly long[] Value={ 1L,2L,7L,16L,41L,94L,219L,492L,1101L,2426L,5311L,11528L,24881L,53398L,114083L,242724L,514581L,1087410L,2291335L,4815680L,10097401L,21126862L,44117867L,91963996L,191384541L,397682154L,825190479L,1710033272L,3539371201L,7317351686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073371Inst : IEnumerable<long>
{
public static readonly long[] Value=A073371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073371.Bytes);
public long this[int i]=>Value[i];

public static A073371Inst Instance=new A073371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073372
{
public static readonly long[] Value={ 1L,3L,12L,34L,99L,261L,678L,1692L,4149L,9959L,23568L,55014L,127031L,290457L,658602L,1482240L,3314025L,7365915L,16285300L,35832810L,78500811L,171293293L,372412782L,806963364L,1743173469L,3754782351L,8066319768L,17285917742L,36957928479L,78847115649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073372Inst : IEnumerable<long>
{
public static readonly long[] Value=A073372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073372.Bytes);
public long this[int i]=>Value[i];

public static A073372Inst Instance=new A073372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073373
{
public static readonly long[] Value={ 1L,4L,18L,60L,195L,576L,1644L,4488L,11925L,30860L,78278L,195012L,478599L,1159080L,2774880L,6575280L,15439065L,35955540L,83118970L,190862860L,435601611L,988620624L,2232236628L,5016441240L,11224087965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073373Inst : IEnumerable<long>
{
public static readonly long[] Value=A073373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073373.Bytes);
public long this[int i]=>Value[i];

public static A073373Inst Instance=new A073373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073374
{
public static readonly long[] Value={ 1L,5L,25L,95L,340L,1106L,3430L,10130L,28915L,80035L,216143L,571225L,1482110L,3783640L,9522740L,23665300L,58149845L,141435985L,340854645L,814589475L,1931900376L,4549699950L,10645737330L,24761578470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073374Inst : IEnumerable<long>
{
public static readonly long[] Value=A073374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073374.Bytes);
public long this[int i]=>Value[i];

public static A073374Inst Instance=new A073374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073375
{
public static readonly long[] Value={ 1L,6L,33L,140L,546L,1932L,6454L,20448L,62271L,183202L,523887L,1461516L,3991400L,10698072L,28203612L,73265056L,187822125L,475788222L,1192287117L,2958453036L,7274927646L,17741533668L,42937126290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073375Inst : IEnumerable<long>
{
public static readonly long[] Value=A073375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073375.Bytes);
public long this[int i]=>Value[i];

public static A073375Inst Instance=new A073375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073376
{
public static readonly long[] Value={ 1L,7L,42L,196L,826L,3150L,11256L,38004L,122787L,381997L,1151458L,3376968L,9671284L,27123292L,74669472L,202181112L,539342181L,1419492627L,3690464106L,9487902396L,24143758254L,60861096714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073376Inst : IEnumerable<long>
{
public static readonly long[] Value=A073376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073376.Bytes);
public long this[int i]=>Value[i];

public static A073376Inst Instance=new A073376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073377
{
public static readonly long[] Value={ 1L,8L,52L,264L,1194L,4872L,18516L,66264L,226083L,740608L,2344232L,7202416L,21562164L,63090288L,180884088L,509245776L,1410356133L,3848340312L,10359516684L,27544099704L,72406891326L,188356187448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073377Inst : IEnumerable<long>
{
public static readonly long[] Value=A073377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073377.Bytes);
public long this[int i]=>Value[i];

public static A073377Inst Instance=new A073377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073378
{
public static readonly long[] Value={ 1L,9L,63L,345L,1665L,7227L,29073L,109791L,394020L,1354210L,4486482L,14397318L,44932446L,136817370L,407566350L,1190446866L,3415935699L,9645169743L,26836557825L,73670997015L,199751003991L,535449185469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073378Inst : IEnumerable<long>
{
public static readonly long[] Value=A073378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073378.Bytes);
public long this[int i]=>Value[i];

public static A073378Inst Instance=new A073378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073379
{
public static readonly long[] Value={ 1L,10L,75L,440L,2255L,10362L,43945L,174460L,656370L,2359500L,8158722L,27275040L,88524930L,279892380L,864508590L,2614740216L,7759693095L,22634343270L,64990287285L,183929970840L,513661549401L,1416970676550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073379Inst : IEnumerable<long>
{
public static readonly long[] Value=A073379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073379.Bytes);
public long this[int i]=>Value[i];

public static A073379Inst Instance=new A073379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073396
{
public static readonly long[] Value={ 16L,27L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073396Inst : IEnumerable<long>
{
public static readonly long[] Value=A073396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073396.Bytes);
public long this[int i]=>Value[i];

public static A073396Inst Instance=new A073396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073397
{
public static readonly long[] Value={ 1L,18L,198L,1680L,12060L,76824L,446952L,2420352L,12363120L,60151520L,280833696L,1265442048L,5528697408L,23507763840L,97575960960L,396398370816L,1579498956288L,6184543546368L,23833455191040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073397Inst : IEnumerable<long>
{
public static readonly long[] Value=A073397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073397.Bytes);
public long this[int i]=>Value[i];

public static A073397Inst Instance=new A073397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073398
{
public static readonly long[] Value={ 1L,20L,240L,2200L,16940L,115104L,711040L,4072640L,21930480L,112157760L,549010176L,2587777920L,11802273600L,52287866880L,225756241920L,952486588416L,3935984616960L,15961485957120L,63628396339200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073398Inst : IEnumerable<long>
{
public static readonly long[] Value=A073398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073398.Bytes);
public long this[int i]=>Value[i];

public static A073398Inst Instance=new A073398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073399
{
public static readonly long[] Value={ 1L,9L,30L,63L,531L,1050L,405L,6165L,29610L,44520L,2511L,59454L,502821L,1789614L,2245320L,15309L,517104L,6686631L,41182344L,120133692L,131891760L,92583L,4214349L,76790673L,714174327L,3559509360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073399Inst : IEnumerable<long>
{
public static readonly long[] Value=A073399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073399.Bytes);
public long this[int i]=>Value[i];

public static A073399Inst Instance=new A073399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073400
{
public static readonly long[] Value={ 2L,9L,33L,45L,396L,831L,243L,3744L,18297L,28236L,1377L,32481L,273483L,968679L,1210140L,8019L,268029L,3418767L,20681811L,58920534L,62686440L,47385L,2130138L,38186478L,347584284L,1683064737L,4075425738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073400Inst : IEnumerable<long>
{
public static readonly long[] Value=A073400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073400.Bytes);
public long this[int i]=>Value[i];

public static A073400Inst Instance=new A073400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073401
{
public static readonly long[] Value={ 1L,30L,9L,1050L,531L,63L,44520L,29610L,6165L,405L,2245320L,1789614L,502821L,59454L,2511L,131891760L,120133692L,41182344L,6686631L,517104L,15309L,8862693840L,8966770308L,3559509360L,714174327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073401Inst : IEnumerable<long>
{
public static readonly long[] Value=A073401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073401.Bytes);
public long this[int i]=>Value[i];

public static A073401Inst Instance=new A073401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073402
{
public static readonly long[] Value={ 2L,33L,9L,831L,396L,45L,28236L,18297L,3744L,243L,1210140L,968679L,273483L,32481L,1377L,62686440L,58920534L,20681811L,3418767L,268029L,8019L,3810867480L,4075425738L,1683064737L,347584284L,38186478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073402Inst : IEnumerable<long>
{
public static readonly long[] Value=A073402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073402.Bytes);
public long this[int i]=>Value[i];

public static A073402Inst Instance=new A073402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073403
{
public static readonly long[] Value={ 1L,12L,36L,120L,888L,1536L,1152L,15168L,62592L,80448L,10944L,222336L,1600704L,4813056L,5068800L,103680L,2992896L,32811264L,169917696L,413351424L,375598080L,981504L,38112768L,587976192L,4592982528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073403Inst : IEnumerable<long>
{
public static readonly long[] Value=A073403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073403.Bytes);
public long this[int i]=>Value[i];

public static A073403Inst Instance=new A073403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073404
{
public static readonly long[] Value={ 2L,12L,36L,96L,672L,1056L,864L,10752L,40416L,43968L,8064L,156672L,1051776L,2815488L,2396160L,76032L,2121984L,22125312L,105981696L,226492416L,161879040L,718848L,27205632L,404656128L,2995605504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073404Inst : IEnumerable<long>
{
public static readonly long[] Value=A073404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073404.Bytes);
public long this[int i]=>Value[i];

public static A073404Inst Instance=new A073404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073405
{
public static readonly long[] Value={ 1L,36L,12L,1536L,888L,120L,80448L,62592L,15168L,1152L,5068800L,4813056L,1600704L,222336L,10944L,375598080L,413351424L,169917696L,32811264L,2992896L,103680L,32103751680L,39661608960L,19066503168L,4592982528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073405Inst : IEnumerable<long>
{
public static readonly long[] Value=A073405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073405.Bytes);
public long this[int i]=>Value[i];

public static A073405Inst Instance=new A073405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073406
{
public static readonly long[] Value={ 2L,36L,12L,1056L,672L,96L,43968L,40416L,10752L,864L,2396160L,2815488L,1051776L,156672L,8064L,161879040L,226492416L,105981696L,22125312L,2121984L,76032L,13044326400L,20766633984L,11446769664L,2995605504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073406Inst : IEnumerable<long>
{
public static readonly long[] Value=A073406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073406.Bytes);
public long this[int i]=>Value[i];

public static A073406Inst Instance=new A073406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073407
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,3L,1L,3L,2L,4L,1L,4L,2L,4L,1L,5L,1L,4L,2L,4L,3L,5L,1L,5L,3L,4L,2L,5L,3L,5L,1L,5L,4L,5L,1L,5L,3L,5L,2L,6L,3L,5L,3L,5L,4L,6L,1L,5L,4L,6L,3L,6L,1L,6L,2L,5L,4L,6L,3L,6L,4L,5L,1L,6L,4L,6L,4L,6L,4L,6L,1L,6L,4L,6L,3L,6L,4L,6L,2L,5L,5L,7L,3L,7L,4L,6L,3L,7L,4L,6L,4L,6L,5L,6L,1L,7L,4L,6L,4L,7L,5L,7L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073407Inst : IEnumerable<long>
{
public static readonly long[] Value=A073407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073407.Bytes);
public long this[int i]=>Value[i];

public static A073407Inst Instance=new A073407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073408
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,3L,2L,1L,1L,4L,1L,3L,2L,4L,1L,2L,1L,4L,1L,3L,1L,5L,1L,1L,2L,5L,2L,4L,1L,5L,3L,3L,1L,6L,1L,4L,2L,5L,1L,2L,1L,6L,2L,4L,1L,6L,3L,3L,3L,6L,1L,5L,1L,5L,2L,1L,2L,6L,1L,5L,3L,6L,1L,4L,1L,6L,3L,5L,2L,7L,1L,3L,1L,7L,1L,6L,4L,6L,2L,4L,1L,7L,2L,5L,3L,6L,2L,2L,1L,6L,4L,6L,1L,7L,1L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073408Inst : IEnumerable<long>
{
public static readonly long[] Value=A073408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073408.Bytes);
public long this[int i]=>Value[i];

public static A073408Inst Instance=new A073408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073409
{
public static readonly long[] Value={ 3L,5L,7L,5L,11L,13L,3L,17L,19L,11L,23L,13L,3L,29L,31L,17L,3L,37L,3L,41L,43L,23L,47L,17L,11L,53L,19L,29L,59L,61L,3L,17L,67L,5L,71L,73L,3L,5L,79L,41L,83L,43L,3L,89L,31L,47L,3L,97L,3L,101L,103L,53L,107L,109L,23L,113L,7L,59L,3L,61L,3L,5L,127L,17L,131L,67L,3L,137L,139L,71L,3L,73L,3L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073409Inst : IEnumerable<long>
{
public static readonly long[] Value=A073409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073409.Bytes);
public long this[int i]=>Value[i];

public static A073409Inst Instance=new A073409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073410
{
public static readonly BigInteger[] Value={ 1L,0L,0L,2L,8L,0L,0L,576L,4608L,0L,0L,2505600L,30067200L,0L,0L,53444966400L,855119462400L,0L,0L,3587014803456000L,71740296069120000L,0L,0L,BigInteger.Parse("584198928937451520000"),BigInteger.Parse("14020774294498836480000"),0L,0L,BigInteger.Parse("196340349691596912721920000"),BigInteger.Parse("5497529791364713556213760000"),0L,0L };
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
public class A073410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073410Inst Instance=new A073410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073411
{
public static readonly long[] Value={ 2L,6L,8L,4L,12L,10L,14L,6L,18L,14L,20L,16L,24L,16L,20L,30L,18L,32L,22L,38L,26L,22L,10L,42L,44L,24L,48L,22L,32L,34L,54L,28L,12L,60L,62L,40L,26L,68L,34L,44L,28L,72L,46L,36L,74L,28L,50L,80L,30L,84L,32L,42L,56L,90L,46L,16L,98L,62L,34L,48L,102L,64L,104L,38L,108L,34L,110L,52L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073411Inst : IEnumerable<long>
{
public static readonly long[] Value=A073411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073411.Bytes);
public long this[int i]=>Value[i];

public static A073411Inst Instance=new A073411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073428
{
public static readonly BigInteger[] Value={ 3L,13L,911L,5791L,79111L,105107L,1232527L,23252729L,113151719L,2527293133L,57911131517L,991011031051L,6769717375777L,13579111315171L,135791113151719L,4547495153555759L,31517192123252729L,719212325272931333L,1131517192123252729L,BigInteger.Parse("71921232527293133353") };
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
public class A073428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073428Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073428.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073428Inst Instance=new A073428Inst();

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