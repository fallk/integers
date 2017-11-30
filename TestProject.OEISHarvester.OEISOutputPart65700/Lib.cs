using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A092973
{
public static readonly long[] Value={ 1L,1L,2L,3L,-16L,-15L,-12L,-7L,-64L,-63L,-120L,-165L,2304L,2145L,1680L,945L,16384L,16065L,30240L,40755L,-921600L,-855855L,-665280L,-369495L,-9437184L,-9237375L,-17297280L,-23108085L,722534400L,670134465L,518918400L,286358625L,9663676416L,9449834625L,17643225600L,23454706275L,-936404582400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092973Inst : IEnumerable<long>
{
public static readonly long[] Value=A092973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092973.Bytes);
public long this[int i]=>Value[i];

public static A092973Inst Instance=new A092973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092974
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,-20L,-18L,-14L,-8L,-81L,-80L,-154L,-216L,-260L,3640L,3240L,2464L,1360L,26244L,25840L,49280L,68040L,80080L,-1841840L,-1632960L,-1232000L,-671840L,-19131876L,-18811520L,-35728000L,-48988800L,-57097040L,1827105280L,1616630400L,1214752000L,658403200L,24794911296L,24360918400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092974Inst : IEnumerable<long>
{
public static readonly long[] Value=A092974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092974.Bytes);
public long this[int i]=>Value[i];

public static A092974Inst Instance=new A092974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092975
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,7L,16L,27L,32L,11L,81L,13L,128L,243L,256L,17L,729L,19L,1024L,2187L,2048L,23L,6561L,3125L,8192L,19683L,16384L,29L,59049L,31L,65536L,177147L,131072L,78125L,531441L,37L,524288L,1594323L,1048576L,41L,4782969L,43L,4194304L,14348907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092975Inst : IEnumerable<long>
{
public static readonly long[] Value=A092975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092975.Bytes);
public long this[int i]=>Value[i];

public static A092975Inst Instance=new A092975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092976
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,7L,2L,5L,4L,10L,2L,19L,2L,13L,13L,9L,2L,37L,2L,29L,17L,19L,2L,61L,6L,22L,10L,39L,2L,247L,2L,17L,25L,28L,25L,127L,2L,31L,29L,97L,2L,450L,2L,59L,82L,37L,2L,217L,8L,146L,37L,69L,2L,271L,37L,133L,41L,46L,2L,1558L,2L,49L,112L,33L,43L,1038L,2L,89L,49L,1105L,2L,469L,2L,58L,211L,99L,49L,1423L,2L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092976Inst : IEnumerable<long>
{
public static readonly long[] Value=A092976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092976.Bytes);
public long this[int i]=>Value[i];

public static A092976Inst Instance=new A092976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092977
{
public static readonly long[] Value={ 2L,3L,7L,5L,11L,7L,43L,17L,19L,11L,23L,13L,79L,29L,31L,17L,103L,19L,457L,41L,43L,23L,47L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092977Inst : IEnumerable<long>
{
public static readonly long[] Value=A092977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092977.Bytes);
public long this[int i]=>Value[i];

public static A092977Inst Instance=new A092977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092978
{
public static readonly long[] Value={ 2L,8L,16L,128L,256L,3072L,6144L,98304L,196608L,3932160L,7864320L,188743680L,25165824L,704643072L,21139292160L,676457349120L,1352914698240L,48704929136640L,4638564679680L,185542587187200L,7792788661862400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092978Inst : IEnumerable<long>
{
public static readonly long[] Value=A092978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092978.Bytes);
public long this[int i]=>Value[i];

public static A092978Inst Instance=new A092978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092979
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,10L,11L,13L,15L,16L,18L,20L,21L,23L,25L,27L,28L,30L,32L,33L,35L,37L,39L,40L,42L,44L,45L,47L,49L,51L,52L,54L,56L,58L,59L,61L,63L,65L,66L,68L,70L,72L,73L,75L,77L,79L,80L,82L,84L,86L,88L,89L,91L,93L,95L,96L,98L,100L,102L,103L,105L,107L,109L,111L,112L,114L,116L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092979Inst : IEnumerable<long>
{
public static readonly long[] Value=A092979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092979.Bytes);
public long this[int i]=>Value[i];

public static A092979Inst Instance=new A092979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093028
{
public static readonly long[] Value={ 1L,15L,20L,39L,44L,58L,63L,77L,82L,96L,100L,119L,124L,138L,143L,157L,162L,176L,181L,195L,204L,218L,223L,237L,242L,256L,261L,275L,280L,299L,303L,317L,322L,336L,341L,355L,360L,379L,384L,398L,402L,416L,421L,435L,440L,459L,464L,478L,483L,497L,505L,510L,529L,534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093028Inst : IEnumerable<long>
{
public static readonly long[] Value=A093028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093028.Bytes);
public long this[int i]=>Value[i];

public static A093028Inst Instance=new A093028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093029
{
public static readonly long[] Value={ 5L,10L,29L,34L,48L,53L,67L,72L,86L,91L,109L,114L,128L,133L,147L,152L,166L,171L,185L,190L,208L,213L,227L,232L,246L,251L,265L,270L,289L,294L,307L,312L,326L,331L,345L,350L,369L,374L,388L,393L,406L,411L,425L,430L,449L,454L,468L,473L,487L,492L,500L,519L,524L,538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093029Inst : IEnumerable<long>
{
public static readonly long[] Value=A093029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093029.Bytes);
public long this[int i]=>Value[i];

public static A093029Inst Instance=new A093029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093030
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,5L,11L,6L,1L,7L,5L,8L,1L,9L,1L,5L,7L,22L,1L,8L,5L,2L,9L,7L,1L,6L,1L,8L,33L,2L,7L,9L,1L,2L,3L,8L,1L,7L,1L,44L,9L,2L,1L,8L,7L,5L,3L,4L,1L,9L,55L,8L,3L,2L,1L,6L,1L,2L,9L,8L,5L,66L,1L,4L,3L,7L,1L,9L,1L,2L,5L,4L,77L,6L,1L,8L,9L,2L,1L,7L,5L,2L,3L,88L,1L,9L,7L,4L,3L,2L,5L,8L,1L,7L,99L,5L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093030Inst : IEnumerable<long>
{
public static readonly long[] Value=A093030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093030.Bytes);
public long this[int i]=>Value[i];

public static A093030Inst Instance=new A093030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093031
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,25L,29L,33L,37L,41L,47L,53L,59L,65L,73L,81L,87L,93L,99L,105L,111L,117L,123L,129L,135L,141L,147L,153L,159L,165L,171L,177L,183L,189L,195L,201L,207L,213L,219L,225L,231L,237L,243L,249L,255L,261L,267L,273L,279L,285L,291L,297L,303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093031Inst : IEnumerable<long>
{
public static readonly long[] Value=A093031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093031.Bytes);
public long this[int i]=>Value[i];

public static A093031Inst Instance=new A093031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093032
{
public static readonly long[] Value={ 3L,2L,1L,1L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,3L,4L,5L,4L,3L,4L,3L,2L,1L,2L,3L,4L,3L,4L,5L,4L,3L,2L,3L,2L,1L,2L,3L,2L,3L,4L,5L,4L,3L,4L,5L,6L,5L,4L,3L,4L,3L,2L,1L,2L,3L,4L,3L,4L,5L,4L,3L,2L,3L,2L,1L,2L,3L,4L,3L,4L,5L,4L,3L,2L,3L,4L,5L,4L,3L,4L,5L,6L,7L,6L,5L,4L,5L,6L,5L,4L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093032Inst : IEnumerable<long>
{
public static readonly long[] Value=A093032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093032.Bytes);
public long this[int i]=>Value[i];

public static A093032Inst Instance=new A093032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093033
{
public static readonly long[] Value={ 6L,79L,314L,807L,1654L,2951L,4794L,7279L,10502L,14559L,19546L,25559L,32694L,41047L,50714L,61791L,74374L,88559L,104442L,122119L,141686L,163239L,186874L,212687L,240774L,271231L,304154L,339639L,377782L,418679L,462426L,509119L,558854L,611727L,667834L,727271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093033Inst : IEnumerable<long>
{
public static readonly long[] Value=A093033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093033.Bytes);
public long this[int i]=>Value[i];

public static A093033Inst Instance=new A093033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093034
{
public static readonly BigInteger[] Value={ 2L,7L,29L,673L,30241L,523777L,2178541L,23569921L,33550337L,66433720321L,137438691329L,30823866178561L,796928461056001L,BigInteger.Parse("1802582780370364661761"),BigInteger.Parse("9186050031556349952001"),BigInteger.Parse("2827987212986831882236723201") };
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
public class A093034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093034Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093034.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093034.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093034Inst Instance=new A093034Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093035
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,17L,1L,20L,8L,20L,1L,103L,1L,20L,27L,54L,1L,109L,1L,112L,27L,20L,1L,315L,8L,20L,27L,112L,1L,315L,1L,112L,27L,20L,27L,481L,1L,20L,27L,324L,1L,321L,1L,112L,125L,20L,1L,695L,8L,112L,27L,112L,1L,321L,27L,324L,27L,20L,1L,1285L,1L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093035Inst : IEnumerable<long>
{
public static readonly long[] Value=A093035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093035.Bytes);
public long this[int i]=>Value[i];

public static A093035Inst Instance=new A093035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093036
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,24L,66L,132L,264L,792L,1848L,2772L,5544L,13332L,14652L,24024L,26664L,72072L,79992L,186648L,205128L,264264L,559944L,792792L,1333332L,2666664L,7279272L,7999992L,13333320L,14666652L,26690664L,29333304L,80071992L,134666532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093036Inst : IEnumerable<long>
{
public static readonly long[] Value=A093036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093036.Bytes);
public long this[int i]=>Value[i];

public static A093036Inst Instance=new A093036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093037
{
public static readonly long[] Value={ 1L,10L,20L,30L,48L,60L,120L,180L,240L,360L,420L,720L,840L,1260L,1440L,1680L,2520L,3360L,5040L,7560L,10080L,15120L,20160L,25200L,30240L,43680L,45360L,50400L,55440L,60480L,65520L,90720L,98280L,110880L,131040L,166320L,196560L,262080L,327600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093037Inst : IEnumerable<long>
{
public static readonly long[] Value=A093037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093037.Bytes);
public long this[int i]=>Value[i];

public static A093037Inst Instance=new A093037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093038
{
public static readonly long[] Value={ 1L,2L,3L,6L,322L,966L,473732L,1420296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093038Inst : IEnumerable<long>
{
public static readonly long[] Value=A093038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093038.Bytes);
public long this[int i]=>Value[i];

public static A093038Inst Instance=new A093038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093039
{
public static readonly long[] Value={ 1L,2L,7L,11L,25L,35L,65L,85L,140L,175L,266L,322L,462L,546L,750L,870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093039Inst : IEnumerable<long>
{
public static readonly long[] Value=A093039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093039.Bytes);
public long this[int i]=>Value[i];

public static A093039Inst Instance=new A093039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093040
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,6L,11L,17L,27L,45L,72L,116L,189L,305L,493L,799L,1292L,2090L,3383L,5473L,8855L,14329L,23184L,37512L,60697L,98209L,158905L,257115L,416020L,673134L,1089155L,1762289L,2851443L,4613733L,7465176L,12078908L,19544085L,31622993L,51167077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093040Inst : IEnumerable<long>
{
public static readonly long[] Value=A093040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093040.Bytes);
public long this[int i]=>Value[i];

public static A093040Inst Instance=new A093040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093041
{
public static readonly long[] Value={ 1L,1L,2L,6L,16L,38L,86L,192L,426L,938L,2048L,4438L,9558L,20480L,43690L,92842L,196608L,415062L,873814L,1835008L,3844778L,8039082L,16777216L,34952534L,72701270L,150994944L,313174698L,648719018L,1342177280L,2773833046L,5726623062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093041Inst : IEnumerable<long>
{
public static readonly long[] Value=A093041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093041.Bytes);
public long this[int i]=>Value[i];

public static A093041Inst Instance=new A093041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093042
{
public static readonly long[] Value={ 0L,1L,1L,6L,15L,55L,168L,559L,1785L,5814L,18755L,60787L,196560L,636323L,2058797L,6663030L,21561015L,69774527L,225792504L,730684103L,2364536625L,7651812246L,24761766811L,80130789371L,259308635040L,839140445275L,2715515402053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093042Inst : IEnumerable<long>
{
public static readonly long[] Value=A093042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093042.Bytes);
public long this[int i]=>Value[i];

public static A093042Inst Instance=new A093042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093043
{
public static readonly long[] Value={ 0L,0L,1L,3L,10L,33L,105L,344L,1105L,3591L,11594L,37565L,121485L,393264L,1272413L,4117971L,13325450L,43123017L,139547457L,451587592L,1461364025L,4729080015L,15303613546L,49523551333L,160261550085L,518617316448L,1678280815525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093043Inst : IEnumerable<long>
{
public static readonly long[] Value=A093043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093043.Bytes);
public long this[int i]=>Value[i];

public static A093043Inst Instance=new A093043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093076
{
public static readonly BigInteger[] Value={ 1L,2L,1L,1L,29L,1L,161L,207L,163047L,19952084L,1395363L,37433304L,1894884996L,22006266L,5012512L,159420748L,7687917L,856655287905375L,57388884947L,1344799562797L,46899771521770733L,74069716582896006L,BigInteger.Parse("382520592142795071229"),BigInteger.Parse("19340660897970532723387") };
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
public class A093076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093076Inst Instance=new A093076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093077
{
public static readonly long[] Value={ 2L,3L,5L,13L,17L,19L,43L,53L,59L,73L,367L,6143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093077Inst : IEnumerable<long>
{
public static readonly long[] Value=A093077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093077.Bytes);
public long this[int i]=>Value[i];

public static A093077Inst Instance=new A093077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093078
{
public static readonly long[] Value={ 5L,7L,11L,13L,19L,79L,83L,89L,149L,367L,431L,853L,4007L,8819L,8969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093078Inst : IEnumerable<long>
{
public static readonly long[] Value=A093078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093078.Bytes);
public long this[int i]=>Value[i];

public static A093078Inst Instance=new A093078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093079
{
public static readonly long[] Value={ 1L,2L,13L,4L,7L,5L,9L,11L,6L,36L,142L,185L,48L,100L,114L,688L,25L,65L,24L,66L,53L,109L,120L,28L,12L,42L,8L,80L,253L,10L,4424L,239L,61L,116L,91L,45L,51L,41L,94L,590L,171L,107L,22L,75L,847L,236L,74L,55L,168L,487L,78L,21L,180L,113L,73L,27L,211L,137L,157L,49L,46L,112L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093079Inst : IEnumerable<long>
{
public static readonly long[] Value=A093079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093079.Bytes);
public long this[int i]=>Value[i];

public static A093079Inst Instance=new A093079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093080
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,10L,21L,26L,29L,59L,92L,111L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093080Inst : IEnumerable<long>
{
public static readonly long[] Value=A093080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093080.Bytes);
public long this[int i]=>Value[i];

public static A093080Inst Instance=new A093080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093081
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,27L,30L,52L,97L,193L,243L,317L,750L,911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093081Inst : IEnumerable<long>
{
public static readonly long[] Value=A093081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093081.Bytes);
public long this[int i]=>Value[i];

public static A093081Inst Instance=new A093081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093082
{
public static readonly BigInteger[] Value={ 1L,1L,8L,2L,334L,2450L,688L,958L,60676L,151L,239478914L,1718557L,43588850341L,44525L,3435544097L,128202996855L,166046498L,468640744L,9748065626452L,2406214305714L,54782975386L,249195119225246375L,20940713346L,BigInteger.Parse("57388133232314021954"),BigInteger.Parse("9869596698791300782235"),BigInteger.Parse("187739128455384480612259907"),184395236716104L };
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
public class A093082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093082Inst Instance=new A093082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093083
{
public static readonly long[] Value={ 1L,7L,8L,16L,16L,19L,22L,31L,39L,47L,54L,58L,67L,75L,84L,88L,96L,100L,108L,110L,110L,114L,119L,127L,133L,141L,144L,148L,151L,157L,162L,168L,171L,179L,180L,181L,188L,195L,197L,197L,200L,200L,209L,210L,217L,226L,234L,234L,239L,246L,252L,254L,262L,268L,270L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093083Inst : IEnumerable<long>
{
public static readonly long[] Value=A093083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093083.Bytes);
public long this[int i]=>Value[i];

public static A093083Inst Instance=new A093083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093084
{
public static readonly long[] Value={ 0L,5L,12L,19L,21L,22L,27L,33L,39L,43L,52L,52L,53L,58L,61L,63L,71L,77L,77L,83L,83L,89L,94L,95L,97L,97L,106L,106L,106L,114L,116L,120L,120L,122L,126L,129L,130L,130L,134L,136L,137L,142L,151L,154L,157L,162L,171L,174L,183L,192L,194L,197L,202L,211L,219L,227L,227L,232L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093084Inst : IEnumerable<long>
{
public static readonly long[] Value=A093084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093084.Bytes);
public long this[int i]=>Value[i];

public static A093084Inst Instance=new A093084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093085
{
public static readonly long[] Value={ 1L,-2L,0L,0L,1L,2L,0L,0L,-1L,-4L,0L,0L,0L,6L,0L,0L,1L,-8L,0L,0L,0L,12L,0L,0L,-1L,-18L,0L,0L,-1L,24L,0L,0L,2L,-32L,0L,0L,1L,44L,0L,0L,-2L,-58L,0L,0L,-1L,76L,0L,0L,2L,-100L,0L,0L,1L,128L,0L,0L,-3L,-164L,0L,0L,-1L,210L,0L,0L,4L,-264L,0L,0L,2L,332L,0L,0L,-5L,-416L,0L,0L,-2L,516L,0L,0L,5L,-640L,0L,0L,2L,790L,0L,0L,-6L,-968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093085Inst : IEnumerable<long>
{
public static readonly long[] Value=A093085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093085.Bytes);
public long this[int i]=>Value[i];

public static A093085Inst Instance=new A093085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093086
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,1L,3L,9L,4L,1L,2L,1L,3L,5L,3L,3L,4L,8L,8L,6L,7L,1L,2L,1L,6L,1L,4L,1L,3L,8L,3L,3L,7L,7L,5L,5L,4L,1L,1L,1L,1L,6L,1L,0L,1L,4L,1L,2L,1L,0L,9L,5L,2L,2L,2L,7L,7L,1L,1L,5L,5L,3L,3L,1L,9L,1L,4L,7L,4L,4L,9L,1L,4L,8L,2L,6L,1L,0L,8L,6L,4L,1L,0L,1L,0L,5L,1L,1L,1L,1L,8L,1L,3L,1L,0L,5L,1L,2L,1L,0L,8L,7L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093086Inst : IEnumerable<long>
{
public static readonly long[] Value=A093086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093086.Bytes);
public long this[int i]=>Value[i];

public static A093086Inst Instance=new A093086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093087
{
public static readonly long[] Value={ 1L,3L,4L,7L,1L,1L,8L,2L,9L,1L,0L,1L,1L,1L,0L,1L,1L,2L,2L,1L,1L,2L,3L,4L,3L,2L,3L,5L,7L,7L,5L,5L,8L,1L,2L,1L,4L,1L,2L,1L,0L,1L,3L,9L,3L,3L,5L,5L,3L,3L,1L,1L,4L,1L,2L,1L,2L,6L,8L,1L,0L,8L,6L,4L,2L,5L,5L,3L,3L,3L,8L,1L,4L,9L,1L,8L,1L,4L,1L,0L,6L,7L,1L,0L,8L,6L,6L,1L,1L,9L,5L,1L,3L,1L,0L,9L,9L,5L,5L,1L,6L,1L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093087Inst : IEnumerable<long>
{
public static readonly long[] Value=A093087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093087.Bytes);
public long this[int i]=>Value[i];

public static A093087Inst Instance=new A093087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093088
{
public static readonly long[] Value={ 1L,4L,5L,9L,1L,4L,1L,0L,5L,5L,1L,5L,1L,0L,6L,6L,6L,1L,6L,1L,2L,1L,2L,7L,7L,7L,3L,3L,3L,9L,1L,4L,1L,4L,1L,0L,6L,6L,1L,2L,1L,0L,5L,5L,5L,5L,1L,6L,1L,2L,7L,3L,3L,1L,5L,1L,0L,1L,0L,1L,0L,6L,7L,7L,3L,9L,1L,0L,6L,4L,6L,6L,1L,1L,1L,1L,1L,6L,1L,3L,1L,4L,1L,0L,1L,2L,1L,0L,1L,6L,1L,0L,1L,0L,1L,2L,7L,2L,2L,2L,2L,7L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093088Inst : IEnumerable<long>
{
public static readonly long[] Value=A093088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093088.Bytes);
public long this[int i]=>Value[i];

public static A093088Inst Instance=new A093088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093089
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,1L,44L,90L,45L,1L,34L,1L,35L,46L,35L,35L,36L,81L,81L,70L,71L,1L,17L,1L,62L,1L,51L,1L,41L,72L,18L,18L,63L,63L,52L,52L,42L,1L,13L,90L,36L,81L,1L,26L,1L,15L,1L,4L,94L,43L,14L,1L,3L,1L,26L,1L,17L,82L,27L,27L,16L,16L,5L,98L,1L,37L,57L,15L,4L,4L,27L,27L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093089Inst : IEnumerable<long>
{
public static readonly long[] Value=A093089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093089.Bytes);
public long this[int i]=>Value[i];

public static A093089Inst Instance=new A093089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093090
{
public static readonly long[] Value={ 1L,3L,4L,7L,11L,18L,29L,47L,76L,1L,23L,77L,24L,1L,0L,1L,1L,25L,1L,1L,2L,26L,26L,2L,3L,28L,52L,28L,5L,31L,80L,80L,33L,36L,1L,11L,1L,60L,1L,13L,69L,37L,12L,12L,61L,61L,14L,82L,1L,6L,49L,24L,73L,1L,22L,75L,96L,83L,7L,55L,73L,97L,74L,23L,97L,1L,71L,1L,79L,90L,62L,1L,28L,1L,70L,1L,71L,97L,1L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093090Inst : IEnumerable<long>
{
public static readonly long[] Value=A093090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093090.Bytes);
public long this[int i]=>Value[i];

public static A093090Inst Instance=new A093090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093091
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,14L,4L,10L,3L,18L,14L,13L,21L,32L,27L,34L,53L,59L,61L,87L,11L,2L,12L,0L,14L,8L,98L,13L,14L,12L,14L,22L,10L,6L,11L,1L,27L,26L,26L,36L,32L,16L,17L,12L,28L,53L,52L,62L,68L,48L,33L,29L,40L,81L,10L,5L,11L,4L,13L,0L,11L,6L,81L,62L,69L,12L,1L,91L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093091Inst : IEnumerable<long>
{
public static readonly long[] Value=A093091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093091.Bytes);
public long this[int i]=>Value[i];

public static A093091Inst Instance=new A093091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093092
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,1L,3L,9L,4L,12L,1L,3L,16L,1L,3L,4L,1L,9L,1L,7L,4L,7L,5L,10L,10L,8L,1L,1L,1L,1L,12L,1L,5L,20L,18L,9L,2L,2L,2L,1L,3L,1L,3L,6L,2L,5L,38L,2L,7L,1L,1L,4L,4L,3L,4L,4L,4L,9L,8L,7L,4L,3L,40L,9L,8L,2L,5L,8L,7L,7L,8L,8L,1L,3L,1L,7L,1L,5L,1L,1L,7L,4L,3L,4L,9L,1L,7L,10L,7L,1L,3L,1L,5L,14L,1L,5L,16L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093092Inst : IEnumerable<long>
{
public static readonly long[] Value=A093092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093092.Bytes);
public long this[int i]=>Value[i];

public static A093092Inst Instance=new A093092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093093
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,13L,21L,3L,4L,2L,4L,7L,6L,6L,11L,13L,1L,2L,17L,2L,4L,1L,4L,3L,19L,19L,6L,5L,5L,7L,2L,2L,3L,8L,25L,11L,1L,0L,1L,2L,9L,4L,5L,11L,33L,3L,6L,1L,2L,1L,1L,3L,11L,13L,9L,1L,6L,4L,4L,3L,6L,9L,7L,3L,3L,2L,4L,1L,4L,2L,4L,2L,2L,1L,0L,7L,1L,0L,8L,7L,9L,15L,1L,6L,1L,0L,6L,5L,6L,5L,5L,6L,6L,6L,4L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093093Inst : IEnumerable<long>
{
public static readonly long[] Value=A093093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093093.Bytes);
public long this[int i]=>Value[i];

public static A093093Inst Instance=new A093093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093094
{
public static readonly long[] Value={ 2L,2L,4L,8L,3L,2L,2L,4L,6L,4L,8L,2L,4L,2L,4L,3L,2L,1L,6L,8L,8L,8L,1L,2L,6L,2L,6L,4L,8L,6L,4L,6L,4L,8L,2L,1L,2L,1L,2L,1L,2L,2L,4L,3L,2L,4L,8L,2L,4L,2L,4L,2L,4L,3L,2L,1L,6L,2L,2L,2L,2L,2L,2L,4L,8L,1L,2L,6L,8L,3L,2L,1L,6L,8L,8L,8L,8L,8L,1L,2L,6L,2L,6L,1L,2L,4L,4L,4L,4L,4L,8L,3L,2L,8L,2L,1L,2L,4L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093094Inst : IEnumerable<long>
{
public static readonly long[] Value=A093094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093094.Bytes);
public long this[int i]=>Value[i];

public static A093094Inst Instance=new A093094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093095
{
public static readonly long[] Value={ 2L,3L,6L,1L,8L,6L,8L,4L,8L,4L,8L,3L,2L,3L,2L,3L,2L,3L,2L,2L,4L,6L,6L,6L,6L,6L,6L,6L,4L,8L,2L,4L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,2L,4L,3L,2L,1L,6L,8L,1L,2L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,2L,8L,1L,2L,6L,2L,6L,4L,8L,8L,2L,2L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093095Inst : IEnumerable<long>
{
public static readonly long[] Value=A093095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093095.Bytes);
public long this[int i]=>Value[i];

public static A093095Inst Instance=new A093095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093096
{
public static readonly long[] Value={ 3L,3L,9L,2L,7L,1L,8L,1L,4L,7L,8L,8L,4L,2L,8L,5L,6L,6L,4L,3L,2L,8L,1L,6L,4L,0L,3L,0L,3L,6L,2L,4L,1L,2L,6L,1L,6L,8L,6L,2L,4L,0L,0L,0L,0L,1L,8L,1L,2L,8L,4L,2L,1L,2L,6L,6L,4L,8L,4L,8L,1L,2L,8L,0L,0L,0L,0L,0L,8L,8L,2L,1L,6L,3L,2L,8L,2L,2L,1L,2L,3L,6L,2L,4L,3L,2L,3L,2L,3L,2L,8L,2L,1L,6L,0L,0L,0L,0L,0L,0L,6L,4L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093096Inst : IEnumerable<long>
{
public static readonly long[] Value=A093096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093096.Bytes);
public long this[int i]=>Value[i];

public static A093096Inst Instance=new A093096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093097
{
public static readonly long[] Value={ 3L,7L,2L,1L,1L,4L,2L,1L,4L,8L,2L,4L,3L,2L,1L,6L,8L,1L,2L,6L,2L,6L,4L,8L,8L,2L,1L,2L,1L,2L,1L,2L,2L,4L,3L,2L,6L,4L,1L,6L,2L,2L,2L,2L,2L,2L,4L,8L,1L,2L,6L,1L,2L,2L,4L,4L,6L,1L,2L,4L,4L,4L,4L,4L,8L,3L,2L,8L,2L,1L,2L,6L,2L,4L,8L,1L,6L,2L,4L,6L,2L,8L,1L,6L,1L,6L,1L,6L,1L,6L,3L,2L,2L,4L,6L,1L,6L,1L,6L,2L,2L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093097Inst : IEnumerable<long>
{
public static readonly long[] Value=A093097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093097.Bytes);
public long this[int i]=>Value[i];

public static A093097Inst Instance=new A093097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093098
{
public static readonly long[] Value={ 2L,3L,8L,6L,5L,6L,1L,2L,6L,2L,1L,4L,4L,7L,7L,7L,6L,1L,5L,6L,2L,5L,6L,1L,6L,4L,3L,6L,2L,1L,2L,5L,6L,1L,6L,3L,8L,4L,8L,2L,3L,5L,4L,3L,8L,2L,3L,5L,4L,3L,1L,1L,7L,6L,4L,9L,6L,1L,1L,5L,6L,2L,5L,3L,6L,3L,2L,1L,5L,6L,2L,5L,6L,1L,1L,2L,9L,6L,6L,4L,7L,2L,9L,3L,6L,2L,1L,3L,2L,1L,5L,6L,2L,5L,6L,1L,2L,1L,6L,6L,5L,6L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093098Inst : IEnumerable<long>
{
public static readonly long[] Value=A093098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093098.Bytes);
public long this[int i]=>Value[i];

public static A093098Inst Instance=new A093098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093099
{
public static readonly long[] Value={ 11L,12L,23L,35L,58L,813L,139L,394L,9412L,41213L,12135L,21353L,13533L,35334L,53348L,33488L,34886L,48867L,886712L,8671216L,67121614L,712161413L,121614138L,216141383L,161413833L,614138337L,141383377L,413833775L,138337755L,383377554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093099Inst : IEnumerable<long>
{
public static readonly long[] Value=A093099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093099.Bytes);
public long this[int i]=>Value[i];

public static A093099Inst Instance=new A093099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093100
{
public static readonly long[] Value={ 13L,34L,47L,711L,118L,182L,829L,2910L,91011L,101110L,11101L,11012L,10122L,1221L,2213L,2134L,1343L,3434L,4347L,3477L,4777L,77711L,771114L,7111414L,1114148L,1141482L,1414822L,4148225L,1482255L,4822555L,82255512L,225551210L,255512104L,555121047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093100Inst : IEnumerable<long>
{
public static readonly long[] Value=A093100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093100.Bytes);
public long this[int i]=>Value[i];

public static A093100Inst Instance=new A093100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093101
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,20L,1L,10L,1L,8L,5L,2L,5L,4L,1L,130L,1L,4000L,1L,2L,5L,52L,5L,494L,1L,40L,1L,10L,13L,4L,25L,38L,5L,16L,13L,230L,13L,20L,1L,46L,5L,104L,475L,62L,1L,20L,1L,130L,31L,832L,2755L,74L,5L,4L,13L,50L,1L,40L,23L,2L,2795L,76L,34385L,2L,1L,80L,1L,650L,1L,2812L,5L,74L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093101Inst : IEnumerable<long>
{
public static readonly long[] Value=A093101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093101.Bytes);
public long this[int i]=>Value[i];

public static A093101Inst Instance=new A093101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093102
{
public static readonly long[] Value={ 1L,4L,7L,41L,42L,43L,47L,49L,51L,52L,53L,57L,59L,61L,62L,63L,67L,69L,414L,741L,4141L,4142L,4143L,4147L,4149L,4151L,4152L,4153L,4157L,4159L,4161L,4162L,4163L,4167L,4169L,4241L,4242L,4243L,4247L,4249L,4251L,4252L,4253L,4257L,4259L,4261L,4262L,4263L,4267L,4269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093102Inst : IEnumerable<long>
{
public static readonly long[] Value=A093102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093102.Bytes);
public long this[int i]=>Value[i];

public static A093102Inst Instance=new A093102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093103
{
public static readonly long[] Value={ 1L,8L,85L,848L,8569L,86360L,870829L,8780192L,88528945L,892615592L,9000032581L,90745188080L,914962188841L,9225346460408L,93016977648925L,937868096859968L,9456301305507169L,95345640478116680L,961347451240583989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093103Inst : IEnumerable<long>
{
public static readonly long[] Value=A093103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093103.Bytes);
public long this[int i]=>Value[i];

public static A093103Inst Instance=new A093103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093104
{
public static readonly long[] Value={ 1L,8L,41L,84L,90L,410L,418L,420L,428L,430L,438L,470L,478L,490L,498L,510L,518L,520L,528L,530L,538L,570L,578L,590L,598L,610L,618L,620L,628L,630L,638L,670L,678L,690L,698L,4104L,4105L,4106L,4184L,4185L,4186L,4204L,4205L,4206L,4284L,4285L,4286L,4304L,4305L,4306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093104Inst : IEnumerable<long>
{
public static readonly long[] Value=A093104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093104.Bytes);
public long this[int i]=>Value[i];

public static A093104Inst Instance=new A093104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093105
{
public static readonly long[] Value={ 0L,4L,7L,8L,41L,84L,90L,410L,418L,420L,428L,430L,438L,470L,478L,490L,498L,510L,518L,520L,528L,530L,538L,570L,578L,590L,598L,610L,618L,620L,628L,630L,638L,670L,678L,690L,698L,4104L,4105L,4106L,4184L,4185L,4186L,4204L,4205L,4206L,4284L,4285L,4286L,4304L,4305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093105Inst : IEnumerable<long>
{
public static readonly long[] Value=A093105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093105.Bytes);
public long this[int i]=>Value[i];

public static A093105Inst Instance=new A093105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093106
{
public static readonly long[] Value={ 6L,18L,20L,21L,54L,100L,110L,136L,147L,155L,156L,162L,253L,342L,486L,500L,602L,657L,812L,820L,889L,979L,1029L,1081L,1210L,1332L,1458L,2028L,2265L,2312L,2485L,2500L,2756L,3081L,3164L,3422L,3660L,3924L,4112L,4374L,4422L,4656L,4805L,5253L,5784L,5819L,6498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093106Inst : IEnumerable<long>
{
public static readonly long[] Value=A093106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093106.Bytes);
public long this[int i]=>Value[i];

public static A093106Inst Instance=new A093106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093107
{
public static readonly long[] Value={ 2L,4L,8L,16L,20L,32L,39L,42L,55L,64L,100L,128L,253L,256L,272L,294L,328L,342L,500L,507L,512L,605L,610L,666L,812L,876L,930L,1024L,1081L,1474L,1711L,1806L,2048L,2058L,2485L,2500L,2756L,2943L,3088L,3403L,3502L,4096L,4624L,4656L,5671L,5819L,6162L,6498L,6591L,6655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093107Inst : IEnumerable<long>
{
public static readonly long[] Value=A093107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093107.Bytes);
public long this[int i]=>Value[i];

public static A093107Inst Instance=new A093107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093108
{
public static readonly long[] Value={ 3L,9L,10L,21L,27L,50L,55L,68L,78L,81L,147L,155L,171L,243L,250L,253L,301L,406L,410L,605L,657L,666L,729L,889L,979L,1014L,1029L,1081L,1156L,1250L,1378L,1582L,1711L,1830L,1962L,2056L,2187L,2211L,2265L,2328L,2485L,2892L,3081L,3249L,3403L,4082L,4658L,4805L,4965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093108Inst : IEnumerable<long>
{
public static readonly long[] Value=A093108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093108.Bytes);
public long this[int i]=>Value[i];

public static A093108Inst Instance=new A093108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093109
{
public static readonly long[] Value={ 2L,4L,6L,8L,16L,18L,32L,42L,52L,54L,55L,64L,93L,128L,162L,171L,256L,272L,294L,355L,406L,486L,506L,512L,605L,676L,820L,1024L,1332L,1458L,1474L,1711L,1806L,1830L,2048L,2058L,2162L,2504L,2525L,2715L,2756L,2883L,2943L,3081L,3249L,3629L,3916L,4096L,4374L,4624L,5210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093109Inst : IEnumerable<long>
{
public static readonly long[] Value=A093109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093109.Bytes);
public long this[int i]=>Value[i];

public static A093109Inst Instance=new A093109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093110
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,9L,12L,13L,14L,15L,17L,18L,21L,26L,27L,30L,32L,33L,34L,36L,37L,39L,40L,45L,46L,49L,58L,64L,65L,68L,71L,72L,73L,75L,76L,77L,79L,84L,85L,88L,96L,97L,103L,104L,107L,116L,124L,125L,126L,128L,129L,132L,135L,137L,138L,141L,142L,143L,146L,150L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093110Inst : IEnumerable<long>
{
public static readonly long[] Value=A093110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093110.Bytes);
public long this[int i]=>Value[i];

public static A093110Inst Instance=new A093110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093111
{
public static readonly long[] Value={ 0L,1L,4L,10L,19L,33L,49L,75L,110L,146L,181L,256L,312L,414L,486L,594L,710L,838L,948L,1184L,1300L,1522L,1758L,2042L,2279L,2546L,2754L,3148L,3411L,3856L,4179L,4611L,5043L,5560L,6213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093111Inst : IEnumerable<long>
{
public static readonly long[] Value=A093111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093111.Bytes);
public long this[int i]=>Value[i];

public static A093111Inst Instance=new A093111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093112
{
public static readonly long[] Value={ -1L,7L,47L,223L,959L,3967L,16127L,65023L,261119L,1046527L,4190207L,16769023L,67092479L,268402687L,1073676287L,4294836223L,17179607039L,68718952447L,274876858367L,1099509530623L,4398042316799L,17592177655807L,70368727400447L,281474943156223L,1125899839733759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093112Inst : IEnumerable<long>
{
public static readonly long[] Value=A093112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093112.Bytes);
public long this[int i]=>Value[i];

public static A093112Inst Instance=new A093112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093113
{
public static readonly long[] Value={ 1L,2L,6L,16L,62L,192L,652L,2048L,9270L,31744L,116948L,393216L,1533868L,5341184L,19445016L,67108864L,332958758L,1215037440L,4711687300L,16642998272L,67697833092L,245257732096L,923984441000L,3298534883328L,13952454631996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093113Inst : IEnumerable<long>
{
public static readonly long[] Value=A093113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093113.Bytes);
public long this[int i]=>Value[i];

public static A093113Inst Instance=new A093113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093114
{
public static readonly long[] Value={ 1L,-2L,-2L,-16L,14L,64L,-484L,-2048L,3798L,-7168L,96292L,131072L,-1247476L,3964928L,-27170632L,-67108864L,220816742L,-497811456L,993377620L,-3758096384L,38457826404L,-201938960384L,1217833409416L,1099511627776L,-4275253627140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093114Inst : IEnumerable<long>
{
public static readonly long[] Value=A093114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093114.Bytes);
public long this[int i]=>Value[i];

public static A093114Inst Instance=new A093114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093115
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,7L,10L,13L,17L,108L,159L,228L,317L,430L,572L,748L,5753L,8125L,11266L,15376L,20672L,27430L,35942L,46575L,59717L,523905L,708028L,946875L,1253880L,1645224L,2140099L,2761318L,3535658L,4494602L,5674753L,7118724L,69766770L,90940578L,117756370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093115Inst : IEnumerable<long>
{
public static readonly long[] Value=A093115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093115.Bytes);
public long this[int i]=>Value[i];

public static A093115Inst Instance=new A093115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093116
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,1L,2L,5L,4L,4L,5L,9L,15L,23L,24L,13L,20L,32L,55L,84L,113L,185L,303L,545L,167L,298L,435L,716L,1055L,1701L,2584L,4213L,6471L,10218L,15884L,4856L,7376L,11231L,17221L,26054L,39583L,60109L,91622L,138569L,209951L,318368L,483098L,730183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093116Inst : IEnumerable<long>
{
public static readonly long[] Value=A093116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093116.Bytes);
public long this[int i]=>Value[i];

public static A093116Inst Instance=new A093116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093117
{
public static readonly long[] Value={ 1L,15L,141L,1443L,14505L,146343L,1475349L,14875995L,149990289L,1512318207L,15248341725L,153745416147L,1550178505401L,15630081782295L,157594402871781L,1588986940402443L,16021377983526945L,161539749616666863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093117Inst : IEnumerable<long>
{
public static readonly long[] Value=A093117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093117.Bytes);
public long this[int i]=>Value[i];

public static A093117Inst Instance=new A093117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093118
{
public static readonly long[] Value={ 5L,13L,68L,25L,222L,1110L,41L,555L,3951L,19010L,61L,1171L,11263L,70438L,329126L,85L,2198L,27468L,216618L,1245986L,5693968L,113L,3788L,59676L,579330L,4022546L,21832492L,98074332L,145L,6117L,118605L,1389927L,11462495L,72887139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093118Inst : IEnumerable<long>
{
public static readonly long[] Value=A093118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093118.Bytes);
public long this[int i]=>Value[i];

public static A093118Inst Instance=new A093118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093119
{
public static readonly long[] Value={ 13L,68L,222L,555L,1171L,2198L,3788L,6117L,9385L,13816L,19658L,27183L,36687L,48490L,62936L,80393L,101253L,125932L,154870L,188531L,227403L,271998L,322852L,380525L,445601L,518688L,600418L,691447L,792455L,904146L,1027248L,1162513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093119Inst : IEnumerable<long>
{
public static readonly long[] Value=A093119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093119.Bytes);
public long this[int i]=>Value[i];

public static A093119Inst Instance=new A093119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093120
{
public static readonly ulong[] Value={ 5L,68L,1110L,19010L,329126L,5693968L,98074332L,1680306750L,28638104550L,485731377560L,8202665891316L,137983709713668L,2313146752430780L,38658742468243520L,644327268137066104L,10712855104602481206UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093120Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A093120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093120.Bytes);
public ulong this[int i]=>Value[i];

public static A093120Inst Instance=new A093120Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093121
{
public static readonly long[] Value={ 1L,0L,4L,6L,30L,80L,286L,882L,2924L,9350L,30438L,98208L,318278L,1029210L,3331820L,10780014L,34888062L,112894960L,365344142L,1182264930L,3825911596L,12380874550L,40065409014L,129654294336L,419570260150L,1357757640330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093121Inst : IEnumerable<long>
{
public static readonly long[] Value=A093121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093121.Bytes);
public long this[int i]=>Value[i];

public static A093121Inst Instance=new A093121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093122
{
public static readonly long[] Value={ 0L,1L,2L,9L,25L,88L,273L,903L,2890L,9405L,30349L,98352L,318045L,1029587L,3331210L,10781001L,34886465L,112897544L,365339961L,1182271695L,3825900650L,12380892261L,40065380357L,129654340704L,419570185125L,1357757761723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093122Inst : IEnumerable<long>
{
public static readonly long[] Value=A093122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093122.Bytes);
public long this[int i]=>Value[i];

public static A093122Inst Instance=new A093122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093123
{
public static readonly long[] Value={ 1L,4L,20L,120L,800L,5600L,40000L,288000L,2080000L,15040000L,108800000L,787200000L,5696000000L,41216000000L,298240000000L,2158080000000L,15616000000000L,112998400000000L,817664000000000L,5916672000000000L,42813440000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093123Inst : IEnumerable<long>
{
public static readonly long[] Value=A093123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093123.Bytes);
public long this[int i]=>Value[i];

public static A093123Inst Instance=new A093123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093140
{
public static readonly long[] Value={ 1L,5L,45L,445L,4445L,44445L,444445L,4444445L,44444445L,444444445L,4444444445L,44444444445L,444444444445L,4444444444445L,44444444444445L,444444444444445L,4444444444444445L,44444444444444445L,444444444444444445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093140Inst : IEnumerable<long>
{
public static readonly long[] Value=A093140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093140.Bytes);
public long this[int i]=>Value[i];

public static A093140Inst Instance=new A093140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093141
{
public static readonly long[] Value={ 1L,4L,40L,400L,4000L,40000L,400000L,4000000L,40000000L,400000000L,4000000000L,40000000000L,400000000000L,4000000000000L,40000000000000L,400000000000000L,4000000000000000L,40000000000000000L,400000000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093141Inst : IEnumerable<long>
{
public static readonly long[] Value=A093141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093141.Bytes);
public long this[int i]=>Value[i];

public static A093141Inst Instance=new A093141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093142
{
public static readonly long[] Value={ 1L,6L,56L,556L,5556L,55556L,555556L,5555556L,55555556L,555555556L,5555555556L,55555555556L,555555555556L,5555555555556L,55555555555556L,555555555555556L,5555555555555556L,55555555555555556L,555555555555555556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093142Inst : IEnumerable<long>
{
public static readonly long[] Value=A093142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093142.Bytes);
public long this[int i]=>Value[i];

public static A093142Inst Instance=new A093142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093143
{
public static readonly long[] Value={ 1L,5L,50L,500L,5000L,50000L,500000L,5000000L,50000000L,500000000L,5000000000L,50000000000L,500000000000L,5000000000000L,50000000000000L,500000000000000L,5000000000000000L,50000000000000000L,500000000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093143Inst : IEnumerable<long>
{
public static readonly long[] Value=A093143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093143.Bytes);
public long this[int i]=>Value[i];

public static A093143Inst Instance=new A093143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093144
{
public static readonly long[] Value={ 0L,1L,20L,350L,6000L,102500L,1750000L,29875000L,510000000L,8706250000L,148625000000L,2537187500000L,43312500000000L,739390625000000L,12622187500000000L,215474218750000000L,3678375000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093144Inst : IEnumerable<long>
{
public static readonly long[] Value=A093144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093144.Bytes);
public long this[int i]=>Value[i];

public static A093144Inst Instance=new A093144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093145
{
public static readonly long[] Value={ 0L,1L,10L,80L,600L,4400L,32000L,232000L,1680000L,12160000L,88000000L,636800000L,4608000000L,33344000000L,241280000000L,1745920000000L,12633600000000L,91417600000000L,661504000000000L,4786688000000000L,34636800000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093145Inst : IEnumerable<long>
{
public static readonly long[] Value=A093145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093145.Bytes);
public long this[int i]=>Value[i];

public static A093145Inst Instance=new A093145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093146
{
public static readonly long[] Value={ 1L,5L,50L,750L,12500L,212500L,3625000L,61875000L,1056250000L,18031250000L,307812500000L,5254687500000L,89703125000000L,1531328125000000L,26141406250000000L,446261718750000000L,7618164062500000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093146Inst : IEnumerable<long>
{
public static readonly long[] Value=A093146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093146.Bytes);
public long this[int i]=>Value[i];

public static A093146Inst Instance=new A093146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093147
{
public static readonly BigInteger[] Value={ 1L,15L,250L,4250L,72500L,1237500L,21125000L,360625000L,6156250000L,105093750000L,1794062500000L,30626562500000L,522828125000000L,8925234375000000L,152363281250000000L,2601003906250000000L,BigInteger.Parse("44401914062500000000") };
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
public class A093147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093147Inst Instance=new A093147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093148
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093148Inst : IEnumerable<long>
{
public static readonly long[] Value=A093148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093148.Bytes);
public long this[int i]=>Value[i];

public static A093148Inst Instance=new A093148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093149
{
public static readonly BigInteger[] Value={ 4L,9L,42L,343L,3908L,55989L,960802L,19173963L,435848052L,11111111113L,313842837674L,9726655034463L,328114698808276L,11966776581370173L,469172025408063618L,BigInteger.Parse("19676527011956855059"),BigInteger.Parse("878942778254232811940"),BigInteger.Parse("41660902667961039785745"),BigInteger.Parse("2088331858752553232964202") };
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
public class A093149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093149.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093149Inst Instance=new A093149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093150
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,4L,3L,2L,1L,0L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093150Inst : IEnumerable<long>
{
public static readonly long[] Value=A093150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093150.Bytes);
public long this[int i]=>Value[i];

public static A093150Inst Instance=new A093150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093151
{
public static readonly BigInteger[] Value={ 1L,13L,169L,1890L,20216L,210824L,2167819L,22119495L,224576508L,2272476724L,22940979719L,231196075659L,2326967290816L,23397529216327L,235077715264515L,2360380831212204L,23688221424314913L,237630022857420415L,2382971166402199310L,BigInteger.Parse("23889590198849417292") };
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
public class A093151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093151.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093151Inst Instance=new A093151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093152
{
public static readonly BigInteger[] Value={ 0L,12L,163L,1881L,20192L,210678L,2167602L,22119050L,224575958L,2272470765L,22940965468L,231196012323L,2326967172345L,23397529032871L,235077714312816L,2360380827753871L,23688221418030854L,237630022854838725L,2382971166321456083L,BigInteger.Parse("23889590198589663868") };
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
public class A093152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093152Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093152.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093152Inst Instance=new A093152Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093153
{
public static readonly long[] Value={ 0L,1L,6L,9L,24L,146L,217L,445L,550L,5959L,14251L,63336L,118471L,183456L,951699L,3458333L,6284059L,2581690L,80743227L,259753424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093153Inst : IEnumerable<long>
{
public static readonly long[] Value=A093153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093153.Bytes);
public long this[int i]=>Value[i];

public static A093153Inst Instance=new A093153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093154
{
public static readonly BigInteger[] Value={ 5L,193L,23041L,92897281L,980995276801L,BigInteger.Parse("23310331287699456001"),BigInteger.Parse("31888533201572855808001"),BigInteger.Parse("13532215908553332190020108288000001"),BigInteger.Parse("8829205774994708066835865418197893120000001"),BigInteger.Parse("945837910352576904120619801361499836578686566400000001") };
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
public class A093154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093154.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093154Inst Instance=new A093154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093155
{
public static readonly long[] Value={ 3L,23L,191L,23039L,322559L,5160959L,40874803199L,25505877196799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093155Inst : IEnumerable<long>
{
public static readonly long[] Value=A093155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093155.Bytes);
public long this[int i]=>Value[i];

public static A093155Inst Instance=new A093155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093156
{
public static readonly long[] Value={ 1L,2L,4L,9L,24L,63L,177L,514L,1527L,4625L,14230L,44358L,139779L,444558L,1425151L,4600339L,14939849L,48778197L,160019885L,527200711L,1743607826L,5786756470L,19266336882L,64331275266L,215377539119L,722840378042L,2431459847364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093156Inst : IEnumerable<long>
{
public static readonly long[] Value=A093156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093156.Bytes);
public long this[int i]=>Value[i];

public static A093156Inst Instance=new A093156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093157
{
public static readonly long[] Value={ 5L,8L,1L,9L,3L,2L,7L,0L,5L,6L,0L,8L,5L,9L,2L,1L,9L,0L,1L,2L,0L,9L,3L,3L,6L,9L,7L,3L,0L,9L,8L,9L,3L,9L,4L,7L,8L,8L,8L,9L,2L,2L,7L,3L,4L,9L,4L,8L,4L,2L,5L,0L,9L,7L,4L,7L,2L,6L,4L,9L,6L,7L,8L,0L,3L,2L,8L,9L,0L,0L,9L,3L,7L,6L,6L,8L,2L,2L,4L,7L,6L,1L,7L,5L,8L,9L,0L,4L,2L,3L,5L,2L,1L,0L,4L,5L,3L,8L,3L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093157Inst : IEnumerable<long>
{
public static readonly long[] Value=A093157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093157.Bytes);
public long this[int i]=>Value[i];

public static A093157Inst Instance=new A093157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093158
{
public static readonly long[] Value={ 1L,11L,1L,137L,1L,363L,761L,7129L,61L,83711L,509L,1145993L,1171733L,1195757L,8431L,42142223L,39541L,275295799L,11167027L,18858053L,36093L,444316699L,269564591L,34052522467L,34395742267L,312536252003L,375035183L,9227046511387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093158Inst : IEnumerable<long>
{
public static readonly long[] Value=A093158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093158.Bytes);
public long this[int i]=>Value[i];

public static A093158Inst Instance=new A093158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093159
{
public static readonly long[] Value={ 1L,144L,96L,72000L,2400L,3512320L,27095040L,870912000L,24192000L,103038566400L,1873428480L,12223042191360L,35258775552000L,99189522432000L,1889324236800L,25062074933575680L,61426654248960L,1101504369917952000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093159Inst : IEnumerable<long>
{
public static readonly long[] Value=A093159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093159.Bytes);
public long this[int i]=>Value[i];

public static A093159Inst Instance=new A093159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093160
{
public static readonly long[] Value={ 1L,4L,14L,40L,101L,236L,518L,1080L,2162L,4180L,7840L,14328L,25591L,44776L,76918L,129952L,216240L,354864L,574958L,920600L,1457946L,2285452L,3548550L,5460592L,8332425L,12614088L,18953310L,28276968L,41904208L,61702876L,90304598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093160Inst : IEnumerable<long>
{
public static readonly long[] Value=A093160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093160.Bytes);
public long this[int i]=>Value[i];

public static A093160Inst Instance=new A093160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093161
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,36L,38L,42L,48L,52L,54L,58L,60L,66L,68L,72L,78L,80L,84L,88L,90L,94L,96L,98L,102L,108L,114L,118L,120L,122L,124L,126L,128L,138L,146L,148L,150L,158L,164L,174L,180L,188L,190L,192L,206L,208L,210L,212L,218L,220L,222L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093161Inst : IEnumerable<long>
{
public static readonly long[] Value=A093161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093161.Bytes);
public long this[int i]=>Value[i];

public static A093161Inst Instance=new A093161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093162
{
public static readonly BigInteger[] Value={ 3L,23L,223L,22222223L,22222222223L,BigInteger.Parse("222222222222222222222222222222222223") };
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
public class A093162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093162Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093162.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093162Inst Instance=new A093162Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093163
{
public static readonly BigInteger[] Value={ 3L,43L,443L,444443L,444444443L,444444444443L,BigInteger.Parse("444444444444444444444444444443"),BigInteger.Parse("44444444444444444444444444444443") };
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
public class A093163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093163Inst Instance=new A093163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093164
{
public static readonly BigInteger[] Value={ 3L,53L,55555553L,BigInteger.Parse("55555555555555555555555553"),BigInteger.Parse("555555555555555555555555555555555555555555555555555555555555555553"),BigInteger.Parse("55555555555555555555555555555555555555555555555555555555555555555555555553") };
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
public class A093164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093164Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093164.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093164.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093164Inst Instance=new A093164Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093165
{
public static readonly BigInteger[] Value={ 3L,73L,773L,77773L,777777773L,777777777773L,777777777777773L,BigInteger.Parse("777777777777777777773") };
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
public class A093165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093165Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093165.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093165Inst Instance=new A093165Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093166
{
public static readonly BigInteger[] Value={ 3L,83L,883L,88883L,88888883L,888888883L,888888888888883L,BigInteger.Parse("888888888888888888888888888888888888888888888888883"),BigInteger.Parse("88888888888888888888888888888888888888888888888888888888888888888888883") };
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
public class A093166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093166Inst Instance=new A093166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093167
{
public static readonly BigInteger[] Value={ 7L,227L,222222227L,222222222222227L,BigInteger.Parse("2222222222222222222222222227"),BigInteger.Parse("2222222222222222222222222222222222222222222222222222222222222227") };
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
public class A093167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093167Inst Instance=new A093167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093168
{
public static readonly BigInteger[] Value={ 7L,37L,337L,333337L,BigInteger.Parse("3333333333333333333333333333333333333333333337") };
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
public class A093168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093168Inst Instance=new A093168Inst();

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