using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A119941
{
public static readonly long[] Value={ 5L,27L,756L,800L,40500L,165375L,1509200L,1524096L,185749200L,186763500L,31696434000L,31802284800L,31887679824L,127830277575L,37009908936000L,37066020992000L,13397976612820800L,13412613057860016L,13425208791508800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119941Inst : IEnumerable<long>
{
public static readonly long[] Value=A119941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119941.Bytes);
public long this[int i]=>Value[i];

public static A119941Inst Instance=new A119941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119942
{
public static readonly long[] Value={ 7L,256L,300L,16000L,67375L,627200L,642096L,79027200L,80041500L,13660416000L,13766266800L,13851661824L,55686205575L,16160272128000L,16216384184000L,5871257725132800L,5885894170172016L,5898489903820800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119942Inst : IEnumerable<long>
{
public static readonly long[] Value=A119942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119942.Bytes);
public long this[int i]=>Value[i];

public static A119942Inst Instance=new A119942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119943
{
public static readonly long[] Value={ 81L,125L,7425L,33075L,318500L,333396L,41674500L,42688800L,7347809700L,7453660500L,7539055524L,30435780375L,8862899245200L,8919011301200L,3236906114442000L,3251542559481216L,3264138293130000L,3275055780469200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119943Inst : IEnumerable<long>
{
public static readonly long[] Value=A119943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119943.Bytes);
public long this[int i]=>Value[i];

public static A119943Inst Instance=new A119943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119944
{
public static readonly long[] Value={ 0L,1L,4L,6L,48L,0L,360L,420L,1680L,0L,25200L,0L,332640L,0L,0L,360360L,11531520L,0L,220540320L,0L,0L,0L,5121436320L,0L,21416915520L,0L,53542288800L,0L,2248776129600L,0L,69872686884000L,72201776446800L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119944Inst : IEnumerable<long>
{
public static readonly long[] Value=A119944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119944.Bytes);
public long this[int i]=>Value[i];

public static A119944Inst Instance=new A119944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119945
{
public static readonly long[] Value={ 59L,47L,63L,36L,54L,52L,54L,54L,32L,54L,53L,23L,87L,89L,107L,105L,107L,88L,85L,107L,106L,173L,208L,181L,199L,197L,199L,199L,177L,199L,90L,157L,192L,165L,183L,181L,183L,183L,161L,183L,96L,163L,198L,171L,189L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119945Inst : IEnumerable<long>
{
public static readonly long[] Value=A119945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119945.Bytes);
public long this[int i]=>Value[i];

public static A119945Inst Instance=new A119945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119946
{
public static readonly long[] Value={ 5L,2L,9L,9L,9L,7L,9L,9L,5L,9L,8L,5L,6L,8L,8L,6L,8L,7L,4L,8L,7L,2L,1L,1L,1L,8L,1L,1L,6L,1L,9L,4L,3L,3L,3L,1L,3L,3L,8L,3L,6L,1L,9L,9L,9L,7L,9L,9L,5L,9L,4L,8L,7L,7L,7L,5L,7L,7L,3L,7L,5L,9L,8L,8L,8L,6L,8L,8L,4L,8L,5L,9L,8L,8L,8L,6L,8L,8L,4L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119946Inst : IEnumerable<long>
{
public static readonly long[] Value=A119946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119946.Bytes);
public long this[int i]=>Value[i];

public static A119946Inst Instance=new A119946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119947
{
public static readonly long[] Value={ 1L,3L,1L,11L,5L,1L,25L,13L,7L,1L,137L,77L,47L,9L,1L,49L,29L,19L,37L,11L,1L,363L,223L,153L,319L,107L,13L,1L,761L,481L,341L,743L,533L,73L,15L,1L,7129L,4609L,3349L,2509L,1879L,275L,191L,17L,1L,7381L,4861L,3601L,2761L,2131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119947Inst : IEnumerable<long>
{
public static readonly long[] Value=A119947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119947.Bytes);
public long this[int i]=>Value[i];

public static A119947Inst Instance=new A119947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119948
{
public static readonly long[] Value={ 1L,4L,4L,18L,18L,9L,48L,48L,48L,16L,300L,300L,300L,100L,25L,120L,120L,120L,360L,180L,36L,980L,980L,980L,2940L,1470L,294L,49L,2240L,2240L,2240L,6720L,6720L,1344L,448L,64L,22680L,22680L,22680L,22680L,22680L,4536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119948Inst : IEnumerable<long>
{
public static readonly long[] Value=A119948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119948.Bytes);
public long this[int i]=>Value[i];

public static A119948Inst Instance=new A119948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119949
{
public static readonly long[] Value={ 1L,4L,17L,46L,271L,146L,1179L,2948L,19959L,23710L,278911L,296058L,4049539L,4547188L,3819427L,8113704L,142240297L,57945728L,1141687557L,811614110L,630796959L,989114644L,23941114969L,31470515448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119949Inst : IEnumerable<long>
{
public static readonly long[] Value=A119949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119949.Bytes);
public long this[int i]=>Value[i];

public static A119949Inst Instance=new A119949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119950
{
public static readonly long[] Value={ 1L,8L,45L,160L,1025L,936L,7693L,22016L,123201L,181000L,2190221L,2409408L,33932665L,43909880L,29887229L,68917248L,1244818081L,732937032L,14699459725L,17464448672L,14290498033L,26212519432L,630291945053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119950Inst : IEnumerable<long>
{
public static readonly long[] Value=A119950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119950.Bytes);
public long this[int i]=>Value[i];

public static A119950Inst Instance=new A119950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119951
{
public static readonly long[] Value={ 1L,3L,29L,65L,281L,595L,9949L,20613L,84883L,173965L,1421113L,2894229L,11762641L,23859587L,773201629L,1564082093L,6321150767L,12761711209L,102977321267L,207595672639L,836499257311L,1684433835077L,27122471168057L,54567418372945L,219485160092143L,441266239318305L,3547513302275441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119951Inst : IEnumerable<long>
{
public static readonly long[] Value=A119951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119951.Bytes);
public long this[int i]=>Value[i];

public static A119951Inst Instance=new A119951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119952
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,6L,9L,11L,13L,17L,22L,27L,32L,40L,51L,61L,72L,88L,108L,128L,150L,180L,217L,255L,297L,351L,416L,485L,562L,657L,770L,891L,1026L,1190L,1380L,1587L,1818L,2092L,2409L,2754L,3139L,3590L,4105L,4670L,5299L,6026L,6854L,7761L,8770L,9926L,11231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119952Inst : IEnumerable<long>
{
public static readonly long[] Value=A119952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119952.Bytes);
public long this[int i]=>Value[i];

public static A119952Inst Instance=new A119952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119953
{
public static readonly long[] Value={ 1L,1L,4L,2L,1L,6L,7L,4L,2L,6L,6L,1L,2L,4L,7L,1L,2L,4L,-1L,-3L,0L,4L,-1L,-11L,-6L,-1L,-5L,-13L,-10L,-4L,-10L,-14L,-10L,-9L,-13L,-17L,-12L,-11L,-19L,-18L,-13L,-15L,-19L,-18L,-15L,-18L,-23L,-19L,-15L,-18L,-25L,-23L,-18L,-22L,-30L,-25L,-20L,-27L,-34L,-30L,-24L,-30L,-39L,-35L,-26L,-33L,-44L,-39L,-31L,-35L,-46L,-42L,-34L,-39L,-47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119953Inst : IEnumerable<long>
{
public static readonly long[] Value=A119953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119953.Bytes);
public long this[int i]=>Value[i];

public static A119953Inst Instance=new A119953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119954
{
public static readonly long[] Value={ 3L,2L,-2L,9L,24L,33L,21L,-2L,-6L,18L,47L,30L,-13L,-20L,4L,-7L,-32L,-42L,-59L,-80L,-77L,-66L,-74L,-107L,-128L,-98L,-67L,-81L,-127L,-151L,-142L,-119L,-107L,-117L,-151L,-190L,-176L,-136L,-123L,-158L,-193L,-202L,-173L,-140L,-133L,-165L,-204L,-188L,-140L,-113L,-151L,-205L,-195L,-127L,-82L,-88L,-120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119954Inst : IEnumerable<long>
{
public static readonly long[] Value=A119954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119954.Bytes);
public long this[int i]=>Value[i];

public static A119954Inst Instance=new A119954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119955
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,10L,11L,12L,13L,14L,27L,49L,50L,51L,52L,53L,125L,126L,127L,128L,129L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,140L,141L,142L,143L,144L,145L,146L,147L,148L,149L,150L,151L,152L,153L,154L,155L,289L,290L,291L,292L,293L,841L,842L,843L,844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119955Inst : IEnumerable<long>
{
public static readonly long[] Value=A119955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119955.Bytes);
public long this[int i]=>Value[i];

public static A119955Inst Instance=new A119955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119956
{
public static readonly long[] Value={ 9L,10L,12L,13L,21L,25L,30L,34L,36L,40L,46L,52L,66L,76L,81L,90L,96L,118L,126L,130L,132L,142L,144L,154L,165L,172L,177L,180L,193L,196L,198L,204L,216L,226L,228L,238L,240L,246L,250L,256L,262L,268L,273L,282L,294L,312L,333L,336L,345L,346L,366L,370L,372L,378L,393L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119956Inst : IEnumerable<long>
{
public static readonly long[] Value=A119956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119956.Bytes);
public long this[int i]=>Value[i];

public static A119956Inst Instance=new A119956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119957
{
public static readonly long[] Value={ 0L,0L,3L,0L,10L,6L,7L,0L,27L,20L,55L,12L,78L,14L,15L,0L,68L,54L,171L,40L,42L,110L,92L,24L,250L,156L,243L,28L,406L,30L,31L,0L,165L,136L,175L,108L,666L,342L,156L,80L,410L,84L,301L,220L,225L,184L,423L,48L,490L,500L,102L,312L,1378L,486L,440L,56L,513L,812L,1711L,60L,1830L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119957Inst : IEnumerable<long>
{
public static readonly long[] Value=A119957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119957.Bytes);
public long this[int i]=>Value[i];

public static A119957Inst Instance=new A119957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119958
{
public static readonly BigInteger[] Value={ 3L,7L,147L,301L,33411L,1748509L,36718689L,4198170109L,709490748421L,82402282638039L,1345903949754637L,1564158644309443L,855594778437265321L,5136411178193150947L,BigInteger.Parse("3703352459477261832787"),BigInteger.Parse("261798531558431048025481") };
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
public class A119958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119958Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A119958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A119958.Bytes);
public BigInteger this[int i]=>Value[i];

public static A119958Inst Instance=new A119958Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119959
{
public static readonly long[] Value={ 3L,7L,21L,43L,111L,157L,273L,343L,507L,813L,931L,1333L,1641L,1807L,2163L,2757L,3423L,3661L,4423L,4971L,5257L,6163L,6807L,7833L,9313L,10101L,10507L,11343L,11773L,12657L,16003L,17031L,18633L,19183L,22053L,22651L,24493L,26407L,27723L,29757L,31863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119959Inst : IEnumerable<long>
{
public static readonly long[] Value=A119959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119959.Bytes);
public long this[int i]=>Value[i];

public static A119959Inst Instance=new A119959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119960
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,10L,15L,16L,24L,25L,29L,34L,35L,39L,40L,43L,47L,48L,50L,53L,57L,58L,60L,63L,67L,68L,70L,71L,72L,73L,76L,77L,78L,84L,85L,89L,94L,95L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119960Inst : IEnumerable<long>
{
public static readonly long[] Value=A119960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119960.Bytes);
public long this[int i]=>Value[i];

public static A119960Inst Instance=new A119960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119961
{
public static readonly long[] Value={ 4L,6L,9L,10L,15L,21L,22L,25L,34L,38L,39L,46L,49L,51L,55L,57L,58L,65L,69L,87L,91L,93L,94L,106L,111L,115L,119L,121L,123L,133L,141L,142L,146L,159L,169L,177L,183L,202L,205L,213L,214L,218L,219L,226L,235L,237L,249L,253L,254L,259L,262L,265L,267L,274L,289L,291L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119961Inst : IEnumerable<long>
{
public static readonly long[] Value=A119961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119961.Bytes);
public long this[int i]=>Value[i];

public static A119961Inst Instance=new A119961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119962
{
public static readonly long[] Value={ 3L,7L,13L,31L,61L,127L,251L,509L,1021L,2039L,4093L,8191L,16381L,32749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119962Inst : IEnumerable<long>
{
public static readonly long[] Value=A119962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119962.Bytes);
public long this[int i]=>Value[i];

public static A119962Inst Instance=new A119962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119963
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,3L,2L,3L,1L,1L,1L,1L,3L,3L,3L,3L,1L,1L,1L,1L,4L,3L,6L,3L,4L,1L,1L,1L,1L,4L,4L,6L,6L,4L,4L,1L,1L,1L,1L,5L,4L,10L,6L,10L,4L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119963Inst : IEnumerable<long>
{
public static readonly long[] Value=A119963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119963.Bytes);
public long this[int i]=>Value[i];

public static A119963Inst Instance=new A119963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119964
{
public static readonly BigInteger[] Value={ 1L,5L,19L,779L,84911L,2632241L,713337311L,1163866139L,587752400195L,476667196558145L,2856927907113011L,345688276760674331L,13819099649042566549UL,BigInteger.Parse("4988694973304366524189"),BigInteger.Parse("10780569837310736058772429") };
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
public class A119964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A119964.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A119964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A119964Inst Instance=new A119964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119965
{
public static readonly long[] Value={ 1L,8L,42L,174L,705L,2764L,10772L,41967L,164793L,654242L,2634801L,10787937L,44983894L,191249703L,829651874L,3673967785L,16612478231L,76708135651L,361707435767L,1741601413569L,8561660600005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119965Inst : IEnumerable<long>
{
public static readonly long[] Value=A119965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119965.Bytes);
public long this[int i]=>Value[i];

public static A119965Inst Instance=new A119965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119966
{
public static readonly long[] Value={ 1L,2L,6L,28L,220L,2565L,45846L,1268622L,55336336L,3876385680L,443603651136L,84205632289664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119966Inst : IEnumerable<long>
{
public static readonly long[] Value=A119966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119966.Bytes);
public long this[int i]=>Value[i];

public static A119966Inst Instance=new A119966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119967
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,49L,113L,259L,595L,1376L,3202L,7479L,17499L,40986L,96116L,225755L,531115L,1251310L,2951556L,6968883L,16468775L,38951925L,92204241L,218426037L,517799861L,1228280392L,2915346934L,6923469409L,16450694861L,39107365561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119967Inst : IEnumerable<long>
{
public static readonly long[] Value=A119967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119967.Bytes);
public long this[int i]=>Value[i];

public static A119967Inst Instance=new A119967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119968
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,16L,27L,44L,73L,130L,251L,507L,1025L,2016L,3811L,6907L,12033L,20282L,33475L,55253L,94185L,171896L,342651L,737266L,1655657L,3751786L,8386587L,18274843L,38629505L,79123224L,157157411L,303174298L,569093601L,1041436386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119968Inst : IEnumerable<long>
{
public static readonly long[] Value=A119968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119968.Bytes);
public long this[int i]=>Value[i];

public static A119968Inst Instance=new A119968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119969
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,3L,3L,1L,0L,0L,0L,0L,1L,7L,21L,35L,35L,21L,7L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,15L,105L,455L,1365L,3003L,5005L,6435L,6435L,5005L,3003L,1365L,455L,105L,15L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,31L,465L,4495L,31465L,169911L,736281L,2629575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119969Inst : IEnumerable<long>
{
public static readonly long[] Value=A119969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119969.Bytes);
public long this[int i]=>Value[i];

public static A119969Inst Instance=new A119969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119970
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,21L,37L,67L,140L,341L,881L,2223L,5292L,11805L,24767L,49203L,93312L,170801L,307550L,564341L,1114531L,2493085L,6336892L,17433725L,49041291L,135933981L,364835251L,942294187L,2340123130L,5595955421L,12914346267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119970Inst : IEnumerable<long>
{
public static readonly long[] Value=A119970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119970.Bytes);
public long this[int i]=>Value[i];

public static A119970Inst Instance=new A119970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119971
{
public static readonly long[] Value={ 1L,0L,1L,3L,6L,10L,16L,30L,73L,201L,540L,1342L,3069L,6513L,12962L,24436L,44109L,77489L,136749L,256791L,550190L,1378554L,3843807L,11096833L,31607566L,86892690L,228901270L,577458936L,1397828943L,3255832291L,7318390846L,15919253376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119971Inst : IEnumerable<long>
{
public static readonly long[] Value=A119971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119971.Bytes);
public long this[int i]=>Value[i];

public static A119971Inst Instance=new A119971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119972
{
public static readonly long[] Value={ 1L,2L,-3L,4L,5L,-6L,-7L,8L,9L,10L,-11L,-12L,13L,-14L,-15L,16L,17L,18L,-19L,20L,21L,-22L,-23L,-24L,25L,26L,-27L,-28L,29L,-30L,-31L,32L,33L,34L,-35L,36L,37L,-38L,-39L,40L,41L,42L,-43L,-44L,45L,-46L,-47L,-48L,49L,50L,-51L,52L,53L,-54L,-55L,-56L,57L,58L,-59L,-60L,61L,-62L,-63L,64L,65L,66L,-67L,68L,69L,-70L,-71L,72L,73L,74L,-75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119972Inst : IEnumerable<long>
{
public static readonly long[] Value=A119972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119972.Bytes);
public long this[int i]=>Value[i];

public static A119972Inst Instance=new A119972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119973
{
public static readonly long[] Value={ 21L,33L,42L,57L,66L,69L,77L,84L,93L,105L,114L,129L,132L,133L,138L,141L,154L,161L,165L,168L,177L,186L,189L,201L,209L,210L,213L,217L,228L,237L,249L,253L,258L,264L,266L,273L,276L,282L,285L,297L,301L,308L,309L,321L,322L,329L,330L,336L,341L,345L,354L,357L,372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119973Inst : IEnumerable<long>
{
public static readonly long[] Value=A119973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119973.Bytes);
public long this[int i]=>Value[i];

public static A119973Inst Instance=new A119973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119974
{
public static readonly long[] Value={ 1L,2L,-3L,4L,0L,5L,0L,-6L,0L,-7L,8L,0L,0L,0L,9L,0L,0L,10L,0L,0L,-11L,0L,-12L,0L,0L,0L,0L,13L,0L,0L,0L,-14L,0L,0L,0L,-15L,16L,0L,0L,0L,0L,0L,0L,0L,17L,0L,0L,0L,0L,18L,0L,0L,0L,0L,-19L,0L,0L,20L,0L,0L,0L,0L,0L,0L,0L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119974Inst : IEnumerable<long>
{
public static readonly long[] Value=A119974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119974.Bytes);
public long this[int i]=>Value[i];

public static A119974Inst Instance=new A119974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119975
{
public static readonly long[] Value={ 1L,2L,7L,22L,77L,266L,947L,3382L,12217L,44338L,161855L,593110L,2181445L,8046650L,29759147L,110303798L,409655281L,1524056546L,5678827511L,21189499030L,79164147389L,296094973418L,1108623865123L,4154794910518L,15584520425641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119975Inst : IEnumerable<long>
{
public static readonly long[] Value=A119975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119975.Bytes);
public long this[int i]=>Value[i];

public static A119975Inst Instance=new A119975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119976
{
public static readonly long[] Value={ 1L,3L,12L,50L,216L,952L,4256L,19224L,87520L,400928L,1845888L,8533824L,39590656L,184216320L,859354112L,4017738112L,18820855296L,88317817344L,415075665920L,1953473141760L,9205135036416L,43425512132608L,205072796270592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119976Inst : IEnumerable<long>
{
public static readonly long[] Value=A119976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119976.Bytes);
public long this[int i]=>Value[i];

public static A119976Inst Instance=new A119976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119977
{
public static readonly long[] Value={ 3L,10L,36L,55L,66L,136L,153L,190L,253L,378L,496L,528L,820L,946L,1035L,1128L,1485L,3240L,3403L,3655L,4950L,5886L,6903L,7750L,8128L,8256L,9316L,10440L,12403L,13203L,13861L,14365L,14535L,15051L,15753L,16290L,17020L,17205L,17578L,18915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119977Inst : IEnumerable<long>
{
public static readonly long[] Value=A119977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119977.Bytes);
public long this[int i]=>Value[i];

public static A119977Inst Instance=new A119977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119978
{
public static readonly BigInteger[] Value={ 2L,12L,48L,2016L,221760L,6918912L,1881944064L,3079544832L,1558249684992L,1265298744213504L,7591792465281024L,919297051250393088L,BigInteger.Parse("36771882050015723520"),BigInteger.Parse("13282003796465679335424") };
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
public class A119978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119978Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A119978.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A119978.Bytes);
public BigInteger this[int i]=>Value[i];

public static A119978Inst Instance=new A119978Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119979
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,3L,2L,5L,6L,5L,11L,9L,6L,9L,3L,9L,3L,9L,19L,9L,9L,7L,14L,17L,23L,21L,9L,9L,20L,17L,5L,1L,3L,9L,23L,33L,15L,13L,3L,9L,21L,9L,40L,13L,3L,9L,43L,33L,30L,25L,3L,9L,36L,29L,18L,9L,57L,3L,9L,33L,54L,17L,33L,1L,3L,9L,44L,17L,42L,65L,21L,9L,2L,5L,33L,13L,31L,51L,68L,17L,15L,51L,56L,5L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119979Inst : IEnumerable<long>
{
public static readonly long[] Value=A119979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119979.Bytes);
public long this[int i]=>Value[i];

public static A119979Inst Instance=new A119979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119980
{
public static readonly long[] Value={ 1L,3L,6L,6L,11L,15L,52L,38L,51L,9L,360L,260L,35L,39L,364L,1932L,680L,532L,1122L,260L,2415L,3570L,168L,360L,71L,12285L,836L,12L,1680L,1155L,858L,936L,7956L,48300L,171120L,234L,4428L,235752L,712L,990L,119L,364182L,406L,11220L,412920L,25584L,476L,19998L,6486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119980Inst : IEnumerable<long>
{
public static readonly long[] Value=A119980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119980.Bytes);
public long this[int i]=>Value[i];

public static A119980Inst Instance=new A119980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119981
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119981Inst : IEnumerable<long>
{
public static readonly long[] Value=A119981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119981.Bytes);
public long this[int i]=>Value[i];

public static A119981Inst Instance=new A119981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119982
{
public static readonly long[] Value={ 132L,1930L,1936L,2440L,2678L,2746L,2990L,3710L,4234L,4760L,4810L,4888L,5676L,6774L,6974L,8482L,8836L,9230L,9456L,9842L,11218L,12394L,12640L,12868L,12894L,13414L,13660L,15938L,16012L,17944L,18226L,18956L,19040L,21088L,21198L,21424L,24546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119982Inst : IEnumerable<long>
{
public static readonly long[] Value=A119982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119982.Bytes);
public long this[int i]=>Value[i];

public static A119982Inst Instance=new A119982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119983
{
public static readonly long[] Value={ 1L,2L,4L,7L,13L,22L,36L,59L,107L,189L,244L,494L,594L,1063L,3276L,5508L,5804L,12427L,12916L,42411L,131773L,167588L,168842L,428013L,839368L,1015502L,1968162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119983Inst : IEnumerable<long>
{
public static readonly long[] Value=A119983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119983.Bytes);
public long this[int i]=>Value[i];

public static A119983Inst Instance=new A119983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119984
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,9L,10L,14L,15L,23L,32L,33L,72L,83L,84L,87L,97L,104L,105L,429L,637L,710L,1152L,1194L,1692L,2814L,3316L,3824L,3971L,5206L,8002L,10016L,12161L,13681L,18069L,33653L,36467L,48355L,48629L,49455L,73574L,82128L,99005L,123685L,135276L,146779L,210404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119984Inst : IEnumerable<long>
{
public static readonly long[] Value=A119984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119984.Bytes);
public long this[int i]=>Value[i];

public static A119984Inst Instance=new A119984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119985
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,3L,4L,1L,1L,2L,1L,1L,2L,2L,3L,4L,2L,3L,4L,3L,4L,6L,4L,6L,8L,1L,1L,2L,1L,1L,2L,2L,3L,4L,1L,1L,2L,1L,1L,2L,2L,3L,4L,2L,3L,4L,3L,4L,6L,4L,6L,8L,2L,3L,4L,3L,4L,6L,4L,6L,8L,3L,4L,6L,4L,6L,8L,6L,9L,12L,4L,6L,8L,6L,9L,12L,8L,12L,16L,1L,1L,2L,1L,1L,2L,2L,3L,4L,1L,1L,2L,1L,1L,2L,2L,3L,4L,2L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119985Inst : IEnumerable<long>
{
public static readonly long[] Value=A119985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119985.Bytes);
public long this[int i]=>Value[i];

public static A119985Inst Instance=new A119985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119986
{
public static readonly long[] Value={ 1L,6L,19L,5L,6L,17L,6L,6L,10L,2L,15L,17L,3L,9L,7L,48L,32L,12L,39L,9L,17L,18L,27L,1L,50L,36L,18L,3L,11L,44L,19L,45L,46L,78L,36L,36L,5L,20L,33L,41L,127L,42L,12L,63L,16L,33L,31L,42L,8L,6L,98L,57L,21L,47L,22L,91L,21L,45L,24L,1L,3L,12L,72L,57L,51L,129L,351L,8L,23L,87L,88L,108L,80L,120L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119986Inst : IEnumerable<long>
{
public static readonly long[] Value=A119986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119986.Bytes);
public long this[int i]=>Value[i];

public static A119986Inst Instance=new A119986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119987
{
public static readonly BigInteger[] Value={ 2L,3L,13L,3251L,16777729L,387421219L,11112006825560761L,BigInteger.Parse("443426488243037769948249630619149912487"),BigInteger.Parse("1075911801979993982060429252856123779115487368830416064665177") };
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
public class A119987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119987Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A119987.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A119987.Bytes);
public BigInteger this[int i]=>Value[i];

public static A119987Inst Instance=new A119987Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119988
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,11L,14L,15L,21L,22L,30L,33L,35L,42L,55L,59L,66L,70L,77L,105L,110L,118L,154L,165L,177L,210L,231L,295L,330L,354L,385L,413L,462L,509L,590L,649L,770L,826L,885L,1018L,1155L,1239L,1298L,1527L,1770L,1947L,2065L,2310L,2478L,2545L,3054L,3245L,3563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119988Inst : IEnumerable<long>
{
public static readonly long[] Value=A119988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119988.Bytes);
public long this[int i]=>Value[i];

public static A119988Inst Instance=new A119988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119989
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,3L,3L,5L,7L,5L,6L,11L,6L,4L,9L,11L,12L,8L,4L,11L,18L,9L,6L,21L,15L,8L,13L,14L,15L,17L,8L,16L,24L,7L,12L,36L,21L,8L,15L,20L,21L,19L,7L,22L,45L,14L,11L,32L,25L,14L,26L,33L,23L,10L,13L,35L,57L,14L,14L,60L,30L,15L,21L,24L,34L,33L,17L,25L,42L,21L,21L,72L,34L,14L,21L,26L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119989Inst : IEnumerable<long>
{
public static readonly long[] Value=A119989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119989.Bytes);
public long this[int i]=>Value[i];

public static A119989Inst Instance=new A119989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119990
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,32L,8L,72L,144L,288L,72L,648L,1296L,2592L,808L,5992L,6872L,18856L,37712L,75424L,150848L,301696L,598224L,1201616L,1201616L,3600312L,7199168L,14404328L,28808656L,57617312L,49885800L,164522200L,329642624L,659285248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119990Inst : IEnumerable<long>
{
public static readonly long[] Value=A119990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119990.Bytes);
public long this[int i]=>Value[i];

public static A119990Inst Instance=new A119990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119991
{
public static readonly long[] Value={ 1L,5L,5L,5L,11L,17L,15L,14L,17L,29L,27L,20L,27L,41L,18L,33L,25L,41L,71L,39L,34L,45L,33L,71L,51L,41L,67L,97L,63L,56L,63L,95L,38L,83L,55L,77L,109L,52L,89L,62L,83L,157L,87L,76L,89L,62L,155L,101L,76L,143L,151L,105L,98L,113L,71L,181L,141L,86L,119L,209L,81L,125L,97L,139L,241L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119991Inst : IEnumerable<long>
{
public static readonly long[] Value=A119991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119991.Bytes);
public long this[int i]=>Value[i];

public static A119991Inst Instance=new A119991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119992
{
public static readonly long[] Value={ 1L,3L,7L,11L,17L,19L,29L,31L,37L,41L,47L,53L,61L,67L,71L,73L,83L,89L,101L,103L,107L,109L,127L,131L,137L,139L,149L,151L,163L,167L,179L,181L,191L,193L,197L,199L,223L,227L,229L,233L,241L,251L,263L,269L,271L,277L,283L,293L,307L,311L,313L,317L,337L,347L,349L,353L,359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119992Inst : IEnumerable<long>
{
public static readonly long[] Value=A119992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119992.Bytes);
public long this[int i]=>Value[i];

public static A119992Inst Instance=new A119992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119993
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,19L,19L,23L,29L,37L,37L,43L,43L,53L,59L,59L,61L,71L,71L,79L,83L,89L,89L,101L,101L,107L,107L,113L,113L,137L,131L,137L,149L,151L,157L,163L,163L,173L,179L,181L,181L,197L,193L,199L,211L,223L,223L,229L,229L,239L,241L,251L,251L,263L,269L,271L,277L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119993Inst : IEnumerable<long>
{
public static readonly long[] Value=A119993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119993.Bytes);
public long this[int i]=>Value[i];

public static A119993Inst Instance=new A119993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119994
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,2L,3L,5L,1L,2L,3L,2L,3L,5L,3L,4L,7L,2L,3L,5L,3L,4L,7L,5L,6L,13L,1L,2L,3L,2L,3L,5L,3L,4L,7L,2L,3L,5L,3L,4L,7L,5L,6L,13L,3L,4L,7L,4L,5L,11L,7L,8L,19L,2L,3L,5L,3L,4L,7L,5L,6L,13L,3L,4L,7L,4L,5L,11L,7L,8L,19L,5L,6L,13L,6L,7L,17L,13L,14L,43L,1L,2L,3L,2L,3L,5L,3L,4L,7L,2L,3L,5L,3L,4L,7L,5L,6L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119994Inst : IEnumerable<long>
{
public static readonly long[] Value=A119994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119994.Bytes);
public long this[int i]=>Value[i];

public static A119994Inst Instance=new A119994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119995
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,4L,2L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,4L,2L,2L,3L,2L,1L,2L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119995Inst : IEnumerable<long>
{
public static readonly long[] Value=A119995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119995.Bytes);
public long this[int i]=>Value[i];

public static A119995Inst Instance=new A119995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119996
{
public static readonly long[] Value={ 1L,5L,14L,39L,103L,272L,713L,1869L,4894L,12815L,33551L,87840L,229969L,602069L,1576238L,4126647L,10803703L,28284464L,74049689L,193864605L,507544126L,1328767775L,3478759199L,9107509824L,23843770273L,62423800997L,163427632718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119996Inst : IEnumerable<long>
{
public static readonly long[] Value=A119996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119996.Bytes);
public long this[int i]=>Value[i];

public static A119996Inst Instance=new A119996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119997
{
public static readonly long[] Value={ 1L,1L,4L,5L,17L,32L,97L,225L,628L,1573L,4225L,10880L,28769L,74849L,196708L,513765L,1347025L,3523360L,9229441L,24154625L,63251156L,165571781L,433507969L,1134881280L,2971250497L,7778684737L,20365103812L,53316141125L,139584105233L,365434903328L,956722661665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119997Inst : IEnumerable<long>
{
public static readonly long[] Value=A119997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119997.Bytes);
public long this[int i]=>Value[i];

public static A119997Inst Instance=new A119997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119998
{
public static readonly long[] Value={ 1L,15L,149L,2357L,10541L,57735L,745356L,1490712L,182574186L,298142397L,298142397L,1490711985L,1490711985L,10540925533895L,74535599249993L,105409255338946L,7453559924999299L,14907119849998598L,471404520791031683L,7453559924999298988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119998Inst : IEnumerable<long>
{
public static readonly long[] Value=A119998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119998.Bytes);
public long this[int i]=>Value[i];

public static A119998Inst Instance=new A119998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A119999
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,8L,6L,5L,5L,4L,4L,4L,4L,2L,12L,2L,5L,8L,4L,6L,3L,5L,3L,2L,12L,7L,2L,4L,4L,8L,3L,3L,6L,2L,12L,12L,5L,2L,4L,5L,3L,8L,3L,2L,12L,7L,5L,4L,2L,3L,3L,3L,3L,2L,12L,12L,12L,7L,4L,2L,3L,4L,5L,2L,12L,7L,5L,4L,4L,3L,2L,3L,3L,2L,12L,12L,5L,12L,4L,5L,3L,2L,3L,2L,12L,7L,12L,4L,4L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A119999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A119999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A119999Inst : IEnumerable<long>
{
public static readonly long[] Value=A119999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A119999.Bytes);
public long this[int i]=>Value[i];

public static A119999Inst Instance=new A119999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120000
{
public static readonly long[] Value={ 1L,2L,8L,12L,298L,1230L,10494L,74543L,238174L,402385L,608924L,858896L,1150972L,1486709L,1864309L,2285798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120000Inst : IEnumerable<long>
{
public static readonly long[] Value=A120000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120000.Bytes);
public long this[int i]=>Value[i];

public static A120000Inst Instance=new A120000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120001
{
public static readonly long[] Value={ 0L,10L,12L,21L,102L,112L,123L,213L,312L,412L,512L,612L,712L,812L,912L,1012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120001Inst : IEnumerable<long>
{
public static readonly long[] Value=A120001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120001.Bytes);
public long this[int i]=>Value[i];

public static A120001Inst Instance=new A120001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120002
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,6L,-2L,-1L,0L,-1L,0L,0L,0L,-2L,10L,-10L,3L,3L,-4L,2L,-3L,2L,-2L,-1L,10L,-5L,-5L,2L,0L,4L,-5L,0L,3L,-4L,10L,0L,-7L,-3L,2L,1L,-2L,5L,-5L,-1L,10L,-5L,-2L,-1L,-2L,1L,0L,0L,0L,-1L,10L,0L,0L,-5L,-3L,-2L,1L,1L,1L,-3L,10L,-5L,-2L,-1L,0L,-1L,-1L,1L,0L,-1L,10L,0L,-7L,7L,-8L,1L,-2L,-1L,1L,-1L,10L,-5L,5L,-8L,0L,3L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120002Inst : IEnumerable<long>
{
public static readonly long[] Value=A120002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120002.Bytes);
public long this[int i]=>Value[i];

public static A120002Inst Instance=new A120002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120003
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,22L,28L,33L,38L,42L,46L,50L,54L,56L,68L,70L,75L,83L,87L,93L,96L,101L,104L,106L,118L,125L,127L,131L,135L,143L,146L,149L,155L,157L,169L,181L,186L,188L,192L,197L,200L,208L,211L,213L,225L,232L,237L,241L,243L,246L,249L,252L,255L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120003Inst : IEnumerable<long>
{
public static readonly long[] Value=A120003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120003.Bytes);
public long this[int i]=>Value[i];

public static A120003Inst Instance=new A120003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120004
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,4L,4L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120004Inst : IEnumerable<long>
{
public static readonly long[] Value=A120004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120004.Bytes);
public long this[int i]=>Value[i];

public static A120004Inst Instance=new A120004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120005
{
public static readonly long[] Value={ 0L,11L,10L,100L,102L,120L,1012L,1023L,1120L,1230L,10123L,10234L,11203L,11230L,12340L,101234L,102345L,111230L,112130L,112340L,123450L,1012345L,1023456L,1112130L,1112340L,1121340L,1123450L,1234560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120005Inst : IEnumerable<long>
{
public static readonly long[] Value=A120005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120005.Bytes);
public long this[int i]=>Value[i];

public static A120005Inst Instance=new A120005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120006
{
public static readonly long[] Value={ 1L,3L,6L,13L,24L,42L,73L,123L,201L,320L,504L,774L,1172L,1755L,2592L,3789L,5478L,7851L,11146L,15696L,21942L,30456L,42000L,57546L,78403L,106212L,143124L,191925L,256146L,340320L,450204L,593163L,778416L,1017698L,1325784L,1721157L,2227050L,2872422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120006Inst : IEnumerable<long>
{
public static readonly long[] Value=A120006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120006.Bytes);
public long this[int i]=>Value[i];

public static A120006Inst Instance=new A120006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120007
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,0L,7L,2L,3L,0L,11L,0L,13L,0L,0L,2L,17L,0L,19L,0L,0L,0L,23L,0L,5L,0L,3L,0L,29L,0L,31L,2L,0L,0L,0L,0L,37L,0L,0L,0L,41L,0L,43L,0L,0L,0L,47L,0L,7L,0L,0L,0L,53L,0L,0L,0L,0L,0L,59L,0L,61L,0L,0L,2L,0L,0L,67L,0L,0L,0L,71L,0L,73L,0L,0L,0L,0L,0L,79L,0L,3L,0L,83L,0L,0L,0L,0L,0L,89L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120007Inst : IEnumerable<long>
{
public static readonly long[] Value=A120007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120007.Bytes);
public long this[int i]=>Value[i];

public static A120007Inst Instance=new A120007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120008
{
public static readonly long[] Value={ 1L,3L,0L,6L,3L,2L,6L,0L,109L,103L,6L,100001L,0L,9L,1006L,17L,6L,0L,3L,6L,5L,103L,0L,1000002L,6L,129L,100012L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120008Inst : IEnumerable<long>
{
public static readonly long[] Value=A120008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120008.Bytes);
public long this[int i]=>Value[i];

public static A120008Inst Instance=new A120008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120009
{
public static readonly long[] Value={ 1L,1L,1L,0L,-6L,-33L,-143L,-572L,-2210L,-8398L,-31654L,-118864L,-445740L,-1671525L,-6273135L,-23571780L,-88704330L,-334347090L,-1262330850L,-4773905760L,-18083762580L,-68611922730L,-260725306374L,-992233959480L,-3781513867796L,-14431491699548L,-55147299002348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120009Inst : IEnumerable<long>
{
public static readonly long[] Value=A120009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120009.Bytes);
public long this[int i]=>Value[i];

public static A120009Inst Instance=new A120009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120010
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,18L,53L,158L,481L,1491L,4688L,14913L,47913L,155261L,506881L,1665643L,5504988L,18287338L,61027991L,204499397L,687808931L,2321177071L,7857504876L,26673769002L,90783820081L,309720079813L,1058984020333L,3628267267358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120010Inst : IEnumerable<long>
{
public static readonly long[] Value=A120010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120010.Bytes);
public long this[int i]=>Value[i];

public static A120010Inst Instance=new A120010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120011
{
public static readonly long[] Value={ 4L,3L,3L,0L,1L,2L,7L,0L,1L,8L,9L,2L,2L,1L,9L,3L,2L,3L,3L,8L,1L,8L,6L,1L,5L,8L,5L,3L,7L,6L,4L,6L,8L,0L,9L,1L,7L,3L,5L,7L,0L,1L,3L,1L,3L,4L,5L,2L,5L,9L,5L,1L,5L,7L,0L,1L,3L,9L,5L,1L,7L,4L,4L,8L,6L,2L,9L,8L,3L,2L,5L,4L,2L,2L,7L,2L,0L,0L,0L,0L,9L,2L,7L,0L,2L,8L,6L,5L,4L,6L,6L,8L,9L,3L,1L,2L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120011Inst : IEnumerable<long>
{
public static readonly long[] Value=A120011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120011.Bytes);
public long this[int i]=>Value[i];

public static A120011Inst Instance=new A120011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120012
{
public static readonly long[] Value={ 1L,3L,9L,24L,42L,-87L,-1575L,-12240L,-77730L,-449994L,-2470278L,-13101228L,-67823484L,-344888619L,-1729791975L,-8581375224L,-42194252106L,-205940062998L,-998899022898L,-4819339232640L,-23144643733428L,-110703908388582L,-527633003316726L,-2506857120078336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120012Inst : IEnumerable<long>
{
public static readonly long[] Value=A120012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120012.Bytes);
public long this[int i]=>Value[i];

public static A120012Inst Instance=new A120012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120013
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,0L,1L,4L,9L,6L,-6L,1L,5L,16L,24L,-4L,-33L,1L,6L,25L,60L,42L,-100L,-143L,1L,7L,36L,120L,192L,-87L,-664L,-572L,1L,8L,49L,210L,530L,360L,-1575L,-3514L,-2210L,1L,9L,64L,336L,1164L,1955L,-1568L,-12240L,-16916L,-8398L,1L,10L,81L,504L,2226L,5892L,3785L,-26804L,-77730L,-77388L,-31654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120013Inst : IEnumerable<long>
{
public static readonly long[] Value=A120013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120013.Bytes);
public long this[int i]=>Value[i];

public static A120013Inst Instance=new A120013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120014
{
public static readonly BigInteger[] Value={ 1L,2L,9L,60L,530L,5892L,79681L,1276760L,23729310L,502780580L,11974950746L,316917570312L,9230453871756L,293492484431720L,10117826259791025L,375952605020796720L,14980065429077943734UL,BigInteger.Parse("637215061582781559972") };
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
public class A120014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120014.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120014Inst Instance=new A120014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120015
{
public static readonly BigInteger[] Value={ 1L,3L,16L,120L,1164L,13965L,200960L,3387636L,65644780L,1440018822L,35314018656L,958109355632L,28508766348664L,923461269689985L,32357613376995840L,1219728800410342556L,BigInteger.Parse("49225886778689380044"),BigInteger.Parse("2118029584754948604618") };
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
public class A120015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120015Inst Instance=new A120015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120016
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,106L,982L,11383L,159595L,2636590L,50278058L,1088631886L,26409797526L,710034913212L,20963748887980L,674521750652735L,23497037813799795L,881180319357526102L,BigInteger.Parse("35400836754598975554"),BigInteger.Parse("1516991897621421273210") };
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
public class A120016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120016Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120016.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120016.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120016Inst Instance=new A120016Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120017
{
public static readonly long[] Value={ 1L,2L,4L,10L,32L,116L,440L,1708L,6760L,27232L,111392L,461536L,1933024L,8170400L,34807232L,149304080L,644298592L,2795216576L,12184415360L,53338632256L,234393350912L,1033614750080L,4572427361536L,20285780245120L,90238113332992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120017Inst : IEnumerable<long>
{
public static readonly long[] Value=A120017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120017.Bytes);
public long this[int i]=>Value[i];

public static A120017Inst Instance=new A120017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120018
{
public static readonly long[] Value={ 1L,3L,9L,30L,114L,480L,2157L,10092L,48525L,238143L,1187952L,6006171L,30710553L,158535975L,825143145L,4325320191L,22814398392L,120999555588L,644878190175L,3451975941243L,18550877091063L,100047282676491L,541314936448764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120018Inst : IEnumerable<long>
{
public static readonly long[] Value=A120018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120018.Bytes);
public long this[int i]=>Value[i];

public static A120018Inst Instance=new A120018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120019
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,2L,1L,4L,9L,10L,6L,1L,5L,16L,30L,32L,18L,1L,6L,25L,68L,114L,116L,53L,1L,7L,36L,130L,312L,480L,440L,158L,1L,8L,49L,222L,710L,1536L,2157L,1708L,481L,1L,9L,64L,350L,1416L,4070L,8000L,10092L,6760L,1491L,1L,10L,81L,520L,2562L,9348L,24365L,43472L,48525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120019Inst : IEnumerable<long>
{
public static readonly long[] Value=A120019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120019.Bytes);
public long this[int i]=>Value[i];

public static A120019Inst Instance=new A120019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120020
{
public static readonly BigInteger[] Value={ 1L,2L,9L,68L,710L,9348L,148085L,2740672L,58033953L,1383923040L,36705564368L,1071911496576L,34179790156473L,1181725089179936L,44035415728886145L,1759481180119564288L,BigInteger.Parse("75042973200676887772"),BigInteger.Parse("3402984761691650083008") };
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
public class A120020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120020Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120020.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120020.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120020Inst Instance=new A120020Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120021
{
public static readonly BigInteger[] Value={ 1L,3L,16L,130L,1416L,19236L,312512L,5906502L,127313320L,3082645951L,82848394752L,2447576485341L,78846484722208L,2750891289611235L,103344880800464896L,4159577854374314795L,BigInteger.Parse("178587276548655542112"),BigInteger.Parse("8147334149686335230068") };
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
public class A120021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120021Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120021.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120021.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120021Inst Instance=new A120021Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120022
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,142L,1558L,21155L,342584L,6448217L,138392304L,3336869488L,89325958048L,2629214627421L,84408934941424L,2935694381925743L,109967573757472768L,4414292541216287516L,BigInteger.Parse("189054708982869449056") };
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
public class A120022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120022Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120022.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120022.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120022Inst Instance=new A120022Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120023
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,10L,11L,17L,20L,28L,41L,48L,57L,58L,59L,71L,208L,972L,993L,1432L,2001L,2175L,2622L,3419L,3720L,4860L,7300L,7402L,14988L,15774L,18510L,22872L,52139L,77028L,149025L,172170L,239699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120023Inst : IEnumerable<long>
{
public static readonly long[] Value=A120023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120023.Bytes);
public long this[int i]=>Value[i];

public static A120023Inst Instance=new A120023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120024
{
public static readonly long[] Value={ 1L,2L,3L,4L,2175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120024Inst : IEnumerable<long>
{
public static readonly long[] Value=A120024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120024.Bytes);
public long this[int i]=>Value[i];

public static A120024Inst Instance=new A120024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120025
{
public static readonly long[] Value={ 2L,1L,4L,2L,2L,1L,1L,6L,2L,4L,1L,1L,1L,4L,1L,1L,2L,14L,2L,3L,2L,1L,1L,2L,2L,2L,1L,1L,8L,1L,2L,1L,1L,2L,2L,1L,3L,2L,11L,979L,3L,19L,1L,1L,39L,2L,1L,4L,4L,4L,1L,27L,1L,1L,22L,6L,1L,8L,13L,1L,1L,1L,24L,5L,3L,21L,8L,3L,1L,2L,1L,2L,2L,1L,2L,1L,1L,2L,4L,1L,6L,1L,2L,1L,1L,12L,77L,2L,1L,4L,2L,4L,2L,1L,2L,1L,35L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120025Inst : IEnumerable<long>
{
public static readonly long[] Value=A120025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120025.Bytes);
public long this[int i]=>Value[i];

public static A120025Inst Instance=new A120025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120026
{
public static readonly long[] Value={ 2L,8L,1L,5L,4L,1L,8L,2L,5L,4L,5L,8L,1L,3L,4L,5L,7L,0L,2L,8L,1L,1L,3L,3L,6L,0L,0L,7L,4L,1L,1L,4L,8L,6L,6L,0L,4L,2L,3L,4L,3L,0L,9L,3L,0L,4L,0L,6L,4L,6L,5L,3L,9L,5L,0L,6L,1L,9L,1L,7L,9L,7L,2L,1L,4L,8L,3L,6L,9L,7L,5L,9L,0L,0L,0L,5L,5L,6L,5L,7L,1L,1L,6L,2L,1L,4L,9L,2L,2L,4L,3L,2L,7L,1L,7L,5L,9L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120026Inst : IEnumerable<long>
{
public static readonly long[] Value=A120026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120026.Bytes);
public long this[int i]=>Value[i];

public static A120026Inst Instance=new A120026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120027
{
public static readonly long[] Value={ 1L,3L,5L,9L,15L,25L,27L,45L,75L,125L,81L,135L,225L,375L,625L,243L,405L,675L,1125L,1875L,3125L,729L,1215L,2025L,3375L,5625L,9375L,15625L,2187L,3645L,6075L,10125L,16875L,28125L,46875L,78125L,6561L,10935L,18225L,30375L,50625L,84375L,140625L,234375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120027Inst : IEnumerable<long>
{
public static readonly long[] Value=A120027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120027.Bytes);
public long this[int i]=>Value[i];

public static A120027Inst Instance=new A120027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120028
{
public static readonly BigInteger[] Value={ 3L,6L,10L,2L,8388607L,1L,1L,10L,5L,1L,BigInteger.Parse("19802808501020211999048785114"),1L,5L,1L,5L,2L,2L,10L,4L,1L,142L,3L,1L,1L,1L,1L,1L,2L,13L,16L,1L,83L,2L,4L,1L,15L,1L,62L,1L,20L,1L,2L,1L,1L,1L,9L,1L,1L,1L,13L,2L,3L,1L,4L,1L,5L,1L,1L,1L,5L,7L,1L,27L,1L,2L,4L,3L,1L,3L,3L,1L,7L,2L,1L,1L,91L,11L,1L,2L,4L,4L };
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
public class A120028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120028Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A120028.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A120028.Bytes);
public BigInteger this[int i]=>Value[i];

public static A120028Inst Instance=new A120028Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120029
{
public static readonly long[] Value={ 3L,1L,6L,4L,0L,6L,2L,4L,9L,9L,9L,9L,2L,7L,2L,4L,0L,4L,2L,3L,8L,5L,8L,1L,6L,5L,7L,4L,0L,9L,6L,6L,7L,9L,6L,8L,7L,4L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,7L,3L,2L,6L,6L,6L,4L,0L,8L,4L,0L,0L,2L,7L,1L,0L,9L,3L,8L,0L,5L,8L,0L,2L,1L,0L,6L,6L,1L,4L,9L,6L,1L,8L,0L,7L,9L,6L,6L,8L,9L,9L,1L,2L,2L,2L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120029Inst : IEnumerable<long>
{
public static readonly long[] Value=A120029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120029.Bytes);
public long this[int i]=>Value[i];

public static A120029Inst Instance=new A120029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120030
{
public static readonly long[] Value={ 1L,-4L,-4L,32L,-4L,-104L,32L,192L,-4L,-292L,-104L,480L,32L,-680L,192L,832L,-4L,-1160L,-292L,1440L,-104L,-1536L,480L,2112L,32L,-2604L,-680L,2624L,192L,-3368L,832L,3840L,-4L,-3840L,-1160L,4992L,-292L,-5480L,1440L,5440L,-104L,-6728L,-1536L,7392L,480L,-7592L,2112L,8832L,32L,-9412L,-2604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120030Inst : IEnumerable<long>
{
public static readonly long[] Value=A120030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120030.Bytes);
public long this[int i]=>Value[i];

public static A120030Inst Instance=new A120030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120031
{
public static readonly long[] Value={ 1L,1L,2L,5L,40L,4L,48L,312L,1664L,14144L,56576L,28288L,226304L,217600L,870400L,2524160L,80773120L,2375680L,1900544L,35160064L,1406402560L,28831252480L,115325009920L,288312524800L,4613000396800L,92260007936L,369040031744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120031Inst : IEnumerable<long>
{
public static readonly long[] Value=A120031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120031.Bytes);
public long this[int i]=>Value[i];

public static A120031Inst Instance=new A120031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120032
{
public static readonly long[] Value={ 1L,2L,3L,9L,63L,7L,77L,539L,2695L,24255L,92169L,48279L,370139L,370139L,1427679L,4283037L,132774147L,4023459L,3129357L,59457783L,2318853537L,48695924277L,190356794901L,486467364747L,7621322047703L,155537184647L,610184339769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120032Inst : IEnumerable<long>
{
public static readonly long[] Value=A120032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120032.Bytes);
public long this[int i]=>Value[i];

public static A120032Inst Instance=new A120032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120033
{
public static readonly long[] Value={ 0L,1L,1L,4L,4L,12L,20L,40L,75L,147L,285L,535L,1062L,2006L,3918L,7548L,14595L,28293L,54761L,106452L,206421L,401522L,780966L,1520543L,2962226L,5777162L,11272279L,22009839L,43006972L,84077384L,164482781L,321944211L,630487562L,1235382703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120033Inst : IEnumerable<long>
{
public static readonly long[] Value=A120033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120033.Bytes);
public long this[int i]=>Value[i];

public static A120033Inst Instance=new A120033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120034
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,6L,17L,30L,65L,131L,257L,536L,1033L,2132L,4187L,8370L,16656L,33123L,65855L,130460L,259431L,513737L,1019223L,2019783L,4003071L,7930375L,15712418L,31126184L,61654062L,122137206L,241920724L,479226157L,949313939L,1880589368L,3725662783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120034Inst : IEnumerable<long>
{
public static readonly long[] Value=A120034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120034.Bytes);
public long this[int i]=>Value[i];

public static A120034Inst Instance=new A120034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120035
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,5L,7L,20L,37L,81L,173L,344L,736L,1461L,3065L,6208L,12643L,25662L,52014L,105487L,212566L,430007L,865650L,1744136L,3508335L,7053390L,14167804L,28441899L,57065447L,114418462L,229341261L,459442819L,920097130L,1841946718L,3686197728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120035Inst : IEnumerable<long>
{
public static readonly long[] Value=A120035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120035.Bytes);
public long this[int i]=>Value[i];

public static A120035Inst Instance=new A120035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120036
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,5L,8L,21L,41L,91L,199L,403L,873L,1767L,3740L,7709L,15910L,32759L,67185L,138063L,281566L,576165L,1173435L,2390366L,4860357L,9873071L,20033969L,40612221L,82266433L,166483857L,336713632L,680482316L,1374413154L,2774347425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120036Inst : IEnumerable<long>
{
public static readonly long[] Value=A120036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120036.Bytes);
public long this[int i]=>Value[i];

public static A120036Inst Instance=new A120036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120037
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,5L,8L,22L,44L,96L,215L,439L,959L,1967L,4185L,8735L,18143L,37695L,77939L,161479L,332008L,684502L,1404867L,2882712L,5904454L,12078654L,24682057L,50375102L,102724466L,209250102L,425921989L,866187909L,1760280404L,3574740094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120037Inst : IEnumerable<long>
{
public static readonly long[] Value=A120037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120037.Bytes);
public long this[int i]=>Value[i];

public static A120037Inst Instance=new A120037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120038
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,5L,8L,22L,46L,99L,224L,461L,1013L,2093L,4459L,9388L,19603L,40946L,85087L,177200L,366248L,758686L,1565038L,3226717L,6641105L,13648299L,28018956L,57445770L,117667693L,240751326L,492172466L,1005221914L,2051468099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120038Inst : IEnumerable<long>
{
public static readonly long[] Value=A120038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120038.Bytes);
public long this[int i]=>Value[i];

public static A120038Inst Instance=new A120038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120039
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,5L,8L,22L,47L,101L,229L,473L,1044L,2171L,4634L,9796L,20513L,43020L,89684L,187361L,388633L,807508L,1671160L,3455934L,7135226L,14708436L,30286472L,62280024L,127944070L,262543635L,538266791L,1102507513L,2256357137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120039Inst : IEnumerable<long>
{
public static readonly long[] Value=A120039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120039.Bytes);
public long this[int i]=>Value[i];

public static A120039Inst Instance=new A120039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120040
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,5L,8L,22L,47L,102L,232L,482L,1062L,2217L,4738L,10051L,21083L,44315L,92608L,193824L,402936L,838879L,1739794L,3605077L,7457977L,15404202L,31781036L,65481376L,134777594L,277096118L,569173839L,1168002568L,2394834166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120040Inst : IEnumerable<long>
{
public static readonly long[] Value=A120040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120040.Bytes);
public long this[int i]=>Value[i];

public static A120040Inst Instance=new A120040Inst();

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