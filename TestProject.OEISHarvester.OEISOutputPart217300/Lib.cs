using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A255682
{
public static readonly long[] Value={ 3L,7L,13L,15L,21L,73L,231L,301L,493L,895L,955L,4069L,5057L,5415L,15325L,19845L,21603L,24577L,37877L,40193L,44283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255682Inst : IEnumerable<long>
{
public static readonly long[] Value=A255682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255682.Bytes);
public long this[int i]=>Value[i];

public static A255682Inst Instance=new A255682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255683
{
public static readonly long[] Value={ 1L,3L,6L,7L,14L,14L,21L,15L,30L,30L,45L,30L,45L,45L,60L,31L,62L,62L,93L,62L,93L,93L,124L,62L,93L,93L,124L,93L,124L,124L,155L,63L,126L,126L,189L,126L,189L,189L,252L,126L,189L,189L,252L,189L,252L,252L,315L,126L,189L,189L,252L,189L,252L,252L,315L,189L,252L,252L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255683Inst : IEnumerable<long>
{
public static readonly long[] Value=A255683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255683.Bytes);
public long this[int i]=>Value[i];

public static A255683Inst Instance=new A255683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255684
{
public static readonly long[] Value={ 58L,406L,754L,986L,1682L,1798L,2146L,2494L,2726L,3422L,3886L,4118L,4234L,5626L,5858L,5974L,6206L,7366L,7946L,8062L,8642L,8758L,9106L,9454L,9686L,11194L,11426L,11542L,11774L,12586L,12934L,13166L,13282L,13978L,14906L,15022L,15254L,15602L,15718L,16414L,17458L,18038L,18154L,18386L,19198L,19546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255684Inst : IEnumerable<long>
{
public static readonly long[] Value=A255684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255684.Bytes);
public long this[int i]=>Value[i];

public static A255684Inst Instance=new A255684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255685
{
public static readonly long[] Value={ 1L,1L,7L,8L,7L,5L,9L,9L,9L,6L,5L,0L,5L,0L,9L,3L,2L,6L,8L,4L,1L,0L,1L,3L,9L,5L,0L,8L,3L,4L,1L,3L,7L,6L,1L,8L,7L,1L,5L,2L,1L,7L,5L,1L,3L,1L,7L,5L,9L,7L,5L,0L,6L,3L,3L,2L,2L,2L,4L,5L,2L,4L,1L,8L,5L,4L,2L,7L,1L,1L,0L,1L,2L,1L,0L,1L,3L,6L,4L,1L,3L,2L,4L,3L,7L,0L,1L,7L,4L,6L,4L,8L,2L,7L,1L,2L,5L,9L,5L,1L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255685Inst : IEnumerable<long>
{
public static readonly long[] Value=A255685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255685.Bytes);
public long this[int i]=>Value[i];

public static A255685Inst Instance=new A255685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255686
{
public static readonly long[] Value={ 3L,9L,12L,15L,18L,21L,27L,33L,39L,45L,51L,63L,69L,87L,93L,111L,123L,135L,141L,153L,159L,177L,189L,201L,219L,225L,237L,249L,255L,267L,291L,303L,309L,321L,339L,363L,381L,393L,411L,423L,453L,459L,501L,537L,543L,573L,579L,633L,669L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255686Inst : IEnumerable<long>
{
public static readonly long[] Value=A255686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255686.Bytes);
public long this[int i]=>Value[i];

public static A255686Inst Instance=new A255686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255687
{
public static readonly long[] Value={ 0L,6L,25L,64L,130L,230L,371L,560L,804L,1110L,1485L,1936L,2470L,3094L,3815L,4640L,5576L,6630L,7809L,9120L,10570L,12166L,13915L,15824L,17900L,20150L,22581L,25200L,28014L,31030L,34255L,37696L,41360L,45254L,49385L,53760L,58386L,63270L,68419L,73840L,79540L,85526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255687Inst : IEnumerable<long>
{
public static readonly long[] Value=A255687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255687.Bytes);
public long this[int i]=>Value[i];

public static A255687Inst Instance=new A255687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255688
{
public static readonly long[] Value={ 1L,3L,15L,90L,579L,3858L,26262L,181380L,1265955L,8906706L,63058530L,448716876L,3206387790L,22992276180L,165364807308L,1192393813320L,8617219956003L,62397513984210L,452607991376490L,3288138397237884L,23921128800374874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255688Inst : IEnumerable<long>
{
public static readonly long[] Value=A255688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255688.Bytes);
public long this[int i]=>Value[i];

public static A255688Inst Instance=new A255688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255689
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,5L,9L,13L,2L,6L,10L,14L,3L,7L,11L,15L,1L,5L,9L,13L,17L,21L,25L,29L,33L,37L,41L,45L,49L,53L,57L,61L,2L,6L,10L,14L,18L,22L,26L,30L,34L,38L,42L,46L,50L,54L,58L,62L,3L,7L,11L,15L,19L,23L,27L,31L,35L,39L,43L,47L,51L,55L,59L,63L,1L,5L,9L,13L,17L,21L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255689Inst : IEnumerable<long>
{
public static readonly long[] Value=A255689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255689.Bytes);
public long this[int i]=>Value[i];

public static A255689Inst Instance=new A255689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255690
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,1L,6L,11L,16L,21L,2L,7L,12L,17L,22L,3L,8L,13L,18L,23L,4L,9L,14L,19L,24L,1L,6L,11L,16L,21L,26L,31L,36L,41L,46L,51L,56L,61L,66L,71L,76L,81L,86L,91L,96L,101L,106L,111L,116L,121L,2L,7L,12L,17L,22L,27L,32L,37L,42L,47L,52L,57L,62L,67L,72L,77L,82L,87L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255690Inst : IEnumerable<long>
{
public static readonly long[] Value=A255690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255690.Bytes);
public long this[int i]=>Value[i];

public static A255690Inst Instance=new A255690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255691
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,1L,7L,13L,19L,25L,31L,2L,8L,14L,20L,26L,32L,3L,9L,15L,21L,27L,33L,4L,10L,16L,22L,28L,34L,5L,11L,17L,23L,29L,35L,1L,7L,13L,19L,25L,31L,37L,43L,49L,55L,61L,67L,73L,79L,85L,91L,97L,103L,109L,115L,121L,127L,133L,139L,145L,151L,157L,163L,169L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255691Inst : IEnumerable<long>
{
public static readonly long[] Value=A255691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255691.Bytes);
public long this[int i]=>Value[i];

public static A255691Inst Instance=new A255691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255692
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,1L,8L,15L,22L,29L,36L,43L,2L,9L,16L,23L,30L,37L,44L,3L,10L,17L,24L,31L,38L,45L,4L,11L,18L,25L,32L,39L,46L,5L,12L,19L,26L,33L,40L,47L,6L,13L,20L,27L,34L,41L,48L,1L,8L,15L,22L,29L,36L,43L,50L,57L,64L,71L,78L,85L,92L,99L,106L,113L,120L,127L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255692Inst : IEnumerable<long>
{
public static readonly long[] Value=A255692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255692.Bytes);
public long this[int i]=>Value[i];

public static A255692Inst Instance=new A255692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255693
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,1L,9L,17L,25L,33L,41L,49L,57L,2L,10L,18L,26L,34L,42L,50L,58L,3L,11L,19L,27L,35L,43L,51L,59L,4L,12L,20L,28L,36L,44L,52L,60L,5L,13L,21L,29L,37L,45L,53L,61L,6L,14L,22L,30L,38L,46L,54L,62L,7L,15L,23L,31L,39L,47L,55L,63L,1L,9L,17L,25L,33L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255693Inst : IEnumerable<long>
{
public static readonly long[] Value=A255693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255693.Bytes);
public long this[int i]=>Value[i];

public static A255693Inst Instance=new A255693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255694
{
public static readonly long[] Value={ 1538419L,3662941L,10835789L,11698837L,13441633L,16002521L,19039199L,28598753L,29170307L,57766903L,58309837L,60324577L,71197453L,75817459L,84834049L,86506051L,127779919L,130415413L,184465669L,189978779L,221705713L,230700227L,231203779L,239519327L,255285439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255694Inst : IEnumerable<long>
{
public static readonly long[] Value=A255694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255694.Bytes);
public long this[int i]=>Value[i];

public static A255694Inst Instance=new A255694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255695
{
public static readonly long[] Value={ 4L,6L,1L,2L,8L,9L,7L,8L,7L,7L,9L,3L,5L,0L,1L,0L,0L,7L,0L,7L,7L,6L,1L,3L,7L,1L,9L,3L,4L,3L,3L,5L,2L,8L,1L,3L,6L,7L,9L,4L,0L,7L,7L,0L,4L,9L,8L,2L,1L,7L,0L,6L,6L,2L,8L,3L,5L,3L,5L,9L,3L,1L,3L,6L,4L,0L,3L,5L,8L,0L,0L,3L,6L,6L,1L,4L,4L,8L,9L,1L,5L,0L,0L,6L,0L,5L,9L,2L,9L,6L,8L,8L,2L,8L,1L,5L,5L,5L,0L,2L,3L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255695Inst : IEnumerable<long>
{
public static readonly long[] Value=A255695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255695.Bytes);
public long this[int i]=>Value[i];

public static A255695Inst Instance=new A255695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255696
{
public static readonly long[] Value={ 1L,8L,7L,2L,6L,8L,2L,4L,4L,9L,7L,6L,8L,5L,4L,6L,1L,1L,5L,6L,3L,8L,5L,7L,9L,4L,7L,9L,9L,6L,1L,3L,9L,8L,8L,6L,9L,1L,6L,2L,8L,9L,5L,6L,5L,2L,6L,1L,9L,5L,6L,3L,8L,4L,1L,3L,3L,1L,5L,7L,4L,5L,3L,7L,8L,8L,4L,3L,1L,9L,5L,1L,7L,0L,9L,8L,0L,2L,2L,6L,7L,5L,1L,7L,0L,7L,2L,7L,8L,4L,0L,2L,4L,5L,6L,7L,9L,7L,9L,9L,8L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255696Inst : IEnumerable<long>
{
public static readonly long[] Value=A255696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255696.Bytes);
public long this[int i]=>Value[i];

public static A255696Inst Instance=new A255696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255697
{
public static readonly long[] Value={ 3L,4L,8L,7L,3L,6L,0L,5L,9L,8L,6L,0L,0L,6L,0L,8L,5L,4L,7L,0L,0L,9L,7L,5L,3L,4L,8L,5L,7L,0L,4L,8L,8L,1L,0L,4L,4L,6L,6L,2L,7L,5L,6L,4L,5L,6L,4L,6L,5L,7L,2L,2L,0L,0L,7L,8L,6L,2L,0L,7L,2L,2L,5L,5L,5L,6L,0L,5L,6L,5L,2L,1L,6L,1L,2L,4L,4L,7L,5L,0L,3L,3L,2L,4L,0L,0L,1L,8L,7L,2L,6L,2L,6L,5L,2L,9L,6L,2L,7L,9L,2L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255697Inst : IEnumerable<long>
{
public static readonly long[] Value=A255697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255697.Bytes);
public long this[int i]=>Value[i];

public static A255697Inst Instance=new A255697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255698
{
public static readonly long[] Value={ 4L,5L,4L,0L,2L,6L,1L,7L,2L,7L,7L,2L,8L,1L,1L,1L,6L,7L,3L,1L,5L,8L,3L,1L,1L,5L,8L,4L,6L,8L,9L,6L,1L,8L,9L,6L,9L,6L,1L,0L,6L,0L,6L,9L,0L,4L,0L,5L,8L,4L,9L,0L,1L,9L,9L,4L,3L,5L,7L,1L,2L,8L,8L,5L,9L,3L,7L,5L,9L,0L,7L,7L,7L,7L,9L,9L,8L,0L,0L,0L,5L,6L,4L,3L,4L,1L,4L,8L,9L,0L,5L,2L,9L,0L,4L,4L,5L,4L,5L,5L,6L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255698Inst : IEnumerable<long>
{
public static readonly long[] Value=A255698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255698.Bytes);
public long this[int i]=>Value[i];

public static A255698Inst Instance=new A255698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255699
{
public static readonly long[] Value={ 1L,8L,7L,1L,3L,7L,2L,7L,5L,9L,3L,6L,6L,0L,2L,7L,3L,7L,8L,8L,3L,7L,0L,4L,5L,5L,4L,9L,0L,2L,4L,3L,5L,5L,7L,7L,1L,8L,8L,7L,4L,6L,4L,8L,3L,3L,0L,7L,2L,0L,9L,7L,6L,0L,1L,1L,1L,9L,1L,2L,9L,9L,0L,3L,0L,9L,4L,1L,3L,1L,6L,1L,3L,1L,2L,1L,0L,7L,2L,3L,0L,3L,9L,0L,2L,3L,6L,1L,0L,5L,1L,4L,9L,9L,6L,0L,2L,4L,5L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255699Inst : IEnumerable<long>
{
public static readonly long[] Value=A255699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255699.Bytes);
public long this[int i]=>Value[i];

public static A255699Inst Instance=new A255699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255700
{
public static readonly long[] Value={ 3L,4L,8L,7L,3L,5L,6L,0L,3L,8L,0L,0L,4L,2L,7L,6L,0L,5L,4L,5L,1L,4L,7L,3L,0L,3L,2L,2L,5L,4L,8L,9L,7L,6L,2L,6L,4L,6L,5L,1L,1L,4L,6L,8L,2L,7L,0L,3L,3L,8L,8L,4L,5L,2L,5L,6L,7L,9L,0L,9L,9L,1L,1L,3L,6L,6L,5L,3L,8L,3L,9L,7L,8L,3L,9L,2L,8L,0L,4L,1L,8L,3L,0L,7L,7L,0L,0L,4L,7L,8L,5L,1L,1L,7L,3L,5L,8L,6L,5L,8L,0L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255700Inst : IEnumerable<long>
{
public static readonly long[] Value=A255700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255700.Bytes);
public long this[int i]=>Value[i];

public static A255700Inst Instance=new A255700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255701
{
public static readonly long[] Value={ 4L,5L,2L,2L,4L,5L,0L,7L,7L,1L,0L,6L,7L,3L,4L,3L,0L,5L,6L,0L,8L,5L,1L,1L,4L,9L,5L,5L,1L,7L,0L,5L,5L,5L,7L,1L,4L,5L,3L,3L,1L,6L,3L,2L,1L,9L,5L,0L,1L,4L,7L,2L,0L,1L,9L,2L,1L,0L,6L,0L,1L,7L,6L,5L,6L,5L,6L,3L,9L,5L,0L,6L,8L,5L,1L,8L,4L,2L,8L,3L,5L,6L,0L,2L,8L,6L,6L,4L,8L,1L,4L,3L,6L,3L,4L,9L,1L,8L,9L,4L,9L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255701Inst : IEnumerable<long>
{
public static readonly long[] Value=A255701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255701.Bytes);
public long this[int i]=>Value[i];

public static A255701Inst Instance=new A255701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255702
{
public static readonly long[] Value={ 1L,8L,7L,1L,0L,4L,5L,6L,0L,5L,3L,0L,1L,2L,5L,9L,5L,1L,4L,8L,7L,3L,9L,5L,1L,4L,7L,5L,8L,1L,0L,5L,6L,3L,4L,3L,0L,3L,1L,8L,9L,6L,2L,8L,2L,3L,0L,8L,7L,5L,8L,2L,8L,6L,5L,6L,0L,4L,2L,4L,5L,2L,7L,9L,8L,5L,5L,2L,5L,8L,3L,5L,4L,0L,9L,5L,1L,0L,4L,2L,3L,0L,2L,7L,7L,5L,4L,9L,7L,6L,1L,1L,3L,0L,7L,4L,8L,9L,6L,9L,7L,9L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255702Inst : IEnumerable<long>
{
public static readonly long[] Value=A255702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255702.Bytes);
public long this[int i]=>Value[i];

public static A255702Inst Instance=new A255702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255703
{
public static readonly long[] Value={ 3L,4L,8L,7L,3L,5L,4L,8L,9L,7L,8L,5L,6L,9L,3L,8L,2L,6L,7L,5L,9L,5L,6L,0L,4L,0L,5L,6L,1L,0L,5L,8L,5L,6L,1L,7L,1L,1L,6L,0L,6L,0L,4L,7L,2L,0L,7L,6L,4L,1L,7L,2L,0L,1L,7L,9L,3L,1L,0L,5L,4L,8L,0L,0L,3L,5L,2L,8L,7L,0L,7L,8L,1L,2L,1L,3L,2L,2L,6L,4L,7L,9L,1L,0L,0L,7L,6L,8L,1L,8L,3L,2L,0L,0L,9L,2L,8L,4L,1L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255703Inst : IEnumerable<long>
{
public static readonly long[] Value=A255703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255703.Bytes);
public long this[int i]=>Value[i];

public static A255703Inst Instance=new A255703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255704
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,1L,1L,0L,4L,3L,1L,1L,0L,8L,7L,3L,1L,1L,0L,17L,18L,8L,3L,1L,1L,0L,36L,45L,21L,8L,3L,1L,1L,0L,79L,116L,56L,22L,8L,3L,1L,1L,0L,175L,298L,152L,59L,22L,8L,3L,1L,1L,0L,395L,776L,413L,163L,60L,22L,8L,3L,1L,1L,0L,899L,2025L,1131L,450L,166L,60L,22L,8L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255704Inst : IEnumerable<long>
{
public static readonly long[] Value=A255704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255704.Bytes);
public long this[int i]=>Value[i];

public static A255704Inst Instance=new A255704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255705
{
public static readonly long[] Value={ 1L,1L,3L,8L,22L,60L,167L,465L,1306L,3681L,10422L,29597L,84313L,240757L,689035L,1975753L,5675145L,16326198L,47032200L,135658367L,391733593L,1132357784L,3276330780L,9487885056L,27497891241L,79753806451L,231474005120L,672250119756L,1953523496677L,5680002466125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255705Inst : IEnumerable<long>
{
public static readonly long[] Value=A255705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255705.Bytes);
public long this[int i]=>Value[i];

public static A255705Inst Instance=new A255705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255706
{
public static readonly long[] Value={ 1L,1L,1L,4L,11L,38L,151L,655L,3112L,16000L,88285L,519592L,3244512L,21400146L,148530179L,1081222613L,8231314455L,65369494593L,540322688516L,4639020151529L,41295634331020L,380514484523095L,3623898600072459L,35622399584611476L,360965731323718242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255706Inst : IEnumerable<long>
{
public static readonly long[] Value=A255706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255706.Bytes);
public long this[int i]=>Value[i];

public static A255706Inst Instance=new A255706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255707
{
public static readonly long[] Value={ 0L,2L,1L,1L,1L,4L,1L,1L,6L,1L,1L,24L,1L,2L,2L,1L,1L,2L,2L,1L,4L,1L,1L,2L,1L,8L,4L,1L,12L,4L,1L,1L,8L,3L,1L,2L,1L,1L,2L,38L,1L,4L,1L,4L,2L,1L,2L,4L,747L,1L,4L,1L,1L,2L,1L,1L,10L,1L,2L,2L,2L,6L,42L,2L,1L,2L,1L,2L,10L,1L,1L,4L,2L,16L,50L,1L,1L,2L,22L,1L,2L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255707Inst : IEnumerable<long>
{
public static readonly long[] Value=A255707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255707.Bytes);
public long this[int i]=>Value[i];

public static A255707Inst Instance=new A255707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255708
{
public static readonly long[] Value={ 0L,0L,1L,1L,-1L,-1L,4L,2L,2L,-3L,-5L,-2L,-7L,-2L,5L,3L,3L,-5L,-4L,-4L,6L,5L,-6L,-3L,-10L,11L,-6L,4L,18L,11L,19L,7L,12L,12L,6L,-13L,19L,7L,-10L,-7L,-9L,-14L,13L,23L,-28L,-8L,-14L,9L,8L,-22L,-9L,-8L,23L,-11L,15L,22L,13L,8L,-21L,-13L,-26L,9L,-12L,-12L,-11L,40L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255708Inst : IEnumerable<long>
{
public static readonly long[] Value=A255708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255708.Bytes);
public long this[int i]=>Value[i];

public static A255708Inst Instance=new A255708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255709
{
public static readonly long[] Value={ 0L,1L,-1L,2L,3L,-2L,-5L,-3L,4L,-6L,6L,-7L,-4L,5L,12L,16L,7L,8L,-10L,-8L,9L,19L,14L,-12L,-14L,-9L,21L,10L,-11L,-15L,17L,15L,-19L,13L,-22L,-13L,-16L,-24L,11L,18L,22L,-18L,25L,23L,-17L,24L,40L,-21L,-38L,20L,-29L,36L,-30L,-20L,32L,-34L,26L,43L,-23L,37L,-26L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255709Inst : IEnumerable<long>
{
public static readonly long[] Value=A255709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255709.Bytes);
public long this[int i]=>Value[i];

public static A255709Inst Instance=new A255709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255710
{
public static readonly long[] Value={ 2L,2L,4L,6L,8L,14L,19L,33L,69L,162L,325L,616L,1314L,2874L,6099L,11780L,21630L,42778L,95379L,225424L,532771L,1184433L,2434239L,4904932L,10213447L,21612164L,44580230L,89065496L,178617292L,373380471L,821875838L,1887456086L,4465488647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255710Inst : IEnumerable<long>
{
public static readonly long[] Value=A255710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255710.Bytes);
public long this[int i]=>Value[i];

public static A255710Inst Instance=new A255710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255711
{
public static readonly long[] Value={ 2L,4L,10L,21L,47L,102L,256L,754L,2169L,5999L,17237L,49510L,132956L,339522L,900236L,2620855L,8077245L,24619352L,71983144L,205409149L,584195761L,1647027286L,4572955010L,12705583667L,36182897964L,106766407391L,326242477740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255711Inst : IEnumerable<long>
{
public static readonly long[] Value=A255711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255711.Bytes);
public long this[int i]=>Value[i];

public static A255711Inst Instance=new A255711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255712
{
public static readonly long[] Value={ 3L,8L,26L,81L,261L,936L,3435L,12406L,45637L,165303L,579197L,2056418L,7724487L,30188921L,117283664L,443965914L,1645885655L,6011641972L,21768376301L,79175516820L,293501032240L,1120198277690L,4414668160947L,17781778665225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255712Inst : IEnumerable<long>
{
public static readonly long[] Value=A255712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255712.Bytes);
public long this[int i]=>Value[i];

public static A255712Inst Instance=new A255712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255713
{
public static readonly long[] Value={ 3L,9L,33L,120L,480L,2079L,9044L,39604L,170835L,720348L,3105394L,14050148L,64838808L,295178921L,1315098518L,5765163507L,25132740083L,110592507674L,498297998116L,2314042703759L,10991409243669L,52236818282458L,242186086327901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255713Inst : IEnumerable<long>
{
public static readonly long[] Value=A255713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255713.Bytes);
public long this[int i]=>Value[i];

public static A255713Inst Instance=new A255713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255714
{
public static readonly long[] Value={ 4L,17L,75L,342L,1707L,8814L,45735L,229317L,1129024L,5744720L,30448145L,163328140L,866397895L,4515528539L,23325358076L,121500213369L,648072229596L,3549923527103L,19654222272276L,107149613713782L,565522043746019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255714Inst : IEnumerable<long>
{
public static readonly long[] Value=A255714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255714.Bytes);
public long this[int i]=>Value[i];

public static A255714Inst Instance=new A255714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255715
{
public static readonly long[] Value={ 5L,24L,121L,653L,3764L,22155L,127375L,721134L,4201419L,25338485L,153827211L,920423497L,5427375260L,32034890790L,192848262264L,1192406909119L,7468582235924L,46184458084732L,277578788510692L,1635584886442562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255715Inst : IEnumerable<long>
{
public static readonly long[] Value=A255715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255715.Bytes);
public long this[int i]=>Value[i];

public static A255715Inst Instance=new A255715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255716
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,3L,4L,4L,1L,3L,8L,10L,6L,1L,4L,9L,26L,21L,8L,1L,5L,17L,33L,81L,47L,14L,1L,6L,24L,75L,120L,261L,102L,19L,1L,6L,32L,121L,342L,480L,936L,256L,33L,1L,7L,36L,191L,653L,1707L,2079L,3435L,754L,69L,1L,7L,48L,242L,1221L,3764L,8814L,9044L,12406L,2169L,162L,1L,8L,52L,374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255716Inst : IEnumerable<long>
{
public static readonly long[] Value=A255716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255716.Bytes);
public long this[int i]=>Value[i];

public static A255716Inst Instance=new A255716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255717
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,17L,24L,32L,36L,48L,52L,68L,83L,100L,107L,129L,136L,161L,184L,208L,217L,248L,275L,308L,338L,372L,386L,426L,439L,479L,518L,561L,603L,650L,666L,714L,761L,812L,832L,889L,909L,967L,1022L,1082L,1105L,1173L,1234L,1303L,1367L,1434L,1460L,1535L,1601L,1677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255717Inst : IEnumerable<long>
{
public static readonly long[] Value=A255717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255717.Bytes);
public long this[int i]=>Value[i];

public static A255717Inst Instance=new A255717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255718
{
public static readonly long[] Value={ 1L,4L,10L,26L,33L,75L,121L,191L,242L,374L,441L,638L,842L,1092L,1240L,1616L,1794L,2256L,2709L,3229L,3526L,4276L,4951L,5788L,6598L,7567L,8128L,9388L,9984L,11282L,12584L,14076L,15589L,17422L,18337L,20249L,22147L,24312L,25518L,28121L,29422L,32110L,34717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255718Inst : IEnumerable<long>
{
public static readonly long[] Value=A255718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255718.Bytes);
public long this[int i]=>Value[i];

public static A255718Inst Instance=new A255718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255719
{
public static readonly long[] Value={ 1L,6L,21L,81L,120L,342L,653L,1221L,1729L,3037L,3884L,6136L,8650L,12056L,14580L,20505L,24083L,32191L,40684L,51184L,58455L,74807L,90133L,110175L,130476L,155925L,173529L,209720L,230413L,269673L,310187L,358492L,408861L,473591L,512204L,582744L,654517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255719Inst : IEnumerable<long>
{
public static readonly long[] Value=A255719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255719.Bytes);
public long this[int i]=>Value[i];

public static A255719Inst Instance=new A255719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255720
{
public static readonly long[] Value={ 1L,8L,47L,261L,480L,1707L,3764L,8072L,12646L,24669L,34201L,58940L,89397L,135543L,174896L,264549L,327946L,465565L,617508L,818021L,977617L,1318930L,1657755L,2121986L,2611024L,3251371L,3748275L,4735382L,5375729L,6512710L,7733039L,9256904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255720Inst : IEnumerable<long>
{
public static readonly long[] Value=A255720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255720.Bytes);
public long this[int i]=>Value[i];

public static A255720Inst Instance=new A255720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255721
{
public static readonly long[] Value={ 1L,14L,102L,936L,2079L,8814L,22155L,53090L,91493L,200228L,304017L,575082L,941185L,1542708L,2114901L,3423009L,4480459L,6771099L,9448995L,13219018L,16542150L,23499170L,30786120L,41197560L,52676852L,68426580L,81835570L,108246990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255721Inst : IEnumerable<long>
{
public static readonly long[] Value=A255721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255721.Bytes);
public long this[int i]=>Value[i];

public static A255721Inst Instance=new A255721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255722
{
public static readonly long[] Value={ 1L,19L,256L,3435L,9044L,45735L,127375L,346499L,667623L,1659159L,2752326L,5689368L,9976897L,17538154L,25598415L,44565127L,61843772L,99471988L,145959173L,215170467L,281539258L,421251283L,576147610L,807868670L,1076649303L,1462427055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255722Inst : IEnumerable<long>
{
public static readonly long[] Value=A255722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255722.Bytes);
public long this[int i]=>Value[i];

public static A255722Inst Instance=new A255722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255723
{
public static readonly long[] Value={ 0L,-2L,-1L,2L,-2L,-4L,1L,0L,-1L,-3L,0L,1L,2L,0L,-3L,4L,-2L,-4L,1L,0L,-4L,-6L,3L,-2L,1L,-1L,-2L,3L,0L,-2L,-1L,2L,-1L,-3L,0L,1L,-3L,-5L,2L,-1L,0L,-2L,-1L,2L,1L,-1L,-2L,3L,2L,0L,-3L,4L,0L,-2L,-1L,2L,-3L,-5L,2L,-1L,4L,2L,-5L,6L,-2L,-4L,1L,0L,-4L,-6L,3L,-2L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255723Inst : IEnumerable<long>
{
public static readonly long[] Value=A255723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255723.Bytes);
public long this[int i]=>Value[i];

public static A255723Inst Instance=new A255723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255724
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,20L,22L,24L,25L,26L,27L,29L,30L,33L,35L,36L,37L,38L,40L,44L,46L,47L,49L,50L,55L,57L,58L,60L,66L,69L,70L,77L,80L,88L,90L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255724Inst : IEnumerable<long>
{
public static readonly long[] Value=A255724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255724.Bytes);
public long this[int i]=>Value[i];

public static A255724Inst Instance=new A255724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255725
{
public static readonly long[] Value={ 11L,12L,15L,24L,36L,101L,102L,104L,105L,110L,120L,125L,150L,208L,240L,306L,315L,360L,735L,1001L,1002L,1004L,1005L,1008L,1010L,1020L,1025L,1040L,1050L,1100L,1125L,1200L,1250L,1352L,1500L,1734L,2016L,2080L,2400L,3006L,3015L,3024L,3060L,3150L,3375L,3600L,6048L,7007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255725Inst : IEnumerable<long>
{
public static readonly long[] Value=A255725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255725.Bytes);
public long this[int i]=>Value[i];

public static A255725Inst Instance=new A255725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255726
{
public static readonly long[] Value={ 11L,12L,15L,24L,36L,110L,120L,125L,150L,240L,315L,360L,735L,1100L,1125L,1200L,1250L,1352L,1500L,1734L,2400L,3150L,3375L,3600L,7350L,11000L,11250L,12000L,12500L,13520L,14112L,15000L,17340L,18144L,21168L,24000L,31500L,33750L,36000L,42336L,63504L,67335L,73500L,91125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255726Inst : IEnumerable<long>
{
public static readonly long[] Value=A255726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255726.Bytes);
public long this[int i]=>Value[i];

public static A255726Inst Instance=new A255726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255727
{
public static readonly long[] Value={ 7L,0L,7L,7L,6L,0L,3L,9L,3L,1L,1L,5L,2L,8L,8L,0L,3L,5L,3L,9L,5L,2L,8L,0L,2L,1L,8L,3L,0L,2L,8L,2L,0L,0L,1L,3L,6L,5L,7L,5L,4L,6L,9L,6L,2L,0L,3L,3L,6L,3L,0L,2L,7L,5L,8L,3L,1L,7L,2L,7L,8L,8L,1L,6L,3L,6L,1L,8L,4L,5L,7L,2L,6L,4L,3L,8L,2L,0L,3L,6L,5L,8L,0L,8L,3L,1L,8L,8L,1L,2L,6L,6L,1L,7L,7L,2L,3L,8L,2L,0L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255727Inst : IEnumerable<long>
{
public static readonly long[] Value=A255727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255727.Bytes);
public long this[int i]=>Value[i];

public static A255727Inst Instance=new A255727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255728
{
public static readonly long[] Value={ 6L,8L,4L,0L,0L,0L,3L,8L,9L,4L,3L,7L,9L,3L,2L,1L,2L,9L,1L,8L,2L,7L,4L,4L,4L,5L,9L,9L,9L,2L,6L,6L,1L,1L,2L,6L,7L,1L,0L,9L,9L,1L,4L,8L,2L,6L,5L,4L,9L,9L,9L,4L,3L,4L,3L,2L,2L,6L,3L,0L,3L,7L,7L,1L,3L,8L,1L,5L,3L,0L,5L,8L,1L,2L,4L,9L,7L,6L,6L,3L,8L,1L,5L,0L,9L,5L,9L,8L,3L,4L,2L,1L,2L,7L,2L,1L,4L,7L,8L,6L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255728Inst : IEnumerable<long>
{
public static readonly long[] Value=A255728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255728.Bytes);
public long this[int i]=>Value[i];

public static A255728Inst Instance=new A255728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255729
{
public static readonly long[] Value={ 12L,23L,35L,47L,613L,819L,923L,1029L,1237L,1547L,1653L,1759L,1967L,2071L,2173L,2489L,2597L,27103L,28107L,35149L,39167L,40173L,45197L,53241L,57269L,58271L,60281L,61283L,69347L,70349L,72359L,79401L,85439L,89461L,90463L,91467L,93487L,96503L,98521L,104569L,108593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255729Inst : IEnumerable<long>
{
public static readonly long[] Value=A255729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255729.Bytes);
public long this[int i]=>Value[i];

public static A255729Inst Instance=new A255729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255730
{
public static readonly long[] Value={ 1L,2L,4L,16L,52L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255730Inst : IEnumerable<long>
{
public static readonly long[] Value=A255730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255730.Bytes);
public long this[int i]=>Value[i];

public static A255730Inst Instance=new A255730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255731
{
public static readonly long[] Value={ 3348L,3510L,6750L,17430L,18750L,18876L,18944L,19475L,20564L,21312L,26550L,28280L,37230L,38396L,43940L,48042L,77770L,88270L,91224L,97470L,108882L,111403L,120046L,123630L,181996L,182646L,235467L,253460L,260429L,264735L,278675L,289161L,295960L,296055L,306642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255731Inst : IEnumerable<long>
{
public static readonly long[] Value=A255731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255731.Bytes);
public long this[int i]=>Value[i];

public static A255731Inst Instance=new A255731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255732
{
public static readonly long[] Value={ 1815L,11050L,15295L,21165L,22165L,30702L,34510L,34645L,42292L,44165L,52059L,53416L,65945L,78430L,80712L,84251L,84835L,86591L,112608L,146055L,148144L,156284L,175419L,178350L,194590L,200655L,201825L,202664L,204085L,209095L,209550L,211250L,212346L,212850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255732Inst : IEnumerable<long>
{
public static readonly long[] Value=A255732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255732.Bytes);
public long this[int i]=>Value[i];

public static A255732Inst Instance=new A255732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255733
{
public static readonly long[] Value={ 3L,4L,6L,12L,26L,96L,137L,946L,1053L,2943L,6874L,17386L,39182L,60504L,114254L,167786L,393216L,497134L,645354L,5250086L,27914146L,448005874L,505235234L,708458286L,3238952914L,71258123714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255733Inst : IEnumerable<long>
{
public static readonly long[] Value=A255733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255733.Bytes);
public long this[int i]=>Value[i];

public static A255733Inst Instance=new A255733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255734
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,20L,30L,40L,50L,60L,70L,80L,90L,100L,102L,112L,120L,200L,207L,210L,220L,240L,300L,301L,330L,342L,360L,400L,453L,462L,500L,506L,573L,600L,700L,720L,800L,900L,924L,1000L,1002L,1008L,1015L,1020L,1026L,1116L,1120L,1145L,1200L,1320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255734Inst : IEnumerable<long>
{
public static readonly long[] Value=A255734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255734.Bytes);
public long this[int i]=>Value[i];

public static A255734Inst Instance=new A255734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255735
{
public static readonly long[] Value={ 1470L,3000L,8918L,17025L,19402L,20650L,21120L,22156L,26522L,36549L,38354L,43281L,46035L,48768L,54229L,54528L,56584L,58216L,58224L,62238L,68096L,68150L,73161L,74024L,74636L,87978L,94041L,114000L,124656L,132240L,133926L,135876L,153105L,153870L,156621L,159819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255735Inst : IEnumerable<long>
{
public static readonly long[] Value=A255735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255735.Bytes);
public long this[int i]=>Value[i];

public static A255735Inst Instance=new A255735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255736
{
public static readonly long[] Value={ 3024L,3168L,5115L,5346L,5950L,6762L,7750L,7956L,8470L,9476L,9576L,9849L,10360L,11495L,13035L,13356L,16335L,22610L,22784L,23864L,37515L,38025L,40704L,40986L,49887L,52925L,59800L,60955L,61812L,67782L,68590L,74800L,78430L,85063L,90160L,90649L,90897L,91540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255736Inst : IEnumerable<long>
{
public static readonly long[] Value=A255736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255736.Bytes);
public long this[int i]=>Value[i];

public static A255736Inst Instance=new A255736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255737
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,9L,13L,21L,22L,25L,29L,37L,41L,50L,65L,85L,86L,89L,93L,101L,105L,114L,129L,149L,153L,162L,177L,198L,213L,241L,293L,341L,342L,345L,349L,357L,361L,370L,385L,405L,409L,418L,433L,454L,469L,497L,549L,597L,601L,610L,625L,646L,661L,689L,741L,790L,805L,833L,885L,941L,994L,1085L,1253L,1365L,1366L,1369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255737Inst : IEnumerable<long>
{
public static readonly long[] Value=A255737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255737.Bytes);
public long this[int i]=>Value[i];

public static A255737Inst Instance=new A255737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255738
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255738Inst : IEnumerable<long>
{
public static readonly long[] Value=A255738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255738.Bytes);
public long this[int i]=>Value[i];

public static A255738Inst Instance=new A255738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255739
{
public static readonly long[] Value={ 1L,2L,3L,9L,51L,473L,3233L,7657L,7722L,20002L,124170L,126137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255739Inst : IEnumerable<long>
{
public static readonly long[] Value=A255739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255739.Bytes);
public long this[int i]=>Value[i];

public static A255739Inst Instance=new A255739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255740
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,2L,0L,0L,1L,4L,3L,2L,1L,0L,1L,5L,4L,6L,2L,0L,0L,1L,6L,5L,12L,3L,2L,0L,0L,1L,7L,6L,20L,4L,6L,2L,0L,0L,1L,8L,7L,30L,5L,12L,6L,2L,1L,0L,1L,9L,8L,42L,6L,20L,12L,12L,2L,0L,0L,1L,10L,9L,56L,7L,30L,20L,36L,3L,2L,0L,0L,1L,11L,10L,72L,8L,42L,30L,80L,4L,6L,2L,0L,0L,1L,12L,11L,90L,9L,56L,42L,150L,5L,12L,6L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255740Inst : IEnumerable<long>
{
public static readonly long[] Value=A255740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255740.Bytes);
public long this[int i]=>Value[i];

public static A255740Inst Instance=new A255740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255741
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,5L,3L,1L,1L,5L,7L,7L,4L,1L,1L,6L,9L,13L,9L,4L,1L,1L,7L,11L,21L,16L,11L,4L,1L,1L,8L,13L,31L,25L,22L,13L,4L,1L,1L,9L,15L,43L,36L,37L,28L,15L,5L,1L,1L,10L,17L,57L,49L,56L,49L,40L,17L,5L,1L,1L,11L,19L,73L,64L,79L,76L,85L,43L,19L,5L,1L,1L,12L,21L,91L,81L,106L,109L,156L,89L,49L,21L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255741Inst : IEnumerable<long>
{
public static readonly long[] Value=A255741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255741.Bytes);
public long this[int i]=>Value[i];

public static A255741Inst Instance=new A255741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255742
{
public static readonly long[] Value={ 14L,21L,25L,48L,146L,776L,3764L,7847L,7904L,18048L,90930L,92219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255742Inst : IEnumerable<long>
{
public static readonly long[] Value=A255742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255742.Bytes);
public long this[int i]=>Value[i];

public static A255742Inst Instance=new A255742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255743
{
public static readonly long[] Value={ 1L,9L,9L,72L,9L,72L,72L,576L,9L,72L,72L,576L,72L,576L,576L,4608L,9L,72L,72L,576L,72L,576L,576L,4608L,72L,576L,576L,4608L,576L,4608L,4608L,36864L,9L,72L,72L,576L,72L,576L,576L,4608L,72L,576L,576L,4608L,576L,4608L,4608L,36864L,72L,576L,576L,4608L,576L,4608L,4608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255743Inst : IEnumerable<long>
{
public static readonly long[] Value=A255743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255743.Bytes);
public long this[int i]=>Value[i];

public static A255743Inst Instance=new A255743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255744
{
public static readonly long[] Value={ 1L,10L,10L,90L,10L,90L,90L,810L,10L,90L,90L,810L,90L,810L,810L,7290L,10L,90L,90L,810L,90L,810L,810L,7290L,90L,810L,810L,7290L,810L,7290L,7290L,65610L,10L,90L,90L,810L,90L,810L,810L,7290L,90L,810L,810L,7290L,810L,7290L,7290L,65610L,90L,810L,810L,7290L,810L,7290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255744Inst : IEnumerable<long>
{
public static readonly long[] Value=A255744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255744.Bytes);
public long this[int i]=>Value[i];

public static A255744Inst Instance=new A255744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255745
{
public static readonly long[] Value={ 1L,11L,11L,110L,11L,110L,110L,1100L,11L,110L,110L,1100L,110L,1100L,1100L,11000L,11L,110L,110L,1100L,110L,1100L,1100L,11000L,110L,1100L,1100L,11000L,1100L,11000L,11000L,110000L,11L,110L,110L,1100L,110L,1100L,1100L,11000L,110L,1100L,1100L,11000L,1100L,11000L,11000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255745Inst : IEnumerable<long>
{
public static readonly long[] Value=A255745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255745.Bytes);
public long this[int i]=>Value[i];

public static A255745Inst Instance=new A255745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255746
{
public static readonly long[] Value={ 6L,10L,22L,34L,35L,51L,58L,65L,82L,87L,91L,111L,115L,118L,119L,129L,141L,142L,155L,183L,201L,202L,205L,209L,213L,214L,215L,217L,249L,274L,287L,291L,295L,298L,299L,301L,305L,319L,323L,335L,358L,377L,382L,391L,394L,403L,407L,411L,413L,447L,454L,469L,478L,481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255746Inst : IEnumerable<long>
{
public static readonly long[] Value=A255746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255746.Bytes);
public long this[int i]=>Value[i];

public static A255746Inst Instance=new A255746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255747
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,9L,14L,21L,22L,25L,30L,37L,42L,53L,70L,85L,86L,89L,94L,101L,106L,117L,134L,149L,154L,165L,182L,201L,222L,261L,310L,341L,342L,345L,350L,357L,362L,373L,390L,405L,410L,421L,438L,457L,478L,517L,566L,597L,602L,613L,630L,649L,670L,709L,758L,793L,814L,853L,906L,965L,1046L,1173L,1302L,1365L,1366L,1369L,1374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255747Inst : IEnumerable<long>
{
public static readonly long[] Value=A255747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255747.Bytes);
public long this[int i]=>Value[i];

public static A255747Inst Instance=new A255747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255748
{
public static readonly long[] Value={ 1L,3L,4L,8L,11L,13L,14L,22L,29L,35L,40L,44L,47L,49L,50L,66L,81L,95L,108L,120L,131L,141L,150L,158L,165L,171L,176L,180L,183L,185L,186L,218L,249L,279L,308L,336L,363L,389L,414L,438L,461L,483L,504L,524L,543L,561L,578L,594L,609L,623L,636L,648L,659L,669L,678L,686L,693L,699L,704L,708L,711L,713L,714L,778L,841L,903L,964L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255748Inst : IEnumerable<long>
{
public static readonly long[] Value=A255748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255748.Bytes);
public long this[int i]=>Value[i];

public static A255748Inst Instance=new A255748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255749
{
public static readonly long[] Value={ 512L,7765L,51064L,118925L,196744L,473630L,739776L,2509233L,2833848L,15683280L,11443688L,103505234L,46550488L,787249560L,193199064L,5867658716L,807118704L,47135689832L,3371471992L,363872055032L,14120529208L,2966121353072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255749Inst : IEnumerable<long>
{
public static readonly long[] Value=A255749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255749.Bytes);
public long this[int i]=>Value[i];

public static A255749Inst Instance=new A255749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255750
{
public static readonly long[] Value={ 2485L,7765L,20730L,46367L,86062L,156658L,290525L,531182L,940860L,1668674L,3031160L,5597085L,10094701L,18262539L,34114081L,65352635L,121376088L,225653362L,436223139L,868777357L,1663472667L,3171906522L,6300155508L,12902328159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255750Inst : IEnumerable<long>
{
public static readonly long[] Value=A255750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255750.Bytes);
public long this[int i]=>Value[i];

public static A255750Inst Instance=new A255750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255751
{
public static readonly long[] Value={ 8776L,24536L,51064L,71651L,81494L,108201L,145536L,211742L,299128L,414453L,561720L,828476L,1176512L,1635984L,2225984L,3293008L,4684384L,6521408L,8880544L,13147776L,18712416L,26059648L,35495328L,52563392L,74821088L,104209152L,141951008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255751Inst : IEnumerable<long>
{
public static readonly long[] Value=A255751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255751.Bytes);
public long this[int i]=>Value[i];

public static A255751Inst Instance=new A255751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255752
{
public static readonly long[] Value={ 30182L,72884L,111064L,118925L,124928L,177281L,306248L,517386L,766616L,1335701L,2994308L,5759584L,8957268L,16979505L,42027004L,83952976L,132161916L,256397865L,651345844L,1313021560L,2072742516L,4044259761L,10340350348L,20890761568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255752Inst : IEnumerable<long>
{
public static readonly long[] Value=A255752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255752.Bytes);
public long this[int i]=>Value[i];

public static A255752Inst Instance=new A255752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255753
{
public static readonly long[] Value={ 99200L,180619L,197284L,203503L,196744L,237248L,300504L,402972L,543216L,719217L,966484L,1367292L,1914280L,2603820L,3577560L,5163800L,7335400L,10077720L,13956840L,20285960L,28956520L,39909960L,55410600L,80711240L,115377640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255753Inst : IEnumerable<long>
{
public static readonly long[] Value=A255753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255753.Bytes);
public long this[int i]=>Value[i];

public static A255753Inst Instance=new A255753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255754
{
public static readonly long[] Value={ 293012L,386060L,341801L,371616L,360501L,473630L,733081L,1166662L,1720217L,3169356L,6568657L,12211026L,19689657L,40611648L,92377017L,178040632L,292586745L,618865560L,1437213809L,2789956224L,4602903185L,9790126112L,22844752297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255754Inst : IEnumerable<long>
{
public static readonly long[] Value=A255754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255754.Bytes);
public long this[int i]=>Value[i];

public static A255754Inst Instance=new A255754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255755
{
public static readonly long[] Value={ 794128L,778827L,551068L,619142L,553072L,652833L,739776L,1010588L,1167904L,1647077L,2006720L,3026536L,3618544L,5468116L,6840960L,10854544L,13156336L,20486224L,25908560L,41893728L,51031728L,80282112L,101902288L,165773792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255755Inst : IEnumerable<long>
{
public static readonly long[] Value=A255755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255755.Bytes);
public long this[int i]=>Value[i];

public static A255755Inst Instance=new A255755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255756
{
public static readonly long[] Value={ 512L,2485L,2485L,8776L,7765L,8776L,30182L,24536L,20730L,30182L,99200L,72884L,51064L,46367L,99200L,293012L,180619L,111064L,71651L,86062L,293012L,794128L,386060L,197284L,118925L,81494L,156658L,794128L,2084773L,778827L,341801L,203503L,124928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255756Inst : IEnumerable<long>
{
public static readonly long[] Value=A255756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255756.Bytes);
public long this[int i]=>Value[i];

public static A255756Inst Instance=new A255756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255757
{
public static readonly long[] Value={ 2485L,7765L,24536L,72884L,180619L,386060L,778827L,1580226L,3130455L,5810558L,10404621L,19209556L,35754204L,64042438L,112969799L,211210444L,404550623L,741978523L,1340845547L,2623013518L,5281311943L,10042459246L,18653169405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255757Inst : IEnumerable<long>
{
public static readonly long[] Value=A255757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255757.Bytes);
public long this[int i]=>Value[i];

public static A255757Inst Instance=new A255757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255758
{
public static readonly long[] Value={ 8776L,20730L,51064L,111064L,197284L,341801L,551068L,880000L,1327924L,1998692L,2971672L,4392340L,6337544L,9143648L,13228340L,19227692L,27421084L,39340572L,56929636L,83008296L,118940192L,171589464L,250432040L,368083568L,531423924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255758Inst : IEnumerable<long>
{
public static readonly long[] Value=A255758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255758.Bytes);
public long this[int i]=>Value[i];

public static A255758Inst Instance=new A255758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255759
{
public static readonly long[] Value={ 30182L,46367L,71651L,118925L,203503L,371616L,619142L,1072628L,1797116L,2967765L,5071867L,8405698L,14522330L,23891246L,44755522L,79091985L,151022450L,262118115L,546460339L,1023817596L,2086472417L,3735441860L,8131658798L,15548790150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255759Inst : IEnumerable<long>
{
public static readonly long[] Value=A255759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255759.Bytes);
public long this[int i]=>Value[i];

public static A255759Inst Instance=new A255759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255760
{
public static readonly long[] Value={ 99200L,86062L,81494L,124928L,196744L,360501L,553072L,962648L,1560352L,2706176L,4233320L,6903168L,10501880L,16557800L,24368576L,36532028L,52140896L,76716744L,106586856L,150848380L,204568672L,287918836L,383572584L,523678364L,685208352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255760Inst : IEnumerable<long>
{
public static readonly long[] Value=A255760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255760.Bytes);
public long this[int i]=>Value[i];

public static A255760Inst Instance=new A255760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255761
{
public static readonly long[] Value={ 293012L,156658L,108201L,177281L,237248L,473630L,652833L,1289436L,2035202L,4063736L,6925353L,13000120L,22368324L,42237154L,75237569L,135754954L,239450238L,455962216L,854685889L,1574304740L,2916053420L,5816374182L,11500663421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255761Inst : IEnumerable<long>
{
public static readonly long[] Value=A255761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255761.Bytes);
public long this[int i]=>Value[i];

public static A255761Inst Instance=new A255761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255762
{
public static readonly long[] Value={ 794128L,290525L,145536L,306248L,300504L,733081L,739776L,1603012L,1998480L,4087836L,5951488L,11586092L,18011344L,33446520L,52638248L,91911020L,141968656L,236249776L,355847440L,566125804L,828298440L,1272368584L,1814128584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255762Inst : IEnumerable<long>
{
public static readonly long[] Value=A255762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255762.Bytes);
public long this[int i]=>Value[i];

public static A255762Inst Instance=new A255762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255763
{
public static readonly long[] Value={ 1L,9L,15L,21L,23L,25L,27L,33L,35L,37L,39L,45L,47L,49L,51L,53L,55L,57L,63L,65L,67L,69L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,105L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,135L,141L,143L,145L,147L,153L,155L,157L,159L,161L,163L,165L,167L,169L,171L,173L,175L,177L,183L,185L,187L,189L,195L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255763Inst : IEnumerable<long>
{
public static readonly long[] Value=A255763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255763.Bytes);
public long this[int i]=>Value[i];

public static A255763Inst Instance=new A255763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255764
{
public static readonly long[] Value={ 1L,10L,19L,91L,100L,172L,244L,820L,829L,901L,973L,1549L,1621L,2197L,2773L,7381L,7390L,7462L,7534L,8110L,8182L,8758L,9334L,13942L,14014L,14590L,15166L,19774L,20350L,24958L,29566L,66430L,66439L,66511L,66583L,67159L,67231L,67807L,68383L,72991L,73063L,73639L,74215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255764Inst : IEnumerable<long>
{
public static readonly long[] Value=A255764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255764.Bytes);
public long this[int i]=>Value[i];

public static A255764Inst Instance=new A255764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255765
{
public static readonly long[] Value={ 1L,11L,21L,111L,121L,211L,301L,1111L,1121L,1211L,1301L,2111L,2201L,3011L,3821L,11111L,11121L,11211L,11301L,12111L,12201L,13011L,13821L,21111L,21201L,22011L,22821L,30111L,30921L,38211L,45501L,111111L,111121L,111211L,111301L,112111L,112201L,113011L,113821L,121111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255765Inst : IEnumerable<long>
{
public static readonly long[] Value=A255765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255765.Bytes);
public long this[int i]=>Value[i];

public static A255765Inst Instance=new A255765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255766
{
public static readonly long[] Value={ 1L,12L,23L,133L,144L,254L,364L,1464L,1475L,1585L,1695L,2795L,2905L,4005L,5105L,16105L,16116L,16226L,16336L,17436L,17546L,18646L,19746L,30746L,30856L,31956L,33056L,44056L,45156L,56156L,67156L,177156L,177167L,177277L,177387L,178487L,178597L,179697L,180797L,191797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255766Inst : IEnumerable<long>
{
public static readonly long[] Value=A255766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255766.Bytes);
public long this[int i]=>Value[i];

public static A255766Inst Instance=new A255766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255767
{
public static readonly long[] Value={ 1L,4L,6L,3L,12L,8L,10L,25L,24L,36L,6L,14L,77L,14L,32L,104L,40L,27L,153L,90L,40L,220L,150L,10L,22L,297L,275L,22L,72L,348L,444L,60L,26L,481L,676L,130L,56L,616L,938L,280L,60L,660L,1455L,450L,15L,80L,880L,1872L,832L,32L,34L,1003L,2618L,1309L,85L,108L,1224L,3312L,2106L,180L,38L,1349L,4465L,3078L,380L,120L,1620L,5540L,4540L,720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255767Inst : IEnumerable<long>
{
public static readonly long[] Value=A255767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255767.Bytes);
public long this[int i]=>Value[i];

public static A255767Inst Instance=new A255767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255768
{
public static readonly long[] Value={ 1L,3L,4L,2L,7L,5L,6L,14L,12L,20L,3L,8L,39L,7L,15L,52L,19L,13L,74L,41L,18L,102L,68L,4L,12L,134L,120L,9L,28L,158L,189L,24L,14L,208L,283L,51L,24L,259L,390L,107L,24L,284L,582L,173L,5L,31L,361L,749L,311L,11L,18L,409L,1024L,485L,29L,39L,488L,1289L,767L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255768Inst : IEnumerable<long>
{
public static readonly long[] Value=A255768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255768.Bytes);
public long this[int i]=>Value[i];

public static A255768Inst Instance=new A255768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255769
{
public static readonly long[] Value={ 7L,11L,23L,31L,47L,59L,67L,83L,97L,109L,137L,149L,167L,179L,197L,211L,233L,269L,331L,347L,353L,367L,389L,419L,431L,439L,587L,617L,739L,751L,829L,859L,907L,919L,977L,991L,1009L,1031L,1039L,1063L,1117L,1171L,1187L,1237L,1319L,1327L,1427L,1447L,1471L,1499L,1553L,1567L,1723L,1901L,1913L,1933L,2207L,2221L,2269L,2293L,2333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255769Inst : IEnumerable<long>
{
public static readonly long[] Value=A255769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255769.Bytes);
public long this[int i]=>Value[i];

public static A255769Inst Instance=new A255769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255770
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,11L,13L,17L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255770Inst : IEnumerable<long>
{
public static readonly long[] Value=A255770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255770.Bytes);
public long this[int i]=>Value[i];

public static A255770Inst Instance=new A255770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255771
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,2L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255771Inst : IEnumerable<long>
{
public static readonly long[] Value=A255771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255771.Bytes);
public long this[int i]=>Value[i];

public static A255771Inst Instance=new A255771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255772
{
public static readonly BigInteger[] Value={ 7L,3L,13L,241L,97L,673L,193L,22253377L,18446744069414584321UL,769L,BigInteger.Parse("442499826945303593556473164314770689"),BigInteger.Parse("349621839326921795694385454593"),BigInteger.Parse("331192380488114152600457428497953408512758882817"),212780015855109121L };
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
public class A255772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255772Inst Instance=new A255772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255773
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,12L,11L,14L,16L,21L,17L,22L,25L,33L,19L,24L,27L,35L,29L,37L,42L,55L,30L,38L,43L,56L,46L,59L,67L,88L,32L,40L,45L,58L,48L,61L,69L,90L,50L,63L,71L,92L,76L,97L,110L,144L,51L,64L,72L,93L,77L,98L,111L,145L,80L,101L,114L,148L,122L,156L,177L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255773Inst : IEnumerable<long>
{
public static readonly long[] Value=A255773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255773.Bytes);
public long this[int i]=>Value[i];

public static A255773Inst Instance=new A255773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255774
{
public static readonly long[] Value={ 2L,5L,7L,10L,13L,15L,20L,18L,23L,26L,34L,28L,36L,41L,54L,31L,39L,44L,57L,47L,60L,68L,89L,49L,62L,70L,91L,75L,96L,109L,143L,52L,65L,73L,94L,78L,99L,112L,146L,81L,102L,115L,149L,123L,157L,178L,233L,83L,104L,117L,151L,125L,159L,180L,235L,130L,164L,185L,240L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255774Inst : IEnumerable<long>
{
public static readonly long[] Value=A255774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255774.Bytes);
public long this[int i]=>Value[i];

public static A255774Inst Instance=new A255774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255775
{
public static readonly BigInteger[] Value={ 140L,1743L,58729L,2413487L,193188995L,32105186518L,9007582907953L,4590560094334298L,4477200560643502537L,BigInteger.Parse("7835100506995593159086") };
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
public class A255775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255775Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255775.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255775.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255775Inst Instance=new A255775Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255776
{
public static readonly long[] Value={ 140L,436L,1512L,5126L,17325L,58707L,198635L,672183L,2274999L,7699081L,26056081L,88181805L,298433705L,1009989977L,3418112157L,11567925109L,39149360907L,132493286347L,448397385023L,1517512474487L,5135721548305L,17380836236957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255776Inst : IEnumerable<long>
{
public static readonly long[] Value=A255776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255776.Bytes);
public long this[int i]=>Value[i];

public static A255776Inst Instance=new A255776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255777
{
public static readonly long[] Value={ 436L,1743L,8672L,37281L,161602L,726684L,3204754L,14164510L,62954158L,278903301L,1235840478L,5481107523L,24297608428L,107711449934L,477559213871L,2117186836905L,9386199366250L,41613275136349L,184488280162414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255777Inst : IEnumerable<long>
{
public static readonly long[] Value=A255777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255777.Bytes);
public long this[int i]=>Value[i];

public static A255777Inst Instance=new A255777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255778
{
public static readonly long[] Value={ 1512L,8672L,58729L,327340L,1968584L,11945779L,71461994L,428975207L,2589583742L,15580188674L,93815267630L,565153391215L,3403888790453L,20499583169858L,123476068356687L,743701123471477L,4479335031465983L,26979398514408492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255778Inst : IEnumerable<long>
{
public static readonly long[] Value=A255778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255778.Bytes);
public long this[int i]=>Value[i];

public static A255778Inst Instance=new A255778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255779
{
public static readonly long[] Value={ 5126L,37281L,327340L,2413487L,18624528L,149549264L,1182407902L,9335360280L,74302402090L,590258349021L,4686029519002L,37230377738228L,295837256040187L,2350134923034554L,18671950248006903L,148351149016244078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255779Inst : IEnumerable<long>
{
public static readonly long[] Value=A255779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255779.Bytes);
public long this[int i]=>Value[i];

public static A255779Inst Instance=new A255779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255780
{
public static readonly long[] Value={ 17325L,161602L,1968584L,18624528L,193188995L,2128300125L,22610019790L,240398279606L,2591552387296L,27827020619579L,298246053051175L,3202910914945837L,34389628326656428L,369056555441122577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255780Inst : IEnumerable<long>
{
public static readonly long[] Value=A255780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255780.Bytes);
public long this[int i]=>Value[i];

public static A255780Inst Instance=new A255780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255781
{
public static readonly BigInteger[] Value={ 58707L,726684L,11945779L,149549264L,2128300125L,32105186518L,463394276783L,6707363776886L,98614808002346L,1440705191111821L,21012373155470318L,307239586725236821L,4490932620915632443L,BigInteger.Parse("65600015259780809553") };
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
public class A255781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255781Inst Instance=new A255781Inst();

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