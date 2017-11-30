using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A072955
{
public static readonly long[] Value={ 1L,2L,5L,8L,9L,10L,11L,12L,15L,18L,19L,20L,21L,22L,25L,28L,29L,50L,51L,52L,55L,58L,59L,80L,81L,82L,85L,88L,89L,90L,91L,92L,95L,98L,99L,1000000L,1000001L,1000002L,1000005L,1000008L,1000009L,1000010L,1000011L,1000012L,1000015L,1000018L,1000019L,1000020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072955Inst : IEnumerable<long>
{
public static readonly long[] Value=A072955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072955.Bytes);
public long this[int i]=>Value[i];

public static A072955Inst Instance=new A072955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072956
{
public static readonly long[] Value={ 1L,5L,6L,7L,9L,11L,1000000L,1000001L,1000005L,1000006L,1000007L,1000009L,1000011L,5000000L,5000001L,5000005L,5000006L,5000007L,5000009L,5000011L,6000000L,6000001L,6000005L,6000006L,6000007L,6000009L,6000011L,7000000L,7000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072956Inst : IEnumerable<long>
{
public static readonly long[] Value=A072956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072956.Bytes);
public long this[int i]=>Value[i];

public static A072956Inst Instance=new A072956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072957
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,8L,9L,10L,11L,12L,15L,16L,17L,18L,19L,20L,21L,22L,25L,26L,27L,28L,29L,50L,51L,55L,56L,57L,58L,59L,60L,61L,62L,65L,66L,67L,68L,69L,70L,71L,72L,75L,76L,77L,78L,79L,80L,81L,82L,85L,86L,87L,88L,89L,90L,91L,92L,95L,96L,97L,98L,99L,1000000L,1000001L,1000002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072957Inst : IEnumerable<long>
{
public static readonly long[] Value=A072957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072957.Bytes);
public long this[int i]=>Value[i];

public static A072957Inst Instance=new A072957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072958
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,14L,17L,20L,21L,22L,23L,24L,27L,40L,41L,42L,43L,44L,47L,70L,71L,72L,73L,74L,77L,100L,101L,102L,103L,104L,107L,110L,114L,117L,120L,121L,122L,123L,124L,127L,140L,141L,142L,143L,144L,147L,170L,171L,172L,173L,174L,177L,200L,201L,202L,203L,204L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072958Inst : IEnumerable<long>
{
public static readonly long[] Value=A072958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072958.Bytes);
public long this[int i]=>Value[i];

public static A072958Inst Instance=new A072958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072959
{
public static readonly long[] Value={ 515904L,11318L,15216L,10799546L,129618L,125258L,14118L,10211981L,2839691L,282506L,14729L,78236429L,299309045L,212445531527L,68884716992L,2457249197L,7503281492L,5427065792075L,55893641747L,150135668600L,299310469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072959Inst : IEnumerable<long>
{
public static readonly long[] Value=A072959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072959.Bytes);
public long this[int i]=>Value[i];

public static A072959Inst Instance=new A072959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072960
{
public static readonly long[] Value={ 0L,3L,6L,8L,9L,30L,33L,36L,38L,39L,60L,63L,66L,68L,69L,80L,83L,86L,88L,89L,90L,93L,96L,98L,99L,300L,303L,306L,308L,309L,330L,333L,336L,338L,339L,360L,363L,366L,368L,369L,380L,383L,386L,388L,389L,390L,393L,396L,398L,399L,600L,603L,606L,608L,609L,630L,633L,636L,638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072960Inst : IEnumerable<long>
{
public static readonly long[] Value=A072960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072960.Bytes);
public long this[int i]=>Value[i];

public static A072960Inst Instance=new A072960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072961
{
public static readonly long[] Value={ 2L,5L,22L,25L,52L,55L,222L,225L,252L,255L,522L,525L,552L,555L,2222L,2225L,2252L,2255L,2522L,2525L,2552L,2555L,5222L,5225L,5252L,5255L,5522L,5525L,5552L,5555L,22222L,22225L,22252L,22255L,22522L,22525L,22552L,22555L,25222L,25225L,25252L,25255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072961Inst : IEnumerable<long>
{
public static readonly long[] Value=A072961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072961.Bytes);
public long this[int i]=>Value[i];

public static A072961Inst Instance=new A072961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072962
{
public static readonly long[] Value={ 1L,20L,1071L,107104L,17201225L,4053135456L,1318104508735L,565989104282624L,310299479406324369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072962Inst : IEnumerable<long>
{
public static readonly long[] Value=A072962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072962.Bytes);
public long this[int i]=>Value[i];

public static A072962Inst Instance=new A072962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072963
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,11L,3L,13L,7L,15L,1L,17L,9L,19L,5L,21L,11L,1L,3L,25L,13L,27L,7L,29L,15L,31L,1L,33L,17L,35L,9L,1L,19L,39L,5L,41L,21L,43L,11L,45L,1L,1L,3L,49L,25L,51L,13L,1L,27L,55L,7L,57L,29L,59L,15L,61L,31L,63L,1L,65L,33L,1L,17L,3L,35L,71L,9L,73L,1L,75L,19L,77L,39L,1L,5L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072963Inst : IEnumerable<long>
{
public static readonly long[] Value=A072963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072963.Bytes);
public long this[int i]=>Value[i];

public static A072963Inst Instance=new A072963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072980
{
public static readonly long[] Value={ 1L,3L,11L,11L,61L,11L,82L,82L,82L,171L,1951L,1951L,26133L,13424L,41273L,41273L,716656L,716656L,13871719L,13871719L,4700888L,9548741L,222854273L,222854273L,222854273L,112857219L,112857219L,112857219L,3310041496L,20075905417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072980Inst : IEnumerable<long>
{
public static readonly long[] Value=A072980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072980.Bytes);
public long this[int i]=>Value[i];

public static A072980Inst Instance=new A072980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072981
{
public static readonly long[] Value={ 1L,2L,7L,2L,2L,1L,3L,2L,2L,1L,3L,1L,1L,21L,1L,1L,4L,3L,1L,2L,1L,1L,1L,6L,3L,1L,1L,1L,3L,1L,8L,208L,1L,2L,5L,2L,1L,3L,4L,1L,6L,2L,3L,2L,1L,3L,1L,4L,1L,1L,1L,2L,1L,1L,1L,33L,3L,1L,1L,2L,1L,26L,3L,1L,1L,1L,1L,1L,1L,55L,1L,10L,2L,34L,1L,1L,5L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072981Inst : IEnumerable<long>
{
public static readonly long[] Value=A072981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072981.Bytes);
public long this[int i]=>Value[i];

public static A072981Inst Instance=new A072981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072982
{
public static readonly long[] Value={ 3L,11L,17L,73L,101L,137L,257L,353L,449L,641L,1409L,10753L,15361L,19841L,65537L,69857L,453377L,976193L,1514497L,5767169L,5882353L,6187457L,8253953L,8257537L,70254593L,167772161L,175636481L,302078977L,458924033L,639631361L,1265011073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072982Inst : IEnumerable<long>
{
public static readonly long[] Value=A072982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072982.Bytes);
public long this[int i]=>Value[i];

public static A072982Inst Instance=new A072982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072983
{
public static readonly long[] Value={ 1L,2L,6L,6L,30L,5L,35L,35L,35L,70L,770L,770L,10010L,5005L,15015L,15015L,255255L,255255L,4849845L,4849845L,1616615L,3233230L,74364290L,74364290L,74364290L,37182145L,37182145L,37182145L,1078282205L,6469693230L,200560490130L,200560490130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072983Inst : IEnumerable<long>
{
public static readonly long[] Value=A072983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072983.Bytes);
public long this[int i]=>Value[i];

public static A072983Inst Instance=new A072983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072984
{
public static readonly long[] Value={ 2L,4L,6L,3L,12L,16L,18L,22L,13L,30L,17L,40L,13L,46L,22L,58L,10L,66L,70L,72L,78L,82L,88L,11L,100L,102L,106L,25L,112L,126L,130L,5L,138L,148L,150L,156L,162L,166L,71L,178L,180L,190L,192L,196L,38L,210L,222L,22L,228L,232L,238L,240L,250L,66L,262L,33L,58L,276L,280L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072984Inst : IEnumerable<long>
{
public static readonly long[] Value=A072984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072984.Bytes);
public long this[int i]=>Value[i];

public static A072984Inst Instance=new A072984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072985
{
public static readonly long[] Value={ 1L,2L,7L,6L,21L,18L,63L,54L,189L,162L,567L,486L,1701L,1458L,5103L,4374L,15309L,13122L,45927L,39366L,137781L,118098L,413343L,354294L,1240029L,1062882L,3720087L,3188646L,11160261L,9565938L,33480783L,28697814L,100442349L,86093442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072985Inst : IEnumerable<long>
{
public static readonly long[] Value=A072985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072985.Bytes);
public long this[int i]=>Value[i];

public static A072985Inst Instance=new A072985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072986
{
public static readonly long[] Value={ 1L,2L,6L,11L,24L,52L,113L,248L,553L,1245L,2828L,6481L,14963L,34770L,81253L,190836L,450202L,1066269L,2534269L,6042375L,14447465L,34632759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072986Inst : IEnumerable<long>
{
public static readonly long[] Value=A072986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072986.Bytes);
public long this[int i]=>Value[i];

public static A072986Inst Instance=new A072986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072987
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,3L,8L,4L,12L,7L,8L,15L,11L,12L,23L,20L,10L,12L,22L,15L,16L,31L,25L,9L,9L,18L,27L,18L,45L,34L,18L,20L,38L,25L,28L,53L,45L,23L,29L,52L,41L,10L,51L,18L,24L,42L,66L,61L,30L,41L,71L,61L,27L,34L,61L,40L,44L,84L,70L,35L,44L,79L,61L,76L,73L,18L,24L,42L,66L,108L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072987Inst : IEnumerable<long>
{
public static readonly long[] Value=A072987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072987.Bytes);
public long this[int i]=>Value[i];

public static A072987Inst Instance=new A072987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072988
{
public static readonly long[] Value={ 1L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072988Inst : IEnumerable<long>
{
public static readonly long[] Value=A072988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072988.Bytes);
public long this[int i]=>Value[i];

public static A072988Inst Instance=new A072988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072989
{
public static readonly long[] Value={ 20L,30L,40L,42L,52L,60L,66L,68L,70L,78L,80L,84L,90L,100L,102L,104L,110L,114L,116L,120L,126L,130L,132L,136L,138L,140L,148L,150L,154L,156L,160L,164L,168L,170L,171L,174L,180L,182L,186L,190L,198L,200L,204L,208L,210L,212L,220L,222L,228L,230L,232L,234L,238L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072989Inst : IEnumerable<long>
{
public static readonly long[] Value=A072989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072989.Bytes);
public long this[int i]=>Value[i];

public static A072989Inst Instance=new A072989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072990
{
public static readonly long[] Value={ 1000L,15L,14L,13L,12L,11L,10L,9L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072990Inst : IEnumerable<long>
{
public static readonly long[] Value=A072990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072990.Bytes);
public long this[int i]=>Value[i];

public static A072990Inst Instance=new A072990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072991
{
public static readonly long[] Value={ 8L,5L,4L,9L,1L,7L,6L,10L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072991Inst : IEnumerable<long>
{
public static readonly long[] Value=A072991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072991.Bytes);
public long this[int i]=>Value[i];

public static A072991Inst Instance=new A072991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072992
{
public static readonly long[] Value={ 10L,18L,21L,22L,27L,30L,33L,34L,35L,40L,42L,45L,52L,55L,56L,57L,58L,65L,66L,69L,70L,75L,77L,81L,82L,84L,85L,88L,90L,93L,94L,98L,100L,102L,105L,106L,108L,110L,115L,118L,119L,120L,121L,129L,132L,133L,135L,136L,138L,140L,141L,148L,152L,154L,155L,156L,161L,162L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072992Inst : IEnumerable<long>
{
public static readonly long[] Value=A072992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072992.Bytes);
public long this[int i]=>Value[i];

public static A072992Inst Instance=new A072992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072993
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,10L,12L,14L,15L,18L,21L,22L,26L,29L,30L,33L,35L,41L,42L,43L,44L,45L,52L,56L,60L,66L,67L,69L,70L,73L,74L,75L,76L,77L,78L,82L,86L,87L,88L,89L,92L,95L,99L,100L,105L,106L,110L,115L,116L,119L,122L,123L,124L,126L,127L,129L,133L,135L,138L,142L,143L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072993Inst : IEnumerable<long>
{
public static readonly long[] Value=A072993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072993.Bytes);
public long this[int i]=>Value[i];

public static A072993Inst Instance=new A072993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072994
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,4L,3L,2L,1L,4L,1L,2L,1L,8L,1L,6L,1L,8L,3L,2L,1L,8L,5L,2L,9L,4L,1L,4L,1L,16L,1L,2L,1L,12L,1L,2L,3L,16L,1L,12L,1L,4L,3L,2L,1L,16L,7L,10L,1L,8L,1L,18L,5L,8L,3L,2L,1L,16L,1L,2L,9L,32L,1L,4L,1L,8L,1L,4L,1L,24L,1L,2L,5L,4L,1L,12L,1L,32L,27L,2L,1L,24L,1L,2L,1L,8L,1L,12L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072994Inst : IEnumerable<long>
{
public static readonly long[] Value=A072994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072994.Bytes);
public long this[int i]=>Value[i];

public static A072994Inst Instance=new A072994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072995
{
public static readonly long[] Value={ 1L,4L,9L,8L,25L,18L,49L,16L,27L,50L,121L,36L,169L,98L,225L,32L,289L,54L,361L,110L,147L,242L,529L,72L,125L,338L,81L,196L,841L,0L,961L,64L,1089L,578L,1225L,108L,1369L,722L,507L,100L,1681L,0L,1849L,484L,675L,1058L,2209L,144L,343L,250L,2601L,1378L,2809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072995Inst : IEnumerable<long>
{
public static readonly long[] Value=A072995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072995.Bytes);
public long this[int i]=>Value[i];

public static A072995Inst Instance=new A072995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073092
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,5L,6L,7L,8L,8L,8L,9L,9L,9L,10L,11L,12L,12L,13L,13L,13L,13L,13L,15L,16L,16L,16L,17L,17L,17L,18L,18L,19L,19L,20L,21L,21L,21L,22L,23L,23L,23L,23L,24L,24L,24L,24L,25L,27L,27L,28L,29L,29L,29L,29L,29L,30L,30L,30L,31L,31L,31L,32L,34L,34L,34L,35L,35L,35L,35L,36L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073092Inst : IEnumerable<long>
{
public static readonly long[] Value=A073092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073092.Bytes);
public long this[int i]=>Value[i];

public static A073092Inst Instance=new A073092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073093
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,2L,4L,3L,3L,2L,4L,2L,3L,3L,5L,2L,4L,2L,4L,3L,3L,2L,5L,3L,3L,4L,4L,2L,4L,2L,6L,3L,3L,3L,5L,2L,3L,3L,5L,2L,4L,2L,4L,4L,3L,2L,6L,3L,4L,3L,4L,2L,5L,3L,5L,3L,3L,2L,5L,2L,3L,4L,7L,3L,4L,2L,4L,3L,4L,2L,6L,2L,3L,4L,4L,3L,4L,2L,6L,5L,3L,2L,5L,3L,3L,3L,5L,2L,5L,3L,4L,3L,3L,3L,7L,2L,4L,4L,5L,2L,4L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073093Inst : IEnumerable<long>
{
public static readonly long[] Value=A073093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073093.Bytes);
public long this[int i]=>Value[i];

public static A073093Inst Instance=new A073093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073094
{
public static readonly long[] Value={ 2L,6L,2L,4L,2L,6L,2L,6L,2L,4L,2L,4L,8L,4L,2L,4L,2L,6L,2L,6L,2L,4L,2L,6L,2L,6L,2L,4L,2L,4L,8L,4L,2L,4L,2L,4L,8L,4L,8L,6L,8L,4L,8L,4L,2L,4L,2L,4L,8L,4L,2L,4L,2L,6L,2L,6L,2L,4L,2L,6L,2L,6L,2L,4L,2L,4L,8L,4L,2L,4L,2L,6L,2L,6L,2L,4L,2L,6L,2L,6L,2L,4L,2L,4L,8L,4L,2L,4L,2L,4L,8L,4L,8L,6L,8L,4L,8L,4L,2L,4L,2L,4L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073094Inst : IEnumerable<long>
{
public static readonly long[] Value=A073094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073094.Bytes);
public long this[int i]=>Value[i];

public static A073094Inst Instance=new A073094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073095
{
public static readonly long[] Value={ 5L,12L,26L,31L,35L,51L,56L,60L,136L,152L,157L,177L,182L,252L,257L,275L,280L,287L,300L,305L,312L,627L,632L,650L,655L,662L,675L,680L,687L,751L,756L,760L,786L,811L,886L,902L,907L,927L,932L,1251L,1256L,1260L,1286L,1311L,1377L,1382L,1400L,1405L,1412L,1425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073095Inst : IEnumerable<long>
{
public static readonly long[] Value=A073095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073095.Bytes);
public long this[int i]=>Value[i];

public static A073095Inst Instance=new A073095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073096
{
public static readonly BigInteger[] Value={ 6L,6L,18L,258L,65538L,4294967298L,BigInteger.Parse("18446744073709551618"),BigInteger.Parse("340282366920938463463374607431768211458"),BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639938") };
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
public class A073096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073096Inst Instance=new A073096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073097
{
public static readonly long[] Value={ -1L,-1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073097Inst : IEnumerable<long>
{
public static readonly long[] Value=A073097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073097.Bytes);
public long this[int i]=>Value[i];

public static A073097Inst Instance=new A073097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073098
{
public static readonly long[] Value={ 2L,3L,11L,2L,5L,6L,13L,17L,6L,2L,7L,11L,23L,18L,3L,8L,2L,73L,7L,31L,2L,22L,201L,71L,19L,29L,23L,19L,139L,59L,37L,43L,15L,263L,17L,131L,71L,16L,257L,6L,227L,363L,191L,83L,16L,113L,123L,234L,178L,457L,197L,106L,38L,8L,208L,173L,29L,895L,515L,313L,162L,808L,1996L,622L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073098Inst : IEnumerable<long>
{
public static readonly long[] Value=A073098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073098.Bytes);
public long this[int i]=>Value[i];

public static A073098Inst Instance=new A073098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073099
{
public static readonly BigInteger[] Value={ 1L,31L,12307L,1180906852403L,BigInteger.Parse("4726403852635437852230311"),BigInteger.Parse("26387151472737581442533784610190235872453672267436617"),BigInteger.Parse("16379090991119093215568426722482532968867795792384100101494022155108529793899838205018451949281878220687877") };
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
public class A073099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073099Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073099.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073099.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073099Inst Instance=new A073099Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073100
{
public static readonly BigInteger[] Value={ 6L,210L,120120L,18050444111700L,BigInteger.Parse("118226688410282226751136160"),BigInteger.Parse("1112813007583117631616979100370019711878239390670756000"),BigInteger.Parse("1191035057635417333689929196555456096447880322064975132139675263681349241137859495385119040334214863238544000") };
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
public class A073100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073100Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073100.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073100.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073100Inst Instance=new A073100Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073101
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,5L,5L,6L,4L,9L,7L,15L,4L,14L,33L,22L,4L,21L,9L,30L,25L,22L,19L,45L,10L,17L,25L,36L,7L,72L,17L,62L,27L,22L,59L,69L,9L,29L,67L,84L,7L,77L,12L,56L,87L,39L,32L,142L,16L,48L,46L,53L,13L,82L,92L,124L,37L,30L,25L,178L,11L,34L,147L,118L,49L,94L,15L,67L,51L,176L,38L,191L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073101Inst : IEnumerable<long>
{
public static readonly long[] Value=A073101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073101.Bytes);
public long this[int i]=>Value[i];

public static A073101Inst Instance=new A073101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073102
{
public static readonly long[] Value={ 211L,421L,631L,1051L,1471L,2311L,2521L,2731L,3361L,3571L,4201L,4621L,4831L,5881L,6091L,6301L,7351L,7561L,8191L,8821L,9241L,9661L,9871L,10501L,10711L,11131L,11551L,11971L,12391L,12601L,13441L,14071L,14281L,15121L,15331L,15541L,16381L,17011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073102Inst : IEnumerable<long>
{
public static readonly long[] Value=A073102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073102.Bytes);
public long this[int i]=>Value[i];

public static A073102Inst Instance=new A073102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073103
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,2L,4L,2L,4L,2L,4L,4L,2L,8L,8L,4L,2L,2L,8L,4L,2L,2L,8L,4L,4L,2L,4L,4L,8L,2L,8L,4L,4L,8L,4L,4L,2L,8L,16L,4L,4L,2L,4L,8L,2L,2L,16L,2L,4L,8L,8L,4L,2L,8L,8L,4L,4L,2L,16L,4L,2L,4L,8L,16L,4L,2L,8L,4L,8L,2L,8L,4L,4L,8L,4L,4L,8L,2L,32L,2L,4L,2L,8L,16L,2L,8L,8L,4L,8L,8L,4L,4L,2L,8L,16L,4L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073103Inst : IEnumerable<long>
{
public static readonly long[] Value=A073103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073103.Bytes);
public long this[int i]=>Value[i];

public static A073103Inst Instance=new A073103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073104
{
public static readonly long[] Value={ 1523L,1447L,1373L,1301L,1231L,1163L,1097L,1033L,971L,911L,853L,797L,743L,691L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073104Inst : IEnumerable<long>
{
public static readonly long[] Value=A073104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073104.Bytes);
public long this[int i]=>Value[i];

public static A073104Inst Instance=new A073104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073105
{
public static readonly long[] Value={ 1L,3L,9L,12L,14L,12L,26L,46L,38L,49L,59L,46L,90L,73L,141L,117L,114L,127L,179L,151L,131L,238L,305L,250L,245L,258L,290L,468L,384L,345L,497L,403L,495L,502L,564L,543L,576L,624L,575L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073105Inst : IEnumerable<long>
{
public static readonly long[] Value=A073105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073105.Bytes);
public long this[int i]=>Value[i];

public static A073105Inst Instance=new A073105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073106
{
public static readonly long[] Value={ 1L,3L,3L,11L,7L,9L,15L,22L,15L,26L,30L,28L,36L,39L,23L,53L,45L,45L,62L,61L,41L,77L,72L,66L,74L,94L,59L,93L,120L,71L,116L,124L,75L,122L,100L,104L,144L,192L,101L,155L,166L,109L,176L,189L,101L,198L,192L,140L,186L,174L,129L,242L,250L,162L,180L,231L,159L,228L,276L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073106Inst : IEnumerable<long>
{
public static readonly long[] Value=A073106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073106.Bytes);
public long this[int i]=>Value[i];

public static A073106Inst Instance=new A073106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073107
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,1L,16L,15L,6L,1L,65L,64L,30L,8L,1L,326L,325L,160L,50L,10L,1L,1957L,1956L,975L,320L,75L,12L,1L,13700L,13699L,6846L,2275L,560L,105L,14L,1L,109601L,109600L,54796L,18256L,4550L,896L,140L,16L,1L,986410L,986409L,493200L,164388L,41076L,8190L,1344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073107Inst : IEnumerable<long>
{
public static readonly long[] Value=A073107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073107.Bytes);
public long this[int i]=>Value[i];

public static A073107Inst Instance=new A073107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073108
{
public static readonly long[] Value={ 1L,3L,10L,11L,16L,29L,38L,35L,64L,29L,54L,107L,58L,69L,92L,85L,82L,163L,124L,81L,190L,155L,142L,241L,116L,139L,338L,213L,176L,221L,214L,223L,520L,211L,184L,361L,278L,267L,400L,179L,294L,607L,288L,335L,362L,379L,342L,587L,394L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073108Inst : IEnumerable<long>
{
public static readonly long[] Value=A073108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073108.Bytes);
public long this[int i]=>Value[i];

public static A073108Inst Instance=new A073108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073109
{
public static readonly BigInteger[] Value={ 0L,0L,-7L,-35L,295L,2065L,-42980L,-42980L,1426670L,15693370L,-774856236L,-10073131068L,692669409432L,692669409432L,-63315621131763L,-1076365559239971L,126262920264259779L,2398995485020935801L,BigInteger.Parse("-351338708777824396629"),BigInteger.Parse("-351338708777824396629") };
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
public class A073109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073109Inst Instance=new A073109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073110
{
public static readonly long[] Value={ 0L,1L,0L,2L,10L,37L,121L,725L,5160L,31794L,279136L,2137531L,21305316L,213311303L,2457648287L,30357607661L,387013387043L,5245097770693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073110Inst : IEnumerable<long>
{
public static readonly long[] Value=A073110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073110.Bytes);
public long this[int i]=>Value[i];

public static A073110Inst Instance=new A073110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073111
{
public static readonly long[] Value={ 0L,2L,0L,0L,35L,211L,0L,0L,56204L,337661L,0L,0L,454113487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073111Inst : IEnumerable<long>
{
public static readonly long[] Value=A073111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073111.Bytes);
public long this[int i]=>Value[i];

public static A073111Inst Instance=new A073111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073112
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,7L,6L,30L,110L,278L,1332L,3312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073112Inst : IEnumerable<long>
{
public static readonly long[] Value=A073112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073112.Bytes);
public long this[int i]=>Value[i];

public static A073112Inst Instance=new A073112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073113
{
public static readonly BigInteger[] Value={ 2L,8L,64L,2048L,1048576L,137438953472L,BigInteger.Parse("1180591620717411303424"),BigInteger.Parse("43556142965880123323311949751266331066368") };
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
public class A073113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073113Inst Instance=new A073113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073114
{
public static readonly long[] Value={ 0L,1L,4L,7L,22L,160L,938L,7261L,67492L,572848L,6774544L,71929775L,985400749L,12521202682L,188765264950L,2889019817104L,47703971114988L,877662524710517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073114Inst : IEnumerable<long>
{
public static readonly long[] Value=A073114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073114.Bytes);
public long this[int i]=>Value[i];

public static A073114Inst Instance=new A073114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073115
{
public static readonly long[] Value={ 1L,7L,0L,9L,8L,0L,3L,4L,4L,2L,8L,6L,1L,2L,9L,1L,3L,1L,4L,6L,4L,1L,7L,8L,7L,3L,9L,9L,4L,4L,4L,5L,7L,5L,5L,9L,7L,0L,1L,2L,5L,0L,2L,2L,0L,5L,7L,6L,7L,8L,6L,0L,5L,1L,6L,9L,5L,7L,0L,0L,2L,6L,4L,4L,6L,5L,1L,2L,8L,7L,1L,2L,8L,1L,4L,8L,4L,6L,5L,9L,6L,2L,4L,7L,8L,3L,1L,6L,1L,3L,2L,4L,5L,9L,9L,9L,3L,8L,8L,3L,9L,2L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073115Inst : IEnumerable<long>
{
public static readonly long[] Value=A073115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073115.Bytes);
public long this[int i]=>Value[i];

public static A073115Inst Instance=new A073115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073116
{
public static readonly BigInteger[] Value={ 0L,1L,5L,1L,8L,4L,64L,128L,16384L,1048576L,34359738368L,18014398509481984L,BigInteger.Parse("1237940039285380274899124224") };
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
public class A073116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073116Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073116.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073116Inst Instance=new A073116Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073117
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,8L,10L,13L,18L,18L,26L,30L,36L,46L,50L,55L,62L,73L,74L,91L,102L,120L,130L,145L,146L,167L,178L,194L,220L,237L,264L,280L,304L,311L,316L,317L,346L,359L,376L,401L,402L,435L,450L,470L,500L,505L,550L,583L,590L,592L,634L,656L,688L,740L,778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073117Inst : IEnumerable<long>
{
public static readonly long[] Value=A073117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073117.Bytes);
public long this[int i]=>Value[i];

public static A073117Inst Instance=new A073117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073118
{
public static readonly long[] Value={ 0L,2L,5L,9L,19L,33L,57L,87L,136L,206L,311L,446L,650L,914L,1284L,1762L,2432L,3276L,4433L,5888L,7824L,10272L,13479L,17471L,22642L,29087L,37283L,47453L,60306L,76112L,95931L,120201L,150338L,187141L,232507L,287591L,355143L,436849L,536347L,656282L,801647L,976095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073118Inst : IEnumerable<long>
{
public static readonly long[] Value=A073118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073118.Bytes);
public long this[int i]=>Value[i];

public static A073118Inst Instance=new A073118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073119
{
public static readonly long[] Value={ 0L,1L,1L,4L,5L,10L,14L,26L,35L,56L,77L,116L,157L,226L,302L,424L,560L,762L,998L,1334L,1727L,2270L,2914L,3779L,4809L,6163L,7781L,9875L,12378L,15565L,19383L,24191L,29934L,37093L,45643L,56201L,68789L,84212L,102564L,124903L,151424L,183499L,221508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073119Inst : IEnumerable<long>
{
public static readonly long[] Value=A073119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073119.Bytes);
public long this[int i]=>Value[i];

public static A073119Inst Instance=new A073119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073120
{
public static readonly long[] Value={ 6L,24L,30L,60L,84L,96L,120L,180L,210L,240L,330L,336L,384L,480L,486L,504L,546L,630L,720L,840L,924L,960L,990L,1224L,1320L,1344L,1386L,1536L,1560L,1710L,1716L,1920L,1944L,2016L,2184L,2310L,2340L,2430L,2520L,2574L,2730L,2880L,3036L,3360L,3570L,3696L,3750L,3840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073120Inst : IEnumerable<long>
{
public static readonly long[] Value=A073120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073120.Bytes);
public long this[int i]=>Value[i];

public static A073120Inst Instance=new A073120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073121
{
public static readonly long[] Value={ 1L,4L,10L,16L,28L,40L,52L,64L,88L,112L,136L,160L,184L,208L,232L,256L,304L,352L,400L,448L,496L,544L,592L,640L,688L,736L,784L,832L,880L,928L,976L,1024L,1120L,1216L,1312L,1408L,1504L,1600L,1696L,1792L,1888L,1984L,2080L,2176L,2272L,2368L,2464L,2560L,2656L,2752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073121Inst : IEnumerable<long>
{
public static readonly long[] Value=A073121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073121.Bytes);
public long this[int i]=>Value[i];

public static A073121Inst Instance=new A073121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073122
{
public static readonly long[] Value={ 1L,2L,5L,4L,13L,10L,9L,8L,25L,26L,29L,20L,21L,18L,17L,16L,49L,50L,53L,52L,61L,58L,57L,40L,41L,42L,45L,36L,37L,34L,33L,32L,97L,98L,101L,100L,109L,106L,105L,104L,121L,122L,125L,116L,117L,114L,113L,80L,81L,82L,85L,84L,93L,90L,89L,72L,73L,74L,77L,68L,69L,66L,65L,64L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073122Inst : IEnumerable<long>
{
public static readonly long[] Value=A073122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073122.Bytes);
public long this[int i]=>Value[i];

public static A073122Inst Instance=new A073122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073123
{
public static readonly long[] Value={ 4L,6L,12L,18L,36L,42L,60L,70L,88L,112L,130L,162L,180L,192L,222L,250L,280L,292L,336L,358L,372L,408L,432L,462L,520L,556L,568L,592L,600L,618L,718L,742L,786L,808L,862L,880L,928L,970L,996L,1032L,1068L,1090L,1162L,1180L,1212L,1222L,1300L,1422L,1438L,1450L,1480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073123Inst : IEnumerable<long>
{
public static readonly long[] Value=A073123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073123.Bytes);
public long this[int i]=>Value[i];

public static A073123Inst Instance=new A073123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073124
{
public static readonly long[] Value={ 2L,2L,2L,2L,6L,2L,2L,4L,6L,4L,4L,6L,2L,2L,12L,10L,4L,10L,6L,6L,6L,8L,2L,2L,12L,10L,6L,6L,2L,2L,10L,4L,14L,12L,4L,4L,10L,4L,6L,2L,6L,4L,10L,10L,12L,6L,4L,14L,6L,4L,10L,12L,8L,4L,6L,24L,10L,6L,2L,8L,14L,18L,2L,6L,2L,12L,16L,4L,6L,6L,2L,6L,26L,2L,8L,10L,4L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073124Inst : IEnumerable<long>
{
public static readonly long[] Value=A073124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073124.Bytes);
public long this[int i]=>Value[i];

public static A073124Inst Instance=new A073124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073125
{
public static readonly long[] Value={ 2L,3L,17L,5L,17L,5L,13L,29L,2L,13L,17L,11L,7L,11L,7L,7L,11L,7L,7L,67L,5L,47L,193L,43L,3L,3L,5L,53L,173L,41L,181L,31L,181L,41L,211L,31L,211L,181L,113L,29L,173L,13L,173L,19L,229L,181L,197L,17L,193L,13L,113L,17L,113L,619L,191L,13L,179L,173L,167L,743L,1499L,7L,1627L,733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073125Inst : IEnumerable<long>
{
public static readonly long[] Value=A073125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073125.Bytes);
public long this[int i]=>Value[i];

public static A073125Inst Instance=new A073125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073126
{
public static readonly long[] Value={ 3L,7L,29L,17L,37L,23L,41L,61L,29L,53L,61L,59L,59L,67L,67L,71L,79L,79L,83L,167L,89L,157L,331L,163L,103L,107L,113L,193L,347L,191L,367L,191L,379L,211L,421L,211L,433L,409L,347L,229L,419L,223L,431L,239L,499L,457L,479L,257L,487L,263L,419L,277L,431L,997L,521L,293L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073126Inst : IEnumerable<long>
{
public static readonly long[] Value=A073126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073126.Bytes);
public long this[int i]=>Value[i];

public static A073126Inst Instance=new A073126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073127
{
public static readonly long[] Value={ 1L,2L,4L,3L,4L,3L,4L,4L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,4L,5L,6L,5L,4L,4L,4L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,6L,6L,5L,6L,5L,6L,5L,6L,6L,6L,5L,6L,5L,6L,5L,6L,7L,6L,5L,6L,6L,6L,7L,8L,5L,8L,7L,8L,6L,5L,6L,6L,6L,8L,7L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,8L,6L,8L,6L,8L,6L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073127Inst : IEnumerable<long>
{
public static readonly long[] Value=A073127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073127.Bytes);
public long this[int i]=>Value[i];

public static A073127Inst Instance=new A073127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073128
{
public static readonly long[] Value={ 0L,1L,1L,5L,5L,49L,118L,121L,2406L,2698L,4182L,4946L,153627L,3087192L,8203485L,38394376L,487844934L,2822741576L,4140154385L,4397137572L,8583966231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073128Inst : IEnumerable<long>
{
public static readonly long[] Value=A073128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073128.Bytes);
public long this[int i]=>Value[i];

public static A073128Inst Instance=new A073128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073129
{
public static readonly BigInteger[] Value={ 0L,4L,5L,120L,125L,12201L,70800L,74657L,29526432L,37132574L,89210424L,124777688L,120392102955L,48617257062792L,343289046464505L,7519663359716376L,1214022599940709056L,BigInteger.Parse("40644839476190305216"),BigInteger.Parse("87437200646372849005"),BigInteger.Parse("98628693371623948080"),BigInteger.Parse("375871306587181970568") };
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
public class A073129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073129Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073129.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073129.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073129Inst Instance=new A073129Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073130
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,4L,2L,2L,6L,2L,2L,4L,6L,6L,2L,6L,2L,2L,2L,2L,6L,8L,2L,2L,4L,2L,2L,2L,2L,2L,2L,2L,2L,6L,6L,4L,2L,2L,2L,2L,2L,2L,2L,4L,4L,4L,2L,4L,2L,2L,2L,6L,6L,6L,2L,2L,4L,2L,2L,2L,4L,2L,2L,2L,6L,2L,2L,2L,6L,4L,6L,6L,2L,6L,4L,2L,2L,2L,2L,2L,2L,6L,2L,6L,4L,2L,2L,4L,4L,2L,4L,2L,2L,2L,12L,2L,6L,2L,2L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073130Inst : IEnumerable<long>
{
public static readonly long[] Value=A073130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073130.Bytes);
public long this[int i]=>Value[i];

public static A073130Inst Instance=new A073130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073131
{
public static readonly long[] Value={ 2L,6L,6L,14L,10L,18L,8L,16L,26L,18L,30L,22L,12L,20L,30L,36L,6L,48L,22L,14L,34L,30L,30L,48L,38L,16L,24L,12L,18L,92L,30L,34L,24L,62L,18L,42L,48L,24L,40L,32L,24L,66L,18L,30L,16L,80L,112L,24L,14L,24L,28L,24L,74L,24L,48L,54L,18L,46L,36L,24L,66L,114L,36L,18L,18L,122L,48L,72L,10L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073131Inst : IEnumerable<long>
{
public static readonly long[] Value=A073131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073131.Bytes);
public long this[int i]=>Value[i];

public static A073131Inst Instance=new A073131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073132
{
public static readonly long[] Value={ 1L,0L,2L,7L,5L,13L,4L,8L,6L,14L,12L,27L,9L,51L,11L,40L,21L,16L,25L,39L,36L,96L,58L,18L,132L,134L,56L,106L,108L,72L,34L,102L,42L,158L,202L,68L,53L,118L,121L,46L,124L,101L,383L,91L,157L,30L,80L,97L,204L,126L,258L,139L,381L,145L,222L,47L,62L,240L,242L,363L,66L,177L,565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073132Inst : IEnumerable<long>
{
public static readonly long[] Value=A073132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073132.Bytes);
public long this[int i]=>Value[i];

public static A073132Inst Instance=new A073132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073133
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,5L,3L,1L,4L,10L,12L,5L,1L,5L,17L,33L,29L,8L,1L,6L,26L,72L,109L,70L,13L,1L,7L,37L,135L,305L,360L,169L,21L,1L,8L,50L,228L,701L,1292L,1189L,408L,34L,1L,9L,65L,357L,1405L,3640L,5473L,3927L,985L,55L,1L,10L,82L,528L,2549L,8658L,18901L,23184L,12970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073133Inst : IEnumerable<long>
{
public static readonly long[] Value=A073133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073133.Bytes);
public long this[int i]=>Value[i];

public static A073133Inst Instance=new A073133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073134
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,-1L,3L,3L,1L,-1L,4L,8L,4L,1L,0L,5L,21L,15L,5L,1L,1L,6L,55L,56L,24L,6L,1L,1L,7L,144L,209L,115L,35L,7L,1L,0L,8L,377L,780L,551L,204L,48L,8L,1L,-1L,9L,987L,2911L,2640L,1189L,329L,63L,9L,1L,-1L,10L,2584L,10864L,12649L,6930L,2255L,496L,80L,10L,1L,0L,11L,6765L,40545L,60605L,40391L,15456L,3905L,711L,99L,11L,1L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073134Inst : IEnumerable<long>
{
public static readonly long[] Value=A073134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073134.Bytes);
public long this[int i]=>Value[i];

public static A073134Inst Instance=new A073134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073135
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,12L,6L,1L,6L,32L,27L,8L,1L,10L,81L,108L,48L,10L,1L,17L,200L,406L,256L,75L,12L,1L,28L,488L,1470L,1281L,500L,108L,14L,1L,45L,1184L,5193L,6160L,3126L,864L,147L,16L,1L,72L,2865L,18036L,28832L,18770L,6481L,1372L,192L,18L,1L,116L,6924L,61885L,132352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073135Inst : IEnumerable<long>
{
public static readonly long[] Value=A073135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073135.Bytes);
public long this[int i]=>Value[i];

public static A073135Inst Instance=new A073135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073136
{
public static readonly long[] Value={ 5L,8L,16L,24L,42L,54L,76L,86L,106L,138L,158L,194L,220L,234L,258L,294L,336L,344L,398L,424L,440L,480L,514L,550L,606L,648L,666L,694L,708L,730L,836L,870L,910L,936L,1008L,1028L,1076L,1130L,1158L,1204L,1242L,1268L,1344L,1364L,1398L,1416L,1508L,1632L,1660L,1676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073136Inst : IEnumerable<long>
{
public static readonly long[] Value=A073136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073136.Bytes);
public long this[int i]=>Value[i];

public static A073136Inst Instance=new A073136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073137
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,5L,7L,8L,9L,9L,11L,9L,11L,11L,15L,16L,17L,17L,19L,17L,19L,19L,23L,17L,19L,19L,23L,19L,23L,23L,31L,32L,33L,33L,35L,33L,35L,35L,39L,33L,35L,35L,39L,35L,39L,39L,47L,33L,35L,35L,39L,35L,39L,39L,47L,35L,39L,39L,47L,39L,47L,47L,63L,64L,65L,65L,67L,65L,67L,67L,71L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073137Inst : IEnumerable<long>
{
public static readonly long[] Value=A073137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073137.Bytes);
public long this[int i]=>Value[i];

public static A073137Inst Instance=new A073137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073138
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,6L,7L,8L,12L,12L,14L,12L,14L,14L,15L,16L,24L,24L,28L,24L,28L,28L,30L,24L,28L,28L,30L,28L,30L,30L,31L,32L,48L,48L,56L,48L,56L,56L,60L,48L,56L,56L,60L,56L,60L,60L,62L,48L,56L,56L,60L,56L,60L,60L,62L,56L,60L,60L,62L,60L,62L,62L,63L,64L,96L,96L,112L,96L,112L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073138Inst : IEnumerable<long>
{
public static readonly long[] Value=A073138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073138.Bytes);
public long this[int i]=>Value[i];

public static A073138Inst Instance=new A073138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073139
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,0L,3L,3L,3L,3L,3L,3L,0L,0L,7L,7L,9L,7L,9L,9L,7L,7L,9L,9L,7L,9L,7L,7L,0L,0L,15L,15L,21L,15L,21L,21L,21L,15L,21L,21L,21L,21L,21L,21L,15L,15L,21L,21L,21L,21L,21L,21L,15L,21L,21L,21L,15L,21L,15L,15L,0L,0L,31L,31L,45L,31L,45L,45L,49L,31L,45L,45L,49L,45L,49L,49L,45L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073139Inst : IEnumerable<long>
{
public static readonly long[] Value=A073139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073139.Bytes);
public long this[int i]=>Value[i];

public static A073139Inst Instance=new A073139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073172
{
public static readonly long[] Value={ 1L,4L,9L,1024L,5621641L,10188864L,27657081L,308950929L,619113924L,904265041L,10011203136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073172Inst : IEnumerable<long>
{
public static readonly long[] Value=A073172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073172.Bytes);
public long this[int i]=>Value[i];

public static A073172Inst Instance=new A073172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073173
{
public static readonly long[] Value={ 4L,9L,16L,1225L,6036849L,10909809L,29484900L,326561041L,653058025L,952833424L,10487398464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073173Inst : IEnumerable<long>
{
public static readonly long[] Value=A073173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073173.Bytes);
public long this[int i]=>Value[i];

public static A073173Inst Instance=new A073173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073174
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,4L,5L,5L,5L,7L,7L,9L,10L,7L,8L,11L,10L,14L,15L,11L,12L,16L,15L,18L,21L,18L,18L,25L,22L,29L,32L,21L,21L,23L,23L,30L,34L,27L,23L,34L,34L,41L,48L,30L,27L,41L,37L,41L,48L,43L,45L,59L,54L,38L,43L,39L,41L,57L,46L,64L,82L,48L,52L,70L,55L,84L,99L,70L,57L,86L,86L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073174Inst : IEnumerable<long>
{
public static readonly long[] Value=A073174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073174.Bytes);
public long this[int i]=>Value[i];

public static A073174Inst Instance=new A073174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073175
{
public static readonly long[] Value={ 2L,23L,101L,4567L,67891L,789101L,4567891L,23456789L,728293031L,1234567891L,45678910111L,678910111213L,1222324252627L,12345678910111L,415161718192021L,3637383940414243L,12223242526272829L,910111213141516171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073175Inst : IEnumerable<long>
{
public static readonly long[] Value=A073175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073175.Bytes);
public long this[int i]=>Value[i];

public static A073175Inst Instance=new A073175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073176
{
public static readonly BigInteger[] Value={ 3L,79L,911L,5791L,79111L,31051L,1232527L,23252729L,113151719L,2527293133L,57911131517L,991011031051L,6769717375777L,41434547495153L,192123252729313L,4547495153555759L,31517192123252729L,BigInteger.Parse("71921232527293133353") };
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
public class A073176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073176Inst Instance=new A073176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073177
{
public static readonly long[] Value={ 6L,7L,4L,8L,10L,72L,2L,48L,10L,24L,20L,40L,81L,0L,36L,15L,4L,9L,40L,12L,36L,0L,12L,32L,21L,12L,56L,3L,6L,35L,18L,30L,0L,4L,32L,72L,28L,7L,45L,49L,2L,24L,63L,0L,81L,27L,18L,63L,45L,9L,0L,45L,40L,14L,0L,81L,42L,24L,81L,24L,28L,30L,18L,14L,21L,0L,28L,0L,7L,36L,24L,0L,0L,6L,40L,18L,10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073177Inst : IEnumerable<long>
{
public static readonly long[] Value=A073177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073177.Bytes);
public long this[int i]=>Value[i];

public static A073177Inst Instance=new A073177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073178
{
public static readonly BigInteger[] Value={ 1L,2L,13L,180L,4266L,153180L,7725510L,519629040L,44880355800L,4835536256880L,635221698211800L,99872627051181600L,BigInteger.Parse("18507444606249152400"),BigInteger.Parse("3990439472567239692000"),BigInteger.Parse("990119486841576670378800") };
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
public class A073178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073178Inst Instance=new A073178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073179
{
public static readonly BigInteger[] Value={ 1L,1L,5L,64L,1417L,47801L,2278981L,145735360L,12026529089L,1243307884537L,157278532956301L,23885127975415136L,4286460830620175065L,BigInteger.Parse("897058398619374567889"),BigInteger.Parse("216462065577670278012557") };
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
public class A073179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A073179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073179Inst Instance=new A073179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073180
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,2L,2L,2L,4L,2L,5L,2L,4L,4L,2L,2L,4L,2L,5L,4L,4L,2L,5L,2L,4L,2L,5L,2L,8L,2L,2L,4L,4L,4L,5L,2L,4L,4L,6L,2L,8L,2L,5L,5L,4L,2L,5L,2L,4L,4L,5L,2L,4L,4L,6L,4L,4L,2L,11L,2L,4L,5L,2L,4L,8L,2L,5L,4L,8L,2L,5L,2L,4L,4L,5L,4L,8L,2L,6L,2L,4L,2L,11L,4L,4L,4L,6L,2L,10L,4L,5L,4L,4L,4L,5L,2L,4L,5L,5L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073180Inst : IEnumerable<long>
{
public static readonly long[] Value=A073180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073180.Bytes);
public long this[int i]=>Value[i];

public static A073180Inst Instance=new A073180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073181
{
public static readonly long[] Value={ 1L,3L,4L,3L,6L,12L,8L,3L,4L,18L,12L,16L,14L,24L,24L,3L,18L,12L,20L,22L,32L,36L,24L,16L,6L,42L,4L,28L,30L,72L,32L,3L,48L,54L,48L,16L,38L,60L,56L,30L,42L,96L,44L,40L,33L,72L,48L,16L,8L,18L,72L,46L,54L,12L,72L,36L,80L,90L,60L,108L,62L,96L,41L,3L,84L,144L,68L,58L,96L,144L,72L,16L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073181Inst : IEnumerable<long>
{
public static readonly long[] Value=A073181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073181.Bytes);
public long this[int i]=>Value[i];

public static A073181Inst Instance=new A073181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073182
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,3L,3L,4L,2L,6L,2L,4L,4L,3L,2L,6L,2L,6L,4L,4L,2L,7L,3L,4L,3L,6L,2L,8L,2L,3L,4L,4L,4L,9L,2L,4L,4L,7L,2L,8L,2L,6L,6L,4L,2L,7L,3L,6L,4L,6L,2L,6L,4L,7L,4L,4L,2L,12L,2L,4L,6L,3L,4L,8L,2L,6L,4L,8L,2L,11L,2L,4L,6L,6L,4L,8L,2L,8L,3L,4L,2L,12L,4L,4L,4L,7L,2L,12L,4L,6L,4L,4L,4L,7L,2L,6L,6L,9L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073182Inst : IEnumerable<long>
{
public static readonly long[] Value=A073182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073182.Bytes);
public long this[int i]=>Value[i];

public static A073182Inst Instance=new A073182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073183
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,12L,8L,7L,13L,18L,12L,28L,14L,24L,24L,7L,18L,39L,20L,42L,32L,36L,24L,36L,31L,42L,13L,56L,30L,72L,32L,7L,48L,54L,48L,91L,38L,60L,56L,50L,42L,96L,44L,84L,78L,72L,48L,36L,57L,93L,72L,98L,54L,39L,72L,64L,80L,90L,60L,168L,62L,96L,104L,7L,84L,144L,68L,126L,96L,144L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073183Inst : IEnumerable<long>
{
public static readonly long[] Value=A073183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073183.Bytes);
public long this[int i]=>Value[i];

public static A073183Inst Instance=new A073183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073184
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,3L,3L,4L,2L,6L,2L,4L,4L,3L,2L,6L,2L,6L,4L,4L,2L,6L,3L,4L,3L,6L,2L,8L,2L,3L,4L,4L,4L,9L,2L,4L,4L,6L,2L,8L,2L,6L,6L,4L,2L,6L,3L,6L,4L,6L,2L,6L,4L,6L,4L,4L,2L,12L,2L,4L,6L,3L,4L,8L,2L,6L,4L,8L,2L,9L,2L,4L,6L,6L,4L,8L,2L,6L,3L,4L,2L,12L,4L,4L,4L,6L,2L,12L,4L,6L,4L,4L,4L,6L,2L,6L,6L,9L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073184Inst : IEnumerable<long>
{
public static readonly long[] Value=A073184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073184.Bytes);
public long this[int i]=>Value[i];

public static A073184Inst Instance=new A073184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073185
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,12L,8L,7L,13L,18L,12L,28L,14L,24L,24L,7L,18L,39L,20L,42L,32L,36L,24L,28L,31L,42L,13L,56L,30L,72L,32L,7L,48L,54L,48L,91L,38L,60L,56L,42L,42L,96L,44L,84L,78L,72L,48L,28L,57L,93L,72L,98L,54L,39L,72L,56L,80L,90L,60L,168L,62L,96L,104L,7L,84L,144L,68L,126L,96L,144L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073185Inst : IEnumerable<long>
{
public static readonly long[] Value=A073185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073185.Bytes);
public long this[int i]=>Value[i];

public static A073185Inst Instance=new A073185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073186
{
public static readonly long[] Value={ 2L,41L,101L,8101L,30323L,141161L,2468101L,42628303L,246810121L,8101214161L,68101214161L,890929496981L,1081101121141L,68890929496981L,202224262830323L,6416616817017217L,58606264666870727L,618202224262830323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073186Inst : IEnumerable<long>
{
public static readonly long[] Value=A073186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073186.Bytes);
public long this[int i]=>Value[i];

public static A073186Inst Instance=new A073186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073187
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,14L,5L,42L,21L,132L,84L,3L,429L,330L,28L,1430L,1287L,180L,4862L,5005L,990L,12L,16796L,19448L,5005L,165L,58786L,75582L,24024L,1430L,208012L,293930L,111384L,10010L,55L,742900L,1144066L,503880L,61880L,1001L,2674440L,4457400L,2238390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073187Inst : IEnumerable<long>
{
public static readonly long[] Value=A073187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073187.Bytes);
public long this[int i]=>Value[i];

public static A073187Inst Instance=new A073187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073204
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,2L,6L,2L,1L,1L,2L,2L,2L,12L,2L,2L,1L,1L,2L,2L,2L,120L,2L,6L,2L,1L,1L,2L,2L,2L,120L,2L,12L,4L,1L,1L,1L,2L,2L,2L,840L,2L,120L,8L,1L,2L,1L,1L,2L,2L,2L,840L,2L,120L,16L,1L,4L,1L,1L,1L,2L,2L,2L,5040L,2L,840L,32L,1L,8L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073204Inst : IEnumerable<long>
{
public static readonly long[] Value=A073204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073204.Bytes);
public long this[int i]=>Value[i];

public static A073204Inst Instance=new A073204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073205
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,12L,17L,16L,18L,10L,21L,11L,14L,15L,13L,19L,20L,22L,23L,26L,31L,30L,32L,45L,57L,44L,42L,43L,46L,47L,48L,50L,24L,35L,49L,56L,63L,25L,58L,28L,37L,38L,29L,39L,40L,41L,27L,59L,33L,51L,52L,34L,53L,54L,55L,36L,60L,61L,62L,64L,65L,68L,73L,72L,74L,87L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073205Inst : IEnumerable<long>
{
public static readonly long[] Value=A073205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073205.Bytes);
public long this[int i]=>Value[i];

public static A073205Inst Instance=new A073205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073206
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,14L,16L,10L,19L,17L,18L,12L,11L,13L,20L,21L,15L,22L,23L,37L,42L,24L,51L,44L,47L,26L,25L,27L,53L,56L,38L,60L,45L,46L,48L,49L,50L,31L,32L,30L,28L,33L,34L,35L,39L,36L,54L,55L,57L,58L,59L,40L,29L,43L,52L,61L,62L,63L,41L,64L,65L,107L,121L,66L,149L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073206Inst : IEnumerable<long>
{
public static readonly long[] Value=A073206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073206.Bytes);
public long this[int i]=>Value[i];

public static A073206Inst Instance=new A073206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073207
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,11L,17L,16L,20L,12L,18L,10L,14L,15L,13L,19L,21L,22L,23L,31L,28L,24L,33L,45L,49L,44L,42L,43L,54L,53L,57L,61L,30L,29L,46L,47L,55L,25L,48L,26L,37L,40L,32L,38L,39L,41L,34L,50L,27L,51L,52L,35L,56L,58L,59L,36L,60L,62L,63L,64L,65L,84L,87L,73L,96L,79L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073207Inst : IEnumerable<long>
{
public static readonly long[] Value=A073207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073207.Bytes);
public long this[int i]=>Value[i];

public static A073207Inst Instance=new A073207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073208
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,16L,10L,14L,19L,17L,18L,12L,11L,15L,20L,13L,21L,22L,23L,26L,42L,44L,53L,25L,38L,37L,24L,47L,27L,51L,56L,60L,45L,48L,49L,46L,50L,31L,32L,30L,28L,39L,40L,43L,29L,52L,54L,55L,34L,33L,41L,57L,35L,58L,59L,61L,36L,62L,63L,64L,65L,126L,73L,72L,76L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073208Inst : IEnumerable<long>
{
public static readonly long[] Value=A073208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073208.Bytes);
public long this[int i]=>Value[i];

public static A073208Inst Instance=new A073208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073209
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,10L,17L,16L,18L,11L,21L,12L,14L,20L,13L,15L,19L,22L,23L,24L,25L,26L,27L,45L,46L,44L,42L,49L,48L,43L,47L,50L,28L,29L,58L,56L,63L,30L,57L,31L,37L,38L,32L,54L,53L,62L,33L,59L,34L,39L,61L,35L,40L,51L,55L,36L,41L,52L,60L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073209Inst : IEnumerable<long>
{
public static readonly long[] Value=A073209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073209.Bytes);
public long this[int i]=>Value[i];

public static A073209Inst Instance=new A073209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073210
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,10L,14L,16L,19L,17L,20L,12L,11L,13L,21L,18L,15L,22L,23L,24L,25L,26L,27L,37L,38L,42L,44L,47L,51L,53L,56L,60L,45L,46L,54L,57L,61L,31L,34L,30L,28L,29L,35L,33L,32L,36L,58L,62L,49L,48L,59L,40L,43L,39L,52L,63L,55L,50L,41L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073210Inst : IEnumerable<long>
{
public static readonly long[] Value=A073210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073210.Bytes);
public long this[int i]=>Value[i];

public static A073210Inst Instance=new A073210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073211
{
public static readonly long[] Value={ 2L,12L,22L,122L,132L,242L,1332L,1342L,1452L,2662L,14642L,14652L,14762L,15972L,29282L,161052L,161062L,161172L,162382L,175692L,322102L,1771562L,1771572L,1771682L,1772892L,1786202L,1932612L,3543122L,19487172L,19487182L,19487292L,19488502L,19501812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073211Inst : IEnumerable<long>
{
public static readonly long[] Value=A073211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073211.Bytes);
public long this[int i]=>Value[i];

public static A073211Inst Instance=new A073211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073212
{
public static readonly long[] Value={ 5L,8L,5L,9L,7L,17L,3L,14L,7L,11L,9L,13L,18L,7L,13L,8L,4L,6L,13L,7L,12L,2L,8L,12L,10L,7L,15L,4L,5L,12L,11L,11L,6L,4L,12L,17L,11L,8L,14L,14L,3L,10L,16L,3L,18L,12L,9L,16L,14L,10L,5L,14L,13L,9L,4L,18L,13L,10L,18L,10L,11L,11L,11L,9L,10L,2L,11L,8L,8L,12L,10L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073212Inst : IEnumerable<long>
{
public static readonly long[] Value=A073212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073212.Bytes);
public long this[int i]=>Value[i];

public static A073212Inst Instance=new A073212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073213
{
public static readonly long[] Value={ 2L,18L,34L,290L,306L,578L,4914L,4930L,5202L,9826L,83522L,83538L,83810L,88434L,167042L,1419858L,1419874L,1420146L,1424770L,1503378L,2839714L,24137570L,24137586L,24137858L,24142482L,24221090L,25557426L,48275138L,410338674L,410338690L,410338962L,410343586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073213Inst : IEnumerable<long>
{
public static readonly long[] Value=A073213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073213.Bytes);
public long this[int i]=>Value[i];

public static A073213Inst Instance=new A073213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073214
{
public static readonly long[] Value={ 2L,20L,38L,362L,380L,722L,6860L,6878L,7220L,13718L,130322L,130340L,130682L,137180L,260642L,2476100L,2476118L,2476460L,2482958L,2606420L,4952198L,47045882L,47045900L,47046242L,47052740L,47176202L,49521980L,94091762L,893871740L,893871758L,893872100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073214Inst : IEnumerable<long>
{
public static readonly long[] Value=A073214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073214.Bytes);
public long this[int i]=>Value[i];

public static A073214Inst Instance=new A073214Inst();

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